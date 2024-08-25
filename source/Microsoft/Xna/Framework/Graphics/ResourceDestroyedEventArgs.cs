using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200038A RID: 906
	public sealed class ResourceDestroyedEventArgs : EventArgs
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00065FF0 File Offset: 0x000641F0
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00066004 File Offset: 0x00064204
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00066018 File Offset: 0x00064218
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0006602C File Offset: 0x0006422C
		public object Tag
		{
			[CompilerGenerated]
			get
			{
				return this.<Tag>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Tag>k__BackingField = value;
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00066040 File Offset: 0x00064240
		public ResourceDestroyedEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04002641 RID: 9793
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002642 RID: 9794
		[CompilerGenerated]
		private object <Tag>k__BackingField;
	}
}
