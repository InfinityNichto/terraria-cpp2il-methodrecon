using System;
using System.Collections.Generic;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class CSVReader
{
	// Token: 0x060001C3 RID: 451 RVA: 0x000021DB File Offset: 0x000003DB
	public static CSVReader Load(string file)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x000021DB File Offset: 0x000003DB
	public static CSVReader LoadFromFile(string file)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000021DB File Offset: 0x000003DB
	public static CSVReader Load(byte[] fileData)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00005420 File Offset: 0x00003620
	public CSVReader()
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00005434 File Offset: 0x00003634
	public void Begin(string file)
	{
		this._filename = file;
		if (Resources.Load(file) != null)
		{
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00005468 File Offset: 0x00003668
	public void Begin(byte[] fileData)
	{
		this._fileData = fileData;
		string[] array = this.ReadLine();
		this.Headers = array;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000548C File Offset: 0x0000368C
	protected override void Finalize()
	{
		base.Finalize();
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000054A0 File Offset: 0x000036A0
	public string GetRawLine()
	{
		/*
An exception occurred when decompiling this method (060001CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String CSVReader::GetRawLine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint8[](var_1_0B, ldfld:uint8[](CSVReader::_fileData, ldloc:CSVReader(this)))
	stfld:int32(CSVReader::_fileOffset, ldloc:CSVReader(this), ldloc:uint8[][exp:int32](var_1_0B))
	stloc:Encoding(var_3_1A, callgetter:Encoding(Encoding::get_UTF8))
	stloc:uint8[](var_4_21, ldfld:uint8[](CSVReader::_fileData, ldloc:CSVReader(this)))
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

	// Token: 0x060001CB RID: 459 RVA: 0x000054D0 File Offset: 0x000036D0
	public string[] ReadLine()
	{
		if (this._fileData != null)
		{
			int fileOffset = this._fileOffset;
			string rawLine = this.GetRawLine();
			string[] array = this.DecodeLine(rawLine);
			int num = array.IndexOf("\"\"");
			string text;
			if (text == null || text != null)
			{
				return text;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x000021DB File Offset: 0x000003DB
	private string[] DecodeLine(string line)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00005520 File Offset: 0x00003720
	// Note: this type is marked as 'beforefieldinit'.
	static CSVReader()
	{
	}

	// Token: 0x04000134 RID: 308
	private static StringBuilder builder;

	// Token: 0x04000135 RID: 309
	private byte[] _fileData;

	// Token: 0x04000136 RID: 310
	private int _fileOffset;

	// Token: 0x04000137 RID: 311
	private string _filename;

	// Token: 0x04000138 RID: 312
	private List<string> _tokens;

	// Token: 0x04000139 RID: 313
	public string[] Headers;
}
