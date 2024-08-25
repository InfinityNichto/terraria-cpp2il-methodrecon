using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011D RID: 285
	[Preserve]
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0001A5FC File Offset: 0x000187FC
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0001A610 File Offset: 0x00018810
		public string DeserializeRootElementName
		{
			[CompilerGenerated]
			get
			{
				return this.<DeserializeRootElementName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DeserializeRootElementName>k__BackingField = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0001A624 File Offset: 0x00018824
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0001A638 File Offset: 0x00018838
		public bool WriteArrayAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.<WriteArrayAttribute>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0001A648 File Offset: 0x00018848
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0001A65C File Offset: 0x0001885C
		public bool OmitRootObject
		{
			[CompilerGenerated]
			get
			{
				return this.<OmitRootObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001A66C File Offset: 0x0001886C
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (this.<OmitRootObject>k__BackingField)
			{
				return;
			}
			bool flag = this.<OmitRootObject>k__BackingField;
			if (this.<OmitRootObject>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001A694 File Offset: 0x00018894
		private IXmlNode WrapXml(object value)
		{
			while (value == null)
			{
			}
			IXmlNode xmlNode;
			return xmlNode;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001A6A8 File Offset: 0x000188A8
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0001A70C File Offset: 0x0001890C
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			if (node != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001A720 File Offset: 0x00018920
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return "#significant-whitespace";
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001A73C File Offset: 0x0001893C
		private bool IsArray(IXmlNode node)
		{
			if (node != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001A778 File Offset: 0x00018978
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001A7C8 File Offset: 0x000189C8
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001A99C File Offset: 0x00018B9C
		private static bool AllSameName(IXmlNode node)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001A9CC File Offset: 0x00018BCC
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = string.IsNullOrEmpty(this.<DeserializeRootElementName>k__BackingField);
			string text = this.<DeserializeRootElementName>k__BackingField;
			return "XmlNodeConverter can only convert JSON that begins with an object.";
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001AA04 File Offset: 0x00018C04
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
			bool flag = propertyName == "#text";
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001AA8C File Offset: 0x00018C8C
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
			bool flag = string.IsNullOrEmpty(propertyName);
			Dictionary<string, string> dictionary = this.ReadAttributeElements(reader, manager);
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
			string text = propertyName.Substring(1);
			string prefix2 = MiscellaneousUtils.GetPrefix(text);
			XmlNodeConverter.AddAttribute(reader, document, currentNode, text, manager, prefix2);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001AB50 File Offset: 0x00018D50
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001AB94 File Offset: 0x00018D94
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
			if (!true)
			{
			}
			string text = XmlConvert.EncodeName(attributeName);
			bool flag = string.IsNullOrEmpty(attributePrefix);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001ABCC File Offset: 0x00018DCC
		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			while (reader == null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			long num = Convert.ToInt64(reader, invariantCulture);
			return XmlConvert.ToString(num);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001AC9C File Offset: 0x00018E9C
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
			string prefix = MiscellaneousUtils.GetPrefix(propertyName);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001AD14 File Offset: 0x00018F14
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			/*
An exception occurred when decompiling this method (06000B2A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.String,System.String> Newtonsoft.Json.Converters.XmlNodeConverter::ReadAttributeElements(Newtonsoft.Json.JsonReader,System.Xml.XmlNamespaceManager)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007D:
	stloc:string(var_19_8B, call:string(string::Concat, ldloc:string(var_13), ldstr:string(":"), ldloc:string(var_17_78)))
	stloc:JsonSerializationException(var_21_95, call:JsonSerializationException(JsonSerializationException::Create, ldloc:JsonReader(reader), ldloc:string(var_20)))
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

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
			bool flag = propertyName == "?xml";
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001AE08 File Offset: 0x00019008
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			/*
An exception occurred when decompiling this method (06000B2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Converters.IXmlElement Newtonsoft.Json.Converters.XmlNodeConverter::CreateElement(System.String,Newtonsoft.Json.Converters.IXmlDocument,System.String,System.Xml.XmlNamespaceManager)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_0_09, call:string(XmlConvert::EncodeName, ldloc:string(elementName)))
	stloc:bool(var_1_10, call:bool(string::IsNullOrEmpty, ldloc:string(elementPrefix)))
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

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001AE28 File Offset: 0x00019028
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001AE80 File Offset: 0x00019080
		private bool IsNamespaceAttribute(string attributeName, [Out] string prefix)
		{
			/*
An exception occurred when decompiling this method (06000B2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Converters.XmlNodeConverter::IsNamespaceAttribute(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_06, ldfld:int32(string::_stringLength, ldloc:string(attributeName)))
	stloc:int32(var_3_0A, ldc.i4:int32(5))
	stloc:int64(var_4_0C, ldc.i4:int64(0))
	stloc:char(var_5_15, callgetter:char(string::get_Chars, ldloc:string(attributeName), ldloc:int32(var_3_0A)))
	stloc:int32(var_6_1D, ldfld:int32(string::_stringLength, ldloc:string(attributeName)))
	stloc:int32(var_7_20, ldc.i4:int32(6))
	stloc:string(var_8_2C, call:string(string::Substring, ldloc:string(attributeName), ldloc:int32(var_7_20), ldloc:int64[exp:int32](var_4_0C)))
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

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001AEC0 File Offset: 0x000190C0
		private bool ValueAttributes(List<IXmlNode> c)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001AEEC File Offset: 0x000190EC
		public override bool CanConvert(Type valueType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001AF00 File Offset: 0x00019100
		public XmlNodeConverter()
		{
		}

		// Token: 0x0400041A RID: 1050
		private const string TextName = "#text";

		// Token: 0x0400041B RID: 1051
		private const string CommentName = "#comment";

		// Token: 0x0400041C RID: 1052
		private const string CDataName = "#cdata-section";

		// Token: 0x0400041D RID: 1053
		private const string WhitespaceName = "#whitespace";

		// Token: 0x0400041E RID: 1054
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x0400041F RID: 1055
		private const string DeclarationName = "?xml";

		// Token: 0x04000420 RID: 1056
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		// Token: 0x04000421 RID: 1057
		[CompilerGenerated]
		private string <DeserializeRootElementName>k__BackingField;

		// Token: 0x04000422 RID: 1058
		[CompilerGenerated]
		private bool <WriteArrayAttribute>k__BackingField;

		// Token: 0x04000423 RID: 1059
		[CompilerGenerated]
		private bool <OmitRootObject>k__BackingField;
	}
}
