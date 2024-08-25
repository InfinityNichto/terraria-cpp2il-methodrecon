using System;

namespace System.Diagnostics
{
	// Token: 0x020000D4 RID: 212
	[SwitchLevel(typeof(TraceLevel))]
	public class TraceSwitch : Switch
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00013D5C File Offset: 0x00011F5C
		public TraceSwitch(string displayName, string description)
		{
			if ("Shadow Key" == null)
			{
			}
			base..ctor(displayName, description);
		}
	}
}
