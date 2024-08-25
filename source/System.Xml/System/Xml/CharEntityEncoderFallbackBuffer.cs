using System;
using System.Globalization;
using System.Text;

namespace System.Xml
{
	// Token: 0x0200000D RID: 13
	internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000024EC File Offset: 0x000006EC
		internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002510 File Offset: 0x00000710
		public override bool Fallback(char charUnknown, int index)
		{
			int num = this.charEntityIndex;
			CharEntityEncoderFallback charEntityEncoderFallback = this.parent;
			int curMarkPos = charEntityEncoderFallback.curMarkPos;
			charEntityEncoderFallback.curMarkPos = curMarkPos;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002550 File Offset: 0x00000750
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!true)
			{
			}
			bool flag = char.IsSurrogatePair(charUnknownHigh, charUnknownLow);
			int num = this.charEntityIndex;
			CharEntityEncoderFallback charEntityEncoderFallback = this.parent;
			int curMarkPos = charEntityEncoderFallback.curMarkPos;
			int[] textContentMarks = charEntityEncoderFallback.textContentMarks;
			charEntityEncoderFallback.curMarkPos = curMarkPos;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num2 = 1;
			int num3 = XmlCharType.CombineSurrogateChar(-1073741824, num2);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025B4 File Offset: 0x000007B4
		public override char GetNextChar()
		{
			char c;
			return c;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025C4 File Offset: 0x000007C4
		public override bool MovePrevious()
		{
			int num = this.charEntityIndex;
			this.charEntityIndex = num;
			return true;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000025E4 File Offset: 0x000007E4
		public override int Remaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000028)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.CharEntityEncoderFallbackBuffer::get_Remaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CharEntityEncoderFallbackBuffer::charEntityIndex, ldloc:CharEntityEncoderFallbackBuffer(this)))
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, ldfld:string(CharEntityEncoderFallbackBuffer::charEntity, ldloc:CharEntityEncoderFallbackBuffer(this))))
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

		// Token: 0x06000029 RID: 41 RVA: 0x00002608 File Offset: 0x00000808
		public override void Reset()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002618 File Offset: 0x00000818
		private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			int num;
			return num;
		}

		// Token: 0x04000020 RID: 32
		private CharEntityEncoderFallback parent;

		// Token: 0x04000021 RID: 33
		private string charEntity = 1;

		// Token: 0x04000022 RID: 34
		private int charEntityIndex;
	}
}
