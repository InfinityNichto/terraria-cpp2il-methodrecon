using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000255 RID: 597
	internal enum CausalityRelation
	{
		// Token: 0x04000AD1 RID: 2769
		AssignDelegate,
		// Token: 0x04000AD2 RID: 2770
		Join,
		// Token: 0x04000AD3 RID: 2771
		Choice,
		// Token: 0x04000AD4 RID: 2772
		Cancel,
		// Token: 0x04000AD5 RID: 2773
		Error
	}
}
