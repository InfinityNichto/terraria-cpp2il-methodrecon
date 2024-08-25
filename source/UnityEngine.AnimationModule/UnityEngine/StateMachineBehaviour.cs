using System;
using UnityEngine.Animations;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002264 File Offset: 0x00000464
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002274 File Offset: 0x00000474
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002284 File Offset: 0x00000484
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002294 File Offset: 0x00000494
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022A4 File Offset: 0x000004A4
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000022B4 File Offset: 0x000004B4
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000022C4 File Offset: 0x000004C4
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022D4 File Offset: 0x000004D4
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022E4 File Offset: 0x000004E4
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022F4 File Offset: 0x000004F4
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002304 File Offset: 0x00000504
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002314 File Offset: 0x00000514
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002324 File Offset: 0x00000524
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002334 File Offset: 0x00000534
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002344 File Offset: 0x00000544
		protected StateMachineBehaviour()
		{
		}
	}
}
