using System;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000B30 RID: 2864
	public interface IImeService
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06005386 RID: 21382
		string CompositionString { get; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06005387 RID: 21383
		bool IsCandidateListVisible { get; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06005388 RID: 21384
		uint SelectedCandidate { get; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06005389 RID: 21385
		uint CandidateCount { get; }

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600538A RID: 21386
		bool IsEnabled { get; }

		// Token: 0x0600538B RID: 21387
		string GetCandidate(uint index);

		// Token: 0x0600538C RID: 21388
		void Enable();

		// Token: 0x0600538D RID: 21389
		void Disable();

		// Token: 0x0600538E RID: 21390
		void AddKeyListener(Action<char> listener);

		// Token: 0x0600538F RID: 21391
		void RemoveKeyListener(Action<char> listener);
	}
}
