using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public sealed class WeakReference<T> : ISerializable where T : class
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00022228 File Offset: 0x00020428
		public WeakReference(T target)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00022238 File Offset: 0x00020438
		public WeakReference(T target, bool trackResurrection)
		{
			long num = 0L;
			base..ctor();
			this.trackResurrection = num != 0L;
			GCHandle gchandle;
			this.handle = gchandle;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0002225C File Offset: 0x0002045C
		private WeakReference(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor();
			}
			while (info == null);
			bool boolean = info.GetBoolean("TrackResurrection");
			this.trackResurrection = "TrackResurrection" != null;
			Type type;
			object value = info.GetValue("TrackedObject", type);
			bool flag = this.trackResurrection;
			GCHandle gchandle;
			this.handle = gchandle;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000222A8 File Offset: 0x000204A8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			bool flag = this.trackResurrection;
			info.AddValue("TrackResurrection", flag);
			object obj;
			info.AddValue("TrackedObject", obj);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000222D8 File Offset: 0x000204D8
		public void SetTarget(T target)
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000222E8 File Offset: 0x000204E8
		public bool TryGetTarget([Out] T target)
		{
			object obj;
			if (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00022310 File Offset: 0x00020510
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x040008AA RID: 2218
		private GCHandle handle;

		// Token: 0x040008AB RID: 2219
		private bool trackResurrection;
	}
}
