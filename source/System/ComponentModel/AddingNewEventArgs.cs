using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000345 RID: 837
	public class AddingNewEventArgs : EventArgs
	{
		// Token: 0x060015C4 RID: 5572 RVA: 0x00040880 File Offset: 0x0003EA80
		public AddingNewEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00040898 File Offset: 0x0003EA98
		public AddingNewEventArgs(object newObject)
		{
			if (!true)
			{
			}
			base..ctor();
			this.NewObject = newObject;
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000408B8 File Offset: 0x0003EAB8
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x000408CC File Offset: 0x0003EACC
		public object NewObject
		{
			[CompilerGenerated]
			get
			{
				return this.<NewObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NewObject>k__BackingField = value;
			}
		}

		// Token: 0x040011B0 RID: 4528
		[CompilerGenerated]
		private object <NewObject>k__BackingField;
	}
}
