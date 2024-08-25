using System;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00023BD0 File Offset: 0x00021DD0
		public ProtocolViolationException()
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00023BE4 File Offset: 0x00021DE4
		public ProtocolViolationException(string message)
			: base(message)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00023BF8 File Offset: 0x00021DF8
		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00023C10 File Offset: 0x00021E10
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00023C28 File Offset: 0x00021E28
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
