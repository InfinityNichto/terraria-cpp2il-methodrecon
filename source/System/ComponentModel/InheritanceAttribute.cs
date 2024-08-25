using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200036B RID: 875
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class InheritanceAttribute : Attribute
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x000424D4 File Offset: 0x000406D4
		public InheritanceAttribute()
		{
			if (!true)
			{
			}
			this.InheritanceLevel = InheritanceLevel.Inherited;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000424F4 File Offset: 0x000406F4
		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
		{
			this.InheritanceLevel = inheritanceLevel;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00042510 File Offset: 0x00040710
		public InheritanceLevel InheritanceLevel
		{
			[CompilerGenerated]
			get
			{
				return this.<InheritanceLevel>k__BackingField;
			}
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00042524 File Offset: 0x00040724
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			return true;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00042540 File Offset: 0x00040740
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00042554 File Offset: 0x00040754
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (060016D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.InheritanceAttribute::IsDefaultAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x060016D8 RID: 5848 RVA: 0x00042564 File Offset: 0x00040764
		public override string ToString()
		{
			if (!true)
			{
			}
			Type type;
			TypeConverter converter = TypeDescriptor.GetConverter(type);
			InheritanceLevel inheritanceLevel = this.<InheritanceLevel>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00042584 File Offset: 0x00040784
		// Note: this type is marked as 'beforefieldinit'.
		static InheritanceAttribute()
		{
		}

		// Token: 0x040011FF RID: 4607
		public static readonly InheritanceAttribute Inherited;

		// Token: 0x04001200 RID: 4608
		public static readonly InheritanceAttribute InheritedReadOnly;

		// Token: 0x04001201 RID: 4609
		public static readonly InheritanceAttribute NotInherited;

		// Token: 0x04001202 RID: 4610
		public static readonly InheritanceAttribute Default;

		// Token: 0x04001203 RID: 4611
		[CompilerGenerated]
		private readonly InheritanceLevel <InheritanceLevel>k__BackingField;
	}
}
