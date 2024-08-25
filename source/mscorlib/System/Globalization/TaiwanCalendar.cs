using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x020005B1 RID: 1457
	[ComVisible(true)]
	[Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x06002C29 RID: 11305 RVA: 0x0006171C File Offset: 0x0005F91C
		internal static Calendar GetDefaultInstance()
		{
			/*
An exception occurred when decompiling this method (06002C29)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.Calendar System.Globalization.TaiwanCalendar::GetDefaultInstance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x00061734 File Offset: 0x0005F934
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x00061748 File Offset: 0x0005F948
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0006175C File Offset: 0x0005F95C
		public TaiwanCalendar()
		{
			int num = 1;
			this.m_currentEraValue = num;
			this.twoDigitYearMax = num;
			base..ctor();
			if ("zh-TW" == null)
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x00061794 File Offset: 0x0005F994
		internal override int ID
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000617A4 File Offset: 0x0005F9A4
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000617C0 File Offset: 0x0005F9C0
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000617DC File Offset: 0x0005F9DC
		public override int GetDayOfMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002C30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.TaiwanCalendar::GetDayOfMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(TaiwanCalendar::helper, ldloc:TaiwanCalendar(this)))
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

		// Token: 0x06002C31 RID: 11313 RVA: 0x000617F0 File Offset: 0x0005F9F0
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x0006180C File Offset: 0x0005FA0C
		public override int GetMonthsInYear(int year, int era)
		{
			int yearOffset = this.helper.GetYearOffset(year, era, true);
			return 12;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0006182C File Offset: 0x0005FA2C
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00061848 File Offset: 0x0005FA48
		public override int GetMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002C34)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.TaiwanCalendar::GetMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(TaiwanCalendar::helper, ldloc:TaiwanCalendar(this)))
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

		// Token: 0x06002C35 RID: 11317 RVA: 0x0006185C File Offset: 0x0005FA5C
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00061878 File Offset: 0x0005FA78
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00061894 File Offset: 0x0005FA94
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			GregorianCalendarHelper gregorianCalendarHelper = this.helper;
			DateTime dateTime;
			return dateTime;
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000618AC File Offset: 0x0005FAAC
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000618C4 File Offset: 0x0005FAC4
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x000618E4 File Offset: 0x0005FAE4
		public override int TwoDigitYearMax
		{
			get
			{
				int twoDigitYearMax = this.twoDigitYearMax;
				this.twoDigitYearMax = 99;
				return 99;
			}
			set
			{
				base.VerifyWritable();
				int maxYear = this.helper.m_maxYear;
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x0006192C File Offset: 0x0005FB2C
		public override int ToFourDigitYear(int year)
		{
			int maxYear = this.helper.m_maxYear;
			return year;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00061968 File Offset: 0x0005FB68
		// Note: this type is marked as 'beforefieldinit'.
		static TaiwanCalendar()
		{
		}

		// Token: 0x040018A2 RID: 6306
		internal static EraInfo[] taiwanEraInfo;

		// Token: 0x040018A3 RID: 6307
		internal static Calendar s_defaultInstance;

		// Token: 0x040018A4 RID: 6308
		internal GregorianCalendarHelper helper;

		// Token: 0x040018A5 RID: 6309
		internal static readonly DateTime calendarMinValue;
	}
}
