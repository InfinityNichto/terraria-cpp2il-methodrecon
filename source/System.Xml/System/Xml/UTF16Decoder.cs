using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200009C RID: 156
	internal class UTF16Decoder : Decoder
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x00018820 File Offset: 0x00016A20
		public UTF16Decoder(bool bigEndian)
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00003FFD File Offset: 0x000021FD
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00018834 File Offset: 0x00016A34
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			int num = this.lastByte;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00018850 File Offset: 0x00016A50
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			/*
An exception occurred when decompiling this method (06000749)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.UTF16Decoder::GetChars(System.Byte[],System.Int32,System.Int32,System.Char[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	call:void(Buffer::BlockCopy, ldloc:uint8[][exp:Array](bytes), ldloc:int32(byteIndex), ldloc:char[][exp:Array](chars), ldloc:int32(byteCount), ldloc:int32(byteCount))
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

		// Token: 0x0600074A RID: 1866 RVA: 0x00018894 File Offset: 0x00016A94
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, [Out] int bytesUsed, [Out] int charsUsed, [Out] bool completed)
		{
			int num = this.lastByte;
			if (byteCount == 0)
			{
				return;
			}
			int num2 = this.lastByte;
			bool flag = this.bigEndian;
			this.lastByte = num2;
			bool flag2 = this.bigEndian;
			if (num2 == 0)
			{
			}
			if (this.bigEndian)
			{
				return;
			}
		}

		// Token: 0x040003B7 RID: 951
		private bool bigEndian;

		// Token: 0x040003B8 RID: 952
		private int lastByte;
	}
}
