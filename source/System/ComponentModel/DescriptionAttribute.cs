using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000333 RID: 819
	[AttributeUsage(AttributeTargets.All)]
	public class DescriptionAttribute : Attribute
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00040140 File Offset: 0x0003E340
		public DescriptionAttribute()
		{
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00040154 File Offset: 0x0003E354
		public DescriptionAttribute(string description)
		{
			this.DescriptionValue = description;
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00040170 File Offset: 0x0003E370
		public virtual string Description
		{
			get
			{
				return this.<DescriptionValue>k__BackingField;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00040184 File Offset: 0x0003E384
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00040198 File Offset: 0x0003E398
		protected string DescriptionValue
		{
			[CompilerGenerated]
			get
			{
				return this.<DescriptionValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DescriptionValue>k__BackingField = value;
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000401AC File Offset: 0x0003E3AC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		public override int GetHashCode()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000401C4 File Offset: 0x0003E3C4
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (0600156D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DescriptionAttribute::IsDefaultAttribute()

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

		// Token: 0x0600156E RID: 5486 RVA: 0x000401D4 File Offset: 0x0003E3D4
		// Note: this type is marked as 'beforefieldinit'.
		static DescriptionAttribute()
		{
		}

		// Token: 0x04001184 RID: 4484
		public static readonly DescriptionAttribute Default;

		// Token: 0x04001185 RID: 4485
		[CompilerGenerated]
		private string <DescriptionValue>k__BackingField;
	}
}
