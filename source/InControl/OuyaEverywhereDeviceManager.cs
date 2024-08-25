using System;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000045 RID: 69
	public class OuyaEverywhereDeviceManager : InputDeviceManager
	{
		// Token: 0x0600035F RID: 863 RVA: 0x000025E1 File Offset: 0x000007E1
		public OuyaEverywhereDeviceManager()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public override void Update(ulong updateTick, float deltaTime)
		{
			if (this.devices != null)
			{
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public static void Enable()
		{
		}

		// Token: 0x040002ED RID: 749
		private bool[] deviceConnected;
	}
}
