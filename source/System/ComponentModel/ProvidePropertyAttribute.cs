using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003AF RID: 943
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		// Token: 0x0600192A RID: 6442 RVA: 0x000468AC File Offset: 0x00044AAC
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
			this.PropertyName = propertyName;
			this.ReceiverTypeName = receiverType;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000468D0 File Offset: 0x00044AD0
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
			this.PropertyName = propertyName;
			this.ReceiverTypeName = receiverTypeName;
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x000468F4 File Offset: 0x00044AF4
		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyName>k__BackingField;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00046908 File Offset: 0x00044B08
		public string ReceiverTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<ReceiverTypeName>k__BackingField;
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0004691C File Offset: 0x00044B1C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.<PropertyName>k__BackingField;
				string text2 = this.<ReceiverTypeName>k__BackingField;
				bool flag;
				return flag;
			}
			return true;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00046940 File Offset: 0x00044B40
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600192F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.ProvidePropertyAttribute::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(ProvidePropertyAttribute::<PropertyName>k__BackingField, ldloc:ProvidePropertyAttribute(this)))
	stloc:string(var_1_0D, ldfld:string(ProvidePropertyAttribute::<ReceiverTypeName>k__BackingField, ldloc:ProvidePropertyAttribute(this)))
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

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0004695C File Offset: 0x00044B5C
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001930)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.ProvidePropertyAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:ProvidePropertyAttribute[exp:object](this)))
	stloc:string(var_1_0D, ldfld:string(ProvidePropertyAttribute::<PropertyName>k__BackingField, ldloc:ProvidePropertyAttribute(this)))
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

		// Token: 0x040012B3 RID: 4787
		[CompilerGenerated]
		private readonly string <PropertyName>k__BackingField;

		// Token: 0x040012B4 RID: 4788
		[CompilerGenerated]
		private readonly string <ReceiverTypeName>k__BackingField;
	}
}
