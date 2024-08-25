using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000AB RID: 171
	internal sealed class Gen2GcCallback : CriticalFinalizerObject
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0000FB48 File Offset: 0x0000DD48
		private Gen2GcCallback()
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000FB5C File Offset: 0x0000DD5C
		public static void Register(Func<object, bool> callback, object targetObj)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		private void Setup(Func<object, bool> callback, object targetObj)
		{
			this._callback = callback;
			GCHandle gchandle;
			this._weakTargetObj = gchandle;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000FB88 File Offset: 0x0000DD88
		protected override void Finalize()
		{
			object obj;
			if (obj != null)
			{
				Func<object, bool> callback = this._callback;
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				GC.ReRegisterForFinalize(this);
				return;
			}
			base.Finalize();
		}

		// Token: 0x0400026D RID: 621
		private Func<object, bool> _callback;

		// Token: 0x0400026E RID: 622
		private GCHandle _weakTargetObj;
	}
}
