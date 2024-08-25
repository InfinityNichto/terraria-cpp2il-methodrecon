using System;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x0200053C RID: 1340
	internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x06002784 RID: 10116 RVA: 0x00055A38 File Offset: 0x00053C38
		internal PinnedBufferMemoryStream(byte[] array)
		{
			this._array = array;
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			this._pinningHandle = gchandle;
			Span span;
			!0 reference = MemoryMarshal.GetReference(span);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00055A68 File Offset: 0x00053C68
		public override int Read(Span<byte> buffer)
		{
			return base.ReadCore(buffer);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00055A7C File Offset: 0x00053C7C
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			base.WriteCore(buffer);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00055A90 File Offset: 0x00053C90
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00055AC4 File Offset: 0x00053CC4
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0400158E RID: 5518
		private byte[] _array;

		// Token: 0x0400158F RID: 5519
		private GCHandle _pinningHandle;
	}
}
