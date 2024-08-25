using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.IO.Enumeration
{
	// Token: 0x0200057F RID: 1407
	public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		// Token: 0x06002A34 RID: 10804 RVA: 0x0005BC34 File Offset: 0x00059E34
		public FileSystemEnumerator(string directory, [Optional] EnumerationOptions options)
		{
			if (directory != null)
			{
				this._originalRootDirectory = directory;
				string text = PathInternal.TrimEndingDirectorySeparator(Path.GetFullPath(directory));
				this._rootDirectory = text;
				if (options == null)
				{
					if (!true)
					{
					}
					string rootDirectory = this._rootDirectory;
				}
				this._directoryHandle = this;
				int num = 1;
				this._lastEntryFound = num != 0;
				string rootDirectory2 = this._rootDirectory;
				this._currentPath = rootDirectory2;
				if (rootDirectory2 == null)
				{
				}
				int readDirRBufferSize = Interop.Sys.GetReadDirRBufferSize();
				return;
			}
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0005BCB4 File Offset: 0x00059EB4
		private bool InternalContinueOnError(Interop.ErrorInfo info, bool ignoreNotFound = false)
		{
			while (!this._options.<IgnoreInaccessible>k__BackingField)
			{
			}
			return true;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0005BCD0 File Offset: 0x00059ED0
		private static bool IsDirectoryNotFound(Interop.ErrorInfo info)
		{
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0005BCE0 File Offset: 0x00059EE0
		private static bool IsAccessError(Interop.ErrorInfo info)
		{
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x0005BCF0 File Offset: 0x00059EF0
		private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			/*
An exception occurred when decompiling this method (06002A38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.IO.Enumeration.FileSystemEnumerator`1::CreateDirectoryHandle(System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:native int(var_0_09, call:native int(Sys::OpenDir, ldloc:string(path)))
	stloc:Exception(var_3_18, call:Exception(Interop::GetExceptionForIoErrno, call:ErrorInfo(Sys::GetLastErrorInfo), ldloc:string(path), ldc.i4:bool(1)))
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

		// Token: 0x06002A39 RID: 10809 RVA: 0x0005BD18 File Offset: 0x00059F18
		private void CloseDirectoryHandle()
		{
			IntPtr intPtr;
			int num = Interop.Sys.CloseDir(intPtr);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0000207A File Offset: 0x0000027A
		public bool MoveNext()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x0005BD30 File Offset: 0x00059F30
		private void FindNextEntry()
		{
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x0005BD40 File Offset: 0x00059F40
		private unsafe void FindNextEntry(byte* entryBufferPtr, int bufferLength)
		{
			int num = 1;
			IntPtr directoryHandle = this._directoryHandle;
			if (num == 0)
			{
			}
			int num2;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0005BD64 File Offset: 0x00059F64
		private bool DequeueNextDirectory()
		{
			bool flag;
			if (flag)
			{
				TResult tresult;
				this._currentPath = tresult;
				this._directoryHandle = this;
				bool flag2;
				return flag2;
			}
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0005BD88 File Offset: 0x00059F88
		private void InternalDispose(bool disposing)
		{
			if (true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0005BDB8 File Offset: 0x00059FB8
		protected virtual bool ShouldIncludeEntry(FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x0005BDC8 File Offset: 0x00059FC8
		protected virtual bool ShouldRecurseIntoEntry(FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x06002A41 RID: 10817
		protected abstract TResult TransformEntry(FileSystemEntry entry);

		// Token: 0x06002A42 RID: 10818 RVA: 0x0005BDD8 File Offset: 0x00059FD8
		protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
		{
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0005BDE8 File Offset: 0x00059FE8
		protected virtual bool ContinueOnError(int error)
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x0000207A File Offset: 0x0000027A
		public TResult Current
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x0000207A File Offset: 0x0000027A
		object IEnumerator.Current
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0000207A File Offset: 0x0000027A
		private void DirectoryFinished()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0000207A File Offset: 0x0000027A
		public void Reset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0005BDF8 File Offset: 0x00059FF8
		public void Dispose()
		{
			if (!true)
			{
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0005BE10 File Offset: 0x0005A010
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0005BE20 File Offset: 0x0005A020
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x040016A8 RID: 5800
		private readonly string _originalRootDirectory;

		// Token: 0x040016A9 RID: 5801
		private readonly string _rootDirectory;

		// Token: 0x040016AA RID: 5802
		private readonly EnumerationOptions _options;

		// Token: 0x040016AB RID: 5803
		private readonly object _lock;

		// Token: 0x040016AC RID: 5804
		private string _currentPath;

		// Token: 0x040016AD RID: 5805
		private IntPtr _directoryHandle;

		// Token: 0x040016AE RID: 5806
		private bool _lastEntryFound;

		// Token: 0x040016AF RID: 5807
		private Queue<string> _pending;

		// Token: 0x040016B0 RID: 5808
		private Interop.Sys.DirectoryEntry _entry;

		// Token: 0x040016B1 RID: 5809
		private TResult _current;

		// Token: 0x040016B2 RID: 5810
		private char[] _pathBuffer;

		// Token: 0x040016B3 RID: 5811
		private byte[] _entryBuffer;
	}
}
