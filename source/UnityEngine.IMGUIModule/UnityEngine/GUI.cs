using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	public class GUI
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000244C File Offset: 0x0000064C
		static GUI()
		{
			DateTime now = DateTime.Now;
			if (!true)
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002464 File Offset: 0x00000664
		internal static DateTime nextScrollStepTime
		{
			[CompilerGenerated]
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002474 File Offset: 0x00000674
		public static GUISkin skin
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000019)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GUISkin UnityEngine.GUI::get_skin()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	call:void(GUIUtility::CheckOnGUI)
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
			set
			{
				GUIUtility.CheckOnGUI();
				if (!true)
				{
				}
				GUI.DoSetSkin(value);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024A4 File Offset: 0x000006A4
		internal static void DoSetSkin(GUISkin newSkin)
		{
			bool flag = newSkin;
			GUIUtility.GetDefaultSkin().MakeCurrent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000024C4 File Offset: 0x000006C4
		public static void Label(Rect position, string text)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000024D4 File Offset: 0x000006D4
		public static void Label(Rect position, string text, GUIStyle style)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000024E4 File Offset: 0x000006E4
		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			if (!true)
			{
			}
			GUI.DoLabel(position, content, style);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002504 File Offset: 0x00000704
		public static bool Button(Rect position, string text)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002518 File Offset: 0x00000718
		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000252C File Offset: 0x0000072C
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002544 File Offset: 0x00000744
		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025B8 File Offset: 0x000007B8
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000025D8 File Offset: 0x000007D8
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000025E8 File Offset: 0x000007E8
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025F8 File Offset: 0x000007F8
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
			int num = 1;
			GUIUtility.CheckOnGUI();
			if (num == 0)
			{
			}
			GUIStyle none = GUIStyle.none;
			throw new MissingMethodException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002628 File Offset: 0x00000828
		public static void EndGroup()
		{
			GUIUtility.CheckOnGUI();
			throw new MissingMethodException();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002640 File Offset: 0x00000840
		internal static GenericStack scrollViewStates
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06000027)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngineInternal.GenericStack UnityEngine.GUI::get_scrollViewStates()

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
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002650 File Offset: 0x00000850
		[RequiredByNativeCode]
		internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList(id, num2 != 0);
			if (num == 0)
			{
			}
			GUISkin skin = GUI.skin;
			throw new MissingMethodException();
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000026E8 File Offset: 0x000008E8
		public static bool changed
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026FC File Offset: 0x000008FC
		internal static void GrabMouseControl(int id)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002710 File Offset: 0x00000910
		internal static bool HasMouseControl(int id)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002724 File Offset: 0x00000924
		internal static void ReleaseMouseControl()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400000F RID: 15
		private static int s_HotTextField;

		// Token: 0x04000010 RID: 16
		private static readonly int s_BoxHash;

		// Token: 0x04000011 RID: 17
		private static readonly int s_ButonHash;

		// Token: 0x04000012 RID: 18
		private static readonly int s_RepeatButtonHash;

		// Token: 0x04000013 RID: 19
		private static readonly int s_ToggleHash;

		// Token: 0x04000014 RID: 20
		private static readonly int s_ButtonGridHash;

		// Token: 0x04000015 RID: 21
		private static readonly int s_SliderHash;

		// Token: 0x04000016 RID: 22
		private static readonly int s_BeginGroupHash;

		// Token: 0x04000017 RID: 23
		private static readonly int s_ScrollviewHash;

		// Token: 0x04000018 RID: 24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static DateTime <nextScrollStepTime>k__BackingField;

		// Token: 0x04000019 RID: 25
		private static GUISkin s_Skin;

		// Token: 0x0400001A RID: 26
		internal static Rect s_ToolTipRect;

		// Token: 0x0400001B RID: 27
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static GenericStack <scrollViewStates>k__BackingField;

		// Token: 0x02000005 RID: 5
		public sealed class WindowFunction : MulticastDelegate
		{
			// Token: 0x0600002D RID: 45 RVA: 0x00002738 File Offset: 0x00000938
			public WindowFunction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x0000278C File Offset: 0x0000098C
			public void Invoke(int id)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
