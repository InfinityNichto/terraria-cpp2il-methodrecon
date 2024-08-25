using System;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public class GUILayout
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00003428 File Offset: 0x00001628
		public static void Label(string text, params GUILayoutOption[] options)
		{
			if (!true)
			{
			}
			GUIContent guicontent = GUIContent.Temp(text);
			GUIStyle label = GUI.skin.m_label;
			GUILayout.DoLabel(guicontent, label, options);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003454 File Offset: 0x00001654
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			if (!true)
			{
			}
			Rect rect = GUILayoutUtility.GetRect(content, style, options);
			if (!true)
			{
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003470 File Offset: 0x00001670
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003480 File Offset: 0x00001680
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			int num = 1;
			GUIUtility.CheckOnGUI();
			if (num == 0)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000034F8 File Offset: 0x000016F8
		public static void EndArea()
		{
			GUIUtility.CheckOnGUI();
			throw new MissingMethodException();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000020F5 File Offset: 0x000002F5
		public static GUILayoutOption Width(float width)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000020F5 File Offset: 0x000002F5
		public static GUILayoutOption Height(float height)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
