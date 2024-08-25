using System;
using System.Runtime.Serialization;

namespace System.Resources
{
	// Token: 0x020004A6 RID: 1190
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		// Token: 0x060022C3 RID: 8899 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		public MissingManifestResourceException()
			: base("Unable to find manifest resource.")
		{
			this._HResult = 5426;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0004E00C File Offset: 0x0004C20C
		public MissingManifestResourceException(string message)
			: base(message)
		{
			this._HResult = 5426;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0004E02C File Offset: 0x0004C22C
		protected MissingManifestResourceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
