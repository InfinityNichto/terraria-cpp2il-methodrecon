using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A2 RID: 162
	[Preserve]
	public class JsonProperty
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000E770 File Offset: 0x0000C970
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0000E784 File Offset: 0x0000C984
		internal JsonContract PropertyContract
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyContract>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PropertyContract>k__BackingField = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000E798 File Offset: 0x0000C998
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				this._propertyName = value;
				if (!true)
				{
				}
				this._skipPropertyNameEscape = true;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		public Type DeclaringType
		{
			[CompilerGenerated]
			get
			{
				return this.<DeclaringType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DeclaringType>k__BackingField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000E808 File Offset: 0x0000CA08
		public int? Order
		{
			[CompilerGenerated]
			get
			{
				return this.<Order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Order>k__BackingField = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000E81C File Offset: 0x0000CA1C
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000E830 File Offset: 0x0000CA30
		public string UnderlyingName
		{
			[CompilerGenerated]
			get
			{
				return this.<UnderlyingName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UnderlyingName>k__BackingField = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000E844 File Offset: 0x0000CA44
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000E858 File Offset: 0x0000CA58
		public IValueProvider ValueProvider
		{
			[CompilerGenerated]
			get
			{
				return this.<ValueProvider>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ValueProvider>k__BackingField = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0000E86C File Offset: 0x0000CA6C
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0000E880 File Offset: 0x0000CA80
		public IAttributeProvider AttributeProvider
		{
			[CompilerGenerated]
			get
			{
				return this.<AttributeProvider>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AttributeProvider>k__BackingField = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000E894 File Offset: 0x0000CA94
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
		public Type PropertyType
		{
			get
			{
				return this._propertyType;
			}
			set
			{
				Type propertyType = this._propertyType;
				this._propertyType = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		public JsonConverter Converter
		{
			[CompilerGenerated]
			get
			{
				return this.<Converter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Converter>k__BackingField = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000E900 File Offset: 0x0000CB00
		public JsonConverter MemberConverter
		{
			[CompilerGenerated]
			get
			{
				return this.<MemberConverter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MemberConverter>k__BackingField = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000E914 File Offset: 0x0000CB14
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000E928 File Offset: 0x0000CB28
		public bool Ignored
		{
			[CompilerGenerated]
			get
			{
				return this.<Ignored>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000E938 File Offset: 0x0000CB38
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public bool Readable
		{
			[CompilerGenerated]
			get
			{
				return this.<Readable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000E95C File Offset: 0x0000CB5C
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000E970 File Offset: 0x0000CB70
		public bool Writable
		{
			[CompilerGenerated]
			get
			{
				return this.<Writable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000E980 File Offset: 0x0000CB80
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000E994 File Offset: 0x0000CB94
		public bool HasMemberAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.<HasMemberAttribute>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		public object DefaultValue
		{
			get
			{
				if (this._hasExplicitDefaultValue)
				{
					return this._defaultValue;
				}
			}
			set
			{
				this._hasExplicitDefaultValue = true;
				this._defaultValue = value;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
		internal object GetResolvedDefaultValue()
		{
			Type propertyType = this._propertyType;
			if (propertyType != null)
			{
				if (!this._hasExplicitDefaultValue && !this._hasGeneratedDefaultValue)
				{
					object defaultValue = ReflectionUtils.GetDefaultValue(propertyType);
					this._defaultValue = defaultValue;
					this._hasGeneratedDefaultValue = true;
				}
				return this._defaultValue;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0000EA24 File Offset: 0x0000CC24
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x0000EA40 File Offset: 0x0000CC40
		public Required Required
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Required Newtonsoft.Json.Serialization.JsonProperty::get_Required()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Required>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.Required>(JsonProperty::_required, ldloc:JsonProperty(this)))
	stloc:bool(var_1_0D, ldfld:bool(JsonProperty::_hasExplicitDefaultValue, ldloc:JsonProperty(this)))
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
				this._required = 1;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000EA54 File Offset: 0x0000CC54
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public bool? IsReference
		{
			[CompilerGenerated]
			get
			{
				return this.<IsReference>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsReference>k__BackingField = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000EA90 File Offset: 0x0000CC90
		public NullValueHandling? NullValueHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<NullValueHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NullValueHandling>k__BackingField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		public DefaultValueHandling? DefaultValueHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultValueHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultValueHandling>k__BackingField = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0000EACC File Offset: 0x0000CCCC
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<ReferenceLoopHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ReferenceLoopHandling>k__BackingField = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0000EB08 File Offset: 0x0000CD08
		public ObjectCreationHandling? ObjectCreationHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<ObjectCreationHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ObjectCreationHandling>k__BackingField = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x0000EB30 File Offset: 0x0000CD30
		public TypeNameHandling? TypeNameHandling
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeNameHandling>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TypeNameHandling>k__BackingField = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0000EB44 File Offset: 0x0000CD44
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0000EB58 File Offset: 0x0000CD58
		public Predicate<object> ShouldSerialize
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldSerialize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShouldSerialize>k__BackingField = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0000EB80 File Offset: 0x0000CD80
		public Predicate<object> ShouldDeserialize
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldDeserialize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShouldDeserialize>k__BackingField = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0000EB94 File Offset: 0x0000CD94
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		public Predicate<object> GetIsSpecified
		{
			[CompilerGenerated]
			get
			{
				return this.<GetIsSpecified>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<GetIsSpecified>k__BackingField = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public Action<object, object> SetIsSpecified
		{
			[CompilerGenerated]
			get
			{
				return this.<SetIsSpecified>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SetIsSpecified>k__BackingField = value;
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		public override string ToString()
		{
			return this._propertyName;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemConverter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemConverter>k__BackingField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0000EC20 File Offset: 0x0000CE20
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x0000EC34 File Offset: 0x0000CE34
		public bool? ItemIsReference
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemIsReference>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemIsReference>k__BackingField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public TypeNameHandling? ItemTypeNameHandling
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x0000EC58 File Offset: 0x0000CE58
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000EC68 File Offset: 0x0000CE68
		internal void WritePropertyName(JsonWriter writer)
		{
			bool skipPropertyNameEscape = this._skipPropertyNameEscape;
			string propertyName = this._propertyName;
			if (skipPropertyNameEscape)
			{
				return;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000EC88 File Offset: 0x0000CE88
		public JsonProperty()
		{
		}

		// Token: 0x0400028C RID: 652
		internal Required? _required;

		// Token: 0x0400028D RID: 653
		internal bool _hasExplicitDefaultValue;

		// Token: 0x0400028E RID: 654
		private object _defaultValue;

		// Token: 0x0400028F RID: 655
		private bool _hasGeneratedDefaultValue;

		// Token: 0x04000290 RID: 656
		private string _propertyName;

		// Token: 0x04000291 RID: 657
		internal bool _skipPropertyNameEscape;

		// Token: 0x04000292 RID: 658
		private Type _propertyType;

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		private JsonContract <PropertyContract>k__BackingField;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private Type <DeclaringType>k__BackingField;

		// Token: 0x04000295 RID: 661
		[CompilerGenerated]
		private int? <Order>k__BackingField;

		// Token: 0x04000296 RID: 662
		[CompilerGenerated]
		private string <UnderlyingName>k__BackingField;

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		private IValueProvider <ValueProvider>k__BackingField;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		private IAttributeProvider <AttributeProvider>k__BackingField;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		private JsonConverter <Converter>k__BackingField;

		// Token: 0x0400029A RID: 666
		[CompilerGenerated]
		private JsonConverter <MemberConverter>k__BackingField;

		// Token: 0x0400029B RID: 667
		[CompilerGenerated]
		private bool <Ignored>k__BackingField;

		// Token: 0x0400029C RID: 668
		[CompilerGenerated]
		private bool <Readable>k__BackingField;

		// Token: 0x0400029D RID: 669
		[CompilerGenerated]
		private bool <Writable>k__BackingField;

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private bool <HasMemberAttribute>k__BackingField;

		// Token: 0x0400029F RID: 671
		[CompilerGenerated]
		private bool? <IsReference>k__BackingField;

		// Token: 0x040002A0 RID: 672
		[CompilerGenerated]
		private NullValueHandling? <NullValueHandling>k__BackingField;

		// Token: 0x040002A1 RID: 673
		[CompilerGenerated]
		private DefaultValueHandling? <DefaultValueHandling>k__BackingField;

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private ObjectCreationHandling? <ObjectCreationHandling>k__BackingField;

		// Token: 0x040002A4 RID: 676
		[CompilerGenerated]
		private TypeNameHandling? <TypeNameHandling>k__BackingField;

		// Token: 0x040002A5 RID: 677
		[CompilerGenerated]
		private Predicate<object> <ShouldSerialize>k__BackingField;

		// Token: 0x040002A6 RID: 678
		[CompilerGenerated]
		private Predicate<object> <ShouldDeserialize>k__BackingField;

		// Token: 0x040002A7 RID: 679
		[CompilerGenerated]
		private Predicate<object> <GetIsSpecified>k__BackingField;

		// Token: 0x040002A8 RID: 680
		[CompilerGenerated]
		private Action<object, object> <SetIsSpecified>k__BackingField;

		// Token: 0x040002A9 RID: 681
		[CompilerGenerated]
		private JsonConverter <ItemConverter>k__BackingField;

		// Token: 0x040002AA RID: 682
		[CompilerGenerated]
		private bool? <ItemIsReference>k__BackingField;

		// Token: 0x040002AB RID: 683
		[CompilerGenerated]
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField;

		// Token: 0x040002AC RID: 684
		[CompilerGenerated]
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField;
	}
}
