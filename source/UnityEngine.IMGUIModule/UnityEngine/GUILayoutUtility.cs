using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
	public class GUILayoutUtility
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002CB0 File Offset: 0x00000EB0
		private static Rect Internal_GetWindowRect(int windowID)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002CC8 File Offset: 0x00000EC8
		private static void Internal_MoveWindow(int windowID, Rect r)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002CE0 File Offset: 0x00000EE0
		internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			/*
An exception occurred when decompiling this method (06000057)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GUILayoutUtility/LayoutCache UnityEngine.GUILayoutUtility::SelectIDList(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002CF0 File Offset: 0x00000EF0
		internal static void Begin(int instanceID)
		{
			if (!true)
			{
			}
			long num = 0L;
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(instanceID, num != 0L);
			throw new MissingMethodException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002D18 File Offset: 0x00000F18
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
			if (!true)
			{
			}
			int num = 1;
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(windowID, num != 0);
			throw new MissingMethodException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002D48 File Offset: 0x00000F48
		internal static void Layout()
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002D74 File Offset: 0x00000F74
		internal static void LayoutFromEditorWindow()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int width = Screen.width;
				throw new MissingMethodException();
			}
			Debug.LogError("GUILayout state invalid. Verify that all layout begin/end calls match.");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002DB4 File Offset: 0x00000FB4
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			List<GUILayoutEntry> entries = toplevel.entries;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002DE4 File Offset: 0x00000FE4
		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
			if (i.isWindow)
			{
				Rect rect = GUILayoutUtility.Internal_GetWindowRect(i.windowID);
				float x = rect.x;
				float width = rect.width;
				float minWidth = i.minWidth;
				float maxWidth = i.maxWidth;
				float minHeight = i.minHeight;
				float maxHeight = i.maxHeight;
				int windowID = i.windowID;
				float xmin = i.rect.m_XMin;
				float ymin = i.rect.m_YMin;
				float width2 = i.rect.m_Width;
				float height = i.rect.m_Height;
				return;
			}
			float minWidth2 = i.minWidth;
			float maxWidth2 = i.maxWidth;
			float maxWidth3 = i.maxWidth;
			float minHeight2 = i.minHeight;
			float maxHeight2 = i.maxHeight;
			float maxHeight3 = i.maxHeight;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002EA0 File Offset: 0x000010A0
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			if (!true)
			{
			}
			Type type;
			if (Activator.CreateInstance(type) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002EC0 File Offset: 0x000010C0
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002EF8 File Offset: 0x000010F8
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			if (!true)
			{
			}
			Rect rect;
			return rect;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002F0C File Offset: 0x0000110C
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			GUIUtility.CheckOnGUI();
			throw new MissingMethodException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002F48 File Offset: 0x00001148
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutUtility()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002F58 File Offset: 0x00001158
		private static void Internal_GetWindowRect_Injected(int windowID, [Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002F6C File Offset: 0x0000116C
		private static void Internal_MoveWindow_Injected(int windowID, Rect r)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000057 RID: 87
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts;

		// Token: 0x04000058 RID: 88
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows;

		// Token: 0x04000059 RID: 89
		internal static GUILayoutUtility.LayoutCache current;

		// Token: 0x0400005A RID: 90
		internal static readonly Rect kDummyRect;

		// Token: 0x0200000E RID: 14
		[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
		internal sealed class LayoutCache
		{
			// Token: 0x1700001E RID: 30
			// (set) Token: 0x06000065 RID: 101 RVA: 0x00002F80 File Offset: 0x00001180
			private int id
			{
				[CompilerGenerated]
				set
				{
					this.<id>k__BackingField = value;
				}
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00002F94 File Offset: 0x00001194
			internal LayoutCache(int instanceID = -1)
			{
				GUILayoutGroup guilayoutGroup = this.topLevel;
				GenericStack genericStack = this.layoutGroups;
				this.id = instanceID;
			}

			// Token: 0x0400005B RID: 91
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int <id>k__BackingField;

			// Token: 0x0400005C RID: 92
			internal GUILayoutGroup topLevel;

			// Token: 0x0400005D RID: 93
			internal GenericStack layoutGroups;

			// Token: 0x0400005E RID: 94
			internal GUILayoutGroup windows;
		}
	}
}
