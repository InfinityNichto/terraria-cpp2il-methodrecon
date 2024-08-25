using System;

namespace System.ComponentModel
{
	// Token: 0x02000397 RID: 919
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x00043C30 File Offset: 0x00041E30
		public LicenseProviderAttribute()
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00043C44 File Offset: 0x00041E44
		public LicenseProviderAttribute(string typeName)
		{
			this._licenseProviderName = typeName;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00043C60 File Offset: 0x00041E60
		public LicenseProviderAttribute(Type type)
		{
			this._licenseProviderType = type;
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00043C7C File Offset: 0x00041E7C
		public Type LicenseProvider
		{
			get
			{
				Type licenseProviderType = this._licenseProviderType;
				if (!true)
				{
				}
				string licenseProviderName = this._licenseProviderName;
				if (licenseProviderName != null)
				{
					if (!true)
					{
					}
					this._licenseProviderType = licenseProviderName;
				}
				return this._licenseProviderType;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00043CB0 File Offset: 0x00041EB0
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (060017ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.LicenseProviderAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:Type(var_3_1C, call:Type(object::GetType, ldloc:LicenseProviderAttribute[exp:object](this)))
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

		// Token: 0x060017EE RID: 6126 RVA: 0x00043CDC File Offset: 0x00041EDC
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			Type licenseProvider = this.LicenseProvider;
			Type type;
			bool flag = type == licenseProvider;
			return true;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00043D08 File Offset: 0x00041F08
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00043D1C File Offset: 0x00041F1C
		// Note: this type is marked as 'beforefieldinit'.
		static LicenseProviderAttribute()
		{
		}

		// Token: 0x04001235 RID: 4661
		public static readonly LicenseProviderAttribute Default;

		// Token: 0x04001236 RID: 4662
		private Type _licenseProviderType;

		// Token: 0x04001237 RID: 4663
		private string _licenseProviderName;
	}
}
