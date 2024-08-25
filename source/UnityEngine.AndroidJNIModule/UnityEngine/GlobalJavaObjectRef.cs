using System;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	internal class GlobalJavaObjectRef
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000034DC File Offset: 0x000016DC
		public GlobalJavaObjectRef(IntPtr jobject)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003500 File Offset: 0x00001700
		protected override void Finalize()
		{
			this.Dispose();
			base.Finalize();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000353A File Offset: 0x0000173A
		public static implicit operator IntPtr(GlobalJavaObjectRef obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003548 File Offset: 0x00001748
		public void Dispose()
		{
			if (!this.m_disposed)
			{
				this.m_disposed = true;
				IntPtr jobject = this.m_jobject;
				AndroidJNISafe.DeleteGlobalRef(this.m_jobject);
				return;
			}
		}

		// Token: 0x04000002 RID: 2
		private bool m_disposed;

		// Token: 0x04000003 RID: 3
		protected IntPtr m_jobject;
	}
}
