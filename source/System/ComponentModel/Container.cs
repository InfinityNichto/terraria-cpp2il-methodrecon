using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003DC RID: 988
	public class Container : IContainer, IDisposable
	{
		// Token: 0x06001A16 RID: 6678 RVA: 0x0004817C File Offset: 0x0004637C
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000481B0 File Offset: 0x000463B0
		public virtual void Add(IComponent component)
		{
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000481C0 File Offset: 0x000463C0
		public virtual void Add(IComponent component, string name)
		{
			object obj = this.syncObj;
			if (component != null)
			{
				return;
			}
			long num;
			if (num != 0L)
			{
				Monitor.Exit(obj);
			}
			long num2;
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00048278 File Offset: 0x00046478
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0004828C File Offset: 0x0004648C
		protected virtual void Dispose(bool disposing)
		{
			object obj = this.syncObj;
			Monitor.Enter(obj, disposing);
			int num = this.siteCount;
			ISite[] array = this.sites;
			this.siteCount = num;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x000482F4 File Offset: 0x000464F4
		protected virtual object GetService(Type service)
		{
			/*
An exception occurred when decompiling this method (06001A1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.Container::GetService(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:Type(service), ldloc:Type(var_0)))
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0004830C File Offset: 0x0004650C
		public virtual ComponentCollection Components
		{
			get
			{
				object obj = this.syncObj;
				if (this.components == null)
				{
					int num = this.siteCount;
					int num2 = this.siteCount;
					ISite[] array = this.sites;
					if (this.filter != null || this.checkedFilter)
					{
					}
				}
				long num3;
				if (!this.checkedFilter || this.filter == null)
				{
					if (this != null)
					{
					}
					num3 = 0L;
					this.filter = num3;
					if (num3 == 0L)
					{
						goto IL_006D;
					}
				}
				ComponentCollection componentCollection = this.components;
				if (num3 != 0L)
				{
					this.components = num3;
				}
				IL_006D:
				long num4 = 0L;
				if (num3 != 0L)
				{
					Monitor.Exit(obj);
				}
				if (num4 == 0L)
				{
					throw new ArrayTypeMismatchException();
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000483C4 File Offset: 0x000465C4
		public virtual void Remove(IComponent component)
		{
			long num = 0L;
			this.Remove(component, num != 0L);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000483DC File Offset: 0x000465DC
		private void Remove(IComponent component, bool preserveSite)
		{
			object obj = this.syncObj;
			if (component != null)
			{
				return;
			}
			Monitor.Exit(obj);
			long num;
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0004845C File Offset: 0x0004665C
		protected void RemoveWithoutUnsiting(IComponent component)
		{
			this.Remove(component, true);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00048474 File Offset: 0x00046674
		protected virtual void ValidateName(IComponent component, string name)
		{
			int num;
			do
			{
				num = 1;
			}
			while (component == null);
			if (name == null)
			{
				return;
			}
			int num2 = this.siteCount;
			ISite[] array = this.sites;
			if (num == 0)
			{
			}
			ISite[] array2 = this.sites;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000484F4 File Offset: 0x000466F4
		public Container()
		{
		}

		// Token: 0x040012FB RID: 4859
		private ISite[] sites;

		// Token: 0x040012FC RID: 4860
		private int siteCount;

		// Token: 0x040012FD RID: 4861
		private ComponentCollection components;

		// Token: 0x040012FE RID: 4862
		private ContainerFilterService filter;

		// Token: 0x040012FF RID: 4863
		private bool checkedFilter;

		// Token: 0x04001300 RID: 4864
		private object syncObj;

		// Token: 0x020003DD RID: 989
		private class Site : ISite, IServiceProvider
		{
			// Token: 0x06001A23 RID: 6691 RVA: 0x00048508 File Offset: 0x00046708
			internal Site(IComponent component, Container container, string name)
			{
				this.component = component;
				this.container = container;
				this.name = name;
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00048530 File Offset: 0x00046730
			public IComponent Component
			{
				get
				{
					return this.component;
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00048544 File Offset: 0x00046744
			public IContainer Container
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001A25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ComponentModel.IContainer System.ComponentModel.Container/Site::get_Container()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Container(var_0_06, ldfld:Container(Site::container, ldloc:Site(this)))
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

			// Token: 0x06001A26 RID: 6694 RVA: 0x00048558 File Offset: 0x00046758
			public object GetService(Type service)
			{
				/*
An exception occurred when decompiling this method (06001A26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.Container/Site::GetService(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:Type(service), ldloc:Type(var_0)))
	stloc:Container(var_2_11, ldfld:Container(Site::container, ldloc:Site(this)))
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

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00048578 File Offset: 0x00046778
			public bool DesignMode
			{
				get
				{
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00048588 File Offset: 0x00046788
			// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0004859C File Offset: 0x0004679C
			public string Name
			{
				get
				{
					return this.name;
				}
				set
				{
					if (value != null && value != null)
					{
						bool flag = value.Equals(value);
					}
				}
			}

			// Token: 0x04001301 RID: 4865
			private IComponent component;

			// Token: 0x04001302 RID: 4866
			private Container container;

			// Token: 0x04001303 RID: 4867
			private string name;
		}
	}
}
