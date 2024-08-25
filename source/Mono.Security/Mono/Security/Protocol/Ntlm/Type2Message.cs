using System;
using System.Text;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000040 RID: 64
	public class Type2Message : MessageBase
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000855C File Offset: 0x0000675C
		public Type2Message(byte[] message)
		{
			if (!true)
			{
			}
			base..ctor();
			this._type = 2;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000857C File Offset: 0x0000677C
		protected override void Finalize()
		{
			if (this._nonce != null)
			{
			}
			base.Finalize();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000085B8 File Offset: 0x000067B8
		public byte[] Nonce
		{
			get
			{
				byte[] nonce = this._nonce;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000085D8 File Offset: 0x000067D8
		public string TargetName
		{
			get
			{
				return this._targetName;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000085EC File Offset: 0x000067EC
		public byte[] TargetInfo
		{
			get
			{
				byte[] targetInfo = this._targetInfo;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000860C File Offset: 0x0000680C
		protected override void Decode(byte[] message)
		{
			base.Decode(message);
			uint num = BitConverterLE.ToUInt32(message, 20);
			byte[] nonce = this._nonce;
			this._flags = (NtlmFlags)num;
			long num2 = 0L;
			Buffer.BlockCopy(message, 24, nonce, (int)num2, 8);
			ushort num3 = BitConverterLE.ToUInt16(message, 12);
			ushort num4 = BitConverterLE.ToUInt16(message, 16);
			NtlmFlags flags = this._flags;
			Encoding unicode = Encoding.Unicode;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008694 File Offset: 0x00006894
		public override byte[] GetBytes()
		{
			byte[] array = base.PrepareMessage(40);
			NtlmFlags flags = this._flags;
			NtlmFlags flags2 = this._flags;
			byte[] nonce = this._nonce;
			return array;
		}

		// Token: 0x040000EB RID: 235
		private byte[] _nonce;

		// Token: 0x040000EC RID: 236
		private string _targetName;

		// Token: 0x040000ED RID: 237
		private byte[] _targetInfo;
	}
}
