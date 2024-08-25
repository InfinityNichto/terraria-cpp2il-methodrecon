using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	[StructLayout(3)]
	public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x0000EF20 File Offset: 0x0000D120
		public DateTimeOffset(long ticks, TimeSpan offset)
		{
			if (!true)
			{
			}
			short num = DateTimeOffset.ValidateOffset(offset);
			this._offsetMinutes = num;
			DateTime dateTime;
			this._dateTime = dateTime;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000EF48 File Offset: 0x0000D148
		public DateTimeOffset(DateTime dateTime)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000EF74 File Offset: 0x0000D174
		public DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000EF94 File Offset: 0x0000D194
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
			if (!true)
			{
			}
			short num = DateTimeOffset.ValidateOffset(offset);
			this._offsetMinutes = num;
			DateTime dateTime;
			this._dateTime = dateTime;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
			if (!true)
			{
			}
			short num;
			this._offsetMinutes = num;
			DateTime dateTime;
			this._dateTime = dateTime;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
			if (!true)
			{
			}
			short num;
			this._offsetMinutes = num;
			DateTime dateTime;
			this._dateTime = dateTime;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public DateTime DateTime
		{
			get
			{
				DateTime clockDateTime = this.ClockDateTime;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0000F014 File Offset: 0x0000D214
		public DateTime UtcDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0000F028 File Offset: 0x0000D228
		public DateTime LocalDateTime
		{
			get
			{
				DateTime utcDateTime = this.UtcDateTime;
				long num = 0L;
				DateTime dateTime = utcDateTime.ToLocalTime(num != 0L);
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0000F048 File Offset: 0x0000D248
		private DateTime ClockDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0000F05C File Offset: 0x0000D25C
		public int Day
		{
			get
			{
				return this.ClockDateTime.GetDatePart(3);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0000F078 File Offset: 0x0000D278
		public int Hour
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600061F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeOffset::get_Hour()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_ClockDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0000F08C File Offset: 0x0000D28C
		public int Millisecond
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000620)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeOffset::get_Millisecond()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_ClockDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		public int Minute
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000621)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeOffset::get_Minute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_ClockDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		public int Month
		{
			get
			{
				return this.ClockDateTime.GetDatePart(2);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		public TimeSpan Offset
		{
			get
			{
				TimeSpan timeSpan;
				return timeSpan;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
		public int Second
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000624)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeOffset::get_Second()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_ClockDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public long Ticks
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000625)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.DateTimeOffset::get_Ticks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_ClockDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0000F108 File Offset: 0x0000D308
		public TimeSpan TimeOfDay
		{
			get
			{
				DateTime clockDateTime = this.ClockDateTime;
				TimeSpan timeSpan;
				return timeSpan;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0000F120 File Offset: 0x0000D320
		public int Year
		{
			get
			{
				DateTime clockDateTime = this.ClockDateTime;
				long num = 0L;
				return clockDateTime.GetDatePart((int)num);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000F140 File Offset: 0x0000D340
		public DateTimeOffset AddTicks(long ticks)
		{
			DateTime dateTime = this.ClockDateTime.AddTicks(ticks);
			DateTimeOffset dateTimeOffset;
			return dateTimeOffset;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000F15C File Offset: 0x0000D35C
		int IComparable.CompareTo(object obj)
		{
			if (obj != null)
			{
				DateTime utcDateTime = this.UtcDateTime;
			}
			return 1;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000F174 File Offset: 0x0000D374
		public int CompareTo(DateTimeOffset other)
		{
			DateTime utcDateTime = this.UtcDateTime;
			return 1;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000F18C File Offset: 0x0000D38C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			DateTime utcDateTime = this.UtcDateTime;
			throw new InvalidCastException();
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public bool Equals(DateTimeOffset other)
		{
			/*
An exception occurred when decompiling this method (0600062C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeOffset::Equals(System.DateTimeOffset)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_UtcDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x0600062D RID: 1581 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
		public static DateTimeOffset FromFileTime(long fileTime)
		{
			if (!true)
			{
			}
			DateTime dateTime = DateTime.FromFileTime(fileTime);
			return 1;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		public static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			if (63232 == 0)
			{
				return;
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			DateTime clockDateTime = this.ClockDateTime;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000F21C File Offset: 0x0000D41C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			short offsetMinutes = this._offsetMinutes;
			info.AddValue("OffsetMinutes", offsetMinutes);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000F240 File Offset: 0x0000D440
		private DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			Type type;
			object value = info.GetValue("DateTime", type);
			Type type2;
			object value2 = info.GetValue("OffsetMinutes", type2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000F270 File Offset: 0x0000D470
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000632)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeOffset::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, callgetter:DateTime(DateTimeOffset::get_UtcDateTime, ldloc:valuetype System.DateTimeOffset&(this)))
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

		// Token: 0x06000633 RID: 1587 RVA: 0x0000F284 File Offset: 0x0000D484
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			/*
An exception occurred when decompiling this method (06000634)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.DateTimeOffset::Parse(System.String,System.IFormatProvider,System.Globalization.DateTimeStyles)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:DateTimeFormatInfo(var_3_35, call:DateTimeFormatInfo(DateTimeFormatInfo::GetInstance, ldloc:IFormatProvider(formatProvider)))
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

		// Token: 0x06000635 RID: 1589 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			/*
An exception occurred when decompiling this method (06000635)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.DateTimeOffset::ParseExact(System.String,System.String,System.IFormatProvider,System.Globalization.DateTimeStyles)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0055:
	stloc:DateTimeFormatInfo(var_5_5B, call:DateTimeFormatInfo(DateTimeFormatInfo::GetInstance, ldloc:IFormatProvider(formatProvider)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000636 RID: 1590 RVA: 0x0000F350 File Offset: 0x0000D550
		public DateTimeOffset ToLocalTime()
		{
			long num = 0L;
			DateTimeOffset dateTimeOffset = this.ToLocalTime(num != 0L);
			DateTimeOffset dateTimeOffset2;
			return dateTimeOffset2;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000F368 File Offset: 0x0000D568
		internal DateTimeOffset ToLocalTime(bool throwOnOverflow)
		{
			DateTime dateTime = this.UtcDateTime.ToLocalTime(throwOnOverflow);
			DateTimeOffset dateTimeOffset;
			return dateTimeOffset;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000F384 File Offset: 0x0000D584
		public override string ToString()
		{
			DateTime clockDateTime = this.ClockDateTime;
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000F39C File Offset: 0x0000D59C
		public string ToString(IFormatProvider formatProvider)
		{
			DateTime clockDateTime = this.ClockDateTime;
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			DateTime clockDateTime = this.ClockDateTime;
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider formatProvider)
		{
			DateTime clockDateTime = this.ClockDateTime;
			bool flag;
			return flag;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public DateTimeOffset ToUniversalTime()
		{
			DateTime utcDateTime = this.UtcDateTime;
			DateTimeOffset dateTimeOffset;
			return dateTimeOffset;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000F400 File Offset: 0x0000D600
		public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, [Out] DateTimeOffset result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000F414 File Offset: 0x0000D614
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, [Out] DateTimeOffset result)
		{
			if (!true)
			{
			}
			bool flag;
			if (input != null)
			{
				char rawStringData = input.GetRawStringData();
				int stringLength = input._stringLength;
				return flag;
			}
			return flag;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000F43C File Offset: 0x0000D63C
		private static short ValidateOffset(TimeSpan offset)
		{
			while (17920 != 0)
			{
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000F458 File Offset: 0x0000D658
		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000F46C File Offset: 0x0000D66C
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			return "An undefined DateTimeStyles value is being used.";
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000F484 File Offset: 0x0000D684
		public static implicit operator DateTimeOffset(DateTime dateTime)
		{
			DateTimeOffset dateTimeOffset;
			return dateTimeOffset;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000F494 File Offset: 0x0000D694
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeOffset()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000257 RID: 599
		public static readonly DateTimeOffset MinValue;

		// Token: 0x04000258 RID: 600
		public static readonly DateTimeOffset MaxValue;

		// Token: 0x04000259 RID: 601
		public static readonly DateTimeOffset UnixEpoch;

		// Token: 0x0400025A RID: 602
		private readonly DateTime _dateTime;

		// Token: 0x0400025B RID: 603
		private readonly short _offsetMinutes;
	}
}
