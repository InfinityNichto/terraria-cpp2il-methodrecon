using System;

namespace System.Diagnostics
{
	// Token: 0x020000C7 RID: 199
	[SwitchLevel(typeof(bool))]
	public class BooleanSwitch : Switch
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x00013494 File Offset: 0x00011694
		public BooleanSwitch(string displayName, string description)
		{
			if (!true)
			{
			}
			base..ctor(displayName, description);
		}
	}
}
