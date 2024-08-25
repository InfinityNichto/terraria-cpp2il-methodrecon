using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000D4 RID: 212
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public class InvalidTimeZoneException : Exception
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x00012B50 File Offset: 0x00010D50
		public InvalidTimeZoneException()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00012B68 File Offset: 0x00010D68
		public InvalidTimeZoneException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00012B80 File Offset: 0x00010D80
		protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
