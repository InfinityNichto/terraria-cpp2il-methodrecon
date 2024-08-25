using System;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004ED RID: 1261
	internal sealed class SignatureConstructedGenericType : SignatureType
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x000510BC File Offset: 0x0004F2BC
		internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			if (typeArguments != null)
			{
				object obj;
				long num2;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					num2 = 0L;
				}
				this._genericTypeDefinition = genericTypeDefinition;
				this._genericTypeArguments = num2;
				return;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000510F8 File Offset: 0x0004F2F8
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00051108 File Offset: 0x0004F308
		protected sealed override bool HasElementTypeImpl()
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00051118 File Offset: 0x0004F318
		protected sealed override bool IsArrayImpl()
		{
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00051128 File Offset: 0x0004F328
		protected sealed override bool IsByRefImpl()
		{
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00051138 File Offset: 0x0004F338
		protected sealed override bool IsPointerImpl()
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x00051148 File Offset: 0x0004F348
		public sealed override bool IsSZArray
		{
			get
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x00051158 File Offset: 0x0004F358
		public sealed override bool IsVariableBoundArray
		{
			get
			{
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x00051168 File Offset: 0x0004F368
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x00051178 File Offset: 0x0004F378
		public sealed override bool IsGenericParameter
		{
			get
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x00051188 File Offset: 0x0004F388
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x00051198 File Offset: 0x0004F398
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600244E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.SignatureConstructedGenericType::get_ContainsGenericParameters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Type[](var_0_06, ldfld:class System.Type[](SignatureConstructedGenericType::_genericTypeArguments, ldloc:SignatureConstructedGenericType(this)))
	stloc:class System.Type[](var_2_0F, ldfld:class System.Type[](SignatureConstructedGenericType::_genericTypeArguments, ldloc:SignatureConstructedGenericType(this)))
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000511BC File Offset: 0x0004F3BC
		internal sealed override SignatureType ElementType
		{
			get
			{
			}
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int GetArrayRank()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000511CC File Offset: 0x0004F3CC
		public sealed override Type GetGenericTypeDefinition()
		{
			return this._genericTypeDefinition;
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override Type[] GetGenericArguments()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000511E0 File Offset: 0x0004F3E0
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				Type[] genericTypeArguments = this._genericTypeArguments;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x00051200 File Offset: 0x0004F400
		public sealed override string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002455)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.SignatureConstructedGenericType::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, ldfld:Type(SignatureConstructedGenericType::_genericTypeDefinition, ldloc:SignatureConstructedGenericType(this)))
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x00051214 File Offset: 0x0004F414
		public sealed override string Namespace
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002456)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.SignatureConstructedGenericType::get_Namespace()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, ldfld:Type(SignatureConstructedGenericType::_genericTypeDefinition, ldloc:SignatureConstructedGenericType(this)))
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

		// Token: 0x06002457 RID: 9303 RVA: 0x00051228 File Offset: 0x0004F428
		public sealed override string ToString()
		{
			/*
An exception occurred when decompiling this method (06002457)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.SignatureConstructedGenericType::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:class System.Type[](var_9_27, ldfld:class System.Type[](SignatureConstructedGenericType::_genericTypeArguments, ldloc:SignatureConstructedGenericType(this)))
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

		// Token: 0x0400141A RID: 5146
		private readonly Type _genericTypeDefinition;

		// Token: 0x0400141B RID: 5147
		private readonly Type[] _genericTypeArguments;
	}
}
