using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x020005B3 RID: 1459
	[ComVisible(true)]
	[Serializable]
	public class ThaiBuddhistCalendar : Calendar
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00061E28 File Offset: 0x00060028
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

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00061E3C File Offset: 0x0006003C
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

		// Token: 0x06002C5D RID: 11357 RVA: 0x00061E50 File Offset: 0x00060050
		public ThaiBuddhistCalendar()
		{
			this.m_currentEraValue = 1;
			this.twoDigitYearMax = 1;
			base..ctor();
			if (!true)
			{
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x00061E74 File Offset: 0x00060074
		internal override int ID
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00061E84 File Offset: 0x00060084
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00061EA0 File Offset: 0x000600A0
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00061EBC File Offset: 0x000600BC
		public override int GetDayOfMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002C61)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.ThaiBuddhistCalendar::GetDayOfMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(ThaiBuddhistCalendar::helper, ldloc:ThaiBuddhistCalendar(this)))
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

		// Token: 0x06002C62 RID: 11362 RVA: 0x00061ED0 File Offset: 0x000600D0
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00061EEC File Offset: 0x000600EC
		public override int GetMonthsInYear(int year, int era)
		{
			int yearOffset = this.helper.GetYearOffset(year, era, true);
			return 12;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00061F0C File Offset: 0x0006010C
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00061F28 File Offset: 0x00060128
		public override int GetMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002C65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.ThaiBuddhistCalendar::GetMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(ThaiBuddhistCalendar::helper, ldloc:ThaiBuddhistCalendar(this)))
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

		// Token: 0x06002C66 RID: 11366 RVA: 0x00061F3C File Offset: 0x0006013C
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00061F58 File Offset: 0x00060158
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00061F74 File Offset: 0x00060174
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			GregorianCalendarHelper gregorianCalendarHelper = this.helper;
			DateTime dateTime;
			return dateTime;
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00061F8C File Offset: 0x0006018C
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00061FA4 File Offset: 0x000601A4
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00061FC8 File Offset: 0x000601C8
		public override int TwoDigitYearMax
		{
			get
			{
				int twoDigitYearMax = this.twoDigitYearMax;
				this.twoDigitYearMax = 2572;
				return 2572;
			}
			set
			{
				base.VerifyWritable();
				int maxYear = this.helper.m_maxYear;
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00062010 File Offset: 0x00060210
		public override int ToFourDigitYear(int year)
		{
			GregorianCalendarHelper gregorianCalendarHelper = this.helper;
			int num;
			return num;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00062030 File Offset: 0x00060230
		// Note: this type is marked as 'beforefieldinit'.
		static ThaiBuddhistCalendar()
		{
		}

		// Token: 0x040018B2 RID: 6322
		internal static EraInfo[] thaiBuddhistEraInfo;

		// Token: 0x040018B3 RID: 6323
		internal GregorianCalendarHelper helper;
	}
}
