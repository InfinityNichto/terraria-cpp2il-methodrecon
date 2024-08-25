using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000116 RID: 278
public static class GUISlider
{
	// Token: 0x060006FE RID: 1790 RVA: 0x00018384 File Offset: 0x00016584
	public static Rectangle GetRegion(Slider_Layout layout)
	{
		/*
An exception occurred when decompiling this method (060006FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUISlider::GetRegion(Slider_Layout)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_06, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_0)))
	stloc:int32(var_3_0D, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_0)))
	stloc:int32(var_4_14, ldfld:int32(Texture2D::Width, ldloc:Texture2D(var_0)))
	stloc:int32(var_5_1C, ldfld:int32(Texture2D::Height, ldloc:Texture2D(var_0)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x000183B4 File Offset: 0x000165B4
	public static void DrawSaturationSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
		int num = 1;
		if (num != 0)
		{
			float hBar = Main.hBar;
			float lBar = Main.lBar;
			return;
		}
		float hBar2 = Main.hBar;
		float lBar2 = Main.lBar;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00018404 File Offset: 0x00016604
	public static void DrawLightnessSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
		int num = 1;
		if (num != 0)
		{
			float hBar = Main.hBar;
			float sBar = Main.sBar;
			return;
		}
		float hBar2 = Main.hBar;
		float sBar2 = Main.sBar;
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00018458 File Offset: 0x00016658
	public static bool DrawSaturation(Slider_Layout layout, bool disablePick, float value, GUISlider.DragState dragState, bool forceOver = false)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00018468 File Offset: 0x00016668
	public static bool DrawLightness(Slider_Layout layout, bool disablePick, float value, GUISlider.DragState dragState, bool forceOver = false)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00018478 File Offset: 0x00016678
	public static bool IsCursorOver(Vector2 cursorPosition, Slider_Layout layout)
	{
		Texture2D texture2D;
		int width = texture2D.Width;
		int height = texture2D.Height;
		int width2 = texture2D.Width;
		int height2 = texture2D.Height;
		return true;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x000021DB File Offset: 0x000003DB
	public static float QuantiseValue(float input, int stepCount)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x000021DB File Offset: 0x000003DB
	public static float CalculateValue(int input, int minValue, int maxValue)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x000184B0 File Offset: 0x000166B0
	public static int ScaleValue(float input, int minValue, int maxValue)
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x000184C4 File Offset: 0x000166C4
	public static bool Draw(Slider_Layout layout, bool disablePick, float value, GUISlider.DragState dragState, [Optional] GUISlider.DrawBackingHandler backingHandler, bool forceOver = false, int minValue = -1, int maxValue = -1, bool ignoreStartPoint = false)
	{
		/*
An exception occurred when decompiling this method (06000707)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUISlider::Draw(Slider_Layout,System.Boolean,System.Single,GUISlider/DragState,GUISlider/DrawBackingHandler,System.Boolean,System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0434:
	stloc:int32(var_211_439, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_213_443, callgetter:int32(Main::get_mouseY))
	stloc:int32(var_215_44D, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_217_457, callgetter:int32(Main::get_mouseY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x02000117 RID: 279
	public sealed class DrawBackingHandler : MulticastDelegate
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x0001892C File Offset: 0x00016B2C
		public DrawBackingHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00018980 File Offset: 0x00016B80
		public void Invoke(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000189A4 File Offset: 0x00016BA4
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000118 RID: 280
	public class DragState
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x000189B4 File Offset: 0x00016BB4
		public DragState()
		{
		}

		// Token: 0x0400058E RID: 1422
		public bool wasDragging;

		// Token: 0x0400058F RID: 1423
		public float dragDir;

		// Token: 0x04000590 RID: 1424
		public float dragStart;

		// Token: 0x04000591 RID: 1425
		public float dragTime;

		// Token: 0x04000592 RID: 1426
		public Vector2 dragStartPoint;
	}
}
