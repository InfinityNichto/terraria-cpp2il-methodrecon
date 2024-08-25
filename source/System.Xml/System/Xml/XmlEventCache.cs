using System;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000034 RID: 52
	internal sealed class XmlEventCache : XmlRawWriter
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00006390 File Offset: 0x00004590
		public XmlEventCache(string baseUri, bool hasRootNode)
		{
			this.baseUri = baseUri;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000063AC File Offset: 0x000045AC
		public void EndEvents()
		{
			if (this.singleText.idxStr == 0)
			{
				int num = this.NewEvent();
				XmlEventCache.XmlEvent[] array = this.pageCurr;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000063D4 File Offset: 0x000045D4
		public void EventsToWriter(XmlWriter writer)
		{
			if (this.singleText.idxStr != 0)
			{
				return;
			}
			if (writer != null)
			{
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006474 File Offset: 0x00004674
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 1;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006494 File Offset: 0x00004694
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 2;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000064B4 File Offset: 0x000046B4
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 3;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000064D4 File Offset: 0x000046D4
		public override void WriteEndAttribute()
		{
			int num = this.NewEvent();
			this.pageCurr.o = 4;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000064F4 File Offset: 0x000046F4
		public override void WriteCData(string text)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 5;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006514 File Offset: 0x00004714
		public override void WriteComment(string text)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 6;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006534 File Offset: 0x00004734
		public override void WriteProcessingInstruction(string name, string text)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 7;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006554 File Offset: 0x00004754
		public override void WriteWhitespace(string ws)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 8;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006574 File Offset: 0x00004774
		public override void WriteString(string text)
		{
			if (this.pages != null)
			{
				int num = this.NewEvent();
				XmlEventCache.XmlEvent[] array = this.pageCurr;
				int num2 = 9;
				array.o = num2;
				return;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000065A4 File Offset: 0x000047A4
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000065B4 File Offset: 0x000047B4
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000065C4 File Offset: 0x000047C4
		public override void WriteRaw(string data)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 10;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000065E8 File Offset: 0x000047E8
		public override void WriteEntityRef(string name)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 11;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000660C File Offset: 0x0000480C
		public override void WriteCharEntity(char ch)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 12;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006630 File Offset: 0x00004830
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 13;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006654 File Offset: 0x00004854
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			byte[] array = XmlEventCache.ToBytes(buffer, index, count);
			int num = this.NewEvent();
			this.pageCurr.o = 14;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006680 File Offset: 0x00004880
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			byte[] array = XmlEventCache.ToBytes(buffer, index, count);
			int num = this.NewEvent();
			this.pageCurr.o = 15;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000066AC File Offset: 0x000048AC
		public override void Close()
		{
			int num = this.NewEvent();
			this.pageCurr.o = 23;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000066D0 File Offset: 0x000048D0
		public override void Flush()
		{
			int num = this.NewEvent();
			this.pageCurr.o = 24;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000066F4 File Offset: 0x000048F4
		public override void WriteValue(string value)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006704 File Offset: 0x00004904
		protected override void Dispose(bool disposing)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 25;
			base.Dispose(disposing);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00006750 File Offset: 0x00004950
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 16;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006774 File Offset: 0x00004974
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 17;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006798 File Offset: 0x00004998
		internal override void StartElementContent()
		{
			int num = this.NewEvent();
			this.pageCurr.o = 18;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000067BC File Offset: 0x000049BC
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 19;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000067E0 File Offset: 0x000049E0
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 20;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006804 File Offset: 0x00004A04
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			int num = this.NewEvent();
			this.pageCurr.o = 21;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006828 File Offset: 0x00004A28
		internal override void WriteEndBase64()
		{
			int num = this.NewEvent();
			this.pageCurr.o = 22;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000684C File Offset: 0x00004A4C
		private void AddEvent(XmlEventCache.XmlEventType eventType)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000686C File Offset: 0x00004A6C
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000688C File Offset: 0x00004A8C
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000068AC File Offset: 0x00004AAC
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000068CC File Offset: 0x00004ACC
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000068EC File Offset: 0x00004AEC
		private void AddEvent(XmlEventCache.XmlEventType eventType, object o)
		{
			int num = this.NewEvent();
			this.pageCurr.o = eventType;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00003FFD File Offset: 0x000021FD
		private int NewEvent()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000690C File Offset: 0x00004B0C
		private static byte[] ToBytes(byte[] buffer, int index, int count)
		{
			/*
An exception occurred when decompiling this method (060001C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Xml.XmlEventCache::ToBytes(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:uint8[][exp:bool](buffer))
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

		// Token: 0x040000AD RID: 173
		private List<XmlEventCache.XmlEvent[]> pages;

		// Token: 0x040000AE RID: 174
		private XmlEventCache.XmlEvent[] pageCurr;

		// Token: 0x040000AF RID: 175
		private int pageSize;

		// Token: 0x040000B0 RID: 176
		private bool hasRootNode;

		// Token: 0x040000B1 RID: 177
		private StringConcat singleText;

		// Token: 0x040000B2 RID: 178
		private string baseUri;

		// Token: 0x02000035 RID: 53
		private enum XmlEventType
		{
			// Token: 0x040000B4 RID: 180
			Unknown,
			// Token: 0x040000B5 RID: 181
			DocType,
			// Token: 0x040000B6 RID: 182
			StartElem,
			// Token: 0x040000B7 RID: 183
			StartAttr,
			// Token: 0x040000B8 RID: 184
			EndAttr,
			// Token: 0x040000B9 RID: 185
			CData,
			// Token: 0x040000BA RID: 186
			Comment,
			// Token: 0x040000BB RID: 187
			PI,
			// Token: 0x040000BC RID: 188
			Whitespace,
			// Token: 0x040000BD RID: 189
			String,
			// Token: 0x040000BE RID: 190
			Raw,
			// Token: 0x040000BF RID: 191
			EntRef,
			// Token: 0x040000C0 RID: 192
			CharEnt,
			// Token: 0x040000C1 RID: 193
			SurrCharEnt,
			// Token: 0x040000C2 RID: 194
			Base64,
			// Token: 0x040000C3 RID: 195
			BinHex,
			// Token: 0x040000C4 RID: 196
			XmlDecl1,
			// Token: 0x040000C5 RID: 197
			XmlDecl2,
			// Token: 0x040000C6 RID: 198
			StartContent,
			// Token: 0x040000C7 RID: 199
			EndElem,
			// Token: 0x040000C8 RID: 200
			FullEndElem,
			// Token: 0x040000C9 RID: 201
			Nmsp,
			// Token: 0x040000CA RID: 202
			EndBase64,
			// Token: 0x040000CB RID: 203
			Close,
			// Token: 0x040000CC RID: 204
			Flush,
			// Token: 0x040000CD RID: 205
			Dispose
		}

		// Token: 0x02000036 RID: 54
		private struct XmlEvent
		{
			// Token: 0x060001C6 RID: 454 RVA: 0x00006920 File Offset: 0x00004B20
			public void InitEvent(XmlEventCache.XmlEventType eventType)
			{
				this.eventType = eventType;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00006934 File Offset: 0x00004B34
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1)
			{
				this.eventType = eventType;
				this.s1 = s1;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00006950 File Offset: 0x00004B50
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00006974 File Offset: 0x00004B74
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
				this.s3 = s3;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x000069A0 File Offset: 0x00004BA0
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
				this.s3 = s3;
				this.o = o;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x000069D4 File Offset: 0x00004BD4
			public void InitEvent(XmlEventCache.XmlEventType eventType, object o)
			{
				this.eventType = eventType;
				this.o = o;
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00003FFD File Offset: 0x000021FD
			public XmlEventCache.XmlEventType EventType
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060001CD RID: 461 RVA: 0x000069F0 File Offset: 0x00004BF0
			public string String1
			{
				get
				{
					return this.s1;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00006A04 File Offset: 0x00004C04
			public string String2
			{
				get
				{
					return this.s2;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00006A18 File Offset: 0x00004C18
			public string String3
			{
				get
				{
					return this.s3;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00006A2C File Offset: 0x00004C2C
			public object Object
			{
				get
				{
					return this.o;
				}
			}

			// Token: 0x040000CE RID: 206
			private XmlEventCache.XmlEventType eventType;

			// Token: 0x040000CF RID: 207
			private string s1;

			// Token: 0x040000D0 RID: 208
			private string s2;

			// Token: 0x040000D1 RID: 209
			private string s3;

			// Token: 0x040000D2 RID: 210
			private object o;
		}
	}
}
