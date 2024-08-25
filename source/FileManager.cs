using System;
using System.IO;
using System.Threading;
using UnityEngine;

// Token: 0x02000070 RID: 112
public class FileManager
{
	// Token: 0x0600026E RID: 622 RVA: 0x00006B0C File Offset: 0x00004D0C
	public FileManager(PlatformUser user, bool primaryUser)
	{
		if (this.CacheFiles)
		{
		}
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00006B28 File Offset: 0x00004D28
	public static void SynchroniseFiles()
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00006B38 File Offset: 0x00004D38
	public void Shutdown()
	{
		CacheFileManager fileCache = this.FileCache;
		if (fileCache != null)
		{
			fileCache.Shutdown();
		}
		FileAPI fileAPI = this.fileAPI;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00006B60 File Offset: 0x00004D60
	public static bool Exists(string path)
	{
		/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean FileManager::Exists(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_1_0F, ldfld:uint8[](CachedFile::<Data>k__BackingField, ldloc:CachedFile(var_0)))
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

	// Token: 0x06000272 RID: 626 RVA: 0x00006B7C File Offset: 0x00004D7C
	public static void Delete(string path)
	{
		Thread.Sleep(1);
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00006B94 File Offset: 0x00004D94
	public static void CreateDirectory(string path)
	{
		Thread.Sleep(1);
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00006BAC File Offset: 0x00004DAC
	public static byte[] ReadAllBytes(string path)
	{
		CachedFile cachedFile;
		do
		{
			Thread.Sleep(1);
		}
		while (cachedFile == null);
		return cachedFile.<Data>k__BackingField;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00006BC8 File Offset: 0x00004DC8
	public static string[] GetFiles(string path, string searchPattern)
	{
		Thread.Sleep(1);
		string[] array;
		return array;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00006BDC File Offset: 0x00004DDC
	public static void WriteAllBytes(string path, byte[] fileData)
	{
		Debug.LogError("WriteAllBytes " + path);
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00006C04 File Offset: 0x00004E04
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
	}

	// Token: 0x04000220 RID: 544
	[ThreadStatic]
	public static FileManager Instance;

	// Token: 0x04000221 RID: 545
	public bool CacheFiles;

	// Token: 0x04000222 RID: 546
	public FileAPI fileAPI;

	// Token: 0x04000223 RID: 547
	public CacheFileManager FileCache;

	// Token: 0x04000224 RID: 548
	public bool IsSyncingUserFiles;

	// Token: 0x04000225 RID: 549
	public bool IsWritingFiles;

	// Token: 0x04000226 RID: 550
	public SyncStatus syncStatus;
}
