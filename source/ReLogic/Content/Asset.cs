using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B39 RID: 2873
	public sealed class Asset<T> : IAsset, IDisposable where T : class
	{
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x00284EB0 File Offset: 0x002830B0
		// (set) Token: 0x060053BE RID: 21438 RVA: 0x00284EC4 File Offset: 0x002830C4
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x000021DB File Offset: 0x000003DB
		public bool IsLoaded
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x00284ED8 File Offset: 0x002830D8
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x00284EEC File Offset: 0x002830EC
		public AssetState State
		{
			[CompilerGenerated]
			get
			{
				return this.<State>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<State>k__BackingField = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x00284F00 File Offset: 0x00283100
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x00284F14 File Offset: 0x00283114
		public bool IsDisposed
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDisposed>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060053C5 RID: 21445 RVA: 0x00284F24 File Offset: 0x00283124
		public IContentSource Source
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060053C7 RID: 21447 RVA: 0x00284F34 File Offset: 0x00283134
		public T Value
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00284F44 File Offset: 0x00283144
		public void ActionUnityLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00284F54 File Offset: 0x00283154
		internal Asset(string name)
		{
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x000021DB File Offset: 0x000003DB
		public static explicit operator T(Asset<T> asset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00284F68 File Offset: 0x00283168
		internal void Unload()
		{
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00284F7C File Offset: 0x0028317C
		internal void SubmitLoadedContent(T value, IContentSource source)
		{
			while (value == null)
			{
			}
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00284F90 File Offset: 0x00283190
		internal void SetToLoadingState()
		{
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00284FA0 File Offset: 0x002831A0
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00284FB8 File Offset: 0x002831B8
		public void Dispose()
		{
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x00284FC8 File Offset: 0x002831C8
		// Note: this type is marked as 'beforefieldinit'.
		static Asset()
		{
		}

		// Token: 0x04008CF0 RID: 36080
		public static readonly Asset<T> Empty;

		// Token: 0x04008CF1 RID: 36081
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04008CF2 RID: 36082
		[CompilerGenerated]
		private AssetState <State>k__BackingField;

		// Token: 0x04008CF3 RID: 36083
		[CompilerGenerated]
		private bool <IsDisposed>k__BackingField;

		// Token: 0x04008CF4 RID: 36084
		[CompilerGenerated]
		private IContentSource <Source>k__BackingField;

		// Token: 0x04008CF5 RID: 36085
		[CompilerGenerated]
		private T <Value>k__BackingField;
	}
}
