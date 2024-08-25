using System;
using System.Collections;
using System.Reflection;

namespace System.Xml
{
	// Token: 0x0200007C RID: 124
	[DefaultMember("ItemOf")]
	public abstract class XmlNodeList : IEnumerable, IDisposable
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005FA RID: 1530
		public abstract int Count { get; }

		// Token: 0x060005FB RID: 1531
		public abstract IEnumerator GetEnumerator();

		// Token: 0x060005FC RID: 1532 RVA: 0x00014574 File Offset: 0x00012774
		void IDisposable.Dispose()
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00014584 File Offset: 0x00012784
		protected virtual void PrivateDisposeNodeList()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00014594 File Offset: 0x00012794
		protected XmlNodeList()
		{
		}
	}
}
