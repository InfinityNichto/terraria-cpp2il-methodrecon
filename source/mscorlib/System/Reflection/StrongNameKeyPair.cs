using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000518 RID: 1304
	[ComVisible(true)]
	[Serializable]
	public class StrongNameKeyPair : ISerializable, IDeserializationCallback
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x00054060 File Offset: 0x00052260
		protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("_publicKey", type);
			if (value != null)
			{
				if (value != null)
				{
					this._publicKey = value;
					if (value != null)
					{
						goto IL_002C;
					}
				}
				throw new InvalidCastException();
			}
			IL_002C:
			string @string = info.GetString("_keyPairContainer");
			this._keyPairContainer = @string;
			bool boolean = info.GetBoolean("_keyPairExported");
			this._keyPairExported = "_keyPairContainer" != null;
			Type type2;
			object value2 = info.GetValue("_keyPairArray", type2);
			if (value2 != null)
			{
				if (value2 == null)
				{
					throw new InvalidCastException();
				}
				this._keyPairArray = value2;
				if (value2 == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000540F4 File Offset: 0x000522F4
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			byte[] publicKey = this._publicKey;
			if (!true)
			{
			}
			Type type;
			info.AddValue("_publicKey", publicKey, type);
			string keyPairContainer = this._keyPairContainer;
			info.AddValue("_keyPairContainer", keyPairContainer);
			bool keyPairExported = this._keyPairExported;
			info.AddValue("_keyPairExported", keyPairExported);
			byte[] keyPairArray = this._keyPairArray;
			Type type2;
			info.AddValue("_keyPairArray", keyPairArray, type2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00054158 File Offset: 0x00052358
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		// Token: 0x04001512 RID: 5394
		private byte[] _publicKey;

		// Token: 0x04001513 RID: 5395
		private string _keyPairContainer;

		// Token: 0x04001514 RID: 5396
		private bool _keyPairExported;

		// Token: 0x04001515 RID: 5397
		private byte[] _keyPairArray;
	}
}
