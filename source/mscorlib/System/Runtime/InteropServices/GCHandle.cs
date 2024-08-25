using System;
using Cpp2IlInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044F RID: 1103
	[ComVisible(true)]
	public struct GCHandle
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x0004C450 File Offset: 0x0004A650
		private GCHandle(IntPtr h)
		{
			this.handle = h;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0004C464 File Offset: 0x0004A664
		private GCHandle(object obj)
		{
			this.handle = obj;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0004C478 File Offset: 0x0004A678
		internal GCHandle(object value, GCHandleType type)
		{
			this.handle = value;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x0004C48C File Offset: 0x0004A68C
		public bool IsAllocated
		{
			get
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x0004C49C File Offset: 0x0004A69C
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		public object Target
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002198)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.InteropServices.GCHandle::get_Target()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(GCHandle::get_IsAllocated, ldloc:valuetype System.Runtime.InteropServices.GCHandle&(this)))
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
			set
			{
				this.handle = value;
			}
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0004C4C4 File Offset: 0x0004A6C4
		public IntPtr AddrOfPinnedObject()
		{
			/*
An exception occurred when decompiling this method (0600219A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.Runtime.InteropServices.GCHandle::AddrOfPinnedObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_2_06, call:native int(native int::op_Explicit, ldloc:bool[exp:int32](var_1)))
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

		// Token: 0x0600219B RID: 8603 RVA: 0x0000207A File Offset: 0x0000027A
		public static GCHandle Alloc(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0000207A File Offset: 0x0000027A
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0004C4D8 File Offset: 0x0004A6D8
		public void Free()
		{
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator IntPtr(GCHandle value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0000207A File Offset: 0x0000027A
		public static explicit operator GCHandle(IntPtr value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool CheckCurrentDomain(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0000207A File Offset: 0x0000027A
		private static object GetTarget(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0000207A File Offset: 0x0000027A
		private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		private static void FreeHandle(IntPtr handle)
		{
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0000207A File Offset: 0x0000027A
		private static IntPtr GetAddrOfPinnedObject(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0004C508 File Offset: 0x0004A708
		public override bool Equals(object o)
		{
			if (o != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0004C51C File Offset: 0x0004A71C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0004C52C File Offset: 0x0004A72C
		public static GCHandle FromIntPtr(IntPtr value)
		{
			GCHandle gchandle;
			return gchandle;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr ToIntPtr(GCHandle value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04001283 RID: 4739
		private IntPtr handle;
	}
}
