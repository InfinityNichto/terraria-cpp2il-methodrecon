using System;
using System.Runtime.CompilerServices;

namespace Terraria.Social.Base
{
	// Token: 0x02000533 RID: 1331
	public abstract class UserJoinToServerRequest
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x001F9098 File Offset: 0x001F7298
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x001F90AC File Offset: 0x001F72AC
		internal string UserDisplayName
		{
			[CompilerGenerated]
			get
			{
				return this.<UserDisplayName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UserDisplayName>k__BackingField = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x001F90C0 File Offset: 0x001F72C0
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x001F90D4 File Offset: 0x001F72D4
		internal string UserFullIdentifier
		{
			[CompilerGenerated]
			get
			{
				return this.<UserFullIdentifier>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UserFullIdentifier>k__BackingField = value;
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06003205 RID: 12805 RVA: 0x001F90E8 File Offset: 0x001F72E8
		// (remove) Token: 0x06003206 RID: 12806 RVA: 0x001F910C File Offset: 0x001F730C
		public event Action OnAccepted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnAccepted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnAccepted, value) != null)
				{
				}
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06003207 RID: 12807 RVA: 0x001F9130 File Offset: 0x001F7330
		// (remove) Token: 0x06003208 RID: 12808 RVA: 0x001F9154 File Offset: 0x001F7354
		public event Action OnRejected
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRejected, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRejected, value) != null)
				{
				}
			}
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x001F9178 File Offset: 0x001F7378
		public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
		{
			this.UserDisplayName = userDisplayName;
			this.UserFullIdentifier = fullIdentifier;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x001F919C File Offset: 0x001F739C
		public void Accept()
		{
			Action onAccepted = this.OnAccepted;
			if (onAccepted != null)
			{
				IntPtr invoke_impl = onAccepted.invoke_impl;
				IntPtr method_code = onAccepted.method_code;
				IntPtr method = onAccepted.method;
				return;
			}
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x001F91CC File Offset: 0x001F73CC
		public void Reject()
		{
			Action onRejected = this.OnRejected;
			if (onRejected != null)
			{
				IntPtr invoke_impl = onRejected.invoke_impl;
				IntPtr method_code = onRejected.method_code;
				IntPtr method = onRejected.method;
				return;
			}
		}

		// Token: 0x0600320C RID: 12812
		public abstract bool IsValid();

		// Token: 0x0600320D RID: 12813
		public abstract string GetUserWrapperText();

		// Token: 0x04003B6C RID: 15212
		[CompilerGenerated]
		private string <UserDisplayName>k__BackingField;

		// Token: 0x04003B6D RID: 15213
		[CompilerGenerated]
		private string <UserFullIdentifier>k__BackingField;

		// Token: 0x04003B6E RID: 15214
		[CompilerGenerated]
		private Action OnAccepted;

		// Token: 0x04003B6F RID: 15215
		[CompilerGenerated]
		private Action OnRejected;
	}
}
