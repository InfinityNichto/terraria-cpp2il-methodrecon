using System;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000426 RID: 1062
	[Serializable]
	internal sealed class IntSizedArray : ICloneable
	{
		// Token: 0x0600212F RID: 8495 RVA: 0x0004B850 File Offset: 0x00049A50
		public IntSizedArray()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0004B864 File Offset: 0x00049A64
		private IntSizedArray(IntSizedArray sizedArray)
		{
			int[] array = sizedArray.objects;
			int[] array2 = sizedArray.objects;
			int[] array3 = sizedArray.negObjects;
			int[] array4 = sizedArray.negObjects;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0000207A File Offset: 0x0000027A
		public object Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000452 RID: 1106
		internal int this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002132)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Serialization.Formatters.Binary.IntSizedArray::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](IntSizedArray::objects, ldloc:IntSizedArray(this)))
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
				int[] array = this.objects;
				this.IncreaseCapacity(index);
				int[] array2 = this.objects;
			}
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		internal void IncreaseCapacity(int index)
		{
			int[] array = this.objects;
			int num = Math.Max(0, index);
		}

		// Token: 0x040011B2 RID: 4530
		internal int[] objects;

		// Token: 0x040011B3 RID: 4531
		internal int[] negObjects;
	}
}
