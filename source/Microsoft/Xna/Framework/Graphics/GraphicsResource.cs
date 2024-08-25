using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200037F RID: 895
	public abstract class GraphicsResource
	{
		// Token: 0x060017B2 RID: 6066 RVA: 0x000659CC File Offset: 0x00063BCC
		internal GraphicsResource()
		{
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000659E0 File Offset: 0x00063BE0
		public void Dispose()
		{
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000659F0 File Offset: 0x00063BF0
		protected internal virtual void GraphicsDeviceResetting()
		{
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060017B5 RID: 6069 RVA: 0x00065A00 File Offset: 0x00063C00
		// (remove) Token: 0x060017B6 RID: 6070 RVA: 0x00065A28 File Offset: 0x00063C28
		public event EventHandler<EventArgs> Disposing
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Disposing, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Disposing, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00065A50 File Offset: 0x00063C50
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00065A64 File Offset: 0x00063C64
		public GraphicsDevice GraphicsDevice
		{
			get
			{
				return this.graphicsDevice;
			}
			internal set
			{
				GraphicsDevice graphicsDevice = this.graphicsDevice;
				this.graphicsDevice = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00065A80 File Offset: 0x00063C80
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00065A94 File Offset: 0x00063C94
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00065AA8 File Offset: 0x00063CA8
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00065ABC File Offset: 0x00063CBC
		public object Tag
		{
			[CompilerGenerated]
			get
			{
				return this.<Tag>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tag>k__BackingField = value;
			}
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00065AD0 File Offset: 0x00063CD0
		public override string ToString()
		{
			bool flag = string.IsNullOrEmpty(this.<Name>k__BackingField);
			return base.ToString();
		}

		// Token: 0x0400261F RID: 9759
		private GraphicsDevice graphicsDevice;

		// Token: 0x04002620 RID: 9760
		[CompilerGenerated]
		private EventHandler<EventArgs> Disposing;

		// Token: 0x04002621 RID: 9761
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002622 RID: 9762
		[CompilerGenerated]
		private object <Tag>k__BackingField;
	}
}
