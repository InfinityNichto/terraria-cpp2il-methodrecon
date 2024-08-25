using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000017 RID: 23
	internal struct RuntimePropertyHandle
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000024C8 File Offset: 0x000006C8
		internal RuntimePropertyHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000207A File Offset: 0x0000027A
		public IntPtr Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000024DC File Offset: 0x000006DC
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

		// Token: 0x06000055 RID: 85 RVA: 0x00002508 File Offset: 0x00000708
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0400008F RID: 143
		private IntPtr value;
	}
}
