using System;
using System.Runtime.InteropServices;

namespace ReLogic.Content
{
	// Token: 0x02000B3B RID: 2875
	public interface IContentValidator
	{
		// Token: 0x060053D3 RID: 21459
		bool AssetIsValid<T>(T content, string contentPath, [Out] IRejectionReason rejectionReason) where T : class;
	}
}
