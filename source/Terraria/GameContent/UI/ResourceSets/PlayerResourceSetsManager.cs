using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A84 RID: 2692
	public class PlayerResourceSetsManager
	{
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0027AD94 File Offset: 0x00278F94
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0027ADA8 File Offset: 0x00278FA8
		public string ActiveSetKeyName
		{
			[CompilerGenerated]
			get
			{
				return this.<ActiveSetKeyName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ActiveSetKeyName>k__BackingField = value;
			}
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x0027ADBC File Offset: 0x00278FBC
		public void BindTo(Preferences preferences)
		{
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x0027ADCC File Offset: 0x00278FCC
		private void Configuration_OnLoad(Preferences obj)
		{
			bool loadedContent = this._loadedContent;
			this._activeSetConfigKey = obj;
			if (loadedContent)
			{
				return;
			}
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x0027ADEC File Offset: 0x00278FEC
		private void Configuration_OnSave(Preferences obj)
		{
			string activeSetConfigKey = this._activeSetConfigKey;
			obj.Put("PlayerResourcesSet", activeSetConfigKey);
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x0027AE0C File Offset: 0x0027900C
		public void LoadContent(AssetRequestMode mode)
		{
			Dictionary<string, IPlayerResourcesDisplaySet> sets = this._sets;
			Dictionary<string, IPlayerResourcesDisplaySet> sets2 = this._sets;
			Dictionary<string, IPlayerResourcesDisplaySet> sets3 = this._sets;
			Dictionary<string, IPlayerResourcesDisplaySet> sets4 = this._sets;
			Dictionary<string, IPlayerResourcesDisplaySet> sets5 = this._sets;
			Dictionary<string, IPlayerResourcesDisplaySet> sets6 = this._sets;
			this._loadedContent = true;
			string activeSetConfigKey = this._activeSetConfigKey;
			this.SetActive(activeSetConfigKey);
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x0027AE5C File Offset: 0x0027905C
		public void SetActiveFromLoadedConfigKey()
		{
			string activeSetConfigKey = this._activeSetConfigKey;
			this.SetActive(activeSetConfigKey);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x0027AE78 File Offset: 0x00279078
		private void SetActive(string name)
		{
			Dictionary<string, IPlayerResourcesDisplaySet> sets = this._sets;
			IPlayerResourcesDisplaySet playerResourcesDisplaySet = Enumerable.First<IPlayerResourcesDisplaySet>(this._sets);
			this.SetActiveFrame(playerResourcesDisplaySet);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x0027AEA0 File Offset: 0x002790A0
		private void SetActiveFrame(IPlayerResourcesDisplaySet set)
		{
			this._activeSet = set;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x0027AEC4 File Offset: 0x002790C4
		public void TryToHoverOverResources()
		{
			IPlayerResourcesDisplaySet activeSet = this._activeSet;
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x0027AEDC File Offset: 0x002790DC
		public void Draw()
		{
			IPlayerResourcesDisplaySet activeSet = this._activeSet;
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x0027AEF4 File Offset: 0x002790F4
		public void CycleResourceSet()
		{
			Dictionary<string, IPlayerResourcesDisplaySet> sets = this._sets;
			IPlayerResourcesDisplaySet playerResourcesDisplaySet = Enumerable.Last<IPlayerResourcesDisplaySet>(this._sets);
			this.SetActiveFrame(playerResourcesDisplaySet);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x0027AF1C File Offset: 0x0027911C
		public PlayerResourceSetsManager()
		{
		}

		// Token: 0x04008881 RID: 34945
		private Dictionary<string, IPlayerResourcesDisplaySet> _sets;

		// Token: 0x04008882 RID: 34946
		private IPlayerResourcesDisplaySet _activeSet;

		// Token: 0x04008883 RID: 34947
		private string _activeSetConfigKey;

		// Token: 0x04008884 RID: 34948
		private bool _loadedContent;

		// Token: 0x04008885 RID: 34949
		[CompilerGenerated]
		private string <ActiveSetKeyName>k__BackingField;

		// Token: 0x02000A85 RID: 2693
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004FA2 RID: 20386 RVA: 0x0027AF30 File Offset: 0x00279130
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06004FA3 RID: 20387 RVA: 0x0027AF44 File Offset: 0x00279144
			internal bool <SetActive>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				string text = this.name;
				bool flag;
				return flag;
			}

			// Token: 0x04008886 RID: 34950
			public string name;
		}

		// Token: 0x02000A86 RID: 2694
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06004FA4 RID: 20388 RVA: 0x0027AF5C File Offset: 0x0027915C
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x0027AF70 File Offset: 0x00279170
			internal bool <CycleResourceSet>b__0(IPlayerResourcesDisplaySet frame)
			{
				IPlayerResourcesDisplaySet activeSet = this.<>4__this._activeSet;
				this.lastFrame = frame;
				return true;
			}

			// Token: 0x04008887 RID: 34951
			public PlayerResourceSetsManager <>4__this;

			// Token: 0x04008888 RID: 34952
			public IPlayerResourcesDisplaySet lastFrame;
		}
	}
}
