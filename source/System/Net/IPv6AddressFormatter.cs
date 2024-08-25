using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200025F RID: 607
	internal struct IPv6AddressFormatter
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x00033B38 File Offset: 0x00031D38
		public IPv6AddressFormatter(ushort[] addr, long scopeId)
		{
			this.address = addr;
			this.scopeId = scopeId;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
		private static ushort SwapUShort(ushort number)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
		private uint AsIPv4Int()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00033B54 File Offset: 0x00031D54
		private bool IsIPv4Compatible()
		{
			if (false)
			{
				return;
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00033B68 File Offset: 0x00031D68
		private bool IsIPv4Mapped()
		{
			if (false)
			{
				return;
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00033B7C File Offset: 0x00031D7C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600105E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.IPv6AddressFormatter::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_16_32, ldfld:int64(IPv6AddressFormatter::scopeId, ldloc:valuetype System.Net.IPv6AddressFormatter&(this)))
	stloc:StringBuilder(var_17_3D, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_15), ldloc:int64(var_16_32)))
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

		// Token: 0x04000CE0 RID: 3296
		private ushort[] address;

		// Token: 0x04000CE1 RID: 3297
		private long scopeId;
	}
}
