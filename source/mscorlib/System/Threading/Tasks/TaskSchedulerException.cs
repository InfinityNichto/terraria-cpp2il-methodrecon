using System;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class TaskSchedulerException : Exception
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x00027CF0 File Offset: 0x00025EF0
		public TaskSchedulerException()
		{
			if (!true)
			{
			}
			base..ctor("An exception was thrown by a TaskScheduler.");
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00027D0C File Offset: 0x00025F0C
		public TaskSchedulerException(Exception innerException)
		{
			if (!true)
			{
			}
			base..ctor("An exception was thrown by a TaskScheduler.", innerException);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00027D28 File Offset: 0x00025F28
		protected TaskSchedulerException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
