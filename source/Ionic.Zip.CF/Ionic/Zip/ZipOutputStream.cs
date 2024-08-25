using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000030 RID: 48
	public class ZipOutputStream : Stream
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00008500 File Offset: 0x00006700
		public ZipOutputStream(Stream stream)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008510 File Offset: 0x00006710
		public ZipOutputStream(string fileName)
		{
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding;
			if (!true)
			{
			}
			base..ctor();
			long num = 0L;
			FileStream fileStream;
			this._Init(fileStream, num != 0L, fileName);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008544 File Offset: 0x00006744
		public ZipOutputStream(Stream stream, bool leaveOpen)
		{
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding;
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000856C File Offset: 0x0000676C
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008588 File Offset: 0x00006788
		public override string ToString()
		{
			bool leaveUnderlyingStreamOpen = this._leaveUnderlyingStreamOpen;
			string name = this._name;
			string text;
			return text;
		}

		// Token: 0x1700008B RID: 139
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000085A4 File Offset: 0x000067A4
		public string Password
		{
			set
			{
				/*
An exception occurred when decompiling this method (06000245)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::set_Password(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldc.i4:bool(1))
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
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000085DC File Offset: 0x000067DC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000085F0 File Offset: 0x000067F0
		public EncryptionAlgorithm Encryption
		{
			get
			{
				return this._encryption;
			}
			set
			{
				if (!this._disposed)
				{
					this._encryption = value;
					return;
				}
				this._exceptionPending = true;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00008614 File Offset: 0x00006814
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00008628 File Offset: 0x00006828
		public int CodecBufferSize
		{
			get
			{
				return this.<CodecBufferSize>k__BackingField;
			}
			set
			{
				this.<CodecBufferSize>k__BackingField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000863C File Offset: 0x0000683C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00008650 File Offset: 0x00006850
		public CompressionStrategy Strategy
		{
			get
			{
				return this.<Strategy>k__BackingField;
			}
			set
			{
				this.<Strategy>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00008664 File Offset: 0x00006864
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00008678 File Offset: 0x00006878
		public ZipEntryTimestamp Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				/*
An exception occurred when decompiling this method (0600024D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::set_Timestamp(Ionic.Zip.ZipEntryTimestamp)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldc.i4:bool(1))
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
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000869C File Offset: 0x0000689C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000086B0 File Offset: 0x000068B0
		public CompressionLevel CompressionLevel
		{
			get
			{
				return this.<CompressionLevel>k__BackingField;
			}
			set
			{
				this.<CompressionLevel>k__BackingField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000086C4 File Offset: 0x000068C4
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000086D8 File Offset: 0x000068D8
		public CompressionMethod CompressionMethod
		{
			get
			{
				return this.<CompressionMethod>k__BackingField;
			}
			set
			{
				this.<CompressionMethod>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000086EC File Offset: 0x000068EC
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00008700 File Offset: 0x00006900
		public string Comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::set_Comment(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldc.i4:bool(1))
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
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00008724 File Offset: 0x00006924
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00008738 File Offset: 0x00006938
		public Zip64Option EnableZip64
		{
			get
			{
				return this._zip64;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000255)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::set_EnableZip64(Ionic.Zip.Zip64Option)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldc.i4:bool(1))
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
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000875C File Offset: 0x0000695C
		public bool OutputUsedZip64
		{
			get
			{
				return !this._anyEntriesUsedZip64 || true;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00008774 File Offset: 0x00006974
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00008788 File Offset: 0x00006988
		public bool IgnoreCase
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000257)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipOutputStream::get_IgnoreCase()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(ZipOutputStream::_DontIgnoreCase, ldloc:ZipOutputStream(this)))
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
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00008798 File Offset: 0x00006998
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000087C0 File Offset: 0x000069C0
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000259)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipOutputStream::get_UseUnicodeAsNecessary()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_0_06, ldfld:Encoding(ZipOutputStream::_alternateEncoding, ldloc:ZipOutputStream(this)))
	stloc:Encoding(var_2_0E, callgetter:Encoding(Encoding::get_UTF8))
	stloc:ZipOption(var_4_17, ldfld:ZipOption(ZipOutputStream::_alternateEncodingUsage, ldloc:ZipOutputStream(this)))
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
				Encoding utf = Encoding.UTF8;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000087EC File Offset: 0x000069EC
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00008808 File Offset: 0x00006A08
		[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			get
			{
				ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
				this._alternateEncodingUsage = ZipOption.AsNecessary;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00008824 File Offset: 0x00006A24
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00008838 File Offset: 0x00006A38
		public Encoding AlternateEncoding
		{
			get
			{
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000884C File Offset: 0x00006A4C
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00008860 File Offset: 0x00006A60
		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return this._alternateEncodingUsage;
			}
			set
			{
				this._alternateEncodingUsage = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00008874 File Offset: 0x00006A74
		public static Encoding DefaultEncoding
		{
			get
			{
				return Encoding.GetEncoding("IBM437");
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000888C File Offset: 0x00006A8C
		private void InsureUniqueEntry(ZipEntry ze1)
		{
			Dictionary<string, ZipEntry> entriesWritten = this._entriesWritten;
			string fileNameInArchive = ze1._FileNameInArchive;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000088C4 File Offset: 0x00006AC4
		internal Stream OutputStream
		{
			get
			{
				return this._outputStream;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000088D8 File Offset: 0x00006AD8
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000088EC File Offset: 0x00006AEC
		public bool ContainsEntry(string name)
		{
			/*
An exception occurred when decompiling this method (06000265)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipOutputStream::ContainsEntry(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_10, call:string(SharedUtilities::NormalizePathForUseInZipFile, ldloc:string(name)))
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

		// Token: 0x06000266 RID: 614 RVA: 0x0000890C File Offset: 0x00006B0C
		public override void Write(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000266)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::Write(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0052:
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000267 RID: 615 RVA: 0x00008974 File Offset: 0x00006B74
		public ZipEntry PutNextEntry(string entryName)
		{
			bool disposed;
			do
			{
				bool flag = string.IsNullOrEmpty(entryName);
				disposed = this._disposed;
			}
			while (disposed);
			this._FinishCurrentEntry();
			if (!disposed)
			{
			}
			ZipEntry zipEntry = ZipEntry.CreateForZipOutputStream(entryName);
			this._currentEntry = zipEntry;
			ZipEntry currentEntry = this._currentEntry;
			short bitField = currentEntry._BitField;
			currentEntry._BitField = bitField;
			if (bitField == 0)
			{
			}
			DateTime now = DateTime.Now;
			DateTime now2 = DateTime.Now;
			DateTime now3 = DateTime.Now;
			currentEntry.SetEntryTimes(now, now2, now3);
			ZipEntry currentEntry2 = this._currentEntry;
			CompressionLevel compressionLevel = this.<CompressionLevel>k__BackingField;
			currentEntry2.CompressionLevel = compressionLevel;
			ZipEntry currentEntry3 = this._currentEntry;
			CompressionMethod compressionMethod = this.<CompressionMethod>k__BackingField;
			currentEntry3.CompressionMethod = compressionMethod;
			ZipEntry currentEntry4 = this._currentEntry;
			string password = this._password;
			currentEntry4.Password = password;
			ZipEntry currentEntry5 = this._currentEntry;
			EncryptionAlgorithm encryption = this._encryption;
			currentEntry5.Encryption = encryption;
			ZipEntry currentEntry6 = this._currentEntry;
			Encoding alternateEncoding = this._alternateEncoding;
			currentEntry6.<AlternateEncoding>k__BackingField = alternateEncoding;
			ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
			currentEntry6.<AlternateEncodingUsage>k__BackingField = alternateEncodingUsage;
			bool flag2 = entryName.EndsWith("/");
			ZipEntry currentEntry7 = this._currentEntry;
			long num = 0L;
			currentEntry7.MarkAsDirectory();
			ZipEntryTimestamp timestamp = this._timestamp;
			this._currentEntry.EmitTimesInWindowsFormatWhenSaving = num != 0L;
			ZipEntryTimestamp timestamp2 = this._timestamp;
			this._currentEntry.EmitTimesInUnixFormatWhenSaving = num != 0L;
			ZipEntry currentEntry8 = this._currentEntry;
			this.InsureUniqueEntry(currentEntry8);
			this._needToWriteEntryHeader = true;
			return this._currentEntry;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008AE4 File Offset: 0x00006CE4
		private void _InitiateCurrentEntry(bool finishing)
		{
			/*
An exception occurred when decompiling this method (06000268)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipOutputStream::_InitiateCurrentEntry(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0080:
	stloc:int32(var_11_81, ldc.i4:int32(1))
	stfld:bool(ZipOutputStream::_exceptionPending, ldloc:ZipOutputStream(this), ldloc:int32[exp:bool](var_11_81))
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

		// Token: 0x06000269 RID: 617 RVA: 0x00002122 File Offset: 0x00000322
		private void _FinishCurrentEntry()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00008B7C File Offset: 0x00006D7C
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (!this._exceptionPending)
				{
					this._FinishCurrentEntry();
					Dictionary<string, ZipEntry> entriesWritten = this._entriesWritten;
					Stream outputStream = this._outputStream;
					Zip64Option zip = this._zip64;
					string comment = this._comment;
					if (this._outputStream != null)
					{
					}
					if (!this._leaveUnderlyingStreamOpen)
					{
					}
				}
				int num = 1;
				this._disposed = num != 0;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public override bool CanRead
		{
			get
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00008BE8 File Offset: 0x00006DE8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00008BF8 File Offset: 0x00006DF8
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00008C08 File Offset: 0x00006E08
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600026F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipOutputStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipOutputStream::_outputStream, ldloc:ZipOutputStream(this)))
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
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008C1C File Offset: 0x00006E1C
		public override void Flush()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002122 File Offset: 0x00000322
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400011E RID: 286
		private EncryptionAlgorithm _encryption;

		// Token: 0x0400011F RID: 287
		private ZipEntryTimestamp _timestamp;

		// Token: 0x04000120 RID: 288
		internal string _password;

		// Token: 0x04000121 RID: 289
		private string _comment;

		// Token: 0x04000122 RID: 290
		private Stream _outputStream;

		// Token: 0x04000123 RID: 291
		private ZipEntry _currentEntry;

		// Token: 0x04000124 RID: 292
		internal Zip64Option _zip64;

		// Token: 0x04000125 RID: 293
		private Dictionary<string, ZipEntry> _entriesWritten;

		// Token: 0x04000126 RID: 294
		private int _entryCount;

		// Token: 0x04000127 RID: 295
		private ZipOption _alternateEncodingUsage;

		// Token: 0x04000128 RID: 296
		private Encoding _alternateEncoding;

		// Token: 0x04000129 RID: 297
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400012A RID: 298
		private bool _disposed;

		// Token: 0x0400012B RID: 299
		private bool _exceptionPending;

		// Token: 0x0400012C RID: 300
		private bool _anyEntriesUsedZip64;

		// Token: 0x0400012D RID: 301
		private bool _directoryNeededZip64;

		// Token: 0x0400012E RID: 302
		private CountingStream _outputCounter;

		// Token: 0x0400012F RID: 303
		private Stream _encryptor;

		// Token: 0x04000130 RID: 304
		private Stream _deflater;

		// Token: 0x04000131 RID: 305
		private CrcCalculatorStream _entryOutputStream;

		// Token: 0x04000132 RID: 306
		private bool _needToWriteEntryHeader;

		// Token: 0x04000133 RID: 307
		private string _name;

		// Token: 0x04000134 RID: 308
		private bool _DontIgnoreCase;

		// Token: 0x04000135 RID: 309
		private int <CodecBufferSize>k__BackingField;

		// Token: 0x04000136 RID: 310
		private CompressionStrategy <Strategy>k__BackingField;

		// Token: 0x04000137 RID: 311
		private CompressionLevel <CompressionLevel>k__BackingField;

		// Token: 0x04000138 RID: 312
		private CompressionMethod <CompressionMethod>k__BackingField;
	}
}
