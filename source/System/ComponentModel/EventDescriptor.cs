using System;

namespace System.ComponentModel
{
	// Token: 0x02000373 RID: 883
	public abstract class EventDescriptor : MemberDescriptor
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x00042BC4 File Offset: 0x00040DC4
		protected EventDescriptor(string name, Attribute[] attrs)
			: base(name, attrs)
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00042BDC File Offset: 0x00040DDC
		protected EventDescriptor(MemberDescriptor descr)
			: base(descr)
		{
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00042BF0 File Offset: 0x00040DF0
		protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
			: base(descr, attrs)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600170B RID: 5899
		public abstract Type ComponentType { get; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600170C RID: 5900
		public abstract Type EventType { get; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600170D RID: 5901
		public abstract bool IsMulticast { get; }

		// Token: 0x0600170E RID: 5902
		public abstract void AddEventHandler(object component, Delegate value);

		// Token: 0x0600170F RID: 5903
		public abstract void RemoveEventHandler(object component, Delegate value);
	}
}
