using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A8F RID: 2703
	public class EmotesGroupListItem : UIElement
	{
		// Token: 0x06004FDA RID: 20442 RVA: 0x0027B91C File Offset: 0x00279B1C
		public EmotesGroupListItem(LocalizedText groupTitle, int groupIndex, int maxEmotesPerRow, params int[] emotes)
		{
			int num = 10;
			this._maxEmotesPerRow = num;
			if (num == 0)
			{
			}
			base..ctor();
			int num2 = 14;
			this._groupIndex = groupIndex;
			this._maxEmotesPerRow = num2;
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x0027B9B8 File Offset: 0x00279BB8
		public override int CompareTo(object obj)
		{
			if (obj != null)
			{
			}
			return base.CompareTo(obj);
		}

		// Token: 0x040088B1 RID: 34993
		private const int TITLE_HEIGHT = 20;

		// Token: 0x040088B2 RID: 34994
		private const int SEPARATOR_HEIGHT = 10;

		// Token: 0x040088B3 RID: 34995
		private const int SIZE_PER_EMOTE = 36;

		// Token: 0x040088B4 RID: 34996
		private Asset<Texture2D> _tempTex;

		// Token: 0x040088B5 RID: 34997
		private int _groupIndex;

		// Token: 0x040088B6 RID: 34998
		private int _maxEmotesPerRow;
	}
}
