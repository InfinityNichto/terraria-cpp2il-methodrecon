using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200003F RID: 63
	public class Type1Message : MessageBase
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x000083AC File Offset: 0x000065AC
		public Type1Message()
		{
			if (!true)
			{
			}
			base..ctor();
			this._type = 1;
			string userDomainName = Environment.UserDomainName;
			this._domain = userDomainName;
			string machineName = Environment.MachineName;
			this._host = machineName;
			this._flags = NtlmFlags.NegotiateUnicode | NtlmFlags.NegotiateOem | NtlmFlags.RequestTarget | NtlmFlags.NegotiateNtlm | NtlmFlags.NegotiateDomainSupplied | NtlmFlags.NegotiateWorkstationSupplied | NtlmFlags.NegotiateAlwaysSign;
		}

		// Token: 0x17000086 RID: 134
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000083F4 File Offset: 0x000065F4
		public string Domain
		{
			set
			{
				bool flag = value == "";
				NtlmFlags flags = this._flags;
				this._domain = value;
				this._flags = flags;
			}
		}

		// Token: 0x17000087 RID: 135
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00008424 File Offset: 0x00006624
		public string Host
		{
			set
			{
				bool flag = value == "";
				NtlmFlags flags = this._flags;
				this._host = value;
				this._flags = flags;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008454 File Offset: 0x00006654
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
			uint num = BitConverterLE.ToUInt32(message, 12);
			this._flags = (NtlmFlags)num;
			ushort num2 = BitConverterLE.ToUInt16(message, 16);
			ushort num3 = BitConverterLE.ToUInt16(message, 20);
			Encoding ascii = Encoding.ASCII;
			this._domain = ascii;
			ushort num4 = BitConverterLE.ToUInt16(message, 24);
			Encoding ascii2 = Encoding.ASCII;
			this._host = ascii2;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000084B8 File Offset: 0x000066B8
		public override byte[] GetBytes()
		{
			string host = this._host;
			string domain = this._domain;
			int stringLength = host._stringLength;
			int stringLength2 = domain._stringLength;
			NtlmFlags flags = this._flags;
			NtlmFlags flags2 = this._flags;
			Encoding ascii = Encoding.ASCII;
			string host2 = this._host;
			if (domain == null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = host2.ToUpper(invariantCulture);
			CodePageDataItem dataItem = ascii.dataItem;
			Encoding ascii2 = Encoding.ASCII;
			string domain2 = this._domain;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text2 = domain2.ToUpper(invariantCulture2);
			CodePageDataItem dataItem2 = ascii2.dataItem;
			byte[] array;
			return array;
		}

		// Token: 0x040000E9 RID: 233
		private string _host;

		// Token: 0x040000EA RID: 234
		private string _domain;
	}
}
