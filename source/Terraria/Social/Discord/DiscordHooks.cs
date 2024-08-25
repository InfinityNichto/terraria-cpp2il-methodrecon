using System;

namespace Terraria.Social.Discord
{
	// Token: 0x02000516 RID: 1302
	public class DiscordHooks
	{
		// Token: 0x06003170 RID: 12656 RVA: 0x001F82BC File Offset: 0x001F64BC
		public void RegisterTo(DiscordRpc.EventHandlers handlers)
		{
			DiscordRpc.OnJoinInfo onJoinInfo = handlers.joinCallback;
			Delegate @delegate;
			if (@delegate != null)
			{
				handlers.joinCallback = @delegate;
				return;
			}
			handlers.joinCallback = @delegate;
			Delegate delegate2;
			if (delegate2 != null)
			{
				handlers.readyCallback = delegate2;
				return;
			}
			handlers.readyCallback = delegate2;
			DiscordRpc.OnRequestInfo onRequestInfo = handlers.requestCallback;
			Delegate delegate3;
			if (delegate3 != null)
			{
				handlers.requestCallback = delegate3;
				return;
			}
			handlers.requestCallback = delegate3;
			DiscordRpc.OnSpectateInfo onSpectateInfo = handlers.spectateCallback;
			Delegate delegate4;
			if (delegate4 != null)
			{
				handlers.spectateCallback = delegate4;
				return;
			}
			handlers.spectateCallback = delegate4;
			DiscordRpc.OnErrorInfo onErrorInfo = handlers.errorCallback;
			Delegate delegate5;
			if (delegate5 != null)
			{
				handlers.errorCallback = delegate5;
				return;
			}
			handlers.errorCallback = delegate5;
			DiscordRpc.OnDisconnectedInfo onDisconnectedInfo = handlers.disconnectedCallback;
			Delegate delegate6;
			if (delegate6 != null)
			{
				handlers.disconnectedCallback = delegate6;
				throw new InvalidCastException();
			}
			handlers.disconnectedCallback = delegate6;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x001F836C File Offset: 0x001F656C
		public void UnRegisterFrom(DiscordRpc.EventHandlers handlers)
		{
			DiscordRpc.OnJoinInfo onJoinInfo = handlers.joinCallback;
			Delegate @delegate;
			if (@delegate != null)
			{
				handlers.joinCallback = @delegate;
				return;
			}
			handlers.joinCallback = @delegate;
			Delegate delegate2;
			if (delegate2 != null)
			{
				handlers.readyCallback = delegate2;
				return;
			}
			handlers.readyCallback = delegate2;
			DiscordRpc.OnRequestInfo onRequestInfo = handlers.requestCallback;
			Delegate delegate3;
			if (delegate3 != null)
			{
				handlers.requestCallback = delegate3;
				return;
			}
			handlers.requestCallback = delegate3;
			DiscordRpc.OnSpectateInfo onSpectateInfo = handlers.spectateCallback;
			Delegate delegate4;
			if (delegate4 != null)
			{
				handlers.spectateCallback = delegate4;
				return;
			}
			handlers.spectateCallback = delegate4;
			DiscordRpc.OnErrorInfo onErrorInfo = handlers.errorCallback;
			Delegate delegate5;
			if (delegate5 != null)
			{
				handlers.errorCallback = delegate5;
				return;
			}
			handlers.errorCallback = delegate5;
			DiscordRpc.OnDisconnectedInfo onDisconnectedInfo = handlers.disconnectedCallback;
			Delegate delegate6;
			if (delegate6 != null)
			{
				handlers.disconnectedCallback = delegate6;
				throw new InvalidCastException();
			}
			handlers.disconnectedCallback = delegate6;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x001F841C File Offset: 0x001F661C
		private void OnReadyInfo(DiscordRpc.DiscordUser connectedUser)
		{
			DiscordRpc.OnReadyInfo onReadyInfo = this.readyCallback;
			if (onReadyInfo != null)
			{
				IntPtr invoke_impl = onReadyInfo.invoke_impl;
				IntPtr method_code = onReadyInfo.method_code;
				IntPtr method = onReadyInfo.method;
				return;
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x001F844C File Offset: 0x001F664C
		private void OnDisconnectedInfo(int errorCode, string message)
		{
			DiscordRpc.OnDisconnectedInfo onDisconnectedInfo = this.disconnectedCallback;
			if (onDisconnectedInfo != null)
			{
				IntPtr invoke_impl = onDisconnectedInfo.invoke_impl;
				IntPtr method_code = onDisconnectedInfo.method_code;
				IntPtr method = onDisconnectedInfo.method;
				return;
			}
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x001F847C File Offset: 0x001F667C
		private void OnErrorInfo(int errorCode, string message)
		{
			DiscordRpc.OnErrorInfo onErrorInfo = this.errorCallback;
			if (onErrorInfo != null)
			{
				IntPtr invoke_impl = onErrorInfo.invoke_impl;
				IntPtr method_code = onErrorInfo.method_code;
				IntPtr method = onErrorInfo.method;
				return;
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x001F84AC File Offset: 0x001F66AC
		private void OnJoinInfo(string secret)
		{
			DiscordRpc.OnJoinInfo onJoinInfo = this.joinCallback;
			if (onJoinInfo != null)
			{
				IntPtr invoke_impl = onJoinInfo.invoke_impl;
				IntPtr method_code = onJoinInfo.method_code;
				IntPtr method = onJoinInfo.method;
				return;
			}
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x001F84DC File Offset: 0x001F66DC
		private void OnSpectateInfo(string secret)
		{
			DiscordRpc.OnSpectateInfo onSpectateInfo = this.spectateCallback;
			if (onSpectateInfo != null)
			{
				IntPtr invoke_impl = onSpectateInfo.invoke_impl;
				IntPtr method_code = onSpectateInfo.method_code;
				IntPtr method = onSpectateInfo.method;
				return;
			}
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x001F850C File Offset: 0x001F670C
		private void OnRequestInfo(DiscordRpc.DiscordUser request)
		{
			DiscordRpc.OnRequestInfo onRequestInfo = this.requestCallback;
			if (onRequestInfo != null)
			{
				IntPtr invoke_impl = onRequestInfo.invoke_impl;
				IntPtr method_code = onRequestInfo.method_code;
				IntPtr method = onRequestInfo.method;
				return;
			}
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x001F853C File Offset: 0x001F673C
		public DiscordHooks()
		{
		}

		// Token: 0x04003B22 RID: 15138
		public DiscordRpc.OnReadyInfo readyCallback;

		// Token: 0x04003B23 RID: 15139
		public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

		// Token: 0x04003B24 RID: 15140
		public DiscordRpc.OnErrorInfo errorCallback;

		// Token: 0x04003B25 RID: 15141
		public DiscordRpc.OnJoinInfo joinCallback;

		// Token: 0x04003B26 RID: 15142
		public DiscordRpc.OnSpectateInfo spectateCallback;

		// Token: 0x04003B27 RID: 15143
		public DiscordRpc.OnRequestInfo requestCallback;
	}
}
