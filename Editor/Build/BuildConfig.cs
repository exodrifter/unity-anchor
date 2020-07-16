using System;
using UnityEditor;

namespace Exodrifter.Anchor.Editor
{
	[Serializable]
	public class BuildConfig
	{
		public string folder;
		public string exeName;
		public bool defaultBuild;
		public BuildTarget target;
		public BuildOptions options;
	}
}
