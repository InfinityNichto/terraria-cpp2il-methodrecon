using System;
using System.ComponentModel;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	[Obsolete("Not supported anymore.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IMask
	{
		// Token: 0x06000184 RID: 388
		bool Enabled();

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000185 RID: 389
		RectTransform rectTransform { get; }
	}
}
