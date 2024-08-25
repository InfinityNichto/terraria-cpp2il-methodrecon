using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000361 RID: 865
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x00041E4C File Offset: 0x0004004C
		public DataObjectAttribute()
		{
			this.IsDataObject = true;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00041E68 File Offset: 0x00040068
		public DataObjectAttribute(bool isDataObject)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00041E7C File Offset: 0x0004007C
		public bool IsDataObject
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDataObject>k__BackingField;
			}
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00041E90 File Offset: 0x00040090
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00041EAC File Offset: 0x000400AC
		public override int GetHashCode()
		{
			bool flag = this.<IsDataObject>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00041EC4 File Offset: 0x000400C4
		public override bool IsDefaultAttribute()
		{
			/*
An exception occurred when decompiling this method (06001697)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.DataObjectAttribute::IsDefaultAttribute()

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

		// Token: 0x06001698 RID: 5784 RVA: 0x00041ED4 File Offset: 0x000400D4
		// Note: this type is marked as 'beforefieldinit'.
		static DataObjectAttribute()
		{
		}

		// Token: 0x040011E8 RID: 4584
		public static readonly DataObjectAttribute DataObject;

		// Token: 0x040011E9 RID: 4585
		public static readonly DataObjectAttribute NonDataObject;

		// Token: 0x040011EA RID: 4586
		public static readonly DataObjectAttribute Default;

		// Token: 0x040011EB RID: 4587
		[CompilerGenerated]
		private readonly bool <IsDataObject>k__BackingField;
	}
}
