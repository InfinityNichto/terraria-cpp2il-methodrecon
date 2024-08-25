using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x02000032 RID: 50
	internal class ZipSegmentedStream : Stream
	{
		// Token: 0x06000283 RID: 643 RVA: 0x00008E18 File Offset: 0x00007018
		private ZipSegmentedStream()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002122 File Offset: 0x00000322
		public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00008E30 File Offset: 0x00007030
		public static ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
		{
			/*
An exception occurred when decompiling this method (06000285)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipSegmentedStream Ionic.Zip.ZipSegmentedStream::ForWriting(System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("")))
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

		// Token: 0x06000286 RID: 646 RVA: 0x00008E50 File Offset: 0x00007050
		public static Stream ForUpdate(string name, uint diskNumber)
		{
			/*
An exception occurred when decompiling this method (06000286)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipSegmentedStream::ForUpdate(System.String,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_06, call:string(Path::GetFileNameWithoutExtension, ldloc:string(var_0)))
	stloc:string(var_2_0E, call:string(Path::Combine, ldloc:string(var_0), ldloc:string(var_1_06)))
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00008E6C File Offset: 0x0000706C
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00008E80 File Offset: 0x00007080
		public bool ContiguousWrite
		{
			get
			{
				return this.<ContiguousWrite>k__BackingField;
			}
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00008E90 File Offset: 0x00007090
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00008EA4 File Offset: 0x000070A4
		public uint CurrentSegment
		{
			get
			{
				return this._currentDiskNumber;
			}
			private set
			{
				this._currentDiskNumber = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00008EB8 File Offset: 0x000070B8
		public string CurrentName
		{
			get
			{
				string text;
				if (this._currentName == null)
				{
					uint currentDiskNumber = this._currentDiskNumber;
					text = this._NameForSegment(currentDiskNumber);
					this._currentName = text;
				}
				return text;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00008EE4 File Offset: 0x000070E4
		public string CurrentTempName
		{
			get
			{
				return this._currentTempName;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008EF8 File Offset: 0x000070F8
		private string _NameForSegment(uint diskNumber)
		{
			string directoryName = Path.GetDirectoryName(this._baseName);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this._baseName);
			string text = Path.Combine(directoryName, fileNameWithoutExtension);
			string text2;
			return text2;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00008F2C File Offset: 0x0000712C
		public uint ComputeSegment(int length)
		{
			/*
An exception occurred when decompiling this method (0600028E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Ionic.Zip.ZipSegmentedStream::ComputeSegment(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	stloc:uint32(var_1_0D, ldfld:uint32(ZipSegmentedStream::_currentDiskNumber, ldloc:ZipSegmentedStream(this)))
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

		// Token: 0x0600028F RID: 655 RVA: 0x00008F48 File Offset: 0x00007148
		public override string ToString()
		{
			if ("ZipSegmentedStream" == null || "ZipSegmentedStream" != null)
			{
				string text;
				if (this._currentName == null)
				{
					uint currentDiskNumber = this._currentDiskNumber;
					text = this._NameForSegment(currentDiskNumber);
					this._currentName = text;
					if (text == null)
					{
						goto IL_0032;
					}
				}
				if (text == null)
				{
					goto IL_0042;
				}
				IL_0032:
				ZipSegmentedStream.RwMode rwMode = this.rwMode;
				string text2;
				if (text2 == null || text2 != null)
				{
					string text3;
					return text3;
				}
			}
			IL_0042:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008F9C File Offset: 0x0000719C
		private void _SetReadStream()
		{
			if (this._innerStream != null)
			{
			}
			uint currentDiskNumber = this._currentDiskNumber;
			int maxSegmentSize = this._maxSegmentSize;
			string baseName = this._baseName;
			this._currentName = baseName;
			if (baseName == null)
			{
				return;
			}
			string text;
			FileStream fileStream = File.OpenRead(text);
			this._innerStream = fileStream;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00008FF8 File Offset: 0x000071F8
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000291)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipSegmentedStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RwMode(var_0_06, ldfld:RwMode(ZipSegmentedStream::rwMode, ldloc:ZipSegmentedStream(this)))
	stloc:Stream(var_1_0D, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	stloc:Stream(var_2_14, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	stloc:Stream(var_3_1B, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	stloc:uint32(var_4_22, ldfld:uint32(ZipSegmentedStream::_currentDiskNumber, ldloc:ZipSegmentedStream(this)))
	stloc:int32(var_5_2A, ldfld:int32(ZipSegmentedStream::_maxSegmentSize, ldloc:ZipSegmentedStream(this)))
	stfld:uint32(ZipSegmentedStream::_currentDiskNumber, ldloc:ZipSegmentedStream(this), ldloc:uint32(var_4_22))
	call:void(ZipSegmentedStream::_SetReadStream, ldloc:ZipSegmentedStream(this))
	stloc:Stream(var_6_40, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	stloc:int32(var_7_43, ldc.i4:int32(1))
	stfld:bool(ZipSegmentedStream::_exceptionPending, ldloc:ZipSegmentedStream(this), ldloc:int32[exp:bool](var_7_43))
	stloc:string(var_8_53, callgetter:string(ZipSegmentedStream::get_CurrentName, ldloc:ZipSegmentedStream(this)))
	stloc:string(var_9_61, call:string(string::Format, ldstr:string("Read error in file {0}"), ldloc:string[exp:object](var_8_53)))
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

		// Token: 0x06000292 RID: 658 RVA: 0x0000906C File Offset: 0x0000726C
		private void _SetWriteStream(uint increment)
		{
			if (this._innerStream != null)
			{
				string text;
				if (this._currentName == null)
				{
					uint currentDiskNumber = this._currentDiskNumber;
					text = this._NameForSegment(currentDiskNumber);
					this._currentName = text;
				}
				bool flag = File.Exists(text);
				string text2;
				if (this._currentName == null)
				{
					uint currentDiskNumber2 = this._currentDiskNumber;
					text2 = this._NameForSegment(currentDiskNumber2);
					this._currentName = text2;
				}
				File.Delete(text2);
				string currentName = this._currentName;
				string currentTempName = this._currentTempName;
				string text3;
				if (currentName == null)
				{
					uint currentDiskNumber3 = this._currentDiskNumber;
					text3 = this._NameForSegment(currentDiskNumber3);
					this._currentName = text3;
				}
				File.Move(currentTempName, text3);
			}
			if (increment != 0U)
			{
				uint currentDiskNumber4 = this._currentDiskNumber;
				this._currentDiskNumber = currentDiskNumber4;
			}
			string baseDir = this._baseDir;
			if (this._currentDiskNumber != 0U)
			{
				return;
			}
			byte[] bytes = BitConverter.GetBytes(19280);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00009138 File Offset: 0x00007338
		public override void Write(byte[] buffer, int offset, int count)
		{
			ZipSegmentedStream.RwMode rwMode = this.rwMode;
			Stream innerStream = this._innerStream;
			bool flag = this.<ContiguousWrite>k__BackingField;
			int maxSegmentSize = this._maxSegmentSize;
			if (flag)
			{
				int num = 1;
				this._SetWriteStream((uint)num);
				return;
			}
			Stream innerStream2 = this._innerStream;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000091A8 File Offset: 0x000073A8
		public long TruncateBackward(uint diskNumber, long offset)
		{
			ZipSegmentedStream.RwMode rwMode = this.rwMode;
			uint currentDiskNumber = this._currentDiskNumber;
			if (this._innerStream != null)
			{
				bool flag = File.Exists(this._currentTempName);
				File.Delete(this._currentTempName);
			}
			uint currentDiskNumber2 = this._currentDiskNumber;
			string text = this._NameForSegment((uint)43151360);
			bool flag2 = File.Exists(text);
			File.Delete(text);
			this._currentDiskNumber = diskNumber;
			if (currentDiskNumber2 == 0U)
			{
			}
			string text2 = SharedUtilities.InternalGetTempFileName();
			string currentName = this._currentName;
			this._currentTempName = text2;
			string text3;
			string currentTempName;
			if (currentName == null)
			{
				uint currentDiskNumber3 = this._currentDiskNumber;
				text3 = this._NameForSegment(currentDiskNumber3);
				currentTempName = this._currentTempName;
				this._currentName = text3;
			}
			File.Move(text3, currentTempName);
			throw new OutOfMemoryException();
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00009278 File Offset: 0x00007478
		public override bool CanRead
		{
			get
			{
				ZipSegmentedStream.RwMode rwMode = this.rwMode;
				if (this._innerStream != null)
				{
					return;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00009298 File Offset: 0x00007498
		public override bool CanSeek
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000296)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipSegmentedStream::get_CanSeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:Stream[exp:bool](ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this))))
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000092AC File Offset: 0x000074AC
		public override bool CanWrite
		{
			get
			{
				ZipSegmentedStream.RwMode rwMode = this.rwMode;
				if (this._innerStream != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000092CC File Offset: 0x000074CC
		public override void Flush()
		{
			Stream innerStream = this._innerStream;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000092E0 File Offset: 0x000074E0
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000299)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipSegmentedStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000092F4 File Offset: 0x000074F4
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00009308 File Offset: 0x00007508
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600029A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipSegmentedStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
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
				Stream innerStream = this._innerStream;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000931C File Offset: 0x0000751C
		public override long Seek(long offset, SeekOrigin origin)
		{
			/*
An exception occurred when decompiling this method (0600029C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipSegmentedStream::Seek(System.Int64,System.IO.SeekOrigin)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
	call:void(SharedUtilities::Workaround_Ladybug318918, ldfld:Stream(ZipSegmentedStream::_innerStream, ldloc:ZipSegmentedStream(this)))
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

		// Token: 0x0600029D RID: 669 RVA: 0x0000933C File Offset: 0x0000753C
		public override void SetLength(long value)
		{
			ZipSegmentedStream.RwMode rwMode = this.rwMode;
			Stream innerStream = this._innerStream;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00009358 File Offset: 0x00007558
		protected override void Dispose(bool disposing)
		{
			if (this._innerStream != null)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x0400013C RID: 316
		private ZipSegmentedStream.RwMode rwMode;

		// Token: 0x0400013D RID: 317
		private bool _exceptionPending;

		// Token: 0x0400013E RID: 318
		private string _baseName;

		// Token: 0x0400013F RID: 319
		private string _baseDir;

		// Token: 0x04000140 RID: 320
		private string _currentName;

		// Token: 0x04000141 RID: 321
		private string _currentTempName;

		// Token: 0x04000142 RID: 322
		private uint _currentDiskNumber;

		// Token: 0x04000143 RID: 323
		private uint _maxDiskNumber;

		// Token: 0x04000144 RID: 324
		private int _maxSegmentSize;

		// Token: 0x04000145 RID: 325
		private Stream _innerStream;

		// Token: 0x04000146 RID: 326
		private bool <ContiguousWrite>k__BackingField;

		// Token: 0x02000033 RID: 51
		private enum RwMode
		{
			// Token: 0x04000148 RID: 328
			None,
			// Token: 0x04000149 RID: 329
			ReadOnly,
			// Token: 0x0400014A RID: 330
			Write
		}
	}
}
