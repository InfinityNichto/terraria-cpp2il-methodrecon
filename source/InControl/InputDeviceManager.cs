using System;
using System.Collections.Generic;

namespace InControl
{
	// Token: 0x02000031 RID: 49
	public abstract class InputDeviceManager
	{
		// Token: 0x0600024E RID: 590
		public abstract void Update(ulong updateTick, float deltaTime);

		// Token: 0x0600024F RID: 591 RVA: 0x00007A8C File Offset: 0x00005C8C
		public virtual void Destroy()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007A9C File Offset: 0x00005C9C
		protected InputDeviceManager()
		{
		}

		// Token: 0x0400024D RID: 589
		protected readonly List<InputDevice> devices;
	}
}
