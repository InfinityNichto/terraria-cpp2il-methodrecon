using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000063 RID: 99
	public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x00011474 File Offset: 0x0000F674
		internal XmlAttributeCollection(XmlNode parent)
			: base(parent)
		{
		}

		// Token: 0x170000F2 RID: 242
		[IndexerName("ItemOf")]
		public XmlAttribute this[int i]
		{
			get
			{
				object obj;
				if (obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000114AC File Offset: 0x0000F6AC
		public override XmlNode SetNamedItem(XmlNode node)
		{
			int num;
			return base.RemoveNodeAt(num);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000114D4 File Offset: 0x0000F6D4
		public XmlAttribute Append(XmlAttribute node)
		{
			if (node != null)
			{
				this.InsertParentIntoElementIdAttrMap(node);
				XmlNode parent = this.parent;
			}
			if (node != null)
			{
			}
			return node;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00011504 File Offset: 0x0000F704
		public XmlAttribute Remove(XmlAttribute node)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00011514 File Offset: 0x0000F714
		public XmlAttribute RemoveAt(int i)
		{
			while (this == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001152C File Offset: 0x0000F72C
		public void RemoveAll()
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001153C File Offset: 0x0000F73C
		void ICollection.CopyTo(Array array, int index)
		{
			long num = 0L;
			long num2 = 0L;
			array.SetValue(num, (int)num2);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00011558 File Offset: 0x0000F758
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00003FFD File Offset: 0x000021FD
		object ICollection.SyncRoot
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00011568 File Offset: 0x0000F768
		int ICollection.Count
		{
			get
			{
				return base.Count;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001157C File Offset: 0x0000F77C
		internal override XmlNode AddNode(XmlNode node)
		{
			if (node != null)
			{
			}
			XmlNode xmlNode = base.AddNode(node);
			if (node != null)
			{
			}
			return xmlNode;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000115A0 File Offset: 0x0000F7A0
		internal override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			XmlNode xmlNode = base.InsertNodeAt(i, node);
			if (node != null)
			{
			}
			return xmlNode;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000115C4 File Offset: 0x0000F7C4
		internal override XmlNode RemoveNodeAt(int i)
		{
			XmlNode xmlNode = base.RemoveNodeAt(i);
			if (xmlNode != null)
			{
			}
			XmlNode parent = this.parent;
			if (this.parent != null)
			{
			}
			XmlAttribute xmlAttribute;
			if (xmlAttribute != null)
			{
			}
			return xmlNode;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000115FC File Offset: 0x0000F7FC
		internal void Detach(XmlAttribute attr)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001160C File Offset: 0x0000F80C
		internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
			XmlNode parent = this.parent;
			if (parent != null)
			{
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00011678 File Offset: 0x0000F878
		internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
			XmlNode parent = this.parent;
			if (parent != null)
			{
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000116EC File Offset: 0x0000F8EC
		internal int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			object obj;
			if (obj != null)
			{
			}
			int num;
			XmlNode xmlNode = base.RemoveNodeAt(num);
			return num;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001170C File Offset: 0x0000F90C
		internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			if (this.parent != null)
			{
			}
			XmlName xmlName;
			if (xmlName != null)
			{
				bool flag = xmlName.prefix == attrPrefix;
				bool flag2 = xmlName.localName == attrPrefix;
				return;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00011744 File Offset: 0x0000F944
		internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
			if (this.parent != null)
			{
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001175C File Offset: 0x0000F95C
		internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			XmlNode xmlNode = base.AddNode(node);
			this.InsertParentIntoElementIdAttrMap(node);
			if (xmlNode != null)
			{
			}
			throw new InvalidCastException();
		}
	}
}
