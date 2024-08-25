using System;
using System.Globalization;
using System.Text;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000315 RID: 789
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x06001AC7 RID: 6855 RVA: 0x00039CC8 File Offset: 0x00037EC8
		static RNGCryptoServiceProvider()
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00039CD8 File Offset: 0x00037ED8
		public RNGCryptoServiceProvider()
		{
			long num = 0L;
			this._handle = num;
			this.Check();
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00039CFC File Offset: 0x00037EFC
		public RNGCryptoServiceProvider(byte[] rgb)
		{
			if (rgb != null)
			{
				return;
			}
			this._handle = rgb;
			this.Check();
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00039D20 File Offset: 0x00037F20
		public RNGCryptoServiceProvider(CspParameters cspParams)
		{
			long num = 0L;
			this._handle = num;
			this.Check();
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00039D44 File Offset: 0x00037F44
		public RNGCryptoServiceProvider(string str)
		{
			if (str == null)
			{
				return;
			}
			Encoding utf = Encoding.UTF8;
			if (utf != null)
			{
				CodePageDataItem dataItem = utf.dataItem;
				return;
			}
			long num = 0L;
			this._handle = num;
			this.Check();
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00039D80 File Offset: 0x00037F80
		private void Check()
		{
			IntPtr handle = this._handle;
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool RngOpen()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr RngInitialize(byte* seed, IntPtr seed_length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00039DA0 File Offset: 0x00037FA0
		private static void RngClose(IntPtr handle)
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00039DB0 File Offset: 0x00037FB0
		public override void GetBytes(byte[] data)
		{
			int num = 1;
			if (data != null)
			{
				if (num == 0)
				{
				}
				IntPtr handle = this._handle;
				long num2 = 0L;
				this._handle = handle;
				int num3 = 9;
				if (num2 == 0L)
				{
					if (num3 != 0)
					{
						return;
					}
					this.Check();
					return;
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00039E18 File Offset: 0x00038018
		internal unsafe void GetBytes(byte* data, IntPtr data_length)
		{
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				IntPtr handle = this._handle;
				long num = 0L;
				this._handle = handle;
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (3 != 0)
				{
					return;
				}
			}
			else
			{
				IntPtr handle2 = this._handle;
				this._handle = handle2;
			}
			this.Check();
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00039E7C File Offset: 0x0003807C
		public override void GetNonZeroBytes(byte[] data)
		{
			while (data == null)
			{
			}
			IntPtr handle = this._handle;
			this._handle = handle;
			this.Check();
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00039EA4 File Offset: 0x000380A4
		protected override void Finalize()
		{
			IntPtr handle = this._handle;
			IntPtr handle2 = this._handle;
			base.Finalize();
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00039EEC File Offset: 0x000380EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x04000DA8 RID: 3496
		private static object _lock;

		// Token: 0x04000DA9 RID: 3497
		private IntPtr _handle;
	}
}
