using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000338 RID: 824
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x000403A0 File Offset: 0x0003E5A0
		public DisplayNameAttribute()
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000403B4 File Offset: 0x0003E5B4
		public DisplayNameAttribute(string displayName)
		{
			this.DisplayNameValue = displayName;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000403D0 File Offset: 0x0003E5D0
		public virtual string DisplayName
		{
			get
			{
				return this.<DisplayNameValue>k__BackingField;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000403E4 File Offset: 0x0003E5E4
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x000403F8 File Offset: 0x0003E5F8
		protected string DisplayNameValue
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayNameValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DisplayNameValue>k__BackingField = value;
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0004040C File Offset: 0x0003E60C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
		public override int GetHashCode()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00040424 File Offset: 0x0003E624
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (0600158A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DisplayNameAttribute::IsDefaultAttribute()

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

		// Token: 0x0600158B RID: 5515 RVA: 0x00040434 File Offset: 0x0003E634
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayNameAttribute()
		{
		}

		// Token: 0x04001198 RID: 4504
		public static readonly DisplayNameAttribute Default;

		// Token: 0x04001199 RID: 4505
		[CompilerGenerated]
		private string <DisplayNameValue>k__BackingField;
	}
}
