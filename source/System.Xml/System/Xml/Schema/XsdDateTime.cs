using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x02000169 RID: 361
	internal struct XsdDateTime
	{
		// Token: 0x06000C6A RID: 3178 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		public XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00020B04 File Offset: 0x0001ED04
		private XsdDateTime(XsdDateTime.Parser parser)
		{
			int value__ = parser.kind.value__;
			int zoneHour = parser.zoneHour;
			XsdDateTime.DateTimeTypeCode typeCode = parser.typeCode;
			int year = parser.year;
			this.InitiateXsdDateTime(parser);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00020B3C File Offset: 0x0001ED3C
		private void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			int year = parser.year;
			int month = parser.month;
			int hour = parser.hour;
			int hour2 = parser.hour;
			int second = parser.second;
			int second2 = parser.second;
			if (year != 0)
			{
				DateTime dateTime;
				this.dt = dateTime;
			}
			XsdDateTime.XsdDateTimeKind kind = parser.kind;
			int zoneMinute = parser.zoneMinute;
			int zoneMinute2 = parser.zoneMinute;
			this.extra = (uint)kind;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		internal static bool TryParse(string text, XsdDateTimeFlags kinds, [Out] XsdDateTime result)
		{
			return true;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			int num = 1;
			this.dt = dateTime;
			if (num == 0)
			{
			}
			DateTimeKind dateTimeKind;
			if (dateTimeKind != DateTimeKind.Unspecified)
			{
				return;
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00020BEC File Offset: 0x0001EDEC
		public XsdDateTime(DateTimeOffset dateTimeOffset)
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00020BFC File Offset: 0x0001EDFC
		public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			DateTime dateTime;
			this.dt = dateTime;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00003FFD File Offset: 0x000021FD
		private XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00003FFD File Offset: 0x000021FD
		private XsdDateTime.XsdDateTimeKind InternalKind
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00020C34 File Offset: 0x0001EE34
		public int Year
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00020C44 File Offset: 0x0001EE44
		public int Month
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00020C54 File Offset: 0x0001EE54
		public int Day
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00020C64 File Offset: 0x0001EE64
		public int Hour
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00020C74 File Offset: 0x0001EE74
		public int Minute
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00020C84 File Offset: 0x0001EE84
		public int Second
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00003FFD File Offset: 0x000021FD
		public int Fraction
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00003FFD File Offset: 0x000021FD
		public int ZoneHour
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00020C94 File Offset: 0x0001EE94
		public int ZoneMinute
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C7B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.XsdDateTime::get_ZoneMinute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(XsdDateTime::extra, ldloc:valuetype System.Xml.Schema.XsdDateTime&(this)))
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

		// Token: 0x06000C7C RID: 3196 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		public static implicit operator DateTime(XsdDateTime xdt)
		{
			/*
An exception occurred when decompiling this method (06000C7C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Xml.Schema.XsdDateTime::op_Implicit(System.Xml.Schema.XsdDateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:TimeZoneInfo(var_21_38, callgetter:TimeZoneInfo(TimeZoneInfo::get_Local))
	stloc:TimeZoneInfo(var_30_4B, callgetter:TimeZoneInfo(TimeZoneInfo::get_Local))
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

		// Token: 0x06000C7D RID: 3197 RVA: 0x00020D04 File Offset: 0x0001EF04
		public static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			/*
An exception occurred when decompiling this method (06000C7D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.Xml.Schema.XsdDateTime::op_Implicit(System.Xml.Schema.XsdDateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0C, callgetter:int32(DateTime::get_Year, callgetter:DateTime[exp:valuetype [mscorlib]System.DateTime&](DateTime::get_Now)))
	stloc:int32(var_10_1A, callgetter:int32(DateTime::get_Year, callgetter:DateTime[exp:valuetype [mscorlib]System.DateTime&](DateTime::get_Now)))
	stloc:TimeZoneInfo(var_16_2A, callgetter:TimeZoneInfo(TimeZoneInfo::get_Local))
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

		// Token: 0x06000C7E RID: 3198 RVA: 0x00020D3C File Offset: 0x0001EF3C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000C7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.XsdDateTime::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	brtrue(IL_0000, ldc.i4:int32[exp:bool](26215))
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

		// Token: 0x06000C7F RID: 3199 RVA: 0x00020D74 File Offset: 0x0001EF74
		private void PrintDate(StringBuilder sb)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00020D84 File Offset: 0x0001EF84
		private void PrintTime(StringBuilder sb)
		{
			if (!true)
			{
			}
			if (this.Fraction != 0)
			{
				if (7 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00020DA0 File Offset: 0x0001EFA0
		private void PrintZone(StringBuilder sb)
		{
			int num = 90;
			StringBuilder stringBuilder = sb.Append((char)num);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		private void IntToCharArray(char[] text, int start, int value, int digits)
		{
			if (digits != 0)
			{
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		private void ShortToCharArray(char[] text, int start, int value)
		{
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDateTime()
		{
		}

		// Token: 0x0400063D RID: 1597
		private DateTime dt;

		// Token: 0x0400063E RID: 1598
		private uint extra;

		// Token: 0x0400063F RID: 1599
		private static readonly int Lzyyyy;

		// Token: 0x04000640 RID: 1600
		private static readonly int Lzyyyy_;

		// Token: 0x04000641 RID: 1601
		private static readonly int Lzyyyy_MM;

		// Token: 0x04000642 RID: 1602
		private static readonly int Lzyyyy_MM_;

		// Token: 0x04000643 RID: 1603
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x04000644 RID: 1604
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x04000645 RID: 1605
		private static readonly int LzHH;

		// Token: 0x04000646 RID: 1606
		private static readonly int LzHH_;

		// Token: 0x04000647 RID: 1607
		private static readonly int LzHH_mm;

		// Token: 0x04000648 RID: 1608
		private static readonly int LzHH_mm_;

		// Token: 0x04000649 RID: 1609
		private static readonly int LzHH_mm_ss;

		// Token: 0x0400064A RID: 1610
		private static readonly int Lz_;

		// Token: 0x0400064B RID: 1611
		private static readonly int Lz_zz;

		// Token: 0x0400064C RID: 1612
		private static readonly int Lz_zz_;

		// Token: 0x0400064D RID: 1613
		private static readonly int Lz_zz_zz;

		// Token: 0x0400064E RID: 1614
		private static readonly int Lz__;

		// Token: 0x0400064F RID: 1615
		private static readonly int Lz__mm;

		// Token: 0x04000650 RID: 1616
		private static readonly int Lz__mm_;

		// Token: 0x04000651 RID: 1617
		private static readonly int Lz__mm__;

		// Token: 0x04000652 RID: 1618
		private static readonly int Lz__mm_dd;

		// Token: 0x04000653 RID: 1619
		private static readonly int Lz___;

		// Token: 0x04000654 RID: 1620
		private static readonly int Lz___dd;

		// Token: 0x04000655 RID: 1621
		private static readonly XmlTypeCode[] typeCodes;

		// Token: 0x0200016A RID: 362
		private enum DateTimeTypeCode
		{
			// Token: 0x04000657 RID: 1623
			DateTime,
			// Token: 0x04000658 RID: 1624
			Time,
			// Token: 0x04000659 RID: 1625
			Date,
			// Token: 0x0400065A RID: 1626
			GYearMonth,
			// Token: 0x0400065B RID: 1627
			GYear,
			// Token: 0x0400065C RID: 1628
			GMonthDay,
			// Token: 0x0400065D RID: 1629
			GDay,
			// Token: 0x0400065E RID: 1630
			GMonth,
			// Token: 0x0400065F RID: 1631
			XdrDateTime
		}

		// Token: 0x0200016B RID: 363
		private enum XsdDateTimeKind
		{
			// Token: 0x04000661 RID: 1633
			Unspecified,
			// Token: 0x04000662 RID: 1634
			Zulu,
			// Token: 0x04000663 RID: 1635
			LocalWestOfZulu,
			// Token: 0x04000664 RID: 1636
			LocalEastOfZulu
		}

		// Token: 0x0200016C RID: 364
		private struct Parser
		{
			// Token: 0x06000C85 RID: 3205 RVA: 0x00020E04 File Offset: 0x0001F004
			public bool Parse(string text, XsdDateTimeFlags kinds)
			{
				this.text = text;
				int stringLength = text._stringLength;
				long num = 0L;
				this.length = stringLength;
				char c = text[(int)num];
				bool flag = char.IsWhiteSpace(c);
				if (this.length == 0)
				{
				}
				int num2 = 773;
				bool flag2 = this.ParseDate((int)num);
				if (num2 != 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num3 = this.length;
				char c2 = this.text[(int)num];
				if (num2 == 0)
				{
				}
				return this.ParseTimeAndZoneAndWhitespace((int)num);
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x00021090 File Offset: 0x0001F290
			private bool ParseDate(int start)
			{
				/*
An exception occurred when decompiling this method (06000C86)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XsdDateTime/Parser::ParseDate(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004E:
	stloc:bool(var_8_5A, call:bool(Parser::Parse2Dig, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this), ldloc:int32(start), ldc.i4:int32(-2147483648)))
	stloc:int32(var_9_63, call:int32(DateTime::DaysInMonth, ldc.i4:int32(0), ldloc:int32(start)))
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

			// Token: 0x06000C87 RID: 3207 RVA: 0x00021104 File Offset: 0x0001F304
			private bool ParseTimeAndZoneAndWhitespace(int start)
			{
				bool flag = this.ParseTime(start);
				bool flag2 = this.ParseZoneAndWhitespace(start);
				return true;
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00021124 File Offset: 0x0001F324
			private bool ParseTimeAndWhitespace(int start)
			{
				bool flag = this.ParseTime(start);
				int num = this.length;
				return flag;
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x00021144 File Offset: 0x0001F344
			private bool ParseTime(int start)
			{
				int num = this.length;
				string text = this.text;
				int num2 = this.length;
				string text2 = this.text;
				int num3 = this.length;
				string text3 = this.text;
				int num4 = this.length;
				long num5 = 0L;
				string text4 = this.text;
				int num6 = this.fraction;
				this.fraction = num4;
				int num7 = this.length;
				int num8 = this.fraction;
				if (num5 != 0L)
				{
					int num9 = this.fraction;
					if (num8 == 0)
					{
					}
					return;
				}
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x000211D0 File Offset: 0x0001F3D0
			private bool ParseZoneAndWhitespace(int start)
			{
				int num = this.length;
				string text = this.text;
				long num2 = 0L;
				char c = text[start];
				int num3 = 1;
				this.kind = (XsdDateTime.XsdDateTimeKind)num3;
				int num4 = this.length;
				if (num4 == 0)
				{
				}
				bool flag = this.Parse2Dig(start, (int)num2);
				if (num4 == 0)
				{
				}
				int num5 = this.length;
				string text2 = this.text;
				long num6 = 0L;
				char c2 = text2[start];
				if (num4 == 0)
				{
				}
				return this.Parse2Dig(start, (int)num6);
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x0002128C File Offset: 0x0001F48C
			private bool Parse4Dig(int start, int num)
			{
				/*
An exception occurred when decompiling this method (06000C8B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XsdDateTime/Parser::Parse4Dig(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Parser::length, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)))
	stloc:char(var_1_13, callgetter:char(string::get_Chars, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)), ldloc:int32(start)))
	stloc:char(var_2_20, callgetter:char(string::get_Chars, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)), ldloc:int32(start)))
	stloc:char(var_3_2D, callgetter:char(string::get_Chars, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)), ldloc:int32(start)))
	stloc:string(var_4_34, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)))
	stloc:char(var_5_3E, callgetter:char(string::get_Chars, ldloc:string(var_4_34), ldloc:int32(start)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](num), ldloc:string[exp:int32](var_4_34))
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

			// Token: 0x06000C8C RID: 3212 RVA: 0x000212E8 File Offset: 0x0001F4E8
			private bool Parse2Dig(int start, int num)
			{
				/*
An exception occurred when decompiling this method (06000C8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XsdDateTime/Parser::Parse2Dig(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Parser::length, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)))
	stloc:char(var_1_13, callgetter:char(string::get_Chars, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)), ldloc:int32(start)))
	stloc:string(var_2_1A, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)))
	stloc:char(var_3_22, callgetter:char(string::get_Chars, ldloc:string(var_2_1A), ldloc:int32(start)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](num), ldloc:string[exp:int32](var_2_1A))
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

			// Token: 0x06000C8D RID: 3213 RVA: 0x00021324 File Offset: 0x0001F524
			private bool ParseChar(int start, char ch)
			{
				/*
An exception occurred when decompiling this method (06000C8D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XsdDateTime/Parser::ParseChar(System.Int32,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Parser::length, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)))
	stloc:char(var_1_13, callgetter:char(string::get_Chars, ldfld:string(Parser::text, ldloc:valuetype System.Xml.Schema.XsdDateTime/Parser&(this)), ldloc:int32(start)))
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

			// Token: 0x06000C8E RID: 3214 RVA: 0x00003FFD File Offset: 0x000021FD
			private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x00021348 File Offset: 0x0001F548
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
			}

			// Token: 0x04000665 RID: 1637
			public XsdDateTime.DateTimeTypeCode typeCode;

			// Token: 0x04000666 RID: 1638
			public int year;

			// Token: 0x04000667 RID: 1639
			public int month;

			// Token: 0x04000668 RID: 1640
			public int day;

			// Token: 0x04000669 RID: 1641
			public int hour;

			// Token: 0x0400066A RID: 1642
			public int minute;

			// Token: 0x0400066B RID: 1643
			public int second;

			// Token: 0x0400066C RID: 1644
			public int fraction;

			// Token: 0x0400066D RID: 1645
			public XsdDateTime.XsdDateTimeKind kind;

			// Token: 0x0400066E RID: 1646
			public int zoneHour;

			// Token: 0x0400066F RID: 1647
			public int zoneMinute;

			// Token: 0x04000670 RID: 1648
			private string text;

			// Token: 0x04000671 RID: 1649
			private int length;

			// Token: 0x04000672 RID: 1650
			private static int[] Power10;
		}
	}
}
