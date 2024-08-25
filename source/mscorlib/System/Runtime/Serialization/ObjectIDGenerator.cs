using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DB RID: 987
	[ComVisible(true)]
	[Serializable]
	public class ObjectIDGenerator
	{
		// Token: 0x06001F1B RID: 7963 RVA: 0x00043F50 File Offset: 0x00042150
		public ObjectIDGenerator()
		{
			this.m_currentCount = 1;
			if (!true)
			{
			}
			this.m_currentSize = 1;
			int currentSize = this.m_currentSize;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00043F80 File Offset: 0x00042180
		private int FindElement(object obj, [Out] bool found)
		{
			int hashCode = RuntimeHelpers.GetHashCode(obj);
			int currentSize = this.m_currentSize;
			object[] objs = this.m_objs;
			return hashCode;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00043FB8 File Offset: 0x000421B8
		public virtual long GetId(object obj, [Out] bool firstTime)
		{
			if (obj != null)
			{
				int num = this.FindElement(obj, firstTime);
				long[] ids = this.m_ids;
				object[] objs = this.m_objs;
				if (obj == null)
				{
					goto IL_0046;
				}
				long[] ids2 = this.m_ids;
				int currentSize = this.m_currentSize;
				this.Rehash();
				firstTime.m_value = currentSize != 0;
			}
			string resourceString = Environment.GetResourceString("Object cannot be null.");
			IL_0046:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00044010 File Offset: 0x00042210
		public virtual long HasId(object obj, [Out] bool firstTime)
		{
			/*
An exception occurred when decompiling this method (06001F1E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Runtime.Serialization.ObjectIDGenerator::HasId(System.Object,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:string(var_4_2A, call:string(Environment::GetResourceString, ldstr:string("Object cannot be null.")))
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

		// Token: 0x06001F1F RID: 7967 RVA: 0x00044048 File Offset: 0x00042248
		private void Rehash()
		{
			int num = 1;
			int currentSize = this.m_currentSize;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000440A0 File Offset: 0x000422A0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectIDGenerator()
		{
		}

		// Token: 0x04000F95 RID: 3989
		internal int m_currentCount;

		// Token: 0x04000F96 RID: 3990
		internal int m_currentSize;

		// Token: 0x04000F97 RID: 3991
		internal long[] m_ids;

		// Token: 0x04000F98 RID: 3992
		internal object[] m_objs;

		// Token: 0x04000F99 RID: 3993
		private static readonly int[] sizes;
	}
}
