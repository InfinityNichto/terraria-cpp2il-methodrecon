using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200004C RID: 76
	internal class XmlUtf8RawTextWriter : XmlRawWriter
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0000DE68 File Offset: 0x0000C068
		protected XmlUtf8RawTextWriter(XmlWriterSettings settings)
		{
			XmlCharType instance = XmlCharType.Instance;
			this.xmlCharType = instance;
			this.bufLen = 6144;
			base..ctor();
			bool flag = settings.useAsync;
			this.useAsync = flag;
			NewLineHandling newLineHandling = settings.newLineHandling;
			this.newLineHandling = newLineHandling;
			bool omitXmlDecl = settings.omitXmlDecl;
			this.omitXmlDeclaration = omitXmlDecl;
			string text = settings.newLineChars;
			this.newLineChars = text;
			bool flag2 = settings.checkCharacters;
			this.checkCharacters = flag2;
			bool flag3 = settings.closeOutput;
			this.closeOutput = flag3;
			XmlStandalone xmlStandalone = settings.standalone;
			this.standalone = xmlStandalone;
			XmlOutputMethod xmlOutputMethod = settings.outputMethod;
			this.outputMethod = xmlOutputMethod;
			bool flag4 = settings.mergeCDataSections;
			this.mergeCDataSections = flag4;
			if (newLineHandling == NewLineHandling.Replace && flag2)
			{
				long num = 0L;
				this.ValidateContentChars(text, "NewLineChars", num != 0L);
				return;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000DF3C File Offset: 0x0000C13C
		public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			this.stream = stream;
			Encoding encoding = settings.encoding;
			this.encoding = encoding;
			if (settings.useAsync)
			{
				int num = 1;
				this.bufLen = num;
				return;
			}
			int num2 = this.bufLen;
			if (stream == null && this.encoding.dataItem != null)
			{
				byte[] array = this.bufBytes;
				int num3 = this.bufPos;
				this.bufPos = num3;
			}
			if (settings.autoXmlDecl)
			{
				XmlStandalone xmlStandalone = this.standalone;
				int num4 = 1;
				this.autoXmlDeclaration = num4 != 0;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			if (this.omitXmlDeclaration || this.autoXmlDeclaration)
			{
				return;
			}
			this.RawText("<?xml version=\"");
			this.RawText("1.0");
			if (this.encoding != null)
			{
				this.RawText("\" encoding=\"");
				Encoding encoding = this.encoding;
			}
			if (standalone != XmlStandalone.Omit)
			{
				this.RawText("\" standalone=\"");
				this.RawText("\" standalone=\"");
			}
			this.RawText("\"?>");
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000E034 File Offset: 0x0000C234
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			if (this.omitXmlDeclaration || this.autoXmlDeclaration)
			{
				return;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000E054 File Offset: 0x0000C254
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.RawText("<!DOCTYPE ");
			this.RawText(name);
			if (pubid != null)
			{
				this.RawText(" PUBLIC \"");
				this.RawText(pubid);
				this.RawText("\" \"");
				if (sysid == null)
				{
					return;
				}
			}
			else
			{
				if (sysid == null)
				{
					return;
				}
				this.RawText(" SYSTEM \"");
			}
			this.RawText(sysid);
			byte[] array = this.bufBytes;
			if (subset != null)
			{
				byte[] array2 = this.bufBytes;
				this.RawText(subset);
				byte[] array3 = this.bufBytes;
			}
			byte[] array4 = this.bufBytes;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			byte[] array = this.bufBytes;
			if (prefix != null && prefix._stringLength != 0)
			{
				this.RawText(prefix);
				byte[] array2 = this.bufBytes;
			}
			this.RawText(localName);
			int num = this.bufPos;
			this.attrEndPos = num;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000E130 File Offset: 0x0000C330
		internal override void StartElementContent()
		{
			byte[] array = this.bufBytes;
			int num = this.bufPos;
			this.contentPos = num;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000E154 File Offset: 0x0000C354
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.contentPos;
			byte[] array = this.bufBytes;
			this.bufPos = num;
			byte[] array2 = this.bufBytes;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			byte[] array = this.bufBytes;
			byte[] array2 = this.bufBytes;
			if (prefix != null && prefix._stringLength != 0)
			{
				this.RawText(prefix);
				byte[] array3 = this.bufBytes;
			}
			this.RawText(localName);
			byte[] array4 = this.bufBytes;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000E244 File Offset: 0x0000C444
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			int num = this.bufPos;
			byte[] array = this.bufBytes;
			byte[] array2;
			if (prefix != null)
			{
				int stringLength = prefix._stringLength;
				this.RawText(prefix);
				array2 = this.bufBytes;
			}
			this.RawText(localName);
			byte[] array3 = this.bufBytes;
			this.bufPos = array2;
			byte[] array4 = this.bufBytes;
			this.bufPos = array2;
			int num2 = 1;
			this.inAttributeValue = num2 != 0;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		public override void WriteEndAttribute()
		{
			byte[] array = this.bufBytes;
			int num = this.bufPos;
			this.attrEndPos = num;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			if (prefix._stringLength != 0)
			{
				this.RawText(" xmlns:");
				this.RawText(prefix);
				byte[] array = this.bufBytes;
				byte[] array2 = this.bufBytes;
				return;
			}
			this.RawText(" xmlns=\"");
			int num = 1;
			this.inAttributeValue = num != 0;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000E344 File Offset: 0x0000C544
		internal override void WriteEndNamespaceDeclaration()
		{
			byte[] array = this.bufBytes;
			int num = this.bufPos;
			this.attrEndPos = num;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E368 File Offset: 0x0000C568
		public override void WriteCData(string text)
		{
			if (this.mergeCDataSections)
			{
				int num = this.cdataPos;
				return;
			}
			byte[] array = this.bufBytes;
			int num2 = 60;
			byte[] array2 = this.bufBytes;
			this.bufPos = num2;
			byte[] array3 = this.bufBytes;
			this.bufPos = num2;
			byte[] array4 = this.bufBytes;
			byte[] array5 = this.bufBytes;
			byte[] array6 = this.bufBytes;
			int num3 = 65;
			byte[] array7 = this.bufBytes;
			int num4 = 84;
			this.bufPos = array6;
			byte[] array8 = this.bufBytes;
			this.bufPos = num4;
			byte[] array9 = this.bufBytes;
			this.bufPos = num3;
			this.WriteCDataSection(text);
			byte[] array10 = this.bufBytes;
			this.bufPos = num3;
			byte[] array11 = this.bufBytes;
			this.bufPos = num3;
			byte[] array12 = this.bufBytes;
			this.bufPos = num3;
			int num5 = this.bufPos;
			this.textPos = num5;
			this.cdataPos = num5;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000E458 File Offset: 0x0000C658
		public override void WriteComment(string text)
		{
			byte[] array = this.bufBytes;
			byte[] array2 = this.bufBytes;
			int num = 33;
			int num2 = 45;
			byte[] array3 = this.bufBytes;
			this.bufPos = num;
			byte[] array4 = this.bufBytes;
			this.bufPos = num;
			this.WriteCommentOrPi(text, num2);
			byte[] array5 = this.bufBytes;
			this.bufPos = num;
			byte[] array6 = this.bufBytes;
			this.bufPos = num;
			byte[] array7 = this.bufBytes;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public override void WriteProcessingInstruction(string name, string text)
		{
			byte[] array = this.bufBytes;
			byte[] array2 = this.bufBytes;
			this.RawText(name);
			int stringLength = text._stringLength;
			byte[] array3 = this.bufBytes;
			int num = 32;
			int num2 = 63;
			this.WriteCommentOrPi(text, num2);
			byte[] array4 = this.bufBytes;
			this.bufPos = num;
			byte[] array5 = this.bufBytes;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000E530 File Offset: 0x0000C730
		public override void WriteEntityRef(string name)
		{
			byte[] array = this.bufBytes;
			this.RawText(name);
			byte[] array2 = this.bufBytes;
			int num = this.bufPos;
			int num2 = this.bufLen;
			int num3 = this.bufPos;
			this.textPos = num3;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000E570 File Offset: 0x0000C770
		public override void WriteCharEntity(char ch)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if (this.checkCharacters)
			{
			}
			byte[] array = this.bufBytes;
			byte[] array2 = this.bufBytes;
			byte[] array3 = this.bufBytes;
			this.bufPos = array2;
			string text;
			this.RawText(text);
			byte[] array4 = this.bufBytes;
			int num = this.bufPos;
			int num2 = this.bufLen;
			int num3 = this.bufPos;
			this.textPos = num3;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		public override void WriteWhitespace(string ws)
		{
			if (ws != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000E620 File Offset: 0x0000C820
		public override void WriteString(string text)
		{
			if (text != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000E644 File Offset: 0x0000C844
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			byte[] array = this.bufBytes;
			byte[] array2 = this.bufBytes;
			byte[] array3 = this.bufBytes;
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			this.RawText(text);
			byte[] array4 = this.bufBytes;
			int num = this.bufPos;
			this.textPos = num;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public override void WriteChars(char[] buffer, int index, int count)
		{
			if (this.inAttributeValue)
			{
				return;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			int num = this.bufPos;
			this.textPos = num;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		public override void WriteRaw(string data)
		{
			if (data != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
			int num = this.bufPos;
			this.textPos = num;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public override void Close()
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E70C File Offset: 0x0000C90C
		public override void Flush()
		{
			if (this.stream != null)
			{
				return;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E724 File Offset: 0x0000C924
		protected virtual void FlushBuffer()
		{
			if (!this.writeToNull)
			{
				byte[] array = this.bufBytes;
				Stream stream = this.stream;
				int num = this.bufPos;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000E760 File Offset: 0x0000C960
		private void FlushEncoder()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E770 File Offset: 0x0000C970
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E81C File Offset: 0x0000CA1C
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		protected void RawText(string s)
		{
			if (s != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				return;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000E8CC File Offset: 0x0000CACC
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			if (this.bufBytes != null)
			{
				return;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000E900 File Offset: 0x0000CB00
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000E968 File Offset: 0x0000CB68
		protected void WriteCommentOrPi(string text, int stopChar)
		{
			if (text._stringLength == 0)
			{
				int num = this.bufPos;
				int num2 = this.bufLen;
				return;
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000EA10 File Offset: 0x0000CC10
		protected void WriteCDataSection(string text)
		{
			if (text._stringLength == 0)
			{
				int num = this.bufPos;
				int num2 = this.bufLen;
				return;
			}
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (this.bufBytes != null)
			{
				return;
			}
			XmlCharType xmlCharType = this.xmlCharType;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00003FFD File Offset: 0x000021FD
		private static bool IsSurrogateByte(byte b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		private unsafe static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			/*
An exception occurred when decompiling this method (060003A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* System.Xml.XmlUtf8RawTextWriter::EncodeSurrogate(System.Char*,System.Char*,System.Byte*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_6_1B, call:Exception(XmlConvert::CreateInvalidHighSurrogateCharException, ldloc:char*[exp:char](pSrc)))
	stloc:string(var_7_27, call:string(Res::GetString, ldstr:string("The surrogate pair is invalid. Missing a low surrogate character.")))
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

		// Token: 0x060003A1 RID: 929 RVA: 0x0000EB08 File Offset: 0x0000CD08
		private unsafe byte* InvalidXmlChar(int ch, byte* pDst, bool entitize)
		{
			/*
An exception occurred when decompiling this method (060003A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* System.Xml.XmlUtf8RawTextWriter::InvalidXmlChar(System.Int32,System.Byte*,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	stloc:int64(var_3_28, ldc.i4:int64(0))
	stloc:Exception(var_4_30, call:Exception(XmlConvert::CreateInvalidCharException, ldloc:int32[exp:char](ch), ldloc:int64[exp:char](var_3_28)))
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0000EB48 File Offset: 0x0000CD48
		internal unsafe void EncodeChar(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			byte* ptr;
			pDst->m_value = ptr;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000EB84 File Offset: 0x0000CD84
		internal unsafe static byte* EncodeMultibyteUTF8(int ch, byte* pDst)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000EB98 File Offset: 0x0000CD98
		internal unsafe static void CharToUTF8(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			byte* ptr;
			pDst->m_value = ptr;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		protected unsafe byte* WriteNewLine(byte* pDst)
		{
			/*
An exception occurred when decompiling this method (060003A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* System.Xml.XmlUtf8RawTextWriter::WriteNewLine(System.Byte*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_0_0E, ldfld:string(XmlUtf8RawTextWriter::newLineChars, ldloc:XmlUtf8RawTextWriter(this)))
	call:void(XmlUtf8RawTextWriter::RawText, ldloc:XmlUtf8RawTextWriter(this), ldloc:string(var_0_0E))
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

		// Token: 0x060003A6 RID: 934 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* LtEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* GtEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* AmpEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* QuoteEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* TabEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* LineFeedEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* CarriageReturnEntity(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		private unsafe static byte* CharEntity(byte* pDst, char ch)
		{
			/*
An exception occurred when decompiling this method (060003AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* System.Xml.XmlUtf8RawTextWriter::CharEntity(System.Byte*,System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_001B, ldloc:int32[exp:bool](var_3_0D))
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

		// Token: 0x060003AE RID: 942 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* RawStartCData(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003FFD File Offset: 0x000021FD
		protected unsafe static byte* RawEndCData(byte* pDst)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000EC08 File Offset: 0x0000CE08
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040001C1 RID: 449
		private readonly bool useAsync;

		// Token: 0x040001C2 RID: 450
		protected byte[] bufBytes;

		// Token: 0x040001C3 RID: 451
		protected Stream stream;

		// Token: 0x040001C4 RID: 452
		protected Encoding encoding;

		// Token: 0x040001C5 RID: 453
		protected XmlCharType xmlCharType;

		// Token: 0x040001C6 RID: 454
		protected int bufPos;

		// Token: 0x040001C7 RID: 455
		protected int textPos;

		// Token: 0x040001C8 RID: 456
		protected int contentPos;

		// Token: 0x040001C9 RID: 457
		protected int cdataPos;

		// Token: 0x040001CA RID: 458
		protected int attrEndPos;

		// Token: 0x040001CB RID: 459
		protected int bufLen;

		// Token: 0x040001CC RID: 460
		protected bool writeToNull;

		// Token: 0x040001CD RID: 461
		protected bool hadDoubleBracket;

		// Token: 0x040001CE RID: 462
		protected bool inAttributeValue;

		// Token: 0x040001CF RID: 463
		protected NewLineHandling newLineHandling;

		// Token: 0x040001D0 RID: 464
		protected bool closeOutput;

		// Token: 0x040001D1 RID: 465
		protected bool omitXmlDeclaration;

		// Token: 0x040001D2 RID: 466
		protected string newLineChars;

		// Token: 0x040001D3 RID: 467
		protected bool checkCharacters;

		// Token: 0x040001D4 RID: 468
		protected XmlStandalone standalone;

		// Token: 0x040001D5 RID: 469
		protected XmlOutputMethod outputMethod;

		// Token: 0x040001D6 RID: 470
		protected bool autoXmlDeclaration;

		// Token: 0x040001D7 RID: 471
		protected bool mergeCDataSections;
	}
}
