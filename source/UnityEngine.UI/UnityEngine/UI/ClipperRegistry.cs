using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200000A RID: 10
	public class ClipperRegistry
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000029F0 File Offset: 0x00000BF0
		protected ClipperRegistry()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002A04 File Offset: 0x00000C04
		public static ClipperRegistry instance
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600004A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.ClipperRegistry UnityEngine.UI.ClipperRegistry::get_instance()

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

		// Token: 0x0600004B RID: 75 RVA: 0x00002A14 File Offset: 0x00000C14
		public void Cull()
		{
			IndexedSet<IClipper> clippers = this.m_Clippers;
			int enabledObjectCount = clippers.m_EnabledObjectCount;
			long num = 0L;
			IClipper clipper = clippers[(int)num];
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002A44 File Offset: 0x00000C44
		public static void Register(IClipper c)
		{
			if (c != null)
			{
				IndexedSet<IClipper> clippers = ClipperRegistry.instance.m_Clippers;
				return;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002A60 File Offset: 0x00000C60
		public static void Unregister(IClipper c)
		{
			IndexedSet<IClipper> clippers = ClipperRegistry.instance.m_Clippers;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002A78 File Offset: 0x00000C78
		public static void Disable(IClipper c)
		{
			IndexedSet<IClipper> clippers = ClipperRegistry.instance.m_Clippers;
		}

		// Token: 0x04000028 RID: 40
		private static ClipperRegistry s_Instance;

		// Token: 0x04000029 RID: 41
		private readonly IndexedSet<IClipper> m_Clippers;
	}
}
