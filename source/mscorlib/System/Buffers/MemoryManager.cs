using System;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000665 RID: 1637
	public abstract class MemoryManager<T>
	{
		// Token: 0x060031CC RID: 12748
		public abstract Span<T> GetSpan();

		// Token: 0x060031CD RID: 12749
		public abstract MemoryHandle Pin(int elementIndex = 0);

		// Token: 0x060031CE RID: 12750 RVA: 0x0006BB48 File Offset: 0x00069D48
		protected internal virtual bool TryGetArray([Out] ArraySegment<T> segment)
		{
		}
	}
}
