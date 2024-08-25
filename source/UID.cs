using System;

// Token: 0x02000067 RID: 103
public static class UID
{
	// Token: 0x06000229 RID: 553 RVA: 0x00006440 File Offset: 0x00004640
	public static int Generate(string data)
	{
		UID.Initialise();
		string text;
		while (text != null)
		{
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00006458 File Offset: 0x00004658
	public static int Generate(byte[] data, int dataLength = -1)
	{
		/*
An exception occurred when decompiling this method (0600022A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UID::Generate(System.Byte[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(UID::Initialise)
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

	// Token: 0x0600022B RID: 555 RVA: 0x0000646C File Offset: 0x0000466C
	public static void InitialiseUIDGeneration(uint resultUID)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00006480 File Offset: 0x00004680
	public static void UIDGenerationAddInt(int value, uint resultUID)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00006490 File Offset: 0x00004690
	public static void UIDGenerationAddFloat(float value, uint resultUID)
	{
		if (!true)
		{
		}
		byte[] bytes = BitConverter.GetBytes(value);
	}

	// Token: 0x0600022E RID: 558 RVA: 0x000064AC File Offset: 0x000046AC
	public static void UIDGenerationAddString(string value, uint resultUID)
	{
		if (value != null)
		{
			string text = value.ToLowerInvariant();
			return;
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x000064C8 File Offset: 0x000046C8
	public static void FinaliseUIDGeneration(uint resultUID)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000064D8 File Offset: 0x000046D8
	private static uint Reflect(uint ulReflect, char cChar)
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x000064E8 File Offset: 0x000046E8
	private static void Initialise()
	{
		long num = 0L;
		int num2 = 7;
		int num3 = 8;
		num.m_value = (long)num2;
		num.m_value = (long)num3;
	}

	// Token: 0x04000204 RID: 516
	private static uint[] s_lookupTable;
}
