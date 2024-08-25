using System;

namespace ReLogic.Content
{
	// Token: 0x02000B3E RID: 2878
	public class ContentRejectionFromFailedLoad_ByAssetExtensionType : IRejectionReason
	{
		// Token: 0x060053DA RID: 21466 RVA: 0x00285060 File Offset: 0x00283260
		public string GetReason()
		{
			return "Only textures of type '.png' and '.xnb' may be loaded.";
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00285074 File Offset: 0x00283274
		public ContentRejectionFromFailedLoad_ByAssetExtensionType()
		{
		}
	}
}
