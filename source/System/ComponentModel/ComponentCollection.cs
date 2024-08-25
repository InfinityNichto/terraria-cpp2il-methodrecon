using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x02000332 RID: 818
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x0004009C File Offset: 0x0003E29C
		public ComponentCollection(IComponent[] components)
		{
			ArrayList innerList = base.InnerList;
		}

		// Token: 0x170004DF RID: 1247
		public virtual IComponent this[string name]
		{
			get
			{
				if (name != null)
				{
					ArrayList innerList = base.InnerList;
				}
				long value = 0.m_value;
				while (this == null)
				{
				}
				if (this != null)
				{
					while (this == null)
					{
					}
					while (this == null)
					{
					}
					long num = 0L;
					if (this != null)
					{
					}
					if (num != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170004E0 RID: 1248
		public virtual IComponent this[int index]
		{
			get
			{
				ArrayList innerList = base.InnerList;
				if (innerList == null || innerList != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0004012C File Offset: 0x0003E32C
		public void CopyTo(IComponent[] array, int index)
		{
			ArrayList innerList = base.InnerList;
		}
	}
}
