using System;
using System.IO;
using System.Text;
using Cpp2IlInjected;

namespace Terraria.Localization
{
	// Token: 0x0200055B RID: 1371
	public class NetworkText
	{
		// Token: 0x06003351 RID: 13137 RVA: 0x001FF1A8 File Offset: 0x001FD3A8
		private NetworkText(string text, NetworkText.Mode mode)
		{
			this._text = text;
			this._mode = mode;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x001FF1CC File Offset: 0x001FD3CC
		private static NetworkText[] ConvertSubstitutionsToNetworkText(object[] substitutions)
		{
			NetworkText networkText;
			if (networkText == null || networkText != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x001FF1E8 File Offset: 0x001FD3E8
		public static NetworkText FromFormattable(string text, params object[] substitutions)
		{
			/*
An exception occurred when decompiling this method (06003353)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.NetworkText Terraria.Localization.NetworkText::FromFormattable(System.String,System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000021DB File Offset: 0x000003DB
		public static NetworkText FromLiteral(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x001FF1F8 File Offset: 0x001FD3F8
		public static NetworkText FromKey(string key, params object[] substitutions)
		{
			/*
An exception occurred when decompiling this method (06003355)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Localization.NetworkText Terraria.Localization.NetworkText::FromKey(System.String,System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:int32[exp:bool](2))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x001FF208 File Offset: 0x001FD408
		public int GetMaxSerializedSize()
		{
			Encoding utf = Encoding.UTF8;
			string text = this._text;
			int num;
			if (this._mode != NetworkText.Mode.Literal)
			{
				NetworkText[] substitutions = this._substitutions;
				string text2 = substitutions._text;
				NetworkText.Mode mode = substitutions._mode;
				NetworkText[] substitutions2 = this._substitutions;
				return num;
			}
			return num;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x001FF254 File Offset: 0x001FD454
		public void Serialize(BinaryWriter writer)
		{
			NetworkText.Mode mode = this._mode;
			string text = this._text;
			this.SerializeSubstitutionList(writer);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x001FF278 File Offset: 0x001FD478
		private void SerializeSubstitutionList(BinaryWriter writer)
		{
			if (this._mode != NetworkText.Mode.Literal)
			{
				string text = this._substitutions._text;
				NetworkText[] substitutions = this._substitutions;
				if (substitutions._text != null)
				{
					NetworkText.Mode mode = substitutions._mode;
					string text2 = this._substitutions._text;
				}
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000021DB File Offset: 0x000003DB
		public static NetworkText Deserialize(BinaryReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000021DB File Offset: 0x000003DB
		public static NetworkText DeserializeLiteral(BinaryReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x001FF2C0 File Offset: 0x001FD4C0
		private void DeserializeSubstitutionList(BinaryReader reader)
		{
			if (this._mode != NetworkText.Mode.Literal)
			{
				NetworkText networkText = NetworkText.Deserialize(reader);
				if (networkText != null && networkText == null)
				{
					throw new ArrayTypeMismatchException();
				}
				NetworkText[] substitutions = this._substitutions;
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001FF2F4 File Offset: 0x001FD4F4
		private void SetToEmptyLiteral()
		{
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x001FF304 File Offset: 0x001FD504
		public override string ToString()
		{
			NetworkText.Mode mode = this._mode;
			return this._text;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x001FF374 File Offset: 0x001FD574
		private string ToDebugInfoString(string linePrefix = "")
		{
			NetworkText.Mode mode = this._mode;
			string text = this._text;
			NetworkText.Mode mode2 = this._mode;
			string textValue = Language.GetTextValue(this._text);
			string text2 = string.Format("{0}Localized Text: {1}\n", linePrefix, textValue);
			string text4;
			string text3 = text4 + text2;
			string text9;
			if (this._mode != NetworkText.Mode.Literal)
			{
				string text5 = this._substitutions._text;
				string text7;
				string text6 = text3 + text7;
				NetworkText.Mode mode3 = this._substitutions._mode;
				string text8 = linePrefix + "\t";
				string text10;
				text9 = text6 + text10;
				NetworkText[] substitutions = this._substitutions;
			}
			return text9;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x001FF410 File Offset: 0x001FD610
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkText()
		{
			NetworkText networkText = NetworkText.FromLiteral("");
		}

		// Token: 0x04003C2A RID: 15402
		public static readonly NetworkText Empty;

		// Token: 0x04003C2B RID: 15403
		private NetworkText[] _substitutions;

		// Token: 0x04003C2C RID: 15404
		private string _text;

		// Token: 0x04003C2D RID: 15405
		private NetworkText.Mode _mode;

		// Token: 0x0200055C RID: 1372
		private enum Mode : byte
		{
			// Token: 0x04003C2F RID: 15407
			Literal,
			// Token: 0x04003C30 RID: 15408
			Formattable,
			// Token: 0x04003C31 RID: 15409
			LocalizationKey
		}
	}
}
