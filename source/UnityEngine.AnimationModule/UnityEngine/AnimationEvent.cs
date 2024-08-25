using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[RequiredByNativeCode]
	[Serializable]
	[StructLayout(0)]
	public sealed class AnimationEvent
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002198 File Offset: 0x00000398
		public AnimationEvent()
		{
			this.m_FunctionName = "";
			this.m_StringParameter = "";
		}

		// Token: 0x04000018 RID: 24
		internal float m_Time;

		// Token: 0x04000019 RID: 25
		internal string m_FunctionName;

		// Token: 0x0400001A RID: 26
		internal string m_StringParameter;

		// Token: 0x0400001B RID: 27
		internal Object m_ObjectReferenceParameter;

		// Token: 0x0400001C RID: 28
		internal float m_FloatParameter;

		// Token: 0x0400001D RID: 29
		internal int m_IntParameter;

		// Token: 0x0400001E RID: 30
		internal int m_MessageOptions;

		// Token: 0x0400001F RID: 31
		internal AnimationEventSource m_Source;

		// Token: 0x04000020 RID: 32
		internal AnimationState m_StateSender;

		// Token: 0x04000021 RID: 33
		internal AnimatorStateInfo m_AnimatorStateInfo;

		// Token: 0x04000022 RID: 34
		internal AnimatorClipInfo m_AnimatorClipInfo;
	}
}
