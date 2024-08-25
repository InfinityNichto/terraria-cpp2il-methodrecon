using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	// Token: 0x02000016 RID: 22
	[RequiredByNativeCode]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable>
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000246C File Offset: 0x0000066C
		internal AnimationScriptPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000247C File Offset: 0x0000067C
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002490 File Offset: 0x00000690
		public bool Equals(AnimationScriptPlayable other)
		{
			PlayableHandle handle = this.m_Handle;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024A8 File Offset: 0x000006A8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationScriptPlayable()
		{
			if (!true)
			{
			}
			PlayableHandle @null = PlayableHandle.Null;
		}

		// Token: 0x04000041 RID: 65
		private PlayableHandle m_Handle;

		// Token: 0x04000042 RID: 66
		private static readonly AnimationScriptPlayable m_NullPlayable;
	}
}
