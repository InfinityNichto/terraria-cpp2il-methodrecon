using System;

namespace System.Collections.Generic
{
	// Token: 0x02000432 RID: 1074
	public sealed class LinkedListNode<T>
	{
		// Token: 0x06001D23 RID: 7459 RVA: 0x0004F108 File Offset: 0x0004D308
		internal LinkedListNode(LinkedList<T> list, T value)
		{
			this.list = list;
			this.item = value;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0004F12C File Offset: 0x0004D32C
		public LinkedListNode<T> Next
		{
			get
			{
				if (this.next != null)
				{
					LinkedListNode head = this.list.head;
					return this;
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0004F150 File Offset: 0x0004D350
		public T Value
		{
			get
			{
				return this.item;
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0004F164 File Offset: 0x0004D364
		internal void Invalidate()
		{
		}

		// Token: 0x040013E4 RID: 5092
		internal LinkedList<T> list;

		// Token: 0x040013E5 RID: 5093
		internal LinkedListNode<T> next;

		// Token: 0x040013E6 RID: 5094
		internal LinkedListNode<T> prev;

		// Token: 0x040013E7 RID: 5095
		internal T item;
	}
}
