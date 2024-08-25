using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000337 RID: 823
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		// Token: 0x0600157D RID: 5501 RVA: 0x00040320 File Offset: 0x0003E520
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
			this.Visibility = visibility;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0004033C File Offset: 0x0003E53C
		public DesignerSerializationVisibility Visibility
		{
			[CompilerGenerated]
			get
			{
				return this.<Visibility>k__BackingField;
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00040350 File Offset: 0x0003E550
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0004036C File Offset: 0x0003E56C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00040380 File Offset: 0x0003E580
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (06001581)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DesignerSerializationVisibilityAttribute::IsDefaultAttribute()

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

		// Token: 0x06001582 RID: 5506 RVA: 0x00040390 File Offset: 0x0003E590
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerSerializationVisibilityAttribute()
		{
		}

		// Token: 0x04001193 RID: 4499
		public static readonly DesignerSerializationVisibilityAttribute Content;

		// Token: 0x04001194 RID: 4500
		public static readonly DesignerSerializationVisibilityAttribute Hidden;

		// Token: 0x04001195 RID: 4501
		public static readonly DesignerSerializationVisibilityAttribute Visible;

		// Token: 0x04001196 RID: 4502
		public static readonly DesignerSerializationVisibilityAttribute Default;

		// Token: 0x04001197 RID: 4503
		[CompilerGenerated]
		private readonly DesignerSerializationVisibility <Visibility>k__BackingField;
	}
}
