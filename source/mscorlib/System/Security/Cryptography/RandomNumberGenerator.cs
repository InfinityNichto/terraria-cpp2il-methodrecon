using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002E9 RID: 745
	[ComVisible(true)]
	public abstract class RandomNumberGenerator : IDisposable
	{
		// Token: 0x060018FE RID: 6398 RVA: 0x00035988 File Offset: 0x00033B88
		protected RandomNumberGenerator()
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0000207A File Offset: 0x0000027A
		public static RandomNumberGenerator Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0003599C File Offset: 0x00033B9C
		public static RandomNumberGenerator Create(string rngName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000359B4 File Offset: 0x00033BB4
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000359C8 File Offset: 0x00033BC8
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001903 RID: 6403
		public abstract void GetBytes(byte[] data);

		// Token: 0x06001904 RID: 6404 RVA: 0x000359D8 File Offset: 0x00033BD8
		public virtual void GetBytes(byte[] data, int offset, int count)
		{
			if (data != null)
			{
				return;
			}
			string resourceString = Environment.GetResourceString("Non-negative number required.");
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void GetNonZeroBytes(byte[] data)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00035A10 File Offset: 0x00033C10
		public static void Fill(Span<byte> data)
		{
			RandomNumberGenerator.FillSpan(data);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00035A24 File Offset: 0x00033C24
		internal static void FillSpan(Span<byte> data)
		{
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00035A34 File Offset: 0x00033C34
		public virtual void GetBytes(Span<byte> data)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (this != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return;
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00035A60 File Offset: 0x00033C60
		public virtual void GetNonZeroBytes(Span<byte> data)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00035A8C File Offset: 0x00033C8C
		public static int GetInt32(int fromInclusive, int toExclusive)
		{
			return fromInclusive;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00035A9C File Offset: 0x00033C9C
		public static int GetInt32(int toExclusive)
		{
			return RandomNumberGenerator.GetInt32(0, toExclusive);
		}
	}
}
