using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Linq
{
	// Token: 0x02000023 RID: 35
	internal class Set<TElement>
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00003B60 File Offset: 0x00001D60
		public Set(IEqualityComparer<TElement> comparer)
		{
			if (comparer == null)
			{
			}
			this.comparer = 1;
			this.freeList = 1;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		public bool Add(TElement value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003B84 File Offset: 0x00001D84
		private bool Find(TElement value, bool add)
		{
			/*
An exception occurred when decompiling this method (06000110)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Set`1::buckets, ldloc:Set`1(this)))
	stloc:valuetype System.Linq.Set`1/Slot[](var_1_0D, ldfld:valuetype System.Linq.Set`1/Slot<!TElement>[][exp:valuetype System.Linq.Set`1/Slot[]](Set`1::slots, ldloc:Set`1(this)))
	stloc:IEqualityComparer`1(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TElement>[exp:IEqualityComparer`1](Set`1::comparer, ldloc:Set`1(this)))
	stloc:valuetype System.Linq.Set`1/Slot[](var_3_1B, ldfld:valuetype System.Linq.Set`1/Slot<!TElement>[][exp:valuetype System.Linq.Set`1/Slot[]](Set`1::slots, ldloc:Set`1(this)))
	stloc:valuetype System.Linq.Set`1/Slot[](var_4_22, ldfld:valuetype System.Linq.Set`1/Slot<!TElement>[][exp:valuetype System.Linq.Set`1/Slot[]](Set`1::slots, ldloc:Set`1(this)))
	stloc:int32(var_5_26, ldc.i4:int32(12))
	stfld:int32(Set`1::freeList, ldloc:Set`1(this), ldloc:int32(var_5_26))
	stloc:valuetype System.Linq.Set`1/Slot[](var_8_3C, ldfld:valuetype System.Linq.Set`1/Slot<!TElement>[][exp:valuetype System.Linq.Set`1/Slot[]](Set`1::slots, ldloc:Set`1(this)))
	stloc:int32(var_9_44, ldfld:int32(Set`1::count, ldloc:Set`1(this)))
	stloc:int32(var_10_4C, ldfld:int32(Set`1::count, ldloc:Set`1(this)))
	stloc:valuetype System.Linq.Set`1/Slot[](var_11_54, ldfld:valuetype System.Linq.Set`1/Slot<!TElement>[][exp:valuetype System.Linq.Set`1/Slot[]](Set`1::slots, ldloc:Set`1(this)))
	stfld:int32(Set`1::count, ldloc:Set`1(this), ldloc:int32(var_5_26))
	stloc:int32[](var_12_64, ldfld:int32[](Set`1::buckets, ldloc:Set`1(this)))
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

		// Token: 0x06000111 RID: 273 RVA: 0x00003BFC File Offset: 0x00001DFC
		private void Resize()
		{
			int num = this.count;
			Set.Slot[] array = this.slots;
			int num2 = this.count;
			int num3 = this.count;
			this.slots = num;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003C38 File Offset: 0x00001E38
		internal int InternalGetHashCode(TElement value)
		{
			/*
An exception occurred when decompiling this method (06000112)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEqualityComparer`1(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TElement>[exp:IEqualityComparer`1](Set`1::comparer, ldloc:Set`1(this)))
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

		// Token: 0x04000086 RID: 134
		private int[] buckets;

		// Token: 0x04000087 RID: 135
		private Set<TElement>.Slot[] slots;

		// Token: 0x04000088 RID: 136
		private int count;

		// Token: 0x04000089 RID: 137
		private int freeList;

		// Token: 0x0400008A RID: 138
		private IEqualityComparer<TElement> comparer;

		// Token: 0x02000024 RID: 36
		internal struct Slot
		{
			// Token: 0x0400008B RID: 139
			internal int hashCode;

			// Token: 0x0400008C RID: 140
			internal TElement value;

			// Token: 0x0400008D RID: 141
			internal int next;
		}
	}
}
