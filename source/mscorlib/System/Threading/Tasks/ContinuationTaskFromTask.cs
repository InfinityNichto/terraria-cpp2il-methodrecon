using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000241 RID: 577
	internal sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x00029FBC File Offset: 0x000281BC
		public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			if (!true)
			{
			}
			Task task = Task.InternalCurrentIfAttached(creationOptions);
			this.m_antecedent = antecedent;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00029FDC File Offset: 0x000281DC
		internal override void InnerInvoke()
		{
			bool flag = this.m_antecedent.NotifyDebuggerOfWaitCompletionIfNecessary();
			Delegate action = this.m_action;
			if (action != null)
			{
				IntPtr method_code = action.method_code;
				IntPtr invoke_impl = action.invoke_impl;
				IntPtr method = action.method;
				return;
			}
			Delegate action2 = this.m_action;
			if (action2 != null)
			{
				IntPtr method_code2 = action2.method_code;
				object stateObject = this.m_stateObject;
				IntPtr invoke_impl2 = action2.invoke_impl;
				IntPtr method2 = action2.method;
				return;
			}
		}

		// Token: 0x04000AA4 RID: 2724
		private Task m_antecedent;
	}
}
