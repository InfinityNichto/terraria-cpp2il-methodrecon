using System;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000004 RID: 4
	public sealed class AesCryptoServiceProvider : Aes
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002250 File Offset: 0x00000450
		public AesCryptoServiceProvider()
		{
			if (!true)
			{
			}
			base..ctor();
			this.FeedbackSizeValue = 8;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002270 File Offset: 0x00000470
		public override void GenerateIV()
		{
			int blockSizeValue = this.BlockSizeValue;
			byte[] array;
			this.IVValue = array;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000228C File Offset: 0x0000048C
		public override void GenerateKey()
		{
			int keySizeValue = this.KeySizeValue;
			byte[] array;
			this.KeyValue = array;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022A8 File Offset: 0x000004A8
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000022B8 File Offset: 0x000004B8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000022CC File Offset: 0x000004CC
		public override byte[] IV
		{
			get
			{
				return base.IV;
			}
			set
			{
				base.IV = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000022F4 File Offset: 0x000004F4
		public override byte[] Key
		{
			get
			{
				return base.Key;
			}
			set
			{
				base.Key = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002308 File Offset: 0x00000508
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000231C File Offset: 0x0000051C
		public override int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				base.KeySize = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002330 File Offset: 0x00000530
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002344 File Offset: 0x00000544
		public override int FeedbackSize
		{
			get
			{
				return this.FeedbackSizeValue;
			}
			set
			{
				base.FeedbackSize = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000236C File Offset: 0x0000056C
		public override CipherMode Mode
		{
			get
			{
				return this.ModeValue;
			}
			set
			{
				base.Mode = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002380 File Offset: 0x00000580
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002394 File Offset: 0x00000594
		public override PaddingMode Padding
		{
			get
			{
				return this.PaddingValue;
			}
			set
			{
				base.Padding = value;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		public override ICryptoTransform CreateDecryptor()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		public override ICryptoTransform CreateEncryptor()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023A8 File Offset: 0x000005A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
	}
}
