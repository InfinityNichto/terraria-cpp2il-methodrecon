using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000099 RID: 153
	[Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
	[Serializable]
	internal class CurrentSystemTimeZone : TimeZone
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0000E320 File Offset: 0x0000C520
		internal CurrentSystemTimeZone()
		{
			if (!true)
			{
			}
			TimeZoneInfo local = TimeZoneInfo.Local;
			TimeSpan baseUtcOffset = local._baseUtcOffset;
			this.m_ticksOffset = baseUtcOffset;
			string standardName = local.StandardName;
			this.m_standardName = standardName;
			string daylightName = local.DaylightName;
			this.m_daylightName = daylightName;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000E36C File Offset: 0x0000C56C
		public override DaylightTime GetDaylightChanges(int year)
		{
			return this.GetCachedDaylightChanges(year);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000E388 File Offset: 0x0000C588
		private static DaylightTime CreateDaylightChanges(int year)
		{
			/*
An exception occurred when decompiling this method (06000593)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DaylightTime System.CurrentSystemTimeZone::CreateDaylightChanges(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0034:
	brtrue(IL_0000, ldloc:DateTime[exp:bool](var_3))
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

		// Token: 0x06000594 RID: 1428 RVA: 0x0000E3CC File Offset: 0x0000C5CC
		public override TimeSpan GetUtcOffset(DateTime time)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool GetTimeZoneData(int year, [Out] long[] data, [Out] string[] names, [Out] bool daylight_inverted)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		private DaylightTime GetCachedDaylightChanges(int year)
		{
			Hashtable cachedDaylightChanges = this.m_CachedDaylightChanges;
			DaylightTime daylightTime = CurrentSystemTimeZone.CreateDaylightChanges(year);
			Hashtable cachedDaylightChanges2 = this.m_CachedDaylightChanges;
			Monitor.Enter(cachedDaylightChanges2, true);
			Hashtable cachedDaylightChanges3 = this.m_CachedDaylightChanges;
			Hashtable cachedDaylightChanges4 = this.m_CachedDaylightChanges;
			long num = 0L;
			Monitor.Exit(cachedDaylightChanges2);
			if (num == 0L)
			{
				if (this.m_CachedDaylightChanges != null)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400021F RID: 543
		private long m_ticksOffset;

		// Token: 0x04000220 RID: 544
		private string m_standardName;

		// Token: 0x04000221 RID: 545
		private string m_daylightName;

		// Token: 0x04000222 RID: 546
		private readonly Hashtable m_CachedDaylightChanges;
	}
}
