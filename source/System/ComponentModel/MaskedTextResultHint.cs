using System;

namespace System.ComponentModel
{
	// Token: 0x020003A6 RID: 934
	public enum MaskedTextResultHint
	{
		// Token: 0x04001287 RID: 4743
		Unknown,
		// Token: 0x04001288 RID: 4744
		CharacterEscaped,
		// Token: 0x04001289 RID: 4745
		NoEffect,
		// Token: 0x0400128A RID: 4746
		SideEffect,
		// Token: 0x0400128B RID: 4747
		Success,
		// Token: 0x0400128C RID: 4748
		AsciiCharacterExpected = -1,
		// Token: 0x0400128D RID: 4749
		AlphanumericCharacterExpected = -2,
		// Token: 0x0400128E RID: 4750
		DigitExpected = -3,
		// Token: 0x0400128F RID: 4751
		LetterExpected = -4,
		// Token: 0x04001290 RID: 4752
		SignedDigitExpected = -5,
		// Token: 0x04001291 RID: 4753
		InvalidInput = -51,
		// Token: 0x04001292 RID: 4754
		PromptCharNotAllowed = -52,
		// Token: 0x04001293 RID: 4755
		UnavailableEditPosition = -53,
		// Token: 0x04001294 RID: 4756
		NonEditPosition = -54,
		// Token: 0x04001295 RID: 4757
		PositionOutOfRange = -55
	}
}
