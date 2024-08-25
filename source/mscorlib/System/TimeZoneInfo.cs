using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200006A RID: 106
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06000302 RID: 770 RVA: 0x00009A10 File Offset: 0x00007C10
		private TimeZoneInfo(byte[] data, string id, bool dstDisabled)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			this._id = id;
			this._displayName = "Local";
			if ("Local" == null)
			{
			}
			this._baseUtcOffset = "Local";
			DateTime utcNow = DateTime.UtcNow;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00009A7C File Offset: 0x00007C7C
		public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules()
		{
			TimeZoneInfo.AdjustmentRule[] adjustmentRules = this._adjustmentRules;
			if (adjustmentRules != null)
			{
				DateTime dateEnd = adjustmentRules._dateEnd;
				DateTime dateEnd2 = this._adjustmentRules._dateEnd;
				TimeSpan baseUtcOffset = this._baseUtcOffset;
				TimeSpan baseUtcOffset2 = this._baseUtcOffset;
				DateTime dateTime;
				DateTime date = dateTime.Date;
				TimeZoneInfo.AdjustmentRule adjustmentRule;
				if (adjustmentRule == null || adjustmentRule != null)
				{
					int num;
					num.m_value = adjustmentRule;
					TimeZoneInfo.TransitionTime daylightTransitionEnd = adjustmentRule._daylightTransitionEnd;
					return adjustmentRule;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00009AF4 File Offset: 0x00007CF4
		private static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData)
		{
			if (!true)
			{
			}
			return TimeZoneInfo.GetLocalTimeZoneFromTzFile();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00009B0C File Offset: 0x00007D0C
		private static bool TryGetLocalTzFile([Out] byte[] rawData, [Out] string id)
		{
			if (!true)
			{
			}
			string tzEnvironmentVariable = TimeZoneInfo.GetTzEnvironmentVariable();
			if (tzEnvironmentVariable != null)
			{
				int stringLength = tzEnvironmentVariable._stringLength;
				if (stringLength == 0)
				{
					string text = Path.Combine(TimeZoneInfo.GetTimeZoneDirectory(), "localtime");
					bool flag;
					return flag;
				}
				long num = 0L;
				char c = tzEnvironmentVariable[(int)num];
				rawData.m_value = tzEnvironmentVariable;
				if (stringLength == 0)
				{
				}
				string text2 = Path.Combine(TimeZoneInfo.GetTimeZoneDirectory(), tzEnvironmentVariable);
			}
			return true;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00009B68 File Offset: 0x00007D68
		private static string GetTzEnvironmentVariable()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("TZ");
			bool flag = string.IsNullOrEmpty(environmentVariable);
			long num = 0L;
			char c = environmentVariable[(int)num];
			return environmentVariable.Substring(1);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00009B9C File Offset: 0x00007D9C
		private static bool TryLoadTzFile(string tzFilePath, byte[] rawData, string id)
		{
			/*
An exception occurred when decompiling this method (06000307)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.TimeZoneInfo::TryLoadTzFile(System.String,System.Byte[],System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stfld:uint8(uint8::m_value, ldloc:uint8[][exp:uint8&](rawData), ldloc:string[exp:uint8](var_7))
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

		// Token: 0x06000308 RID: 776 RVA: 0x00009BD4 File Offset: 0x00007DD4
		private static string FindTimeZoneIdUsingReadLink(string tzFilePath)
		{
			if (!true)
			{
			}
			string text;
			if (text != null)
			{
				string timeZoneDirectory = TimeZoneInfo.GetTimeZoneDirectory();
				string text2;
				bool flag = text2.StartsWith(timeZoneDirectory, StringComparison.Ordinal);
				int stringLength = timeZoneDirectory._stringLength;
				return text2.Substring(stringLength);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00009C0C File Offset: 0x00007E0C
		private static string GetDirectoryEntryFullPath(Interop.Sys.DirectoryEntry dirent, string currentPath)
		{
			if (dirent != null)
			{
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00009C28 File Offset: 0x00007E28
		private static void EnumerateFilesRecursively(string path, Predicate<string> condition)
		{
			if (!true)
			{
			}
			int readDirRBufferSize = Interop.Sys.GetReadDirRBufferSize();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009CCC File Offset: 0x00007ECC
		private static string FindTimeZoneId(byte[] rawData)
		{
			if ("Local" == null)
			{
			}
			string timeZoneDirectory = TimeZoneInfo.GetTimeZoneDirectory();
			if ("Local" == null)
			{
			}
			string text = Path.Combine(Path.Combine(timeZoneDirectory, "localtime"), "posixrules");
			return timeZoneDirectory;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00009D08 File Offset: 0x00007F08
		private static bool CompareTimeZoneFile(string filePath, byte[] buffer, byte[] rawData)
		{
			if (!false)
			{
				Exception endOfFile = Error.GetEndOfFile();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00009D3C File Offset: 0x00007F3C
		private static TimeZoneInfo GetLocalTimeZoneFromTzFile()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			TimeZoneInfo timeZoneInfo;
			if (timeZoneInfo != null)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (TimeZoneInfo.CreateLocalUnity() != null)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00009D68 File Offset: 0x00007F68
		private static TimeZoneInfo GetTimeZoneFromTzData(byte[] rawData, string id)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00009D78 File Offset: 0x00007F78
		private static string GetTimeZoneDirectory()
		{
			if (!true)
			{
			}
			long num = 0L;
			string environmentVariable = Environment.GetEnvironmentVariable("TZDIR");
			if (environmentVariable != null)
			{
				if ("TZDIR" == null)
				{
				}
				bool flag = environmentVariable.EndsWith((char)num);
				if ("TZDIR" == null)
				{
				}
				string text;
				return environmentVariable + text;
			}
			return "/usr/share/zoneinfo/";
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00009DBC File Offset: 0x00007FBC
		internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, [Out] bool isAmbiguousLocalDst)
		{
			if (!true)
			{
			}
			TimeZoneInfo local = TimeZoneInfo.Local;
			return 1;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00009DD4 File Offset: 0x00007FD4
		private static void TZif_GenerateAdjustmentRules([Out] TimeZoneInfo.AdjustmentRule[] rules, TimeSpan baseUtcOffset, DateTime[] dts, byte[] typeOfLocalTime, TimeZoneInfo.TZifType[] transitionType, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
		{
			if (true)
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000207A File Offset: 0x0000027A
		private static void TZif_GenerateAdjustmentRule(int index, TimeSpan timeZoneBaseUtcOffset, List<TimeZoneInfo.AdjustmentRule> rulesList, DateTime[] dts, byte[] typeOfLocalTime, TimeZoneInfo.TZifType[] transitionTypes, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00009DE4 File Offset: 0x00007FE4
		private static TimeSpan TZif_CalculateTransitionOffsetFromBase(TimeSpan transitionOffset, TimeSpan timeZoneBaseUtcOffset)
		{
			/*
An exception occurred when decompiling this method (06000313)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeZoneInfo::TZif_CalculateTransitionOffsetFromBase(System.TimeSpan,System.TimeSpan)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_18, callgetter:int32(TimeSpan::get_Hours, ldloc:TimeSpan[exp:valuetype System.TimeSpan&](var_0_0A)))
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

		// Token: 0x06000314 RID: 788 RVA: 0x00009E0C File Offset: 0x0000800C
		private static TimeZoneInfo.TZifType TZif_GetEarlyDateTransitionType(TimeZoneInfo.TZifType[] transitionTypes)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00009E1C File Offset: 0x0000801C
		private static TimeZoneInfo.AdjustmentRule TZif_CreateAdjustmentRuleForPosixFormat(string posixFormat, DateTime startTransitionDate, TimeSpan timeZoneBaseUtcOffset)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			TimeSpan timeSpan2;
			TimeSpan timeSpan3;
			TimeSpan timeSpan = TimeZoneInfo.TZif_CalculateTransitionOffsetFromBase(timeSpan2, timeSpan3);
			TimeZoneInfo.AdjustmentRule adjustmentRule;
			return adjustmentRule;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00009E44 File Offset: 0x00008044
		private static TimeSpan? TZif_ParseOffsetString(string offset)
		{
			/*
An exception occurred when decompiling this method (06000316)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.TimeSpan> System.TimeZoneInfo::TZif_ParseOffsetString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0A, call:bool(string::IsNullOrEmpty, ldstr:string("g")))
	stloc:bool(var_6_17, call:bool(int32::TryParse, ldloc:string(var_5), ldc.i4:int32(1)))
	stloc:CultureInfo(var_10_27, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000317 RID: 791 RVA: 0x00009E7C File Offset: 0x0000807C
		private static DateTime ParseTimeOfDay(string time)
		{
			/*
An exception occurred when decompiling this method (06000317)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::ParseTimeOfDay(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:valuetype System.Nullable`1<valuetype System.TimeSpan>(var_0_09, call:Nullable`1[exp:valuetype System.Nullable`1<valuetype System.TimeSpan>](TimeZoneInfo::TZif_ParseOffsetString, ldloc:string(time)))
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

		// Token: 0x06000318 RID: 792 RVA: 0x00009E98 File Offset: 0x00008098
		private static TimeZoneInfo.TransitionTime TZif_CreateTransitionTimeFromPosixRule(string date, string time)
		{
			bool flag = string.IsNullOrEmpty(date);
			return 1;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00009F3C File Offset: 0x0000813C
		private static void TZif_ParseJulianDay(string date, [Out] int month, [Out] int day)
		{
			long num2;
			do
			{
				int stringLength = date._stringLength;
				int num = 1;
				char c = date[num];
				num2 = 0L;
				int num3 = 2;
				char c2 = date[num];
				int stringLength2 = date._stringLength;
				char c3 = date[num3];
				if (stringLength2 == 0)
				{
				}
			}
			while (num2 == 0L);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00009F94 File Offset: 0x00008194
		private static bool TZif_ParseMDateRule(string dateRule, [Out] int month, [Out] int week, [Out] DayOfWeek dayOfWeek)
		{
			/*
An exception occurred when decompiling this method (0600031A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.TimeZoneInfo::TZif_ParseMDateRule(System.String,System.Int32,System.Int32,System.DayOfWeek)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:int64(var_25_3A, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](week), ldloc:int64[exp:int32](var_25_3A))
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

		// Token: 0x0600031B RID: 795 RVA: 0x00009FE8 File Offset: 0x000081E8
		private static bool TZif_ParsePosixFormat(string posixFormat, [Out] string standardName, [Out] string standardOffset, [Out] string daylightSavingsName, [Out] string daylightSavingsOffset, [Out] string start, [Out] string startTime, [Out] string end, [Out] string endTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text;
			bool flag = string.IsNullOrEmpty(text);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000A010 File Offset: 0x00008210
		private static string TZif_ParsePosixName(string posixFormat, int index)
		{
			string text;
			return text;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000A028 File Offset: 0x00008228
		private static string TZif_ParsePosixOffset(string posixFormat, int index)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000A03C File Offset: 0x0000823C
		private static void TZif_ParsePosixDateTime(string posixFormat, int index, [Out] string date, [Out] string time)
		{
			if (!true)
			{
			}
			string text = TimeZoneInfo.TZif_ParsePosixDate(posixFormat, index);
			int stringLength = posixFormat._stringLength;
			string text2 = TimeZoneInfo.TZif_ParsePosixTime(posixFormat, index);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000A064 File Offset: 0x00008264
		private static string TZif_ParsePosixDate(string posixFormat, int index)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000A078 File Offset: 0x00008278
		private static string TZif_ParsePosixTime(string posixFormat, int index)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A08C File Offset: 0x0000828C
		private static string TZif_ParsePosixString(string posixFormat, int index, Func<char, bool> breakCondition)
		{
			string text;
			return text;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A09C File Offset: 0x0000829C
		private static string TZif_GetZoneAbbreviation(string zoneAbbreviations, int index)
		{
			string text;
			return text;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000207A File Offset: 0x0000027A
		private static int TZif_ToInt32(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000207A File Offset: 0x0000027A
		private static long TZif_ToInt64(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A0AC File Offset: 0x000082AC
		private static long TZif_ToUnixTime(byte[] value, int startIndex, TimeZoneInfo.TZVersion version)
		{
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A0C0 File Offset: 0x000082C0
		private static DateTime TZif_UnixTimeToDateTime(long unixTime)
		{
			/*
An exception occurred when decompiling this method (06000326)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::TZif_UnixTimeToDateTime(System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_0B, callgetter:DateTime(DateTimeOffset::get_UtcDateTime, call:DateTimeOffset[exp:valuetype System.DateTimeOffset&](DateTimeOffset::FromUnixTimeSeconds, ldloc:int64(unixTime))))
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

		// Token: 0x06000327 RID: 807 RVA: 0x0000A0D8 File Offset: 0x000082D8
		private static void TZif_ParseRaw(byte[] data, [Out] TimeZoneInfo.TZifHead t, [Out] DateTime[] dts, [Out] byte[] typeOfLocalTime, [Out] TimeZoneInfo.TZifType[] transitionType, [Out] string zoneAbbreviations, [Out] bool[] StandardTime, [Out] bool[] GmtTime, [Out] string futureTransitionsPosixFormat)
		{
			if (t.Version != TimeZoneInfo.TZVersion.V1)
			{
				uint leapCount = t.LeapCount;
				uint typeCount = t.TypeCount;
				uint typeCount2 = t.TypeCount;
				uint isGmtCount = t.IsGmtCount;
				uint leapCount2 = t.LeapCount;
				int num = 8;
				t.Magic = (uint)num;
				return;
			}
			int num2 = 44;
			uint timeCount = t.TimeCount;
			uint timeCount2 = t.TimeCount;
			uint typeCount3 = t.TypeCount;
			uint typeCount4 = t.TypeCount;
			uint typeCount5 = t.TypeCount;
			uint timeCount3 = t.TimeCount;
			if (timeCount3 != 0U)
			{
				TimeZoneInfo.TZVersion version = t.Version;
				if (timeCount3 == 0U)
				{
				}
				DateTime dateTime = TimeZoneInfo.TZif_UnixTimeToDateTime(TimeZoneInfo.TZif_ToUnixTime(data, num2, version));
				if (t.TimeCount != 0U)
				{
					uint timeCount4 = t.TimeCount;
				}
			}
			int num3;
			if (t.TypeCount != 0U)
			{
				num3 = 1;
				uint typeCount6 = t.TypeCount;
			}
			Encoding utf = Encoding.UTF8;
			uint charCount = t.CharCount;
			uint charCount2 = t.CharCount;
			uint isStdCount = t.IsStdCount;
			uint timeCount5 = t.TimeCount;
			if (isStdCount != 0U)
			{
				uint typeCount7 = t.TypeCount;
				return;
			}
			if (t.IsGmtCount != 0U)
			{
				uint typeCount8 = t.TypeCount;
			}
			if (t.Version != TimeZoneInfo.TZVersion.V1)
			{
				num3.m_value = utf;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000A208 File Offset: 0x00008408
		public string DisplayName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000328)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TimeZoneInfo::get_DisplayName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](TimeZoneInfo::_displayName, ldloc:TimeZoneInfo(this)))
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
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000A21C File Offset: 0x0000841C
		public string StandardName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000329)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TimeZoneInfo::get_StandardName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](TimeZoneInfo::_standardDisplayName, ldloc:TimeZoneInfo(this)))
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
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000A230 File Offset: 0x00008430
		public string DaylightName
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600032A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TimeZoneInfo::get_DaylightName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](TimeZoneInfo::_daylightDisplayName, ldloc:TimeZoneInfo(this)))
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
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000A244 File Offset: 0x00008444
		public TimeSpan BaseUtcOffset
		{
			get
			{
				TimeSpan baseUtcOffset = this._baseUtcOffset;
				TimeSpan timeSpan;
				return timeSpan;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000A25C File Offset: 0x0000845C
		public bool SupportsDaylightSavingTime
		{
			get
			{
				return this._supportsDaylightSavingTime;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000A270 File Offset: 0x00008470
		private TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			DateTime dateEnd = this._adjustmentRules._dateEnd;
			DateTime dateEnd2 = this._adjustmentRules._dateEnd;
			return rule;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000A298 File Offset: 0x00008498
		public TimeSpan GetUtcOffset(DateTime dateTime)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000A2AC File Offset: 0x000084AC
		internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000A2C0 File Offset: 0x000084C0
		internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000A2D4 File Offset: 0x000084D4
		private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000A2FC File Offset: 0x000084FC
		internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000A310 File Offset: 0x00008510
		private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			while (this._supportsDaylightSavingTime)
			{
				TimeZoneInfo.AdjustmentRule[] adjustmentRules = this._adjustmentRules;
				if (adjustmentRules == null)
				{
					return;
				}
				if (cachedData._localTimeZone == null)
				{
					TimeZoneInfo timeZoneInfo = cachedData.CreateLocal();
				}
				if (adjustmentRules == null)
				{
				}
				DateTimeKind correspondingKind = cachedData.GetCorrespondingKind(this);
				if (adjustmentRules == null)
				{
				}
				TimeZoneInfo.AdjustmentRule adjustmentRule;
				if (adjustmentRule != null)
				{
					bool hasDaylightSaving = adjustmentRule.HasDaylightSaving;
					if (adjustmentRules == null)
					{
					}
					bool flag;
					return flag;
				}
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000A364 File Offset: 0x00008564
		internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000A378 File Offset: 0x00008578
		private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			/*
An exception occurred when decompiling this method (06000335)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::ConvertTime(System.DateTime,System.TimeZoneInfo,System.TimeZoneInfo,System.TimeZoneInfoOptions,System.TimeZoneInfo/CachedData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	brtrue(IL_0000, logicnot:bool(ldloc:DateTimeKind[exp:bool](var_16)))
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
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000A3D8 File Offset: 0x000085D8
		internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return 1;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000A3EC File Offset: 0x000085EC
		public bool Equals(TimeZoneInfo other)
		{
			if (other != null)
			{
				string id = this._id;
				string id2 = other._id;
				bool flag = string.Equals(id, id2, StringComparison.OrdinalIgnoreCase);
				return this.HasSameRules(other);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000A41C File Offset: 0x0000861C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000A430 File Offset: 0x00008630
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000339)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeZoneInfo::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:string(var_0_0C, ldfld:string(TimeZoneInfo::_id, ldloc:TimeZoneInfo(this)))
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

		// Token: 0x0600033A RID: 826 RVA: 0x0000A44C File Offset: 0x0000864C
		public bool HasSameRules(TimeZoneInfo other)
		{
			while (other == null)
			{
			}
			TimeSpan baseUtcOffset = this._baseUtcOffset;
			TimeSpan baseUtcOffset2 = other._baseUtcOffset;
			bool flag = baseUtcOffset != baseUtcOffset2;
			bool supportsDaylightSavingTime = this._supportsDaylightSavingTime;
			bool supportsDaylightSavingTime2 = other._supportsDaylightSavingTime;
			TimeZoneInfo.AdjustmentRule[] adjustmentRules = other._adjustmentRules;
			TimeZoneInfo.AdjustmentRule[] adjustmentRules2 = this._adjustmentRules;
			if (adjustmentRules2 != null && flag)
			{
				DateTime dateEnd = adjustmentRules2._dateEnd;
				DateTime dateEnd2 = adjustmentRules._dateEnd;
				return;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public static TimeZoneInfo Local
		{
			get
			{
				if (!true)
				{
				}
				TimeZoneInfo timeZoneInfo;
				return timeZoneInfo;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000A4CC File Offset: 0x000086CC
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600033C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TimeZoneInfo::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](TimeZoneInfo::_displayName, ldloc:TimeZoneInfo(this)))
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000A4E0 File Offset: 0x000086E0
		public static TimeZoneInfo Utc
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000A4F4 File Offset: 0x000086F4
		private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			if (!true)
			{
			}
			this._id = id;
			this._displayName = displayName;
			this._standardDisplayName = standardDisplayName;
			this._adjustmentRules = adjustmentRules;
			this._supportsDaylightSavingTime = true;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000207A File Offset: 0x0000027A
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000A530 File Offset: 0x00008730
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			object obj;
			while (daylightDisplayName == null || !true || obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000A550 File Offset: 0x00008750
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			int num = 1;
			string id = this._id;
			TimeSpan baseUtcOffset = this._baseUtcOffset;
			TimeZoneInfo.AdjustmentRule[] adjustmentRules = this._adjustmentRules;
			if (num == 0)
			{
			}
			bool supportsDaylightSavingTime = this._supportsDaylightSavingTime;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000A598 File Offset: 0x00008798
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			string id = this._id;
			info.AddValue("Id", id);
			string displayName = this._displayName;
			info.AddValue("DisplayName", displayName);
			string standardDisplayName = this._standardDisplayName;
			info.AddValue("StandardName", standardDisplayName);
			string daylightDisplayName = this._daylightDisplayName;
			info.AddValue("DaylightName", daylightDisplayName);
			TimeSpan baseUtcOffset = this._baseUtcOffset;
			TimeZoneInfo.AdjustmentRule[] adjustmentRules = this._adjustmentRules;
			info.AddValue("AdjustmentRules", adjustmentRules);
			bool supportsDaylightSavingTime = this._supportsDaylightSavingTime;
			info.AddValue("SupportsDaylightSavingTime", supportsDaylightSavingTime);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000A628 File Offset: 0x00008828
		private TimeZoneInfo(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor();
			}
			while (info == null);
			Type type;
			object value = info.GetValue("Id", type);
			if (value != null)
			{
				this._id = value;
				return;
			}
			Type type2;
			object value2 = info.GetValue("DisplayName", type2);
			if (value2 != null)
			{
				this._displayName = value2;
				return;
			}
			Type type3;
			if (info.GetValue("StandardName", type3) != null)
			{
				return;
			}
			Type type4;
			object value3 = info.GetValue("DaylightName", type4);
			if (value3 != null)
			{
				this._daylightDisplayName = value3;
				return;
			}
			Type type5;
			object value4 = info.GetValue("BaseUtcOffset", type5);
			Type type6;
			object value5 = info.GetValue("AdjustmentRules", type6);
			if (value5 != null)
			{
				if (value5 != null)
				{
					this._adjustmentRules = value5;
					if (value5 != null)
					{
						goto IL_009D;
					}
				}
				throw new InvalidCastException();
			}
			IL_009D:
			Type type7;
			object value6 = info.GetValue("SupportsDaylightSavingTime", type7);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000A6E8 File Offset: 0x000088E8
		private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, [Out] int? ruleIndex)
		{
			long num = 0L;
			return this.GetAdjustmentRuleForTime(dateTime, num != 0L, ruleIndex);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000A700 File Offset: 0x00008900
		private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, [Out] int? ruleIndex)
		{
			/*
An exception occurred when decompiling this method (06000345)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeZoneInfo/AdjustmentRule System.TimeZoneInfo::GetAdjustmentRuleForTime(System.DateTime,System.Boolean,System.Nullable`1<System.Int32>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0049:
	stfld:bool(Nullable`1::hasValue, ldloc:valuetype System.Nullable`1<int32>[exp:valuetype System.Nullable`1&](ruleIndex), ldloc:class System.TimeZoneInfo/AdjustmentRule[][exp:bool](var_6))
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

		// Token: 0x06000346 RID: 838 RVA: 0x0000A760 File Offset: 0x00008960
		private int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
		{
			DateTime dateStart = rule._dateStart;
			TimeSpan daylightDelta = previousRule._daylightDelta;
			TimeSpan baseUtcOffsetDelta = previousRule._baseUtcOffsetDelta;
			DateTime dateTime2 = this.ConvertToFromUtc(dateTime, daylightDelta, baseUtcOffsetDelta, true);
			DateTime dateStart2 = rule._dateStart;
			if (dateStart == null)
			{
			}
			DateTime dateStart3 = rule._dateStart;
			if (dateStart == null)
			{
			}
			bool flag = dateOnly >= dateStart3;
			DateTime dateEnd = rule._dateEnd;
			TimeSpan daylightDelta2 = rule._daylightDelta;
			TimeSpan baseUtcOffsetDelta2 = rule._baseUtcOffsetDelta;
			DateTime dateTime3 = this.ConvertToFromUtc(dateTime, daylightDelta2, baseUtcOffsetDelta2, true);
			DateTime dateEnd2 = rule._dateEnd;
			if (dateEnd == null)
			{
			}
			return 1;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000A7F4 File Offset: 0x000089F4
		private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			DateTime dateTime2 = this.ConvertToFromUtc(dateTime, daylightDelta, baseUtcOffsetDelta, true);
			DateTime dateTime3;
			return dateTime3;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000A810 File Offset: 0x00008A10
		private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			long num = 0L;
			DateTime dateTime2 = this.ConvertToFromUtc(dateTime, daylightDelta, baseUtcOffsetDelta, num != 0L);
			DateTime dateTime3;
			return dateTime3;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000A82C File Offset: 0x00008A2C
		private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
		{
			/*
An exception occurred when decompiling this method (06000349)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::ConvertToFromUtc(System.DateTime,System.TimeSpan,System.TimeSpan,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:TimeSpan(var_2_1E, call:TimeSpan(TimeSpan::Negate, call:TimeSpan[exp:valuetype System.TimeSpan&](TimeSpan::op_Addition, call:TimeSpan(TimeSpan::op_Addition, ldloc:TimeSpan(var_1_08), ldloc:TimeSpan(daylightDelta)), ldloc:TimeSpan(baseUtcOffsetDelta))))
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

		// Token: 0x0600034A RID: 842 RVA: 0x0000A858 File Offset: 0x00008A58
		private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, [Out] bool isAmbiguousLocalDst)
		{
			/*
An exception occurred when decompiling this method (0600034A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::ConvertUtcToTimeZone(System.Int64,System.TimeZoneInfo,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x0600034B RID: 843 RVA: 0x0000A868 File Offset: 0x00008A68
		private DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			/*
An exception occurred when decompiling this method (0600034B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DaylightTimeStruct System.TimeZoneInfo::GetDaylightTime(System.Int32,System.TimeZoneInfo/AdjustmentRule,System.Nullable`1<System.Int32>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0070:
	stloc:bool(var_14_7B, ldfld:bool(TransitionTime::_isFixedDateRule, ldfld:TransitionTime[exp:valuetype System.TimeZoneInfo/TransitionTime&](AdjustmentRule::_daylightTransitionStart, ldloc:AdjustmentRule(rule))))
	stloc:DateTime(var_16_88, ldfld:DateTime(TransitionTime::_timeOfDay, ldfld:TransitionTime[exp:valuetype System.TimeZoneInfo/TransitionTime&](AdjustmentRule::_daylightTransitionEnd, ldloc:AdjustmentRule(rule))))
	stloc:bool(var_17_95, ldfld:bool(TransitionTime::_isFixedDateRule, ldfld:TransitionTime[exp:valuetype System.TimeZoneInfo/TransitionTime&](AdjustmentRule::_daylightTransitionEnd, ldloc:AdjustmentRule(rule))))
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

		// Token: 0x0600034C RID: 844 RVA: 0x0000A90C File Offset: 0x00008B0C
		private static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
		{
			int num = 1;
			if (time != null)
			{
			}
			if (num == 0)
			{
			}
			DateTime dateStart = rule._dateStart;
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000A984 File Offset: 0x00008B84
		private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			/*
An exception occurred when decompiling this method (0600034D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeZoneInfo::GetDaylightSavingsStartOffsetFromUtc(System.TimeSpan,System.TimeZoneInfo/AdjustmentRule,System.Nullable`1<System.Int32>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:TimeSpan(var_5_33, ldfld:TimeSpan(AdjustmentRule::_baseUtcOffsetDelta, ldloc:AdjustmentRule(var_1)))
	brtrue(IL_0000, ldloc:bool(var_0_06))
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

		// Token: 0x0600034E RID: 846 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule)
		{
			TimeSpan baseUtcOffsetDelta = rule._baseUtcOffsetDelta;
			if (!true)
			{
			}
			TimeSpan timeSpan = baseUtcOffset + baseUtcOffsetDelta;
			TimeSpan daylightDelta = rule._daylightDelta;
			TimeSpan timeSpan2 = timeSpan + daylightDelta;
			return 1;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex, [Out] bool isAmbiguousLocalDst, TimeZoneInfo zone)
		{
			bool flag4;
			if (utc != null)
			{
				TimeZoneInfo.AdjustmentRule adjustmentRule;
				if (adjustmentRule != null)
				{
					bool flag = adjustmentRule.IsEndDateMarkerForEndOfYear();
					TimeSpan baseUtcOffsetDelta = adjustmentRule._baseUtcOffsetDelta;
					DateTime dateTime2;
					DateTime dateTime = dateTime2 - baseUtcOffsetDelta;
					TimeZoneInfo.AdjustmentRule adjustmentRule2;
					if (adjustmentRule2 != null)
					{
						bool flag2 = adjustmentRule2.IsStartDateMarkerForBeginningOfYear();
						bool flag3 = adjustmentRule2.IsEndDateMarkerForEndOfYear();
					}
				}
				DateTime dateTime4;
				TimeSpan timeSpan;
				DateTime dateTime3 = dateTime4 - timeSpan;
				return flag4;
			}
			return flag4;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000AB1C File Offset: 0x00008D1C
		private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule)
		{
			if (!true)
			{
				DateTime dateTime;
				int year = dateTime.Year;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000AB58 File Offset: 0x00008D58
		private static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			int num = 1;
			if (time == null || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			DateTime dateTime2;
			DateTime dateTime = dateTime2.AddYears(num2);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		private static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			int num = 1;
			if (time == null || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			DateTime dateTime2;
			DateTime dateTime = dateTime2.AddYears(num2);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
		{
			/*
An exception occurred when decompiling this method (06000353)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeZoneInfo::GetUtcOffset(System.DateTime,System.TimeZoneInfo,System.TimeZoneInfoOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x06000354 RID: 852 RVA: 0x0000AC24 File Offset: 0x00008E24
		private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000AC38 File Offset: 0x00008E38
		private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, [Out] bool isDaylightSavings)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000AC4C File Offset: 0x00008E4C
		internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, [Out] bool isDaylightSavings, [Out] bool isAmbiguousLocalDst)
		{
			/*
An exception occurred when decompiling this method (06000356)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeZoneInfo::GetUtcOffsetFromUtc(System.DateTime,System.TimeZoneInfo,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:TimeSpan(var_8_2C, ldfld:TimeSpan(AdjustmentRule::_baseUtcOffsetDelta, ldloc:AdjustmentRule(var_6)))
	stloc:TimeSpan(var_9_36, call:TimeSpan(TimeSpan::op_Addition, ldloc:TimeSpan(var_1_08), ldloc:TimeSpan(var_8_2C)))
	stloc:bool(var_10_3F, callgetter:bool(AdjustmentRule::get_HasDaylightSaving, ldloc:AdjustmentRule(var_6)))
	stloc:TimeSpan(var_11_47, ldfld:TimeSpan(TimeZoneInfo::_baseUtcOffset, ldloc:TimeZoneInfo(zone)))
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

		// Token: 0x06000357 RID: 855 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		internal static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime)
		{
			/*
An exception occurred when decompiling this method (06000357)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.TimeZoneInfo::TransitionTimeToDateTime(System.Int32,System.TimeZoneInfo/TransitionTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:int32(var_8_2F, call:int32(DateTime::DaysInMonth, ldloc:int32(year), ldloc:uint8[exp:int32](var_0)))
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

		// Token: 0x06000358 RID: 856 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules, [Out] bool adjustmentRulesSupportDst)
		{
			if (id == null)
			{
				return;
			}
			int stringLength = id._stringLength;
			if (stringLength == 0)
			{
				string text = SR.Format("The specified ID parameter '{0}' is not supported.", id);
				return;
			}
			if (stringLength == 0)
			{
			}
			bool flag = TimeZoneInfo.UtcOffsetOutOfRange(baseUtcOffset);
			long num = 63445L;
			if (num == 0L)
			{
				if (adjustmentRules != null && num != 0L)
				{
					int num2 = 1;
					adjustmentRulesSupportDst.m_value = num2 != 0;
					DateTime dateEnd = adjustmentRules._dateEnd;
					long num3 = 0L;
					if (!adjustmentRulesSupportDst)
					{
						return;
					}
					if (dateEnd == null)
					{
					}
					if (num3 == 0L || dateEnd == null)
					{
					}
					DateTime dateEnd2 = adjustmentRules._dateEnd;
				}
				return;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000AD58 File Offset: 0x00008F58
		internal static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000AD70 File Offset: 0x00008F70
		private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			/*
An exception occurred when decompiling this method (0600035A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeZoneInfo::GetUtcOffset(System.TimeSpan,System.TimeZoneInfo/AdjustmentRule)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:TimeSpan(var_2_13, call:TimeSpan(TimeSpan::op_Addition, ldloc:TimeSpan(baseUtcOffset), ldloc:TimeSpan(var_1_08)))
	stloc:bool(var_3_1A, callgetter:bool(AdjustmentRule::get_HasDaylightSaving, ldloc:AdjustmentRule(adjustmentRule)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x0600035B RID: 859 RVA: 0x0000AD9C File Offset: 0x00008F9C
		private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan;
			return TimeZoneInfo.UtcOffsetOutOfRange(timeSpan);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		private static void NormalizeAdjustmentRuleOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetTimeZoneDirectoryUnity()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, [Out] long[] data, [Out] string[] names, string standardNameCurrentYear, string daylightNameCurrentYear)
		{
			int num = 12;
			int num2 = DateTime.DaysInMonth(42170256, num);
			int num3 = 12;
			int num4 = DateTime.DaysInMonth(num2, num3);
			DateTime dateTime;
			int month = dateTime.Month;
			int year2 = dateTime.Year;
			DateTime dateTime2;
			int month2 = dateTime2.Month;
			TimeSpan timeOfDay = dateTime2.TimeOfDay;
			DateTime dateTime3;
			int month3 = dateTime3.Month;
			DateTime dateTime4;
			int month4 = dateTime4.Month;
			TimeSpan timeOfDay2 = dateTime2.TimeOfDay;
			DateTime dateTime5;
			int month5 = dateTime5.Month;
			int year3 = dateTime5.Year;
			return 41463808;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000AEC0 File Offset: 0x000090C0
		private static TimeZoneInfo CreateLocalUnity()
		{
			if (!true)
			{
			}
			int year = DateTime.UtcNow.Year;
			int num = 43;
			if ("hh\\:mm" != null)
			{
				List<TimeZoneInfo.AdjustmentRule> list;
				if (list._size == 0)
				{
				}
				List<TimeZoneInfo.AdjustmentRule> list2;
				int size = list2._size;
				if (size == 0)
				{
				}
				if (year != 0 || size == 0)
				{
				}
			}
			if (num == 0)
			{
			}
			TimeZoneInfo timeZoneInfo;
			return timeZoneInfo;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000AF0C File Offset: 0x0000910C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneInfo()
		{
			if (!true)
			{
			}
			TimeSpan timeSpan2;
			TimeSpan timeSpan = -timeSpan2;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000AF28 File Offset: 0x00009128
		internal TimeZoneInfo()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040001A3 RID: 419
		private readonly string _id;

		// Token: 0x040001A4 RID: 420
		private readonly string _displayName;

		// Token: 0x040001A5 RID: 421
		private readonly string _standardDisplayName;

		// Token: 0x040001A6 RID: 422
		private readonly string _daylightDisplayName;

		// Token: 0x040001A7 RID: 423
		private readonly TimeSpan _baseUtcOffset;

		// Token: 0x040001A8 RID: 424
		private readonly bool _supportsDaylightSavingTime;

		// Token: 0x040001A9 RID: 425
		private readonly TimeZoneInfo.AdjustmentRule[] _adjustmentRules;

		// Token: 0x040001AA RID: 426
		private static readonly TimeZoneInfo s_utcTimeZone;

		// Token: 0x040001AB RID: 427
		private static TimeZoneInfo.CachedData s_cachedData;

		// Token: 0x040001AC RID: 428
		private static readonly DateTime s_maxDateOnly;

		// Token: 0x040001AD RID: 429
		private static readonly DateTime s_minDateOnly;

		// Token: 0x040001AE RID: 430
		private static readonly TimeSpan MaxOffset;

		// Token: 0x040001AF RID: 431
		private static readonly TimeSpan MinOffset;

		// Token: 0x0200006B RID: 107
		private struct TZifType
		{
			// Token: 0x06000362 RID: 866 RVA: 0x0000AF3C File Offset: 0x0000913C
			public TZifType(byte[] data, int index)
			{
				while (data == null)
				{
				}
			}

			// Token: 0x040001B0 RID: 432
			public readonly TimeSpan UtcOffset;

			// Token: 0x040001B1 RID: 433
			public readonly bool IsDst;

			// Token: 0x040001B2 RID: 434
			public readonly byte AbbreviationIndex;
		}

		// Token: 0x0200006C RID: 108
		private struct TZifHead
		{
			// Token: 0x06000363 RID: 867 RVA: 0x0000AF50 File Offset: 0x00009150
			public TZifHead(byte[] data, int index)
			{
				int num = 1;
				if (data != null)
				{
					if (num == 0)
					{
					}
					this.Magic = (uint)num;
					this.Version = (TimeZoneInfo.TZVersion)num;
					if (num == 0)
					{
					}
					this.IsGmtCount = (uint)num;
					this.IsStdCount = (uint)num;
					this.LeapCount = (uint)num;
					this.TimeCount = (uint)num;
					this.TypeCount = (uint)num;
					this.CharCount = (uint)num;
					return;
				}
			}

			// Token: 0x040001B3 RID: 435
			public readonly uint Magic;

			// Token: 0x040001B4 RID: 436
			public readonly TimeZoneInfo.TZVersion Version;

			// Token: 0x040001B5 RID: 437
			public readonly uint IsGmtCount;

			// Token: 0x040001B6 RID: 438
			public readonly uint IsStdCount;

			// Token: 0x040001B7 RID: 439
			public readonly uint LeapCount;

			// Token: 0x040001B8 RID: 440
			public readonly uint TimeCount;

			// Token: 0x040001B9 RID: 441
			public readonly uint TypeCount;

			// Token: 0x040001BA RID: 442
			public readonly uint CharCount;
		}

		// Token: 0x0200006D RID: 109
		private enum TZVersion : byte
		{
			// Token: 0x040001BC RID: 444
			V1,
			// Token: 0x040001BD RID: 445
			V2,
			// Token: 0x040001BE RID: 446
			V3
		}

		// Token: 0x0200006E RID: 110
		[Serializable]
		public sealed class AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback
		{
			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000AFA8 File Offset: 0x000091A8
			public DateTime DateStart
			{
				get
				{
					DateTime dateStart = this._dateStart;
					DateTime dateTime;
					return dateTime;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000365 RID: 869 RVA: 0x0000AFC0 File Offset: 0x000091C0
			public DateTime DateEnd
			{
				get
				{
					DateTime dateEnd = this._dateEnd;
					DateTime dateTime;
					return dateTime;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000AFD8 File Offset: 0x000091D8
			public TimeSpan DaylightDelta
			{
				get
				{
					TimeSpan daylightDelta = this._daylightDelta;
					TimeSpan timeSpan;
					return timeSpan;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000367 RID: 871 RVA: 0x0000AFF0 File Offset: 0x000091F0
			public TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				get
				{
					bool isFixedDateRule = this._daylightTransitionStart._isFixedDateRule;
					TimeZoneInfo.TransitionTime transitionTime;
					transitionTime._isFixedDateRule = isFixedDateRule;
					return transitionTime;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000368 RID: 872 RVA: 0x0000B014 File Offset: 0x00009214
			public TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				get
				{
					bool isFixedDateRule = this._daylightTransitionEnd._isFixedDateRule;
					DateTime timeOfDay = this._daylightTransitionEnd._timeOfDay;
					TimeZoneInfo.TransitionTime transitionTime;
					transitionTime._isFixedDateRule = isFixedDateRule;
					transitionTime._timeOfDay = timeOfDay;
					return transitionTime;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000369 RID: 873 RVA: 0x0000B048 File Offset: 0x00009248
			internal TimeSpan BaseUtcOffsetDelta
			{
				get
				{
					TimeSpan baseUtcOffsetDelta = this._baseUtcOffsetDelta;
					TimeSpan timeSpan;
					return timeSpan;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000B060 File Offset: 0x00009260
			internal bool NoDaylightTransitions
			{
				get
				{
					return this._noDaylightTransitions;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600036B RID: 875 RVA: 0x0000B074 File Offset: 0x00009274
			internal bool HasDaylightSaving
			{
				get
				{
					int num = 1;
					TimeSpan daylightDelta = this._daylightDelta;
					if (num == 0)
					{
					}
					bool isFixedDateRule = this._daylightTransitionStart._isFixedDateRule;
					TimeZoneInfo.TransitionTime daylightTransitionStart = this._daylightTransitionStart;
					if (!isFixedDateRule)
					{
					}
					bool isFixedDateRule2 = this._daylightTransitionEnd._isFixedDateRule;
					DateTime timeOfDay = this._daylightTransitionEnd._timeOfDay;
					TimeZoneInfo.TransitionTime daylightTransitionEnd = this._daylightTransitionEnd;
					if (!isFixedDateRule2)
					{
					}
					bool flag;
					return flag;
				}
			}

			// Token: 0x0600036C RID: 876 RVA: 0x0000B0D4 File Offset: 0x000092D4
			public bool Equals(TimeZoneInfo.AdjustmentRule other)
			{
				int num = 1;
				if (other != null)
				{
					DateTime dateStart = this._dateStart;
					DateTime dateStart2 = other._dateStart;
					if (num == 0)
					{
					}
					DateTime dateEnd = this._dateEnd;
					DateTime dateEnd2 = other._dateEnd;
					if (num == 0)
					{
					}
					bool flag = dateEnd == dateEnd2;
					TimeSpan daylightDelta = this._daylightDelta;
					TimeSpan daylightDelta2 = other._daylightDelta;
					if (num == 0)
					{
					}
					bool flag2 = daylightDelta == daylightDelta2;
					TimeSpan baseUtcOffsetDelta = this._baseUtcOffsetDelta;
					TimeSpan baseUtcOffsetDelta2 = other._baseUtcOffsetDelta;
					if (num == 0)
					{
					}
					bool flag3 = baseUtcOffsetDelta == baseUtcOffsetDelta2;
					bool isFixedDateRule = other._daylightTransitionEnd._isFixedDateRule;
					DateTime timeOfDay = other._daylightTransitionEnd._timeOfDay;
					bool isFixedDateRule2 = other._daylightTransitionStart._isFixedDateRule;
					bool flag4;
					return flag4;
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000B180 File Offset: 0x00009380
			public override int GetHashCode()
			{
				int num;
				return num;
			}

			// Token: 0x0600036E RID: 878 RVA: 0x0000B190 File Offset: 0x00009390
			private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				bool isFixedDateRule = daylightTransitionStart._isFixedDateRule;
				bool isFixedDateRule2 = daylightTransitionEnd._isFixedDateRule;
				this._dateStart = dateStart;
				this._dateEnd = dateEnd;
				this._daylightDelta = daylightDelta;
				bool isFixedDateRule3 = daylightTransitionStart._isFixedDateRule;
				this._daylightTransitionStart._isFixedDateRule = isFixedDateRule3;
				bool isFixedDateRule4 = daylightTransitionEnd._isFixedDateRule;
				this._noDaylightTransitions = noDaylightTransitions;
				this._daylightTransitionEnd._isFixedDateRule = isFixedDateRule4;
				this._baseUtcOffsetDelta = baseUtcOffsetDelta;
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0000B200 File Offset: 0x00009400
			public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				/*
An exception occurred when decompiling this method (0600036F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeZoneInfo/AdjustmentRule System.TimeZoneInfo/AdjustmentRule::CreateAdjustmentRule(System.DateTime,System.DateTime,System.TimeSpan,System.TimeZoneInfo/TransitionTime,System.TimeZoneInfo/TransitionTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:bool(TransitionTime::_isFixedDateRule, ldloc:TransitionTime[exp:valuetype System.TimeZoneInfo/TransitionTime&](daylightTransitionStart)))
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

			// Token: 0x06000370 RID: 880 RVA: 0x0000B214 File Offset: 0x00009414
			internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				/*
An exception occurred when decompiling this method (06000370)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeZoneInfo/AdjustmentRule System.TimeZoneInfo/AdjustmentRule::CreateAdjustmentRule(System.DateTime,System.DateTime,System.TimeSpan,System.TimeZoneInfo/TransitionTime,System.TimeZoneInfo/TransitionTime,System.TimeSpan,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(TransitionTime::_isFixedDateRule, ldloc:TransitionTime[exp:valuetype System.TimeZoneInfo/TransitionTime&](daylightTransitionStart)))
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

			// Token: 0x06000371 RID: 881 RVA: 0x0000B228 File Offset: 0x00009428
			internal bool IsStartDateMarkerForBeginningOfYear()
			{
				while (!this._noDaylightTransitions)
				{
					byte month = this._daylightTransitionStart._month;
					byte day = this._daylightTransitionStart._day;
					TimeZoneInfo.TransitionTime daylightTransitionStart = this._daylightTransitionStart;
					int num;
					if (num != 0)
					{
						return;
					}
					TimeZoneInfo.TransitionTime daylightTransitionStart2 = this._daylightTransitionStart;
					int num2;
					if (num2 != 0)
					{
						return;
					}
					TimeZoneInfo.TransitionTime daylightTransitionStart3 = this._daylightTransitionStart;
					int num3;
					if (num3 != 0)
					{
						return;
					}
				}
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000B27C File Offset: 0x0000947C
			internal bool IsEndDateMarkerForEndOfYear()
			{
				while (!this._noDaylightTransitions)
				{
					byte month = this._daylightTransitionEnd._month;
					byte day = this._daylightTransitionEnd._day;
					TimeZoneInfo.TransitionTime daylightTransitionEnd = this._daylightTransitionEnd;
					int num;
					if (num != 0)
					{
						return;
					}
					TimeZoneInfo.TransitionTime daylightTransitionEnd2 = this._daylightTransitionEnd;
					int num2;
					if (num2 != 0)
					{
						return;
					}
					TimeZoneInfo.TransitionTime daylightTransitionEnd3 = this._daylightTransitionEnd;
					int num3;
					if (num3 != 0)
					{
						return;
					}
				}
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000B2D0 File Offset: 0x000094D0
			private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
			{
				DateTimeKind dateTimeKind;
				if (dateTimeKind != DateTimeKind.Unspecified)
				{
				}
				DateTimeKind dateTimeKind2;
				if (dateTimeKind2 != DateTimeKind.Unspecified)
				{
				}
				bool isFixedDateRule = daylightTransitionEnd._isFixedDateRule;
				if (!isFixedDateRule)
				{
				}
				long num = 63445L;
				if (!isFixedDateRule)
				{
					if (!isFixedDateRule)
					{
					}
					DateTimeKind dateTimeKind3;
					if (dateTimeKind3 != DateTimeKind.Unspecified || num == 0L)
					{
					}
					DateTimeKind dateTimeKind4;
					if (dateTimeKind4 != DateTimeKind.Unspecified || num == 0L)
					{
					}
					return;
				}
			}

			// Token: 0x06000374 RID: 884 RVA: 0x0000B318 File Offset: 0x00009518
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				bool isFixedDateRule = this._daylightTransitionStart._isFixedDateRule;
				DateTime dateStart = this._dateStart;
				DateTime dateEnd = this._dateEnd;
				TimeSpan daylightDelta = this._daylightDelta;
				bool isFixedDateRule2 = this._daylightTransitionEnd._isFixedDateRule;
				DateTime timeOfDay = this._daylightTransitionEnd._timeOfDay;
				bool noDaylightTransitions = this._noDaylightTransitions;
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0000B36C File Offset: 0x0000956C
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				while (info == null)
				{
				}
				DateTime dateStart = this._dateStart;
				info.AddValue("DateStart", dateStart);
				DateTime dateEnd = this._dateEnd;
				info.AddValue("DateEnd", dateEnd);
				TimeSpan daylightDelta = this._daylightDelta;
				bool isFixedDateRule = this._daylightTransitionStart._isFixedDateRule;
				bool isFixedDateRule2 = this._daylightTransitionEnd._isFixedDateRule;
				DateTime timeOfDay = this._daylightTransitionEnd._timeOfDay;
				TimeSpan baseUtcOffsetDelta = this._baseUtcOffsetDelta;
				bool noDaylightTransitions = this._noDaylightTransitions;
				info.AddValue("NoDaylightTransitions", noDaylightTransitions);
			}

			// Token: 0x06000376 RID: 886 RVA: 0x0000B3EC File Offset: 0x000095EC
			private AdjustmentRule(SerializationInfo info, StreamingContext context)
			{
				do
				{
					base..ctor();
				}
				while (info == null);
				if (!true)
				{
				}
				Type type;
				object value = info.GetValue("DateStart", type);
				Type type2;
				object value2 = info.GetValue("DateEnd", type2);
				Type type3;
				object value3 = info.GetValue("DaylightDelta", type3);
				Type type4;
				object value4 = info.GetValue("DaylightTransitionStart", type4);
				Type type5;
				object value5 = info.GetValue("DaylightTransitionEnd", type5);
				Type type6;
				if (info.GetValueNoThrow("BaseUtcOffsetDelta", type6) != null)
				{
				}
				Type type7;
				if (info.GetValueNoThrow("NoDaylightTransitions", type7) != null)
				{
				}
			}

			// Token: 0x06000377 RID: 887 RVA: 0x0000B470 File Offset: 0x00009670
			internal AdjustmentRule()
			{
				throw new NotSupportedException();
			}

			// Token: 0x040001BF RID: 447
			private readonly DateTime _dateStart;

			// Token: 0x040001C0 RID: 448
			private readonly DateTime _dateEnd;

			// Token: 0x040001C1 RID: 449
			private readonly TimeSpan _daylightDelta;

			// Token: 0x040001C2 RID: 450
			private readonly TimeZoneInfo.TransitionTime _daylightTransitionStart;

			// Token: 0x040001C3 RID: 451
			private readonly TimeZoneInfo.TransitionTime _daylightTransitionEnd;

			// Token: 0x040001C4 RID: 452
			private readonly TimeSpan _baseUtcOffsetDelta;

			// Token: 0x040001C5 RID: 453
			private readonly bool _noDaylightTransitions;
		}

		// Token: 0x0200006F RID: 111
		[Serializable]
		public readonly struct TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0000B484 File Offset: 0x00009684
			public DateTime TimeOfDay
			{
				get
				{
					DateTime dateTime;
					return dateTime;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000379 RID: 889 RVA: 0x0000B494 File Offset: 0x00009694
			public int Month
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000379)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeZoneInfo/TransitionTime::get_Month()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(TransitionTime::_month, ldloc:valuetype System.TimeZoneInfo/TransitionTime&(this)))
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

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600037A RID: 890 RVA: 0x0000B4A8 File Offset: 0x000096A8
			public int Week
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600037A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeZoneInfo/TransitionTime::get_Week()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(TransitionTime::_week, ldloc:valuetype System.TimeZoneInfo/TransitionTime&(this)))
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

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600037B RID: 891 RVA: 0x0000B4BC File Offset: 0x000096BC
			public int Day
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600037B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeZoneInfo/TransitionTime::get_Day()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(TransitionTime::_day, ldloc:valuetype System.TimeZoneInfo/TransitionTime&(this)))
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

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0000B4D0 File Offset: 0x000096D0
			public DayOfWeek DayOfWeek
			{
				get
				{
					return this._dayOfWeek;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600037D RID: 893 RVA: 0x0000B4E4 File Offset: 0x000096E4
			public bool IsFixedDateRule
			{
				get
				{
					return this._isFixedDateRule;
				}
			}

			// Token: 0x0600037E RID: 894 RVA: 0x0000B4F8 File Offset: 0x000096F8
			public override bool Equals(object obj)
			{
				if (obj != null)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0000B50C File Offset: 0x0000970C
			public static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				bool isFixedDateRule = t1._isFixedDateRule;
				bool flag;
				return flag;
			}

			// Token: 0x06000380 RID: 896 RVA: 0x0000B524 File Offset: 0x00009724
			public bool Equals(TimeZoneInfo.TransitionTime other)
			{
				bool isFixedDateRule = other._isFixedDateRule;
				bool isFixedDateRule2 = this._isFixedDateRule;
				byte month = this._month;
				byte month2 = other._month;
				bool isFixedDateRule3 = other._isFixedDateRule;
				byte week = this._week;
				byte week2 = other._week;
				DayOfWeek dayOfWeek = this._dayOfWeek;
				DayOfWeek dayOfWeek2 = other._dayOfWeek;
				bool flag;
				return flag;
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000B58C File Offset: 0x0000978C
			public override int GetHashCode()
			{
				/*
An exception occurred when decompiling this method (06000381)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeZoneInfo/TransitionTime::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(TransitionTime::_month, ldloc:valuetype System.TimeZoneInfo/TransitionTime&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(TransitionTime::_week, ldloc:valuetype System.TimeZoneInfo/TransitionTime&(this)))
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

			// Token: 0x06000382 RID: 898 RVA: 0x0000B5A8 File Offset: 0x000097A8
			private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				TimeZoneInfo.TransitionTime.ValidateTransitionTime(timeOfDay, month, week, day, dayOfWeek);
				this._timeOfDay = timeOfDay;
				this._month = (byte)month;
				this._week = (byte)week;
				this._day = (byte)day;
				this._dayOfWeek = dayOfWeek;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000B5E8 File Offset: 0x000097E8
			public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				TimeZoneInfo.TransitionTime transitionTime;
				transitionTime._timeOfDay = timeOfDay;
				transitionTime._month = (byte)month;
				transitionTime._day = (byte)day;
				transitionTime._week = 1;
				transitionTime._isFixedDateRule = true;
				return transitionTime;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x0000B61C File Offset: 0x0000981C
			public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
			{
				TimeZoneInfo.TransitionTime.ValidateTransitionTime(timeOfDay, month, week, 1, dayOfWeek);
				TimeZoneInfo.TransitionTime transitionTime;
				transitionTime._timeOfDay = timeOfDay;
				transitionTime._month = (byte)month;
				transitionTime._week = (byte)week;
				transitionTime._day = 1;
				transitionTime._dayOfWeek = dayOfWeek;
				return transitionTime;
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0000B658 File Offset: 0x00009858
			private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				if (timeOfDay.Kind != DateTimeKind.Unspecified)
				{
					return;
				}
				if (22859 == 0)
				{
					return;
				}
			}

			// Token: 0x06000386 RID: 902 RVA: 0x0000B67C File Offset: 0x0000987C
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				byte month = this._month;
				byte week = this._week;
				byte day = this._day;
				DayOfWeek dayOfWeek = this._dayOfWeek;
			}

			// Token: 0x06000387 RID: 903 RVA: 0x0000B6A8 File Offset: 0x000098A8
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				while (info == null)
				{
				}
				byte month = this._month;
				info.AddValue("Month", month);
				byte week = this._week;
				info.AddValue("Week", week);
				byte day = this._day;
				info.AddValue("Day", day);
				DayOfWeek dayOfWeek = this._dayOfWeek;
				bool isFixedDateRule = this._isFixedDateRule;
				info.AddValue("IsFixedDateRule", isFixedDateRule);
			}

			// Token: 0x06000388 RID: 904 RVA: 0x0000B710 File Offset: 0x00009910
			private TransitionTime(SerializationInfo info, StreamingContext context)
			{
				while (info == null)
				{
				}
				Type type;
				object value = info.GetValue("TimeOfDay", type);
				Type type2;
				object value2 = info.GetValue("Month", type2);
				Type type3;
				object value3 = info.GetValue("Week", type3);
				Type type4;
				object value4 = info.GetValue("Day", type4);
				Type type5;
				object value5 = info.GetValue("DayOfWeek", type5);
				Type type6;
				object value6 = info.GetValue("IsFixedDateRule", type6);
			}

			// Token: 0x040001C6 RID: 454
			private readonly DateTime _timeOfDay;

			// Token: 0x040001C7 RID: 455
			private readonly byte _month;

			// Token: 0x040001C8 RID: 456
			private readonly byte _week;

			// Token: 0x040001C9 RID: 457
			private readonly byte _day;

			// Token: 0x040001CA RID: 458
			private readonly DayOfWeek _dayOfWeek;

			// Token: 0x040001CB RID: 459
			private readonly bool _isFixedDateRule;
		}

		// Token: 0x02000070 RID: 112
		private sealed class CachedData
		{
			// Token: 0x06000389 RID: 905 RVA: 0x0000B77C File Offset: 0x0000997C
			private TimeZoneInfo CreateLocal()
			{
				if (this._localTimeZone != null)
				{
				}
				if (!true)
				{
				}
				TimeZoneInfo timeZoneInfo;
				string daylightDisplayName = timeZoneInfo._daylightDisplayName;
				TimeSpan baseUtcOffset = timeZoneInfo._baseUtcOffset;
				string id = timeZoneInfo._id;
				string displayName = timeZoneInfo._displayName;
				string standardDisplayName = timeZoneInfo._standardDisplayName;
				TimeZoneInfo.AdjustmentRule[] adjustmentRules = timeZoneInfo._adjustmentRules;
				long num = 0L;
				if (true)
				{
					Monitor.Exit(this);
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600038A RID: 906 RVA: 0x0000B7F4 File Offset: 0x000099F4
			public TimeZoneInfo Local
			{
				get
				{
					TimeZoneInfo localTimeZone = this._localTimeZone;
					if (localTimeZone != null)
					{
						return localTimeZone;
					}
					return this.CreateLocal();
				}
			}

			// Token: 0x0600038B RID: 907 RVA: 0x0000B814 File Offset: 0x00009A14
			public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
			{
				if (!true)
				{
				}
				TimeZoneInfo localTimeZone = this._localTimeZone;
				return DateTimeKind.Utc;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x0000B82C File Offset: 0x00009A2C
			public CachedData()
			{
			}

			// Token: 0x040001CC RID: 460
			private TimeZoneInfo _localTimeZone;
		}

		// Token: 0x02000071 RID: 113
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x0600038D RID: 909 RVA: 0x0000B840 File Offset: 0x00009A40
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0000B854 File Offset: 0x00009A54
			internal bool <FindTimeZoneId>b__0(string filePath)
			{
				string text = this.localtimeFilePath;
				bool flag = string.Equals(filePath, text, StringComparison.OrdinalIgnoreCase);
				string text2 = this.posixrulesFilePath;
				bool flag2 = string.Equals(filePath, text2, StringComparison.OrdinalIgnoreCase);
				byte[] array = this.buffer;
				byte[] array2 = this.rawData;
				bool flag3 = TimeZoneInfo.CompareTimeZoneFile(filePath, array, array2);
				string text3 = this.timeZoneDirectory;
				this.id = filePath;
				bool flag4 = filePath.StartsWith(text3, StringComparison.Ordinal);
				string text4 = this.id;
				int stringLength = this.timeZoneDirectory._stringLength;
				string text5 = text4.Substring(stringLength);
				this.id = text5;
				return true;
			}

			// Token: 0x040001CD RID: 461
			public string localtimeFilePath;

			// Token: 0x040001CE RID: 462
			public string posixrulesFilePath;

			// Token: 0x040001CF RID: 463
			public byte[] buffer;

			// Token: 0x040001D0 RID: 464
			public byte[] rawData;

			// Token: 0x040001D1 RID: 465
			public string id;

			// Token: 0x040001D2 RID: 466
			public string timeZoneDirectory;
		}

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600038F RID: 911 RVA: 0x0000B8E4 File Offset: 0x00009AE4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000390 RID: 912 RVA: 0x0000B8F4 File Offset: 0x00009AF4
			public <>c()
			{
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0000207A File Offset: 0x0000027A
			internal bool <TZif_ParsePosixName>b__34_1(char c)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000392 RID: 914 RVA: 0x0000B908 File Offset: 0x00009B08
			internal bool <TZif_ParsePosixName>b__34_0(char c)
			{
				if (!true)
				{
				}
				return char.IsDigit(c);
			}

			// Token: 0x06000393 RID: 915 RVA: 0x0000B920 File Offset: 0x00009B20
			internal bool <TZif_ParsePosixOffset>b__35_0(char c)
			{
				if (!true)
				{
				}
				return char.IsDigit(c);
			}

			// Token: 0x06000394 RID: 916 RVA: 0x0000207A File Offset: 0x0000027A
			internal bool <TZif_ParsePosixDate>b__37_0(char c)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000395 RID: 917 RVA: 0x0000207A File Offset: 0x0000027A
			internal bool <TZif_ParsePosixTime>b__38_0(char c)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000396 RID: 918 RVA: 0x0000B938 File Offset: 0x00009B38
			internal int <CreateLocalUnity>b__161_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2)
			{
				DateTime dateStart = rule1._dateStart;
				DateTime dateStart2 = rule2._dateStart;
				int num;
				return num;
			}

			// Token: 0x040001D3 RID: 467
			public static readonly TimeZoneInfo.<>c <>9;

			// Token: 0x040001D4 RID: 468
			public static Func<char, bool> <>9__34_1;

			// Token: 0x040001D5 RID: 469
			public static Func<char, bool> <>9__34_0;

			// Token: 0x040001D6 RID: 470
			public static Func<char, bool> <>9__35_0;

			// Token: 0x040001D7 RID: 471
			public static Func<char, bool> <>9__37_0;

			// Token: 0x040001D8 RID: 472
			public static Func<char, bool> <>9__38_0;

			// Token: 0x040001D9 RID: 473
			public static Comparison<TimeZoneInfo.AdjustmentRule> <>9__161_0;
		}
	}
}
