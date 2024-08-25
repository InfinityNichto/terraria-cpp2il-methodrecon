using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004D8 RID: 1240
	public class ManifestResourceInfo
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x0005076C File Offset: 0x0004E96C
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
			this.ReferencedAssembly = containingAssembly;
			this.FileName = containingFileName;
			this.ResourceLocation = resourceLocation;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00050794 File Offset: 0x0004E994
		public virtual Assembly ReferencedAssembly
		{
			[CompilerGenerated]
			get
			{
				return this.<ReferencedAssembly>k__BackingField;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000507A8 File Offset: 0x0004E9A8
		public virtual string FileName
		{
			[CompilerGenerated]
			get
			{
				return this.<FileName>k__BackingField;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000507BC File Offset: 0x0004E9BC
		public virtual ResourceLocation ResourceLocation
		{
			[CompilerGenerated]
			get
			{
				return this.<ResourceLocation>k__BackingField;
			}
		}

		// Token: 0x040013B0 RID: 5040
		[CompilerGenerated]
		private readonly Assembly <ReferencedAssembly>k__BackingField;

		// Token: 0x040013B1 RID: 5041
		[CompilerGenerated]
		private readonly string <FileName>k__BackingField;

		// Token: 0x040013B2 RID: 5042
		[CompilerGenerated]
		private readonly ResourceLocation <ResourceLocation>k__BackingField;
	}
}
