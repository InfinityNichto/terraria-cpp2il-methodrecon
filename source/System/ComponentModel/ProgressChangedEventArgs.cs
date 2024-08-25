using System;

namespace System.ComponentModel
{
	// Token: 0x020003E7 RID: 999
	public class ProgressChangedEventArgs : EventArgs
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x00049390 File Offset: 0x00047590
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
			if (!true)
			{
			}
			base..ctor();
			this.progressPercentage = progressPercentage;
			this.userState = userState;
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000493B4 File Offset: 0x000475B4
		[global::System.SRDescription("Percentage progress made in operation.")]
		public int ProgressPercentage
		{
			get
			{
				return this.progressPercentage;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x000493C8 File Offset: 0x000475C8
		[global::System.SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			get
			{
				return this.userState;
			}
		}

		// Token: 0x04001319 RID: 4889
		private readonly int progressPercentage;

		// Token: 0x0400131A RID: 4890
		private readonly object userState;
	}
}
