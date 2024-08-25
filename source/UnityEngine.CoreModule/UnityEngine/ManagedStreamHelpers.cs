using System;
using System.IO;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C2 RID: 194
	internal static class ManagedStreamHelpers
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00006D68 File Offset: 0x00004F68
		internal static void ValidateLoadFromStream(Stream stream)
		{
			if (stream != null)
			{
				return;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00006D7C File Offset: 0x00004F7C
		[RequiredByNativeCode]
		internal unsafe static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
		{
			ManagedStreamHelpers.ValidateLoadFromStream(stream);
			void* ptr = (void*)returnValueAddress;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00006D98 File Offset: 0x00004F98
		[RequiredByNativeCode]
		internal unsafe static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
		{
			ManagedStreamHelpers.ValidateLoadFromStream(stream);
			void* ptr = (void*)returnValueAddress;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00006DB4 File Offset: 0x00004FB4
		[RequiredByNativeCode]
		internal unsafe static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
		{
			ManagedStreamHelpers.ValidateLoadFromStream(stream);
			void* ptr = (void*)returnValueAddress;
		}
	}
}
