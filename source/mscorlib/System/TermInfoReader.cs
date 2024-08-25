using System;
using System.IO;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000193 RID: 403
	internal class TermInfoReader
	{
		// Token: 0x06000FB5 RID: 4021 RVA: 0x000218CC File Offset: 0x0001FACC
		public TermInfoReader(string term, string filename)
		{
			FileStream fileStream = File.OpenRead(filename);
			byte[] array = this.buffer;
			this.ReadHeader(array, 0);
			byte[] array2 = this.buffer;
			int num = this.booleansOffset;
			int stringLength = this.GetString(array2, num)._stringLength;
			if (stringLength != 0)
			{
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00021948 File Offset: 0x0001FB48
		public TermInfoReader(string term, byte[] buffer)
		{
			while (buffer == null)
			{
			}
			this.buffer = buffer;
			int num = this.booleansOffset;
			string @string = this.GetString(buffer, num);
			int num2 = this.booleansOffset;
			int stringLength = @string._stringLength;
			this.booleansOffset = num2;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00021984 File Offset: 0x0001FB84
		private void DetermineVersion(short magic)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0002199C File Offset: 0x0001FB9C
		private void ReadHeader(byte[] buffer, int position)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000219AC File Offset: 0x0001FBAC
		private void ReadNames(byte[] buffer, int position)
		{
			string text;
			int stringLength = text._stringLength;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000219C0 File Offset: 0x0001FBC0
		public int Get(TermInfoNumbers number)
		{
			/*
An exception occurred when decompiling this method (06000FBA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TermInfoReader::Get(System.TermInfoNumbers)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TermInfoReader::numSize, ldloc:TermInfoReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(TermInfoReader::boolSize, ldloc:TermInfoReader(this)))
	stloc:int32(var_2_14, ldfld:int32(TermInfoReader::booleansOffset, ldloc:TermInfoReader(this)))
	stloc:uint8[](var_3_1B, ldfld:uint8[](TermInfoReader::buffer, ldloc:TermInfoReader(this)))
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

		// Token: 0x06000FBB RID: 4027 RVA: 0x000219E8 File Offset: 0x0001FBE8
		public string Get(TermInfoStrings tstr)
		{
			int num = this.strOffsets;
			int num2 = this.booleansOffset;
			int num3 = this.boolSize;
			int num4 = this.strOffsets;
			byte[] array = this.buffer;
			string text;
			return text;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00021A28 File Offset: 0x0001FC28
		public byte[] GetStringBytes(TermInfoStrings tstr)
		{
			int num = this.strOffsets;
			int num2 = this.booleansOffset;
			int num3 = this.boolSize;
			int num4 = this.strOffsets;
			byte[] array = this.buffer;
			byte[] array2;
			return array2;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000207A File Offset: 0x0000027A
		private short GetInt16(byte[] buffer, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00021A68 File Offset: 0x0001FC68
		private string GetString(byte[] buffer, int offset)
		{
			/*
An exception occurred when decompiling this method (06000FBE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TermInfoReader::GetString(System.Byte[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_ASCII))
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x00021A7C File Offset: 0x0001FC7C
		private byte[] GetStringBytes(byte[] buffer, int offset)
		{
		}

		// Token: 0x040006EE RID: 1774
		private int boolSize;

		// Token: 0x040006EF RID: 1775
		private int numSize;

		// Token: 0x040006F0 RID: 1776
		private int strOffsets;

		// Token: 0x040006F1 RID: 1777
		private byte[] buffer;

		// Token: 0x040006F2 RID: 1778
		private int booleansOffset;

		// Token: 0x040006F3 RID: 1779
		private int intOffset;
	}
}
