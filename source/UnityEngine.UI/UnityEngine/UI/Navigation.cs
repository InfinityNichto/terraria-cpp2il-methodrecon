using System;
using Cpp2IlInjected;

namespace UnityEngine.UI
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public struct Navigation : IEquatable<Navigation>
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0000B2AC File Offset: 0x000094AC
		public Navigation.Mode mode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000B2C0 File Offset: 0x000094C0
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0000B2D4 File Offset: 0x000094D4
		public bool wrapAround
		{
			get
			{
				return this.m_WrapAround;
			}
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000B2E4 File Offset: 0x000094E4
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public Selectable selectOnUp
		{
			get
			{
				return this.m_SelectOnUp;
			}
			set
			{
				this.m_SelectOnUp = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000B30C File Offset: 0x0000950C
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000B320 File Offset: 0x00009520
		public Selectable selectOnDown
		{
			get
			{
				return this.m_SelectOnDown;
			}
			set
			{
				this.m_SelectOnDown = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000B334 File Offset: 0x00009534
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000B348 File Offset: 0x00009548
		public Selectable selectOnLeft
		{
			get
			{
				return this.m_SelectOnLeft;
			}
			set
			{
				this.m_SelectOnLeft = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000B35C File Offset: 0x0000955C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000B370 File Offset: 0x00009570
		public Selectable selectOnRight
		{
			get
			{
				return this.m_SelectOnRight;
			}
			set
			{
				this.m_SelectOnRight = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000B384 File Offset: 0x00009584
		public static Navigation defaultNavigation
		{
			get
			{
				Navigation navigation;
				navigation.m_Mode = Navigation.Mode.Automatic;
				return navigation;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000B39C File Offset: 0x0000959C
		public bool Equals(Navigation other)
		{
			Selectable selectOnUp = this.m_SelectOnUp;
			Selectable selectOnUp2 = other.m_SelectOnUp;
			bool flag = selectOnUp == selectOnUp2;
			Selectable selectOnDown = this.m_SelectOnDown;
			Selectable selectOnDown2 = other.m_SelectOnDown;
			bool flag2 = selectOnDown == selectOnDown2;
			Selectable selectOnLeft = this.m_SelectOnLeft;
			Selectable selectOnLeft2 = other.m_SelectOnLeft;
			bool flag3 = selectOnLeft == selectOnLeft2;
			Selectable selectOnRight = this.m_SelectOnRight;
			Selectable selectOnRight2 = other.m_SelectOnRight;
			return selectOnRight == selectOnRight2;
		}

		// Token: 0x040001A1 RID: 417
		[SerializeField]
		private Navigation.Mode m_Mode;

		// Token: 0x040001A2 RID: 418
		[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
		[SerializeField]
		private bool m_WrapAround;

		// Token: 0x040001A3 RID: 419
		[SerializeField]
		private Selectable m_SelectOnUp;

		// Token: 0x040001A4 RID: 420
		[SerializeField]
		private Selectable m_SelectOnDown;

		// Token: 0x040001A5 RID: 421
		[SerializeField]
		private Selectable m_SelectOnLeft;

		// Token: 0x040001A6 RID: 422
		[SerializeField]
		private Selectable m_SelectOnRight;

		// Token: 0x0200005B RID: 91
		[Flags]
		public enum Mode
		{
			// Token: 0x040001A8 RID: 424
			None = 0,
			// Token: 0x040001A9 RID: 425
			Horizontal = 1,
			// Token: 0x040001AA RID: 426
			Vertical = 2,
			// Token: 0x040001AB RID: 427
			Automatic = 3,
			// Token: 0x040001AC RID: 428
			Explicit = 4
		}
	}
}
