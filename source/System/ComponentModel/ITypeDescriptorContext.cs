using System;

namespace System.ComponentModel
{
	// Token: 0x02000389 RID: 905
	public interface ITypeDescriptorContext : IServiceProvider
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060017A2 RID: 6050
		IContainer Container { get; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060017A3 RID: 6051
		object Instance { get; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060017A4 RID: 6052
		PropertyDescriptor PropertyDescriptor { get; }

		// Token: 0x060017A5 RID: 6053
		bool OnComponentChanging();

		// Token: 0x060017A6 RID: 6054
		void OnComponentChanged();
	}
}
