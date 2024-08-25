using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000659 RID: 1625
	[Serializable]
	internal class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(byte x, byte y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0006B82C File Offset: 0x00069A2C
		public override int GetHashCode(byte b)
		{
			int num;
			return num;
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0006B83C File Offset: 0x00069A3C
		internal override int IndexOf(byte[] array, byte value, int startIndex, int count)
		{
			if (array == null)
			{
				string resourceString = Environment.GetResourceString("Index was out of range. Must be non-negative and less than the size of the collection.");
				return "startIndex";
			}
			int num;
			if (count != 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0006B880 File Offset: 0x00069A80
		internal override int LastIndexOf(byte[] array, byte value, int startIndex, int count)
		{
			return startIndex;
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x0006B890 File Offset: 0x00069A90
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x0006B8A4 File Offset: 0x00069AA4
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060031A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Generic.ByteEqualityComparer::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:ByteEqualityComparer[exp:object](this)))
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

		// Token: 0x060031A1 RID: 12705 RVA: 0x0006B8B8 File Offset: 0x00069AB8
		public ByteEqualityComparer()
		{
		}
	}
}
