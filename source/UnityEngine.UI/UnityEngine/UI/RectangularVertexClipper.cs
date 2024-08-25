using System;

namespace UnityEngine.UI
{
	// Token: 0x0200000E RID: 14
	internal class RectangularVertexClipper
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002B10 File Offset: 0x00000D10
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			/*
An exception occurred when decompiling this method (06000057)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect UnityEngine.UI.RectangularVertexClipper::GetCanvasRect(UnityEngine.RectTransform,UnityEngine.Canvas)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_1_09, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](RectangularVertexClipper::m_WorldCorners, ldloc:RectangularVertexClipper(this)))
	call:void(RectTransform::GetWorldCorners, ldloc:RectTransform(t), ldloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_1_09))
	stloc:Transform(var_2_17, call:Transform(Component::GetComponent, ldloc:Canvas[exp:Component](c)))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_3_1E, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](RectangularVertexClipper::m_CanvasCorners, ldloc:RectangularVertexClipper(this)))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_5_28, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](RectangularVertexClipper::m_WorldCorners, ldloc:RectangularVertexClipper(this)))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_7_30, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](RectangularVertexClipper::m_CanvasCorners, ldloc:RectangularVertexClipper(this)))
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

		// Token: 0x06000058 RID: 88 RVA: 0x00002B50 File Offset: 0x00000D50
		public RectangularVertexClipper()
		{
		}

		// Token: 0x0400002A RID: 42
		private readonly Vector3[] m_WorldCorners;

		// Token: 0x0400002B RID: 43
		private readonly Vector3[] m_CanvasCorners;
	}
}
