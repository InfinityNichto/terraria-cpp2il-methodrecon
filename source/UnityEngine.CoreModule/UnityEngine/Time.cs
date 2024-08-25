using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	[NativeHeader("Runtime/Input/TimeManager.h")]
	[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
	public class Time
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00005B2C File Offset: 0x00003D2C
		public static float deltaTime
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00005B40 File Offset: 0x00003D40
		public static float unscaledTime
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00005B54 File Offset: 0x00003D54
		public static float unscaledDeltaTime
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00005B68 File Offset: 0x00003D68
		public static float fixedDeltaTime
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00005B90 File Offset: 0x00003D90
		public static float timeScale
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public static int frameCount
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00005BB8 File Offset: 0x00003DB8
		[NativeProperty("Realtime")]
		public static float realtimeSinceStartup
		{
			get
			{
				throw new MissingMethodException();
			}
		}
	}
}
