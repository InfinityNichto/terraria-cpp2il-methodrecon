using System;

namespace System.Collections
{
	// Token: 0x020005EA RID: 1514
	public interface IList : ICollection, IEnumerable
	{
		// Token: 0x17000702 RID: 1794
		object this[int index] { get; set; }

		// Token: 0x06002DBE RID: 11710
		int Add(object value);

		// Token: 0x06002DBF RID: 11711
		bool Contains(object value);

		// Token: 0x06002DC0 RID: 11712
		void Clear();

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002DC1 RID: 11713
		bool IsReadOnly { get; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002DC2 RID: 11714
		bool IsFixedSize { get; }

		// Token: 0x06002DC3 RID: 11715
		int IndexOf(object value);

		// Token: 0x06002DC4 RID: 11716
		void Insert(int index, object value);

		// Token: 0x06002DC5 RID: 11717
		void Remove(object value);

		// Token: 0x06002DC6 RID: 11718
		void RemoveAt(int index);
	}
}
