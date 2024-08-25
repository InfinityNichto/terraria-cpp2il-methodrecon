using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000013 RID: 19
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00008")]
	[Serializable]
	public class SfxGenerationException : ZipException
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002680 File Offset: 0x00000880
		public SfxGenerationException()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002694 File Offset: 0x00000894
		public SfxGenerationException(string message)
			: base(message)
		{
		}
	}
}
