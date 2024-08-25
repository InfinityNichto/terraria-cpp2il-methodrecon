using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020002E3 RID: 739
public static class nativefiledialog
{
	// Token: 0x06001112 RID: 4370 RVA: 0x00055300 File Offset: 0x00053500
	private static int Utf8Size(string str)
	{
		return 1;
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00055310 File Offset: 0x00053510
	private unsafe static byte* Utf8EncodeNullable(string str)
	{
		/*
An exception occurred when decompiling this method (06001113)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* nativefiledialog::Utf8EncodeNullable(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:void*(var_0_0B, call:void*(native int::op_Explicit, call:native int(Marshal::AllocHGlobal, ldc.i4:int32(1))))
	stloc:int32(var_2_13, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	stloc:Encoding(var_4_1B, callgetter:Encoding(Encoding::get_UTF8))
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

	// Token: 0x06001114 RID: 4372 RVA: 0x0005533C File Offset: 0x0005353C
	private unsafe static string UTF8_ToManaged(IntPtr s, bool freePtr = false)
	{
		bool flag;
		if ((void*)(flag ? 1 : 0) != null)
		{
		}
		Encoding utf = Encoding.UTF8;
		string text;
		return text;
	}

	// Token: 0x06001115 RID: 4373
	private static extern void free(IntPtr ptr);

	// Token: 0x06001116 RID: 4374
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialog(byte* filterList, byte* defaultPath, [Out] IntPtr outPath);

	// Token: 0x06001117 RID: 4375 RVA: 0x00055360 File Offset: 0x00053560
	public unsafe static nativefiledialog.nfdresult_t NFD_OpenDialog(string filterList, string defaultPath, [Out] string outPath)
	{
		byte* ptr = nativefiledialog.Utf8EncodeNullable(filterList);
		IntPtr intPtr;
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr2;
		Marshal.FreeHGlobal(intPtr2);
		string text = nativefiledialog.UTF8_ToManaged(intPtr2, true);
		nativefiledialog.nfdresult_t nfdresult_t;
		return nfdresult_t;
	}

	// Token: 0x06001118 RID: 4376
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialogMultiple(byte* filterList, byte* defaultPath, [Out] nativefiledialog.nfdpathset_t outPaths);

	// Token: 0x06001119 RID: 4377 RVA: 0x0005538C File Offset: 0x0005358C
	public unsafe static nativefiledialog.nfdresult_t NFD_OpenDialogMultiple(string filterList, string defaultPath, [Out] nativefiledialog.nfdpathset_t outPaths)
	{
		byte* ptr = nativefiledialog.Utf8EncodeNullable(filterList);
		IntPtr intPtr;
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr2;
		Marshal.FreeHGlobal(intPtr2);
		nativefiledialog.nfdresult_t nfdresult_t;
		return nfdresult_t;
	}

	// Token: 0x0600111A RID: 4378
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_SaveDialog(byte* filterList, byte* defaultPath, [Out] IntPtr outPath);

	// Token: 0x0600111B RID: 4379 RVA: 0x000553B0 File Offset: 0x000535B0
	public unsafe static nativefiledialog.nfdresult_t NFD_SaveDialog(string filterList, string defaultPath, [Out] string outPath)
	{
		byte* ptr = nativefiledialog.Utf8EncodeNullable(filterList);
		IntPtr intPtr;
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr2;
		Marshal.FreeHGlobal(intPtr2);
		string text = nativefiledialog.UTF8_ToManaged(intPtr2, true);
		nativefiledialog.nfdresult_t nfdresult_t;
		return nfdresult_t;
	}

	// Token: 0x0600111C RID: 4380
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_PickFolder(byte* defaultPath, [Out] IntPtr outPath);

	// Token: 0x0600111D RID: 4381 RVA: 0x000553DC File Offset: 0x000535DC
	public static nativefiledialog.nfdresult_t NFD_PickFolder(string defaultPath, [Out] string outPath)
	{
		IntPtr intPtr;
		Marshal.FreeHGlobal(intPtr);
		string text = nativefiledialog.UTF8_ToManaged(intPtr, true);
		nativefiledialog.nfdresult_t nfdresult_t;
		return nfdresult_t;
	}

	// Token: 0x0600111E RID: 4382
	private static extern IntPtr INTERNAL_NFD_GetError();

	// Token: 0x0600111F RID: 4383 RVA: 0x000553F8 File Offset: 0x000535F8
	public static string NFD_GetError()
	{
		IntPtr intPtr = nativefiledialog.INTERNAL_NFD_GetError();
		long num = 0L;
		return nativefiledialog.UTF8_ToManaged(intPtr, num != 0L);
	}

	// Token: 0x06001120 RID: 4384
	public static extern IntPtr NFD_PathSet_GetCount(nativefiledialog.nfdpathset_t pathset);

	// Token: 0x06001121 RID: 4385
	private static extern IntPtr INTERNAL_NFD_PathSet_GetPath(nativefiledialog.nfdpathset_t pathset, IntPtr index);

	// Token: 0x06001122 RID: 4386 RVA: 0x00055414 File Offset: 0x00053614
	public static string NFD_PathSet_GetPath(nativefiledialog.nfdpathset_t pathset, IntPtr index)
	{
		long num = 0L;
		IntPtr intPtr;
		return nativefiledialog.UTF8_ToManaged(intPtr, num != 0L);
	}

	// Token: 0x06001123 RID: 4387
	public static extern void NFD_PathSet_Free(nativefiledialog.nfdpathset_t pathset);

	// Token: 0x040020E2 RID: 8418
	private const string nativeLibName = "nfd";

	// Token: 0x020002E4 RID: 740
	public enum nfdresult_t
	{
		// Token: 0x040020E4 RID: 8420
		NFD_ERROR,
		// Token: 0x040020E5 RID: 8421
		NFD_OKAY,
		// Token: 0x040020E6 RID: 8422
		NFD_CANCEL
	}

	// Token: 0x020002E5 RID: 741
	public struct nfdpathset_t
	{
		// Token: 0x040020E7 RID: 8423
		private IntPtr buf;

		// Token: 0x040020E8 RID: 8424
		private IntPtr indices;

		// Token: 0x040020E9 RID: 8425
		private IntPtr count;
	}
}
