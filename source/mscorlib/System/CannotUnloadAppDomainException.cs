using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200012F RID: 303
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x0001A490 File Offset: 0x00018690
		public CannotUnloadAppDomainException()
			: base("Attempt to unload the AppDomain failed.")
		{
			this._HResult = 4117;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0001A4B4 File Offset: 0x000186B4
		public CannotUnloadAppDomainException(string message)
			: base(message)
		{
			this._HResult = 4117;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0001A4D4 File Offset: 0x000186D4
		protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
