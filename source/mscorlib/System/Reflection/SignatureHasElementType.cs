using System;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004EE RID: 1262
	internal abstract class SignatureHasElementType : SignatureType
	{
		// Token: 0x06002458 RID: 9304 RVA: 0x00051264 File Offset: 0x0004F464
		protected SignatureHasElementType(SignatureType elementType)
		{
			this._elementType = elementType;
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00051280 File Offset: 0x0004F480
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00051290 File Offset: 0x0004F490
		protected sealed override bool HasElementTypeImpl()
		{
			return true;
		}

		// Token: 0x0600245B RID: 9307
		protected abstract override bool IsArrayImpl();

		// Token: 0x0600245C RID: 9308
		protected abstract override bool IsByRefImpl();

		// Token: 0x0600245D RID: 9309
		protected abstract override bool IsPointerImpl();

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600245E RID: 9310
		public abstract override bool IsSZArray { get; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600245F RID: 9311
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000512A0 File Offset: 0x0004F4A0
		public sealed override bool IsConstructedGenericType
		{
			get
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000512B0 File Offset: 0x0004F4B0
		public sealed override bool IsGenericParameter
		{
			get
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000512C0 File Offset: 0x0004F4C0
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000512D0 File Offset: 0x0004F4D0
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002463)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.SignatureHasElementType::get_ContainsGenericParameters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SignatureType(var_0_06, ldfld:SignatureType(SignatureHasElementType::_elementType, ldloc:SignatureHasElementType(this)))
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

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000512E4 File Offset: 0x0004F4E4
		internal sealed override SignatureType ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x06002465 RID: 9317
		public abstract override int GetArrayRank();

		// Token: 0x06002466 RID: 9318 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type GetGenericTypeDefinition()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000512F8 File Offset: 0x0004F4F8
		public sealed override Type[] GetGenericArguments()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x0005130C File Offset: 0x0004F50C
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x00051320 File Offset: 0x0004F520
		public sealed override string Name
		{
			get
			{
				SignatureType elementType = this._elementType;
				string text;
				return text;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x00051338 File Offset: 0x0004F538
		public sealed override string Namespace
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600246B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.SignatureHasElementType::get_Namespace()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SignatureType(var_0_06, ldfld:SignatureType(SignatureHasElementType::_elementType, ldloc:SignatureHasElementType(this)))
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

		// Token: 0x0600246C RID: 9324 RVA: 0x0005134C File Offset: 0x0004F54C
		public sealed override string ToString()
		{
			SignatureType elementType = this._elementType;
			string text;
			return text;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600246D RID: 9325
		protected abstract string Suffix { get; }

		// Token: 0x0400141C RID: 5148
		private readonly SignatureType _elementType;
	}
}
