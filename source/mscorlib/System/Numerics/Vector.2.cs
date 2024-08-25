using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Numerics
{
	// Token: 0x0200052D RID: 1325
	[Intrinsic]
	public static class Vector
	{
		// Token: 0x06002727 RID: 10023 RVA: 0x0000207A File Offset: 0x0000027A
		public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x00054C3C File Offset: 0x00052E3C
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
