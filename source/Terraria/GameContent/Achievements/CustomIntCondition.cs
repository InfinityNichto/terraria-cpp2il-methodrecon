using System;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009AC RID: 2476
	public class CustomIntCondition : AchievementCondition
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x00261E40 File Offset: 0x00260040
		// (set) Token: 0x06004942 RID: 18754 RVA: 0x00261E54 File Offset: 0x00260054
		public int Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (!true)
				{
				}
				if (this._tracker != null)
				{
				}
				int maxValue = this._maxValue;
				this._value = value;
			}
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00261E84 File Offset: 0x00260084
		private CustomIntCondition(string name, int maxValue)
			: base(name)
		{
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00261E98 File Offset: 0x00260098
		public override void Clear()
		{
			base.Clear();
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x00261EAC File Offset: 0x002600AC
		public override void Load(JObject state)
		{
			base.Load(state);
			JToken jtoken;
			int num = (int)jtoken;
			IAchievementTracker tracker = this._tracker;
			this._value = num;
			if (tracker != null)
			{
				return;
			}
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x000021DB File Offset: 0x000003DB
		protected override IAchievementTracker CreateAchievementTracker()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(string name, int maxValue)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00261EE0 File Offset: 0x002600E0
		public override void Complete()
		{
			if (this._tracker != null)
			{
				int maxValue = this._maxValue;
			}
			int maxValue2 = this._maxValue;
			this._value = maxValue2;
			base.Complete();
		}

		// Token: 0x0400843A RID: 33850
		[JsonProperty("Value")]
		private int _value;

		// Token: 0x0400843B RID: 33851
		private int _maxValue;
	}
}
