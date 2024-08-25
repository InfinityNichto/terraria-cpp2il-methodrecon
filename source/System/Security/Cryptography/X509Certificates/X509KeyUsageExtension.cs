using System;
using Cpp2IlInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200011B RID: 283
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00018850 File Offset: 0x00016A50
		public X509KeyUsageExtension()
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00018864 File Offset: 0x00016A64
		public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
		{
			byte[] raw = encodedKeyUsage._raw;
			this._critical = true;
			this._raw = raw;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001889C File Offset: 0x00016A9C
		public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
		{
			this._critical = true;
			this._keyUsages = X509KeyUsageFlags.EncipherOnly;
			byte[] array = this.Encode();
			base.RawData = array;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000188CC File Offset: 0x00016ACC
		public X509KeyUsageFlags KeyUsages
		{
			get
			{
				AsnDecodeStatus status = this._status;
				return this._keyUsages;
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000188E8 File Offset: 0x00016AE8
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			while (asnEncodedData == null)
			{
			}
			if (asnEncodedData._oid != null)
			{
				return;
			}
			byte[] raw = asnEncodedData._raw;
			base.RawData = raw;
			byte[] raw2 = this._raw;
			this._critical = "2.5.29.15" != null;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw2);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001893C File Offset: 0x00016B3C
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			int num = 1;
			if (extension == null || num != 0)
			{
				return;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00018964 File Offset: 0x00016B64
		internal byte[] Encode()
		{
			if (this._keyUsages != X509KeyUsageFlags.None)
			{
				return;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00018980 File Offset: 0x00016B80
		internal override string ToString(bool multiLine)
		{
			AsnDecodeStatus status = this._status;
			byte[] raw = this._raw;
			string text;
			return text;
		}

		// Token: 0x0400052F RID: 1327
		internal const string oid = "2.5.29.15";

		// Token: 0x04000530 RID: 1328
		internal const string friendlyName = "Key Usage";

		// Token: 0x04000531 RID: 1329
		internal const X509KeyUsageFlags all = X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly;

		// Token: 0x04000532 RID: 1330
		private X509KeyUsageFlags _keyUsages;

		// Token: 0x04000533 RID: 1331
		private AsnDecodeStatus _status;
	}
}
