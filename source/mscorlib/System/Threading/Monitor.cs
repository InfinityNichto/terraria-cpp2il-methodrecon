using System;
using System.Runtime.ConstrainedExecution;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001F0 RID: 496
	public static class Monitor
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x00025AD8 File Offset: 0x00023CD8
		public static void Enter(object obj)
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00025AE8 File Offset: 0x00023CE8
		public static void Enter(object obj, bool lockTaken)
		{
			Monitor.ReliableEnterTimeout(obj, lockTaken ? 1 : 0, lockTaken);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00025B04 File Offset: 0x00023D04
		private static void ThrowLockTakenException()
		{
			/*
An exception occurred when decompiling this method (060011B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Threading.Monitor::ThrowLockTakenException()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Argument must be initialized to false")))
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

		// Token: 0x060011B1 RID: 4529 RVA: 0x00025B1C File Offset: 0x00023D1C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Exit(object obj)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool TryEnter(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00025B2C File Offset: 0x00023D2C
		public static void TryEnter(object obj, int millisecondsTimeout, bool lockTaken)
		{
			Monitor.ReliableEnterTimeout(obj, millisecondsTimeout, lockTaken);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00025B48 File Offset: 0x00023D48
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00025B58 File Offset: 0x00023D58
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00025B68 File Offset: 0x00023D68
		public static bool Wait(object obj)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00025B78 File Offset: 0x00023D78
		public static void Pulse(object obj)
		{
			while (obj == null)
			{
			}
			Monitor.ObjPulse(obj);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00025B90 File Offset: 0x00023D90
		public static void PulseAll(object obj)
		{
			while (obj == null)
			{
			}
			Monitor.ObjPulseAll(obj);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool Monitor_test_synchronised(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00025BA8 File Offset: 0x00023DA8
		private static void Monitor_pulse(object obj)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00025BB8 File Offset: 0x00023DB8
		private static void ObjPulse(object obj)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00025BC8 File Offset: 0x00023DC8
		private static void Monitor_pulse_all(object obj)
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00025BD8 File Offset: 0x00023DD8
		private static void ObjPulseAll(object obj)
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool Monitor_wait(object obj, int ms)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00025BE8 File Offset: 0x00023DE8
		private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, bool lockTaken)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00025BF8 File Offset: 0x00023DF8
		private static void ReliableEnterTimeout(object obj, int timeout, bool lockTaken)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00025C0C File Offset: 0x00023E0C
		private static void ReliableEnter(object obj, bool lockTaken)
		{
			Monitor.ReliableEnterTimeout(obj, lockTaken ? 1 : 0, lockTaken);
		}
	}
}
