using System;

namespace System.Threading
{
	// Token: 0x020001B7 RID: 439
	internal interface IAsyncLocal
	{
		// Token: 0x060010AB RID: 4267
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
