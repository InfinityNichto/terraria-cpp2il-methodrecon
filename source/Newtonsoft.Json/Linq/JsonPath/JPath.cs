using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EC RID: 236
	[Preserve]
	internal class JPath
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00017984 File Offset: 0x00015B84
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00017998 File Offset: 0x00015B98
		public List<PathFilter> Filters
		{
			[CompilerGenerated]
			get
			{
				return this.<Filters>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Filters>k__BackingField = value;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000179AC File Offset: 0x00015BAC
		public JPath(string expression)
		{
			ValidationUtils.ArgumentNotNull(expression, "expression");
			this._expression = expression;
			this.ParseMain();
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000179D4 File Offset: 0x00015BD4
		private void ParseMain()
		{
			int currentIndex = this._currentIndex;
			this.EatWhitespace();
			string expression = this._expression;
			int currentIndex2 = this._currentIndex;
			int stringLength = expression._stringLength;
			char c = expression[currentIndex2];
			string expression2 = this._expression;
			int stringLength2 = expression2._stringLength;
			int currentIndex3 = this._currentIndex;
			char c2 = expression2[currentIndex2];
			int currentIndex4 = this._currentIndex;
			this._currentIndex = currentIndex;
			List<PathFilter> list = this.<Filters>k__BackingField;
			long num = 0L;
			bool flag = this.ParsePath(list, currentIndex, num != 0L);
			int currentIndex5 = this._currentIndex;
			this.EatWhitespace();
			string expression3 = this._expression;
			int currentIndex6 = this._currentIndex;
			int stringLength3 = expression3._stringLength;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0000212A File Offset: 0x0000032A
		private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00017A90 File Offset: 0x00015C90
		private PathFilter ParseIndexer(char indexerOpenChar)
		{
			PathFilter pathFilter;
			return pathFilter;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00017AA8 File Offset: 0x00015CA8
		private PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			int currentIndex = this._currentIndex;
			string expression = this._expression;
			int stringLength = expression._stringLength;
			long num = 0L;
			long num2 = 0L;
			char c = expression[currentIndex];
			int currentIndex2 = this._currentIndex;
			this.EatWhitespace();
			int currentIndex3 = this._currentIndex;
			if (stringLength == 0)
			{
			}
			long num3 = 0L;
			if (stringLength == 0)
			{
				int currentIndex4 = this._currentIndex;
				this._currentIndex = (int)num3;
				int stringLength2 = this._expression._stringLength;
				if (stringLength2 == 0 || stringLength2 != 0)
				{
					int currentIndex5 = this._currentIndex;
					string text = this._expression.Substring(currentIndex, 42240400);
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					int num4 = Convert.ToInt32(text, invariantCulture);
					if (num2 == 0L)
					{
						goto IL_00CE;
					}
				}
				int currentIndex6 = this._currentIndex;
				if (num == 0L)
				{
				}
				string expression2 = this._expression;
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text2;
				int num5 = Convert.ToInt32(text2, invariantCulture2);
				int currentIndex7 = this._currentIndex;
				IL_00CE:
				int currentIndex8 = this._currentIndex;
				this._currentIndex = currentIndex8;
				this.EatWhitespace();
				int currentIndex9 = this._currentIndex;
				int stringLength3 = this._expression._stringLength;
				long num6 = 0L;
				if (stringLength3 != 0)
				{
				}
				if (num6 == 0L)
				{
					goto IL_0160;
				}
				CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
				string text3;
				int num7 = Convert.ToInt32(text3, invariantCulture3);
				int stringLength4 = text3._stringLength;
				CultureInfo invariantCulture4 = CultureInfo.InvariantCulture;
				string text4;
				int num8 = Convert.ToInt32(text4, invariantCulture4);
				if (!false)
				{
					goto IL_0160;
				}
				CultureInfo invariantCulture5 = CultureInfo.InvariantCulture;
				string text5;
				int num9 = Convert.ToInt32(text5, invariantCulture5);
			}
			string text7;
			string text6 = "Unexpected character while parsing path indexer: " + text7;
			IL_0160:
			return "Array index expected.";
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00017C1C File Offset: 0x00015E1C
		private void EatWhitespace()
		{
			string expression = this._expression;
			int currentIndex = this._currentIndex;
			int stringLength = expression._stringLength;
			char c = expression[currentIndex];
			int currentIndex2 = this._currentIndex;
			string expression2 = this._expression;
			this._currentIndex = currentIndex;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00017C60 File Offset: 0x00015E60
		private PathFilter ParseQuery(char indexerCloseChar)
		{
			/*
An exception occurred when decompiling this method (060009C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JsonPath.PathFilter Newtonsoft.Json.Linq.JsonPath.JPath::ParseQuery(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:int32(var_0_06))
	call:void(JPath::EnsureLength, ldloc:JPath(this), ldstr:string("Path ended with open indexer."))
	stloc:string(var_1_1F, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_2_26, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:char(var_3_2E, callgetter:char(string::get_Chars, ldloc:string(var_1_1F), ldloc:int32(var_2_26)))
	stloc:int32(var_4_35, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:int32(var_4_35))
	stloc:QueryExpression(var_5_45, call:QueryExpression(JPath::ParseExpression, ldloc:JPath(this)))
	stloc:int32(var_6_4D, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:int32(var_6_4D))
	call:void(JPath::EnsureLength, ldloc:JPath(this), ldstr:string("Path ended with open indexer."))
	call:void(JPath::EatWhitespace, ldloc:JPath(this))
	stloc:string(var_7_6E, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_8_76, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:char(var_9_81, callgetter:char(string::get_Chars, ldloc:string(var_7_6E), ldloc:int32(var_8_76)))
	stloc:string(var_12_8D, call:string(char::ToString, ldloc:char[exp:char&](var_11)))
	stloc:string(var_13_9B, call:string(string::Concat, ldstr:string("Unexpected character while parsing path indexer: "), ldloc:string(var_12_8D)))
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x00017D0C File Offset: 0x00015F0C
		private QueryExpression ParseExpression()
		{
			string expression = this._expression;
			int currentIndex = this._currentIndex;
			int stringLength = expression._stringLength;
			long num = 0L;
			this.EatWhitespace();
			string expression2 = this._expression;
			int currentIndex2 = this._currentIndex;
			char c = expression2[currentIndex2];
			int currentIndex3 = this._currentIndex;
			this._currentIndex = currentIndex3;
			int currentIndex4 = this._currentIndex;
			this.EatWhitespace();
			this.EnsureLength("Path ended with open query.");
			string expression3 = this._expression;
			int currentIndex5 = this._currentIndex;
			char c2 = expression3[currentIndex5];
			string expression4 = this._expression;
			int currentIndex6 = this._currentIndex;
			char c3 = expression4[currentIndex6];
			string expression5 = this._expression;
			int currentIndex7 = this._currentIndex;
			char c4 = expression5[currentIndex7];
			string expression6 = this._expression;
			int currentIndex8 = this._currentIndex;
			char c5 = expression6[currentIndex8];
			string expression7 = this._expression;
			int currentIndex9 = this._currentIndex;
			char c6 = expression7[currentIndex9];
			bool flag = this.Match("&&");
			if (num != 0L)
			{
			}
			if (num != 0L)
			{
				QueryOperator queryOperator = this.ParseOperator();
				this.EatWhitespace();
				this.EnsureLength("Path ended with open query.");
				object obj = this.ParseValue();
				this.EatWhitespace();
				this.EnsureLength("Path ended with open query.");
			}
			List<PathFilter> list = this.<Filters>k__BackingField;
			int currentIndex10 = this._currentIndex;
			string expression8 = this._expression;
			list._syncRoot = 1073741824;
			string expression9 = this._expression;
			int currentIndex11 = this._currentIndex;
			char c7 = expression9[currentIndex11];
			bool flag2 = this.Match("||");
			string expression10 = this._expression;
			int currentIndex12 = this._currentIndex;
			int stringLength2 = expression10._stringLength;
			return 1073741824;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00017EDC File Offset: 0x000160DC
		private object ParseValue()
		{
			/*
An exception occurred when decompiling this method (060009C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JsonPath.JPath::ParseValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_08, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_2_0F, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:char(var_3_17, callgetter:char(string::get_Chars, ldloc:string(var_1_08), ldloc:int32(var_2_0F)))
	stloc:string(var_4_1E, call:string(JPath::ReadQuotedString, ldloc:JPath(this)))
	stloc:bool(var_6_2B, call:bool(JPath::Match, ldloc:JPath(this), ldstr:string("true")))
	stloc:int32(var_8_33, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:string(var_9_3B, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:string[exp:int32](var_4_1E))
	stloc:int32(var_10_4C, ldfld:int32(string::_stringLength, ldloc:string(var_9_3B)))
	stloc:int32(var_13_54, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:string(var_14_5C, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:char[exp:int32](var_11))
	stloc:int32(var_15_6D, ldfld:int32(string::_stringLength, ldloc:string(var_14_5C)))
	stloc:CultureInfo(var_19_7A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x060009CA RID: 2506 RVA: 0x00017F68 File Offset: 0x00016168
		private string ReadQuotedString()
		{
			long num = 0L;
			int currentIndex = this._currentIndex;
			string expression = this._expression;
			this._currentIndex = (int)num;
			int stringLength = expression._stringLength;
			char c = expression[(int)num];
			int currentIndex2 = this._currentIndex;
			int currentIndex3 = this._currentIndex;
			this._currentIndex = (int)num;
			int num2 = 39;
			this._currentIndex = num2;
			int currentIndex4 = this._currentIndex;
			string expression2 = this._expression;
			int currentIndex5 = this._currentIndex;
			char c2 = expression2[currentIndex5];
			int num3 = 92;
			int currentIndex6 = this._currentIndex;
			this._currentIndex = num3;
			return this._expression;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00018024 File Offset: 0x00016224
		private bool Match(string s)
		{
			/*
An exception occurred when decompiling this method (060009CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Linq.JsonPath.JPath::Match(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(s)))
	stloc:int32(var_1_0D, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:char(var_3_17, callgetter:char(string::get_Chars, ldloc:string(s), ldloc:int64[exp:int32](var_2_0F)))
	stloc:string(var_4_1E, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_5_27, ldfld:int32(string::_stringLength, ldloc:string(var_4_1E)))
	stloc:char(var_6_31, callgetter:char(string::get_Chars, ldloc:string(var_4_1E), ldloc:int64[exp:int32](var_2_0F)))
	stloc:int32(var_7_39, ldfld:int32(string::_stringLength, ldloc:string(s)))
	stfld:int32(JPath::_currentIndex, ldloc:JPath(this), ldloc:int32(var_1_0D))
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

		// Token: 0x060009CC RID: 2508 RVA: 0x00018078 File Offset: 0x00016278
		private QueryOperator ParseOperator()
		{
			string expression = this._expression;
			int currentIndex = this._currentIndex;
			int stringLength = expression._stringLength;
			bool flag = this.Match("==");
			bool flag2 = this.Match("!=");
			bool flag3 = this.Match("<>");
			bool flag4 = this.Match("<=");
			bool flag5 = this.Match("<");
			bool flag6 = this.Match(">=");
			bool flag7 = this.Match(">");
			return "Could not read query operator.";
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0001810C File Offset: 0x0001630C
		private PathFilter ParseQuotedField(char indexerCloseChar)
		{
			/*
An exception occurred when decompiling this method (060009CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Linq.JsonPath.PathFilter Newtonsoft.Json.Linq.JsonPath.JPath::ParseQuotedField(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007F:
	stloc:string(var_12_85, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_13_8D, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:int32(var_14_96, ldfld:int32(string::_stringLength, ldloc:string(var_12_85)))
	stloc:string(var_15_9E, ldfld:string(JPath::_expression, ldloc:JPath(this)))
	stloc:int32(var_16_A6, ldfld:int32(JPath::_currentIndex, ldloc:JPath(this)))
	stloc:string(var_17_B6, call:string(char::ToString, callgetter:char[exp:char&](string::get_Chars, ldloc:string(var_15_9E), ldloc:int32(var_16_A6))))
	stloc:string(var_18_C4, call:string(string::Concat, ldstr:string("Unexpected character while parsing path indexer: "), ldloc:string(var_17_B6)))
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

		// Token: 0x060009CE RID: 2510 RVA: 0x000181E0 File Offset: 0x000163E0
		private void EnsureLength(string message)
		{
			string expression = this._expression;
			int currentIndex = this._currentIndex;
			int stringLength = expression._stringLength;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00018204 File Offset: 0x00016404
		internal IEnumerable<JToken> Evaluate(JToken t, bool errorWhenNoMatch)
		{
			return JPath.Evaluate(this.<Filters>k__BackingField, t, errorWhenNoMatch);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00018220 File Offset: 0x00016420
		internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken t, bool errorWhenNoMatch)
		{
			if (filters == null || filters != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040003CD RID: 973
		private readonly string _expression;

		// Token: 0x040003CE RID: 974
		[CompilerGenerated]
		private List<PathFilter> <Filters>k__BackingField;

		// Token: 0x040003CF RID: 975
		private int _currentIndex;
	}
}
