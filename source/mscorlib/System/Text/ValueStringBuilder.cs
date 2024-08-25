using System;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000287 RID: 647
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x0600161E RID: 5662 RVA: 0x0002E814 File Offset: 0x0002CA14
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			this._chars = initialBuffer;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0002E828 File Offset: 0x0002CA28
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x17000234 RID: 564
		public char this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001620)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Text.ValueStringBuilder::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Span`1<char>(var_0_06, ldfld:valuetype System.Span`1<char>(ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this)))
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

		// Token: 0x06001621 RID: 5665 RVA: 0x0002E850 File Offset: 0x0002CA50
		public override string ToString()
		{
			int pos = this._pos;
			int length = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			string text;
			return text;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0002E884 File Offset: 0x0002CA84
		public bool TryCopyTo(Span<char> destination, [Out] int charsWritten)
		{
			int pos = this._pos;
			int length = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			int pos2 = this._pos;
			return true;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		public void Append(char c)
		{
			int length = this._chars._length;
			this._chars._pointer = c;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		public void Append(string s)
		{
			int stringLength = s._stringLength;
			int length = this._chars._length;
			Span<char> chars = this._chars;
			long num = 0L;
			char c = s[(int)num];
			chars._pointer = c;
			this._pos = length;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0002E93C File Offset: 0x0002CB3C
		private void AppendSlow(string s)
		{
			int length = this._chars._length;
			int stringLength = s._stringLength;
			this.Grow(stringLength);
			char rawStringData = s.GetRawStringData();
			int stringLength2 = s._stringLength;
			int length2 = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int length3 = this._chars._length;
			Span<char> chars = this._chars;
			int pos = this._pos;
			int stringLength3 = s._stringLength;
			this._pos = pos;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0002E9B4 File Offset: 0x0002CBB4
		public void Append(char c, int count)
		{
			int length = this._chars._length;
			int pos = this._pos;
			this.Grow(count);
			int pos2 = this._pos;
			int length2 = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			int pos3 = this._pos;
			this._pos = pos3;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0002EA10 File Offset: 0x0002CC10
		public unsafe void Append(char* value, int length)
		{
			int length2 = this._chars._length;
			int pos = this._pos;
			this.Grow(length);
			int pos2 = this._pos;
			int length3 = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			int pos3 = this._pos;
			this._pos = pos3;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public Span<char> AppendSpan(int length)
		{
			/*
An exception occurred when decompiling this method (06001628)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Span`1<System.Char> System.Text.ValueStringBuilder::AppendSpan(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(Span`1::_length, ldfld:valuetype System.Span`1<char>[exp:valuetype System.Span`1&](ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this))))
	call:void(ValueStringBuilder::Grow, ldloc:valuetype System.Text.ValueStringBuilder&(this), ldloc:int32(length))
	stloc:int32(var_1_1E, ldfld:int32(Span`1::_length, ldfld:valuetype System.Span`1<char>[exp:valuetype System.Span`1&](ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this))))
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
	stloc:valuetype System.Span`1<char>(var_3_2C, ldfld:valuetype System.Span`1<char>(ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this)))
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

		// Token: 0x06001629 RID: 5673 RVA: 0x0002EAA8 File Offset: 0x0002CCA8
		private void GrowAndAppend(char c)
		{
			int num = 1;
			this.Grow(num);
			int length = this._chars._length;
			Span<char> chars = this._chars;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0002EAD4 File Offset: 0x0002CCD4
		private void Grow(int requiredAdditionalCapacity)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int pos = this._pos;
			int length = this._chars._length;
			if (num == 0)
			{
			}
			int num2 = Math.Max(0, requiredAdditionalCapacity);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0002EB08 File Offset: 0x0002CD08
		public void Dispose()
		{
		}

		// Token: 0x04000B58 RID: 2904
		private char[] _arrayToReturnToPool;

		// Token: 0x04000B59 RID: 2905
		private Span<char> _chars;

		// Token: 0x04000B5A RID: 2906
		private int _pos;
	}
}
