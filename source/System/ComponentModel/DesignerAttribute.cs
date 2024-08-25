using System;
using System.Diagnostics;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003DF RID: 991
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Conditional("FALSE")]
	public sealed class DesignerAttribute : Attribute
	{
		// Token: 0x06001A2F RID: 6703 RVA: 0x0004875C File Offset: 0x0004695C
		public DesignerAttribute(string designerTypeName)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = designerTypeName.ToUpper(invariantCulture);
			this.designerTypeName = designerTypeName;
			if (!true)
			{
			}
			Type type;
			this.designerBaseTypeName = type;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00048794 File Offset: 0x00046994
		public DesignerAttribute(Type designerType)
		{
			this.designerTypeName = designerType;
			Type type;
			this.designerBaseTypeName = type;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000487B8 File Offset: 0x000469B8
		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = designerTypeName.ToUpper(invariantCulture);
			this.designerTypeName = designerTypeName;
			this.designerBaseTypeName = designerBaseTypeName;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000487EC File Offset: 0x000469EC
		public DesignerAttribute(string designerTypeName, Type designerBaseType)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = designerTypeName.ToUpper(invariantCulture);
			this.designerTypeName = designerTypeName;
			this.designerBaseTypeName = designerBaseType;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00048820 File Offset: 0x00046A20
		public DesignerAttribute(Type designerType, Type designerBaseType)
		{
			this.designerTypeName = designerType;
			this.designerBaseTypeName = designerBaseType;
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00048844 File Offset: 0x00046A44
		public string DesignerBaseTypeName
		{
			get
			{
				return this.designerBaseTypeName;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00048858 File Offset: 0x00046A58
		public string DesignerTypeName
		{
			get
			{
				return this.designerTypeName;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0004886C File Offset: 0x00046A6C
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A36)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.DesignerAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0E, ldfld:string(DesignerAttribute::designerBaseTypeName, ldloc:DesignerAttribute(this)))
	stloc:int64(var_2_10, ldc.i4:int64(0))
	stloc:string(var_3_19, call:string(string::Substring, ldloc:string(var_0_0E), ldloc:int64[exp:int32](var_2_10), ldloc:int32(var_1)))
	stloc:Type(var_4_20, call:Type(object::GetType, ldloc:DesignerAttribute[exp:object](this)))
	stfld:string(DesignerAttribute::typeId, ldloc:DesignerAttribute(this), ldloc:string(var_5))
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

		// Token: 0x06001A37 RID: 6711 RVA: 0x000488A4 File Offset: 0x00046AA4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.designerBaseTypeName;
				string text2 = this.designerTypeName;
				bool flag;
				return flag;
			}
			return true;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000488C8 File Offset: 0x00046AC8
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001A38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.DesignerAttribute::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(DesignerAttribute::designerTypeName, ldloc:DesignerAttribute(this)))
	stloc:string(var_1_0D, ldfld:string(DesignerAttribute::designerBaseTypeName, ldloc:DesignerAttribute(this)))
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

		// Token: 0x04001304 RID: 4868
		private readonly string designerTypeName;

		// Token: 0x04001305 RID: 4869
		private readonly string designerBaseTypeName;

		// Token: 0x04001306 RID: 4870
		private string typeId;
	}
}
