using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003BF RID: 959
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute
	{
		// Token: 0x06001980 RID: 6528 RVA: 0x000473D4 File Offset: 0x000455D4
		public TypeConverterAttribute()
		{
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000473E8 File Offset: 0x000455E8
		public TypeConverterAttribute(Type type)
		{
			this.ConverterTypeName = type;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00047404 File Offset: 0x00045604
		public TypeConverterAttribute(string typeName)
		{
			this.ConverterTypeName = typeName;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x00047420 File Offset: 0x00045620
		public string ConverterTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<ConverterTypeName>k__BackingField;
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00047434 File Offset: 0x00045634
		public override bool Equals(object obj)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00047444 File Offset: 0x00045644
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001985)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.TypeConverterAttribute::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(TypeConverterAttribute::<ConverterTypeName>k__BackingField, ldloc:TypeConverterAttribute(this)))
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

		// Token: 0x06001986 RID: 6534 RVA: 0x00047458 File Offset: 0x00045658
		// Note: this type is marked as 'beforefieldinit'.
		static TypeConverterAttribute()
		{
		}

		// Token: 0x040012D3 RID: 4819
		public static readonly TypeConverterAttribute Default;

		// Token: 0x040012D4 RID: 4820
		[CompilerGenerated]
		private readonly string <ConverterTypeName>k__BackingField;
	}
}
