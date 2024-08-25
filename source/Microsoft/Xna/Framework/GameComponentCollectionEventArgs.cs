using System;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200033B RID: 827
	public class GameComponentCollectionEventArgs : EventArgs
	{
		// Token: 0x060014E5 RID: 5349 RVA: 0x0005F7E4 File Offset: 0x0005D9E4
		public GameComponentCollectionEventArgs(IGameComponent gameComponent)
		{
			if (!true)
			{
			}
			base..ctor();
			this._gameComponent = gameComponent;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0005F804 File Offset: 0x0005DA04
		public IGameComponent GameComponent
		{
			get
			{
				return this._gameComponent;
			}
		}

		// Token: 0x040022C4 RID: 8900
		private IGameComponent _gameComponent;
	}
}
