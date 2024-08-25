using System;

namespace System.Net
{
	// Token: 0x02000122 RID: 290
	internal static class ContextFlagsAdapterPal
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x00019394 File Offset: 0x00017594
		internal static ContextFlagsPal GetContextFlagsPalFromInterop(global::Interop.NetSecurityNative.GssFlags gssFlags, bool isServer)
		{
			/*
An exception occurred when decompiling this method (060006E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.ContextFlagsPal System.Net.ContextFlagsAdapterPal::GetContextFlagsPalFromInterop(Interop/NetSecurityNative/GssFlags,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(2))
	stloc:int32(var_2_0A, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_0_01)))
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

		// Token: 0x060006E4 RID: 1764 RVA: 0x000193AC File Offset: 0x000175AC
		internal static global::Interop.NetSecurityNative.GssFlags GetInteropFromContextFlagsPal(ContextFlagsPal flags, bool isServer)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000193C4 File Offset: 0x000175C4
		// Note: this type is marked as 'beforefieldinit'.
		static ContextFlagsAdapterPal()
		{
		}

		// Token: 0x0400054C RID: 1356
		private static readonly ContextFlagsAdapterPal.ContextFlagMapping[] s_contextFlagMapping;

		// Token: 0x02000123 RID: 291
		private readonly struct ContextFlagMapping
		{
			// Token: 0x060006E6 RID: 1766 RVA: 0x000193D4 File Offset: 0x000175D4
			public ContextFlagMapping(global::Interop.NetSecurityNative.GssFlags gssFlag, ContextFlagsPal contextFlag)
			{
				this.GssFlags = gssFlag;
			}

			// Token: 0x0400054D RID: 1357
			public readonly global::Interop.NetSecurityNative.GssFlags GssFlags;

			// Token: 0x0400054E RID: 1358
			public readonly ContextFlagsPal ContextFlag;
		}
	}
}
