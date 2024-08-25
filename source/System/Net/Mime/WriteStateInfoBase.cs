using System;

namespace System.Net.Mime
{
	// Token: 0x02000327 RID: 807
	internal class WriteStateInfoBase
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x0003F424 File Offset: 0x0003D624
		internal WriteStateInfoBase()
		{
			if (!true)
			{
			}
			this._header = 1;
			if (!true)
			{
			}
			this._maxLineLength = 70;
			this._footer = 1;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0003F454 File Offset: 0x0003D654
		internal int FooterLength
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Mime.WriteStateInfoBase::get_FooterLength()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](WriteStateInfoBase::_footer, ldloc:WriteStateInfoBase(this)))
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0003F468 File Offset: 0x0003D668
		internal byte[] Footer
		{
			get
			{
				return this._footer;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0003F47C File Offset: 0x0003D67C
		internal byte[] Header
		{
			get
			{
				return this._header;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0003F490 File Offset: 0x0003D690
		internal byte[] Buffer
		{
			get
			{
				return this._buffer;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0003F4A4 File Offset: 0x0003D6A4
		internal int Length
		{
			get
			{
				return this._currentBufferUsed;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		internal int CurrentLineLength
		{
			get
			{
				return this._currentLineLength;
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0003F4CC File Offset: 0x0003D6CC
		private void EnsureSpaceInBuffer(int moreBytes)
		{
			byte[] buffer = this._buffer;
			int currentBufferUsed = this._currentBufferUsed;
			byte[] buffer2 = this._buffer;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0003F4F0 File Offset: 0x0003D6F0
		internal void Append(byte aByte)
		{
			int num = 1;
			this.EnsureSpaceInBuffer(num);
			byte[] buffer = this._buffer;
			int currentLineLength = this._currentLineLength;
			this._currentLineLength = currentLineLength;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0003F51C File Offset: 0x0003D71C
		internal void Append(params byte[] bytes)
		{
			byte[] buffer = this._buffer;
			int currentBufferUsed = this._currentBufferUsed;
			int currentLineLength = this._currentLineLength;
			this._currentLineLength = currentLineLength;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0003F548 File Offset: 0x0003D748
		internal void AppendCRLF(bool includeSpace)
		{
			int num = 1;
			byte[] footer = this._footer;
			if (footer != null && num != 0)
			{
				this.Append(footer);
			}
			int num2 = 1;
			this.EnsureSpaceInBuffer(num2);
			byte[] buffer = this._buffer;
			int currentLineLength = this._currentLineLength;
			this._currentLineLength = currentLineLength;
			byte[] header = this._header;
			if (header != null && currentLineLength != 0)
			{
				this.Append(header);
				return;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0003F5B4 File Offset: 0x0003D7B4
		internal void AppendHeader()
		{
			byte[] header = this._header;
			if (header != null)
			{
				this.Append(header);
				return;
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		internal void AppendFooter()
		{
			byte[] footer = this._footer;
			if (footer != null)
			{
				this.Append(footer);
				return;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		internal int MaxLineLength
		{
			get
			{
				return this._maxLineLength;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003F608 File Offset: 0x0003D808
		internal void Reset()
		{
		}

		// Token: 0x0400115E RID: 4446
		protected readonly byte[] _header;

		// Token: 0x0400115F RID: 4447
		protected readonly byte[] _footer;

		// Token: 0x04001160 RID: 4448
		protected readonly int _maxLineLength;

		// Token: 0x04001161 RID: 4449
		protected byte[] _buffer;

		// Token: 0x04001162 RID: 4450
		protected int _currentLineLength;

		// Token: 0x04001163 RID: 4451
		protected int _currentBufferUsed;
	}
}
