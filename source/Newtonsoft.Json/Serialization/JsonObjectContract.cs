using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A5 RID: 165
	[Preserve]
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0000EE1C File Offset: 0x0000D01C
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0000EE30 File Offset: 0x0000D030
		public MemberSerialization MemberSerialization
		{
			[CompilerGenerated]
			get
			{
				return this.<MemberSerialization>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MemberSerialization>k__BackingField = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0000EE44 File Offset: 0x0000D044
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0000EE58 File Offset: 0x0000D058
		public Required? ItemRequired
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemRequired>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemRequired>k__BackingField = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public JsonPropertyCollection Properties
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
				this.<Properties>k__BackingField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Obsolete("ConstructorParameters is obsolete. Use CreatorParameters instead.")]
		public JsonPropertyCollection ConstructorParameters
		{
			get
			{
				return this.CreatorParameters;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000EE94 File Offset: 0x0000D094
		public JsonPropertyCollection CreatorParameters
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonPropertyCollection Newtonsoft.Json.Serialization.JsonObjectContract::get_CreatorParameters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0E, ldfld:Type(JsonContract::<UnderlyingType>k__BackingField, ldloc:JsonObjectContract[exp:JsonContract](this)))
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		[Obsolete("OverrideConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo OverrideConstructor
		{
			get
			{
				return this._overrideConstructor;
			}
			set
			{
				this._overrideConstructor = value;
				if (value != null)
				{
					ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
					return;
				}
				long num = 0L;
				this._overrideCreator = num;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0000EEF0 File Offset: 0x0000D0F0
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0000EF04 File Offset: 0x0000D104
		[Obsolete("ParametrizedConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo ParametrizedConstructor
		{
			get
			{
				return this._parametrizedConstructor;
			}
			set
			{
				this._parametrizedConstructor = value;
				if (value != null)
				{
					ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
					return;
				}
				long num = 0L;
				this._parameterizedCreator = num;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0000EF30 File Offset: 0x0000D130
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0000EF44 File Offset: 0x0000D144
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000EF58 File Offset: 0x0000D158
		internal ObjectConstructor<object> ParameterizedCreator
		{
			get
			{
				return this._parameterizedCreator;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0000EF6C File Offset: 0x0000D16C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0000EF80 File Offset: 0x0000D180
		public ExtensionDataSetter ExtensionDataSetter
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtensionDataSetter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ExtensionDataSetter>k__BackingField = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0000EF94 File Offset: 0x0000D194
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		public ExtensionDataGetter ExtensionDataGetter
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtensionDataGetter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ExtensionDataGetter>k__BackingField = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public Type ExtensionDataValueType
		{
			get
			{
				return this._extensionDataValueType;
			}
			set
			{
				this._extensionDataValueType = value;
				if (value != null)
				{
					return;
				}
				long num = 0L;
				this.ExtensionDataIsJToken = num != 0L;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0000212A File Offset: 0x0000032A
		internal bool HasRequiredOrDefaultValueProperties
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		public JsonObjectContract(Type underlyingType)
			: base(underlyingType)
		{
			this.ContractType = JsonContractType.Object;
			Type <UnderlyingType>k__BackingField = this.<UnderlyingType>k__BackingField;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000F018 File Offset: 0x0000D218
		internal object GetUninitializedObject()
		{
			if (!true)
			{
			}
			bool fullyTrusted = JsonTypeReflector.FullyTrusted;
			Type nonNullableUnderlyingType = this.NonNullableUnderlyingType;
			return FormatterServices.GetUninitializedObject(nonNullableUnderlyingType);
		}

		// Token: 0x040002AF RID: 687
		[CompilerGenerated]
		private MemberSerialization <MemberSerialization>k__BackingField;

		// Token: 0x040002B0 RID: 688
		[CompilerGenerated]
		private Required? <ItemRequired>k__BackingField;

		// Token: 0x040002B1 RID: 689
		[CompilerGenerated]
		private JsonPropertyCollection <Properties>k__BackingField;

		// Token: 0x040002B2 RID: 690
		[CompilerGenerated]
		private ExtensionDataSetter <ExtensionDataSetter>k__BackingField;

		// Token: 0x040002B3 RID: 691
		[CompilerGenerated]
		private ExtensionDataGetter <ExtensionDataGetter>k__BackingField;

		// Token: 0x040002B4 RID: 692
		internal bool ExtensionDataIsJToken;

		// Token: 0x040002B5 RID: 693
		private bool? _hasRequiredOrDefaultValueProperties;

		// Token: 0x040002B6 RID: 694
		private ConstructorInfo _parametrizedConstructor;

		// Token: 0x040002B7 RID: 695
		private ConstructorInfo _overrideConstructor;

		// Token: 0x040002B8 RID: 696
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x040002B9 RID: 697
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x040002BA RID: 698
		private JsonPropertyCollection _creatorParameters;

		// Token: 0x040002BB RID: 699
		private Type _extensionDataValueType;
	}
}
