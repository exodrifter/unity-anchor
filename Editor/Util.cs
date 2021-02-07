using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class Util
{
	#region Shortcut

	[MenuItem("Util/Shortcut/Data Path", false, 11)]
	public static void DataPath()
	{
		Process.Start("file://" + Application.dataPath);
	}

	[MenuItem("Util/Shortcut/Persistent Data Path", false, 12)]
	public static void PersistentDataPath()
	{
		Process.Start("file://" + Application.persistentDataPath);
	}

	[MenuItem("Util/Shortcut/Streaming Assets Path", false, 13)]
	public static void StreamingAssetsPath()
	{
		Process.Start("file://" + Application.streamingAssetsPath);
	}

	[MenuItem("Util/Shortcut/Temporary Cache Path", false, 14)]
	public static void TemporaryCachePath()
	{
		Process.Start("file://" + Application.temporaryCachePath);
	}

	#endregion

	/// <summary>
	/// This shortcut should be manually used when the editor version is
	/// updated, foring all assets to be reserialized to the newest
	/// serialization format used by the new editor. This will help minimize
	/// changes in diffs when intentional changes are made.
	/// </summary>
	[MenuItem("Util/Force Reserialize", false, 100)]
	private static void ForceReserialize()
	{
		AssetDatabase.ForceReserializeAssets();
	}
}
