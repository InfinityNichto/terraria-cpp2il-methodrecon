using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003B4 RID: 948
	public class RefreshEventArgs : EventArgs
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x00046EA8 File Offset: 0x000450A8
		public RefreshEventArgs(object componentChanged)
		{
			if (!true)
			{
			}
			base..ctor();
			this.ComponentChanged = componentChanged;
			Type type = componentChanged.GetType();
			this.TypeChanged = type;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00046ED4 File Offset: 0x000450D4
		public RefreshEventArgs(Type typeChanged)
		{
			if (!true)
			{
			}
			base..ctor();
			this.TypeChanged = typeChanged;
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00046EF4 File Offset: 0x000450F4
		public object ComponentChanged
		{
			[CompilerGenerated]
			get
			{
				return this.<ComponentChanged>k__BackingField;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00046F08 File Offset: 0x00045108
		public Type TypeChanged
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeChanged>k__BackingField;
			}
		}

		// Token: 0x040012C2 RID: 4802
		[CompilerGenerated]
		private readonly object <ComponentChanged>k__BackingField;

		// Token: 0x040012C3 RID: 4803
		[CompilerGenerated]
		private readonly Type <TypeChanged>k__BackingField;
	}
}
