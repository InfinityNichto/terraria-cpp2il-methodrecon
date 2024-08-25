using System;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200033E RID: 830
	public interface IUpdateable
	{
		// Token: 0x060014EF RID: 5359
		void Update(GameTime gameTime);

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060014F0 RID: 5360
		// (remove) Token: 0x060014F1 RID: 5361
		event EventHandler<EventArgs> EnabledChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060014F2 RID: 5362
		// (remove) Token: 0x060014F3 RID: 5363
		event EventHandler<EventArgs> UpdateOrderChanged;

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060014F4 RID: 5364
		bool Enabled { get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060014F5 RID: 5365
		int UpdateOrder { get; }
	}
}
