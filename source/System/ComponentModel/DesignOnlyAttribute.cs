using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000334 RID: 820
	[AttributeUsage(AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x000401E4 File Offset: 0x0003E3E4
		public DesignOnlyAttribute(bool isDesignOnly)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000401F8 File Offset: 0x0003E3F8
		public bool IsDesignOnly
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDesignOnly>k__BackingField;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0004020C File Offset: 0x0003E40C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00040228 File Offset: 0x0003E428
		public override int GetHashCode()
		{
			bool flag = this.<IsDesignOnly>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00040240 File Offset: 0x0003E440
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (06001573)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DesignOnlyAttribute::IsDefaultAttribute()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:bool(var_0_06, ldfld:bool(DesignOnlyAttribute::<IsDesignOnly>k__BackingField, ldloc:DesignOnlyAttribute(this)))
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

		// Token: 0x06001574 RID: 5492 RVA: 0x00040258 File Offset: 0x0003E458
		// Note: this type is marked as 'beforefieldinit'.
		static DesignOnlyAttribute()
		{
		}

		// Token: 0x04001186 RID: 4486
		[CompilerGenerated]
		private readonly bool <IsDesignOnly>k__BackingField;

		// Token: 0x04001187 RID: 4487
		public static readonly DesignOnlyAttribute Yes;

		// Token: 0x04001188 RID: 4488
		public static readonly DesignOnlyAttribute No;

		// Token: 0x04001189 RID: 4489
		public static readonly DesignOnlyAttribute Default;
	}
}
