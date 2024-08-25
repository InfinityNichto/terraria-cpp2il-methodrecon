using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200074F RID: 1871
	public class ParticleRenderer
	{
		// Token: 0x06003DAB RID: 15787 RVA: 0x00239D84 File Offset: 0x00237F84
		public ParticleRenderer()
		{
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(IParticle particle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00239D98 File Offset: 0x00237F98
		public void Update()
		{
			int size = this.Particles._size;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00239DD4 File Offset: 0x00237FD4
		public void Draw(SpriteBatch spriteBatch)
		{
			int size = this.Particles._size;
		}

		// Token: 0x04007C6B RID: 31851
		public ParticleRendererSettings Settings;

		// Token: 0x04007C6C RID: 31852
		public List<IParticle> Particles;
	}
}
