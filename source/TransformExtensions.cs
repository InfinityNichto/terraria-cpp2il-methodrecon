using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000300 RID: 768
public static class TransformExtensions
{
	// Token: 0x060011C6 RID: 4550 RVA: 0x000021DB File Offset: 0x000003DB
	public static Transform[] FindAllInChildren(this Transform transform, string name)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x000021DB File Offset: 0x000003DB
	private static void FindAllInChildren(this Transform transform, string name, List<Transform> results)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00056FBC File Offset: 0x000551BC
	public static Transform GetChildByName(this Transform transform, string name)
	{
		/*
An exception occurred when decompiling this method (060011C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Transform TransformExtensions::GetChildByName(UnityEngine.Transform,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_3_0D, callgetter:string(Object::get_name, callgetter:GameObject[exp:Object](Component::get_gameObject, ldloc:Transform[exp:Component](var_2))))
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

	// Token: 0x060011C9 RID: 4553 RVA: 0x00056FDC File Offset: 0x000551DC
	public static Transform FindInChildren(this Transform transform, string name)
	{
		/*
An exception occurred when decompiling this method (060011C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Transform TransformExtensions::FindInChildren(UnityEngine.Transform,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_3_0D, callgetter:string(Object::get_name, callgetter:GameObject[exp:Object](Component::get_gameObject, ldloc:Transform[exp:Component](var_2))))
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

	// Token: 0x060011CA RID: 4554 RVA: 0x00056FFC File Offset: 0x000551FC
	public static T FindInObjectOrChildren<T>(this Transform transform) where T : Component
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00057010 File Offset: 0x00055210
	public static T FindInChildren<T>(this Transform transform) where T : Component
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00057024 File Offset: 0x00055224
	public static T FindInParents<T>(this Transform transform) where T : Component
	{
		Transform parent;
		GameObject gameObject;
		for (;;)
		{
			if (!true)
			{
			}
			Transform transform2;
			parent = transform2.parent;
			long num = 0L;
			bool flag;
			if (!flag)
			{
			}
			if (num == 0L)
			{
				break;
			}
			if (gameObject == null)
			{
				return;
			}
			if (gameObject == null)
			{
				goto Block_2;
			}
		}
		gameObject = parent.gameObject;
		Transform parent2 = parent.parent;
		throw new MissingMethodException();
		Block_2:
		throw new InvalidCastException();
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00057070 File Offset: 0x00055270
	public static void SetLayer(this Transform transform, int layer)
	{
		transform.gameObject.layer = layer;
		Transform transform2 = transform.transform;
		int childCount = transform2.childCount;
		long num = 0L;
		transform2.GetChild((int)num).SetLayer(layer);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x000570A8 File Offset: 0x000552A8
	public static string GetPath(this Transform transform)
	{
		string text;
		return "/" + text;
	}
}
