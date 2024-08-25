using System;
using Cpp2IlInjected;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200001E RID: 30
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	public static class UnsafeUtility
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000021B3 File Offset: 0x000003B3
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002268 File Offset: 0x00000468
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002278 File Offset: 0x00000478
		public static int SizeOf<T>() where T : struct
		{
			return 2;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002288 File Offset: 0x00000488
		private static bool IsBlittableValueType(Type t)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000229C File Offset: 0x0000049C
		private static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			return string.Format("{0} is not blittable because it is not of value type ({1})\n", t, name);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022D4 File Offset: 0x000004D4
		internal static bool IsArrayBlittable(Array arr)
		{
			Type type;
			return UnsafeUtility.IsBlittableValueType(type);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022E8 File Offset: 0x000004E8
		internal static string GetReasonForArrayNonBlittable(Array arr)
		{
			string text;
			return text;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021B3 File Offset: 0x000003B3
		public static int AlignOf<T>() where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022F8 File Offset: 0x000004F8
		[ThreadSafe(ThrowsException = true)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000230C File Offset: 0x0000050C
		[ThreadSafe(ThrowsException = true)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002320 File Offset: 0x00000520
		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002334 File Offset: 0x00000534
		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002348 File Offset: 0x00000548
		public unsafe static void MemClear(void* destination, long size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000235C File Offset: 0x0000055C
		[ThreadSafe]
		public static bool IsBlittable(Type type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0200001F RID: 31
		private struct AlignOfHelper<T> where T : struct
		{
			// Token: 0x04000048 RID: 72
			public byte dummy;

			// Token: 0x04000049 RID: 73
			public T data;
		}
	}
}
