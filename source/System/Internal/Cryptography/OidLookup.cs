using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Internal.Cryptography
{
	// Token: 0x0200006F RID: 111
	internal static class OidLookup
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public static string ToFriendlyName(string oid, global::System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups)
		{
			if (true || !true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			if (text == null || !true)
			{
			}
			return 1;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public static string ToOid(string friendlyName, global::System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups)
		{
			for (;;)
			{
				if (true || !true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				string text;
				if (text != null)
				{
					if (!true)
					{
						return;
					}
					return;
				}
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005CEC File Offset: 0x00003EEC
		private static bool ShouldUseCache(global::System.Security.Cryptography.OidGroup oidGroup)
		{
			return true;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005CFC File Offset: 0x00003EFC
		private static string NativeOidToFriendlyName(string oid, global::System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups)
		{
			/*
An exception occurred when decompiling this method (060001A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Internal.Cryptography.OidLookup::NativeOidToFriendlyName(System.String,System.Security.Cryptography.OidGroup,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_0A, call:uint32('<PrivateImplementationDetails>'::ComputeStringHash, ldstr:string("id-smime-alg-3DESwrap")))
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

		// Token: 0x060001A4 RID: 420 RVA: 0x00005D18 File Offset: 0x00003F18
		private static string NativeFriendlyNameToOid(string friendlyName, global::System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups)
		{
			/*
An exception occurred when decompiling this method (060001A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Internal.Cryptography.OidLookup::NativeFriendlyNameToOid(System.String,System.Security.Cryptography.OidGroup,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_0A, call:uint32('<PrivateImplementationDetails>'::ComputeStringHash, ldstr:string("id-smime-alg-3DESwrap")))
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

		// Token: 0x060001A5 RID: 421 RVA: 0x00005D34 File Offset: 0x00003F34
		// Note: this type is marked as 'beforefieldinit'.
		static OidLookup()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;

		// Token: 0x04000136 RID: 310
		private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;

		// Token: 0x04000137 RID: 311
		private static readonly Dictionary<string, string> s_friendlyNameToOid;

		// Token: 0x04000138 RID: 312
		private static readonly Dictionary<string, string> s_oidToFriendlyName;

		// Token: 0x04000139 RID: 313
		private static readonly Dictionary<string, string> s_compatOids;

		// Token: 0x02000070 RID: 112
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060001A6 RID: 422 RVA: 0x00005D48 File Offset: 0x00003F48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00005D58 File Offset: 0x00003F58
			public <>c()
			{
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
			internal string <.cctor>b__10_0(KeyValuePair<string, string> kvp)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
			internal string <.cctor>b__10_1(KeyValuePair<string, string> kvp)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400013A RID: 314
			public static readonly OidLookup.<>c <>9;
		}
	}
}
