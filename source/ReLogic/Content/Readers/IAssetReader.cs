using System;
using System.IO;

namespace ReLogic.Content.Readers
{
	// Token: 0x02000B52 RID: 2898
	public interface IAssetReader
	{
		// Token: 0x06005458 RID: 21592
		T FromStream<T>(Stream stream) where T : class;
	}
}
