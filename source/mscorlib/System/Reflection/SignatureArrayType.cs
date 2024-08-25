using System;

namespace System.Reflection
{
	// Token: 0x020004EB RID: 1259
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x00050F70 File Offset: 0x0004F170
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
		{
			this._elementType = elementType;
			this._rank = rank;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00050F94 File Offset: 0x0004F194
		protected sealed override bool IsArrayImpl()
		{
			return true;
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00050FA4 File Offset: 0x0004F1A4
		protected sealed override bool IsByRefImpl()
		{
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00050FB4 File Offset: 0x0004F1B4
		protected sealed override bool IsPointerImpl()
		{
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00050FC4 File Offset: 0x0004F1C4
		public sealed override bool IsSZArray
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002437)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.SignatureArrayType::get_IsSZArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(SignatureArrayType::_isMultiDim, ldloc:SignatureArrayType(this)))
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x00050FD8 File Offset: 0x0004F1D8
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return this._isMultiDim;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00050FEC File Offset: 0x0004F1EC
		public sealed override int GetArrayRank()
		{
			return this._rank;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x00051000 File Offset: 0x0004F200
		protected sealed override string Suffix
		{
			get
			{
				if (this._isMultiDim)
				{
					int rank = this._rank;
					return "]";
				}
				return "[]";
			}
		}

		// Token: 0x04001418 RID: 5144
		private readonly int _rank;

		// Token: 0x04001419 RID: 5145
		private readonly bool _isMultiDim;
	}
}
