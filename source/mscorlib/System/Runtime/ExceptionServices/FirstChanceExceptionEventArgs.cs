using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x0200045A RID: 1114
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0004CA90 File Offset: 0x0004AC90
		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return this.<Exception>k__BackingField;
			}
		}

		// Token: 0x04001294 RID: 4756
		[CompilerGenerated]
		private readonly Exception <Exception>k__BackingField;
	}
}
