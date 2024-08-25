using System;

namespace System.ComponentModel
{
	// Token: 0x02000383 RID: 899
	public interface IIntellisenseBuilder
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001798 RID: 6040
		string Name { get; }

		// Token: 0x06001799 RID: 6041
		bool Show(string language, string value, string newValue);
	}
}
