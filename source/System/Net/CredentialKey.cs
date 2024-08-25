using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x0200018C RID: 396
	internal class CredentialKey
	{
		// Token: 0x06000A33 RID: 2611 RVA: 0x0002286C File Offset: 0x00020A6C
		internal CredentialKey(global::System.Uri uriPrefix, string authenticationType)
		{
			this.UriPrefix = uriPrefix;
			string @string = uriPrefix.m_String;
			this.AuthenticationType = authenticationType;
			this.UriPrefixLength = @string;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002289C File Offset: 0x00020A9C
		internal bool Match(global::System.Uri uri, string authenticationType)
		{
			if (!true)
			{
			}
			if (authenticationType != null)
			{
				string authenticationType2 = this.AuthenticationType;
				if (string.Compare(authenticationType, authenticationType2, StringComparison.OrdinalIgnoreCase) != 0)
				{
				}
			}
			global::System.Uri uriPrefix = this.UriPrefix;
			bool flag;
			return flag;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000228CC File Offset: 0x00020ACC
		internal bool IsPrefix(global::System.Uri uri, global::System.Uri prefixUri)
		{
			/*
An exception occurred when decompiling this method (06000A35)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialKey::IsPrefix(System.Uri,System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, callgetter:string(Uri::get_Scheme, ldloc:Uri(prefixUri)))
	stloc:string(var_1_0D, callgetter:string(Uri::get_Scheme, ldloc:Uri(uri)))
	stloc:bool(var_2_15, call:bool(string::op_Inequality, ldloc:string(var_0_06), ldloc:string(var_1_0D)))
	stloc:string(var_3_1C, callgetter:string(Uri::get_Host, ldloc:Uri(prefixUri)))
	stloc:string(var_4_23, callgetter:string(Uri::get_Host, ldloc:Uri(uri)))
	stloc:bool(var_5_2D, call:bool(string::op_Inequality, ldloc:string(var_3_1C), ldloc:string(var_4_23)))
	stloc:int32(var_6_35, callgetter:int32(Uri::get_Port, ldloc:Uri(prefixUri)))
	stloc:int32(var_7_3D, callgetter:int32(Uri::get_Port, ldloc:Uri(uri)))
	stloc:string(var_8_45, callgetter:string(Uri::get_AbsolutePath, ldloc:Uri(prefixUri)))
	stloc:string(var_10_4D, callgetter:string(Uri::get_AbsolutePath, ldloc:Uri(uri)))
	stloc:string(var_13_58, callgetter:string(Uri::get_AbsolutePath, ldloc:Uri(uri)))
	stloc:string(var_14_60, callgetter:string(Uri::get_AbsolutePath, ldloc:Uri(prefixUri)))
	stloc:int64(var_15_63, ldc.i4:int64(0))
	stloc:int64(var_16_66, ldc.i4:int64(0))
	stloc:int32(var_17_78, call:int32(string::Compare, ldloc:string(var_13_58), ldloc:int64[exp:int32](var_15_63), ldloc:string(var_14_60), ldloc:int64[exp:int32](var_16_66), ldloc:int32(var_9), ldc.i4:StringComparison(5)))
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

		// Token: 0x06000A36 RID: 2614 RVA: 0x00022954 File Offset: 0x00020B54
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000A36)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.CredentialKey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:string(var_0_1A, call:string(string::ToUpperInvariant, ldfld:string(CredentialKey::AuthenticationType, ldloc:CredentialKey(this))))
	stloc:Uri(var_1_21, ldfld:Uri(CredentialKey::UriPrefix, ldloc:CredentialKey(this)))
	stloc:int32(var_2_28, ldfld:int32(CredentialKey::UriPrefixLength, ldloc:CredentialKey(this)))
	stloc:int32(var_3_2A, ldc.i4:int32(1))
	stfld:int32(CredentialKey::m_HashCode, ldloc:CredentialKey(this), ldloc:Uri[exp:int32](var_1_21))
	stfld:bool(CredentialKey::m_ComputedHashCode, ldloc:CredentialKey(this), ldloc:int32[exp:bool](var_3_2A))
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002299C File Offset: 0x00020B9C
		public override bool Equals(object comparand)
		{
			/*
An exception occurred when decompiling this method (06000A37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialKey::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:Uri(var_3_15, ldfld:Uri(CredentialKey::UriPrefix, ldloc:CredentialKey(this)))
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

		// Token: 0x06000A38 RID: 2616 RVA: 0x000229C0 File Offset: 0x00020BC0
		public override string ToString()
		{
			if ("[" == null || "[" != null)
			{
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				string text;
				if ((text == null || text != null) && ("]:" == null || "]:" != null))
				{
					string text2 = ValidationHelper.ToString(this.UriPrefix);
					if ((text2 == null || text2 != null) && (":" == null || ":" != null))
					{
						string text3 = ValidationHelper.ToString(this.AuthenticationType);
						if (text3 == null || text3 != null)
						{
							string text4;
							return text4;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040007C4 RID: 1988
		internal global::System.Uri UriPrefix;

		// Token: 0x040007C5 RID: 1989
		internal int UriPrefixLength;

		// Token: 0x040007C6 RID: 1990
		internal string AuthenticationType;

		// Token: 0x040007C7 RID: 1991
		private int m_HashCode;

		// Token: 0x040007C8 RID: 1992
		private bool m_ComputedHashCode;
	}
}
