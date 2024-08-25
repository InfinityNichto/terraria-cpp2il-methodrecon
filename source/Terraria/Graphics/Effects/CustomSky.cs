using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000780 RID: 1920
	public abstract class CustomSky : GameEffect
	{
		// Token: 0x06003EDF RID: 16095
		public abstract void Update(GameTime gameTime);

		// Token: 0x06003EE0 RID: 16096
		public abstract void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth);

		// Token: 0x06003EE1 RID: 16097
		public abstract bool IsActive();

		// Token: 0x06003EE2 RID: 16098
		public abstract void Reset();

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0023F5F4 File Offset: 0x0023D7F4
		public virtual Color OnTileColor(Color inColor)
		{
			Color color;
			return color;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual float GetCloudAlpha()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0023F604 File Offset: 0x0023D804
		public override bool IsVisible()
		{
			return true;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0023F614 File Offset: 0x0023D814
		protected CustomSky()
		{
		}
	}
}
