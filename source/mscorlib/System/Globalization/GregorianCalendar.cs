using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005AA RID: 1450
	[ComVisible(true)]
	[Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x06002B99 RID: 11161 RVA: 0x00060484 File Offset: 0x0005E684
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			if (this.m_type != (GregorianCalendarTypes)0)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				string resourceString = Environment.GetResourceString("The deserialized value of the member \"{0}\" in the class \"{1}\" is out of range.");
				string text = string.Format(currentCulture, resourceString, "type", "GregorianCalendar");
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000604C0 File Offset: 0x0005E6C0
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000604D4 File Offset: 0x0005E6D4
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

		// Token: 0x06002B9C RID: 11164 RVA: 0x000604E8 File Offset: 0x0005E6E8
		internal static Calendar GetDefaultInstance()
		{
			/*
An exception occurred when decompiling this method (06002B9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.Calendar System.Globalization.GregorianCalendar::GetDefaultInstance()

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

		// Token: 0x06002B9D RID: 11165 RVA: 0x00060500 File Offset: 0x0005E700
		public GregorianCalendar()
		{
			this.m_type = GregorianCalendarTypes.Localized;
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0006051C File Offset: 0x0005E71C
		public GregorianCalendar(GregorianCalendarTypes type)
		{
			this.m_type = type;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x00060544 File Offset: 0x0005E744
		internal override int ID
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002B9F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.GregorianCalendar::get_ID()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GregorianCalendarTypes(var_0_06, ldfld:GregorianCalendarTypes(GregorianCalendar::m_type, ldloc:GregorianCalendar(this)))
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

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00060558 File Offset: 0x0005E758
		internal virtual int GetDatePart(long ticks, int part)
		{
			/*
An exception occurred when decompiling this method (06002BA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.GregorianCalendar::GetDatePart(System.Int64,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	brtrue(IL_0000, ldloc:int64[exp:bool](var_0_05))
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

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00060590 File Offset: 0x0005E790
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			/*
An exception occurred when decompiling this method (06002BA1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Globalization.GregorianCalendar::GetAbsoluteDate(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:string(var_3_1F, call:string(Environment::GetResourceString, ldstr:string("Year, Month, and Day parameters describe an un-representable DateTime.")))
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

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetDayOfMonth(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x0000207A File Offset: 0x0000027A
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000605BC File Offset: 0x0005E7BC
		public override int GetDaysInMonth(int year, int month, int era)
		{
			if (!true)
			{
			}
			string resourceString = Environment.GetResourceString("Era value was not valid.");
			return "era";
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00060614 File Offset: 0x0005E814
		public override int GetDaysInYear(int year, int era)
		{
			return 365;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00060658 File Offset: 0x0005E858
		public override int GetEra(DateTime time)
		{
			return 1;
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0000207A File Offset: 0x0000027A
		public override int[] Eras
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetMonth(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00060668 File Offset: 0x0005E868
		public override int GetMonthsInYear(int year, int era)
		{
			return 12;
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetYear(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0006069C File Offset: 0x0005E89C
		public override bool IsLeapYear(int year, int era)
		{
			string resourceString = Environment.GetResourceString("Era value was not valid.");
			return "era" != null;
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000606F0 File Offset: 0x0005E8F0
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			DateTime dateTime;
			return dateTime;
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0006070C File Offset: 0x0005E90C
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, [Out] DateTime result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x00060724 File Offset: 0x0005E924
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00060748 File Offset: 0x0005E948
		public override int TwoDigitYearMax
		{
			get
			{
				int twoDigitYearMax = this.twoDigitYearMax;
				this.twoDigitYearMax = 2029;
				return 2029;
			}
			set
			{
				base.VerifyWritable();
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0006077C File Offset: 0x0005E97C
		public override int ToFourDigitYear(int year)
		{
			return base.ToFourDigitYear(year);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000607B0 File Offset: 0x0005E9B0
		// Note: this type is marked as 'beforefieldinit'.
		static GregorianCalendar()
		{
		}

		// Token: 0x0400185A RID: 6234
		internal GregorianCalendarTypes m_type;

		// Token: 0x0400185B RID: 6235
		internal static readonly int[] DaysToMonth365;

		// Token: 0x0400185C RID: 6236
		internal static readonly int[] DaysToMonth366;

		// Token: 0x0400185D RID: 6237
		private static Calendar s_defaultInstance;
	}
}
