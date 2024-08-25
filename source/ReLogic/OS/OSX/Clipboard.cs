using System;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000B27 RID: 2855
	internal class Clipboard : Clipboard
	{
		// Token: 0x0600535B RID: 21339 RVA: 0x0028467C File Offset: 0x0028287C
		protected override string GetClipboard()
		{
			long num = 0L;
			if ("-pboard general" != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x002846BC File Offset: 0x002828BC
		protected override void SetClipboard(string text)
		{
			if ("-pboard general -Prefer txt" != null)
			{
			}
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00284704 File Offset: 0x00282904
		public Clipboard()
		{
		}
	}
}
