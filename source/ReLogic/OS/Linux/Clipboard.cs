using System;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux
{
	// Token: 0x02000B2A RID: 2858
	internal class Clipboard : Clipboard
	{
		// Token: 0x06005366 RID: 21350 RVA: 0x002847B4 File Offset: 0x002829B4
		protected override string GetClipboard()
		{
			long num = 0L;
			if ("-o" != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x002847F4 File Offset: 0x002829F4
		private void ClearClipboard()
		{
			if ("-c" != null)
			{
			}
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00284838 File Offset: 0x00282A38
		protected override void SetClipboard(string text)
		{
			bool flag = text == "";
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00284890 File Offset: 0x00282A90
		public Clipboard()
		{
		}
	}
}
