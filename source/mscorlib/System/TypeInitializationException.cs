using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public sealed class TypeInitializationException : SystemException
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x000180A8 File Offset: 0x000162A8
		private TypeInitializationException()
			: base("Type constructor threw an exception.")
		{
			this._HResult = 5428;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000180CC File Offset: 0x000162CC
		public TypeInitializationException(string fullTypeName, Exception innerException)
		{
			string text = SR.Format("The type initializer for '{0}' threw an exception.", fullTypeName);
			base..ctor(text, innerException);
			this._typeName = fullTypeName;
			this._HResult = 5428;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00018100 File Offset: 0x00016300
		internal TypeInitializationException(string fullTypeName, string message, Exception innerException)
			: base(message, innerException)
		{
			this._typeName = fullTypeName;
			this._HResult = 5428;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00018128 File Offset: 0x00016328
		internal TypeInitializationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("TypeName");
			this._typeName = @string;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00018150 File Offset: 0x00016350
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (this._typeName == null)
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00018170 File Offset: 0x00016370
		public string TypeName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AA5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.TypeInitializationException::get_TypeName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](TypeInitializationException::_typeName, ldloc:TypeInitializationException(this)))
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
		}

		// Token: 0x040003F5 RID: 1013
		private string _typeName;
	}
}
