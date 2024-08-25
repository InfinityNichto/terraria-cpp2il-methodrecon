using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using InControl;

namespace Controller
{
	// Token: 0x02000B60 RID: 2912
	public class ControllerDeviceManager : Singleton<ControllerDeviceManager>
	{
		// Token: 0x06005496 RID: 21654 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateConnectedControllers(float elapsedTime, bool forceUpdate = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x000021DB File Offset: 0x000003DB
		private void UpdateDevices(float elapsedTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x002865D4 File Offset: 0x002847D4
		public ControllerDeviceManager()
		{
		}

		// Token: 0x04008D87 RID: 36231
		private int lastFrame = 1;

		// Token: 0x04008D88 RID: 36232
		public List<ControllerDevice> AttachedDevices;

		// Token: 0x04008D89 RID: 36233
		private List<ControllerDevice> _deviceUpdateList;

		// Token: 0x04008D8A RID: 36234
		private List<UnityInputDevice> _joyConUpdateList;

		// Token: 0x04008D8B RID: 36235
		public List<ControllerDevice> UnconfiguredList;

		// Token: 0x04008D8C RID: 36236
		private List<ControllerDevice> _unconfiguredUpdateList;

		// Token: 0x04008D8D RID: 36237
		public List<ControllerDevice> ActiveControllers;
	}
}
