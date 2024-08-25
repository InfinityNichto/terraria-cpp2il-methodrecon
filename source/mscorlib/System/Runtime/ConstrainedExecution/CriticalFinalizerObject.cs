using System;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x02000461 RID: 1121
	public abstract class CriticalFinalizerObject
	{
		// Token: 0x060021EF RID: 8687 RVA: 0x0004CB8C File Offset: 0x0004AD8C
		protected CriticalFinalizerObject()
		{
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0004CBA0 File Offset: 0x0004ADA0
		protected override void Finalize()
		{
			base.Finalize();
		}
	}
}
