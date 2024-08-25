using System;
using System.Globalization;
using System.Text;

namespace System.Xml.Linq
{
	// Token: 0x02000018 RID: 24
	public abstract class XNode : XObject
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00003918 File Offset: 0x00001B18
		internal XNode()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000392C File Offset: 0x00001B2C
		public void Remove()
		{
			XContainer parent;
			do
			{
				parent = this.parent;
			}
			while (parent == null);
			parent.RemoveNode(this);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000394C File Offset: 0x00001B4C
		public override string ToString()
		{
			SaveOptions saveOptionsFromAnnotations = base.GetSaveOptionsFromAnnotations();
			return this.GetXmlString(saveOptionsFromAnnotations);
		}

		// Token: 0x060000AF RID: 175
		public abstract void WriteTo(XmlWriter writer);

		// Token: 0x060000B0 RID: 176 RVA: 0x00003968 File Offset: 0x00001B68
		internal virtual void AppendText(StringBuilder sb)
		{
		}

		// Token: 0x060000B1 RID: 177
		internal abstract XNode CloneNode();

		// Token: 0x060000B2 RID: 178 RVA: 0x00003978 File Offset: 0x00001B78
		private string GetXmlString(SaveOptions o)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (this != null)
			{
			}
			long num = 0L;
			int num2 = 6;
			XmlWriter xmlWriter;
			if (xmlWriter != null)
			{
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000040 RID: 64
		internal XNode next;
	}
}
