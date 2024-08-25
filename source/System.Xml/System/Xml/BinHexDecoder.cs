using System;
using System.Runtime.InteropServices;

namespace System.Xml
{
	// Token: 0x02000007 RID: 7
	internal class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021DC File Offset: 0x000003DC
		internal override bool IsFull
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600000A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.BinHexDecoder::get_IsFull()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BinHexDecoder::curIndex, ldloc:BinHexDecoder(this)))
	stloc:bool(var_1_0D, ldfld:bool(BinHexDecoder::hasHalfByteCached, ldloc:BinHexDecoder(this)))
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

		// Token: 0x0600000B RID: 11 RVA: 0x000021F8 File Offset: 0x000003F8
		internal override int Decode(char[] chars, int startPos, int len)
		{
			while (chars == null)
			{
			}
			if (len != 0)
			{
				byte[] array = this.buffer;
				int num = this.curIndex;
				bool flag = this.hasHalfByteCached;
				int num2 = this.curIndex;
				this.curIndex = num2;
			}
			return "len";
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002238 File Offset: 0x00000438
		public static byte[] Decode(char[] chars, bool allowOddChars)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000224C File Offset: 0x0000044C
		private unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, bool hasHalfByteCached, byte cachedHalfByte, [Out] int charsDecoded, [Out] int bytesDecoded)
		{
			XmlCharType instance = XmlCharType.Instance;
		}

		// Token: 0x0400000A RID: 10
		private byte[] buffer;

		// Token: 0x0400000B RID: 11
		private int curIndex;

		// Token: 0x0400000C RID: 12
		private int endIndex;

		// Token: 0x0400000D RID: 13
		private bool hasHalfByteCached;

		// Token: 0x0400000E RID: 14
		private byte cachedHalfByte;
	}
}
