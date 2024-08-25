using System;

namespace System.ComponentModel
{
	// Token: 0x0200038C RID: 908
	public abstract class InstanceCreationEditor
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0004369C File Offset: 0x0004189C
		public virtual string Text
		{
			get
			{
				return "(New...)";
			}
		}

		// Token: 0x060017AF RID: 6063
		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);

		// Token: 0x060017B0 RID: 6064 RVA: 0x000436B0 File Offset: 0x000418B0
		protected InstanceCreationEditor()
		{
		}
	}
}
