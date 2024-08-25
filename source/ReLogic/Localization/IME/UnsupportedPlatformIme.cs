using System;
using Cpp2IlInjected;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000B32 RID: 2866
	public class UnsupportedPlatformIme : PlatformIme
	{
		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x00284BCC File Offset: 0x00282DCC
		public override uint CandidateCount
		{
			get
			{
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x000021DB File Offset: 0x000003DB
		public override string CompositionString
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x00284BDC File Offset: 0x00282DDC
		public override bool IsCandidateListVisible
		{
			get
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x00284BEC File Offset: 0x00282DEC
		public override uint SelectedCandidate
		{
			get
			{
			}
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x000021DB File Offset: 0x000003DB
		public override string GetCandidate(uint index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00284BFC File Offset: 0x00282DFC
		public UnsupportedPlatformIme()
		{
		}
	}
}
