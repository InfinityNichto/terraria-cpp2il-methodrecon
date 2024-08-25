using System;

namespace System.Xml.Schema
{
	// Token: 0x0200014B RID: 331
	public abstract class XmlSchemaObject
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001E59C File Offset: 0x0001C79C
		internal virtual void OnAdd(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		internal virtual void OnRemove(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		internal virtual void OnClear(XmlSchemaObjectCollection container)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001E5CC File Offset: 0x0001C7CC
		protected XmlSchemaObject()
		{
		}
	}
}
