using System;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000425 RID: 1061
	[Serializable]
	internal sealed class SizedArray : ICloneable
	{
		// Token: 0x06002128 RID: 8488 RVA: 0x0004B73C File Offset: 0x0004993C
		internal SizedArray()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0004B750 File Offset: 0x00049950
		internal SizedArray(int length)
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0004B764 File Offset: 0x00049964
		private SizedArray(SizedArray sizedArray)
		{
			object[] array = sizedArray.objects;
			object[] array2 = sizedArray.objects;
			object[] array3 = sizedArray.negObjects;
			object[] array4 = sizedArray.negObjects;
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0000207A File Offset: 0x0000027A
		public object Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000451 RID: 1105
		internal object this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600212C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.Formatters.Binary.SizedArray::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_06, ldfld:object[](SizedArray::objects, ldloc:SizedArray(this)))
	stloc:object[](var_1_0D, ldfld:object[](SizedArray::negObjects, ldloc:SizedArray(this)))
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
				object[] array = this.objects;
				this.IncreaseCapacity(index);
				object[] array2 = this.objects;
				if (value != null && value == null)
				{
					return;
				}
				index.m_value = value;
			}
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0004B808 File Offset: 0x00049A08
		internal void IncreaseCapacity(int index)
		{
			object[] array = this.objects;
			int num = Math.Max(0, index);
		}

		// Token: 0x040011B0 RID: 4528
		internal object[] objects;

		// Token: 0x040011B1 RID: 4529
		internal object[] negObjects;
	}
}
