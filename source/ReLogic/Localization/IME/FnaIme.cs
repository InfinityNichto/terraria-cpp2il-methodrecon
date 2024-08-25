using System;
using Cpp2IlInjected;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000B2F RID: 2863
	internal class FnaIme : PlatformIme
	{
		// Token: 0x0600537D RID: 21373 RVA: 0x002849E0 File Offset: 0x00282BE0
		public FnaIme()
		{
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x002849F4 File Offset: 0x00282BF4
		private void OnCharCallback(char key)
		{
			if (this.<IsEnabled>k__BackingField)
			{
				base.OnKeyPress(key);
				return;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x00284A14 File Offset: 0x00282C14
		public override uint CandidateCount
		{
			get
			{
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x000021DB File Offset: 0x000003DB
		public override string CompositionString
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x00284A24 File Offset: 0x00282C24
		public override bool IsCandidateListVisible
		{
			get
			{
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x00284A34 File Offset: 0x00282C34
		public override uint SelectedCandidate
		{
			get
			{
			}
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x000021DB File Offset: 0x000003DB
		public override string GetCandidate(uint index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00284A44 File Offset: 0x00282C44
		protected override void Dispose(bool disposing)
		{
			if (!this._disposedValue)
			{
				if (this.<IsEnabled>k__BackingField)
				{
				}
				this._disposedValue = true;
			}
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00284A68 File Offset: 0x00282C68
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x04008B30 RID: 35632
		private bool _disposedValue;
	}
}
