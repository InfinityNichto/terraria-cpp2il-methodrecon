using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200031A RID: 794
	internal class TripleDESTransform : SymmetricTransform
	{
		// Token: 0x06001AEF RID: 6895 RVA: 0x0003A27C File Offset: 0x0003847C
		public TripleDESTransform(TripleDES algo, bool encryption, byte[] key, byte[] iv)
		{
			int num = 1;
			base..ctor(algo, encryption, iv);
			byte[] strongKey;
			if (key == null)
			{
				strongKey = TripleDESTransform.GetStrongKey();
			}
			if (num == 0)
			{
			}
			bool flag = TripleDES.IsWeakKey(strongKey);
			DES des = DES.Create();
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0003A2C8 File Offset: 0x000384C8
		protected override void ECB(byte[] input, byte[] output)
		{
			if (!true)
			{
			}
			bool encrypt = this.encrypt;
			if (encrypt)
			{
				this.E1.ProcessBlock(output, output);
				this.D2.ProcessBlock(output, output);
				return;
			}
			this.D1.ProcessBlock(output, output);
			this.E2.ProcessBlock(output, output);
			if (!encrypt)
			{
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0003A31C File Offset: 0x0003851C
		internal static byte[] GetStrongKey()
		{
			if (!true)
			{
			}
			byte[] array = KeyBuilder.Key(1073741824);
			bool flag = TripleDES.IsWeakKey(array);
			return array;
		}

		// Token: 0x04000DB5 RID: 3509
		private DESTransform E1;

		// Token: 0x04000DB6 RID: 3510
		private DESTransform D2;

		// Token: 0x04000DB7 RID: 3511
		private DESTransform E3;

		// Token: 0x04000DB8 RID: 3512
		private DESTransform D1;

		// Token: 0x04000DB9 RID: 3513
		private DESTransform E2;

		// Token: 0x04000DBA RID: 3514
		private DESTransform D3;
	}
}
