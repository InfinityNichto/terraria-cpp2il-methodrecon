using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x02000025 RID: 37
	internal class QueryOutputWriter : XmlRawWriter
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00003A68 File Offset: 0x00001C68
		public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings)
		{
			this.wrapped = writer;
			string docTypeSystem = settings.docTypeSystem;
			this.systemId = docTypeSystem;
			string docTypePublic = settings.docTypePublic;
			this.publicId = docTypePublic;
			if (settings.outputMethod == XmlOutputMethod.Xml)
			{
				if (docTypeSystem != null)
				{
					this.outputDocType = 257 != 0;
				}
				if (settings.autoXmlDecl)
				{
					XmlStandalone standalone = settings.standalone;
					this.checkWellFormedDoc = standalone != XmlStandalone.Omit;
				}
				int size = settings.cdataSections._size;
				List<XmlQualifiedName> cdataSections = settings.cdataSections;
				Dictionary<XmlQualifiedName, int> dictionary = this.lookupCDataElems;
				return;
			}
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00003B34 File Offset: 0x00001D34
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			set
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				this.resolver = value;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003B50 File Offset: 0x00001D50
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003B64 File Offset: 0x00001D64
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003B78 File Offset: 0x00001D78
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			if (this.publicId != null || this.systemId != null)
			{
				return;
			}
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			while (this.checkWellFormedDoc)
			{
				int num = this.depth;
				if (num != 0 || !this.hasDocElem)
				{
					int num2 = 1;
					this.depth = num;
					this.hasDocElem = num2 != 0;
					break;
				}
			}
			if (this.outputDocType)
			{
				int stringLength = prefix._stringLength;
				XmlRawWriter xmlRawWriter = this.wrapped;
				if (stringLength != 0)
				{
					string text = prefix + ":" + localName;
				}
				string text2 = this.systemId;
				string text3 = this.publicId;
			}
			XmlRawWriter xmlRawWriter2 = this.wrapped;
			if (this.lookupCDataElems != null)
			{
				this.qnameCData.Init(localName, ns);
				Dictionary<XmlQualifiedName, int> dictionary = this.lookupCDataElems;
				BitStack bitStack = this.bitsCData;
				XmlQualifiedName xmlQualifiedName = this.qnameCData;
				uint curr = bitStack.curr;
				bitStack.PushCurr();
				uint curr2 = bitStack.curr;
				bitStack.curr = dictionary;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003C68 File Offset: 0x00001E68
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
			if (this.checkWellFormedDoc)
			{
				int num = this.depth;
				this.depth = num;
			}
			if (this.lookupCDataElems != null)
			{
				BitStack bitStack = this.bitsCData;
				uint curr = bitStack.curr;
				bitStack.curr = curr;
				int stackPos = bitStack.stackPos;
				uint[] bitStack2 = bitStack.bitStack;
				bitStack.stackPos = stackPos;
				bitStack.curr = (uint)stackPos;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003CD0 File Offset: 0x00001ED0
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
			if (this.checkWellFormedDoc)
			{
				int num = this.depth;
				this.depth = num;
			}
			if (this.lookupCDataElems != null)
			{
				BitStack bitStack = this.bitsCData;
				uint curr = bitStack.curr;
				bitStack.curr = curr;
				int stackPos = bitStack.stackPos;
				uint[] bitStack2 = bitStack.bitStack;
				bitStack.stackPos = stackPos;
				bitStack.curr = (uint)stackPos;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003D38 File Offset: 0x00001F38
		internal override void StartElementContent()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003D4C File Offset: 0x00001F4C
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
			this.inAttr = true;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003D68 File Offset: 0x00001F68
		public override void WriteEndAttribute()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003D7C File Offset: 0x00001F7C
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003D90 File Offset: 0x00001F90
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.QueryOutputWriter::get_SupportsNamespaceDeclarationInChunks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlRawWriter(var_0_06, ldfld:XmlRawWriter(QueryOutputWriter::wrapped, ldloc:QueryOutputWriter(this)))
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

		// Token: 0x060000C4 RID: 196 RVA: 0x00003DA4 File Offset: 0x00001FA4
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003DB8 File Offset: 0x00001FB8
		internal override void WriteEndNamespaceDeclaration()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003DCC File Offset: 0x00001FCC
		public override void WriteCData(string text)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public override void WriteComment(string text)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003DF4 File Offset: 0x00001FF4
		public override void WriteProcessingInstruction(string name, string text)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003E08 File Offset: 0x00002008
		public override void WriteWhitespace(string ws)
		{
			if (this.inAttr)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				return;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003E28 File Offset: 0x00002028
		public override void WriteString(string text)
		{
			if (this.inAttr)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				return;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003E48 File Offset: 0x00002048
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.inAttr)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				return;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003E68 File Offset: 0x00002068
		public override void WriteEntityRef(string name)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003E7C File Offset: 0x0000207C
		public override void WriteCharEntity(char ch)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003E90 File Offset: 0x00002090
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003EA4 File Offset: 0x000020A4
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			if (this.inAttr)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				return;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003EC4 File Offset: 0x000020C4
		public override void WriteRaw(string data)
		{
			if (this.inAttr)
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
				return;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003EE4 File Offset: 0x000020E4
		public override void Close()
		{
			do
			{
				XmlRawWriter xmlRawWriter = this.wrapped;
			}
			while (this.checkWellFormedDoc && !this.hasDocElem);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003F08 File Offset: 0x00002108
		public override void Flush()
		{
			XmlRawWriter xmlRawWriter = this.wrapped;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003F1C File Offset: 0x0000211C
		private bool StartCDataSection()
		{
			if (this.lookupCDataElems != null)
			{
				uint curr = this.bitsCData.curr;
			}
			this.inCDataSection = true;
			return true;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003F48 File Offset: 0x00002148
		private void EndCDataSection()
		{
		}

		// Token: 0x04000051 RID: 81
		private XmlRawWriter wrapped;

		// Token: 0x04000052 RID: 82
		private bool inCDataSection;

		// Token: 0x04000053 RID: 83
		private Dictionary<XmlQualifiedName, int> lookupCDataElems;

		// Token: 0x04000054 RID: 84
		private BitStack bitsCData;

		// Token: 0x04000055 RID: 85
		private XmlQualifiedName qnameCData;

		// Token: 0x04000056 RID: 86
		private bool outputDocType;

		// Token: 0x04000057 RID: 87
		private bool checkWellFormedDoc;

		// Token: 0x04000058 RID: 88
		private bool hasDocElem;

		// Token: 0x04000059 RID: 89
		private bool inAttr;

		// Token: 0x0400005A RID: 90
		private string systemId;

		// Token: 0x0400005B RID: 91
		private string publicId;

		// Token: 0x0400005C RID: 92
		private int depth;
	}
}
