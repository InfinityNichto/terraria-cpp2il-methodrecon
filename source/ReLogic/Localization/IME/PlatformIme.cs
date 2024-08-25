using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000B31 RID: 2865
	public abstract class PlatformIme : IImeService, IDisposable
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06005390 RID: 21392
		public abstract string CompositionString { get; }

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06005391 RID: 21393
		public abstract bool IsCandidateListVisible { get; }

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06005392 RID: 21394
		public abstract uint SelectedCandidate { get; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06005393 RID: 21395
		public abstract uint CandidateCount { get; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x00284A9C File Offset: 0x00282C9C
		// (set) Token: 0x06005395 RID: 21397 RVA: 0x00284AB0 File Offset: 0x00282CB0
		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEnabled>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00284AC0 File Offset: 0x00282CC0
		protected PlatformIme()
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddKeyListener(Action<char> listener)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00284AD4 File Offset: 0x00282CD4
		public void RemoveKeyListener(Action<char> listener)
		{
			List<Action<char>> keyPressCallbacks = this._keyPressCallbacks;
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00284AE8 File Offset: 0x00282CE8
		protected void OnKeyPress(char character)
		{
			List<Action<char>> keyPressCallbacks = this._keyPressCallbacks;
		}

		// Token: 0x0600539A RID: 21402
		public abstract string GetCandidate(uint index);

		// Token: 0x0600539B RID: 21403 RVA: 0x00284B10 File Offset: 0x00282D10
		public void Enable()
		{
			if (!this.<IsEnabled>k__BackingField)
			{
				this.<IsEnabled>k__BackingField = true;
			}
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00284B2C File Offset: 0x00282D2C
		public void Disable()
		{
			if (this.<IsEnabled>k__BackingField)
			{
			}
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00284B44 File Offset: 0x00282D44
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00284B54 File Offset: 0x00282D54
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00284B64 File Offset: 0x00282D64
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposedValue)
			{
				return;
			}
			this._disposedValue = true;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00284B84 File Offset: 0x00282D84
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00284BB8 File Offset: 0x00282DB8
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x04008B31 RID: 35633
		[CompilerGenerated]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x04008B32 RID: 35634
		private readonly List<Action<char>> _keyPressCallbacks;

		// Token: 0x04008B33 RID: 35635
		private bool _disposedValue;
	}
}
