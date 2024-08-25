using System;

namespace System.Globalization
{
	// Token: 0x020005C3 RID: 1475
	public sealed class IdnMapping
	{
		// Token: 0x06002D20 RID: 11552 RVA: 0x00063D00 File Offset: 0x00061F00
		public IdnMapping()
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00063D14 File Offset: 0x00061F14
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				bool flag = this.allow_unassigned;
				bool flag2 = this.use_std3;
				return;
			}
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00063D34 File Offset: 0x00061F34
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06002D22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.IdnMapping::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(IdnMapping::allow_unassigned, ldloc:IdnMapping(this)))
	stloc:bool(var_1_0D, ldfld:bool(IdnMapping::use_std3, ldloc:IdnMapping(this)))
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

		// Token: 0x06002D23 RID: 11555 RVA: 0x00063D50 File Offset: 0x00061F50
		public string GetAscii(string unicode)
		{
			while (unicode == null)
			{
			}
			int stringLength = unicode._stringLength;
			long num = 0L;
			return this.GetAscii(unicode, (int)num, stringLength);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00063D74 File Offset: 0x00061F74
		public string GetAscii(string unicode, int index, int count)
		{
			while (unicode == null)
			{
			}
			int stringLength = unicode._stringLength;
			int num = 1;
			return this.Convert(unicode, index, count, num != 0);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00063DA0 File Offset: 0x00061FA0
		private string Convert(string input, int index, int count, bool toAscii)
		{
			int stringLength = input.Substring(index, count)._stringLength;
			if (stringLength == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (stringLength != 0)
			{
				string text;
				return text;
			}
			string text2;
			int stringLength2 = text2._stringLength;
			string[] array;
			return string.Join(".", array);
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00063DF8 File Offset: 0x00061FF8
		private string ToAscii(string s, int offset)
		{
			int stringLength = s._stringLength;
			long num = 0L;
			char c = s[(int)num];
			char c2 = s[(int)num];
			char c3 = s[(int)num];
			int stringLength2 = s._stringLength;
			string text = this.NamePrep(s, offset);
			if (this.use_std3)
			{
			}
			int stringLength3 = text._stringLength;
			long num2 = 0L;
			char c4 = text[(int)num2];
			int stringLength4 = text._stringLength;
			int num3 = 5;
			string text2 = this.puny.Encode(text, num3);
			return "xn--" + text2;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00063E88 File Offset: 0x00062088
		private void VerifyLength(string s, int offset)
		{
			if (s._stringLength != 0)
			{
				return;
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00063EA0 File Offset: 0x000620A0
		private string NamePrep(string s, int offset)
		{
			string text;
			if (!this.allow_unassigned)
			{
				int stringLength = text._stringLength;
				long num = 0L;
				if (stringLength == 0)
				{
				}
				UnicodeCategory unicodeCategory = char.GetUnicodeCategory(text, (int)num);
				int stringLength2 = text._stringLength;
			}
			return text;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00063ED4 File Offset: 0x000620D4
		private void VerifyProhibitedCharacters(string s, int offset)
		{
			int stringLength = s._stringLength;
			long num = 0L;
			if (stringLength == 0)
			{
			}
			UnicodeCategory unicodeCategory = char.GetUnicodeCategory(s, (int)num);
			char c = s[(int)num];
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00063F20 File Offset: 0x00062120
		private void VerifyStd3AsciiRules(string s, int offset)
		{
			int stringLength = s._stringLength;
			long num = 0L;
			char c = s[(int)num];
			int stringLength2 = s._stringLength;
			char c2 = s[(int)num];
			int stringLength3 = s._stringLength;
			long num2 = 0L;
			char c3 = s[(int)num2];
			int stringLength4 = s._stringLength;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00063F70 File Offset: 0x00062170
		public string GetUnicode(string ascii)
		{
			while (ascii == null)
			{
			}
			int stringLength = ascii._stringLength;
			long num = 0L;
			return this.GetUnicode(ascii, (int)num, stringLength);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00063F94 File Offset: 0x00062194
		public string GetUnicode(string ascii, int index, int count)
		{
			while (ascii == null)
			{
			}
			int stringLength = ascii._stringLength;
			long num = 0L;
			return this.Convert(ascii, index, count, num != 0L);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00063FC0 File Offset: 0x000621C0
		private string ToUnicode(string s, int offset)
		{
			string text4;
			int num5;
			do
			{
				int stringLength = s._stringLength;
				long num = 0L;
				long num2 = 0L;
				char c = s[(int)num];
				int stringLength2 = s._stringLength;
				string text = this.NamePrep(s, (int)num2);
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text2 = text.ToLower(invariantCulture);
				int num3 = 4;
				long num4 = 0L;
				string text3 = text2.Substring(num3);
				text4 = this.puny.Decode(text3, (int)num4);
				string text5 = this.ToAscii(text4, (int)num4);
			}
			while (num5 != 0);
			return text4;
		}

		// Token: 0x04001938 RID: 6456
		private bool allow_unassigned;

		// Token: 0x04001939 RID: 6457
		private bool use_std3;

		// Token: 0x0400193A RID: 6458
		private Punycode puny;
	}
}
