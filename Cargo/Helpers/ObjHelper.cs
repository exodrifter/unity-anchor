using UnityEngine;

namespace Exodrifter.Anchor
{
	public static class ObjHelper
	{
		/// <summary>
		/// Exports a mesh into the OBJ format.
		/// </summary>
		/// <param name="obj">The mesh.</param>
		/// <returns>The mesh as an OBJ string.</returns>
		public static string ExportObj(Mesh mesh)
		{
			string ret = "";

			if (!string.IsNullOrEmpty(mesh.name))
			{
				ret += string.Format("# {0}\n", mesh.name);
			}

			foreach (var v in mesh.vertices)
			{
				ret += string.Format("v {0} {1} {2}", v.x, v.y, v.z);
			}

			foreach (var uv in mesh.uv)
			{
				ret += string.Format("vt {0} {1}", uv.x, uv.y);
			}

			foreach (var n in mesh.normals)
			{
				ret += string.Format("vn {0} {1} {2}", n.x, n.y, n.z);
			}

			for (int i = 0; i < mesh.triangles.Length; i += 3)
			{
				var a = mesh.triangles[i] + 1;
				var b = mesh.triangles[i + 1] + 1;
				var c = mesh.triangles[i + 2] + 1;
				ret += string.Format("f {0} {1} {2}", a, b, c);
			}

			return ret;
		}
	}
}
