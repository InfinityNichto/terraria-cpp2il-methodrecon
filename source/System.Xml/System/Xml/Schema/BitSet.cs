using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x020000C3 RID: 195
	internal sealed class BitSet
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00019C48 File Offset: 0x00017E48
		private BitSet()
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00019C5C File Offset: 0x00017E5C
		public BitSet(int count)
		{
			this.count = count;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00019C78 File Offset: 0x00017E78
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x170001F2 RID: 498
		public bool this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000804)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.BitSet::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BitSet::count, ldloc:BitSet(this)))
	stloc:uint32[](var_1_0D, ldfld:uint32[](BitSet::bits, ldloc:BitSet(this)))
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

		// Token: 0x06000805 RID: 2053 RVA: 0x00019CA8 File Offset: 0x00017EA8
		public void Clear()
		{
			uint[] array = this.bits;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00019CBC File Offset: 0x00017EBC
		public void Set(int index)
		{
			this.EnsureLength(index);
			uint[] array = this.bits;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00019CD8 File Offset: 0x00017ED8
		public bool Get(int index)
		{
			/*
An exception occurred when decompiling this method (06000807)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.BitSet::Get(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BitSet::count, ldloc:BitSet(this)))
	stloc:uint32[](var_1_0D, ldfld:uint32[](BitSet::bits, ldloc:BitSet(this)))
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

		// Token: 0x06000808 RID: 2056 RVA: 0x00019CF4 File Offset: 0x00017EF4
		public int NextSet(int startFrom)
		{
			/*
An exception occurred when decompiling this method (06000808)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.BitSet::NextSet(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BitSet::count, ldloc:BitSet(this)))
	stloc:uint32[](var_1_0D, ldfld:uint32[](BitSet::bits, ldloc:BitSet(this)))
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

		// Token: 0x06000809 RID: 2057 RVA: 0x00019D10 File Offset: 0x00017F10
		public void And(BitSet other)
		{
			uint[] array = this.bits;
			uint[] array2 = other.bits;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00019D2C File Offset: 0x00017F2C
		public void Or(BitSet other)
		{
			uint[] array = other.bits;
			uint[] array2 = this.bits;
			uint[] array3 = other.bits;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00003FFD File Offset: 0x000021FD
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00019D50 File Offset: 0x00017F50
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				uint[] array = this.bits;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00019D70 File Offset: 0x00017F70
		public BitSet Clone()
		{
			object obj;
			do
			{
				int num = this.count;
				uint[] array = this.bits;
			}
			while (obj == null || (obj != null && obj != null));
			throw new InvalidCastException();
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00019D9C File Offset: 0x00017F9C
		public bool Intersects(BitSet other)
		{
			int num = 1;
			uint[] array = this.bits;
			uint[] array2 = other.bits;
			if (num == 0)
			{
			}
			uint[] array3 = this.bits;
			uint[] array4 = other.bits;
			while (array3 == null)
			{
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00003FFD File Offset: 0x000021FD
		private int Subscript(int bitIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00019DD8 File Offset: 0x00017FD8
		private void EnsureLength(int nRequiredLength)
		{
			uint[] array = this.bits;
			uint[] array2 = this.bits;
		}

		// Token: 0x04000416 RID: 1046
		private int count;

		// Token: 0x04000417 RID: 1047
		private uint[] bits;
	}
}
