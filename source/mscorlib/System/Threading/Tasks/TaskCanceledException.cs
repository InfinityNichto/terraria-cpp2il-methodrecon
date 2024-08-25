using System;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	// Token: 0x02000217 RID: 535
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x00027BA0 File Offset: 0x00025DA0
		public TaskCanceledException()
			: base("A task was canceled.")
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00027BB8 File Offset: 0x00025DB8
		public TaskCanceledException(Task task)
		{
			if (task != null)
			{
				CancellationToken cancellationToken = task.m_contingentProperties.m_cancellationToken;
				return;
			}
			this._canceledTask = task;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00027BDC File Offset: 0x00025DDC
		protected TaskCanceledException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000A1B RID: 2587
		[NonSerialized]
		private readonly Task _canceledTask;
	}
}
