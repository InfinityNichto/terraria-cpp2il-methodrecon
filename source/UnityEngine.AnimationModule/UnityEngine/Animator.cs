using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UsedByNativeCode]
	public class Animator : Behaviour
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000021C4 File Offset: 0x000003C4
		public void SetTrigger(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021D8 File Offset: 0x000003D8
		public void ResetTrigger(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021EC File Offset: 0x000003EC
		public AnimatorControllerParameter[] parameters
		{
			[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002200 File Offset: 0x00000400
		public int parameterCount
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002214 File Offset: 0x00000414
		public bool hasBoundPlayables
		{
			[NativeMethod("HasBoundPlayables")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002228 File Offset: 0x00000428
		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000223C File Offset: 0x0000043C
		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002250 File Offset: 0x00000450
		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name)
		{
			throw new MissingMethodException();
		}
	}
}
