using System;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005C4 RID: 1476
	internal class Bootstring
	{
		// Token: 0x06002D2E RID: 11566 RVA: 0x0006403C File Offset: 0x0006223C
		public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
		{
			this.delimiter = delimiter;
			this.base_num = baseNum;
			this.tmax = tmin;
			this.tmax = tmax;
			this.damp = skew;
			this.damp = damp;
			this.initial_n = initialBias;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00064084 File Offset: 0x00062284
		public string Encode(string s, int offset)
		{
			int num = this.initial_bias;
			int stringLength = s._stringLength;
			long num2 = 0L;
			char c = s[(int)num2];
			char c2 = s[(int)num2];
			int stringLength2 = s._stringLength;
			char c3 = this.delimiter;
			int stringLength3 = s._stringLength;
			long num3 = 0L;
			char c4 = s[(int)num3];
			char c5 = s[(int)num3];
			char c6 = s[(int)num3];
			int stringLength4 = s._stringLength;
			long num4 = 0L;
			char c7 = s[(int)num4];
			int num5 = this.base_num;
			int num6 = this.tmin;
			int num7 = this.tmax;
			int num8 = this.base_num;
			int stringLength5 = s._stringLength;
			throw new OverflowException();
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0000207A File Offset: 0x0000027A
		private char EncodeDigit(int d)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00064134 File Offset: 0x00062334
		private int DecodeDigit(char c)
		{
			return this.base_num;
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x0006414C File Offset: 0x0006234C
		private int Adapt(int delta, int numPoints, bool firstTime)
		{
			/*
An exception occurred when decompiling this method (06002D32)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.Bootstring::Adapt(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Bootstring::damp, ldloc:Bootstring(this)))
	stloc:int32(var_2_0F, ldfld:int32(Bootstring::base_num, ldloc:Bootstring(this)))
	stloc:int32(var_3_16, ldfld:int32(Bootstring::tmax, ldloc:Bootstring(this)))
	stloc:int32(var_4_1D, ldfld:int32(Bootstring::tmax, ldloc:Bootstring(this)))
	stloc:int32(var_5_25, ldfld:int32(Bootstring::skew, ldloc:Bootstring(this)))
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

		// Token: 0x06002D33 RID: 11571 RVA: 0x00064180 File Offset: 0x00062380
		public string Decode(string s, int offset)
		{
			int num = this.initial_bias;
			int stringLength = s._stringLength;
			long num2 = 0L;
			long num3 = 0L;
			char c = s[(int)num3];
			char c2 = this.delimiter;
			int stringLength2 = s._stringLength;
			long num4;
			if (num2 != 0L)
			{
				num4 = 0L;
			}
			int stringLength3 = s._stringLength;
			int num5 = this.base_num;
			long num6 = 0L;
			int num7 = this.base_num;
			int num8 = this.tmin;
			int num9 = this.tmax;
			int num10 = this.base_num;
			long num11 = 0L;
			int num12 = this.Adapt((int)num11, (int)num6, num4 != 0L);
			int stringLength4 = s._stringLength;
			return s;
		}

		// Token: 0x0400193B RID: 6459
		private readonly char delimiter;

		// Token: 0x0400193C RID: 6460
		private readonly int base_num;

		// Token: 0x0400193D RID: 6461
		private readonly int tmin;

		// Token: 0x0400193E RID: 6462
		private readonly int tmax;

		// Token: 0x0400193F RID: 6463
		private readonly int skew;

		// Token: 0x04001940 RID: 6464
		private readonly int damp;

		// Token: 0x04001941 RID: 6465
		private readonly int initial_bias;

		// Token: 0x04001942 RID: 6466
		private readonly int initial_n;
	}
}
