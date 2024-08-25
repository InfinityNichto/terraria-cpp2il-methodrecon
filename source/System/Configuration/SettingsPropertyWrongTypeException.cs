using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	// Token: 0x020004AB RID: 1195
	[Serializable]
	public class SettingsPropertyWrongTypeException : Exception
	{
		// Token: 0x0600201F RID: 8223 RVA: 0x00052BC0 File Offset: 0x00050DC0
		public SettingsPropertyWrongTypeException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00052BD4 File Offset: 0x00050DD4
		protected SettingsPropertyWrongTypeException(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00052BE8 File Offset: 0x00050DE8
		public SettingsPropertyWrongTypeException(string message)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00052BFC File Offset: 0x00050DFC
		public SettingsPropertyWrongTypeException(string message, Exception innerException)
		{
			throw new NotSupportedException();
		}
	}
}
