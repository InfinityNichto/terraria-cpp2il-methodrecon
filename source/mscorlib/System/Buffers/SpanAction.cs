using System;

namespace System.Buffers
{
	// Token: 0x0200065F RID: 1631
	public sealed class SpanAction<T, in TArg> : MulticastDelegate
	{
		// Token: 0x060031BA RID: 12730 RVA: 0x0006BA24 File Offset: 0x00069C24
		public SpanAction(object @object, IntPtr method)
		{
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0006BA40 File Offset: 0x00069C40
		public void Invoke(Span<T> span, TArg arg)
		{
		}
	}
}
