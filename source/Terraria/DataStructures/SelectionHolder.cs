using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.DataStructures
{
	// Token: 0x0200066D RID: 1645
	public abstract class SelectionHolder<TCycleType> where TCycleType : class, IConfigKeyHolder
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x00221064 File Offset: 0x0021F264
		public string ActiveSelectionKeyName
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

		// Token: 0x06003711 RID: 14097 RVA: 0x00221074 File Offset: 0x0021F274
		public void BindTo(Preferences preferences)
		{
		}

		// Token: 0x06003712 RID: 14098
		protected abstract void Configuration_Save(Preferences obj);

		// Token: 0x06003713 RID: 14099
		protected abstract void Configuration_OnLoad(Preferences obj);

		// Token: 0x06003714 RID: 14100 RVA: 0x00221088 File Offset: 0x0021F288
		protected void Wrapped_Configuration_OnLoad(Preferences obj)
		{
			if (this.LoadedContent)
			{
				return;
			}
		}

		// Token: 0x06003715 RID: 14101
		protected abstract void PopulateOptionsAndLoadContent(AssetRequestMode mode);

		// Token: 0x06003716 RID: 14102 RVA: 0x002210A0 File Offset: 0x0021F2A0
		public void LoadContent(AssetRequestMode mode)
		{
			this.LoadedContent = true;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x002210B4 File Offset: 0x0021F2B4
		public void CycleSelection()
		{
			this.Options = this;
			Dictionary options = this.Options;
			if (this.ActiveSelection == null)
			{
				Dictionary options2 = this.Options;
				this.ActiveSelection = options2;
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x002210E8 File Offset: 0x0021F2E8
		public void SetActiveMinimapFromLoadedConfigKey()
		{
			string activeSelectionConfigKey = this.ActiveSelectionConfigKey;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x002210FC File Offset: 0x0021F2FC
		private void SetActiveFrame(string frameName)
		{
			this.Options = frameName;
			Dictionary options = this.Options;
			if (this == null)
			{
				Dictionary options2 = this.Options;
			}
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00221124 File Offset: 0x0021F324
		private void SetActiveFrame(TCycleType frame)
		{
			this.ActiveSelection = frame;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00221144 File Offset: 0x0021F344
		protected SelectionHolder()
		{
			this.Options = this;
			base..ctor();
		}

		// Token: 0x04007814 RID: 30740
		protected Dictionary<string, TCycleType> Options;

		// Token: 0x04007815 RID: 30741
		protected TCycleType ActiveSelection;

		// Token: 0x04007816 RID: 30742
		protected string ActiveSelectionConfigKey;

		// Token: 0x04007817 RID: 30743
		protected bool LoadedContent;

		// Token: 0x04007818 RID: 30744
		[CompilerGenerated]
		private string <ActiveSelectionKeyName>k__BackingField;

		// Token: 0x0200066E RID: 1646
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600371C RID: 14108 RVA: 0x00221160 File Offset: 0x0021F360
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600371D RID: 14109 RVA: 0x00221174 File Offset: 0x0021F374
			internal bool <CycleSelection>b__0(TCycleType frame)
			{
				TCycleType activeSelection = this.<>4__this.ActiveSelection;
				this.lastFrame = frame;
				return true;
			}

			// Token: 0x04007819 RID: 30745
			public SelectionHolder<TCycleType> <>4__this;

			// Token: 0x0400781A RID: 30746
			public TCycleType lastFrame;
		}

		// Token: 0x0200066F RID: 1647
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x0600371E RID: 14110 RVA: 0x00221198 File Offset: 0x0021F398
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0600371F RID: 14111 RVA: 0x002211AC File Offset: 0x0021F3AC
			internal bool <SetActiveFrame>b__0(KeyValuePair<string, TCycleType> pair)
			{
				string text = this.frameName;
				bool flag;
				return flag;
			}

			// Token: 0x0400781B RID: 30747
			public string frameName;
		}
	}
}
