using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x0200015D RID: 349
	internal abstract class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0001EA00 File Offset: 0x0001CC00
		protected XmlBaseConverter(XmlSchemaType schemaType)
		{
			do
			{
				XmlSchemaDatatype datatype = schemaType.datatype;
			}
			while (schemaType != null && schemaType.baseSchemaType != null);
			XmlSchemaSimpleType xmlSchemaSimpleType;
			this.schemaType = xmlSchemaSimpleType;
			XmlTypeCode xmlTypeCode = xmlSchemaSimpleType.TypeCode;
			this.typeCode = xmlTypeCode;
			XmlSchemaDatatype datatype2 = xmlSchemaSimpleType.datatype;
			this.clrTypeDefault = datatype2;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001EA44 File Offset: 0x0001CC44
		protected XmlBaseConverter(XmlTypeCode typeCode)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001EA7C File Offset: 0x0001CC7C
		protected XmlBaseConverter(XmlBaseConverter converterAtomic)
		{
			XmlSchemaType xmlSchemaType = converterAtomic.schemaType;
			long num = 0L;
			this.schemaType = xmlSchemaType;
			XmlTypeCode xmlTypeCode = converterAtomic.typeCode;
			this.typeCode = xmlTypeCode;
			Type type = Array.CreateInstance(converterAtomic.clrTypeDefault, (int)num).GetType();
			this.clrTypeDefault = type;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
		protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
		{
			XmlSchemaType xmlSchemaType = converterAtomic.schemaType;
			this.schemaType = xmlSchemaType;
			XmlTypeCode xmlTypeCode = converterAtomic.typeCode;
			this.clrTypeDefault = clrTypeDefault;
			this.typeCode = xmlTypeCode;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public override bool ToBoolean(DateTime value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001EB14 File Offset: 0x0001CD14
		public override bool ToBoolean(double value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001EB28 File Offset: 0x0001CD28
		public override bool ToBoolean(int value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001EB3C File Offset: 0x0001CD3C
		public override bool ToBoolean(long value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001EB50 File Offset: 0x0001CD50
		public override bool ToBoolean(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001EB68 File Offset: 0x0001CD68
		public override bool ToBoolean(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001EB80 File Offset: 0x0001CD80
		public override DateTime ToDateTime(bool value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0001EB94 File Offset: 0x0001CD94
		public override DateTime ToDateTime(DateTimeOffset value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
		public override DateTime ToDateTime(double value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001EBBC File Offset: 0x0001CDBC
		public override DateTime ToDateTime(int value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		public override DateTime ToDateTime(long value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
		public override DateTime ToDateTime(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		public override DateTime ToDateTime(object value)
		{
			return 1;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001EC28 File Offset: 0x0001CE28
		public override DateTimeOffset ToDateTimeOffset(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001EC40 File Offset: 0x0001CE40
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public override decimal ToDecimal(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001EC70 File Offset: 0x0001CE70
		public override decimal ToDecimal(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001EC88 File Offset: 0x0001CE88
		public override double ToDouble(bool value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public override double ToDouble(DateTime value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
		public override double ToDouble(int value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		public override double ToDouble(long value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		public override double ToDouble(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		public override double ToDouble(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0001ED08 File Offset: 0x0001CF08
		public override int ToInt32(bool value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001ED1C File Offset: 0x0001CF1C
		public override int ToInt32(DateTime value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001ED30 File Offset: 0x0001CF30
		public override int ToInt32(double value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001ED44 File Offset: 0x0001CF44
		public override int ToInt32(long value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001ED58 File Offset: 0x0001CF58
		public override int ToInt32(string value)
		{
			if ("Invalid File" == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public override int ToInt32(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001ED8C File Offset: 0x0001CF8C
		public override long ToInt64(bool value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		public override long ToInt64(DateTime value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
		public override long ToInt64(double value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		public override long ToInt64(int value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001EDDC File Offset: 0x0001CFDC
		public override long ToInt64(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
		public override long ToInt64(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001EE0C File Offset: 0x0001D00C
		public override float ToSingle(double value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001EE20 File Offset: 0x0001D020
		public override float ToSingle(string value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001EE38 File Offset: 0x0001D038
		public override float ToSingle(object value)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001EE50 File Offset: 0x0001D050
		public override string ToString(bool value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001EE68 File Offset: 0x0001D068
		public override string ToString(DateTime value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001EE80 File Offset: 0x0001D080
		public override string ToString(DateTimeOffset value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001EE98 File Offset: 0x0001D098
		public override string ToString(decimal value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		public override string ToString(double value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		public override string ToString(int value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		public override string ToString(long value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
		public override string ToString(float value)
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001EF10 File Offset: 0x0001D110
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			if (!true)
			{
			}
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string ToString(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(bool value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(DateTime value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(decimal value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(double value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(int value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(long value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00003FFD File Offset: 0x000021FD
		public override object ChangeType(object value, Type destinationType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0001EF28 File Offset: 0x0001D128
		protected XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001EF3C File Offset: 0x0001D13C
		protected XmlTypeCode TypeCode
		{
			get
			{
				return this.typeCode;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0001EF50 File Offset: 0x0001D150
		protected string XmlTypeName
		{
			get
			{
				int num = 1;
				XmlSchemaType xmlSchemaType = this.schemaType;
				XmlQualifiedName qname;
				string text;
				if (xmlSchemaType != null)
				{
					bool isEmpty = xmlSchemaType.qname.IsEmpty;
					qname = xmlSchemaType.baseSchemaType.qname;
					if (num == 0)
					{
					}
					text = XmlBaseConverter.QNameToString(qname);
					return text;
				}
				string ns = qname.ns;
				return text;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		protected Type DefaultClrType
		{
			get
			{
				return this.clrTypeDefault;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
		protected static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
		protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			if (!true)
			{
			}
			bool flag = sourceType == destinationType;
			string xmlTypeName = this.XmlTypeName;
			if ((xmlTypeName == null || xmlTypeName != null) && (sourceType == null || sourceType != null))
			{
				string xmlTypeName2 = this.XmlTypeName;
				if ((xmlTypeName2 != null && xmlTypeName2 == null) || (sourceType != null && sourceType == null) || xmlTypeName == null || xmlTypeName != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0001F01C File Offset: 0x0001D21C
		protected static string QNameToString(XmlQualifiedName name)
		{
			if (true)
			{
				bool flag = "http://www.w3.org/2001/XMLSchema" == "http://www.w3.org/2001/XMLSchema";
			}
			return "xdt:" + "http://www.w3.org/2003/11/xpath-datatypes";
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001F050 File Offset: 0x0001D250
		protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			/*
An exception occurred when decompiling this method (06000B9F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Schema.XmlBaseConverter::ChangeListType(System.Object,System.Type,System.Xml.IXmlNamespaceResolver)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:object(value)))
	stloc:Exception(var_1_0F, call:Exception(XmlBaseConverter::CreateInvalidClrMappingException, ldloc:XmlBaseConverter(this), ldloc:Type(var_0_06), ldloc:Type(destinationType)))
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

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001F06C File Offset: 0x0001D26C
		protected static byte[] StringToBase64Binary(string value)
		{
			if (!true)
			{
			}
			string text;
			return Convert.FromBase64String(text);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001F084 File Offset: 0x0001D284
		protected static DateTime StringToDate(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001F098 File Offset: 0x0001D298
		protected static DateTime StringToDateTime(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		protected static TimeSpan StringToDayTimeDuration(string value)
		{
			TimeSpan timeSpan;
			return timeSpan;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001F0BC File Offset: 0x0001D2BC
		protected static TimeSpan StringToDuration(string value)
		{
			TimeSpan timeSpan;
			return timeSpan;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001F0CC File Offset: 0x0001D2CC
		protected static DateTime StringToGDay(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		protected static DateTime StringToGMonth(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		protected static DateTime StringToGMonthDay(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0001F108 File Offset: 0x0001D308
		protected static DateTime StringToGYear(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001F11C File Offset: 0x0001D31C
		protected static DateTime StringToGYearMonth(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0001F130 File Offset: 0x0001D330
		protected static DateTimeOffset StringToDateOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001F144 File Offset: 0x0001D344
		protected static DateTimeOffset StringToDateTimeOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0001F158 File Offset: 0x0001D358
		protected static DateTimeOffset StringToGDayOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0001F16C File Offset: 0x0001D36C
		protected static DateTimeOffset StringToGMonthOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0001F180 File Offset: 0x0001D380
		protected static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001F194 File Offset: 0x0001D394
		protected static DateTimeOffset StringToGYearOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		protected static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		protected static byte[] StringToHexBinary(string value)
		{
			if (!true)
			{
			}
			long num = 0L;
			string text;
			return XmlConvert.FromBinHexString(text, num != 0L);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null || value != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001F204 File Offset: 0x0001D404
		protected static DateTime StringToTime(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001F218 File Offset: 0x0001D418
		protected static DateTimeOffset StringToTimeOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0001F22C File Offset: 0x0001D42C
		protected static TimeSpan StringToYearMonthDuration(string value)
		{
			TimeSpan timeSpan;
			return timeSpan;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0001F23C File Offset: 0x0001D43C
		protected static string AnyUriToString(Uri value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0001F24C File Offset: 0x0001D44C
		protected static string Base64BinaryToString(byte[] value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0001F260 File Offset: 0x0001D460
		protected static string DateToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0001F270 File Offset: 0x0001D470
		protected static string DateTimeToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0001F280 File Offset: 0x0001D480
		protected static string DayTimeDurationToString(TimeSpan value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0001F290 File Offset: 0x0001D490
		protected static string DurationToString(TimeSpan value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001F2A0 File Offset: 0x0001D4A0
		protected static string GDayToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0001F2B0 File Offset: 0x0001D4B0
		protected static string GMonthToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		protected static string GMonthDayToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0001F2D0 File Offset: 0x0001D4D0
		protected static string GYearToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		protected static string GYearMonthToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		protected static string DateOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001F300 File Offset: 0x0001D500
		protected static string DateTimeOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0001F310 File Offset: 0x0001D510
		protected static string GDayOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0001F320 File Offset: 0x0001D520
		protected static string GMonthOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0001F330 File Offset: 0x0001D530
		protected static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001F340 File Offset: 0x0001D540
		protected static string GYearOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0001F350 File Offset: 0x0001D550
		protected static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0001F360 File Offset: 0x0001D560
		protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			if (qname != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0001F394 File Offset: 0x0001D594
		protected static string TimeToString(DateTime value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		protected static string TimeOffsetToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
		protected static string YearMonthDurationToString(TimeSpan value)
		{
			string text;
			return text;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
		internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			DateTime localDateTime = value.LocalDateTime;
			DateTime dateTime;
			return dateTime;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0001F3DC File Offset: 0x0001D5DC
		internal static int DecimalToInt32(decimal value)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0001F400 File Offset: 0x0001D600
		protected static long DecimalToInt64(decimal value)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num;
			return num;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0001F424 File Offset: 0x0001D624
		protected static ulong DecimalToUInt64(decimal value)
		{
			if ("uriScheme" == null)
			{
			}
			if ("uriScheme" == null)
			{
			}
			ulong num;
			return num;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0001F44C File Offset: 0x0001D64C
		protected static byte Int32ToByte(int value)
		{
			string text = XmlConvert.ToString(42191000);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0001F470 File Offset: 0x0001D670
		protected static short Int32ToInt16(int value)
		{
			string text = XmlConvert.ToString(42191000);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0001F494 File Offset: 0x0001D694
		protected static sbyte Int32ToSByte(int value)
		{
			string text = XmlConvert.ToString(42191000);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		protected static ushort Int32ToUInt16(int value)
		{
			string text = XmlConvert.ToString(42191000);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		protected static int Int64ToInt32(long value)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		protected static uint Int64ToUInt32(long value)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0001F50C File Offset: 0x0001D70C
		protected static DateTime UntypedAtomicToDateTime(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0001F520 File Offset: 0x0001D720
		protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0001F534 File Offset: 0x0001D734
		// Note: this type is marked as 'beforefieldinit'.
		static XmlBaseConverter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000608 RID: 1544
		private XmlSchemaType schemaType;

		// Token: 0x04000609 RID: 1545
		private XmlTypeCode typeCode;

		// Token: 0x0400060A RID: 1546
		private Type clrTypeDefault;

		// Token: 0x0400060B RID: 1547
		protected static readonly Type ICollectionType;

		// Token: 0x0400060C RID: 1548
		protected static readonly Type IEnumerableType;

		// Token: 0x0400060D RID: 1549
		protected static readonly Type IListType;

		// Token: 0x0400060E RID: 1550
		protected static readonly Type ObjectArrayType;

		// Token: 0x0400060F RID: 1551
		protected static readonly Type StringArrayType;

		// Token: 0x04000610 RID: 1552
		protected static readonly Type XmlAtomicValueArrayType;

		// Token: 0x04000611 RID: 1553
		protected static readonly Type DecimalType;

		// Token: 0x04000612 RID: 1554
		protected static readonly Type Int32Type;

		// Token: 0x04000613 RID: 1555
		protected static readonly Type Int64Type;

		// Token: 0x04000614 RID: 1556
		protected static readonly Type StringType;

		// Token: 0x04000615 RID: 1557
		protected static readonly Type XmlAtomicValueType;

		// Token: 0x04000616 RID: 1558
		protected static readonly Type ObjectType;

		// Token: 0x04000617 RID: 1559
		protected static readonly Type ByteType;

		// Token: 0x04000618 RID: 1560
		protected static readonly Type Int16Type;

		// Token: 0x04000619 RID: 1561
		protected static readonly Type SByteType;

		// Token: 0x0400061A RID: 1562
		protected static readonly Type UInt16Type;

		// Token: 0x0400061B RID: 1563
		protected static readonly Type UInt32Type;

		// Token: 0x0400061C RID: 1564
		protected static readonly Type UInt64Type;

		// Token: 0x0400061D RID: 1565
		protected static readonly Type XPathItemType;

		// Token: 0x0400061E RID: 1566
		protected static readonly Type DoubleType;

		// Token: 0x0400061F RID: 1567
		protected static readonly Type SingleType;

		// Token: 0x04000620 RID: 1568
		protected static readonly Type DateTimeType;

		// Token: 0x04000621 RID: 1569
		protected static readonly Type DateTimeOffsetType;

		// Token: 0x04000622 RID: 1570
		protected static readonly Type BooleanType;

		// Token: 0x04000623 RID: 1571
		protected static readonly Type ByteArrayType;

		// Token: 0x04000624 RID: 1572
		protected static readonly Type XmlQualifiedNameType;

		// Token: 0x04000625 RID: 1573
		protected static readonly Type UriType;

		// Token: 0x04000626 RID: 1574
		protected static readonly Type TimeSpanType;

		// Token: 0x04000627 RID: 1575
		protected static readonly Type XPathNavigatorType;
	}
}
