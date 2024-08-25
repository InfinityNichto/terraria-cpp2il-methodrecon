using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x0200016D RID: 365
	internal struct XsdDuration
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x00021358 File Offset: 0x0001F558
		public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			this.years = years;
			this.days = months;
			this.days = days;
			this.minutes = hours;
			this.minutes = minutes;
			this.nanoseconds = (uint)seconds;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0002139C File Offset: 0x0001F59C
		public XsdDuration(TimeSpan timeSpan)
		{
			long num = -2004318072L;
			this.seconds = (int)num;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000213B8 File Offset: 0x0001F5B8
		public XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000213C8 File Offset: 0x0001F5C8
		public XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			Exception ex;
			while (ex != null)
			{
			}
			this.minutes = (int)durationType;
			this.seconds = (int)durationType;
			this.nanoseconds = (uint)durationType;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000213F0 File Offset: 0x0001F5F0
		public bool IsNegative
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.XsdDuration::get_IsNegative()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(XsdDuration::nanoseconds, ldloc:valuetype System.Xml.Schema.XsdDuration&(this)))
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00003FFD File Offset: 0x000021FD
		public int Years
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00021404 File Offset: 0x0001F604
		public int Months
		{
			get
			{
				return this.months;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00021418 File Offset: 0x0001F618
		public int Days
		{
			get
			{
				return this.days;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0002142C File Offset: 0x0001F62C
		public int Hours
		{
			get
			{
				return this.hours;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00021440 File Offset: 0x0001F640
		public int Minutes
		{
			get
			{
				return this.minutes;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00021454 File Offset: 0x0001F654
		public int Seconds
		{
			get
			{
				return this.seconds;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00021468 File Offset: 0x0001F668
		public int Nanoseconds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C9B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.XsdDuration::get_Nanoseconds()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(XsdDuration::nanoseconds, ldloc:valuetype System.Xml.Schema.XsdDuration&(this)))
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

		// Token: 0x06000C9C RID: 3228 RVA: 0x0002147C File Offset: 0x0001F67C
		public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			Exception ex;
			while (ex != null)
			{
			}
			TimeSpan timeSpan;
			return timeSpan;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00021490 File Offset: 0x0001F690
		internal Exception TryToTimeSpan([Out] TimeSpan result)
		{
			Exception ex;
			return ex;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000214A0 File Offset: 0x0001F6A0
		internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, [Out] TimeSpan result)
		{
			uint num = this.nanoseconds;
			long num2 = 32768L;
			result._ticks = num2;
			int num3 = 38528;
			uint num4 = this.nanoseconds;
			result._ticks = (long)num3;
			throw new OverflowException();
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000215A4 File Offset: 0x0001F7A4
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000215B4 File Offset: 0x0001F7B4
		internal string ToString(XsdDuration.DurationType durationType)
		{
			uint num = this.nanoseconds;
			if (num == 0U)
			{
			}
			int num2 = this.months;
			if (num2 != 0)
			{
				if (num == 0U)
				{
				}
				string text = XmlConvert.ToString(num2);
			}
			int num3 = this.days;
			if (num3 != 0)
			{
				if ("0M" == null)
				{
				}
				string text2 = XmlConvert.ToString(num3);
			}
			uint num4;
			if (this.hours == 0 && this.minutes == 0 && this.seconds == 0)
			{
				num4 = this.nanoseconds;
			}
			int num5 = this.hours;
			if (num5 != 0)
			{
				if (num4 == 0U)
				{
				}
				string text3 = XmlConvert.ToString(num5);
			}
			int num6 = this.minutes;
			if (num6 != 0)
			{
				if (num4 == 0U)
				{
				}
				string text4 = XmlConvert.ToString(num6);
			}
			int num7 = this.seconds;
			if (num4 != 0U)
			{
				if (num4 == 0U)
				{
				}
				string text5 = XmlConvert.ToString(num7);
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000216A4 File Offset: 0x0001F8A4
		internal static Exception TryParse(string s, [Out] XsdDuration result)
		{
			Exception ex;
			return ex;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000216B4 File Offset: 0x0001F8B4
		internal static Exception TryParse(string s, XsdDuration.DurationType durationType, [Out] XsdDuration result)
		{
			string text;
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			int num2 = 1;
			char c2 = text[num2];
			string text2;
			if (text2 == null || text == null || text != null)
			{
				string text3;
				char c3 = text3[43159552];
				char c4 = text3[43159552];
				string text4;
				while (text4 != null)
				{
				}
				char c5 = text3[43159552];
				string text5;
				while (text5 != null)
				{
				}
				char c6 = text3[43159552];
				string text6;
				while (text6 != null)
				{
				}
				char c7 = text3[43159552];
				string text7;
				while (text7 != null)
				{
				}
				char c8 = text3[43159552];
				string text8;
				while (text8 != null)
				{
				}
				char c9 = text3[43159552];
				string text9;
				while (text9 != null)
				{
				}
				string text10;
				while (text10 != null)
				{
				}
				int num3 = 1;
				char c10 = text3[43159552];
				int num4 = 9;
				char c11 = text3[-1073741824];
				if (num3 == 0 || num4 == 0)
				{
				}
				if (text3 == null || text3 != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000217B4 File Offset: 0x0001F9B4
		private static string TryParseDigits(string s, int offset, bool eatDigits, [Out] int result, [Out] int numDigits)
		{
			return "Value '{0}' was either too large or too small for {1}.";
		}

		// Token: 0x04000673 RID: 1651
		private int years;

		// Token: 0x04000674 RID: 1652
		private int months;

		// Token: 0x04000675 RID: 1653
		private int days;

		// Token: 0x04000676 RID: 1654
		private int hours;

		// Token: 0x04000677 RID: 1655
		private int minutes;

		// Token: 0x04000678 RID: 1656
		private int seconds;

		// Token: 0x04000679 RID: 1657
		private uint nanoseconds;

		// Token: 0x0200016E RID: 366
		private enum Parts
		{
			// Token: 0x0400067B RID: 1659
			HasNone,
			// Token: 0x0400067C RID: 1660
			HasYears,
			// Token: 0x0400067D RID: 1661
			HasMonths,
			// Token: 0x0400067E RID: 1662
			HasDays = 4,
			// Token: 0x0400067F RID: 1663
			HasHours = 8,
			// Token: 0x04000680 RID: 1664
			HasMinutes = 16,
			// Token: 0x04000681 RID: 1665
			HasSeconds = 32
		}

		// Token: 0x0200016F RID: 367
		public enum DurationType
		{
			// Token: 0x04000683 RID: 1667
			Duration,
			// Token: 0x04000684 RID: 1668
			YearMonthDuration,
			// Token: 0x04000685 RID: 1669
			DayTimeDuration
		}
	}
}
