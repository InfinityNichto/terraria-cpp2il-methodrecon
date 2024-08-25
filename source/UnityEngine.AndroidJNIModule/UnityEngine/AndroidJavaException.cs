using System;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public sealed class AndroidJavaException : Exception
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00003498 File Offset: 0x00001698
		internal AndroidJavaException(string message, string javaStackTrace)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this.mJavaStackTrace = javaStackTrace;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000034B8 File Offset: 0x000016B8
		public override string StackTrace
		{
			get
			{
				string text = this.mJavaStackTrace;
				string stackTrace = base.StackTrace;
				return text + stackTrace;
			}
		}

		// Token: 0x04000001 RID: 1
		private string mJavaStackTrace;
	}
}
