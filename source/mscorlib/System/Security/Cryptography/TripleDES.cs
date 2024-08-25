using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000309 RID: 777
	[ComVisible(true)]
	public abstract class TripleDES : SymmetricAlgorithm
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x000385F0 File Offset: 0x000367F0
		protected TripleDES()
		{
			this.PaddingValue = PaddingMode.PKCS7;
			if (2 == 0)
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00038610 File Offset: 0x00036810
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00038644 File Offset: 0x00036844
		public override byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					bool flag = TripleDES.IsWeakKey(this.KeyValue);
					byte[] keyValue = this.KeyValue;
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (value != null)
				{
					bool flag = TripleDES.IsWeakKey(value);
					object obj;
					if (obj != null)
					{
						if (obj != null)
						{
							this.KeyValue = obj;
							if (obj != null)
							{
								return;
							}
						}
						throw new InvalidCastException();
					}
					return;
				}
				string resourceString = Environment.GetResourceString("Specified key is not a valid size for this algorithm.");
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000207A File Offset: 0x0000027A
		public new static TripleDES Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0003868C File Offset: 0x0003688C
		public new static TripleDES Create(string str)
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

		// Token: 0x06001A49 RID: 6729 RVA: 0x000386A4 File Offset: 0x000368A4
		public static bool IsWeakKey(byte[] rgbKey)
		{
			if (!true)
			{
			}
			long num = 0L;
			byte[] array;
			bool flag = TripleDES.EqualBytes(array, (int)num, 8, 8);
			return true;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000386DC File Offset: 0x000368DC
		private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count)
		{
			string resourceString = Environment.GetResourceString("Value was invalid.");
			string resourceString2 = Environment.GetResourceString("Non-negative number required.");
			return "start1" != null;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00038714 File Offset: 0x00036914
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return true;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00038724 File Offset: 0x00036924
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDES()
		{
		}

		// Token: 0x04000D34 RID: 3380
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000D35 RID: 3381
		private static KeySizes[] s_legalKeySizes;
	}
}
