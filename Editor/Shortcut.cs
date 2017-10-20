using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class Shortcut
{
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
}
