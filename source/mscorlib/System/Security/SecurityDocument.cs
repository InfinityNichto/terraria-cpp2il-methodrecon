using System;
using System.Security.Util;
using System.Text;
using Cpp2IlInjected;

namespace System.Security
{
	// Token: 0x02000294 RID: 660
	[Serializable]
	internal sealed class SecurityDocument
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x0002FF40 File Offset: 0x0002E140
		public SecurityDocument(int numData)
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0002FF54 File Offset: 0x0002E154
		public void GuaranteeSize(int size)
		{
			byte[] data = this.m_data;
			byte[] data2 = this.m_data;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0002FF70 File Offset: 0x0002E170
		public void AddString(string str, int position)
		{
			int stringLength = str._stringLength;
			int stringLength2 = str._stringLength;
			byte[] data = this.m_data;
			long num = 0L;
			char c = str[(int)num];
			byte[] data2 = this.m_data;
			char c2 = str[(int)num];
			int stringLength3 = str._stringLength;
			byte[] data3 = this.m_data;
			int stringLength4 = str._stringLength;
			byte[] data4 = this.m_data;
			int stringLength5 = str._stringLength;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		public void AppendString(string str, int position)
		{
			while (this.m_data != null)
			{
			}
			this.AddString(str, position);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0000207A File Offset: 0x0000027A
		public static int EncodedStringSize(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0002FFF8 File Offset: 0x0002E1F8
		public string GetString(int position, bool bCreate)
		{
			if (this.m_data == null)
			{
			}
			Tokenizer.StringMaker sharedStringMaker = SharedStatics.GetSharedStringMaker();
			byte[] data = this.m_data;
			StringBuilder outStringBuilder;
			if (sharedStringMaker._outStringBuilder == null)
			{
				outStringBuilder = sharedStringMaker._outStringBuilder;
			}
			char[] outChars = sharedStringMaker._outChars;
			int num = 512;
			long num2 = 0L;
			StringBuilder stringBuilder = outStringBuilder.Append(outChars, (int)num2, num);
			int num3 = 1;
			char[] outChars2 = sharedStringMaker._outChars;
			sharedStringMaker._outIndex = num3;
			char[] outChars3 = sharedStringMaker._outChars;
			sharedStringMaker._outIndex = num3;
			position.m_value = num3;
			return sharedStringMaker.MakeString();
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000300B0 File Offset: 0x0002E2B0
		public void AddToken(byte b, int position)
		{
			this.GuaranteeSize((int)b);
			byte[] data = this.m_data;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000300CC File Offset: 0x0002E2CC
		public SecurityElement GetRootElement()
		{
			SecurityElement securityElement;
			return securityElement;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000300DC File Offset: 0x0002E2DC
		public SecurityElement GetElement(int position, bool bCreate)
		{
			return this.InternalGetElement(position, bCreate);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000300F4 File Offset: 0x0002E2F4
		internal SecurityElement InternalGetElement(int position, bool bCreate)
		{
			/*
An exception occurred when decompiling this method (060016CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.SecurityElement System.Security.SecurityDocument::InternalGetElement(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](SecurityDocument::m_data, ldloc:SecurityDocument(this)))
	stloc:string(var_1_0F, call:string(SecurityDocument::GetString, ldloc:SecurityDocument(this), ldloc:int32(position), ldloc:bool(bCreate)))
	stloc:int64(var_2_11, ldc.i4:int64(0))
	stloc:string(var_4_1C, call:string(SecurityDocument::GetString, ldloc:SecurityDocument(this), ldloc:int32(position), ldloc:int64[exp:bool](var_2_11)))
	stloc:string(var_5_26, call:string(SecurityDocument::GetString, ldloc:SecurityDocument(this), ldloc:int32(position), ldloc:int64[exp:bool](var_2_11)))
	stloc:uint8[](var_6_2E, ldfld:uint8[](SecurityDocument::m_data, ldloc:SecurityDocument(this)))
	stloc:uint8[](var_9_36, ldfld:uint8[](SecurityDocument::m_data, ldloc:SecurityDocument(this)))
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

		// Token: 0x04000B96 RID: 2966
		internal byte[] m_data;
	}
}
