using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	public class ResourcesAPI
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000081F0 File Offset: 0x000063F0
		internal static ResourcesAPI ActiveAPI
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000820C File Offset: 0x0000640C
		public static ResourcesAPI overrideAPI
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600045F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.ResourcesAPI UnityEngine.ResourcesAPI::get_overrideAPI()

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

		// Token: 0x06000460 RID: 1120 RVA: 0x0000821C File Offset: 0x0000641C
		protected internal ResourcesAPI()
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00008230 File Offset: 0x00006430
		protected internal virtual Shader FindShaderByName(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00008244 File Offset: 0x00006444
		protected internal virtual Object Load(string path, Type systemTypeInstance)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00008258 File Offset: 0x00006458
		protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000826C File Offset: 0x0000646C
		protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00008280 File Offset: 0x00006480
		protected internal virtual void UnloadAsset(Object assetToUnload)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00008294 File Offset: 0x00006494
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPI()
		{
		}

		// Token: 0x040003CD RID: 973
		private static ResourcesAPI s_DefaultAPI;

		// Token: 0x040003CE RID: 974
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static ResourcesAPI <overrideAPI>k__BackingField;
	}
}
