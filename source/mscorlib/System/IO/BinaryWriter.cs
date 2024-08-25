using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Mono.Security;

namespace System.IO
{
	// Token: 0x02000562 RID: 1378
	[ComVisible(true)]
	[Serializable]
	public class BinaryWriter : IDisposable
	{
		// Token: 0x0600293A RID: 10554 RVA: 0x00059528 File Offset: 0x00057728
		protected BinaryWriter()
		{
			if (!true)
			{
			}
			this.OutStream = 1;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00059548 File Offset: 0x00057748
		public BinaryWriter(Stream output)
		{
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00059558 File Offset: 0x00057758
		public BinaryWriter(Stream output, Encoding encoding)
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00059568 File Offset: 0x00057768
		public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
		{
			/*
An exception occurred when decompiling this method (0600293D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.BinaryWriter::.ctor(System.IO.Stream,System.Text.Encoding,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	stloc:string(var_0_34, call:string(Environment::GetResourceString, ldstr:string("Stream was not writable.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x0600293E RID: 10558 RVA: 0x000595AC File Offset: 0x000577AC
		public virtual void Close()
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000595BC File Offset: 0x000577BC
		protected virtual void Dispose(bool disposing)
		{
			Stream outStream = this.OutStream;
			if (this._leaveOpen)
			{
				return;
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000595DC File Offset: 0x000577DC
		public void Dispose()
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000595EC File Offset: 0x000577EC
		public virtual Stream BaseStream
		{
			get
			{
				return this.OutStream;
			}
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00059600 File Offset: 0x00057800
		public virtual void Flush()
		{
			Stream outStream = this.OutStream;
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00059614 File Offset: 0x00057814
		public virtual long Seek(int offset, SeekOrigin origin)
		{
			/*
An exception occurred when decompiling this method (06002943)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.IO.BinaryWriter::Seek(System.Int32,System.IO.SeekOrigin)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(BinaryWriter::OutStream, ldloc:BinaryWriter(this)))
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

		// Token: 0x06002944 RID: 10564 RVA: 0x00059628 File Offset: 0x00057828
		public virtual void Write(bool value)
		{
			byte[] buffer = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer2 = this._buffer;
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0005964C File Offset: 0x0005784C
		public virtual void Write(byte value)
		{
			Stream outStream = this.OutStream;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00059660 File Offset: 0x00057860
		[CLSCompliant(false)]
		public virtual void Write(sbyte value)
		{
			Stream outStream = this.OutStream;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00059674 File Offset: 0x00057874
		public virtual void Write(byte[] buffer)
		{
			while (buffer == null)
			{
			}
			Stream outStream = this.OutStream;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0005968C File Offset: 0x0005788C
		public virtual void Write(byte[] buffer, int index, int count)
		{
			Stream outStream = this.OutStream;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000596A0 File Offset: 0x000578A0
		public virtual void Write(char ch)
		{
			if (!true)
			{
			}
			bool flag = char.IsSurrogate(ch);
			if (this._buffer != null)
			{
				return;
			}
			Encoder encoder = this._encoder;
			Stream outStream = this.OutStream;
			byte[] buffer = this._buffer;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000596E4 File Offset: 0x000578E4
		public virtual void Write(char[] chars)
		{
			while (chars == null)
			{
			}
			Encoding encoding = this._encoding;
			Stream outStream = this.OutStream;
			CodePageDataItem dataItem = encoding.dataItem;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0005970C File Offset: 0x0005790C
		public virtual void Write(double value)
		{
			Stream outStream = this.OutStream;
			byte[] bytes = BitConverterLE.GetBytes(value);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0005972C File Offset: 0x0005792C
		public virtual void Write(short value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer3 = this._buffer;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00059758 File Offset: 0x00057958
		[CLSCompliant(false)]
		public virtual void Write(ushort value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer3 = this._buffer;
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00059784 File Offset: 0x00057984
		public virtual void Write(int value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			byte[] buffer3 = this._buffer;
			byte[] buffer4 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer5 = this._buffer;
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000597C0 File Offset: 0x000579C0
		[CLSCompliant(false)]
		public virtual void Write(uint value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			byte[] buffer3 = this._buffer;
			byte[] buffer4 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer5 = this._buffer;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000597FC File Offset: 0x000579FC
		public virtual void Write(long value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			byte[] buffer3 = this._buffer;
			byte[] buffer4 = this._buffer;
			byte[] buffer5 = this._buffer;
			byte[] buffer6 = this._buffer;
			byte[] buffer7 = this._buffer;
			byte[] buffer8 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer9 = this._buffer;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00059858 File Offset: 0x00057A58
		[CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
			byte[] buffer3 = this._buffer;
			byte[] buffer4 = this._buffer;
			byte[] buffer5 = this._buffer;
			byte[] buffer6 = this._buffer;
			byte[] buffer7 = this._buffer;
			byte[] buffer8 = this._buffer;
			Stream outStream = this.OutStream;
			byte[] buffer9 = this._buffer;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000598B4 File Offset: 0x00057AB4
		public virtual void Write(float value)
		{
			Stream outStream = this.OutStream;
			byte[] bytes = BitConverterLE.GetBytes(value);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000598D4 File Offset: 0x00057AD4
		public virtual void Write(string value)
		{
			if (value == null)
			{
				throw new OverflowException();
			}
			Encoding encoding = this._encoding;
			this.Write7BitEncodedInt(43155456);
			if (this._largeByteBuffer == null)
			{
				Encoding encoding2 = this._encoding;
				byte[] largeByteBuffer = this._largeByteBuffer;
			}
			int stringLength = value._stringLength;
			int maxChars = this._maxChars;
			int stringLength2 = value._stringLength;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (this._largeByteBuffer != null)
			{
				return;
			}
			Encoder encoder = this._encoder;
			Stream outStream = this.OutStream;
			byte[] largeByteBuffer2 = this._largeByteBuffer;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00059988 File Offset: 0x00057B88
		protected void Write7BitEncodedInt(int value)
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00059998 File Offset: 0x00057B98
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryWriter()
		{
		}

		// Token: 0x04001629 RID: 5673
		public static readonly BinaryWriter Null;

		// Token: 0x0400162A RID: 5674
		protected Stream OutStream;

		// Token: 0x0400162B RID: 5675
		private byte[] _buffer;

		// Token: 0x0400162C RID: 5676
		private Encoding _encoding;

		// Token: 0x0400162D RID: 5677
		private Encoder _encoder;

		// Token: 0x0400162E RID: 5678
		[OptionalField]
		private bool _leaveOpen;

		// Token: 0x0400162F RID: 5679
		private byte[] _largeByteBuffer;

		// Token: 0x04001630 RID: 5680
		private int _maxChars;
	}
}
