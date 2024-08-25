using System;
using System.Globalization;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x02000038 RID: 56
	public class SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00007D30 File Offset: 0x00005F30
		public SubjectKeyIdentifierExtension(X509Extension extension)
			: base(extension)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00007D44 File Offset: 0x00005F44
		protected override void Decode()
		{
			byte[] value = this.extnValue.Value;
			byte[] array;
			this.ski = array;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007D64 File Offset: 0x00005F64
		protected override void Encode()
		{
			while (this.ski == null)
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00007D7C File Offset: 0x00005F7C
		public override string Name
		{
			get
			{
				return "Subject Key Identifier";
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00007D90 File Offset: 0x00005F90
		public byte[] Identifier
		{
			get
			{
				object obj;
				if (this.ski == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public override string ToString()
		{
			if (this.ski != null)
			{
				byte[] array = this.ski;
				if (", HasRightShoulderButton=" == null)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				byte[] array2 = this.ski;
				return;
			}
		}

		// Token: 0x040000CC RID: 204
		private byte[] ski;
	}
}
