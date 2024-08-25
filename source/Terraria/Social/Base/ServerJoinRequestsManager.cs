using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Social.Base
{
	// Token: 0x02000531 RID: 1329
	public class ServerJoinRequestsManager
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060031F5 RID: 12789 RVA: 0x001F8EF8 File Offset: 0x001F70F8
		// (remove) Token: 0x060031F6 RID: 12790 RVA: 0x001F8F1C File Offset: 0x001F711C
		public event ServerJoinRequestEvent OnRequestAdded
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRequestAdded, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRequestAdded, value) != null)
				{
				}
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060031F7 RID: 12791 RVA: 0x001F8F40 File Offset: 0x001F7140
		// (remove) Token: 0x060031F8 RID: 12792 RVA: 0x001F8F64 File Offset: 0x001F7164
		public event ServerJoinRequestEvent OnRequestRemoved
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRequestRemoved, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRequestRemoved, value) != null)
				{
				}
			}
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x001F8F88 File Offset: 0x001F7188
		public ServerJoinRequestsManager()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x001F8F9C File Offset: 0x001F719C
		public void Update()
		{
			int size = this._requests._size;
			this.RemoveRequestAtIndex(0);
			List<UserJoinToServerRequest> requests = this._requests;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(UserJoinToServerRequest request)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x001F8FC4 File Offset: 0x001F71C4
		private void RemoveRequestAtIndex(int i)
		{
			List<UserJoinToServerRequest> requests = this._requests;
			List<UserJoinToServerRequest> requests2 = this._requests;
			ServerJoinRequestEvent onRequestRemoved = this.OnRequestRemoved;
			if (onRequestRemoved != null)
			{
				IntPtr invoke_impl = onRequestRemoved.invoke_impl;
				IntPtr method_code = onRequestRemoved.method_code;
				IntPtr method = onRequestRemoved.method;
				return;
			}
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x001F9004 File Offset: 0x001F7204
		private void RemoveRequest(UserJoinToServerRequest request)
		{
			List<UserJoinToServerRequest> requests = this._requests;
			ServerJoinRequestEvent onRequestRemoved = this.OnRequestRemoved;
			if (onRequestRemoved != null)
			{
				IntPtr invoke_impl = onRequestRemoved.invoke_impl;
				IntPtr method_code = onRequestRemoved.method_code;
				IntPtr method = onRequestRemoved.method;
				return;
			}
		}

		// Token: 0x04003B66 RID: 15206
		private readonly List<UserJoinToServerRequest> _requests;

		// Token: 0x04003B67 RID: 15207
		public readonly ReadOnlyCollection<UserJoinToServerRequest> CurrentRequests;

		// Token: 0x04003B68 RID: 15208
		[CompilerGenerated]
		private ServerJoinRequestEvent OnRequestAdded;

		// Token: 0x04003B69 RID: 15209
		[CompilerGenerated]
		private ServerJoinRequestEvent OnRequestRemoved;

		// Token: 0x02000532 RID: 1330
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060031FE RID: 12798 RVA: 0x001F903C File Offset: 0x001F723C
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060031FF RID: 12799 RVA: 0x001F9050 File Offset: 0x001F7250
			internal void <Add>b__0()
			{
				ServerJoinRequestsManager serverJoinRequestsManager = this.<>4__this;
				UserJoinToServerRequest userJoinToServerRequest = this.request;
				serverJoinRequestsManager.RemoveRequest(userJoinToServerRequest);
			}

			// Token: 0x06003200 RID: 12800 RVA: 0x001F9074 File Offset: 0x001F7274
			internal void <Add>b__1()
			{
				ServerJoinRequestsManager serverJoinRequestsManager = this.<>4__this;
				UserJoinToServerRequest userJoinToServerRequest = this.request;
				serverJoinRequestsManager.RemoveRequest(userJoinToServerRequest);
			}

			// Token: 0x04003B6A RID: 15210
			public ServerJoinRequestsManager <>4__this;

			// Token: 0x04003B6B RID: 15211
			public UserJoinToServerRequest request;
		}
	}
}
