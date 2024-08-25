using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO.Enumeration
{
	// Token: 0x02000574 RID: 1396
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public ref struct FileSystemEntry
	{
		// Token: 0x06002A09 RID: 10761 RVA: 0x0005B698 File Offset: 0x00059898
		internal static FileAttributes Initialize(FileSystemEntry entry, Interop.Sys.DirectoryEntry directoryEntry, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory, Span<char> pathBuffer)
		{
			/*
An exception occurred when decompiling this method (06002A09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.FileAttributes System.IO.Enumeration.FileSystemEntry::Initialize(System.IO.Enumeration.FileSystemEntry,Interop/Sys/DirectoryEntry,System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>,System.Span`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0005B6B0 File Offset: 0x000598B0
		private ReadOnlySpan<char> FullPath
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002A0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<System.Char> System.IO.Enumeration.FileSystemEntry::get_FullPath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0058:
	stloc:int32(var_9_63, ldfld:int32(Span`1::_length, ldfld:valuetype System.Span`1<char>[exp:valuetype System.Span`1&](FileSystemEntry::_pathBuffer, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this))))
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
	stloc:valuetype System.Span`1<char>(var_11_73, ldfld:valuetype System.Span`1<char>(FileSystemEntry::_pathBuffer, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this)))
	stfld:valuetype System.ReadOnlySpan`1<char>(FileSystemEntry::_fullPath, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this), ldloc:valuetype System.Span`1<char>[exp:valuetype System.ReadOnlySpan`1<char>](var_11_73))
	stfld:int32(ReadOnlySpan`1::_length, ldfld:valuetype System.ReadOnlySpan`1<char>[exp:valuetype System.ReadOnlySpan`1&](FileSystemEntry::_fullPath, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this)), ldloc:valuetype System.ReadOnlySpan`1<char>[exp:int32](var_3_2A))
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x0005B748 File Offset: 0x00059948
		public ReadOnlySpan<char> FileName
		{
			get
			{
				if (true && this._fileName._length == 0)
				{
					ReadOnlySpan<char> readOnlySpan;
					this._fileName = readOnlySpan;
				}
				ReadOnlySpan<char> fileName = this._fileName;
				int length = this._fileName._length;
				return fileName;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0005B780 File Offset: 0x00059980
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x0005B7A4 File Offset: 0x000599A4
		public ReadOnlySpan<char> Directory
		{
			[CompilerGenerated]
			readonly get
			{
				ReadOnlySpan<char> readOnlySpan = this.<Directory>k__BackingField;
				int length = this.<Directory>k__BackingField._length;
				return readOnlySpan;
			}
			[CompilerGenerated]
			private set
			{
				this.<Directory>k__BackingField = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x0005B7B8 File Offset: 0x000599B8
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x0005B7DC File Offset: 0x000599DC
		public ReadOnlySpan<char> RootDirectory
		{
			[CompilerGenerated]
			readonly get
			{
				ReadOnlySpan<char> readOnlySpan = this.<RootDirectory>k__BackingField;
				int length = this.<RootDirectory>k__BackingField._length;
				return readOnlySpan;
			}
			[CompilerGenerated]
			private set
			{
				this.<RootDirectory>k__BackingField = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x0005B7F0 File Offset: 0x000599F0
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x0005B814 File Offset: 0x00059A14
		public ReadOnlySpan<char> OriginalRootDirectory
		{
			[CompilerGenerated]
			readonly get
			{
				ReadOnlySpan<char> readOnlySpan = this.<OriginalRootDirectory>k__BackingField;
				int length = this.<OriginalRootDirectory>k__BackingField._length;
				return readOnlySpan;
			}
			[CompilerGenerated]
			private set
			{
				this.<OriginalRootDirectory>k__BackingField = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x0005B828 File Offset: 0x00059A28
		public FileAttributes Attributes
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002A12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.FileAttributes System.IO.Enumeration.FileSystemEntry::get_Attributes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FileAttributes(var_0_06, ldfld:FileAttributes(FileSystemEntry::_initialAttributes, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this)))
	stloc:valuetype System.ReadOnlySpan`1<char>(var_1_0D, callgetter:ReadOnlySpan`1[exp:valuetype System.ReadOnlySpan`1<char>](FileSystemEntry::get_FullPath, ldloc:valuetype System.IO.Enumeration.FileSystemEntry&(this)))
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0005B844 File Offset: 0x00059A44
		public bool IsDirectory
		{
			get
			{
				return this._status.<InitiallyDirectory>k__BackingField;
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0005B85C File Offset: 0x00059A5C
		public string ToSpecifiedFullPath()
		{
			int length = this.<Directory>k__BackingField._length;
			int length2 = this.<RootDirectory>k__BackingField._length;
			ReadOnlySpan<char> readOnlySpan = this.<Directory>k__BackingField;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			ReadOnlySpan<char> readOnlySpan2 = this.<OriginalRootDirectory>k__BackingField;
			int length3 = this.<OriginalRootDirectory>k__BackingField._length;
			if (length == 0)
			{
			}
			bool flag = PathInternal.EndsInDirectorySeparator(readOnlySpan2);
			if (length == 0)
			{
			}
			bool flag2 = PathInternal.StartsWithDirectorySeparator(readOnlySpan);
			ThrowHelper.ThrowArgumentOutOfRangeException();
			ReadOnlySpan<char> readOnlySpan3 = this.<OriginalRootDirectory>k__BackingField;
			int length4 = this.<OriginalRootDirectory>k__BackingField._length;
			ReadOnlySpan<char> fileName = this.FileName;
			if (length == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0400168B RID: 5771
		internal Interop.Sys.DirectoryEntry _directoryEntry;

		// Token: 0x0400168C RID: 5772
		private FileStatus _status;

		// Token: 0x0400168D RID: 5773
		private Span<char> _pathBuffer;

		// Token: 0x0400168E RID: 5774
		private ReadOnlySpan<char> _fullPath;

		// Token: 0x0400168F RID: 5775
		private ReadOnlySpan<char> _fileName;

		// Token: 0x04001690 RID: 5776
		[FixedBuffer(typeof(char), 256)]
		private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer;

		// Token: 0x04001691 RID: 5777
		private FileAttributes _initialAttributes;

		// Token: 0x04001692 RID: 5778
		[CompilerGenerated]
		private ReadOnlySpan<char> <Directory>k__BackingField;

		// Token: 0x04001693 RID: 5779
		[CompilerGenerated]
		private ReadOnlySpan<char> <RootDirectory>k__BackingField;

		// Token: 0x04001694 RID: 5780
		[CompilerGenerated]
		private ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField;

		// Token: 0x02000575 RID: 1397
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 512)]
		public struct <_fileNameBuffer>e__FixedBuffer
		{
			// Token: 0x04001695 RID: 5781
			public char FixedElementField;
		}
	}
}
