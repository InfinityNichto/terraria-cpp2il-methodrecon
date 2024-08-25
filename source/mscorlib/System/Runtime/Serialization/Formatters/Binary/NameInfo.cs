using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042A RID: 1066
	internal sealed class NameInfo
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x0004BA48 File Offset: 0x00049C48
		internal NameInfo()
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0004BA5C File Offset: 0x00049C5C
		internal void Init()
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0004BA6C File Offset: 0x00049C6C
		public bool IsSealed
		{
			get
			{
				bool niisSealed;
				if (this.NIsealedStatusChecked)
				{
					niisSealed = this.NIisSealed;
				}
				bool isSealed = this.NItype.IsSealed;
				this.NIisSealed = niisSealed;
				this.NIsealedStatusChecked = true;
				return isSealed;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0004BAA4 File Offset: 0x00049CA4
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		public string NIname
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002140)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Serialization.Formatters.Binary.NameInfo::get_NIname()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0E, ldfld:Type(NameInfo::NItype, ldloc:NameInfo(this)))
	stfld:string(NameInfo::NIFullName, ldloc:NameInfo(this), ldloc:Type[exp:string](var_0_0E))
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
			set
			{
				this.NIFullName = value;
			}
		}

		// Token: 0x040011C2 RID: 4546
		internal string NIFullName;

		// Token: 0x040011C3 RID: 4547
		internal long NIobjectId;

		// Token: 0x040011C4 RID: 4548
		internal long NIassemId;

		// Token: 0x040011C5 RID: 4549
		internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

		// Token: 0x040011C6 RID: 4550
		internal Type NItype;

		// Token: 0x040011C7 RID: 4551
		internal bool NIisSealed;

		// Token: 0x040011C8 RID: 4552
		internal bool NIisArray;

		// Token: 0x040011C9 RID: 4553
		internal bool NIisArrayItem;

		// Token: 0x040011CA RID: 4554
		internal bool NItransmitTypeOnObject;

		// Token: 0x040011CB RID: 4555
		internal bool NItransmitTypeOnMember;

		// Token: 0x040011CC RID: 4556
		internal bool NIisParentTypeOnObject;

		// Token: 0x040011CD RID: 4557
		internal InternalArrayTypeE NIarrayEnum;

		// Token: 0x040011CE RID: 4558
		private bool NIsealedStatusChecked;
	}
}
