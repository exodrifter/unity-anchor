using Exodrifter.Anchor.Editor;
using UnityEditor;
using UnityEngine;

namespace Exodrifter.Anchor
{
	[CustomPropertyDrawer(typeof(Pool))]
	public class PoolPropertyDrawer : PropertyDrawer
	{
		public override void OnGUI
			(Rect rect, SerializedProperty prop, GUIContent label)
		{
			rect = XGUI.PrefixLabel(rect, label);

			rect.height = XGUI.LineHeight;
			XGUI.PropertyField(rect, prop.FindPropertyRelative("factory.prefab"), XGUI.None(), false);

			rect.y += XGUI.LineHeight + XGUI.LineSpacing;
			XGUI.PropertyField(rect, prop.FindPropertyRelative("factory.parent"), XGUI.None(), false);
		}

		public override float GetPropertyHeight
			(SerializedProperty prop, GUIContent label)
		{
			return XGUI.LineHeight * 2 + XGUI.LineSpacing;
		}
	}
}
