using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002D4 RID: 724
	[ComVisible(true)]
	public abstract class DES : SymmetricAlgorithm
	{
		// Token: 0x06001866 RID: 6246 RVA: 0x00034228 File Offset: 0x00032428
		protected DES()
		{
			this.KeySizeValue = 64;
			if (64 == 0)
			{
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00034248 File Offset: 0x00032448
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x00034288 File Offset: 0x00032488
		public override byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					bool flag = DES.IsWeakKey(this.KeyValue);
					bool flag2 = DES.IsSemiWeakKey(this.KeyValue);
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
					if (!true)
					{
					}
					bool flag = DES.IsWeakKey(value);
					if (!true)
					{
					}
					bool flag2 = DES.IsSemiWeakKey(value);
					object obj;
					if (obj != null)
					{
						if (obj != null)
						{
							this.KeyValue = obj;
							if (obj != null)
							{
								goto IL_002D;
							}
						}
						throw new InvalidCastException();
					}
					IL_002D:
					this.KeySizeValue = 1;
					return;
				}
				string resourceString = Environment.GetResourceString("Specified key is not a valid size for this algorithm.");
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0000207A File Offset: 0x0000027A
		public new static DES Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000342E4 File Offset: 0x000324E4
		public new static DES Create(string algName)
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

		// Token: 0x0600186B RID: 6251 RVA: 0x000342FC File Offset: 0x000324FC
		public static bool IsWeakKey(byte[] rgbKey)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00034334 File Offset: 0x00032534
		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00034374 File Offset: 0x00032574
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return true;
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0000207A File Offset: 0x0000027A
		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00034384 File Offset: 0x00032584
		// Note: this type is marked as 'beforefieldinit'.
		static DES()
		{
		}

		// Token: 0x04000CA3 RID: 3235
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000CA4 RID: 3236
		private static KeySizes[] s_legalKeySizes;
	}
}
