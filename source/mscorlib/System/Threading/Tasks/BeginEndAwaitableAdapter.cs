using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000223 RID: 547
	internal sealed class BeginEndAwaitableAdapter : RendezvousAwaitable<IAsyncResult>
	{
		// Token: 0x06001312 RID: 4882 RVA: 0x0002816C File Offset: 0x0002636C
		public BeginEndAwaitableAdapter()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00028184 File Offset: 0x00026384
		// Note: this type is marked as 'beforefieldinit'.
		static BeginEndAwaitableAdapter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000A33 RID: 2611
		public static readonly AsyncCallback Callback;

		// Token: 0x02000224 RID: 548
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001314 RID: 4884 RVA: 0x00028194 File Offset: 0x00026394
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001315 RID: 4885 RVA: 0x000281A4 File Offset: 0x000263A4
			public <>c()
			{
			}

			// Token: 0x06001316 RID: 4886 RVA: 0x000281B8 File Offset: 0x000263B8
			internal void <.cctor>b__2_0(IAsyncResult asyncResult)
			{
			}

			// Token: 0x04000A34 RID: 2612
			public static readonly BeginEndAwaitableAdapter.<>c <>9;
		}
	}
}
