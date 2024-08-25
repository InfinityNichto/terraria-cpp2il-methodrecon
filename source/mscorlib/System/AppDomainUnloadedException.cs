using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200012E RID: 302
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x0001A454 File Offset: 0x00018654
		public AppDomainUnloadedException()
			: base("Attempted to access an unloaded AppDomain.")
		{
			this._HResult = 4116;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0001A478 File Offset: 0x00018678
		protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
