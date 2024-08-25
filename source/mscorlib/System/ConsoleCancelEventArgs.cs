using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000127 RID: 295
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		// Token: 0x06000B96 RID: 2966 RVA: 0x0001A118 File Offset: 0x00018318
		internal ConsoleCancelEventArgs(ConsoleSpecialKey type)
		{
			if (!true)
			{
			}
			base..ctor();
			this._type = type;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0001A138 File Offset: 0x00018338
		public bool Cancel
		{
			[CompilerGenerated]
			get
			{
				return this.<Cancel>k__BackingField;
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001A14C File Offset: 0x0001834C
		internal ConsoleCancelEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400041C RID: 1052
		private readonly ConsoleSpecialKey _type;

		// Token: 0x0400041D RID: 1053
		[CompilerGenerated]
		private bool <Cancel>k__BackingField;
	}
}
