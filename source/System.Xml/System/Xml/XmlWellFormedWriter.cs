using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200004E RID: 78
	internal class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
		{
			XmlCharType instance = XmlCharType.Instance;
			this.xmlCharType = instance;
			base..ctor();
			this.writer = writer;
			if (writer != null)
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000F194 File Offset: 0x0000D394
		public override WriteState WriteState
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.WriteState System.Xml.XmlWellFormedWriter::get_WriteState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:State(var_0_06, ldfld:State(XmlWellFormedWriter::currentState, ldloc:XmlWellFormedWriter(this)))
	stloc:State(var_1_0D, ldfld:State(XmlWellFormedWriter::currentState, ldloc:XmlWellFormedWriter(this)))
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

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		public override void WriteStartDocument()
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
		public override void WriteStartDocument(bool standalone)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public override void WriteEndDocument()
		{
			int num = this.elemTop;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F220 File Offset: 0x0000D420
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (name != null && name._stringLength != 0)
			{
				ConformanceLevel conformanceLevel = this.conformanceLevel;
				if (!this.dtdWritten)
				{
					if (this.conformanceLevel == ConformanceLevel.Auto)
					{
						int num = 2;
						this.conformanceLevel = (ConformanceLevel)num;
						if (num == 0)
						{
						}
						this.stateTable = num;
					}
					if (this.checkCharacters)
					{
						if (pubid != null)
						{
						}
						if (sysid != null)
						{
						}
						if (subset != null)
						{
						}
					}
					XmlWriter xmlWriter = this.writer;
					int num2 = 1;
					this.dtdWritten = num2 != 0;
					return;
				}
			}
			else
			{
				string @string = Res.GetString("The empty string '' is not a valid name.");
				string string2 = Res.GetString("DTD is not allowed in XML fragments.");
			}
			int num3 = 16;
			this.currentState = (XmlWellFormedWriter.State)num3;
			string string3 = Res.GetString("The DTD has already been written out.");
			string[] array;
			string string4 = Res.GetString("'{0}', hexadecimal value {1}, is an invalid character.", array);
			string[] array2;
			string string5 = Res.GetString("'{0}', hexadecimal value {1}, is an invalid character.", array2);
			string[] array3;
			string string6 = Res.GetString("'{0}', hexadecimal value {1}, is an invalid character.", array3);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000F30C File Offset: 0x0000D50C
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (localName != null && localName._stringLength != 0)
			{
				this.CheckNCName(localName);
				if (prefix != null)
				{
					int stringLength = prefix._stringLength;
					this.CheckNCName(prefix);
					string text;
					if (ns == null)
					{
						text = this.LookupNamespace(prefix);
						if (text == null)
						{
							goto IL_003F;
						}
					}
					if (text._stringLength != 0)
					{
						goto IL_0050;
					}
					IL_003F:
					string @string = Res.GetString("Cannot use a prefix with an empty namespace.");
				}
				string text2;
				if (this != null || text2 == null)
				{
				}
				IL_0050:
				if (this.elemTop == 0 && this.rawWriter != null)
				{
					ConformanceLevel conformanceLevel = this.conformanceLevel;
				}
				XmlWriter xmlWriter = this.writer;
				int num = this.elemTop;
				string namespaceUri = this.elemScopeStack.namespaceUri;
				XmlWellFormedWriter.ElementScope[] array = this.elemScopeStack;
				int num2 = this.nsTop;
				int num3 = this.attrCount;
				Dictionary<string, int> dictionary = this.attrHashTable;
				return;
			}
			string string2 = Res.GetString("The empty string '' is not a valid local name.");
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
		public override void WriteEndElement()
		{
			if (this.rawWriter != null)
			{
				string xmlLang = this.elemScopeStack.xmlLang;
				return;
			}
			XmlWriter xmlWriter = this.writer;
			XmlWellFormedWriter.ElementScope[] array = this.elemScopeStack;
			bool flag = this.useNsHashtable;
			XmlSpace xmlSpace = array.xmlSpace;
			if (flag)
			{
				int num = this.nsTop;
			}
			this.nsTop = (int)xmlSpace;
			this.elemTop = array;
			ConformanceLevel conformanceLevel = this.conformanceLevel;
			int num2 = 7;
			this.currentState = (XmlWellFormedWriter.State)num2;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000F47C File Offset: 0x0000D67C
		public override void WriteFullEndElement()
		{
			if (this.rawWriter != null)
			{
				string xmlLang = this.elemScopeStack.xmlLang;
				return;
			}
			XmlWriter xmlWriter = this.writer;
			XmlWellFormedWriter.ElementScope[] array = this.elemScopeStack;
			bool flag = this.useNsHashtable;
			XmlSpace xmlSpace = array.xmlSpace;
			if (flag)
			{
				int num = this.nsTop;
			}
			this.nsTop = (int)xmlSpace;
			this.elemTop = array;
			ConformanceLevel conformanceLevel = this.conformanceLevel;
			int num2 = 7;
			this.currentState = (XmlWellFormedWriter.State)num2;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000F504 File Offset: 0x0000D704
		public override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
			if (localName == null || localName._stringLength == 0)
			{
				bool flag = prefix == "xmlns";
			}
			this.CheckNCName("xmlns");
			string text;
			if (namespaceName == null && text == null)
			{
				return;
			}
			this.curDeclPrefix = "xmlns";
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000F638 File Offset: 0x0000D838
		public override void WriteEndAttribute()
		{
			XmlWellFormedWriter.SpecialAttribute specialAttribute = this.specAttr;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public override void WriteCData(string text)
		{
			if (text == null)
			{
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000F8CC File Offset: 0x0000DACC
		public override void WriteComment(string text)
		{
			if (text == null)
			{
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		public override void WriteProcessingInstruction(string name, string text)
		{
			if (name != null && name._stringLength != 0)
			{
				this.CheckNCName(name);
				if (text == null)
				{
				}
				int stringLength = name._stringLength;
				int num;
				if (num != 0)
				{
					XmlWriter xmlWriter = this.writer;
					return;
				}
				if (this.currentState == XmlWellFormedWriter.State.Start)
				{
					int num2 = 1;
					this.xmlDeclFollows = num2 != 0;
					if (this.rawWriter != null)
					{
						return;
					}
					XmlWriter xmlWriter2 = this.writer;
					return;
				}
			}
			else
			{
				string @string = Res.GetString("The empty string '' is not a valid name.");
			}
			ConformanceLevel conformanceLevel = this.conformanceLevel;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000F990 File Offset: 0x0000DB90
		public override void WriteEntityRef(string name)
		{
			if (name == null || name._stringLength == 0)
			{
				string @string = Res.GetString("The empty string '' is not a valid name.");
				return;
			}
			this.CheckNCName(name);
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				this.attrValueCache.WriteEntityRef(name);
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		public override void WriteCharEntity(char ch)
		{
			if (!true)
			{
			}
			bool flag = char.IsSurrogate(ch);
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				this.attrValueCache.WriteCharEntity(ch);
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000FA44 File Offset: 0x0000DC44
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			if (!true)
			{
			}
			bool flag = char.IsSurrogatePair(highChar, lowChar);
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				this.attrValueCache.WriteSurrogateCharEntity(lowChar, highChar);
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		public override void WriteWhitespace(string ws)
		{
			if (ws == null)
			{
			}
			XmlCharType instance = XmlCharType.Instance;
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				XmlWellFormedWriter.AttributeValueCache attributeValueCache = this.attrValueCache;
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public override void WriteString(string text)
		{
			if (text != null)
			{
				if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
				{
					this.attrValueCache.WriteString(text);
					return;
				}
				XmlWriter xmlWriter = this.writer;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000FB34 File Offset: 0x0000DD34
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				return;
			}
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				this.attrValueCache.WriteChars(buffer, index, count);
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				return;
			}
			if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
			{
				this.attrValueCache.WriteRaw(buffer, index, count);
				return;
			}
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		public override void WriteRaw(string data)
		{
			if (data != null)
			{
				if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
				{
					this.attrValueCache.WriteRaw(data);
					return;
				}
				XmlWriter xmlWriter = this.writer;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			if (buffer != null)
			{
				XmlWriter xmlWriter = this.writer;
				return;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000FC34 File Offset: 0x0000DE34
		public override void Close()
		{
			XmlWellFormedWriter.State state = this.currentState;
			if (this.writeEndDocumentOnClose)
			{
				int num = this.elemTop;
				XmlWellFormedWriter.State state2 = this.currentState;
				return;
			}
			int num2 = this.elemTop;
			XmlWellFormedWriter.State state3 = this.currentState;
			XmlRawWriter xmlRawWriter = this.rawWriter;
			if (xmlRawWriter != null)
			{
			}
			XmlRawWriterBase64Encoder base64Encoder = xmlRawWriter.base64Encoder;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000FC98 File Offset: 0x0000DE98
		public override void Flush()
		{
			XmlWriter xmlWriter = this.writer;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public override string LookupPrefix(string ns)
		{
			if (ns != null)
			{
				XmlWellFormedWriter.Namespace[] array = this.nsStack;
				if (this.predefinedNamespaces != null)
				{
					XmlWellFormedWriter.Namespace[] array2 = this.nsStack;
					int num = this.nsTop;
					XmlWellFormedWriter.Namespace[] array3 = this.nsStack;
				}
				bool flag;
				bool value = flag.m_value;
			}
			int num2 = 16;
			this.currentState = (XmlWellFormedWriter.State)num2;
			throw new OutOfMemoryException();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public override void WriteValue(string value)
		{
			if (value != null)
			{
				if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
				{
					this.attrValueCache.WriteValue(value);
					return;
				}
				XmlWriter xmlWriter = this.writer;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000FD54 File Offset: 0x0000DF54
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			XmlWellFormedWriter.State state = this.currentState;
			BinHexEncoder.Encode(buffer, index, count, this);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000FD88 File Offset: 0x0000DF88
		internal XmlRawWriter RawWriter
		{
			get
			{
				return this.rawWriter;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		private bool SaveAttrValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlWellFormedWriter::get_SaveAttrValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SpecialAttribute(var_0_06, ldfld:SpecialAttribute(XmlWellFormedWriter::specAttr, ldloc:XmlWellFormedWriter(this)))
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		private bool InBase64
		{
			get
			{
				XmlWellFormedWriter.State state = this.currentState;
				return true;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
			XmlWellFormedWriter.State state = this.currentState;
			this.specAttr = special;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		private void WriteStartDocumentImpl(XmlStandalone standalone)
		{
			if (this.conformanceLevel != ConformanceLevel.Auto)
			{
				string @string = Res.GetString("WriteStartDocument cannot be called on writers created with ConformanceLevel.Fragment.");
			}
			int num = 2;
			this.conformanceLevel = (ConformanceLevel)num;
			if (num == 0)
			{
			}
			this.stateTable = num;
			if (this.rawWriter != null)
			{
				if (!this.xmlDeclFollows)
				{
					return;
				}
			}
			else
			{
				XmlWriter xmlWriter = this.writer;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000FE58 File Offset: 0x0000E058
		private void StartFragment()
		{
			this.conformanceLevel = ConformanceLevel.Fragment;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000FE6C File Offset: 0x0000E06C
		private void PushNamespaceImplicit(string prefix, string ns)
		{
			int num = this.LookupNamespaceIndex(prefix);
			XmlSpace xmlSpace = this.elemScopeStack.xmlSpace;
			XmlWellFormedWriter.Namespace[] array = this.nsStack;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000FF3C File Offset: 0x0000E13C
		private bool PushNamespaceExplicit(string prefix, string ns)
		{
			/*
An exception occurred when decompiling this method (060003EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlWellFormedWriter::PushNamespaceExplicit(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00FD:
	stloc:XmlException(var_26_10C, call:XmlException(XmlWellFormedWriter::DupAttrException, ldstr:string("xmlns"), ldstr:string("xmlns")))
	stloc:string(var_27_118, call:string(Res::GetString, ldstr:string("Prefix \"xmlns\" is reserved for use by XML.")))
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

		// Token: 0x060003EB RID: 1003 RVA: 0x00010064 File Offset: 0x0000E264
		private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
			int num = this.nsTop;
			XmlWellFormedWriter.Namespace[] array = this.nsStack;
			this.nsTop = 0;
			XmlWellFormedWriter.Namespace[] array2 = this.nsStack;
			int num2 = this.nsTop;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000100D8 File Offset: 0x0000E2D8
		private void AddToNamespaceHashtable(int namespaceIndex)
		{
			XmlWellFormedWriter.Namespace[] array = this.nsStack;
			Dictionary<string, int> dictionary = this.nsHashtable;
			XmlWellFormedWriter.Namespace[] array2 = this.nsStack;
			Dictionary<string, int> dictionary2 = this.nsHashtable;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00010104 File Offset: 0x0000E304
		private int LookupNamespaceIndex(string prefix)
		{
			if (this.useNsHashtable)
			{
				Dictionary<string, int> dictionary = this.nsHashtable;
			}
			int num = this.nsTop;
			XmlWellFormedWriter.Namespace[] array = this.nsStack;
			return num;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00010130 File Offset: 0x0000E330
		private void PopNamespaces(int indexFrom, int indexTo)
		{
			XmlWellFormedWriter.Namespace[] array = this.nsStack;
			Dictionary<string, int> dictionary = this.nsHashtable;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003FFD File Offset: 0x000021FD
		private static XmlException DupAttrException(string prefix, string localName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001014C File Offset: 0x0000E34C
		private void AdvanceState(XmlWellFormedWriter.Token token)
		{
			XmlWellFormedWriter.State state = this.currentState;
			XmlWellFormedWriter.State[] array = this.stateTable;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00010208 File Offset: 0x0000E408
		private void StartElementContent()
		{
			XmlWellFormedWriter.ElementScope[] array = this.elemScopeStack;
			XmlWellFormedWriter.Namespace[] array2 = this.nsStack;
			XmlWriter xmlWriter = this.writer;
			XmlRawWriter xmlRawWriter = this.rawWriter;
			if (this.rawWriter != null)
			{
				return;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00010240 File Offset: 0x0000E440
		private static string GetStateName(XmlWellFormedWriter.State state)
		{
			return "Error";
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00010260 File Offset: 0x0000E460
		internal string LookupNamespace(string prefix)
		{
			/*
An exception occurred when decompiling this method (060003F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlWellFormedWriter::LookupNamespace(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int64(var_2_15, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x00010284 File Offset: 0x0000E484
		private string LookupLocalNamespace(string prefix)
		{
			/*
An exception occurred when decompiling this method (060003F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlWellFormedWriter::LookupLocalNamespace(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Xml.XmlWellFormedWriter/ElementScope[](var_0_06, ldfld:valuetype System.Xml.XmlWellFormedWriter/ElementScope[](XmlWellFormedWriter::elemScopeStack, ldloc:XmlWellFormedWriter(this)))
	stloc:int32(var_1_0D, ldfld:int32(XmlWellFormedWriter::nsTop, ldloc:XmlWellFormedWriter(this)))
	stloc:XmlSpace(var_2_14, ldfld:XmlSpace(ElementScope::xmlSpace, ldloc:valuetype System.Xml.XmlWellFormedWriter/ElementScope[][exp:valuetype System.Xml.XmlWellFormedWriter/ElementScope&](var_0_06)))
	stloc:valuetype System.Xml.XmlWellFormedWriter/Namespace[](var_3_1B, ldfld:valuetype System.Xml.XmlWellFormedWriter/Namespace[](XmlWellFormedWriter::nsStack, ldloc:XmlWellFormedWriter(this)))
	stloc:XmlSpace(var_5_27, ldfld:XmlSpace(ElementScope::xmlSpace, ldfld:valuetype System.Xml.XmlWellFormedWriter/ElementScope[][exp:valuetype System.Xml.XmlWellFormedWriter/ElementScope&](XmlWellFormedWriter::elemScopeStack, ldloc:XmlWellFormedWriter(this))))
	stloc:valuetype System.Xml.XmlWellFormedWriter/Namespace[](var_7_32, ldfld:valuetype System.Xml.XmlWellFormedWriter/Namespace[](XmlWellFormedWriter::nsStack, ldloc:XmlWellFormedWriter(this)))
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x000102C4 File Offset: 0x0000E4C4
		private string GeneratePrefix()
		{
			string text3;
			do
			{
				if (this.nsTop == 0)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text2;
				string text = "p" + text2;
				if (this.LookupNamespace(text) == null)
				{
					break;
				}
				if ("p" == null)
				{
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text4;
				text3 = text + text4;
			}
			while (this.LookupNamespace(text3) != null);
			return text3;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00010320 File Offset: 0x0000E520
		private void CheckNCName(string ncname)
		{
			int stringLength = ncname._stringLength;
			XmlCharType xmlCharType = this.xmlCharType;
			long num = 0L;
			char c = ncname[(int)num];
			int num2 = 1;
			XmlCharType xmlCharType2 = this.xmlCharType;
			char c2 = ncname[num2];
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00010368 File Offset: 0x0000E568
		private static Exception InvalidCharsException(string name, int badCharIndex)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001037C File Offset: 0x0000E57C
		private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
			/*
An exception occurred when decompiling this method (060003F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlWellFormedWriter::ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter/Token,System.Xml.XmlWellFormedWriter/State)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:ConformanceLevel(var_3_24, ldfld:ConformanceLevel(XmlWellFormedWriter::conformanceLevel, ldloc:XmlWellFormedWriter(this)))
	stloc:string(var_4_2F, call:string(Res::GetString, ldstr:string("Make sure that the ConformanceLevel setting is set to ConformanceLevel.Fragment or ConformanceLevel.Auto if you want to write an XML fragment.")))
	stloc:string(var_5_3E, call:string(string::Concat, ldloc:string(var_2), ldstr:string(" "), ldloc:string(var_4_2F)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000103C8 File Offset: 0x0000E5C8
		private bool IsClosedOrErrorState
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlWellFormedWriter::get_IsClosedOrErrorState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:State(var_0_06, ldfld:State(XmlWellFormedWriter::currentState, ldloc:XmlWellFormedWriter(this)))
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

		// Token: 0x060003FA RID: 1018 RVA: 0x000103DC File Offset: 0x0000E5DC
		private void AddAttribute(string prefix, string localName, string namespaceName)
		{
			int num = 1;
			XmlWellFormedWriter.AttrName[] array = this.attrStack;
			this.attrCount = num;
			int prev = array.prev;
			XmlWellFormedWriter.AttrName[] array2 = this.attrStack;
			int num2 = this.attrCount;
			if (this.attrHashTable == null)
			{
				SecureStringHasher secureStringHasher = this.hasher;
			}
			long num3 = 0L;
			this.AddToAttrHashTable((int)num3);
			this.AddToAttrHashTable((int)num3);
			XmlWellFormedWriter.AttrName[] array3 = this.attrStack;
			XmlWellFormedWriter.AttrName[] array4 = this.attrStack;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00010454 File Offset: 0x0000E654
		private void AddToAttrHashTable(int attributeIndex)
		{
			XmlWellFormedWriter.AttrName[] array = this.attrStack;
			Dictionary<string, int> dictionary = this.attrHashTable;
			Dictionary<string, int> dictionary2 = this.attrHashTable;
			Dictionary<string, int> dictionary3 = this.attrHashTable;
			XmlWellFormedWriter.AttrName[] array2 = this.attrStack;
			XmlWellFormedWriter.AttrName[] array3 = this.attrStack;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00010490 File Offset: 0x0000E690
		// Note: this type is marked as 'beforefieldinit'.
		static XmlWellFormedWriter()
		{
			if (("Start" == null || "Start" != null) && ("TopLevel" == null || "TopLevel" != null) && ("Document" == null || "Document" != null) && ("Element Start Tag" == null || "Element Start Tag" != null) && ("Element Content" == null || "Element Content" != null) && ("Element Content" == null || "Element Content" != null) && ("Attribute" == null || "Attribute" != null) && ("EndRootElement" == null || "EndRootElement" != null) && ("Attribute" == null || "Attribute" != null) && ("Special Attribute" == null || "Special Attribute" != null) && ("End Document" == null || "End Document" != null) && ("Root Level Attribute Value" == null || "Root Level Attribute Value" != null) && ("Root Level Special Attribute Value" == null || "Root Level Special Attribute Value" != null) && ("Root Level Base64 Attribute Value" == null || "Root Level Base64 Attribute Value" != null) && ("After Root Level Attribute" == null || "After Root Level Attribute" != null) && ("Closed" == null || "Closed" != null) && ("Error" == null || "Error" != null) && ("StartDocument" == null || "StartDocument" != null) && ("EndDocument" == null || "EndDocument" != null) && ("PI" == null || "PI" != null) && ("Comment" == null || "Comment" != null) && ("DTD" == null || "DTD" != null) && ("StartElement" == null || "StartElement" != null) && ("EndElement" == null || "EndElement" != null) && ("StartAttribute" == null || "StartAttribute" != null) && ("EndAttribute" == null || "EndAttribute" != null) && ("Text" == null || "Text" != null) && ("CDATA" == null || "CDATA" != null) && ("Atomic value" == null || "Atomic value" != null) && ("Base64" == null || "Base64" != null) && ("RawData" == null || "RawData" != null) && ("Whitespace" == null || "Whitespace" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040001DE RID: 478
		private XmlWriter writer;

		// Token: 0x040001DF RID: 479
		private XmlRawWriter rawWriter;

		// Token: 0x040001E0 RID: 480
		private IXmlNamespaceResolver predefinedNamespaces;

		// Token: 0x040001E1 RID: 481
		private XmlWellFormedWriter.Namespace[] nsStack;

		// Token: 0x040001E2 RID: 482
		private int nsTop;

		// Token: 0x040001E3 RID: 483
		private Dictionary<string, int> nsHashtable;

		// Token: 0x040001E4 RID: 484
		private bool useNsHashtable;

		// Token: 0x040001E5 RID: 485
		private XmlWellFormedWriter.ElementScope[] elemScopeStack;

		// Token: 0x040001E6 RID: 486
		private int elemTop;

		// Token: 0x040001E7 RID: 487
		private XmlWellFormedWriter.AttrName[] attrStack;

		// Token: 0x040001E8 RID: 488
		private int attrCount;

		// Token: 0x040001E9 RID: 489
		private Dictionary<string, int> attrHashTable;

		// Token: 0x040001EA RID: 490
		private XmlWellFormedWriter.SpecialAttribute specAttr;

		// Token: 0x040001EB RID: 491
		private XmlWellFormedWriter.AttributeValueCache attrValueCache;

		// Token: 0x040001EC RID: 492
		private string curDeclPrefix;

		// Token: 0x040001ED RID: 493
		private XmlWellFormedWriter.State[] stateTable;

		// Token: 0x040001EE RID: 494
		private XmlWellFormedWriter.State currentState;

		// Token: 0x040001EF RID: 495
		private bool checkCharacters;

		// Token: 0x040001F0 RID: 496
		private bool omitDuplNamespaces;

		// Token: 0x040001F1 RID: 497
		private bool writeEndDocumentOnClose;

		// Token: 0x040001F2 RID: 498
		private ConformanceLevel conformanceLevel;

		// Token: 0x040001F3 RID: 499
		private bool dtdWritten;

		// Token: 0x040001F4 RID: 500
		private bool xmlDeclFollows;

		// Token: 0x040001F5 RID: 501
		private XmlCharType xmlCharType;

		// Token: 0x040001F6 RID: 502
		private SecureStringHasher hasher;

		// Token: 0x040001F7 RID: 503
		internal static readonly string[] stateName;

		// Token: 0x040001F8 RID: 504
		internal static readonly string[] tokenName;

		// Token: 0x040001F9 RID: 505
		private static WriteState[] state2WriteState;

		// Token: 0x040001FA RID: 506
		private static readonly XmlWellFormedWriter.State[] StateTableDocument;

		// Token: 0x040001FB RID: 507
		private static readonly XmlWellFormedWriter.State[] StateTableAuto;

		// Token: 0x0200004F RID: 79
		private enum State
		{
			// Token: 0x040001FD RID: 509
			Start,
			// Token: 0x040001FE RID: 510
			TopLevel,
			// Token: 0x040001FF RID: 511
			Document,
			// Token: 0x04000200 RID: 512
			Element,
			// Token: 0x04000201 RID: 513
			Content,
			// Token: 0x04000202 RID: 514
			B64Content,
			// Token: 0x04000203 RID: 515
			B64Attribute,
			// Token: 0x04000204 RID: 516
			AfterRootEle,
			// Token: 0x04000205 RID: 517
			Attribute,
			// Token: 0x04000206 RID: 518
			SpecialAttr,
			// Token: 0x04000207 RID: 519
			EndDocument,
			// Token: 0x04000208 RID: 520
			RootLevelAttr,
			// Token: 0x04000209 RID: 521
			RootLevelSpecAttr,
			// Token: 0x0400020A RID: 522
			RootLevelB64Attr,
			// Token: 0x0400020B RID: 523
			AfterRootLevelAttr,
			// Token: 0x0400020C RID: 524
			Closed,
			// Token: 0x0400020D RID: 525
			Error,
			// Token: 0x0400020E RID: 526
			StartContent = 101,
			// Token: 0x0400020F RID: 527
			StartContentEle,
			// Token: 0x04000210 RID: 528
			StartContentB64,
			// Token: 0x04000211 RID: 529
			StartDoc,
			// Token: 0x04000212 RID: 530
			StartDocEle = 106,
			// Token: 0x04000213 RID: 531
			EndAttrSEle,
			// Token: 0x04000214 RID: 532
			EndAttrEEle,
			// Token: 0x04000215 RID: 533
			EndAttrSCont,
			// Token: 0x04000216 RID: 534
			EndAttrSAttr = 111,
			// Token: 0x04000217 RID: 535
			PostB64Cont,
			// Token: 0x04000218 RID: 536
			PostB64Attr,
			// Token: 0x04000219 RID: 537
			PostB64RootAttr,
			// Token: 0x0400021A RID: 538
			StartFragEle,
			// Token: 0x0400021B RID: 539
			StartFragCont,
			// Token: 0x0400021C RID: 540
			StartFragB64,
			// Token: 0x0400021D RID: 541
			StartRootLevelAttr
		}

		// Token: 0x02000050 RID: 80
		private enum Token
		{
			// Token: 0x0400021F RID: 543
			StartDocument,
			// Token: 0x04000220 RID: 544
			EndDocument,
			// Token: 0x04000221 RID: 545
			PI,
			// Token: 0x04000222 RID: 546
			Comment,
			// Token: 0x04000223 RID: 547
			Dtd,
			// Token: 0x04000224 RID: 548
			StartElement,
			// Token: 0x04000225 RID: 549
			EndElement,
			// Token: 0x04000226 RID: 550
			StartAttribute,
			// Token: 0x04000227 RID: 551
			EndAttribute,
			// Token: 0x04000228 RID: 552
			Text,
			// Token: 0x04000229 RID: 553
			CData,
			// Token: 0x0400022A RID: 554
			AtomicValue,
			// Token: 0x0400022B RID: 555
			Base64,
			// Token: 0x0400022C RID: 556
			RawData,
			// Token: 0x0400022D RID: 557
			Whitespace
		}

		// Token: 0x02000051 RID: 81
		private class NamespaceResolverProxy : IXmlNamespaceResolver
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x000106B0 File Offset: 0x0000E8B0
			internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
			{
				this.wfWriter = wfWriter;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x000106CC File Offset: 0x0000E8CC
			string IXmlNamespaceResolver.LookupNamespace(string prefix)
			{
				return this.wfWriter.LookupNamespace(prefix);
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x000106E8 File Offset: 0x0000E8E8
			string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
			{
				/*
An exception occurred when decompiling this method (060003FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlWellFormedWriter/NamespaceResolverProxy::System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlWellFormedWriter(var_0_06, ldfld:XmlWellFormedWriter(NamespaceResolverProxy::wfWriter, ldloc:NamespaceResolverProxy(this)))
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

			// Token: 0x0400022E RID: 558
			private XmlWellFormedWriter wfWriter;
		}

		// Token: 0x02000052 RID: 82
		private struct ElementScope
		{
			// Token: 0x06000400 RID: 1024 RVA: 0x000106FC File Offset: 0x0000E8FC
			internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
				this.prevNSTop = prevNSTop;
				this.localName = localName;
				this.namespaceUri = namespaceUri;
				this.prefix = prefix;
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00010728 File Offset: 0x0000E928
			internal void WriteEndElement(XmlRawWriter rawWriter)
			{
				string text = this.prefix;
				string text2 = this.localName;
				string text3 = this.namespaceUri;
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0001074C File Offset: 0x0000E94C
			internal void WriteFullEndElement(XmlRawWriter rawWriter)
			{
				string text = this.prefix;
				string text2 = this.localName;
				string text3 = this.namespaceUri;
			}

			// Token: 0x0400022F RID: 559
			internal int prevNSTop;

			// Token: 0x04000230 RID: 560
			internal string prefix;

			// Token: 0x04000231 RID: 561
			internal string localName;

			// Token: 0x04000232 RID: 562
			internal string namespaceUri;

			// Token: 0x04000233 RID: 563
			internal XmlSpace xmlSpace;

			// Token: 0x04000234 RID: 564
			internal string xmlLang;
		}

		// Token: 0x02000053 RID: 83
		private enum NamespaceKind
		{
			// Token: 0x04000236 RID: 566
			Written,
			// Token: 0x04000237 RID: 567
			NeedToWrite,
			// Token: 0x04000238 RID: 568
			Implied,
			// Token: 0x04000239 RID: 569
			Special
		}

		// Token: 0x02000054 RID: 84
		private struct Namespace
		{
			// Token: 0x06000403 RID: 1027 RVA: 0x00010770 File Offset: 0x0000E970
			internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
				this.prefix = prefix;
				this.namespaceUri = namespaceUri;
				this.kind = kind;
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00010794 File Offset: 0x0000E994
			internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
				if (rawWriter != null)
				{
					string text = this.namespaceUri;
					return;
				}
			}

			// Token: 0x0400023A RID: 570
			internal string prefix;

			// Token: 0x0400023B RID: 571
			internal string namespaceUri;

			// Token: 0x0400023C RID: 572
			internal XmlWellFormedWriter.NamespaceKind kind;

			// Token: 0x0400023D RID: 573
			internal int prevNsIndex;
		}

		// Token: 0x02000055 RID: 85
		private struct AttrName
		{
			// Token: 0x06000405 RID: 1029 RVA: 0x000107B4 File Offset: 0x0000E9B4
			internal void Set(string prefix, string localName, string namespaceUri)
			{
				this.prefix = prefix;
				this.namespaceUri = namespaceUri;
				this.localName = localName;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x000107D8 File Offset: 0x0000E9D8
			internal bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				bool flag = this.localName == localName;
				return true;
			}

			// Token: 0x0400023E RID: 574
			internal string prefix;

			// Token: 0x0400023F RID: 575
			internal string namespaceUri;

			// Token: 0x04000240 RID: 576
			internal string localName;

			// Token: 0x04000241 RID: 577
			internal int prev;
		}

		// Token: 0x02000056 RID: 86
		private enum SpecialAttribute
		{
			// Token: 0x04000243 RID: 579
			No,
			// Token: 0x04000244 RID: 580
			DefaultXmlns,
			// Token: 0x04000245 RID: 581
			PrefixedXmlns,
			// Token: 0x04000246 RID: 582
			XmlSpace,
			// Token: 0x04000247 RID: 583
			XmlLang
		}

		// Token: 0x02000057 RID: 87
		private class AttributeValueCache
		{
			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00010804 File Offset: 0x0000EA04
			internal string StringValue
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000407)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlWellFormedWriter/AttributeValueCache::get_StringValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int32(var_1_12, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
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
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00010824 File Offset: 0x0000EA24
			internal void WriteEntityRef(string name)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				bool flag = name == "lt";
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x0001089C File Offset: 0x0000EA9C
			internal void WriteCharEntity(char ch)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(ch);
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x000108C4 File Offset: 0x0000EAC4
			internal void WriteSurrogateCharEntity(char lowChar, char highChar)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(highChar);
				StringBuilder stringBuilder2 = this.stringValue.Append(lowChar);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x000108FC File Offset: 0x0000EAFC
			internal void WriteWhitespace(string ws)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(ws);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.Whitespace, ws);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0001092C File Offset: 0x0000EB2C
			internal void WriteString(string text)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
					return;
				}
				int num = this.lastItem;
				StringBuilder stringBuilder = this.stringValue.Append(text);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.String, text);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x0001096C File Offset: 0x0000EB6C
			internal void WriteChars(char[] buffer, int index, int count)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(buffer, index, count);
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00010998 File Offset: 0x0000EB98
			internal void WriteRaw(char[] buffer, int index, int count)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(buffer, index, count);
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x000109C4 File Offset: 0x0000EBC4
			internal void WriteRaw(string data)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(data);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.Raw, data);
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x000109F4 File Offset: 0x0000EBF4
			internal void WriteValue(string value)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				StringBuilder stringBuilder = this.stringValue.Append(value);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.ValueString, value);
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x00010A24 File Offset: 0x0000EC24
			internal void Replay(XmlWriter writer)
			{
				if (this.singleStringValue != null)
				{
					return;
				}
				int num = this.firstItem;
				XmlWellFormedWriter.AttributeValueCache.Item[] array = this.items;
				XmlWellFormedWriter.AttributeValueCache.ItemType type = array.type;
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00010A78 File Offset: 0x0000EC78
			internal void Trim()
			{
				int num = 1;
				string text = this.singleStringValue;
				if (text != null)
				{
					if (num == 0)
					{
					}
					string text2 = XmlConvert.TrimString(text);
					this.singleStringValue = text2;
					return;
				}
				StringBuilder stringBuilder = this.stringValue;
				XmlCharType instance = XmlCharType.Instance;
				int num2 = this.firstItem;
				int num3 = this.lastItem;
				XmlWellFormedWriter.AttributeValueCache.Item[] array = this.items;
				string text3;
				if (text3 != null)
				{
				}
				int stringLength = text3._stringLength;
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00010B78 File Offset: 0x0000ED78
			internal void Clear()
			{
				StringBuilder stringBuilder = this.stringValue;
				long num = 0L;
				stringBuilder.Length = (int)num;
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00010B98 File Offset: 0x0000ED98
			private void StartComplexValue()
			{
				StringBuilder stringBuilder = this.stringValue;
				string text = this.singleStringValue;
				StringBuilder stringBuilder2 = stringBuilder.Append(text);
				string text2 = this.singleStringValue;
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.String, text2);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00010BCC File Offset: 0x0000EDCC
			private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
			{
				int num = this.lastItem;
				XmlWellFormedWriter.AttributeValueCache.Item[] array = this.items;
				XmlWellFormedWriter.AttributeValueCache.Item[] array2;
				if (array != null)
				{
					object data2 = array.data;
					array2 = this.items;
					return;
				}
				if (array2 == null)
				{
					XmlWellFormedWriter.AttributeValueCache.Item[] array3 = this.items;
				}
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00010C10 File Offset: 0x0000EE10
			public AttributeValueCache()
			{
			}

			// Token: 0x04000248 RID: 584
			private StringBuilder stringValue;

			// Token: 0x04000249 RID: 585
			private string singleStringValue;

			// Token: 0x0400024A RID: 586
			private XmlWellFormedWriter.AttributeValueCache.Item[] items;

			// Token: 0x0400024B RID: 587
			private int firstItem;

			// Token: 0x0400024C RID: 588
			private int lastItem = 1;

			// Token: 0x02000058 RID: 88
			private enum ItemType
			{
				// Token: 0x0400024E RID: 590
				EntityRef,
				// Token: 0x0400024F RID: 591
				CharEntity,
				// Token: 0x04000250 RID: 592
				SurrogateCharEntity,
				// Token: 0x04000251 RID: 593
				Whitespace,
				// Token: 0x04000252 RID: 594
				String,
				// Token: 0x04000253 RID: 595
				StringChars,
				// Token: 0x04000254 RID: 596
				Raw,
				// Token: 0x04000255 RID: 597
				RawChars,
				// Token: 0x04000256 RID: 598
				ValueString
			}

			// Token: 0x02000059 RID: 89
			private class Item
			{
				// Token: 0x06000417 RID: 1047 RVA: 0x00010C2A File Offset: 0x0000EE2A
				internal Item()
				{
				}

				// Token: 0x06000418 RID: 1048 RVA: 0x00010C2A File Offset: 0x0000EE2A
				internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
				{
				}

				// Token: 0x04000257 RID: 599
				internal XmlWellFormedWriter.AttributeValueCache.ItemType type;

				// Token: 0x04000258 RID: 600
				internal object data;
			}

			// Token: 0x0200005A RID: 90
			private class BufferChunk
			{
				// Token: 0x06000419 RID: 1049 RVA: 0x00010C2A File Offset: 0x0000EE2A
				internal BufferChunk(char[] buffer, int index, int count)
				{
				}

				// Token: 0x04000259 RID: 601
				internal char[] buffer;

				// Token: 0x0400025A RID: 602
				internal int index;

				// Token: 0x0400025B RID: 603
				internal int count;
			}
		}
	}
}
