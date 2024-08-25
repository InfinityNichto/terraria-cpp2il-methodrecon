using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200034D RID: 845
	public abstract class ComponentEditor
	{
		// Token: 0x060015F9 RID: 5625 RVA: 0x00002050 File Offset: 0x00000250
		public bool EditComponent(object component)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060015FA RID: 5626
		public abstract bool EditComponent(ITypeDescriptorContext context, object component);

		// Token: 0x060015FB RID: 5627 RVA: 0x00040E94 File Offset: 0x0003F094
		protected ComponentEditor()
		{
		}
	}
}
