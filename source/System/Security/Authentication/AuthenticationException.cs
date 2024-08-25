using System;
using System.Runtime.Serialization;

namespace System.Security.Authentication
{
	// Token: 0x020000E4 RID: 228
	[Serializable]
	public class AuthenticationException : SystemException
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x00014F24 File Offset: 0x00013124
		public AuthenticationException()
		{
			string text = Locale.GetText("Authentication exception.");
			base..ctor(text);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00014F44 File Offset: 0x00013144
		public AuthenticationException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00014F5C File Offset: 0x0001315C
		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}
	}
}
