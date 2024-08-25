using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x020005AF RID: 1455
	[ComVisible(true)]
	[Serializable]
	public class JapaneseCalendar : Calendar
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x00060EA0 File Offset: 0x0005F0A0
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x00060EB4 File Offset: 0x0005F0B4
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

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		internal static EraInfo[] GetEraInfo()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x00060EE0 File Offset: 0x0005F0E0
		private static EraInfo[] GetErasFromRegistry()
		{
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00060EF0 File Offset: 0x0005F0F0
		internal static Calendar GetDefaultInstance()
		{
			/*
An exception occurred when decompiling this method (06002BEB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.Calendar System.Globalization.JapaneseCalendar::GetDefaultInstance()

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

		// Token: 0x06002BEC RID: 11244 RVA: 0x00060F08 File Offset: 0x0005F108
		public JapaneseCalendar()
		{
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x00060F20 File Offset: 0x0005F120
		internal override int ID
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00060F30 File Offset: 0x0005F130
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return this.helper.GetDaysInMonth(year, month, era);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x00060F4C File Offset: 0x0005F14C
		public override int GetDaysInYear(int year, int era)
		{
			return this.helper.GetDaysInYear(year, era);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x00060F68 File Offset: 0x0005F168
		public override int GetDayOfMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002BF0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.JapaneseCalendar::GetDayOfMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(JapaneseCalendar::helper, ldloc:JapaneseCalendar(this)))
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

		// Token: 0x06002BF1 RID: 11249 RVA: 0x00060F7C File Offset: 0x0005F17C
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return this.helper.GetDayOfWeek(time);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00060F98 File Offset: 0x0005F198
		public override int GetMonthsInYear(int year, int era)
		{
			int yearOffset = this.helper.GetYearOffset(year, era, true);
			return 12;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		public override int GetEra(DateTime time)
		{
			return this.helper.GetEra(time);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00060FD4 File Offset: 0x0005F1D4
		public override int GetMonth(DateTime time)
		{
			/*
An exception occurred when decompiling this method (06002BF4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.JapaneseCalendar::GetMonth(System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(JapaneseCalendar::helper, ldloc:JapaneseCalendar(this)))
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

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00060FE8 File Offset: 0x0005F1E8
		public override int GetYear(DateTime time)
		{
			return this.helper.GetYear(time);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x00061004 File Offset: 0x0005F204
		public override bool IsLeapYear(int year, int era)
		{
			return this.helper.IsLeapYear(year, era);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00061020 File Offset: 0x0005F220
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			GregorianCalendarHelper gregorianCalendarHelper = this.helper;
			DateTime dateTime;
			return dateTime;
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00061038 File Offset: 0x0005F238
		public override int ToFourDigitYear(int year)
		{
			int maxYear = this.helper.m_maxYear;
			return year;
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x00061074 File Offset: 0x0005F274
		public override int[] Eras
		{
			get
			{
				return this.helper.Eras;
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0006108C File Offset: 0x0005F28C
		internal static string[] EraNames()
		{
			if (!true)
			{
			}
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			long ticks = eraInfo.ticks;
			long ticks2 = eraInfo.ticks;
			long ticks3 = eraInfo.ticks;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000610C0 File Offset: 0x0005F2C0
		internal static string[] EnglishEraNames()
		{
			if (!true)
			{
			}
			EraInfo[] eraInfo = JapaneseCalendar.GetEraInfo();
			long ticks = eraInfo.ticks;
			long ticks2 = eraInfo.ticks;
			long ticks3 = eraInfo.ticks;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000610F4 File Offset: 0x0005F2F4
		internal override bool IsValidYear(int year, int era)
		{
			/*
An exception occurred when decompiling this method (06002BFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.JapaneseCalendar::IsValidYear(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarHelper(var_0_06, ldfld:GregorianCalendarHelper(JapaneseCalendar::helper, ldloc:JapaneseCalendar(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:int32(var_2_12, call:int32(GregorianCalendarHelper::GetYearOffset, ldloc:GregorianCalendarHelper(var_0_06), ldloc:int32(year), ldloc:int32(era), ldloc:int64[exp:bool](var_1_08)))
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00061114 File Offset: 0x0005F314
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00061134 File Offset: 0x0005F334
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

		// Token: 0x06002BFF RID: 11263 RVA: 0x0006117C File Offset: 0x0005F37C
		// Note: this type is marked as 'beforefieldinit'.
		static JapaneseCalendar()
		{
		}

		// Token: 0x0400187A RID: 6266
		internal static readonly DateTime calendarMinValue;

		// Token: 0x0400187B RID: 6267
		internal static EraInfo[] japaneseEraInfo;

		// Token: 0x0400187C RID: 6268
		internal static Calendar s_defaultInstance;

		// Token: 0x0400187D RID: 6269
		internal GregorianCalendarHelper helper;
	}
}
