using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006D RID: 109
	[Preserve]
	internal static class MathUtils
	{
		// Token: 0x060003DB RID: 987 RVA: 0x0000AD4C File Offset: 0x00008F4C
		public static int IntLength(ulong i)
		{
			return 1;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000212A File Offset: 0x0000032A
		public static char IntToHex(int n)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public static int? Min(int? val1, int? val2)
		{
			return val1;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public static int? Max(int? val1, int? val2)
		{
			return val1;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public static double? Max(double? val1, double? val2)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public static bool ApproxEquals(double d1, double d2)
		{
			return true;
		}
	}
}
