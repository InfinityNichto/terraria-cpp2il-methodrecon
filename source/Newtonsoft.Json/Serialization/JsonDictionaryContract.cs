using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A1 RID: 161
	[Preserve]
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0000E474 File Offset: 0x0000C674
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0000E488 File Offset: 0x0000C688
		[Obsolete("PropertyNameResolver is obsolete. Use DictionaryKeyResolver instead.")]
		public Func<string, string> PropertyNameResolver
		{
			get
			{
				return this.<DictionaryKeyResolver>k__BackingField;
			}
			set
			{
				this.<DictionaryKeyResolver>k__BackingField = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000E49C File Offset: 0x0000C69C
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public Func<string, string> DictionaryKeyResolver
		{
			[CompilerGenerated]
			get
			{
				return this.<DictionaryKeyResolver>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DictionaryKeyResolver>k__BackingField = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		public Type DictionaryKeyType
		{
			[CompilerGenerated]
			get
			{
				return this.<DictionaryKeyType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DictionaryKeyType>k__BackingField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0000E500 File Offset: 0x0000C700
		public Type DictionaryValueType
		{
			[CompilerGenerated]
			get
			{
				return this.<DictionaryValueType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<DictionaryValueType>k__BackingField = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000E514 File Offset: 0x0000C714
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000E528 File Offset: 0x0000C728
		internal JsonContract KeyContract
		{
			[CompilerGenerated]
			get
			{
				return this.<KeyContract>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<KeyContract>k__BackingField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000E53C File Offset: 0x0000C73C
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0000E550 File Offset: 0x0000C750
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000E560 File Offset: 0x0000C760
		internal ObjectConstructor<object> ParameterizedCreator
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000594)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object> Newtonsoft.Json.Serialization.JsonDictionaryContract::get_ParameterizedCreator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ReflectionDelegateFactory(var_1_0F, callgetter:ReflectionDelegateFactory(JsonTypeReflector::get_ReflectionDelegateFactory))
	stloc:ConstructorInfo(var_2_16, ldfld:ConstructorInfo(JsonDictionaryContract::_parameterizedConstructor, ldloc:JsonDictionaryContract(this)))
	stfld:class Newtonsoft.Json.Serialization.ObjectConstructor`1<object>(JsonDictionaryContract::_parameterizedCreator, ldloc:JsonDictionaryContract(this), ldloc:ReflectionDelegateFactory[exp:class Newtonsoft.Json.Serialization.ObjectConstructor`1<object>](var_1_0F))
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000E58C File Offset: 0x0000C78C
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		public ObjectConstructor<object> OverrideCreator
		{
			get
			{
				return this._overrideCreator;
			}
			set
			{
				this._overrideCreator = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				return (!this.<HasParameterizedCreator>k__BackingField && this._parameterizedCreator == null) || true;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		public JsonDictionaryContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 5;
			this.ContractType = (JsonContractType)num;
			Type genericCollectionDefinitionType = this._genericCollectionDefinitionType;
			if (genericCollectionDefinitionType == null)
			{
			}
			if (genericCollectionDefinitionType == null)
			{
			}
			Type genericCollectionDefinitionType2 = this._genericCollectionDefinitionType;
			Type genericCollectionDefinitionType3 = this._genericCollectionDefinitionType;
			Type type;
			bool flag = ReflectionUtils.IsGenericDefinition(this.<UnderlyingType>k__BackingField, type);
			if ((underlyingType == null || underlyingType != null) && (underlyingType == null || underlyingType != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			if (this._genericWrapperCreator == null)
			{
				Type type = this.<DictionaryKeyType>k__BackingField;
				if ((type != null && type == null) || this.<DictionaryValueType>k__BackingField == null)
				{
					goto IL_004F;
				}
				Type type2;
				this._genericWrapperType = type2;
				Type genericCollectionDefinitionType = this._genericCollectionDefinitionType;
				if (genericCollectionDefinitionType != null && genericCollectionDefinitionType == null)
				{
					goto IL_004F;
				}
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				this._genericWrapperCreator = reflectionDelegateFactory;
			}
			if ((dictionary == null || dictionary != null) && dictionary != null && dictionary == null)
			{
				throw new InvalidCastException();
			}
			IL_004F:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000E720 File Offset: 0x0000C920
		internal IDictionary CreateTemporaryDictionary()
		{
			Type type;
			Type type2;
			if (this._genericTemporaryDictionaryCreator == null && ((this.<DictionaryKeyType>k__BackingField == null && type == null) || type != null) && ((this.<DictionaryValueType>k__BackingField == null && type2 == null) || type2 != null))
			{
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				this._genericTemporaryDictionaryCreator = reflectionDelegateFactory;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400027F RID: 639
		[CompilerGenerated]
		private Func<string, string> <DictionaryKeyResolver>k__BackingField;

		// Token: 0x04000280 RID: 640
		[CompilerGenerated]
		private Type <DictionaryKeyType>k__BackingField;

		// Token: 0x04000281 RID: 641
		[CompilerGenerated]
		private Type <DictionaryValueType>k__BackingField;

		// Token: 0x04000282 RID: 642
		[CompilerGenerated]
		private JsonContract <KeyContract>k__BackingField;

		// Token: 0x04000283 RID: 643
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000284 RID: 644
		private Type _genericWrapperType;

		// Token: 0x04000285 RID: 645
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000286 RID: 646
		private Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x04000287 RID: 647
		[CompilerGenerated]
		private bool <ShouldCreateWrapper>k__BackingField;

		// Token: 0x04000288 RID: 648
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x04000289 RID: 649
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400028A RID: 650
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400028B RID: 651
		[CompilerGenerated]
		private bool <HasParameterizedCreator>k__BackingField;
	}
}
