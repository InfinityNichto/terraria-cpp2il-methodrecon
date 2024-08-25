using System;

namespace InControl
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class InControlException : Exception
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x000058C0 File Offset: 0x00003AC0
		public InControlException()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000058D8 File Offset: 0x00003AD8
		public InControlException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000058F0 File Offset: 0x00003AF0
		public InControlException(string message, Exception inner)
		{
			if (!true)
			{
			}
			base..ctor(message, inner);
		}
	}
}
