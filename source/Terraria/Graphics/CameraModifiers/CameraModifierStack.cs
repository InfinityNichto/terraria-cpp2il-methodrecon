using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x0200076F RID: 1903
	public class CameraModifierStack
	{
		// Token: 0x06003E67 RID: 15975 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(ICameraModifier modifier)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0023D2EC File Offset: 0x0023B4EC
		private void RemoveIdenticalModifiers(ICameraModifier modifier)
		{
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0023D31C File Offset: 0x0023B51C
		public void ApplyTo(Vector2 cameraPosition)
		{
			float x = cameraPosition.X;
			float y = cameraPosition.Y;
			this.ClearFinishedModifiers();
			int size = this._modifiers._size;
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0023D364 File Offset: 0x0023B564
		private void ClearFinishedModifiers()
		{
			int size = this._modifiers._size;
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x0023D390 File Offset: 0x0023B590
		public CameraModifierStack()
		{
		}

		// Token: 0x04007D20 RID: 32032
		private List<ICameraModifier> _modifiers;
	}
}
