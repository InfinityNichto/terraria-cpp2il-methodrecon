using System;
using System.IO;
using System.Text;

namespace System.Security.Util
{
	// Token: 0x0200029F RID: 671
	internal sealed class Tokenizer
	{
		// Token: 0x06001728 RID: 5928 RVA: 0x00031534 File Offset: 0x0002F734
		internal void BasicInitialization()
		{
			Tokenizer.StringMaker sharedStringMaker = SharedStatics.GetSharedStringMaker();
			this._maker = sharedStringMaker;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00031550 File Offset: 0x0002F750
		public void Recycle()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00031560 File Offset: 0x0002F760
		internal Tokenizer(string input)
		{
			this.BasicInitialization();
			this._inString = input;
			int stringLength = input._stringLength;
			this._inTokenSource = Tokenizer.TokenSource.String;
			this._inSize = stringLength;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00031598 File Offset: 0x0002F798
		internal void ChangeFormat(Encoding encoding)
		{
			if (encoding != null)
			{
				Tokenizer.TokenSource inTokenSource = this._inTokenSource;
				if (this._inTokenReader != null)
				{
					return;
				}
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00031600 File Offset: 0x0002F800
		internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
			int countTokens = stream.m_countTokens;
			Tokenizer.StringMaker maker = this._maker;
			int inSavedCharacter = this._inSavedCharacter;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000318D4 File Offset: 0x0002FAD4
		private string GetStringToken()
		{
			return this._maker.MakeString();
		}

		// Token: 0x04000BB4 RID: 2996
		public int LineNo;

		// Token: 0x04000BB5 RID: 2997
		private int _inProcessingTag;

		// Token: 0x04000BB6 RID: 2998
		private byte[] _inBytes;

		// Token: 0x04000BB7 RID: 2999
		private char[] _inChars;

		// Token: 0x04000BB8 RID: 3000
		private string _inString;

		// Token: 0x04000BB9 RID: 3001
		private int _inIndex;

		// Token: 0x04000BBA RID: 3002
		private int _inSize;

		// Token: 0x04000BBB RID: 3003
		private int _inSavedCharacter;

		// Token: 0x04000BBC RID: 3004
		private Tokenizer.TokenSource _inTokenSource;

		// Token: 0x04000BBD RID: 3005
		private Tokenizer.ITokenReader _inTokenReader;

		// Token: 0x04000BBE RID: 3006
		private Tokenizer.StringMaker _maker;

		// Token: 0x04000BBF RID: 3007
		private string[] _searchStrings;

		// Token: 0x04000BC0 RID: 3008
		private string[] _replaceStrings;

		// Token: 0x04000BC1 RID: 3009
		private int _inNestedIndex;

		// Token: 0x04000BC2 RID: 3010
		private int _inNestedSize;

		// Token: 0x04000BC3 RID: 3011
		private string _inNestedString;

		// Token: 0x020002A0 RID: 672
		private enum TokenSource
		{
			// Token: 0x04000BC5 RID: 3013
			UnicodeByteArray,
			// Token: 0x04000BC6 RID: 3014
			UTF8ByteArray,
			// Token: 0x04000BC7 RID: 3015
			ASCIIByteArray,
			// Token: 0x04000BC8 RID: 3016
			CharArray,
			// Token: 0x04000BC9 RID: 3017
			String,
			// Token: 0x04000BCA RID: 3018
			NestedStrings,
			// Token: 0x04000BCB RID: 3019
			Other
		}

		// Token: 0x020002A1 RID: 673
		[Serializable]
		internal sealed class StringMaker
		{
			// Token: 0x0600172E RID: 5934 RVA: 0x000318EC File Offset: 0x0002FAEC
			private static uint HashString(string str)
			{
			}

			// Token: 0x0600172F RID: 5935 RVA: 0x000318FC File Offset: 0x0002FAFC
			private static uint HashCharArray(char[] a, int l)
			{
			}

			// Token: 0x06001730 RID: 5936 RVA: 0x0003190C File Offset: 0x0002FB0C
			public StringMaker()
			{
			}

			// Token: 0x06001731 RID: 5937 RVA: 0x00031920 File Offset: 0x0002FB20
			private bool CompareStringAndChars(string str, char[] a, int l)
			{
				/*
An exception occurred when decompiling this method (06001731)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Util.Tokenizer/StringMaker::CompareStringAndChars(System.String,System.Char[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(str)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:char(var_2_10, callgetter:char(string::get_Chars, ldloc:string(str), ldloc:int64[exp:int32](var_1_08)))
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

			// Token: 0x06001732 RID: 5938 RVA: 0x00031944 File Offset: 0x0002FB44
			public string MakeString()
			{
				StringBuilder outStringBuilder = this._outStringBuilder;
				char[] outChars = this._outChars;
				int outIndex = this._outIndex;
				if (outStringBuilder != null)
				{
					StringBuilder outStringBuilder2 = this._outStringBuilder;
				}
				uint num = this.cStringsMax;
				StringBuilder outStringBuilder3 = this._outStringBuilder;
				if (this.cStringsMax != 0U)
				{
					if (this.aStrings != null)
					{
					}
					string[] array = this.aStrings;
					uint num2;
					if (num2 == 0U)
					{
						goto IL_00A8;
					}
					uint num3 = this.cStringsMax;
				}
				this.cStringsMax = num;
				string[] array2 = this.aStrings;
				if (num != 0U)
				{
					uint num4 = this.cStringsMax;
					string[] array3 = this.aStrings;
					while (num != 0U)
					{
					}
				}
				string[] array4 = this.aStrings;
				string text;
				if (text == null || text != null)
				{
					uint num5 = this.cStringsUsed;
					this.cStringsUsed = num5;
					return text;
				}
				IL_00A8:
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04000BCC RID: 3020
			private string[] aStrings;

			// Token: 0x04000BCD RID: 3021
			private uint cStringsMax;

			// Token: 0x04000BCE RID: 3022
			private uint cStringsUsed;

			// Token: 0x04000BCF RID: 3023
			public StringBuilder _outStringBuilder;

			// Token: 0x04000BD0 RID: 3024
			public char[] _outChars;

			// Token: 0x04000BD1 RID: 3025
			public int _outIndex;
		}

		// Token: 0x020002A2 RID: 674
		internal interface ITokenReader
		{
			// Token: 0x06001733 RID: 5939
			int Read();
		}

		// Token: 0x020002A3 RID: 675
		internal class StreamTokenReader : Tokenizer.ITokenReader
		{
			// Token: 0x06001734 RID: 5940 RVA: 0x00031A00 File Offset: 0x0002FC00
			internal StreamTokenReader(StreamReader input)
			{
				this._in = input;
			}

			// Token: 0x06001735 RID: 5941 RVA: 0x00031A1C File Offset: 0x0002FC1C
			public virtual int Read()
			{
				/*
An exception occurred when decompiling this method (06001735)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Util.Tokenizer/StreamTokenReader::Read()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StreamReader(var_0_06, ldfld:StreamReader(StreamTokenReader::_in, ldloc:StreamTokenReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(StreamTokenReader::_numCharRead, ldloc:StreamTokenReader(this)))
	stfld:int32(StreamTokenReader::_numCharRead, ldloc:StreamTokenReader(this), ldloc:int32(var_1_0D))
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

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06001736 RID: 5942 RVA: 0x00031A40 File Offset: 0x0002FC40
			internal int NumCharEncountered
			{
				get
				{
					return this._numCharRead;
				}
			}

			// Token: 0x04000BD2 RID: 3026
			internal StreamReader _in;

			// Token: 0x04000BD3 RID: 3027
			internal int _numCharRead;
		}
	}
}
