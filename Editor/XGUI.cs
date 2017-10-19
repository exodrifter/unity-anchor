using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Internal;

namespace Exodrifter.Anchor.Editor
{
	public static class XGUI
	{
		#region GUI

		public static Color color
		{
			get
			{
				return GUI.color;
			}
			set
			{
				oldColor = oldColor ?? GUI.color;
				GUI.color = value;
			}
		}
		private static Color? oldColor = null;

		public static Color backgroundColor
		{
			get
			{
				return GUI.backgroundColor;
			}
			set
			{
				oldBackgroundColor = oldBackgroundColor ?? GUI.color;
				GUI.backgroundColor = value;
			}
		}
		private static Color? oldBackgroundColor = null;

		public static Color contentColor
		{
			get
			{
				return GUI.contentColor;
			}
			set
			{
				oldContentColor = oldContentColor ?? GUI.color;
				GUI.contentColor = value;
			}
		}
		private static Color? oldContentColor = null;

		public static bool changed
		{
			get
			{
				return GUI.changed;
			}
			set
			{
				oldChanged = oldChanged ?? GUI.changed;
				GUI.changed = value;
			}
		}
		private static bool? oldChanged = null;

		public static bool enabled
		{
			get
			{
				return GUI.enabled;
			}
			set
			{
				oldEnabled = oldEnabled ?? GUI.enabled;
				GUI.enabled = value;
			}
		}
		private static bool? oldEnabled = null;

		public static int depth
		{
			get
			{
				return GUI.depth;
			}
			set
			{
				oldDepth = oldDepth ?? GUI.depth;
				GUI.depth = value;
			}
		}
		private static int? oldDepth = null;

		public static GUISkin skin
		{
			get
			{
				return GUI.skin;
			}
			set
			{
				oldSkin = oldSkin ?? GUI.skin;
				GUI.skin = value;
			}
		}
		private static GUISkin oldSkin = null;

		public static Matrix4x4 matrix
		{
			get
			{
				return GUI.matrix;
			}
			set
			{
				oldMatrix = oldMatrix ?? GUI.matrix;
				GUI.matrix = value;
			}
		}
		private static Matrix4x4? oldMatrix = null;

		public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUI.BeginClip(position, scrollOffset, renderOffset, resetOffset);
		}

