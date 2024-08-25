using System;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000267 RID: 615
	[Serializable]
	public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x0002B604 File Offset: 0x00029804
		public DecoderReplacementFallback()
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0002B614 File Offset: 0x00029814
		internal DecoderReplacementFallback(SerializationInfo info, StreamingContext context)
		{
			string @string = info.GetString("strDefault");
			this._strDefault = @string;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0002B64C File Offset: 0x0002984C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			string strDefault = this._strDefault;
			info.AddValue("strDefault", strDefault);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0002B66C File Offset: 0x0002986C
		public DecoderReplacementFallback(string replacement)
		{
			do
			{
				base..ctor();
			}
			while (replacement == null);
			int stringLength = replacement._stringLength;
			long num = 0L;
			if (stringLength == 0)
			{
			}
			bool flag = char.IsSurrogate(replacement, (int)num);
			if (stringLength == 0)
			{
			}
			bool flag2 = char.IsHighSurrogate(replacement, (int)num);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0002B6CC File Offset: 0x000298CC
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0002B6E0 File Offset: 0x000298E0
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			/*
An exception occurred when decompiling this method (060014C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.DecoderFallbackBuffer System.Text.DecoderReplacementFallback::CreateFallbackBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(DecoderReplacementFallback::_strDefault, ldloc:DecoderReplacementFallback(this)))
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0002B6F4 File Offset: 0x000298F4
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault._stringLength;
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0002B70C File Offset: 0x0002990C
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			string strDefault = this._strDefault;
			bool flag;
			return flag;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0002B728 File Offset: 0x00029928
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060014C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.DecoderReplacementFallback::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(DecoderReplacementFallback::_strDefault, ldloc:DecoderReplacementFallback(this)))
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

		// Token: 0x04000AF8 RID: 2808
		private string _strDefault;
	}
}
