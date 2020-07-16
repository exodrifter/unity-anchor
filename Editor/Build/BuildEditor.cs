using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditorInternal;
using UnityEngine;

namespace Exodrifter.Anchor.Editor
{
	public class BuildEditor : EditorWindow
	{
		private static List<BuildConfig> configs = new List<BuildConfig>();
		private ReorderableList list;

		private Vector2 leftPos;
		private Vector2 rightPos;
		private bool options;

		private void Awake()
		{
			configs = BuildUtil.LoadSettings();
		}

		private void OnEnable()
		{
			configs = BuildUtil.LoadSettings();
		}

		private void OnFocus()
		{
			configs = BuildUtil.LoadSettings();
		}

		[DidReloadScripts]
		private static void OnReload()
		{
			configs = BuildUtil.LoadSettings();
		}

		private void OnGUI()
		{
			XGUI.BeginVertical();
			XGUI.BeginHorizontal(XGUI.ExpandHeight(true));
			XGUI.BeginScrollView(ref leftPos, XGUI.Width(250));

			if (list == null)
			{
				list = new ReorderableList(configs, typeof(BuildConfig));
				list.drawHeaderCallback += (rect) =>
				{
					XGUI.Label(rect, "Build Configs");
				};
				list.drawElementCallback += (rect, index, active, focused) =>
				{
					XGUI.Label(rect, configs[index].folder);
				};
				list.onAddCallback += (list) =>
				{
					var config = new BuildConfig();
					config.folder = "New Build Config";
					list.list.Add(config);
				};
			}
			list.DoLayoutList();

			if (XGUI.Button("Build Defaults"))
			{
				BuildDefaults();
			}
			if (XGUI.Button("Open Build Folder"))
			{
				OpenBuildFolder();
			}

			XGUI.EndScrollView();
			XGUI.BeginScrollView(ref rightPos);

			if (list.index >= 0)
			{
				var config = (BuildConfig)list.list[list.index];
				DrawConfig(config);
			}
			else
			{
				XGUI.enabled = false;
				XGUI.BeginHorizontal();
				XGUI.FlexibleSpace();
				XGUI.BeginVertical();
				XGUI.Space(20);
				XGUI.Label("No build selected");
				XGUI.EndVertical();
				XGUI.FlexibleSpace();
				XGUI.EndHorizontal();
				XGUI.enabled = true;
			}

			XGUI.EndScrollView();
			XGUI.EndHorizontal();

			XGUI.enabled = false;
			XGUI.Label(BuildUtil.GetSettingsPath());
			XGUI.enabled = true;

			XGUI.EndVertical();

			if (XGUI.changed)
			{
				configs = (List<BuildConfig>)list.list;
				BuildUtil.SaveSettings(configs);
			}

			XGUI.Reset();
		}

		private void DrawConfig(BuildConfig config)
		{
			var targetSupported = BuildUtil.IsTargetSupported(config.target);
			if (!targetSupported && config.target != 0)
			{
				var message = string.Format(
					"Build module for {0} is not installed!",
					config.target
				);
				XGUI.HelpBox(message, MessageType.Warning);
			}

			XGUI.enabled = targetSupported;
			if (XGUI.Button(XGUI.Content("Build")))
			{
				EditorApplication.delayCall += () =>
					BuildUtil.Build((BuildConfig)list.list[list.index]);
			}
			XGUI.enabled = true;

			XGUI.TextField("Folder", ref config.folder);
			XGUI.TextField("Exe Name", ref config.exeName);
			XGUI.Toggle("Default Build", ref config.defaultBuild);
			config.target = (BuildTarget)XGUI.EnumPopup("Target Platform", config.target);

			options = XGUI.Foldout(options, "Build Options");
			if (options)
			{
				DrawBuildOptions(config);
			}
		}

