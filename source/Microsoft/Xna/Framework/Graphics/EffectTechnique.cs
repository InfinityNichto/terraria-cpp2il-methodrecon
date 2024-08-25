using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000368 RID: 872
	public class EffectTechnique
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0006358C File Offset: 0x0006178C
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x000635A0 File Offset: 0x000617A0
		public EffectPassCollection Passes
		{
			[CompilerGenerated]
			get
			{
				return this.<Passes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Passes>k__BackingField = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000635B4 File Offset: 0x000617B4
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x000635C8 File Offset: 0x000617C8
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

		// Token: 0x060016CA RID: 5834 RVA: 0x000635DC File Offset: 0x000617DC
		internal EffectTechnique(Effect effect, EffectTechnique cloneSource)
		{
			string text = cloneSource.<Name>k__BackingField;
			this.Name = text;
			EffectPassCollection effectPassCollection = cloneSource.<Passes>k__BackingField.Clone(effect);
			this.Passes = effectPassCollection;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00063614 File Offset: 0x00061814
		internal EffectTechnique(Effect effect, string name, EffectPassCollection passes)
		{
			this.Passes = passes;
			this.Name = name;
		}

		// Token: 0x040024E9 RID: 9449
		[CompilerGenerated]
		private EffectPassCollection <Passes>k__BackingField;

		// Token: 0x040024EA RID: 9450
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
