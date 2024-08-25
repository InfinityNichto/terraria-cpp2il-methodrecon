using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003A8 RID: 936
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x00045858 File Offset: 0x00043A58
		public NestedContainer(IComponent owner)
		{
			do
			{
				base..ctor();
			}
			while (owner == null);
			this.Owner = owner;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00045878 File Offset: 0x00043A78
		public IComponent Owner
		{
			[CompilerGenerated]
			get
			{
				return this.<Owner>k__BackingField;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0004588C File Offset: 0x00043A8C
		protected virtual string OwnerName
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.ComponentModel.NestedContainer::get_OwnerName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:IComponent(var_3_24, ldfld:IComponent(NestedContainer::<Owner>k__BackingField, ldloc:NestedContainer(this)))
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

		// Token: 0x060018AE RID: 6318 RVA: 0x000458C0 File Offset: 0x00043AC0
		protected override ISite CreateSite(IComponent component, string name)
		{
			/*
An exception occurred when decompiling this method (060018AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.ISite System.ComponentModel.NestedContainer::CreateSite(System.ComponentModel.IComponent,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:IComponent[exp:bool](component)))
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

		// Token: 0x060018AF RID: 6319 RVA: 0x000458D0 File Offset: 0x00043AD0
		protected override void Dispose(bool disposing)
		{
			IComponent component = this.<Owner>k__BackingField;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000458EC File Offset: 0x00043AEC
		protected override object GetService(Type service)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = service == type;
			return base.GetService(service);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0004590C File Offset: 0x00043B0C
		private void OnOwnerDisposed(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04001296 RID: 4758
		[CompilerGenerated]
		private readonly IComponent <Owner>k__BackingField;

		// Token: 0x020003A9 RID: 937
		private class Site : INestedSite, ISite, IServiceProvider
		{
			// Token: 0x060018B2 RID: 6322 RVA: 0x00045920 File Offset: 0x00043B20
			internal Site(IComponent component, NestedContainer container, string name)
			{
				this._name = name;
				this.Component = component;
				this.Container = container;
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00045948 File Offset: 0x00043B48
			public IComponent Component
			{
				[CompilerGenerated]
				get
				{
					return this.<Component>k__BackingField;
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0004595C File Offset: 0x00043B5C
			public IContainer Container
			{
				[CompilerGenerated]
				get
				{
					return this.<Container>k__BackingField;
				}
			}

			// Token: 0x060018B5 RID: 6325 RVA: 0x00045970 File Offset: 0x00043B70
			public object GetService(Type service)
			{
				if (!true)
				{
				}
				Type type;
				bool flag = service == type;
				IContainer container = this.<Container>k__BackingField;
				throw new InvalidCastException();
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00045994 File Offset: 0x00043B94
			public bool DesignMode
			{
				get
				{
					if (this.<Container>k__BackingField != null)
					{
					}
					if (this == null || this != null)
					{
					}
					long value = 0.m_value;
					throw new InvalidCastException();
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x060018B7 RID: 6327 RVA: 0x000459BC File Offset: 0x00043BBC
			public string FullName
			{
				get
				{
					if (this._name != null)
					{
						IContainer container = this.<Container>k__BackingField;
						string name = this._name;
						if (container != null)
						{
							CultureInfo invariantCulture = CultureInfo.InvariantCulture;
							string text;
							return text;
						}
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x060018B8 RID: 6328 RVA: 0x000459F8 File Offset: 0x00043BF8
			// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00045A0C File Offset: 0x00043C0C
			public string Name
			{
				get
				{
					return this._name;
				}
				set
				{
					if (value != null)
					{
						string name = this._name;
						if (name != null)
						{
							bool flag = value.Equals(name);
						}
					}
					IContainer container = this.<Container>k__BackingField;
					IComponent component = this.<Component>k__BackingField;
					this._name = value;
				}
			}

			// Token: 0x04001297 RID: 4759
			private string _name;

			// Token: 0x04001298 RID: 4760
			[CompilerGenerated]
			private readonly IComponent <Component>k__BackingField;

			// Token: 0x04001299 RID: 4761
			[CompilerGenerated]
			private readonly IContainer <Container>k__BackingField;
		}
	}
}