		public static void BeginClip(Rect position)
		{
			GUI.BeginClip(position);
		}

		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
			GUI.BeginGroup(position, image, style);
		}

		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
			GUI.BeginGroup(position, text, style);
		}

		public static void BeginGroup(Rect position, GUIStyle style)
		{
			GUI.BeginGroup(position, style);
		}

		public static void BeginGroup(Rect position, GUIContent content)
		{
			GUI.BeginGroup(position, content);
		}

		public static void BeginGroup(Rect position, Texture image)
		{
			GUI.BeginGroup(position, image);
		}

		public static void BeginGroup(Rect position, string text)
		{
			GUI.BeginGroup(position, text);
		}

		public static void BeginGroup(Rect position)
		{
			GUI.BeginGroup(position);
		}

		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			GUI.BeginGroup(position, content, style);
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect);
		}

		public static void BeginScrollView(Rect position, ref Vector2 scrollPosition, Rect viewRect)
		{
			scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect);
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical);
		}

		public static void BeginScrollView(Rect position, ref Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical);
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
		}

		public static void BeginScrollView(Rect position, ref Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
		}

		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar);
		}

		public static void BeginScrollView(Rect position, ref Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			scrollPosition = GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar);
		}

		public static void Box(Rect position, string text, GUIStyle style)
		{
			GUI.Box(position, text, style);
		}

		public static void Box(Rect position, string text)
		{
			GUI.Box(position, text);
		}

		public static void Box(Rect position, Texture image)
		{
			GUI.Box(position, image);
		}

		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
			GUI.Box(position, content, style);
		}

		public static void Box(Rect position, Texture image, GUIStyle style)
		{
			GUI.Box(position, image, style);
		}

		public static void Box(Rect position, GUIContent content)
		{
			GUI.Box(position, content);
		}

		public static void BringWindowToBack(int windowID)
		{
			GUI.BringWindowToBack(windowID);
		}

		public static void BringWindowToFront(int windowID)
		{
			GUI.BringWindowToFront(windowID);
		}

		public static bool Button(Rect position, string text)
		{
			return GUI.Button(position, text);
		}

		public static bool Button(Rect position, Texture image)
		{
			return GUI.Button(position, image);
		}

		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.Button(position, content, style);
		}

		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			return GUI.Button(position, image, style);
		}

		public static bool Button(Rect position, GUIContent content)
		{
			return GUI.Button(position, content);
		}

		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return GUI.Button(position, text, style);
		}

		public static void DragWindow()
		{
			GUI.DragWindow();
		}

		public static void DragWindow(Rect position)
		{
			GUI.DragWindow(position);
		}

		public static void DrawTexture(Rect position, Texture image)
		{
			GUI.DrawTexture(position, image);
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect);
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend);
		}

		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
			GUI.DrawTexture(position, image, scaleMode);
		}

		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords, alphaBlend);
		}

		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords);
		}

		public static void EndClip()
		{
			GUI.EndClip();
		}

		public static void EndGroup()
		{
			GUI.EndGroup();
		}

		public static void EndScrollView(bool handleScrollWheel)
		{
			GUI.EndScrollView(handleScrollWheel);
		}

		public static void FocusControl(string name)
		{
			GUI.FocusControl(name);
		}

		public static void FocusWindow(int windowID)
		{
			GUI.FocusWindow(windowID);
		}

		public static string GetNameOfFocusedControl()
		{
			return GUI.GetNameOfFocusedControl();
		}

		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return GUI.HorizontalScrollbar(position, value, size, leftValue, rightValue, style);
		}

		public static void HorizontalScrollbar(Rect position, ref float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			value = GUI.HorizontalScrollbar(position, value, size, leftValue, rightValue, style);
		}

		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return GUI.HorizontalScrollbar(position, value, size, leftValue, rightValue);
		}

		public static void HorizontalScrollbar(Rect position, ref float value, float size, float leftValue, float rightValue)
		{
			value = GUI.HorizontalScrollbar(position, value, size, leftValue, rightValue);
		}

		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.HorizontalSlider(position, value, leftValue, rightValue, slider, thumb);
		}

		public static void HorizontalSlider(Rect position, ref float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			value = GUI.HorizontalSlider(position, value, leftValue, rightValue, slider, thumb);
		}

		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return GUI.HorizontalSlider(position, value, leftValue, rightValue);
		}

		public static void HorizontalSlider(Rect position, ref float value, float leftValue, float rightValue)
		{
			value = GUI.HorizontalSlider(position, value, leftValue, rightValue);
		}

		public static void Label(Rect position, Texture image, GUIStyle style)
		{
			GUI.Label(position, image, style);
		}

		public static void Label(Rect position, string text, GUIStyle style)
		{
			GUI.Label(position, text, style);
		}

		public static void Label(Rect position, GUIContent content)
		{
			GUI.Label(position, content);
		}

		public static void Label(Rect position, Texture image)
		{
			GUI.Label(position, image);
		}

		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			GUI.Label(position, content, style);
		}

		public static void Label(Rect position, string text)
		{
			GUI.Label(position, text);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			return GUI.ModalWindow(id, clientRect, func, image);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style)
		{
			return GUI.ModalWindow(id, clientRect, func, content, style);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			return GUI.ModalWindow(id, clientRect, func, image, style);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			return GUI.ModalWindow(id, clientRect, func, text, style);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			return GUI.ModalWindow(id, clientRect, func, content);
		}

		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			return GUI.ModalWindow(id, clientRect, func, text);
		}

		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return GUI.PasswordField(position, password, maskChar);
		}

		public static void PasswordField(Rect position, ref string password, char maskChar)
		{
			password = GUI.PasswordField(position, password, maskChar);
		}

		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength);
		}

		public static void PasswordField(Rect position, ref string password, char maskChar, int maxLength)
		{
			password = GUI.PasswordField(position, password, maskChar, maxLength);
		}

		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, style);
		}

		public static void PasswordField(Rect position, ref string password, char maskChar, GUIStyle style)
		{
			password = GUI.PasswordField(position, password, maskChar, style);
		}

		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength, style);
		}

		public static void PasswordField(Rect position, ref string password, char maskChar, int maxLength, GUIStyle style)
		{
			password = GUI.PasswordField(position, password, maskChar, maxLength, style);
		}

		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.RepeatButton(position, content, style);
		}

		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return GUI.RepeatButton(position, image, style);
		}

		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return GUI.RepeatButton(position, text, style);
		}

		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return GUI.RepeatButton(position, content);
		}

		public static bool RepeatButton(Rect position, Texture image)
		{
			return GUI.RepeatButton(position, image);
		}

		public static bool RepeatButton(Rect position, string text)
		{
			return GUI.RepeatButton(position, text);
		}

		public static void ScrollTo(Rect position)
		{
			GUI.ScrollTo(position);
		}

		public static bool ScrollTowards(Rect position, float maxDelta)
		{
			return GUI.ScrollTowards(position, maxDelta);
		}

		public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount)
		{
			return GUI.SelectionGrid(position, selected, content, xCount);
		}

		public static void SelectionGrid(Rect position, ref int selected, GUIContent[] content, int xCount)
		{
			selected = GUI.SelectionGrid(position, selected, content, xCount);
		}

		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, texts, xCount, style);
		}

		public static void SelectionGrid(Rect position, ref int selected, string[] texts, int xCount, GUIStyle style)
		{
			selected = GUI.SelectionGrid(position, selected, texts, xCount, style);
		}

		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount)
		{
			return GUI.SelectionGrid(position, selected, images, xCount);
		}

		public static void SelectionGrid(Rect position, ref int selected, Texture[] images, int xCount)
		{
			selected = GUI.SelectionGrid(position, selected, images, xCount);
		}

		public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, images, xCount, style);
		}

		public static void SelectionGrid(Rect position, ref int selected, Texture[] images, int xCount, GUIStyle style)
		{
			selected = GUI.SelectionGrid(position, selected, images, xCount, style);
		}

		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, contents, xCount, style);
		}

		public static void SelectionGrid(Rect position, ref int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			selected = GUI.SelectionGrid(position, selected, contents, xCount, style);
		}

		public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount)
		{
			return GUI.SelectionGrid(position, selected, texts, xCount);
		}

		public static void SelectionGrid(Rect position, ref int selected, string[] texts, int xCount)
		{
			selected = GUI.SelectionGrid(position, selected, texts, xCount);
		}

		public static void SetNextControlName(string name)
		{
			GUI.SetNextControlName(name);
		}

		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			return GUI.Slider(position, value, size, start, end, slider, thumb, horiz, id);
		}

		public static void Slider(Rect position, ref float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id)
		{
			value = GUI.Slider(position, value, size, start, end, slider, thumb, horiz, id);
		}

		public static string TextArea(Rect position, string text)
		{
			return GUI.TextArea(position, text);
		}

		public static void TextArea(Rect position, ref string text)
		{
			text = GUI.TextArea(position, text);
		}

		public static string TextArea(Rect position, string text, int maxLength)
		{
			return GUI.TextArea(position, text, maxLength);
		}

		public static void TextArea(Rect position, ref string text, int maxLength)
		{
			text = GUI.TextArea(position, text, maxLength);
		}

		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			return GUI.TextArea(position, text, style);
		}

		public static void TextArea(Rect position, ref string text, GUIStyle style)
		{
			text = GUI.TextArea(position, text, style);
		}

		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			return GUI.TextArea(position, text, maxLength, style);
		}

		public static void TextArea(Rect position, ref string text, int maxLength, GUIStyle style)
		{
			text = GUI.TextArea(position, text, maxLength, style);
		}

		public static string TextField(Rect position, string text, GUIStyle style)
		{
			return GUI.TextField(position, text, style);
		}

		public static void TextField(Rect position, ref string text, GUIStyle style)
		{
			text = GUI.TextField(position, text, style);
		}

		public static string TextField(Rect position, string text, int maxLength)
		{
			return GUI.TextField(position, text, maxLength);
		}

		public static void TextField(Rect position, ref string text, int maxLength)
		{
			text = GUI.TextField(position, text, maxLength);
		}

		public static string TextField(Rect position, string text)
		{
			return GUI.TextField(position, text);
		}

		public static void TextField(Rect position, ref string text)
		{
			text = GUI.TextField(position, text);
		}

		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			return GUI.TextField(position, text, maxLength, style);
		}

		public static void TextField(Rect position, ref string text, int maxLength, GUIStyle style)
		{
			text = GUI.TextField(position, text, maxLength, style);
		}

		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return GUI.Toggle(position, value, image, style);
		}

		public static void Toggle(Rect position, ref bool value, Texture image, GUIStyle style)
		{
			value = GUI.Toggle(position, value, image, style);
		}

		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			return GUI.Toggle(position, value, content, style);
		}

		public static void Toggle(Rect position, ref bool value, GUIContent content, GUIStyle style)
		{
			value = GUI.Toggle(position, value, content, style);
		}

		public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			return GUI.Toggle(position, id, value, content, style);
		}

		public static void Toggle(Rect position, int id, ref bool value, GUIContent content, GUIStyle style)
		{
			value = GUI.Toggle(position, id, value, content, style);
		}

		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return GUI.Toggle(position, value, content);
		}

		public static void Toggle(Rect position, ref bool value, GUIContent content)
		{
			value = GUI.Toggle(position, value, content);
		}

		public static bool Toggle(Rect position, bool value, string text)
		{
			return GUI.Toggle(position, value, text);
		}

		public static void Toggle(Rect position, ref bool value, string text)
		{
			value = GUI.Toggle(position, value, text);
		}

		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return GUI.Toggle(position, value, text, style);
		}

		public static void Toggle(Rect position, ref bool value, string text, GUIStyle style)
		{
			value = GUI.Toggle(position, value, text, style);
		}

		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return GUI.Toggle(position, value, image);
		}

		public static void Toggle(Rect position, ref bool value, Texture image)
		{
			value = GUI.Toggle(position, value, image);
		}

		public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, contents, style);
		}

		public static void Toolbar(Rect position, ref int selected, GUIContent[] contents, GUIStyle style)
		{
			selected = GUI.Toolbar(position, selected, contents, style);
		}

		public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, texts, style);
		}

		public static void Toolbar(Rect position, ref int selected, string[] texts, GUIStyle style)
		{
			selected = GUI.Toolbar(position, selected, texts, style);
		}

		public static int Toolbar(Rect position, int selected, GUIContent[] content)
		{
			return GUI.Toolbar(position, selected, content);
		}

		public static void Toolbar(Rect position, ref int selected, GUIContent[] content)
		{
			selected = GUI.Toolbar(position, selected, content);
		}

		public static int Toolbar(Rect position, int selected, string[] texts)
		{
			return GUI.Toolbar(position, selected, texts);
		}

		public static void Toolbar(Rect position, ref int selected, string[] texts)
		{
			selected = GUI.Toolbar(position, selected, texts);
		}

		public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, images, style);
		}

		public static void Toolbar(Rect position, ref int selected, Texture[] images, GUIStyle style)
		{
			selected = GUI.Toolbar(position, selected, images, style);
		}

		public static int Toolbar(Rect position, int selected, Texture[] images)
		{
			return GUI.Toolbar(position, selected, images);
		}

		public static void Toolbar(Rect position, ref int selected, Texture[] images)
		{
			selected = GUI.Toolbar(position, selected, images);
		}

		public static void UnfocusWindow()
		{
			GUI.UnfocusWindow();
		}

		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return GUI.VerticalScrollbar(position, value, size, topValue, bottomValue);
		}

		public static void VerticalScrollbar(Rect position, ref float value, float size, float topValue, float bottomValue)
		{
			value = GUI.VerticalScrollbar(position, value, size, topValue, bottomValue);
		}

		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return GUI.VerticalScrollbar(position, value, size, topValue, bottomValue, style);
		}

		public static void VerticalScrollbar(Rect position, ref float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			value = GUI.VerticalScrollbar(position, value, size, topValue, bottomValue, style);
		}

		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return GUI.VerticalSlider(position, value, topValue, bottomValue);
		}

		public static void VerticalSlider(Rect position, ref float value, float topValue, float bottomValue)
		{
			value = GUI.VerticalSlider(position, value, topValue, bottomValue);
		}

		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.VerticalSlider(position, value, topValue, bottomValue, slider, thumb);
		}

		public static void VerticalSlider(Rect position, ref float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			value = GUI.VerticalSlider(position, value, topValue, bottomValue, slider, thumb);
		}

		#endregion

		#region EditorGUI

		public static bool showMixedValue
		{
			get
			{
				return EditorGUI.showMixedValue;
			}
			set
			{
				oldShowMixedValue = oldShowMixedValue ?? EditorGUI.showMixedValue;
				EditorGUI.showMixedValue = value;
			}
		}
		private static bool? oldShowMixedValue;

		public static bool actionKey
		{
			get { return EditorGUI.actionKey; }
		}

		public static int indentLevel
		{
			get
			{
				return EditorGUI.indentLevel;
			}
			set
			{
				oldIndentLevel = oldIndentLevel ?? EditorGUI.indentLevel;
				EditorGUI.indentLevel = value;
			}
		}
		private static int? oldIndentLevel;

		public static void BeginChangeCheck()
		{
			EditorGUI.BeginChangeCheck();
		}

		public static void BeginDisabledGroup(bool disabled)
		{
			EditorGUI.BeginDisabledGroup(disabled);
		}

		public static GUIContent BeginProperty(Rect totalPosition, GUIContent label, SerializedProperty property)
		{
			return EditorGUI.BeginProperty(totalPosition, label, property);
		}

		public static Bounds BoundsField(Rect position, Bounds value)
		{
			return EditorGUI.BoundsField(position, value);
		}

		public static Bounds BoundsField(Rect position, string label, Bounds value)
		{
			return EditorGUI.BoundsField(position, label, value);
		}

		public static Bounds BoundsField(Rect position, GUIContent label, Bounds value)
		{
			return EditorGUI.BoundsField(position, label, value);
		}

		public static Color ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, ColorPickerHDRConfig hdrConfig)
		{
			return EditorGUI.ColorField(position, label, value, showEyedropper, showAlpha, hdr, hdrConfig);
		}

		public static Color ColorField(Rect position, Color value)
		{
			return EditorGUI.ColorField(position, value);
		}

		public static Color ColorField(Rect position, string label, Color value)
		{
			return EditorGUI.ColorField(position, label, value);
		}

		public static Color ColorField(Rect position, GUIContent label, Color value)
		{
			return EditorGUI.ColorField(position, label, value);
		}

		public static void CurveField(Rect position, SerializedProperty property, Color color, Rect ranges, GUIContent label)
		{
			EditorGUI.CurveField(position, property, color, ranges, label);
		}

		public static void CurveField(Rect position, SerializedProperty property, Color color, Rect ranges)
		{
			EditorGUI.CurveField(position, property, color, ranges);
		}

		public static AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value, Color color, Rect ranges)
		{
			return EditorGUI.CurveField(position, label, value, color, ranges);
		}

		public static AnimationCurve CurveField(Rect position, string label, AnimationCurve value, Color color, Rect ranges)
		{
			return EditorGUI.CurveField(position, label, value, color, ranges);
		}

		public static AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value)
		{
			return EditorGUI.CurveField(position, label, value);
		}

		public static AnimationCurve CurveField(Rect position, string label, AnimationCurve value)
		{
			return EditorGUI.CurveField(position, label, value);
		}

		public static AnimationCurve CurveField(Rect position, AnimationCurve value)
		{
			return EditorGUI.CurveField(position, value);
		}

		public static AnimationCurve CurveField(Rect position, AnimationCurve value, Color color, Rect ranges)
		{
			return EditorGUI.CurveField(position, value, color, ranges);
		}

		public static double DelayedDoubleField(Rect position, double value, GUIStyle style)
		{
			return EditorGUI.DelayedDoubleField(position, value, style);
		}

		public static double DelayedDoubleField(Rect position, double value)
		{
			return EditorGUI.DelayedDoubleField(position, value);
		}

		public static double DelayedDoubleField(Rect position, string label, double value)
		{
			return EditorGUI.DelayedDoubleField(position, label, value);
		}

		public static double DelayedDoubleField(Rect position, string label, double value, GUIStyle style)
		{
			return EditorGUI.DelayedDoubleField(position, label, value, style);
		}

		public static double DelayedDoubleField(Rect position, GUIContent label, double value)
		{
			return EditorGUI.DelayedDoubleField(position, label, value);
		}

		public static double DelayedDoubleField(Rect position, GUIContent label, double value, GUIStyle style)
		{
			return EditorGUI.DelayedDoubleField(position, label, value, style);
		}

		public static float DelayedFloatField(Rect position, string label, float value)
		{
			return EditorGUI.DelayedFloatField(position, label, value);
		}

		public static float DelayedFloatField(Rect position, string label, float value, GUIStyle style)
		{
			return EditorGUI.DelayedFloatField(position, label, value, style);
		}

		public static float DelayedFloatField(Rect position, float value, GUIStyle style)
		{
			return EditorGUI.DelayedFloatField(position, value, style);
		}

		public static float DelayedFloatField(Rect position, float value)
		{
			return EditorGUI.DelayedFloatField(position, value);
		}

		public static float DelayedFloatField(Rect position, GUIContent label, float value, GUIStyle style)
		{
			return EditorGUI.DelayedFloatField(position, label, value, style);
		}

		public static void DelayedFloatField(Rect position, SerializedProperty property)
		{
			EditorGUI.DelayedFloatField(position, property);
		}

		public static void DelayedFloatField(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.DelayedFloatField(position, property, label);
		}

		public static float DelayedFloatField(Rect position, GUIContent label, float value)
		{
			return EditorGUI.DelayedFloatField(position, label, value);
		}

		public static int DelayedIntField(Rect position, int value)
		{
			return EditorGUI.DelayedIntField(position, value);
		}

		public static int DelayedIntField(Rect position, int value, GUIStyle style)
		{
			return EditorGUI.DelayedIntField(position, value, style);
		}

		public static int DelayedIntField(Rect position, string label, int value, GUIStyle style)
		{
			return EditorGUI.DelayedIntField(position, label, value, style);
		}

		public static int DelayedIntField(Rect position, GUIContent label, int value)
		{
			return EditorGUI.DelayedIntField(position, label, value);
		}

		public static void DelayedIntField(Rect position, SerializedProperty property)
		{
			EditorGUI.DelayedIntField(position, property);
		}

		public static void DelayedIntField(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.DelayedIntField(position, property, label);
		}

		public static int DelayedIntField(Rect position, string label, int value)
		{
			return EditorGUI.DelayedIntField(position, label, value);
		}

		public static int DelayedIntField(Rect position, GUIContent label, int value, GUIStyle style)
		{
			return EditorGUI.DelayedIntField(position, label, value, style);
		}

		public static string DelayedTextField(Rect position, string label, string text)
		{
			return EditorGUI.DelayedTextField(position, label, text);
		}

		public static string DelayedTextField(Rect position, string text, GUIStyle style)
		{
			return EditorGUI.DelayedTextField(position, text, style);
		}

		public static string DelayedTextField(Rect position, string label, string text, GUIStyle style)
		{
			return EditorGUI.DelayedTextField(position, label, text, style);
		}

		public static string DelayedTextField(Rect position, GUIContent label, string text)
		{
			return EditorGUI.DelayedTextField(position, label, text);
		}

		public static string DelayedTextField(Rect position, GUIContent label, string text, GUIStyle style)
		{
			return EditorGUI.DelayedTextField(position, label, text, style);
		}

		public static void DelayedTextField(Rect position, SerializedProperty property)
		{
			EditorGUI.DelayedTextField(position, property);
		}

		public static string DelayedTextField(Rect position, string text)
		{
			return EditorGUI.DelayedTextField(position, text);
		}

		public static string DelayedTextField(Rect position, GUIContent label, int controlId, string text, GUIStyle style)
		{
			return EditorGUI.DelayedTextField(position, label, controlId, text, style);
		}

		public static void DelayedTextField(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.DelayedTextField(position, property, label);
		}

		public static string DelayedTextField(Rect position, GUIContent label, int controlId, string text)
		{
			return EditorGUI.DelayedTextField(position, label, controlId, text);
		}

		public static double DoubleField(Rect position, GUIContent label, double value, GUIStyle style)
		{
			return EditorGUI.DoubleField(position, label, value, style);
		}

		public static double DoubleField(Rect position, string label, double value, GUIStyle style)
		{
			return EditorGUI.DoubleField(position, label, value, style);
		}

		public static double DoubleField(Rect position, string label, double value)
		{
			return EditorGUI.DoubleField(position, label, value);
		}

		public static double DoubleField(Rect position, double value, GUIStyle style)
		{
			return EditorGUI.DoubleField(position, value, style);
		}

		public static double DoubleField(Rect position, double value)
		{
			return EditorGUI.DoubleField(position, value);
		}

		public static double DoubleField(Rect position, GUIContent label, double value)
		{
			return EditorGUI.DoubleField(position, label, value);
		}

		public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect)
		{
			EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect);
		}

		public static void DrawPreviewTexture(Rect position, Texture image)
		{
			EditorGUI.DrawPreviewTexture(position, image);
		}

		public static void DrawPreviewTexture(Rect position, Texture image, Material mat)
		{
			EditorGUI.DrawPreviewTexture(position, image, mat);
		}

		public static void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode)
		{
			EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode);
		}

		public static void DrawRect(Rect rect, Color color)
		{
			EditorGUI.DrawRect(rect, color);
		}

		public static void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode, float imageAspect)
		{
			EditorGUI.DrawTextureAlpha(position, image, scaleMode, imageAspect);
		}

		public static void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode)
		{
			EditorGUI.DrawTextureAlpha(position, image, scaleMode);
		}

		public static void DrawTextureAlpha(Rect position, Texture image)
		{
			EditorGUI.DrawTextureAlpha(position, image);
		}

		public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode)
		{
			EditorGUI.DrawTextureTransparent(position, image, scaleMode);
		}

		public static void DrawTextureTransparent(Rect position, Texture image)
		{
			EditorGUI.DrawTextureTransparent(position, image);
		}

		public static void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect)
		{
			EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect);
		}

		public static bool DropdownButton(Rect position, GUIContent content, FocusType focusType)
		{
			return EditorGUI.DropdownButton(position, content, focusType);
		}

		public static bool DropdownButton(Rect position, GUIContent content, FocusType focusType, GUIStyle style)
		{
			return EditorGUI.DropdownButton(position, content, focusType, style);
		}

		public static void DropShadowLabel(Rect position, GUIContent content, GUIStyle style)
		{
			EditorGUI.DropShadowLabel(position, content, style);
		}

		public static void DropShadowLabel(Rect position, string text, GUIStyle style)
		{
			EditorGUI.DropShadowLabel(position, text, style);
		}

		public static void DropShadowLabel(Rect position, GUIContent content)
		{
			EditorGUI.DropShadowLabel(position, content);
		}

		public static void DropShadowLabel(Rect position, string text)
		{
			EditorGUI.DropShadowLabel(position, text);
		}

		public static bool EndChangeCheck()
		{
			return EditorGUI.EndChangeCheck();
		}

		public static void EndDisabledGroup()
		{
			EditorGUI.EndDisabledGroup();
		}

		public static void EndProperty()
		{
			EditorGUI.EndProperty();
		}

		public static Enum EnumMaskField(Rect position, string label, Enum enumValue, GUIStyle style)
		{
			return EditorGUI.EnumMaskField(position, label, enumValue, style);
		}

		public static Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue, GUIStyle style)
		{
			return EditorGUI.EnumMaskField(position, label, enumValue, style);
		}

		public static Enum EnumMaskField(Rect position, Enum enumValue)
		{
			return EditorGUI.EnumMaskField(position, enumValue);
		}

		public static Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue)
		{
			return EditorGUI.EnumMaskField(position, label, enumValue);
		}

		public static Enum EnumMaskField(Rect position, string label, Enum enumValue)
		{
			return EditorGUI.EnumMaskField(position, label, enumValue);
		}

		public static Enum EnumMaskField(Rect position, Enum enumValue, GUIStyle style)
		{
			return EditorGUI.EnumMaskField(position, enumValue, style);
		}

		public static Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected, GUIStyle style)
		{
			return EditorGUI.EnumMaskPopup(position, label, selected, style);
		}

		public static Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected)
		{
			return EditorGUI.EnumMaskPopup(position, label, selected);
		}

		public static Enum EnumMaskPopup(Rect position, string label, Enum selected, GUIStyle style)
		{
			return EditorGUI.EnumMaskPopup(position, label, selected, style);
		}

		public static Enum EnumMaskPopup(Rect position, string label, Enum selected)
		{
			return EditorGUI.EnumMaskPopup(position, label, selected);
		}

		public static Enum EnumPopup(Rect position, GUIContent label, Enum selected, GUIStyle style)
		{
			return EditorGUI.EnumPopup(position, label, selected, style);
		}

		public static Enum EnumPopup(Rect position, Enum selected, GUIStyle style)
		{
			return EditorGUI.EnumPopup(position, selected, style);
		}

		public static Enum EnumPopup(Rect position, string label, Enum selected)
		{
			return EditorGUI.EnumPopup(position, label, selected);
		}

		public static Enum EnumPopup(Rect position, string label, Enum selected, GUIStyle style)
		{
			return EditorGUI.EnumPopup(position, label, selected, style);
		}

		public static Enum EnumPopup(Rect position, Enum selected)
		{
			return EditorGUI.EnumPopup(position, selected);
		}

		public static Enum EnumPopup(Rect position, GUIContent label, Enum selected)
		{
			return EditorGUI.EnumPopup(position, label, selected);
		}

		public static float FloatField(Rect position, GUIContent label, float value, GUIStyle style)
		{
			return EditorGUI.FloatField(position, label, value, style);
		}

		public static float FloatField(Rect position, string label, float value, GUIStyle style)
		{
			return EditorGUI.FloatField(position, label, value, style);
		}

		public static float FloatField(Rect position, float value, GUIStyle style)
		{
			return EditorGUI.FloatField(position, value, style);
		}

		public static float FloatField(Rect position, string label, float value)
		{
			return EditorGUI.FloatField(position, label, value);
		}

		public static float FloatField(Rect position, GUIContent label, float value)
		{
			return EditorGUI.FloatField(position, label, value);
		}

		public static float FloatField(Rect position, float value)
		{
			return EditorGUI.FloatField(position, value);
		}

		public static void FocusTextInControl(string name)
		{
			EditorGUI.FocusTextInControl(name);
		}

		public static bool Foldout(Rect position, bool foldout, string content)
		{
			return EditorGUI.Foldout(position, foldout, content);
		}

		public static bool Foldout(Rect position, bool foldout, string content, GUIStyle style)
		{
			return EditorGUI.Foldout(position, foldout, content, style);
		}

		public static bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick)
		{
			return EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
		}

		public static bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick, GUIStyle style)
		{
			return EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
		}

		public static bool Foldout(Rect position, bool foldout, GUIContent content, GUIStyle style)
		{
			return EditorGUI.Foldout(position, foldout, content, style);
		}

		public static bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick)
		{
			return EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
		}

		public static bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick, GUIStyle style)
		{
			return EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
		}

		public static bool Foldout(Rect position, bool foldout, GUIContent content)
		{
			return EditorGUI.Foldout(position, foldout, content);
		}

		public static float GetPropertyHeight(SerializedPropertyType type, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(type, label);
		}

		public static float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, label);
		}

		public static float GetPropertyHeight(SerializedProperty property, GUIContent label, bool includeChildren)
		{
			return EditorGUI.GetPropertyHeight(property, label, includeChildren);
		}

		public static float GetPropertyHeight(SerializedProperty property)
		{
			return EditorGUI.GetPropertyHeight(property);
		}

		public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label)
		{
			EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label);
		}

		public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, int id, GUIStyle style)
		{
			EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id, style);
		}

		public static void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, int id)
		{
			EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id);
		}

		public static void HelpBox(Rect position, string message, MessageType type)
		{
			EditorGUI.HelpBox(position, message, type);
		}

		public static Rect IndentedRect(Rect source)
		{
			return EditorGUI.IndentedRect(source);
		}

		public static void InspectorTitlebar(Rect position, UnityEngine.Object[] targetObjs)
		{
			EditorGUI.InspectorTitlebar(position, targetObjs);
		}

		public static bool InspectorTitlebar(Rect position, bool foldout, UnityEngine.Object[] targetObjs, bool expandable)
		{
			return EditorGUI.InspectorTitlebar(position, foldout, targetObjs, expandable);
		}

		public static bool InspectorTitlebar(Rect position, bool foldout, UnityEngine.Object targetObj, bool expandable)
		{
			return EditorGUI.InspectorTitlebar(position, foldout, targetObj, expandable);
		}

		public static int IntField(Rect position, int value)
		{
			return EditorGUI.IntField(position, value);
		}

		public static int IntField(Rect position, int value, GUIStyle style)
		{
			return EditorGUI.IntField(position, value, style);
		}

		public static int IntField(Rect position, GUIContent label, int value, GUIStyle style)
		{
			return EditorGUI.IntField(position, label, value, style);
		}

		public static int IntField(Rect position, string label, int value, GUIStyle style)
		{
			return EditorGUI.IntField(position, label, value, style);
		}

		public static int IntField(Rect position, GUIContent label, int value)
		{
			return EditorGUI.IntField(position, label, value);
		}

		public static int IntField(Rect position, string label, int value)
		{
			return EditorGUI.IntField(position, label, value);
		}

		public static int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues)
		{
			return EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
		}

		public static int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style)
		{
			return EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
		}

		public static int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues)
		{
			return EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
		}

		public static int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style)
		{
			return EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
		}

		public static int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues)
		{
			return EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
		}

		public static int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style)
		{
			return EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
		}

		public static void IntPopup(Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues)
		{
			EditorGUI.IntPopup(position, property, displayedOptions, optionValues);
		}

		public static int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues)
		{
			return EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
		}

		public static int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style)
		{
			return EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
		}

		public static void IntPopup(Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label)
		{
			EditorGUI.IntPopup(position, property, displayedOptions, optionValues, label);
		}

		public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue, GUIContent label)
		{
			EditorGUI.IntSlider(position, property, leftValue, rightValue, label);
		}

		public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue, string label)
		{
			EditorGUI.IntSlider(position, property, leftValue, rightValue, label);
		}

		public static void IntSlider(Rect position, SerializedProperty property, int leftValue, int rightValue)
		{
			EditorGUI.IntSlider(position, property, leftValue, rightValue);
		}

		public static int IntSlider(Rect position, GUIContent label, int value, int leftValue, int rightValue)
		{
			return EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
		}

		public static int IntSlider(Rect position, string label, int value, int leftValue, int rightValue)
		{
			return EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
		}

		public static int IntSlider(Rect position, int value, int leftValue, int rightValue)
		{
			return EditorGUI.IntSlider(position, value, leftValue, rightValue);
		}

		public static void LabelField(Rect position, string label)
		{
			EditorGUI.LabelField(position, label);
		}

		public static void LabelField(Rect position, string label, string label2, GUIStyle style)
		{
			EditorGUI.LabelField(position, label, label2, style);
		}

		public static void LabelField(Rect position, string label, string label2)
		{
			EditorGUI.LabelField(position, label, label2);
		}

		public static void LabelField(Rect position, GUIContent label, GUIContent label2)
		{
			EditorGUI.LabelField(position, label, label2);
		}

		public static void LabelField(Rect position, GUIContent label, GUIContent label2, GUIStyle style)
		{
			EditorGUI.LabelField(position, label, label2, style);
		}

		public static void LabelField(Rect position, GUIContent label, GUIStyle style)
		{
			EditorGUI.LabelField(position, label, style);
		}

		public static void LabelField(Rect position, GUIContent label)
		{
			EditorGUI.LabelField(position, label);
		}

		public static void LabelField(Rect position, string label, GUIStyle style)
		{
			EditorGUI.LabelField(position, label, style);
		}

		public static int LayerField(Rect position, GUIContent label, int layer)
		{
			return EditorGUI.LayerField(position, label, layer);
		}

		public static int LayerField(Rect position, string label, int layer, GUIStyle style)
		{
			return EditorGUI.LayerField(position, label, layer, style);
		}

		public static int LayerField(Rect position, string label, int layer)
		{
			return EditorGUI.LayerField(position, label, layer);
		}

		public static int LayerField(Rect position, int layer, GUIStyle style)
		{
			return EditorGUI.LayerField(position, layer, style);
		}

		public static int LayerField(Rect position, int layer)
		{
			return EditorGUI.LayerField(position, layer);
		}

		public static int LayerField(Rect position, GUIContent label, int layer, GUIStyle style)
		{
			return EditorGUI.LayerField(position, label, layer, style);
		}

		public static long LongField(Rect position, string label, long value)
		{
			return EditorGUI.LongField(position, label, value);
		}

		public static long LongField(Rect position, long value, GUIStyle style)
		{
			return EditorGUI.LongField(position, value, style);
		}

		public static long LongField(Rect position, string label, long value, GUIStyle style)
		{
			return EditorGUI.LongField(position, label, value, style);
		}

		public static long LongField(Rect position, GUIContent label, long value, GUIStyle style)
		{
			return EditorGUI.LongField(position, label, value, style);
		}

		public static long LongField(Rect position, long value)
		{
			return EditorGUI.LongField(position, value);
		}

		public static long LongField(Rect position, GUIContent label, long value)
		{
			return EditorGUI.LongField(position, label, value);
		}

		public static int MaskField(Rect position, int mask, string[] displayedOptions)
		{
			return EditorGUI.MaskField(position, mask, displayedOptions);
		}

		public static int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions)
		{
			return EditorGUI.MaskField(position, label, mask, displayedOptions);
		}

		public static int MaskField(Rect position, int mask, string[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.MaskField(position, mask, displayedOptions, style);
		}

		public static int MaskField(Rect position, string label, int mask, string[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.MaskField(position, label, mask, displayedOptions, style);
		}

		public static int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.MaskField(position, label, mask, displayedOptions, style);
		}

		public static int MaskField(Rect position, string label, int mask, string[] displayedOptions)
		{
			return EditorGUI.MaskField(position, label, mask, displayedOptions);
		}

		public static void MinMaxSlider(Rect position, string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit)
		{
			EditorGUI.MinMaxSlider(position, label, ref minValue, ref maxValue, minLimit, maxLimit);
		}

		public static void MinMaxSlider(Rect position, GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit)
		{
			EditorGUI.MinMaxSlider(position, label, ref minValue, ref maxValue, minLimit, maxLimit);
		}

		public static void MinMaxSlider(Rect position, ref float minValue, ref float maxValue, float minLimit, float maxLimit)
		{
			EditorGUI.MinMaxSlider(position, ref minValue, ref maxValue, minLimit, maxLimit);
		}

		public static void MultiFloatField(Rect position, GUIContent label, GUIContent[] subLabels, float[] values)
		{
			EditorGUI.MultiFloatField(position, label, subLabels, values);
		}

		public static void MultiFloatField(Rect position, GUIContent[] subLabels, float[] values)
		{
			EditorGUI.MultiFloatField(position, subLabels, values);
		}

		public static void MultiPropertyField(Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator)
		{
			EditorGUI.MultiPropertyField(position, subLabels, valuesIterator);
		}

		public static void MultiPropertyField(Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator, GUIContent label)
		{
			EditorGUI.MultiPropertyField(position, subLabels, valuesIterator, label);
		}

		public static void ObjectField(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.ObjectField(position, property, label);
		}

		public static void ObjectField(Rect position, SerializedProperty property, Type objType)
		{
			EditorGUI.ObjectField(position, property, objType);
		}

		public static void ObjectField(Rect position, SerializedProperty property, Type objType, GUIContent label)
		{
			EditorGUI.ObjectField(position, property, objType, label);
		}

		public static UnityEngine.Object ObjectField(Rect position, UnityEngine.Object obj, Type objType, bool allowSceneObjects)
		{
			return EditorGUI.ObjectField(position, obj, objType, allowSceneObjects);
		}

		public static T ObjectField<T>(Rect position, UnityEngine.Object obj, bool allowSceneObjects) where T : UnityEngine.Object
		{
			return (T)EditorGUI.ObjectField(position, obj, typeof(T), allowSceneObjects);
		}

		public static UnityEngine.Object ObjectField(Rect position, string label, UnityEngine.Object obj, Type objType, bool allowSceneObjects)
		{
			return EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
		}

		public static T ObjectField<T>(Rect position, string label, UnityEngine.Object obj, bool allowSceneObjects) where T : UnityEngine.Object
		{
			return (T)EditorGUI.ObjectField(position, label, obj, typeof(T), allowSceneObjects);
		}

		public static void ObjectField(Rect position, SerializedProperty property)
		{
			EditorGUI.ObjectField(position, property);
		}

		public static UnityEngine.Object ObjectField(Rect position, GUIContent label, UnityEngine.Object obj, Type objType, bool allowSceneObjects)
		{
			return EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
		}

		public static T ObjectField<T>(Rect position, GUIContent label, UnityEngine.Object obj, bool allowSceneObjects) where T : UnityEngine.Object
		{
			return (T)EditorGUI.ObjectField(position, label, obj, typeof(T), allowSceneObjects);
		}

		public static string PasswordField(Rect position, string password)
		{
			return EditorGUI.PasswordField(position, password);
		}

		public static string PasswordField(Rect position, string password, GUIStyle style)
		{
			return EditorGUI.PasswordField(position, password, style);
		}

		public static string PasswordField(Rect position, string label, string password)
		{
			return EditorGUI.PasswordField(position, label, password);
		}

		public static string PasswordField(Rect position, string label, string password, GUIStyle style)
		{
			return EditorGUI.PasswordField(position, label, password, style);
		}

		public static string PasswordField(Rect position, GUIContent label, string password)
		{
			return EditorGUI.PasswordField(position, label, password);
		}

		public static string PasswordField(Rect position, GUIContent label, string password, GUIStyle style)
		{
			return EditorGUI.PasswordField(position, label, password, style);
		}

		public static int Popup(Rect position, int selectedIndex, string[] displayedOptions)
		{
			return EditorGUI.Popup(position, selectedIndex, displayedOptions);
		}

		public static int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions)
		{
			return EditorGUI.Popup(position, selectedIndex, displayedOptions);
		}

		public static int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
		}

		public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
		}

		public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions)
		{
			return EditorGUI.Popup(position, label, selectedIndex, displayedOptions);
		}

		public static int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
		}

		public static int Popup(Rect position, int selectedIndex, string[] displayedOptions, GUIStyle style)
		{
			return EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
		}

		public static int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions)
		{
			return EditorGUI.Popup(position, label, selectedIndex, displayedOptions);
		}

		public static Rect PrefixLabel(Rect totalPosition, int id, GUIContent label, GUIStyle style)
		{
			return EditorGUI.PrefixLabel(totalPosition, id, label, style);
		}

		public static Rect PrefixLabel(Rect totalPosition, GUIContent label)
		{
			return EditorGUI.PrefixLabel(totalPosition, label);
		}

		public static Rect PrefixLabel(Rect totalPosition, int id, GUIContent label)
		{
			return EditorGUI.PrefixLabel(totalPosition, id, label);
		}

		public static Rect PrefixLabel(Rect totalPosition, GUIContent label, GUIStyle style)
		{
			return EditorGUI.PrefixLabel(totalPosition, label, style);
		}

		public static void ProgressBar(Rect position, float value, string text)
		{
			EditorGUI.ProgressBar(position, value, text);
		}

		public static bool PropertyField(Rect position, SerializedProperty property, GUIContent label)
		{
			return EditorGUI.PropertyField(position, property, label);
		}

		public static bool PropertyField(Rect position, SerializedProperty property, bool includeChildren)
		{
			return EditorGUI.PropertyField(position, property, includeChildren);
		}

		public static bool PropertyField(Rect position, SerializedProperty property, GUIContent label, bool includeChildren)
		{
			return EditorGUI.PropertyField(position, property, label, includeChildren);
		}

		public static bool PropertyField(Rect position, SerializedProperty property)
		{
			return EditorGUI.PropertyField(position, property);
		}

		public static Rect RectField(Rect position, Rect value)
		{
			return EditorGUI.RectField(position, value);
		}

		public static Rect RectField(Rect position, string label, Rect value)
		{
			return EditorGUI.RectField(position, label, value);
		}

		public static Rect RectField(Rect position, GUIContent label, Rect value)
		{
			return EditorGUI.RectField(position, label, value);
		}

		public static void SelectableLabel(Rect position, string text)
		{
			EditorGUI.SelectableLabel(position, text);
		}

		public static void SelectableLabel(Rect position, string text, GUIStyle style)
		{
			EditorGUI.SelectableLabel(position, text, style);
		}

		public static float Slider(Rect position, float value, float leftValue, float rightValue)
		{
			return EditorGUI.Slider(position, value, leftValue, rightValue);
		}

		public static float Slider(Rect position, GUIContent label, float value, float leftValue, float rightValue)
		{
			return EditorGUI.Slider(position, label, value, leftValue, rightValue);
		}

		public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue)
		{
			EditorGUI.Slider(position, property, leftValue, rightValue);
		}

		public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue, string label)
		{
			EditorGUI.Slider(position, property, leftValue, rightValue, label);
		}

		public static float Slider(Rect position, string label, float value, float leftValue, float rightValue)
		{
			return EditorGUI.Slider(position, label, value, leftValue, rightValue);
		}

		public static void Slider(Rect position, SerializedProperty property, float leftValue, float rightValue, GUIContent label)
		{
			EditorGUI.Slider(position, property, leftValue, rightValue, label);
		}

		public static string TagField(Rect position, string tag, GUIStyle style)
		{
			return EditorGUI.TagField(position, tag, style);
		}

		public static string TagField(Rect position, GUIContent label, string tag, GUIStyle style)
		{
			return EditorGUI.TagField(position, label, tag, style);
		}

		public static string TagField(Rect position, string tag)
		{
			return EditorGUI.TagField(position, tag);
		}

		public static string TagField(Rect position, string label, string tag, GUIStyle style)
		{
			return EditorGUI.TagField(position, label, tag, style);
		}

		public static string TagField(Rect position, GUIContent label, string tag)
		{
			return EditorGUI.TagField(position, label, tag);
		}

		public static string TagField(Rect position, string label, string tag)
		{
			return EditorGUI.TagField(position, label, tag);
		}

		public static string TextField(Rect position, GUIContent label, string text)
		{
			return EditorGUI.TextField(position, label, text);
		}

		public static string TextField(Rect position, GUIContent label, string text, GUIStyle style)
		{
			return EditorGUI.TextField(position, label, text, style);
		}

		public static string TextField(Rect position, string label, string text)
		{
			return EditorGUI.TextField(position, label, text);
		}

		public static string TextField(Rect position, string label, string text, GUIStyle style)
		{
			return EditorGUI.TextField(position, label, text, style);
		}

		public static bool Toggle(Rect position, bool value)
		{
			return EditorGUI.Toggle(position, value);
		}

		public static bool Toggle(Rect position, string label, bool value)
		{
			return EditorGUI.Toggle(position, label, value);
		}

		public static bool Toggle(Rect position, bool value, GUIStyle style)
		{
			return EditorGUI.Toggle(position, value, style);
		}

		public static bool Toggle(Rect position, string label, bool value, GUIStyle style)
		{
			return EditorGUI.Toggle(position, label, value, style);
		}

		public static bool Toggle(Rect position, GUIContent label, bool value)
		{
			return EditorGUI.Toggle(position, label, value);
		}

		public static bool Toggle(Rect position, GUIContent label, bool value, GUIStyle style)
		{
			return EditorGUI.Toggle(position, label, value, style);
		}

		public static bool ToggleLeft(Rect position, GUIContent label, bool value)
		{
			return EditorGUI.ToggleLeft(position, label, value);
		}

		public static bool ToggleLeft(Rect position, GUIContent label, bool value, GUIStyle labelStyle)
		{
			return EditorGUI.ToggleLeft(position, label, value, labelStyle);
		}

		public static bool ToggleLeft(Rect position, string label, bool value)
		{
			return EditorGUI.ToggleLeft(position, label, value);
		}

		public static bool ToggleLeft(Rect position, string label, bool value, GUIStyle labelStyle)
		{
			return EditorGUI.ToggleLeft(position, label, value, labelStyle);
		}

		public static Vector2 Vector2Field(Rect position, string label, Vector2 value)
		{
			return EditorGUI.Vector2Field(position, label, value);
		}

		public static Vector2 Vector2Field(Rect position, GUIContent label, Vector2 value)
		{
			return EditorGUI.Vector2Field(position, label, value);
		}

		public static Vector3 Vector3Field(Rect position, GUIContent label, Vector3 value)
		{
			return EditorGUI.Vector3Field(position, label, value);
		}

		public static Vector3 Vector3Field(Rect position, string label, Vector3 value)
		{
			return EditorGUI.Vector3Field(position, label, value);
		}

		public static Vector4 Vector4Field(Rect position, string label, Vector4 value)
		{
			return EditorGUI.Vector4Field(position, label, value);
		}

		public static Vector4 Vector4Field(Rect position, GUIContent label, Vector4 value)
		{
			return EditorGUI.Vector4Field(position, label, value);
		}

		#endregion

		#region GUILayout

		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, content, style);
		}

		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, image, style);
		}

		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, text, style);
		}

		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, style);
		}

		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, content);
		}

		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, image);
		}

		public static void BeginArea(Rect screenRect)
		{
			GUILayout.BeginArea(screenRect);
		}

		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, text);
		}

		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, style, options);
		}

		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, style, options);
		}

		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, style, options);
		}

		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, options);
		}

		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, options);
		}

		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, options);
		}

		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, style, options);
		}

		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, style, options);
		}

		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, options);
		}

		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, options);
		}

		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, options);
		}

		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, style, options);
		}

		public static void EndArea()
		{
			GUILayout.EndArea();
		}

		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return GUILayout.ExpandHeight(expand);
		}

		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return GUILayout.ExpandWidth(expand);
		}

		public static void FlexibleSpace()
		{
			GUILayout.FlexibleSpace();
		}

		public static GUILayoutOption Height(float height)
		{
			return GUILayout.Height(height);
		}

		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, options);
		}

		public static void HorizontalScrollbar(ref float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, options);
		}

		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, options);
		}

		public static void HorizontalScrollbar(ref float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			value = GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, options);
		}

		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		public static void HorizontalSlider(ref float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			value = GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, options);
		}

		public static void HorizontalSlider(ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = GUILayout.HorizontalSlider(value, leftValue, rightValue, options);
		}

		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, style, options);
		}

		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, options);
		}

		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, options);
		}

		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, options);
		}

		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, style, options);
		}

		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, style, options);
		}

		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return GUILayout.MaxHeight(maxHeight);
		}

		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return GUILayout.MaxWidth(maxWidth);
		}

		public static GUILayoutOption MinHeight(float minHeight)
		{
			return GUILayout.MinHeight(minHeight);
		}

		public static GUILayoutOption MinWidth(float minWidth)
		{
			return GUILayout.MinWidth(minWidth);
		}

		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, options);
		}

		public static void PasswordField(ref string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			password = GUILayout.PasswordField(password, maskChar, maxLength, options);
		}

		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, options);
		}

		public static void PasswordField(ref string password, char maskChar, params GUILayoutOption[] options)
		{
			password = GUILayout.PasswordField(password, maskChar, options);
		}

		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, style, options);
		}

		public static void PasswordField(ref string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			password = GUILayout.PasswordField(password, maskChar, style, options);
		}

		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, style, options);
		}

		public static void PasswordField(ref string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			password = GUILayout.PasswordField(password, maskChar, maxLength, style, options);
		}

		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, options);
		}

		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, options);
		}

		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, style, options);
		}

		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, style, options);
		}

		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, style, options);
		}

		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, options);
		}

		public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, options);
		}

		public static void SelectionGrid(ref int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, texts, xCount, options);
		}

		public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, options);
		}

		public static void SelectionGrid(ref int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, images, xCount, options);
		}

		public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, contents, xCount, style, options);
		}

		public static void SelectionGrid(ref int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, contents, xCount, style, options);
		}

		public static int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, style, options);
		}

		public static void SelectionGrid(ref int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, images, xCount, style, options);
		}

		public static int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, style, options);
		}

		public static void SelectionGrid(ref int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, texts, xCount, style, options);
		}

		public static int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, options);
		}

		public static void SelectionGrid(ref int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
		{
			selected = GUILayout.SelectionGrid(selected, content, xCount, options);
		}

		public static void Space(float pixels)
		{
			GUILayout.Space(pixels);
		}

		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, options);
		}

		public static void Toggle(ref bool value, Texture image, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, image, options);
		}

		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, style, options);
		}

		public static void Toggle(ref bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, content, style, options);
		}

		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, style, options);
		}

		public static void Toggle(ref bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, text, style, options);
		}

		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, style, options);
		}

		public static void Toggle(ref bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, image, style, options);
		}

		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, options);
		}

		public static void Toggle(ref bool value, GUIContent content, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, content, options);
		}

		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, options);
		}

		public static void Toggle(ref bool value, string text, params GUILayoutOption[] options)
		{
			value = GUILayout.Toggle(value, text, options);
		}

		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, options);
		}

		public static void Toolbar(ref int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, contents, style, options);
		}

		public static int Toolbar(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, options);
		}

		public static void Toolbar(ref int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, texts, style, options);
		}

		public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, options);
		}

		public static void Toolbar(ref int selected, string[] texts, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, texts, options);
		}

		public static int Toolbar(int selected, Texture[] images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, options);
		}

		public static void Toolbar(ref int selected, Texture[] images, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, images, options);
		}

		public static int Toolbar(int selected, GUIContent[] content, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, content, options);
		}

		public static void Toolbar(ref int selected, GUIContent[] content, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, content, options);
		}

		public static int Toolbar(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, options);
		}

		public static void Toolbar(ref int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = GUILayout.Toolbar(selected, images, style, options);
		}

		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, options);
		}

		public static void VerticalScrollbar(ref float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			value = GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, options);
		}

		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, options);
		}

		public static void VerticalScrollbar(ref float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			value = GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, options);
		}

		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, options);
		}

		public static void VerticalSlider(ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = GUILayout.VerticalSlider(value, leftValue, rightValue, options);
		}

		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		public static void VerticalSlider(ref float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			value = GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		public static GUILayoutOption Width(float width)
		{
			return GUILayout.Width(width);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, style, options);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, style, options);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, style, options);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, options);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, options);
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, options);
		}

		#endregion

		#region EditorGUILayout

		public static bool BeginFadeGroup(float value)
		{
			return EditorGUILayout.BeginFadeGroup(value);
		}

		public static Rect BeginHorizontal(params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginHorizontal(options);
		}

		public static Rect BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginHorizontal(style, options);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginScrollView(scrollPosition, options);
		}

		public static void BeginScrollView(ref Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, options);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
		}

		public static void BeginScrollView(ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
		}

		public static void BeginScrollView(ref Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginScrollView(scrollPosition, style, options);
		}

		public static void BeginScrollView(ref Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, style, options);
		}

		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
		}

		public static void BeginScrollView(ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
		}

		public static bool BeginToggleGroup(GUIContent label, bool toggle)
		{
			return EditorGUILayout.BeginToggleGroup(label, toggle);
		}

		public static void BeginToggleGroup(GUIContent label, ref bool toggle)
		{
			toggle = EditorGUILayout.BeginToggleGroup(label, toggle);
		}

		public static bool BeginToggleGroup(string label, bool toggle)
		{
			return EditorGUILayout.BeginToggleGroup(label, toggle);
		}

		public static void BeginToggleGroup(string label, ref bool toggle)
		{
			toggle = EditorGUILayout.BeginToggleGroup(label, toggle);
		}

		public static Rect BeginVertical(params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginVertical(options);
		}

		public static Rect BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BeginVertical(style, options);
		}

		public static Bounds BoundsField(Bounds value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BoundsField(value, options);
		}

		public static void BoundsField(ref Bounds value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.BoundsField(value, options);
		}

		public static Bounds BoundsField(string label, Bounds value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BoundsField(label, value, options);
		}

		public static void BoundsField(string label, ref Bounds value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.BoundsField(label, value, options);
		}

		public static Bounds BoundsField(GUIContent label, Bounds value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.BoundsField(label, value, options);
		}

		public static void BoundsField(GUIContent label, ref Bounds value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.BoundsField(label, value, options);
		}

		public static Color ColorField(string label, Color value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ColorField(label, value, options);
		}

		public static void ColorField(string label, ref Color value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ColorField(label, value, options);
		}

		public static Color ColorField(Color value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ColorField(value, options);
		}

		public static void ColorField(ref Color value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ColorField(value, options);
		}

		public static Color ColorField(GUIContent label, Color value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ColorField(label, value, options);
		}

		public static void ColorField(GUIContent label, ref Color value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ColorField(label, value, options);
		}

		public static Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, ColorPickerHDRConfig hdrConfig, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ColorField(label, value, showEyedropper, showAlpha, hdr, hdrConfig, options);
		}

		public static void ColorField(GUIContent label, ref Color value, bool showEyedropper, bool showAlpha, bool hdr, ColorPickerHDRConfig hdrConfig, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ColorField(label, value, showEyedropper, showAlpha, hdr, hdrConfig, options);
		}

		public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(label, value, options);
		}

		public static void CurveField(GUIContent label, ref AnimationCurve value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(label, value, options);
		}

		public static AnimationCurve CurveField(AnimationCurve value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(value, options);
		}

		public static void CurveField(ref AnimationCurve value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(value, options);
		}

		public static AnimationCurve CurveField(AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(value, color, ranges, options);
		}

		public static void CurveField(ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(value, color, ranges, options);
		}

		public static AnimationCurve CurveField(string label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(label, value, color, ranges, options);
		}

		public static void CurveField(string label, ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(label, value, color, ranges, options);
		}

		public static AnimationCurve CurveField(string label, AnimationCurve value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(label, value, options);
		}

		public static void CurveField(string label, ref AnimationCurve value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(label, value, options);
		}

		public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			return EditorGUILayout.CurveField(label, value, color, ranges, options);
		}

		public static void CurveField(GUIContent label, ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.CurveField(label, value, color, ranges, options);
		}

		public static void CurveField(SerializedProperty property, Color color, Rect ranges, params GUILayoutOption[] options)
		{
			EditorGUILayout.CurveField(property, color, ranges, options);
		}

		public static void CurveField(SerializedProperty property, Color color, Rect ranges, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.CurveField(property, color, ranges, label, options);
		}

		public static double DelayedDoubleField(double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(value, style, options);
		}

		public static void DelayedDoubleField(ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(value, style, options);
		}

		public static double DelayedDoubleField(double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(value, options);
		}

		public static void DelayedDoubleField(ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(value, options);
		}

		public static double DelayedDoubleField(string label, double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(label, value, options);
		}

		public static void DelayedDoubleField(string label, ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(label, value, options);
		}

		public static double DelayedDoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(label, value, style, options);
		}

		public static void DelayedDoubleField(GUIContent label, ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(label, value, style, options);
		}

		public static double DelayedDoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(label, value, style, options);
		}

		public static void DelayedDoubleField(string label, ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(label, value, style, options);
		}

		public static double DelayedDoubleField(GUIContent label, double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedDoubleField(label, value, options);
		}

		public static void DelayedDoubleField(GUIContent label, ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedDoubleField(label, value, options);
		}

		public static void DelayedFloatField(SerializedProperty property, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedFloatField(property, options);
		}

		public static float DelayedFloatField(float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(value, options);
		}

		public static void DelayedFloatField(ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(value, options);
		}

		public static float DelayedFloatField(float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(value, style, options);
		}

		public static void DelayedFloatField(ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(value, style, options);
		}

		public static float DelayedFloatField(string label, float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(label, value, options);
		}

		public static void DelayedFloatField(string label, ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(label, value, options);
		}

		public static float DelayedFloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(label, value, style, options);
		}

		public static void DelayedFloatField(string label, ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(label, value, style, options);
		}

		public static void DelayedFloatField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedFloatField(property, label, options);
		}

		public static float DelayedFloatField(GUIContent label, float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(label, value, options);
		}

		public static void DelayedFloatField(GUIContent label, ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(label, value, options);
		}

		public static float DelayedFloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedFloatField(label, value, style, options);
		}

		public static void DelayedFloatField(GUIContent label, ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedFloatField(label, value, style, options);
		}

		public static void DelayedIntField(SerializedProperty property, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedIntField(property, options);
		}

		public static int DelayedIntField(string label, int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(label, value, style, options);
		}

		public static void DelayedIntField(string label, ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(label, value, style, options);
		}

		public static int DelayedIntField(string label, int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(label, value, options);
		}

		public static void DelayedIntField(string label, ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(label, value, options);
		}

		public static int DelayedIntField(GUIContent label, int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(label, value, options);
		}

		public static void DelayedIntField(GUIContent label, ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(label, value, options);
		}

		public static int DelayedIntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(label, value, style, options);
		}

		public static void DelayedIntField(GUIContent label, ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(label, value, style, options);
		}

		public static void DelayedIntField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedIntField(property, label, options);
		}

		public static int DelayedIntField(int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(value, options);
		}

		public static void DelayedIntField(ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(value, options);
		}

		public static int DelayedIntField(int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedIntField(value, style, options);
		}

		public static void DelayedIntField(ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DelayedIntField(value, style, options);
		}

		public static string DelayedTextField(GUIContent label, string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(label, text, options);
		}

		public static void DelayedTextField(GUIContent label, ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(label, text, options);
		}

		public static void DelayedTextField(SerializedProperty property, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedTextField(property, options);
		}

		public static void DelayedTextField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.DelayedTextField(property, label, options);
		}

		public static string DelayedTextField(string label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(label, text, style, options);
		}

		public static void DelayedTextField(string label, ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(label, text, style, options);
		}

		public static string DelayedTextField(string label, string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(label, text, options);
		}

		public static void DelayedTextField(string label, ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(label, text, options);
		}

		public static string DelayedTextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(text, style, options);
		}

		public static void DelayedTextField(ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(text, style, options);
		}

		public static string DelayedTextField(string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(text, options);
		}

		public static void DelayedTextField(ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(text, options);
		}

		public static string DelayedTextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DelayedTextField(label, text, style, options);
		}

		public static void DelayedTextField(GUIContent label, ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.DelayedTextField(label, text, style, options);
		}

		public static double DoubleField(double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(value, options);
		}

		public static void DoubleField(ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(value, options);
		}

		public static double DoubleField(string label, double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(label, value, options);
		}

		public static void DoubleField(string label, ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(label, value, options);
		}

		public static double DoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(label, value, style, options);
		}

		public static void DoubleField(string label, ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(label, value, style, options);
		}

		public static double DoubleField(GUIContent label, double value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(label, value, options);
		}

		public static void DoubleField(GUIContent label, ref double value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(label, value, options);
		}

		public static double DoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(label, value, style, options);
		}

		public static void DoubleField(GUIContent label, ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(label, value, style, options);
		}

		public static double DoubleField(double value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DoubleField(value, style, options);
		}

		public static void DoubleField(ref double value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.DoubleField(value, style, options);
		}

		public static bool DropdownButton(GUIContent content, FocusType focusType, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DropdownButton(content, focusType, options);
		}

		public static bool DropdownButton(GUIContent content, FocusType focusType, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.DropdownButton(content, focusType, style, options);
		}

		public static void EndFadeGroup()
		{
			EditorGUILayout.EndFadeGroup();
		}

		public static void EndHorizontal()
		{
			EditorGUILayout.EndHorizontal();
		}

		public static void EndScrollView()
		{
			EditorGUILayout.EndScrollView();
		}

		public static void EndToggleGroup()
		{
			EditorGUILayout.EndToggleGroup();
		}

		public static void EndVertical()
		{
			EditorGUILayout.EndVertical();
		}

		public static Enum EnumMaskField(string label, Enum enumValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(label, enumValue, options);
		}

		public static void EnumMaskField(string label, ref Enum enumValue, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(label, enumValue, options);
		}

		public static Enum EnumMaskField(GUIContent label, Enum enumValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(label, enumValue, options);
		}

		public static void EnumMaskField(GUIContent label, ref Enum enumValue, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(label, enumValue, options);
		}

		public static Enum EnumMaskField(string label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(label, enumValue, style, options);
		}

		public static void EnumMaskField(string label, ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(label, enumValue, style, options);
		}

		public static Enum EnumMaskField(Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(enumValue, style, options);
		}

		public static void EnumMaskField(ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(enumValue, style, options);
		}

		public static Enum EnumMaskField(Enum enumValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(enumValue, options);
		}

		public static void EnumMaskField(ref Enum enumValue, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(enumValue, options);
		}

		public static Enum EnumMaskField(GUIContent label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskField(label, enumValue, style, options);
		}

		public static void EnumMaskField(GUIContent label, ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
		{
			enumValue = EditorGUILayout.EnumMaskField(label, enumValue, style, options);
		}

		public static Enum EnumMaskPopup(GUIContent label, Enum selected, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskPopup(label, selected, options);
		}

		public static void EnumMaskPopup(GUIContent label, ref Enum selected, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumMaskPopup(label, selected, options);
		}

		public static Enum EnumMaskPopup(string label, Enum selected, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskPopup(label, selected, options);
		}

		public static void EnumMaskPopup(string label, ref Enum selected, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumMaskPopup(label, selected, options);
		}

		public static Enum EnumMaskPopup(string label, Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskPopup(label, selected, style, options);
		}

		public static void EnumMaskPopup(string label, ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumMaskPopup(label, selected, style, options);
		}

		public static Enum EnumMaskPopup(GUIContent label, Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumMaskPopup(label, selected, style, options);
		}

		public static void EnumMaskPopup(GUIContent label, ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumMaskPopup(label, selected, style, options);
		}

		public static Enum EnumPopup(string label, Enum selected, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(label, selected, options);
		}

		public static void EnumPopup(string label, ref Enum selected, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(label, selected, options);
		}

		public static Enum EnumPopup(Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(selected, style, options);
		}

		public static void EnumPopup(ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(selected, style, options);
		}

		public static Enum EnumPopup(string label, Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(label, selected, style, options);
		}

		public static void EnumPopup(string label, ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(label, selected, style, options);
		}

		public static Enum EnumPopup(Enum selected, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(selected, options);
		}

		public static void EnumPopup(ref Enum selected, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(selected, options);
		}

		public static Enum EnumPopup(GUIContent label, Enum selected, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(label, selected, options);
		}

		public static void EnumPopup(GUIContent label, ref Enum selected, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(label, selected, options);
		}

		public static Enum EnumPopup(GUIContent label, Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.EnumPopup(label, selected, style, options);
		}

		public static void EnumPopup(GUIContent label, ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
		{
			selected = EditorGUILayout.EnumPopup(label, selected, style, options);
		}

		public static float FloatField(GUIContent label, float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(label, value, options);
		}

		public static void FloatField(GUIContent label, ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(label, value, options);
		}

		public static float FloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(label, value, style, options);
		}

		public static void FloatField(string label, ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(label, value, style, options);
		}

		public static float FloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(label, value, style, options);
		}

		public static void FloatField(GUIContent label, ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(label, value, style, options);
		}

		public static float FloatField(string label, float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(label, value, options);
		}

		public static void FloatField(string label, ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(label, value, options);
		}

		public static float FloatField(float value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(value, style, options);
		}

		public static void FloatField(ref float value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(value, style, options);
		}

		public static float FloatField(float value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.FloatField(value, options);
		}

		public static void FloatField(ref float value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.FloatField(value, options);
		}

		public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			return EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
		}

		public static void Foldout(ref bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
		}

		public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			return EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
		}

		public static void Foldout(ref bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
		}

		public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick)
		{
			return EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
		}

		public static void Foldout(ref bool foldout, GUIContent content, bool toggleOnLabelClick)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
		}

		public static bool Foldout(bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			return EditorGUILayout.Foldout(foldout, content, style);
		}

		public static void Foldout(ref bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, style);
		}

		public static bool Foldout(bool foldout, string content)
		{
			return EditorGUILayout.Foldout(foldout, content);
		}

		public static void Foldout(ref bool foldout, string content)
		{
			foldout = EditorGUILayout.Foldout(foldout, content);
		}

		public static bool Foldout(bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			return EditorGUILayout.Foldout(foldout, content, style);
		}

		public static void Foldout(ref bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, style);
		}

		public static bool Foldout(bool foldout, GUIContent content)
		{
			return EditorGUILayout.Foldout(foldout, content);
		}

		public static void Foldout(ref bool foldout, GUIContent content)
		{
			foldout = EditorGUILayout.Foldout(foldout, content);
		}

		public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick)
		{
			return EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
		}

		public static void Foldout(ref bool foldout, string content, bool toggleOnLabelClick)
		{
			foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
		}

		public static Rect GetControlRect(params GUILayoutOption[] options)
		{
			return EditorGUILayout.GetControlRect(options);
		}

		public static Rect GetControlRect(bool hasLabel, params GUILayoutOption[] options)
		{
			return EditorGUILayout.GetControlRect(hasLabel, options);
		}

		public static Rect GetControlRect(bool hasLabel, float height, params GUILayoutOption[] options)
		{
			return EditorGUILayout.GetControlRect(hasLabel, height, options);
		}

		public static Rect GetControlRect(bool hasLabel, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.GetControlRect(hasLabel, height, style, options);
		}

		public static void HelpBox(string message, MessageType type)
		{
			EditorGUILayout.HelpBox(message, type);
		}

		public static void HelpBox(string message, MessageType type, bool wide)
		{
			EditorGUILayout.HelpBox(message, type, wide);
		}

		public static bool InspectorTitlebar(bool foldout, UnityEngine.Object[] targetObjs)
		{
			return EditorGUILayout.InspectorTitlebar(foldout, targetObjs);
		}

		public static void InspectorTitlebar(ref bool foldout, UnityEngine.Object[] targetObjs)
		{
			foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObjs);
		}

		public static bool InspectorTitlebar(bool foldout, UnityEngine.Object targetObj)
		{
			return EditorGUILayout.InspectorTitlebar(foldout, targetObj);
		}

		public static void InspectorTitlebar(ref bool foldout, UnityEngine.Object targetObj)
		{
			foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObj);
		}

		public static void InspectorTitlebar(UnityEngine.Object[] targetObjs)
		{
			EditorGUILayout.InspectorTitlebar(targetObjs);
		}

		public static bool InspectorTitlebar(bool foldout, UnityEngine.Object[] targetObjs, bool expandable)
		{
			return EditorGUILayout.InspectorTitlebar(foldout, targetObjs, expandable);
		}

		public static void InspectorTitlebar(ref bool foldout, UnityEngine.Object[] targetObjs, bool expandable)
		{
			foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObjs, expandable);
		}

		public static bool InspectorTitlebar(bool foldout, UnityEngine.Object targetObj, bool expandable)
		{
			return EditorGUILayout.InspectorTitlebar(foldout, targetObj, expandable);
		}

		public static void InspectorTitlebar(ref bool foldout, UnityEngine.Object targetObj, bool expandable)
		{
			foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObj, expandable);
		}

		public static int IntField(GUIContent label, int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(label, value, options);
		}

		public static void IntField(GUIContent label, ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(label, value, options);
		}

		public static int IntField(string label, int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(label, value, style, options);
		}

		public static void IntField(string label, ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(label, value, style, options);
		}

		public static int IntField(string label, int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(label, value, options);
		}

		public static void IntField(string label, ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(label, value, options);
		}

		public static int IntField(int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(value, style, options);
		}

		public static void IntField(ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(value, style, options);
		}

		public static int IntField(int value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(value, options);
		}

		public static void IntField(ref int value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(value, options);
		}

		public static int IntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntField(label, value, style, options);
		}

		public static void IntField(GUIContent label, ref int value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntField(label, value, style, options);
		}

		public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
		}

		public static void IntPopup(GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
		}

		public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntPopup(string label, ref int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
		}

		public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
		}

		public static void IntPopup(string label, ref int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
		}

		public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntPopup(ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
		}

		public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
		}

		public static void IntPopup(ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
		}

		public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntPopup(GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			EditorGUILayout.IntPopup(property, displayedOptions, optionValues, options);
		}

		public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.IntPopup(property, displayedOptions, optionValues, label, options);
		}

		public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
		}

		public static void IntPopup(ref int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
		}

		public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntPopup(ref int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
		}

		public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
		}

		public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, string label, params GUILayoutOption[] options)
		{
			EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
		}

		public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			EditorGUILayout.IntSlider(property, leftValue, rightValue, options);
		}

		public static int IntSlider(GUIContent label, int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
		}

		public static void IntSlider(GUIContent label, ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
		}

		public static int IntSlider(string label, int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
		}

		public static void IntSlider(string label, ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
		}

		public static int IntSlider(int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.IntSlider(value, leftValue, rightValue, options);
		}

		public static void IntSlider(ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.IntSlider(value, leftValue, rightValue, options);
		}

		public static float Knob(Vector2 knobSize, float value, float minValue, float maxValue, string unit, Color backgroundColor, Color activeColor, bool showValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Knob(knobSize, value, minValue, maxValue, unit, backgroundColor, activeColor, showValue, options);
		}

		public static void Knob(Vector2 knobSize, ref float value, float minValue, float maxValue, string unit, Color backgroundColor, Color activeColor, bool showValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Knob(knobSize, value, minValue, maxValue, unit, backgroundColor, activeColor, showValue, options);
		}

		public static void LabelField(string label, GUIStyle style, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, style, options);
		}

		public static void LabelField(GUIContent label, GUIContent label2, GUIStyle style, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, label2, style, options);
		}

		public static void LabelField(GUIContent label, GUIContent label2, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, label2, options);
		}

		public static void LabelField(string label, string label2, GUIStyle style, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, label2, style, options);
		}

		public static void LabelField(string label, string label2, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, label2, options);
		}

		public static void LabelField(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, style, options);
		}

		public static void LabelField(GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, options);
		}

		public static void LabelField(string label, params GUILayoutOption[] options)
		{
			EditorGUILayout.LabelField(label, options);
		}

		public static int LayerField(int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(layer, style, options);
		}

		public static void LayerField(ref int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(layer, style, options);
		}

		public static int LayerField(int layer, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(layer, options);
		}

		public static void LayerField(ref int layer, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(layer, options);
		}

		public static int LayerField(GUIContent label, int layer, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(label, layer, options);
		}

		public static void LayerField(GUIContent label, ref int layer, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(label, layer, options);
		}

		public static int LayerField(GUIContent label, int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(label, layer, style, options);
		}

		public static void LayerField(GUIContent label, ref int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(label, layer, style, options);
		}

		public static int LayerField(string label, int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(label, layer, style, options);
		}

		public static void LayerField(string label, ref int layer, GUIStyle style, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(label, layer, style, options);
		}

		public static int LayerField(string label, int layer, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LayerField(label, layer, options);
		}

		public static void LayerField(string label, ref int layer, params GUILayoutOption[] options)
		{
			layer = EditorGUILayout.LayerField(label, layer, options);
		}

		public static long LongField(string label, long value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(label, value, style, options);
		}

		public static void LongField(string label, ref long value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(label, value, style, options);
		}

		public static long LongField(string label, long value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(label, value, options);
		}

		public static void LongField(string label, ref long value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(label, value, options);
		}

		public static long LongField(long value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(value, style, options);
		}

		public static void LongField(ref long value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(value, style, options);
		}

		public static long LongField(long value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(value, options);
		}

		public static void LongField(ref long value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(value, options);
		}

		public static long LongField(GUIContent label, long value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(label, value, style, options);
		}

		public static void LongField(GUIContent label, ref long value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(label, value, style, options);
		}

		public static long LongField(GUIContent label, long value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.LongField(label, value, options);
		}

		public static void LongField(GUIContent label, ref long value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.LongField(label, value, options);
		}

		public static int MaskField(GUIContent label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
		}

		public static void MaskField(GUIContent label, ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
		}

		public static int MaskField(string label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
		}

		public static void MaskField(string label, ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
		}

		public static int MaskField(string label, int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(label, mask, displayedOptions, options);
		}

		public static void MaskField(string label, ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(label, mask, displayedOptions, options);
		}

		public static int MaskField(int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(mask, displayedOptions, options);
		}

		public static void MaskField(ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(mask, displayedOptions, options);
		}

		public static int MaskField(int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(mask, displayedOptions, style, options);
		}

		public static void MaskField(ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(mask, displayedOptions, style, options);
		}

		public static int MaskField(GUIContent label, int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.MaskField(label, mask, displayedOptions, options);
		}

		public static void MaskField(GUIContent label, ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
		{
			mask = EditorGUILayout.MaskField(label, mask, displayedOptions, options);
		}

		public static void MinMaxSlider(ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
		{
			EditorGUILayout.MinMaxSlider(ref minValue, ref maxValue, minLimit, maxLimit, options);
		}

		public static void MinMaxSlider(string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
		{
			EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);
		}

		public static void MinMaxSlider(GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
		{
			EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);
		}

		public static void ObjectField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.ObjectField(property, label, options);
		}

		public static void ObjectField(SerializedProperty property, params GUILayoutOption[] options)
		{
			EditorGUILayout.ObjectField(property, options);
		}

		public static UnityEngine.Object ObjectField(GUIContent label, UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
		}

		public static void ObjectField(GUIContent label, ref UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			obj = EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
		}

		public static UnityEngine.Object ObjectField(string label, UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
		}

		public static void ObjectField(string label, ref UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			obj = EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
		}

		public static UnityEngine.Object ObjectField(UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ObjectField(obj, objType, allowSceneObjects, options);
		}

		public static void ObjectField(ref UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		{
			obj = EditorGUILayout.ObjectField(obj, objType, allowSceneObjects, options);
		}

		public static T ObjectField<T>(GUIContent label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			return (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
		}

		public static void ObjectField<T>(GUIContent label, ref T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			obj = (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
		}

		public static T ObjectField<T>(string label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			return (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
		}

		public static void ObjectField<T>(string label, ref T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			obj = (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
		}

		public static T ObjectField<T>(T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			return (T)EditorGUILayout.ObjectField(obj, typeof(T), allowSceneObjects, options);
		}

		public static void ObjectField<T>(ref T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
		{
			obj = (T)EditorGUILayout.ObjectField(obj, typeof(T), allowSceneObjects, options);
		}

		public static void ObjectField(SerializedProperty property, Type objType, params GUILayoutOption[] options)
		{
			EditorGUILayout.ObjectField(property, objType, options);
		}

		public static void ObjectField(SerializedProperty property, Type objType, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.ObjectField(property, objType, label, options);
		}

		public static string PasswordField(string password, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(password, style, options);
		}

		public static void PasswordField(ref string password, GUIStyle style, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(password, style, options);
		}

		public static string PasswordField(string label, string password, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(label, password, options);
		}

		public static void PasswordField(string label, ref string password, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(label, password, options);
		}

		public static string PasswordField(string label, string password, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(label, password, style, options);
		}

		public static void PasswordField(string label, ref string password, GUIStyle style, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(label, password, style, options);
		}

		public static string PasswordField(GUIContent label, string password, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(label, password, options);
		}

		public static void PasswordField(GUIContent label, ref string password, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(label, password, options);
		}

		public static string PasswordField(GUIContent label, string password, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(label, password, style, options);
		}

		public static void PasswordField(GUIContent label, ref string password, GUIStyle style, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(label, password, style, options);
		}

		public static string PasswordField(string password, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PasswordField(password, options);
		}

		public static void PasswordField(ref string password, params GUILayoutOption[] options)
		{
			password = EditorGUILayout.PasswordField(password, options);
		}

		public static int Popup(string label, int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
		}

		public static void Popup(string label, ref int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
		}

		public static int Popup(string label, int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
		}

		public static void Popup(string label, ref int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
		}

		public static int Popup(int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
		}

		public static void Popup(ref int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
		}

		public static int Popup(int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
		}

		public static void Popup(ref int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
		}

		public static int Popup(int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
		}

		public static void Popup(ref int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
		}

		public static int Popup(int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
		}

		public static void Popup(ref int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
		}

		public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
		}

		public static void Popup(GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
		}

		public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
		}

		public static void Popup(GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
		{
			selectedIndex = EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
		}

		public static void PrefixLabel(string label)
		{
			EditorGUILayout.PrefixLabel(label);
		}

		public static void PrefixLabel(string label, [DefaultValue("\"Button\"")] GUIStyle followingStyle)
		{
			EditorGUILayout.PrefixLabel(label, followingStyle);
		}

		public static void PrefixLabel(string label, GUIStyle followingStyle, GUIStyle labelStyle)
		{
			EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);
		}

		public static void PrefixLabel(GUIContent label)
		{
			EditorGUILayout.PrefixLabel(label);
		}

		public static void PrefixLabel(GUIContent label, GUIStyle followingStyle, GUIStyle labelStyle)
		{
			EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);
		}

		public static void PrefixLabel(GUIContent label, [DefaultValue("\"Button\"")] GUIStyle followingStyle)
		{
			EditorGUILayout.PrefixLabel(label, followingStyle);
		}

		public static bool PropertyField(SerializedProperty property, bool includeChildren, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PropertyField(property, includeChildren, options);
		}

		public static bool PropertyField(SerializedProperty property, GUIContent label, bool includeChildren, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PropertyField(property, label, includeChildren, options);
		}

		public static bool PropertyField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PropertyField(property, label, options);
		}

		public static bool PropertyField(SerializedProperty property, params GUILayoutOption[] options)
		{
			return EditorGUILayout.PropertyField(property, options);
		}

		public static Rect RectField(GUIContent label, Rect value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.RectField(label, value, options);
		}

		public static void RectField(GUIContent label, ref Rect value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.RectField(label, value, options);
		}

		public static Rect RectField(Rect value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.RectField(value, options);
		}

		public static void RectField(ref Rect value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.RectField(value, options);
		}

		public static Rect RectField(string label, Rect value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.RectField(label, value, options);
		}

		public static void RectField(string label, ref Rect value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.RectField(label, value, options);
		}

		public static void SelectableLabel(string text, params GUILayoutOption[] options)
		{
			EditorGUILayout.SelectableLabel(text, options);
		}

		public static void SelectableLabel(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			EditorGUILayout.SelectableLabel(text, style, options);
		}

		public static void Separator()
		{
			EditorGUILayout.Separator();
		}

		public static float Slider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Slider(value, leftValue, rightValue, options);
		}

		public static void Slider(ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Slider(value, leftValue, rightValue, options);
		}

		public static float Slider(GUIContent label, float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
		}

		public static void Slider(ref GUIContent label, float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
		}

		public static float Slider(string label, float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
		}

		public static void Slider(string label, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
		}

		public static void Slider(SerializedProperty property, float leftValue, float rightValue, string label, params GUILayoutOption[] options)
		{
			EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
		}

		public static void Slider(SerializedProperty property, float leftValue, float rightValue, GUIContent label, params GUILayoutOption[] options)
		{
			EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
		}

		public static void Slider(SerializedProperty property, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			EditorGUILayout.Slider(property, leftValue, rightValue, options);
		}

		public static void Space()
		{
			EditorGUILayout.Space();
		}

		public static string TagField(string tag, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(tag, options);
		}

		public static void TagField(ref string tag, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(tag, options);
		}

		public static string TagField(GUIContent label, string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(label, tag, style, options);
		}

		public static void TagField(GUIContent label, ref string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(label, tag, style, options);
		}

		public static string TagField(GUIContent label, string tag, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(label, tag, options);
		}

		public static void TagField(GUIContent label, ref string tag, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(label, tag, options);
		}

		public static string TagField(string label, string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(label, tag, style, options);
		}

		public static void TagField(string label, ref string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(label, tag, style, options);
		}

		public static string TagField(string label, string tag, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(label, tag, options);
		}

		public static void TagField(string label, ref string tag, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(label, tag, options);
		}

		public static string TagField(string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TagField(tag, style, options);
		}

		public static void TagField(ref string tag, GUIStyle style, params GUILayoutOption[] options)
		{
			tag = EditorGUILayout.TagField(tag, style, options);
		}

		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextArea(text, style, options);
		}

		public static void TextArea(ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextArea(text, style, options);
		}

		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextArea(text, options);
		}

		public static void TextArea(ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextArea(text, options);
		}

		public static string TextField(string label, string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(label, text, options);
		}

		public static void TextField(string label, ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(label, text, options);
		}

		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(text, style, options);
		}

		public static void TextField(ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(text, style, options);
		}

		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(text, options);
		}

		public static void TextField(ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(text, options);
		}

		public static string TextField(GUIContent label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(label, text, style, options);
		}

		public static void TextField(GUIContent label, ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(label, text, style, options);
		}

		public static string TextField(GUIContent label, string text, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(label, text, options);
		}

		public static void TextField(GUIContent label, ref string text, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(label, text, options);
		}

		public static string TextField(string label, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.TextField(label, text, style, options);
		}

		public static void TextField(string label, ref string text, GUIStyle style, params GUILayoutOption[] options)
		{
			text = EditorGUILayout.TextField(label, text, style, options);
		}

		public static bool Toggle(GUIContent label, bool value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(label, value, options);
		}

		public static void Toggle(GUIContent label, ref bool value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(label, value, options);
		}

		public static bool Toggle(string label, bool value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(label, value, options);
		}

		public static void Toggle(string label, ref bool value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(label, value, options);
		}

		public static bool Toggle(string label, bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(label, value, style, options);
		}

		public static void Toggle(string label, ref bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(label, value, style, options);
		}

		public static bool Toggle(GUIContent label, bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(label, value, style, options);
		}

		public static void Toggle(GUIContent label, ref bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(label, value, style, options);
		}

		public static bool Toggle(bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(value, style, options);
		}

		public static void Toggle(ref bool value, GUIStyle style, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(value, style, options);
		}

		public static bool Toggle(bool value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Toggle(value, options);
		}

		public static void Toggle(ref bool value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Toggle(value, options);
		}

		public static bool ToggleLeft(string label, bool value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ToggleLeft(label, value, options);
		}

		public static void ToggleLeft(string label, ref bool value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ToggleLeft(label, value, options);
		}

		public static bool ToggleLeft(GUIContent label, bool value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ToggleLeft(label, value, options);
		}

		public static void ToggleLeft(GUIContent label, ref bool value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ToggleLeft(label, value, options);
		}

		public static bool ToggleLeft(string label, bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
		}

		public static void ToggleLeft(string label, ref bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
		}

		public static bool ToggleLeft(GUIContent label, bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
		{
			return EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
		}

		public static void ToggleLeft(GUIContent label, ref bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
		}

		public static Vector2 Vector2Field(GUIContent label, Vector2 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector2Field(label, value, options);
		}

		public static void Vector2Field(GUIContent label, ref Vector2 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector2Field(label, value, options);
		}

		public static Vector2 Vector2Field(string label, Vector2 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector2Field(label, value, options);
		}

		public static void Vector2Field(string label, ref Vector2 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector2Field(label, value, options);
		}

		public static Vector3 Vector3Field(GUIContent label, Vector3 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector3Field(label, value, options);
		}

		public static void Vector3Field(GUIContent label, ref Vector3 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector3Field(label, value, options);
		}

		public static Vector3 Vector3Field(string label, Vector3 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector3Field(label, value, options);
		}

		public static void Vector3Field(string label, ref Vector3 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector3Field(label, value, options);
		}

		public static Vector4 Vector4Field(GUIContent label, Vector4 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector4Field(label, value, options);
		}

		public static void Vector4Field(GUIContent label, ref Vector4 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector4Field(label, value, options);
		}

		public static Vector4 Vector4Field(string label, Vector4 value, params GUILayoutOption[] options)
		{
			return EditorGUILayout.Vector4Field(label, value, options);
		}

		public static void Vector4Field(string label, ref Vector4 value, params GUILayoutOption[] options)
		{
			value = EditorGUILayout.Vector4Field(label, value, options);
		}

		#endregion

		#region GUIContent

		public static GUIContent None()
		{
			return GUIContent.none;
		}

		public static GUIContent Content()
		{
			return new GUIContent();
		}

		public static GUIContent Content(string text)
		{
			return new GUIContent(text);
		}

		public static GUIContent Content(Texture image)
		{
			return new GUIContent(image);
		}

		public static GUIContent Content(GUIContent src)
		{
			return new GUIContent(src);
		}

		public static GUIContent Content(string text, Texture image)
		{
			return new GUIContent(text, image);
		}

		public static GUIContent Content(string text, string tooltip)
		{
			return new GUIContent(text, tooltip);
		}

		public static GUIContent Content(Texture image, string tooltip)
		{
			return new GUIContent(image, tooltip);
		}

		public static GUIContent Content(string text, Texture image, string tooltip)
		{
			return new GUIContent(text, image, tooltip);
		}

		#endregion

		#region EditorGUIUtility

		public static float LineHeight
		{
			get { return EditorGUIUtility.singleLineHeight; }
		}

		public static float LineSpacing
		{
			get { return EditorGUIUtility.standardVerticalSpacing; }
		}

		#endregion

		public static void Reset()
		{
			if (oldColor.HasValue) color = oldColor.Value;
			if (oldBackgroundColor.HasValue) backgroundColor = oldBackgroundColor.Value;
			if (oldContentColor.HasValue) contentColor = oldContentColor.Value;
			if (oldChanged.HasValue) changed = oldChanged.Value;
			if (oldEnabled.HasValue) enabled = oldEnabled.Value;
			if (oldDepth.HasValue) depth = oldDepth.Value;
			if (oldSkin != null) skin = oldSkin;
			if (oldMatrix.HasValue) matrix = oldMatrix.Value;
			if (oldShowMixedValue.HasValue) showMixedValue = oldShowMixedValue.Value;
			if (oldIndentLevel.HasValue) indentLevel = oldIndentLevel.Value;

			oldColor = null;
			oldBackgroundColor = null;
			oldContentColor = null;
			oldChanged = null;
			oldEnabled = null;
			oldDepth = null;
			oldSkin = null;
			oldMatrix = null;
			oldShowMixedValue = null;
			oldIndentLevel = null;
		}
	}
}
