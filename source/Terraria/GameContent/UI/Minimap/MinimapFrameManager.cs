using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000A8C RID: 2700
	public class MinimapFrameManager : SelectionHolder<MinimapFrame>
	{
		// Token: 0x06004FC8 RID: 20424 RVA: 0x0027B5CC File Offset: 0x002797CC
		protected override void Configuration_OnLoad(Preferences obj)
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x0027B5E4 File Offset: 0x002797E4
		protected override void Configuration_Save(Preferences obj)
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x0027B5F4 File Offset: 0x002797F4
		protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
		{
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x0027B604 File Offset: 0x00279804
		private void CreateAndAdd(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
		{
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x0027B614 File Offset: 0x00279814
		public void DrawTo(SpriteBatch spriteBatch, Vector2 position)
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x0027B624 File Offset: 0x00279824
		public void DrawForeground(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x0027B634 File Offset: 0x00279834
		public MinimapFrameManager()
		{
		}
	}
}
