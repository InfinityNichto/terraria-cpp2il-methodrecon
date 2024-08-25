using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A4 RID: 1188
	internal static class Unsafe
	{
		// Token: 0x060022B0 RID: 8880 RVA: 0x0000207A File Offset: 0x0000027A
		public static T Add<T>(T source, int elementOffset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0000207A File Offset: 0x0000027A
		public static T Add<T>(T source, IntPtr elementOffset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0000207A File Offset: 0x0000027A
		public unsafe static void* Add<T>(void* source, int elementOffset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x0000207A File Offset: 0x0000027A
		public static T AddByteOffset<T>(T source, IntPtr byteOffset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool AreSame<T>(T left, T right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0000207A File Offset: 0x0000027A
		public static T As<T>(object o) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0000207A File Offset: 0x0000027A
		public static TTo As<TTo, TFrom>(TFrom source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0000207A File Offset: 0x0000027A
		public unsafe static void* AsPointer<T>(T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000207A File Offset: 0x0000027A
		public unsafe static T AsRef<T>(void* source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0000207A File Offset: 0x0000027A
		public static T AsRef<T>([In] T source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
		public static void InitBlockUnaligned(byte startAddress, byte value, uint byteCount)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0000207A File Offset: 0x0000027A
		public unsafe static T Read<T>(void* source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0000207A File Offset: 0x0000027A
		public static T ReadUnaligned<T>(byte source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
		public static int SizeOf<T>()
		{
			return 16;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
		public static void WriteUnaligned<T>(byte destination, T value)
		{
			destination.m_value = value;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool IsAddressLessThan<T>(T left, T right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0000207A File Offset: 0x0000027A
		internal static T AddByteOffset<T>(T source, ulong byteOffset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
