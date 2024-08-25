using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000377 RID: 887
	internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06001740 RID: 5952 RVA: 0x00043250 File Offset: 0x00041450
		public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes)
			: base(extenderInfo, attributes)
		{
			ExtenderProvidedPropertyAttribute extenderProvidedPropertyAttribute = ExtenderProvidedPropertyAttribute.Create(extenderInfo, receiverType, provider);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00043280 File Offset: 0x00041480
		public ExtendedPropertyDescriptor(PropertyDescriptor extender, Attribute[] attributes)
			: base(extender, attributes)
		{
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00043298 File Offset: 0x00041498
		public override bool CanResetValue(object comp)
		{
			ReflectPropertyDescriptor extenderInfo = this._extenderInfo;
			IExtenderProvider provider = this._provider;
			return extenderInfo.ExtenderCanResetValue(provider, comp);
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000432BC File Offset: 0x000414BC
		public override Type ComponentType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001743)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.ComponentModel.ExtendedPropertyDescriptor::get_ComponentType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ReflectPropertyDescriptor(var_0_06, ldfld:ReflectPropertyDescriptor(ExtendedPropertyDescriptor::_extenderInfo, ldloc:ExtendedPropertyDescriptor(this)))
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsReadOnly
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000432D0 File Offset: 0x000414D0
		public override Type PropertyType
		{
			get
			{
				ReflectPropertyDescriptor extenderInfo = this._extenderInfo;
				IExtenderProvider provider = this._provider;
				return extenderInfo.ExtenderGetType(provider);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000432F4 File Offset: 0x000414F4
		public override string DisplayName
		{
			get
			{
				string displayName = base.DisplayName;
				if (this != null)
				{
				}
				IExtenderProvider provider = this._provider;
				ISite site;
				if (site != null && site != null)
				{
					string text;
					return text;
				}
				return displayName;
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0004331C File Offset: 0x0004151C
		public override object GetValue(object comp)
		{
			ReflectPropertyDescriptor extenderInfo = this._extenderInfo;
			IExtenderProvider provider = this._provider;
			return extenderInfo.ExtenderGetValue(provider, comp);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00043340 File Offset: 0x00041540
		public override void ResetValue(object comp)
		{
			IExtenderProvider provider = this._provider;
			this._extenderInfo.ExtenderResetValue(provider, comp, this);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00043364 File Offset: 0x00041564
		public override void SetValue(object component, object value)
		{
			IExtenderProvider provider = this._provider;
			this._extenderInfo.ExtenderSetValue(provider, component, value, this);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00043388 File Offset: 0x00041588
		public override bool ShouldSerializeValue(object comp)
		{
			ReflectPropertyDescriptor extenderInfo = this._extenderInfo;
			IExtenderProvider provider = this._provider;
			return extenderInfo.ExtenderShouldSerializeValue(provider, comp);
		}

		// Token: 0x04001226 RID: 4646
		private readonly ReflectPropertyDescriptor _extenderInfo;

		// Token: 0x04001227 RID: 4647
		private readonly IExtenderProvider _provider;
	}
}
