using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Terraria.Utilities;

// Token: 0x0200006B RID: 107
public class CacheFileManager : FileAPI
{
	// Token: 0x06000236 RID: 566 RVA: 0x00006578 File Offset: 0x00004778
	public CacheFileManager(FileManager fileMan, FileAPI api, bool primaryUser, PlatformUser user)
	{
		this.fileManager = fileMan;
		this.fileAPI = api;
		ManagedThread managedThread;
		this.UploadThread = managedThread;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000065A4 File Offset: 0x000047A4
	public void Shutdown()
	{
		ManagedThread uploadThread = this.UploadThread;
		if (uploadThread != null && uploadThread.IsAlive)
		{
			ManagedThread uploadThread2 = this.UploadThread;
			if (uploadThread == null)
			{
			}
			ThreadManager.TerminateThread(uploadThread2);
		}
		ManagedThread syncThread = this.SyncThread;
		if (syncThread != null && syncThread.IsAlive)
		{
			ManagedThread syncThread2 = this.SyncThread;
			if (syncThread == null)
			{
			}
			ThreadManager.TerminateThread(syncThread2);
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x000065F8 File Offset: 0x000047F8
	public void ResyncFiles()
	{
		bool flag = this.uploadPending.Reset();
		if (!true)
		{
		}
		ManagedThread managedThread;
		this.SyncThread = managedThread;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x000021DB File Offset: 0x000003DB
	public void FileSyncInternal(object threadContext)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000661C File Offset: 0x0000481C
	private void SyncFolder(string folderPath, bool recursive = false)
	{
		FileAPI fileAPI = this.fileAPI;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x000021DB File Offset: 0x000003DB
	private CachedFile GetFile(string path, bool create = true)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000665C File Offset: 0x0000485C
	public void SyncFile(string filePath)
	{
		int num = 1;
		CachedFile file = this.GetFile(filePath, num != 0);
		FileAPI fileAPI = this.fileAPI;
		string filename = file.Filename;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x000066D0 File Offset: 0x000048D0
	private void FileUpload(object threadContext)
	{
		int num = 1;
		ManualResetEvent manualResetEvent = this.uploadPending;
		PlatformUser user = this.User;
		PlatformUser.Platform platformId = this.User.PlatformId;
		LocalUser localUser = UserManagement.FindLocalUserByUser(user);
		if (localUser != null)
		{
			localUser.LoadThreadstate();
		}
		FileAPI fileAPI = this.fileAPI;
		this.UploadingFiles = num != 0;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00006784 File Offset: 0x00004984
	public string GetUserSavePath()
	{
		return this._userSavePath;
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00006798 File Offset: 0x00004998
	public void LegacySync()
	{
	}

	// Token: 0x06000240 RID: 576 RVA: 0x000067A8 File Offset: 0x000049A8
	public void Mount(bool forSync)
	{
	}

	// Token: 0x06000241 RID: 577 RVA: 0x000067B8 File Offset: 0x000049B8
	public void Unmount(bool forSync)
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000067C8 File Offset: 0x000049C8
	public void CreateDirectory(string directory)
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x000067D8 File Offset: 0x000049D8
	public void InSync()
	{
		List<CachedFile> list = this.modifications;
		int size = this.modifications._size;
		bool flag = this.uploadPending.Set();
	}

	// Token: 0x06000244 RID: 580 RVA: 0x000021DB File Offset: 0x000003DB
	public void WriteFile(string filename, byte[] fileData)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000245 RID: 581 RVA: 0x000021DB File Offset: 0x000003DB
	public void Delete(string filename)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000683C File Offset: 0x00004A3C
	public byte[] ReadFile(string filename)
	{
		CachedFile file;
		do
		{
			file = this.GetFile(filename, true);
		}
		while (file == null);
		return file.<Data>k__BackingField;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000685C File Offset: 0x00004A5C
	public string CleanPath(string path)
	{
		if (!true)
		{
		}
		string text = FileUtilities.CleanSwitchPath(path);
		string text2;
		return text2.Replace("//", "/");
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00006884 File Offset: 0x00004A84
	public string[] GetFiles(string path, string searchPattern)
	{
		int size = this.allFiles._size;
		throw new OutOfMemoryException();
	}

	// Token: 0x06000249 RID: 585 RVA: 0x000068AC File Offset: 0x00004AAC
	public string[] GetFolders(string path)
	{
	}

	// Token: 0x0600024A RID: 586 RVA: 0x000021DB File Offset: 0x000003DB
	public void GetFileModifications(List<CachedFile> files)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600024B RID: 587 RVA: 0x000068BC File Offset: 0x00004ABC
	public bool Exists(string filename)
	{
		/*
An exception occurred when decompiling this method (0600024B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean CacheFileManager::Exists(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_2_14, ldfld:uint8[](CachedFile::<Data>k__BackingField, ldloc:CachedFile(var_1_0A)))
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

	// Token: 0x0600024C RID: 588 RVA: 0x000068E0 File Offset: 0x00004AE0
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
	}

	// Token: 0x0400020C RID: 524
	public bool UploadingFiles;

	// Token: 0x0400020D RID: 525
	private List<CachedFile> allFiles;

	// Token: 0x0400020E RID: 526
	private List<CachedFile> modifications;

	// Token: 0x0400020F RID: 527
	private ManualResetEvent uploadPending;

	// Token: 0x04000210 RID: 528
	private readonly FileManager fileManager;

	// Token: 0x04000211 RID: 529
	private readonly FileAPI fileAPI;

	// Token: 0x04000212 RID: 530
	private readonly bool PrimaryUser;

	// Token: 0x04000213 RID: 531
	private readonly PlatformUser User;

	// Token: 0x04000214 RID: 532
	private ManagedThread UploadThread;

	// Token: 0x04000215 RID: 533
	private ManagedThread SyncThread;

	// Token: 0x04000216 RID: 534
	private string _userSavePath;
}
