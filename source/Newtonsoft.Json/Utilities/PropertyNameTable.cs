using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000042 RID: 66
	[Preserve]
	internal class PropertyNameTable
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00008B58 File Offset: 0x00006D58
		static PropertyNameTable()
		{
			int tickCount = Environment.TickCount;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008B70 File Offset: 0x00006D70
		public PropertyNameTable()
		{
			int num = 31;
			this._mask = num;
			base..ctor();
			int mask = this._mask;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008B98 File Offset: 0x00006D98
		public string Get(char[] key, int start, int length)
		{
			/*
An exception occurred when decompiling this method (060002C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Utilities.PropertyNameTable::Get(System.Char[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_1_0E, ldfld:int32(PropertyNameTable::_mask, ldloc:PropertyNameTable(this)))
	stloc:class Newtonsoft.Json.Utilities.PropertyNameTable/Entry[](var_2_15, ldfld:class Newtonsoft.Json.Utilities.PropertyNameTable/Entry[](PropertyNameTable::_entries, ldloc:PropertyNameTable(this)))
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

		// Token: 0x060002C2 RID: 706 RVA: 0x00008BC0 File Offset: 0x00006DC0
		public string Add(string key)
		{
			int num;
			do
			{
				num = 1;
			}
			while (key == null);
			if (key._stringLength == 0 || num != 0)
			{
			}
			int stringLength = key._stringLength;
			long num2 = 0L;
			char c = key[(int)num2];
			int stringLength2 = key._stringLength;
			int mask = this._mask;
			PropertyNameTable.Entry[] entries = this._entries;
			string text;
			return text;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008C0C File Offset: 0x00006E0C
		private string AddEntry(string str, int hashCode)
		{
			int mask = this._mask;
			PropertyNameTable.Entry[] entries = this._entries;
			PropertyNameTable.Entry[] entries2 = this._entries;
			int count = this._count;
			int mask2 = this._mask;
			this.Grow();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008C48 File Offset: 0x00006E48
		private void Grow()
		{
			int mask = this._mask;
			PropertyNameTable.Entry[] entries = this._entries;
			int num = 1;
			int hashCode = entries.HashCode;
			int hashCode2 = entries.HashCode;
			this._mask = num;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008C84 File Offset: 0x00006E84
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
		}

		// Token: 0x04000177 RID: 375
		private static readonly int HashCodeRandomizer;

		// Token: 0x04000178 RID: 376
		private int _count;

		// Token: 0x04000179 RID: 377
		private PropertyNameTable.Entry[] _entries;

		// Token: 0x0400017A RID: 378
		private int _mask;

		// Token: 0x02000043 RID: 67
		private class Entry
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x00008C98 File Offset: 0x00006E98
			internal Entry(string value, int hashCode, PropertyNameTable.Entry next)
			{
				this.Value = value;
				this.HashCode = hashCode;
				this.Next = next;
			}

			// Token: 0x0400017B RID: 379
			internal readonly string Value;

			// Token: 0x0400017C RID: 380
			internal readonly int HashCode;

			// Token: 0x0400017D RID: 381
			internal PropertyNameTable.Entry Next;
		}
	}
}
