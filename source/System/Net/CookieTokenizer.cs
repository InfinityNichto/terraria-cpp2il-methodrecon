using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200020E RID: 526
	internal class CookieTokenizer
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x000295AC File Offset: 0x000277AC
		internal CookieTokenizer(string tokenStream)
		{
			int stringLength = tokenStream._stringLength;
			this.m_tokenStream = tokenStream;
			this.m_length = stringLength;
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000295D4 File Offset: 0x000277D4
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000295E8 File Offset: 0x000277E8
		internal bool EndOfCookie
		{
			get
			{
				return this.m_eofCookie;
			}
			set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000295F8 File Offset: 0x000277F8
		internal bool Eof
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000CFB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CookieTokenizer::get_Eof()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
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
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002960C File Offset: 0x0002780C
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00029620 File Offset: 0x00027820
		internal string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00029634 File Offset: 0x00027834
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00029648 File Offset: 0x00027848
		internal bool Quoted
		{
			get
			{
				return this.m_quoted;
			}
			set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00029658 File Offset: 0x00027858
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0002966C File Offset: 0x0002786C
		internal CookieToken Token
		{
			get
			{
				return this.m_token;
			}
			set
			{
				this.m_token = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00029680 File Offset: 0x00027880
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00029694 File Offset: 0x00027894
		internal string Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				this.m_value = value;
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000296A8 File Offset: 0x000278A8
		internal string Extract()
		{
			string text;
			for (;;)
			{
				int tokenLength = this.m_tokenLength;
				if (tokenLength != 0)
				{
					string tokenStream = this.m_tokenStream;
					int start = this.m_start;
					text = tokenStream.Substring(start, tokenLength);
					if (!this.m_quoted)
					{
						break;
					}
				}
			}
			return text.Trim();
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000296E4 File Offset: 0x000278E4
		internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			/*
An exception occurred when decompiling this method (06000D05)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.CookieToken System.Net.CookieTokenizer::FindNext(System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_08, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_start, ldloc:CookieTokenizer(this), ldloc:int32(var_1_08))
	stloc:bool(var_2_21, call:bool(char::IsWhiteSpace, callgetter:char(string::get_Chars, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)), ldloc:int32(var_1_08))))
	stloc:int32(var_3_28, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:int32(var_4_2F, ldfld:int32(CookieTokenizer::m_start, ldloc:CookieTokenizer(this)))
	stloc:int32(var_5_37, ldfld:int32(CookieTokenizer::m_length, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_3_28))
	stfld:int32(CookieTokenizer::m_start, ldloc:CookieTokenizer(this), ldloc:int32(var_4_2F))
	stloc:int32(var_6_4E, ldfld:int32(CookieTokenizer::m_length, ldloc:CookieTokenizer(this)))
	stloc:char(var_7_5C, callgetter:char(string::get_Chars, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)), ldloc:int32(var_3_28)))
	stloc:int32(var_8_64, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:int32(var_9_67, ldc.i4:int32(1))
	stfld:bool(CookieTokenizer::m_quoted, ldloc:CookieTokenizer(this), ldloc:int32[exp:bool](var_9_67))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_3_28))
	stloc:char(var_10_84, callgetter:char(string::get_Chars, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)), ldloc:int32(var_3_28)))
	stloc:int32(var_11_8C, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_3_28))
	stloc:int32(var_12_9B, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:int32(var_13_A3, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_13_A3))
	stloc:int32(var_14_B3, ldfld:int32(CookieTokenizer::m_start, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_tokenLength, ldloc:CookieTokenizer(this), ldloc:int32(var_14_B3))
	stloc:char(var_15_CA, callgetter:char(string::get_Chars, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)), ldloc:int32(var_13_A3)))
	stloc:string(var_16_D2, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)))
	stloc:int32(var_17_DA, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:char(var_18_E5, callgetter:char(string::get_Chars, ldloc:string(var_16_D2), ldloc:int32(var_17_DA)))
	stloc:string(var_19_ED, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)))
	stloc:int32(var_20_F5, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:char(var_21_100, callgetter:char(string::get_Chars, ldloc:string(var_19_ED), ldloc:int32(var_20_F5)))
	stloc:string(var_22_108, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)))
	stloc:int32(var_23_110, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:char(var_24_11B, callgetter:char(string::get_Chars, ldloc:string(var_22_108), ldloc:int32(var_23_110)))
	stloc:int32(var_25_123, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_start, ldloc:CookieTokenizer(this), ldloc:int32(var_23_110))
	stfld:int32(CookieTokenizer::m_tokenLength, ldloc:CookieTokenizer(this), ldloc:int32(var_6_4E))
	stloc:int32(var_26_13B, ldfld:int32(CookieTokenizer::m_tokenLength, ldloc:CookieTokenizer(this)))
	stloc:int32(var_27_143, ldfld:int32(CookieTokenizer::m_length, ldloc:CookieTokenizer(this)))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_23_110))
	stfld:int32(CookieTokenizer::m_tokenLength, ldloc:CookieTokenizer(this), ldloc:int32(var_26_13B))
	stloc:int32(var_28_15B, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:char(var_29_16A, callgetter:char(string::get_Chars, ldfld:string(CookieTokenizer::m_tokenStream, ldloc:CookieTokenizer(this)), ldloc:int32(var_28_15B)))
	stloc:int32(var_30_172, ldfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this)))
	stloc:int32(var_31_175, ldc.i4:int32(3))
	stfld:int32(CookieTokenizer::m_index, ldloc:CookieTokenizer(this), ldloc:int32(var_31_175))
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

		// Token: 0x06000D06 RID: 3334 RVA: 0x00029874 File Offset: 0x00027A74
		internal CookieToken Next(bool first, bool parseResponseCookies)
		{
			this.Reset();
			long num = 0L;
			long num2 = 0L;
			CookieToken cookieToken = this.FindNext(num != 0L, num2 != 0L);
			this.m_eofCookie = true;
			string text = this.Extract();
			this.m_name = text;
			if (text._stringLength != 0)
			{
				CookieToken cookieToken2 = this.TokenFromName(num != 0L);
				this.m_token = cookieToken2;
				return cookieToken2;
			}
			return CookieToken.Attribute;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0002990C File Offset: 0x00027B0C
		internal void Reset()
		{
			int index = this.m_index;
			this.m_start = index;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00029928 File Offset: 0x00027B28
		internal CookieToken TokenFromName(bool parseResponseCookies)
		{
			if (!true)
			{
			}
			string name = this.m_name;
			int num;
			while (num != 0)
			{
			}
			string name2 = this.m_name;
			int num2;
			while (num2 != 0)
			{
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00029950 File Offset: 0x00027B50
		// Note: this type is marked as 'beforefieldinit'.
		static CookieTokenizer()
		{
		}

		// Token: 0x04000B24 RID: 2852
		private bool m_eofCookie;

		// Token: 0x04000B25 RID: 2853
		private int m_index;

		// Token: 0x04000B26 RID: 2854
		private int m_length;

		// Token: 0x04000B27 RID: 2855
		private string m_name;

		// Token: 0x04000B28 RID: 2856
		private bool m_quoted;

		// Token: 0x04000B29 RID: 2857
		private int m_start;

		// Token: 0x04000B2A RID: 2858
		private CookieToken m_token;

		// Token: 0x04000B2B RID: 2859
		private int m_tokenLength;

		// Token: 0x04000B2C RID: 2860
		private string m_tokenStream;

		// Token: 0x04000B2D RID: 2861
		private string m_value;

		// Token: 0x04000B2E RID: 2862
		private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;

		// Token: 0x04000B2F RID: 2863
		private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;

		// Token: 0x0200020F RID: 527
		private struct RecognizedAttribute
		{
			// Token: 0x06000D0A RID: 3338 RVA: 0x00029960 File Offset: 0x00027B60
			internal RecognizedAttribute(string name, CookieToken token)
			{
				this.m_name = name;
				this.m_token = token;
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0002997C File Offset: 0x00027B7C
			internal CookieToken Token
			{
				get
				{
					return this.m_token;
				}
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
			internal bool IsEqualTo(string value)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000B30 RID: 2864
			private string m_name;

			// Token: 0x04000B31 RID: 2865
			private CookieToken m_token;
		}
	}
}
