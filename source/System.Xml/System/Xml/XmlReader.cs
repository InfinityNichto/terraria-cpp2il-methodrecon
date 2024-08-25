using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Schema;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000039 RID: 57
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlReader : IDisposable
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00006D58 File Offset: 0x00004F58
		public virtual XmlReaderSettings Settings
		{
			get
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FE RID: 510
		public abstract XmlNodeType NodeType { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000200 RID: 512
		public abstract string LocalName { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000201 RID: 513
		public abstract string NamespaceURI { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000202 RID: 514
		public abstract string Prefix { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000203 RID: 515
		public abstract string Value { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000204 RID: 516
		public abstract string BaseURI { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000205 RID: 517
		public abstract bool IsEmptyElement { get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00006D68 File Offset: 0x00004F68
		public virtual bool IsDefault
		{
			get
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00003FFD File Offset: 0x000021FD
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000208 RID: 520
		public abstract bool MoveToAttribute(string name);

		// Token: 0x06000209 RID: 521
		public abstract bool MoveToFirstAttribute();

		// Token: 0x0600020A RID: 522
		public abstract bool MoveToNextAttribute();

		// Token: 0x0600020B RID: 523
		public abstract bool MoveToElement();

		// Token: 0x0600020C RID: 524
		public abstract bool ReadAttributeValue();

		// Token: 0x0600020D RID: 525
		public abstract bool Read();

		// Token: 0x0600020E RID: 526 RVA: 0x00006D78 File Offset: 0x00004F78
		public virtual void Close()
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020F RID: 527
		public abstract ReadState ReadState { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000210 RID: 528
		public abstract XmlNameTable NameTable { get; }

		// Token: 0x06000211 RID: 529
		public abstract string LookupNamespace(string prefix);

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00006D88 File Offset: 0x00004F88
		public virtual bool CanResolveEntity
		{
			get
			{
			}
		}

		// Token: 0x06000213 RID: 531
		public abstract void ResolveEntity();

		// Token: 0x06000214 RID: 532 RVA: 0x00006D98 File Offset: 0x00004F98
		public void Dispose()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006DA8 File Offset: 0x00004FA8
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00006DB8 File Offset: 0x00004FB8
		internal virtual IDtdInfo DtdInfo
		{
			get
			{
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006DC8 File Offset: 0x00004FC8
		internal static int CalcBufferSize(Stream input)
		{
			return 4096;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00006DDC File Offset: 0x00004FDC
		protected XmlReader()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00006DF0 File Offset: 0x00004FF0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReader()
		{
		}

		// Token: 0x040000DF RID: 223
		private static uint IsTextualNodeBitmap;

		// Token: 0x040000E0 RID: 224
		private static uint CanReadContentAsBitmap;

		// Token: 0x040000E1 RID: 225
		private static uint HasValueBitmap;
	}
}
