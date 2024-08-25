using System;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200033C RID: 828
	public interface IDrawable
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060014E7 RID: 5351
		int DrawOrder { get; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060014E8 RID: 5352
		bool Visible { get; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060014E9 RID: 5353
		// (remove) Token: 0x060014EA RID: 5354
		event EventHandler<EventArgs> DrawOrderChanged;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060014EB RID: 5355
		// (remove) Token: 0x060014EC RID: 5356
		event EventHandler<EventArgs> VisibleChanged;

		// Token: 0x060014ED RID: 5357
		void Draw(GameTime gameTime);
	}
}
