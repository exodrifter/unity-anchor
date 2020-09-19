using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Exodrifter.Anchor.Editor
{
	public static class BuildUtil
	{
		/// <summary>
		/// Returns the path to the build folder.
		/// </summary>
		/// <returns>The path to the build folder.</returns>
		public static string GetBuildPath()
		{
			var file = "../Builds/";
			return Path.GetFullPath(Path.Combine(Application.dataPath, file));
		}

		/// <summary>
		/// Returns the path to the build settings file.
		/// </summary>
		/// <returns>The path to the build settings file.</returns>
		public static string GetSettingsPath()
		{
			var file = "../ProjectSettings/Anchor/BuildSettings.json";
			return Path.GetFullPath(Path.Combine(Application.dataPath, file));
		}

		/// <summary>
		/// Returns true if the build module is installed for the specified
		/// <see cref="BuildTarget"/>.
		/// </summary>
		/// <param name="target">The build target to check.</param>
		/// <returns>True if the build module is installed.</returns>
		public static bool IsTargetSupported(BuildTarget target)
		{
			var manager = Type.GetType(
				"UnityEditor.Modules.ModuleManager, UnityEditor.dll");

			var flags = BindingFlags.Static | BindingFlags.NonPublic;
			var fn = manager.GetMethod("GetTargetStringFromBuildTarget", flags);
			var targetStr = fn.Invoke(null, new object[] { target });

			fn = manager.GetMethod("IsPlatformSupportLoaded", flags);
			return (bool)fn.Invoke(null, new object[] { targetStr });
		}

		#region Build

		/// <summary>
		/// Builds the specified config.
		/// </summary>
		/// <param name="config">The build config to use.</param>
		public static void Build(BuildConfig config)
		{
			if (!IsTargetSupported(config.target))
			{
				Debug.LogError(string.Format(
					"Failed to build {0}; {0} build module is not installed",
					config.target
				));

				return;
			}

			// Do the build
			var path = Path.Combine(GetBuildPath(), config.folder);
			var options = new BuildPlayerOptions();
			options.target = config.target;
			options.scenes = EditorBuildSettings.scenes.Select(x => x.path).ToArray();
			options.locationPathName = Path.Combine(path,
				GetExeFilename(config.exeName, config.target));

			try
			{
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				BuildPipeline.BuildPlayer(options);
			}
			catch (Exception e)
			{
				Debug.LogError(string.Format(
					"Failed to build {0}; {1}",
					config.folder, e));
				return;
			}

			// Zip the build
			var zipFilename = path + ".zip";
			if (File.Exists(zipFilename))
			{
				File.Delete(zipFilename);
			}

			try
			{
				using (var zip = ZipStorer.Create(zipFilename, ""))
				{
					zip.AddDirectory(
						ZipStorer.Compression.Deflate, path, config.folder, "");
				}
			}
			catch (Exception e)
			{
				Debug.LogError(string.Format(
					"Failed to zip {0}; {1}",
					config.folder, e));

				File.Delete(zipFilename);
				return;
			}
		}

		private static string GetExeFilename(string exeName, BuildTarget target)
		{
			switch (target)
			{
				default:
					throw new ArgumentException("Unknown target " + target);
				case BuildTarget.Android:
					return Path.ChangeExtension(exeName, "apk");
				case BuildTarget.StandaloneWindows:
				case BuildTarget.StandaloneWindows64:
					return Path.ChangeExtension(exeName, "exe");
				case BuildTarget.StandaloneOSX:
					return Path.ChangeExtension(exeName, "app");
				case BuildTarget.StandaloneLinux64:
					return Path.ChangeExtension(exeName, "x86_64");
				case BuildTarget.WebGL:
					return exeName;
			}
		}

		#endregion

#region Settings

		public static List<BuildConfig> LoadSettings()
		{
			var path = GetSettingsPath();
			if (!File.Exists(path))
			{
				return new List<BuildConfig>();
			}

			try
			{
				var json = File.ReadAllText(path);
				return Import.Json<List<BuildConfig>>(json);
			}
			catch (Exception e)
			{
				Debug.LogError(string.Format(
					"Failed to load settings from \"{0}\"; {1}",
					path, e
				));

				return new List<BuildConfig>();
			}
		}

		public static void SaveSettings(List<BuildConfig> configs)
		{
			var path = GetSettingsPath();

			try
			{
				var json = Export.Json(configs, true);
				Directory.CreateDirectory(Path.GetDirectoryName(path));
				File.WriteAllText(path, json);
			}
			catch (Exception e)
			{
				Debug.LogError(string.Format(
					"Failed to write settings to \"{0}\"; {1}",
					path, e
				));
			}
		}

#endregion
	}
}
