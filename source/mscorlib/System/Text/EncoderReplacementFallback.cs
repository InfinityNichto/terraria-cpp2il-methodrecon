using System;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
	{
		// Token: 0x06001512 RID: 5394 RVA: 0x0002BE4C File Offset: 0x0002A04C
		public EncoderReplacementFallback()
		{
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0002BE5C File Offset: 0x0002A05C
		internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context)
		{
			string @string = info.GetString("strDefault");
			this._strDefault = @string;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0002BE94 File Offset: 0x0002A094
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			string strDefault = this._strDefault;
			info.AddValue("strDefault", strDefault);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		public EncoderReplacementFallback(string replacement)
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0002BF14 File Offset: 0x0002A114
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0002BF28 File Offset: 0x0002A128
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			/*
An exception occurred when decompiling this method (06001517)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.EncoderFallbackBuffer System.Text.EncoderReplacementFallback::CreateFallbackBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(EncoderReplacementFallback::_strDefault, ldloc:EncoderReplacementFallback(this)))
	stloc:string(var_1_0E, call:string(string::Concat, ldloc:string(var_0_06), ldloc:string(var_0_06)))
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0002BF44 File Offset: 0x0002A144
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault._stringLength;
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0002BF5C File Offset: 0x0002A15C
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			string strDefault = this._strDefault;
			bool flag;
			return flag;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0002BF78 File Offset: 0x0002A178
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600151A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.EncoderReplacementFallback::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(EncoderReplacementFallback::_strDefault, ldloc:EncoderReplacementFallback(this)))
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

		// Token: 0x04000B17 RID: 2839
		private string _strDefault;
	}
}
