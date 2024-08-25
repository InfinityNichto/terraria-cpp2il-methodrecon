using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000016 RID: 22
	internal struct RuntimeEventHandle
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002478 File Offset: 0x00000678
		internal RuntimeEventHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000207A File Offset: 0x0000027A
		public IntPtr Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000248C File Offset: 0x0000068C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				Type type = obj.GetType();
				Type type2;
				bool flag = type2 != type;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000024B8 File Offset: 0x000006B8
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0400008E RID: 142
		private IntPtr value;
	}
}
