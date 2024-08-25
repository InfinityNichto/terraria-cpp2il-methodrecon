using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000344 RID: 836
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x060015BE RID: 5566 RVA: 0x00040800 File Offset: 0x0003EA00
		public ReadOnlyAttribute(bool isReadOnly)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00040814 File Offset: 0x0003EA14
		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				return this.<IsReadOnly>k__BackingField;
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00040828 File Offset: 0x0003EA28
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			return true;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00040844 File Offset: 0x0003EA44
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00040858 File Offset: 0x0003EA58
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (060015C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ReadOnlyAttribute::IsDefaultAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:bool(var_0_06, ldfld:bool(ReadOnlyAttribute::<IsReadOnly>k__BackingField, ldloc:ReadOnlyAttribute(this)))
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

		// Token: 0x060015C3 RID: 5571 RVA: 0x00040870 File Offset: 0x0003EA70
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
		}

		// Token: 0x040011AC RID: 4524
		public static readonly ReadOnlyAttribute Yes;

		// Token: 0x040011AD RID: 4525
		public static readonly ReadOnlyAttribute No;

		// Token: 0x040011AE RID: 4526
		public static readonly ReadOnlyAttribute Default;

		// Token: 0x040011AF RID: 4527
		[CompilerGenerated]
		private readonly bool <IsReadOnly>k__BackingField;
	}
}
