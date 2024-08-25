using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000071 RID: 113
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/DisplayManager.h")]
	public class Display
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x000047AC File Offset: 0x000029AC
		internal Display()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000047C4 File Offset: 0x000029C4
		internal Display(IntPtr nativeDisplay)
		{
			this.nativeDisplay = nativeDisplay;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000047E0 File Offset: 0x000029E0
		public int renderingWidth
		{
			get
			{
				int num = 1;
				IntPtr intPtr = this.nativeDisplay;
				if (num == 0)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00004800 File Offset: 0x00002A00
		public int renderingHeight
		{
			get
			{
				int num = 1;
				IntPtr intPtr = this.nativeDisplay;
				if (num == 0)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00004820 File Offset: 0x00002A20
		public int systemWidth
		{
			get
			{
				int num = 1;
				IntPtr intPtr = this.nativeDisplay;
				if (num == 0)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00004840 File Offset: 0x00002A40
		public int systemHeight
		{
			get
			{
				int num = 1;
				IntPtr intPtr = this.nativeDisplay;
				if (num == 0)
				{
				}
				throw new MissingMethodException();
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004860 File Offset: 0x00002A60
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			throw new MissingMethodException();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00004874 File Offset: 0x00002A74
		public static Display main
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Display UnityEngine.Display::get_main()

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

		// Token: 0x060001C1 RID: 449 RVA: 0x00004884 File Offset: 0x00002A84
		[RequiredByNativeCode]
		private static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00004898 File Offset: 0x00002A98
		[RequiredByNativeCode]
		private static void FireDisplaysUpdated()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000048AC File Offset: 0x00002AAC
		[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
		private static void GetSystemExtImpl(IntPtr nativeDisplay, [Out] int w, [Out] int h)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000048C0 File Offset: 0x00002AC0
		[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
		private static void GetRenderingExtImpl(IntPtr nativeDisplay, [Out] int w, [Out] int h)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000048D4 File Offset: 0x00002AD4
		[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
		private static int RelativeMouseAtImpl(int x, int y, [Out] int rx, [Out] int ry)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000048E8 File Offset: 0x00002AE8
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
		}

		// Token: 0x040002DD RID: 733
		internal IntPtr nativeDisplay;

		// Token: 0x040002DE RID: 734
		public static Display[] displays;

		// Token: 0x040002DF RID: 735
		private static Display _mainDisplay;

		// Token: 0x040002E0 RID: 736
		private static int m_ActiveEditorGameViewTarget;

		// Token: 0x040002E1 RID: 737
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Display.DisplaysUpdatedDelegate onDisplaysUpdated;

		// Token: 0x02000072 RID: 114
		public sealed class DisplaysUpdatedDelegate : MulticastDelegate
		{
			// Token: 0x060001C7 RID: 455 RVA: 0x00004900 File Offset: 0x00002B00
			public DisplaysUpdatedDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00004954 File Offset: 0x00002B54
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
