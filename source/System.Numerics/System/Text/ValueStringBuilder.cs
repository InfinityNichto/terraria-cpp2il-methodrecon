using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x0200000A RID: 10
	[DefaultMember("Item")]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003420 File Offset: 0x00001620
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			this._chars = initialBuffer;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003434 File Offset: 0x00001634
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003448 File Offset: 0x00001648
		public override string ToString()
		{
			int pos = this._pos;
			int length = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			string text;
			return text;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000347C File Offset: 0x0000167C
		public bool TryCopyTo(Span<char> destination, [Out] int charsWritten)
		{
			int pos = this._pos;
			int length = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			int pos2 = this._pos;
			return true;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000034B8 File Offset: 0x000016B8
		public void Insert(int index, char value, int count)
		{
			int length = this._chars._length;
			int pos = this._pos;
			this.Grow(count);
			int pos2 = this._pos;
			int length2 = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars = this._chars;
			int length3 = this._chars._length;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int length4 = this._chars._length;
			Span<char> chars2 = this._chars;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Span<char> chars3 = this._chars;
			int pos3 = this._pos;
			this._pos = pos3;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000354C File Offset: 0x0000174C
		public void Append(char c)
		{
			int length = this._chars._length;
			this._chars._pointer = c;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000357C File Offset: 0x0000177C
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

		// Token: 0x06000047 RID: 71 RVA: 0x000035C8 File Offset: 0x000017C8
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

		// Token: 0x06000048 RID: 72 RVA: 0x00003640 File Offset: 0x00001840
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

		// Token: 0x06000049 RID: 73 RVA: 0x0000369C File Offset: 0x0000189C
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

		// Token: 0x0600004A RID: 74 RVA: 0x000036F8 File Offset: 0x000018F8
		public Span<char> AppendSpan(int length)
		{
			/*
An exception occurred when decompiling this method (0600004A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Span`1<System.Char> System.Text.ValueStringBuilder::AppendSpan(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(Span`1::_length, ldfld:valuetype [mscorlib]System.Span`1<char>[exp:valuetype [mscorlib]System.Span`1&](ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this))))
	call:void(ValueStringBuilder::Grow, ldloc:valuetype System.Text.ValueStringBuilder&(this), ldloc:int32(length))
	stloc:int32(var_1_1E, ldfld:int32(Span`1::_length, ldfld:valuetype [mscorlib]System.Span`1<char>[exp:valuetype [mscorlib]System.Span`1&](ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this))))
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
	stloc:valuetype [mscorlib]System.Span`1<char>(var_3_2C, ldfld:valuetype [mscorlib]System.Span`1<char>(ValueStringBuilder::_chars, ldloc:valuetype System.Text.ValueStringBuilder&(this)))
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

		// Token: 0x0600004B RID: 75 RVA: 0x00003734 File Offset: 0x00001934
		private void GrowAndAppend(char c)
		{
			int num = 1;
			this.Grow(num);
			int length = this._chars._length;
			this._chars._pointer = c;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003764 File Offset: 0x00001964
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

		// Token: 0x0600004D RID: 77 RVA: 0x00003798 File Offset: 0x00001998
		public void Dispose()
		{
		}

		// Token: 0x0400001A RID: 26
		private char[] _arrayToReturnToPool;

		// Token: 0x0400001B RID: 27
		private Span<char> _chars;

		// Token: 0x0400001C RID: 28
		private int _pos;
	}
}
