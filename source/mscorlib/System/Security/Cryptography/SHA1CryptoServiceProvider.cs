using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x02000319 RID: 793
	[ComVisible(true)]
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x0003A1C8 File Offset: 0x000383C8
		public SHA1CryptoServiceProvider()
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0003A1DC File Offset: 0x000383DC
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0003A210 File Offset: 0x00038410
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0003A224 File Offset: 0x00038424
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			SHA1Internal sha1Internal = this.sha;
			this.State = 1;
			sha1Internal.HashCore(rgb, ibStart, cbSize);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0003A248 File Offset: 0x00038448
		protected override byte[] HashFinal()
		{
			return this.sha.HashFinal();
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0003A260 File Offset: 0x00038460
		public override void Initialize()
		{
			uint[] h = this.sha._H;
		}

		// Token: 0x04000DB4 RID: 3508
		private SHA1Internal sha;
	}
}
