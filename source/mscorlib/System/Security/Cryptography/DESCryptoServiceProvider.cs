using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002D5 RID: 725
	[ComVisible(true)]
	public sealed class DESCryptoServiceProvider : DES
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x00034398 File Offset: 0x00032598
		public DESCryptoServiceProvider()
		{
			if (!true)
			{
			}
			base..ctor();
			if (!true)
			{
			}
			long num = 0L;
			bool flag = Utils.HasAlgorithm(26113, (int)num);
			this.FeedbackSizeValue = 8;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000343D4 File Offset: 0x000325D4
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (", HasRightShoulderButton=" == null)
			{
			}
			bool flag = DES.IsWeakKey(rgbKey);
			if (", HasRightShoulderButton=" == null)
			{
			}
			bool flag2 = DES.IsSemiWeakKey(rgbKey);
			return "Specified key is a known weak key for '{0}' and cannot be used.";
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00034410 File Offset: 0x00032610
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (!true)
			{
			}
			bool flag = DES.IsWeakKey(rgbKey);
			if (!true)
			{
			}
			bool flag2 = DES.IsSemiWeakKey(rgbKey);
			return "Specified key is a known weak key for '{0}' and cannot be used.";
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00034444 File Offset: 0x00032644
		public override void GenerateKey()
		{
			if (!true)
			{
			}
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
			byte[] keyValue = this.KeyValue;
			bool flag = DES.IsWeakKey(this.KeyValue);
			bool flag2 = DES.IsSemiWeakKey(this.KeyValue);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00034480 File Offset: 0x00032680
		public override void GenerateIV()
		{
			if (!true)
			{
			}
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
			byte[] ivvalue = this.IVValue;
		}
	}
}
