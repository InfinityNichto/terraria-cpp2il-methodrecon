using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x0200071A RID: 1818
	[DebuggerDisplay("Snap Point - {Name} {Id}")]
	public class SnapPoint
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00235A40 File Offset: 0x00233C40
		// (set) Token: 0x06003C27 RID: 15399 RVA: 0x00235A54 File Offset: 0x00233C54
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x00235A68 File Offset: 0x00233C68
		// (set) Token: 0x06003C29 RID: 15401 RVA: 0x00235A90 File Offset: 0x00233C90
		public Vector2 Position
		{
			[CompilerGenerated]
			get
			{
				float x = this.<Position>k__BackingField.X;
				float y = this.<Position>k__BackingField.Y;
				Vector2 vector;
				return vector;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00235AA0 File Offset: 0x00233CA0
		public SnapPoint(string name, int id, Vector2 anchor, Vector2 offset)
		{
			this.Name = name;
			this.Id = id;
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00235AC4 File Offset: 0x00233CC4
		public void Calculate(UIElement element)
		{
			float x = element._dimensions.X;
			float x2 = this._offset.X;
			float y = this._offset.Y;
			if (!true)
			{
			}
			float x3 = this._anchor.X;
			float y2 = this._anchor.Y;
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00235B1C File Offset: 0x00233D1C
		public void ThisIsAHackThatChangesTheSnapPointsInfo(Vector2 anchor, Vector2 offset, int id)
		{
			this.<Id>k__BackingField = anchor;
		}

		// Token: 0x04007B77 RID: 31607
		public string Name;

		// Token: 0x04007B78 RID: 31608
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04007B79 RID: 31609
		[CompilerGenerated]
		private Vector2 <Position>k__BackingField;

		// Token: 0x04007B7A RID: 31610
		private Vector2 _anchor;

		// Token: 0x04007B7B RID: 31611
		private Vector2 _offset;
	}
}
