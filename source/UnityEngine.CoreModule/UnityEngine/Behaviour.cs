using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[UsedByNativeCode]
	public class Behaviour : Component
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00005DF4 File Offset: 0x00003FF4
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00005E08 File Offset: 0x00004008
		[RequiredByNativeCode]
		[NativeProperty]
		public bool enabled
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00005E1C File Offset: 0x0000401C
		[NativeProperty]
		public bool isActiveAndEnabled
		{
			[NativeMethod("IsAddedToManager")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00005E30 File Offset: 0x00004030
		public Behaviour()
		{
		}
	}
}
