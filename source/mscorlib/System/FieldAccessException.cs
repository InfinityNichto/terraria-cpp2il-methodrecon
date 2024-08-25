using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0000FA30 File Offset: 0x0000DC30
		public FieldAccessException()
			: base("Attempted to access a field that is not accessible by the caller.")
		{
			this._HResult = 5383;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000FA54 File Offset: 0x0000DC54
		public FieldAccessException(string message)
			: base(message)
		{
			this._HResult = 5383;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000FA74 File Offset: 0x0000DC74
		protected FieldAccessException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
