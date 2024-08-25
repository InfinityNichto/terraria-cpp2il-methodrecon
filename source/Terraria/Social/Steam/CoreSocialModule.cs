using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Terraria.Social.Steam
{
	// Token: 0x02000511 RID: 1297
	public class CoreSocialModule : ISocialModule
	{
		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600314C RID: 12620 RVA: 0x001F7D48 File Offset: 0x001F5F48
		// (remove) Token: 0x0600314D RID: 12621 RVA: 0x001F7D60 File Offset: 0x001F5F60
		public static event Action OnTick
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x001F7D78 File Offset: 0x001F5F78
		public static void SetSkipPulsing(bool shouldSkipPausing)
		{
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x001F7D88 File Offset: 0x001F5F88
		public void Initialize()
		{
			this.IsSteamValid = true;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x001F7D9C File Offset: 0x001F5F9C
		public void PulseSteamTick()
		{
			bool flag = Monitor.TryEnter(this._steamTickLock);
			Monitor.Pulse(this._steamTickLock);
			Monitor.Exit(this._steamTickLock);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x001F7DCC File Offset: 0x001F5FCC
		public void PulseSteamCallback()
		{
			bool flag = Monitor.TryEnter(this._steamCallbackLock);
			Monitor.Pulse(this._steamCallbackLock);
			Monitor.Exit(this._steamCallbackLock);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x001F7DFC File Offset: 0x001F5FFC
		public static void Pulse()
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x001F7E0C File Offset: 0x001F600C
		private void SteamTickLoop(object context)
		{
			do
			{
				Monitor.Enter(this._steamTickLock);
				if (!this.IsSteamValid)
				{
					break;
				}
				bool flag = Monitor.Wait(this._steamTickLock);
			}
			while (this.IsSteamValid);
			Monitor.Exit(this._steamTickLock);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x001F7E4C File Offset: 0x001F604C
		private void SteamCallbackLoop(object context)
		{
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x001F7E5C File Offset: 0x001F605C
		public void Shutdown()
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x001F7E6C File Offset: 0x001F606C
		public CoreSocialModule()
		{
		}

		// Token: 0x04003B11 RID: 15121
		private static CoreSocialModule _instance;

		// Token: 0x04003B12 RID: 15122
		public const int SteamAppId = 105600;

		// Token: 0x04003B13 RID: 15123
		private bool IsSteamValid;

		// Token: 0x04003B14 RID: 15124
		[CompilerGenerated]
		private static Action OnTick;

		// Token: 0x04003B15 RID: 15125
		private object _steamTickLock;

		// Token: 0x04003B16 RID: 15126
		private object _steamCallbackLock;

		// Token: 0x04003B17 RID: 15127
		private bool _skipPulsing;
	}
}
