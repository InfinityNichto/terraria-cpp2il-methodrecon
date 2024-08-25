using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace UnityEngine.Pool
{
	// Token: 0x02000158 RID: 344
	public class ObjectPool<T> : IDisposable where T : class
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public int CountAll
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public int CountInactive
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000671)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.Pool.ObjectPool`1::get_CountInactive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:List`1(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<!T>[exp:List`1](ObjectPool`1::m_List, ldloc:ObjectPool`1(this)))
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

		// Token: 0x06000672 RID: 1650 RVA: 0x0000B6CC File Offset: 0x000098CC
		public ObjectPool(Func<T> createFunc, [Optional] Action<T> actionOnGet, [Optional] Action<T> actionOnRelease, [Optional] Action<T> actionOnDestroy, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
		{
			if (createFunc != null)
			{
				this.m_List = this;
				this.m_CreateFunc = createFunc;
				this.m_MaxSize = maxSize;
				this.m_ActionOnGet = actionOnGet;
				this.m_ActionOnRelease = actionOnRelease;
				this.m_ActionOnDestroy = actionOnDestroy;
				return;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0000B710 File Offset: 0x00009910
		public T Get()
		{
			/*
An exception occurred when decompiling this method (06000673)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T UnityEngine.Pool.ObjectPool`1::Get()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:Func`1(var_3_23, ldfld:class [mscorlib]System.Func`1<!T>[exp:Func`1](ObjectPool`1::m_CreateFunc, ldloc:ObjectPool`1(this)))
	stloc:object(var_4_2A, ldfld:object(List`1::_syncRoot, ldloc:List`1(var_2)))
	brtrue(IL_0000, logicnot:bool(ldfld:class [mscorlib]System.Action`1<!T>[exp:bool](ObjectPool`1::m_ActionOnGet, ldloc:ObjectPool`1(this))))
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

		// Token: 0x06000674 RID: 1652 RVA: 0x0000B750 File Offset: 0x00009950
		public void Release(T element)
		{
			if (this.m_ActionOnRelease != null)
			{
			}
			int maxSize = this.m_MaxSize;
			List list = this.m_List;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000B780 File Offset: 0x00009980
		public void Clear()
		{
			if (this.m_ActionOnDestroy != null)
			{
				List list = this.m_List;
				Action actionOnDestroy = this.m_ActionOnDestroy;
				return;
			}
			List list2 = this.m_List;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000B7CC File Offset: 0x000099CC
		public void Dispose()
		{
		}

		// Token: 0x04000638 RID: 1592
		internal readonly List<T> m_List;

		// Token: 0x04000639 RID: 1593
		private readonly Func<T> m_CreateFunc;

		// Token: 0x0400063A RID: 1594
		private readonly Action<T> m_ActionOnGet;

		// Token: 0x0400063B RID: 1595
		private readonly Action<T> m_ActionOnRelease;

		// Token: 0x0400063C RID: 1596
		private readonly Action<T> m_ActionOnDestroy;

		// Token: 0x0400063D RID: 1597
		private readonly int m_MaxSize;

		// Token: 0x0400063E RID: 1598
		internal bool m_CollectionCheck;

		// Token: 0x0400063F RID: 1599
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <CountAll>k__BackingField;
	}
}
