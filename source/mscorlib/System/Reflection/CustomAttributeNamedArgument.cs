using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004F8 RID: 1272
	public struct CustomAttributeNamedArgument
	{
		// Token: 0x060024DB RID: 9435 RVA: 0x00051710 File Offset: 0x0004F910
		internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
		{
			this.TypedValue = typedValue;
			this.MemberName = memberName;
			this._attributeType = attributeType;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00051734 File Offset: 0x0004F934
		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
			if (memberInfo != null)
			{
				return;
			}
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00051774 File Offset: 0x0004F974
		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
			this._lazyMemberInfo = memberInfo;
			this._attributeType = memberInfo;
			this.TypedValue = typedArgument;
			if (memberInfo != null)
			{
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000517AC File Offset: 0x0004F9AC
		public readonly CustomAttributeTypedArgument TypedValue
		{
			[CompilerGenerated]
			get
			{
				return this.<TypedValue>k__BackingField;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x000517C0 File Offset: 0x0004F9C0
		public readonly bool IsField
		{
			[CompilerGenerated]
			get
			{
				return this.<IsField>k__BackingField;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000517D4 File Offset: 0x0004F9D4
		public readonly string MemberName
		{
			[CompilerGenerated]
			get
			{
				return this.<MemberName>k__BackingField;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000517E8 File Offset: 0x0004F9E8
		public MemberInfo MemberInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (060024E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.MemberInfo System.Reflection.CustomAttributeNamedArgument::get_MemberInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0037:
	stloc:Type(var_7_3D, ldfld:Type(CustomAttributeNamedArgument::_attributeType, ldloc:valuetype System.Reflection.CustomAttributeNamedArgument&(this)))
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

		// Token: 0x060024E2 RID: 9442 RVA: 0x00051834 File Offset: 0x0004FA34
		public override bool Equals(object obj)
		{
			/*
An exception occurred when decompiling this method (060024E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.CustomAttributeNamedArgument::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(CustomAttributeNamedArgument::<IsField>k__BackingField, ldloc:valuetype System.Reflection.CustomAttributeNamedArgument&(this)))
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

		// Token: 0x060024E3 RID: 9443 RVA: 0x00051848 File Offset: 0x0004FA48
		public override int GetHashCode()
		{
			bool flag = this.<IsField>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00051860 File Offset: 0x0004FA60
		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			bool flag = left.<IsField>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00051878 File Offset: 0x0004FA78
		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			bool flag = left.<IsField>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00051890 File Offset: 0x0004FA90
		public override string ToString()
		{
			int num = 1;
			Type attributeType = this._attributeType;
			if (num == 0)
			{
			}
			bool flag = this.<IsField>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x0400143F RID: 5183
		[CompilerGenerated]
		private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField;

		// Token: 0x04001440 RID: 5184
		[CompilerGenerated]
		private readonly bool <IsField>k__BackingField;

		// Token: 0x04001441 RID: 5185
		[CompilerGenerated]
		private readonly string <MemberName>k__BackingField;

		// Token: 0x04001442 RID: 5186
		private readonly Type _attributeType;

		// Token: 0x04001443 RID: 5187
		private MemberInfo _lazyMemberInfo;
	}
}
