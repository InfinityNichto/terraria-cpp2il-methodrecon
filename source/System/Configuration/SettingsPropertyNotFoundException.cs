using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	// Token: 0x020004AA RID: 1194
	[Serializable]
	public class SettingsPropertyNotFoundException : Exception
	{
		// Token: 0x0600201B RID: 8219 RVA: 0x00052B70 File Offset: 0x00050D70
		public SettingsPropertyNotFoundException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00052B84 File Offset: 0x00050D84
		protected SettingsPropertyNotFoundException(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00052B98 File Offset: 0x00050D98
		public SettingsPropertyNotFoundException(string message)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00052BAC File Offset: 0x00050DAC
		public SettingsPropertyNotFoundException(string message, Exception innerException)
		{
			throw new NotSupportedException();
		}
	}
}
