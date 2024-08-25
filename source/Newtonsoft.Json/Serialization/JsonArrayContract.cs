using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000098 RID: 152
	[Preserve]
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0000D894 File Offset: 0x0000BA94
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		public Type CollectionItemType
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectionItemType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CollectionItemType>k__BackingField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000D8BC File Offset: 0x0000BABC
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		public bool IsMultidimensionalArray
		{
			[CompilerGenerated]
			get
			{
				return this.<IsMultidimensionalArray>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		internal bool IsArray
		{
			[CompilerGenerated]
			get
			{
				return this.<IsArray>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0000D904 File Offset: 0x0000BB04
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0000D918 File Offset: 0x0000BB18
		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldCreateWrapper>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0000D928 File Offset: 0x0000BB28
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x0000D93C File Offset: 0x0000BB3C
		internal bool CanDeserialize
		{
			[CompilerGenerated]
			get
			{
				return this.<CanDeserialize>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0000D94C File Offset: 0x0000BB4C
		internal ObjectConstructor<object> ParameterizedCreator
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000546)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object> Newtonsoft.Json.Serialization.JsonArrayContract::get_ParameterizedCreator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ReflectionDelegateFactory(var_1_0F, callgetter:ReflectionDelegateFactory(JsonTypeReflector::get_ReflectionDelegateFactory))
	stloc:ConstructorInfo(var_2_16, ldfld:ConstructorInfo(JsonArrayContract::_parameterizedConstructor, ldloc:JsonArrayContract(this)))
	stfld:class Newtonsoft.Json.Serialization.ObjectConstructor`1<object>(JsonArrayContract::_parameterizedCreator, ldloc:JsonArrayContract(this), ldloc:ReflectionDelegateFactory[exp:class Newtonsoft.Json.Serialization.ObjectConstructor`1<object>](var_1_0F))
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000D978 File Offset: 0x0000BB78
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0000D98C File Offset: 0x0000BB8C
		public ObjectConstructor<object> OverrideCreator
		{
			get
			{
				return this._overrideCreator;
			}
			set
			{
				this._overrideCreator = value;
				this.<CanDeserialize>k__BackingField = true;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		public bool HasParameterizedCreator
		{
			[CompilerGenerated]
			get
			{
				return this.<HasParameterizedCreator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				return (!this.<HasParameterizedCreator>k__BackingField && this._parameterizedCreator == null) || true;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		public JsonArrayContract(Type underlyingType)
			: base(underlyingType)
		{
			Type createdType = this._createdType;
			int num = 2;
			this.ContractType = (JsonContractType)num;
			bool isArray = createdType.IsArray;
			this.<IsArray>k__BackingField = num != 0;
			Type <UnderlyingType>k__BackingField = this.<UnderlyingType>k__BackingField;
			if (num == 0)
			{
			}
			Type collectionItemType = ReflectionUtils.GetCollectionItemType(<UnderlyingType>k__BackingField);
			int num2 = 1;
			this.CollectionItemType = collectionItemType;
			this.IsReadOnlyOrFixedSize = num2 != 0;
			if (num2 == 0)
			{
			}
			Type type = this.<CollectionItemType>k__BackingField;
			if (type == null || type != null)
			{
				bool flag = this.<IsArray>k__BackingField;
				Type type2;
				this._genericCollectionDefinitionType = type2;
				if (flag)
				{
					Type <UnderlyingType>k__BackingField2 = this.<UnderlyingType>k__BackingField;
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000DC30 File Offset: 0x0000BE30
		internal IWrappedCollection CreateWrapper(object list)
		{
			if (this._genericWrapperCreator == null)
			{
				Type type = this.<CollectionItemType>k__BackingField;
				if (type != null && type == null)
				{
					goto IL_0077;
				}
				Type type2;
				this._genericWrapperType = type2;
				Type type3;
				bool flag = ReflectionUtils.InheritsGenericDefinition(this._genericCollectionDefinitionType, type3);
				Type genericCollectionDefinitionType = this._genericCollectionDefinitionType;
				Type genericCollectionDefinitionType2 = this._genericCollectionDefinitionType;
				Type type4 = this.<CollectionItemType>k__BackingField;
				if (type4 != null && type4 == null)
				{
					goto IL_0077;
				}
				Type genericWrapperType = this._genericWrapperType;
				Type type5;
				if (type5 != null && type5 == null)
				{
					goto IL_0077;
				}
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				this._genericWrapperCreator = reflectionDelegateFactory;
			}
			if ((list == null || list != null) && list != null && list == null)
			{
				throw new InvalidCastException();
			}
			IL_0077:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		internal IList CreateTemporaryCollection()
		{
			if (this._genericTemporaryCollectionCreator == null)
			{
				if (this.<IsMultidimensionalArray>k__BackingField)
				{
				}
				Type type = this.<CollectionItemType>k__BackingField;
				while (type == null)
				{
				}
				if (type != null && type == null)
				{
					throw new ArrayTypeMismatchException();
				}
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				this._genericTemporaryCollectionCreator = reflectionDelegateFactory;
			}
			throw new InvalidCastException();
		}

		// Token: 0x04000251 RID: 593
		[CompilerGenerated]
		private Type <CollectionItemType>k__BackingField;

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		private bool <IsMultidimensionalArray>k__BackingField;

		// Token: 0x04000253 RID: 595
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000254 RID: 596
		private Type _genericWrapperType;

		// Token: 0x04000255 RID: 597
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000256 RID: 598
		private Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x04000257 RID: 599
		[CompilerGenerated]
		private bool <IsArray>k__BackingField;

		// Token: 0x04000258 RID: 600
		[CompilerGenerated]
		private bool <ShouldCreateWrapper>k__BackingField;

		// Token: 0x04000259 RID: 601
		[CompilerGenerated]
		private bool <CanDeserialize>k__BackingField;

		// Token: 0x0400025A RID: 602
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400025B RID: 603
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400025C RID: 604
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400025D RID: 605
		[CompilerGenerated]
		private bool <HasParameterizedCreator>k__BackingField;
	}
}