		private void DrawBuildOptions(BuildConfig config)
		{
			DrawBuildOption(config, BuildOptions.Development, "Development Build");
			DrawBuildInfo("Build a development version of the player.");
			DrawBuildOption(config, BuildOptions.AutoRunPlayer, "Auto Run Player");
			DrawBuildInfo("Run the built player.");
			DrawBuildOption(config, BuildOptions.ShowBuiltPlayer, "Show Built Player");
			DrawBuildInfo("Show the built player.");
			DrawBuildOption(config, BuildOptions.BuildAdditionalStreamedScenes, "Build Additional Streamed Scenes");
			DrawBuildInfo("Build a compressed asset bundle that contains streamed scenes loadable with the WWW class.");
			DrawBuildOption(config, BuildOptions.AcceptExternalModificationsToPlayer, "Accept External Modifications to Player");
			DrawBuildInfo("Used when building Xcode (iOS) or Eclipse (Android) projects.");
			DrawBuildOption(config, BuildOptions.ConnectWithProfiler, "Connect With Profiler");
			DrawBuildInfo("Start the player with a connection to the profiler in the editor.");
			DrawBuildOption(config, BuildOptions.AllowDebugging, "Allow Debugging");
			DrawBuildInfo("Allow script debuggers to attach to the player remotely.");
			DrawBuildOption(config, BuildOptions.SymlinkLibraries, "Symlink Libraries");
			DrawBuildInfo("Symlink runtime libraries when generating iOS Xcode project. (Faster iteration time).");
			DrawBuildOption(config, BuildOptions.UncompressedAssetBundle, "Uncompressed Asset Bundle");
			DrawBuildInfo("Don't compress the data when creating the asset bundle.");
			DrawBuildOption(config, BuildOptions.ConnectToHost, "Connect to Host");
			DrawBuildInfo("Sets the Player to connect to the Editor.");
			DrawBuildOption(config, BuildOptions.EnableHeadlessMode, "Enable Headless Mode");
			DrawBuildInfo("Build headless Linux standalone.");
			DrawBuildOption(config, BuildOptions.BuildScriptsOnly, "Build Scripts Only");
			DrawBuildInfo("Build only the scripts of a project.");
			DrawBuildOption(config, BuildOptions.ForceEnableAssertions, "Force Enable Assertions");
			DrawBuildInfo("Include assertions in the build. By default, the assertions are only included in development builds.");
			DrawBuildOption(config, BuildOptions.CompressWithLz4, "Compress with Lz4");
			DrawBuildInfo("Use chunk-based Lz4 compression when building the Player.");
			DrawBuildOption(config, BuildOptions.StrictMode, "Strict Mode");
			DrawBuildInfo("Do not allow the build to succeed if any errors are reporting during it.");
		}

		private void DrawBuildOption(BuildConfig config, BuildOptions option, string label)
		{
			var value = (config.options & option) > 0;
			XGUI.ToggleLeft(label, ref value);

			if (value)
			{
				config.options |= option;
			}
			else
			{
				config.options &= ~option;
			}
		}

		private void DrawBuildInfo(string info)
		{
			XGUI.BeginHorizontal();
			XGUI.Space(20);
			XGUI.enabled = false;
			XGUI.LabelField(info);
			XGUI.enabled = true;
			XGUI.EndHorizontal();
		}

		#region Menu Items

		[MenuItem("Util/Build/Build Defaults", false, 0)]
		public static void BuildDefaults()
		{
			var configs = BuildUtil.LoadSettings();

			foreach (var config in configs)
			{
				if (config.defaultBuild)
				{
					BuildUtil.Build(config);
				}
			}
		}

		[MenuItem("Util/Build/Open Build Folder", false, 1)]
		public static void OpenBuildFolder()
		{
			Process.Start("file://" + BuildUtil.GetBuildPath());
		}

		[MenuItem("Util/Build/Settings", false, 2)]
		public static void OpenSettingsWindow()
		{
			var window = GetWindow<BuildEditor>();
			window.titleContent = new GUIContent("Build Settings");
			window.Show();
		}

		#endregion
	}
}
