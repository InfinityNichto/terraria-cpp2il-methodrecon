using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		// Token: 0x060003CE RID: 974 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public ArgumentNullException()
			: base("Value cannot be null.")
		{
			this._HResult = 16387;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		public ArgumentNullException(string paramName)
			: base("Value cannot be null.")
		{
			this._paramName = paramName;
			this._HResult = 16387;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public ArgumentNullException(string paramName, string message)
			: base(message)
		{
			this._paramName = paramName;
			this._HResult = 16387;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		protected ArgumentNullException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
