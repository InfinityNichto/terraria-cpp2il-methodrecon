using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	// Token: 0x020004A9 RID: 1193
	[Serializable]
	public class SettingsPropertyIsReadOnlyException : Exception
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00052B20 File Offset: 0x00050D20
		public SettingsPropertyIsReadOnlyException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00052B34 File Offset: 0x00050D34
		protected SettingsPropertyIsReadOnlyException(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00052B48 File Offset: 0x00050D48
		public SettingsPropertyIsReadOnlyException(string message)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00052B5C File Offset: 0x00050D5C
		public SettingsPropertyIsReadOnlyException(string message, Exception innerException)
		{
			throw new NotSupportedException();
		}
	}
}
