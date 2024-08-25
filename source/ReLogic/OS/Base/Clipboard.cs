using System;

namespace ReLogic.OS.Base
{
	// Token: 0x02000B2D RID: 2861
	internal abstract class Clipboard : IClipboard
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x00284954 File Offset: 0x00282B54
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x00284964 File Offset: 0x00282B64
		public string Value
		{
			get
			{
				string text;
				return text;
			}
			set
			{
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x00284974 File Offset: 0x00282B74
		public string MultiLineValue
		{
			get
			{
				string text;
				return text;
			}
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00284984 File Offset: 0x00282B84
		private static string SanitizeClipboardText(string clipboardText, bool allowNewLine)
		{
		}

		// Token: 0x06005376 RID: 21366
		protected abstract string GetClipboard();

		// Token: 0x06005377 RID: 21367
		protected abstract void SetClipboard(string text);

		// Token: 0x06005378 RID: 21368 RVA: 0x00284994 File Offset: 0x00282B94
		protected Clipboard()
		{
		}
	}
}
