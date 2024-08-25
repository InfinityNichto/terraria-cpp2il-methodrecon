using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000028 RID: 40
	internal struct SafeStringMarshal : IDisposable
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000207A File Offset: 0x0000027A
		private static IntPtr StringToUtf8_icall(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr StringToUtf8(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000025EC File Offset: 0x000007EC
		public static void GFree(IntPtr ptr)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000025FC File Offset: 0x000007FC
		public SafeStringMarshal(string str)
		{
			this.str = str;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002610 File Offset: 0x00000810
		public IntPtr Value
		{
			get
			{
				IntPtr intPtr = this.marshaled_string;
				bool flag;
				this.marshaled_string = flag;
				return this.marshaled_string;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002634 File Offset: 0x00000834
		public void Dispose()
		{
			IntPtr intPtr = this.marshaled_string;
			IntPtr intPtr2 = this.marshaled_string;
		}

		// Token: 0x040000BB RID: 187
		private readonly string str;

		// Token: 0x040000BC RID: 188
		private IntPtr marshaled_string;
	}
}
