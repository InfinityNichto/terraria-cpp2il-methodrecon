using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020001B8 RID: 440
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x000235C8 File Offset: 0x000217C8
		public T CurrentValue
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentValue>k__BackingField;
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000235DC File Offset: 0x000217DC
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
			this.<PreviousValue>k__BackingField = previousValue;
			this.CurrentValue = currentValue;
		}

		// Token: 0x040008FD RID: 2301
		[CompilerGenerated]
		private readonly T <PreviousValue>k__BackingField;

		// Token: 0x040008FE RID: 2302
		[CompilerGenerated]
		private readonly T <CurrentValue>k__BackingField;

		// Token: 0x040008FF RID: 2303
		[CompilerGenerated]
		private readonly bool <ThreadContextChanged>k__BackingField;
	}
}
