using System;
using System.Runtime.CompilerServices;

namespace System.Net.Mime
{
	// Token: 0x02000325 RID: 805
	internal class Base64WriteStateInfo : WriteStateInfoBase
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x0003F3C0 File Offset: 0x0003D5C0
		internal Base64WriteStateInfo()
		{
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0003F3D4 File Offset: 0x0003D5D4
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0003F3E8 File Offset: 0x0003D5E8
		internal int Padding
		{
			[CompilerGenerated]
			get
			{
				return this.<Padding>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Padding>k__BackingField = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0003F3FC File Offset: 0x0003D5FC
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0003F410 File Offset: 0x0003D610
		internal byte LastBits
		{
			[CompilerGenerated]
			get
			{
				return this.<LastBits>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LastBits>k__BackingField = value;
			}
		}

		// Token: 0x0400115C RID: 4444
		[CompilerGenerated]
		private int <Padding>k__BackingField;

		// Token: 0x0400115D RID: 4445
		[CompilerGenerated]
		private byte <LastBits>k__BackingField;
	}
}
