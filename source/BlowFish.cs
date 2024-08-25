using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x020002DC RID: 732
public class BlowFish
{
	// Token: 0x060010D0 RID: 4304 RVA: 0x000533F8 File Offset: 0x000515F8
	public BlowFish()
	{
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0005340C File Offset: 0x0005160C
	private void ROUND(BlowFish.aword a, BlowFish.aword b, int n)
	{
		uint[] parray = this.PArray;
		uint[] sboxes = this.SBoxes;
		byte @byte = b.byte1;
		byte byte2 = b.byte0;
		byte byte3 = b.byte2;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00053440 File Offset: 0x00051640
	private unsafe void Decipher(uint* xl, uint* xr)
	{
		uint[] parray = this.PArray;
		uint[] sboxes = this.SBoxes;
		xl->m_value = sboxes;
		xr->m_value = parray;
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0005346C File Offset: 0x0005166C
	private unsafe void Encipher(uint* xl, uint* xr)
	{
		uint[] parray = this.PArray;
		uint[] sboxes = this.SBoxes;
		int num = 256;
		xr->m_value = (uint)num;
		xl->m_value = parray;
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0005349C File Offset: 0x0005169C
	public void Initialize(byte[] key)
	{
		int num = 1;
		uint[] parray = this.PArray;
		if (num == 0)
		{
		}
		uint[] sboxes = this.SBoxes;
		uint[] parray2 = this.PArray;
		uint[] parray3 = this.PArray;
		uint[] sboxes2 = this.SBoxes;
		int num2 = 1;
		this.isInitialized = num2 != 0;
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x000021DB File Offset: 0x000003DB
	private uint GetOutputLength(uint lInputLong)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x000534F8 File Offset: 0x000516F8
	public unsafe void Decode(byte* pInput, byte* pOutput, uint lSize)
	{
		if (lSize != 0U)
		{
			return;
		}
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0005350C File Offset: 0x0005170C
	// Note: this type is marked as 'beforefieldinit'.
	static BlowFish()
	{
	}

	// Token: 0x040020B0 RID: 8368
	private const int NPASS = 16;

	// Token: 0x040020B1 RID: 8369
	private static uint[] bf_P;

	// Token: 0x040020B2 RID: 8370
	private static uint[] bf_S;

	// Token: 0x040020B3 RID: 8371
	private uint[] PArray;

	// Token: 0x040020B4 RID: 8372
	private uint[] SBoxes;

	// Token: 0x040020B5 RID: 8373
	public bool isInitialized;

	// Token: 0x020002DD RID: 733
	[StructLayout(2)]
	private struct aword
	{
		// Token: 0x040020B6 RID: 8374
		public uint dword;

		// Token: 0x040020B7 RID: 8375
		[FixedBuffer(typeof(byte), 4)]
		public BlowFish.aword.<integer>e__FixedBuffer integer;

		// Token: 0x040020B8 RID: 8376
		public byte byte3;

		// Token: 0x040020B9 RID: 8377
		public byte byte2;

		// Token: 0x040020BA RID: 8378
		public byte byte1;

		// Token: 0x040020BB RID: 8379
		public byte byte0;

		// Token: 0x020002DE RID: 734
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(0, Size = 4)]
		public struct <integer>e__FixedBuffer
		{
			// Token: 0x040020BC RID: 8380
			public byte FixedElementField;
		}
	}
}
