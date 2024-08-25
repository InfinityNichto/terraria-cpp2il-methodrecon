using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000389 RID: 905
	public sealed class ResourceCreatedEventArgs : EventArgs
	{
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00065FB0 File Offset: 0x000641B0
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x00065FC4 File Offset: 0x000641C4
		public object Resource
		{
			[CompilerGenerated]
			get
			{
				return this.<Resource>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Resource>k__BackingField = value;
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00065FD8 File Offset: 0x000641D8
		public ResourceCreatedEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04002640 RID: 9792
		[CompilerGenerated]
		private object <Resource>k__BackingField;
	}
}
