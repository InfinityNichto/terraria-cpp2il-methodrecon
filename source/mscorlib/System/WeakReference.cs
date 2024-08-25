using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020001A4 RID: 420
	[ComVisible(true)]
	[Serializable]
	public class WeakReference : ISerializable
	{
		// Token: 0x06000FF9 RID: 4089 RVA: 0x00022114 File Offset: 0x00020314
		private void AllocateHandle(object target)
		{
			bool flag = this.isLongReference;
			GCHandle gchandle;
			this.gcHandle = gchandle;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00022130 File Offset: 0x00020330
		protected WeakReference()
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00022144 File Offset: 0x00020344
		public WeakReference(object target)
		{
			this.AllocateHandle(target);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00022160 File Offset: 0x00020360
		public WeakReference(object target, bool trackResurrection)
		{
			this.AllocateHandle(target);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002217C File Offset: 0x0002037C
		protected WeakReference(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor();
			}
			while (info == null);
			object obj;
			this.AllocateHandle(obj);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool IsAlive
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0002219C File Offset: 0x0002039C
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x000221AC File Offset: 0x000203AC
		public virtual object Target
		{
			get
			{
				object obj;
				return obj;
			}
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000221BC File Offset: 0x000203BC
		public virtual bool TrackResurrection
		{
			get
			{
				return this.isLongReference;
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000221D0 File Offset: 0x000203D0
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00022204 File Offset: 0x00020404
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info != null)
			{
				info.AddValue("TrackedObject", this);
				return;
			}
		}

		// Token: 0x040008A8 RID: 2216
		private bool isLongReference;

		// Token: 0x040008A9 RID: 2217
		private GCHandle gcHandle;
	}
}
