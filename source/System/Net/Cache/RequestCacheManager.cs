using System;

namespace System.Net.Cache
{
	// Token: 0x020002E2 RID: 738
	internal sealed class RequestCacheManager
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		internal static RequestCacheBinding GetBinding(string internedScheme)
		{
			/*
An exception occurred when decompiling this method (060012F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Cache.RequestCacheBinding System.Net.Cache.RequestCacheManager::GetBinding(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060012F4 RID: 4852 RVA: 0x0003ABE0 File Offset: 0x00038DE0
		internal static void SetBinding(string uriScheme, RequestCacheBinding binding)
		{
			while (uriScheme == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				RequestCacheManager.LoadConfigSettings();
			}
			if (!true)
			{
			}
			if (!true)
			{
				int stringLength = uriScheme._stringLength;
				if (stringLength != 0)
				{
					if (stringLength == 0)
					{
					}
					if (stringLength == 0)
					{
					}
					if (stringLength == 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0003AC1C File Offset: 0x00038E1C
		private static void LoadConfigSettings()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003AC58 File Offset: 0x00038E58
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheManager()
		{
		}

		// Token: 0x04000F6D RID: 3949
		private static RequestCachingSectionInternal s_CacheConfigSettings;

		// Token: 0x04000F6E RID: 3950
		private static readonly RequestCacheBinding s_BypassCacheBinding;

		// Token: 0x04000F6F RID: 3951
		private static RequestCacheBinding s_DefaultGlobalBinding;

		// Token: 0x04000F70 RID: 3952
		private static RequestCacheBinding s_DefaultHttpBinding;

		// Token: 0x04000F71 RID: 3953
		private static RequestCacheBinding s_DefaultFtpBinding;
	}
}
