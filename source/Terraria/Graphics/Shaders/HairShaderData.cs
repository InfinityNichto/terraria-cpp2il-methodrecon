using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x02000748 RID: 1864
	public class HairShaderData : ShaderData
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00239118 File Offset: 0x00237318
		public bool ShaderDisabled
		{
			get
			{
				return this._shaderDisabled;
			}
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x0023912C File Offset: 0x0023732C
		public HairShaderData(Ref<Effect> shader, string passName)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._uSecondaryColor.Z = (float)1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._shader = shader;
			this._passName = passName;
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x0023916C File Offset: 0x0023736C
		public virtual void Apply(Player player, [Optional] DrawData? drawData)
		{
			bool shaderDisabled = this._shaderDisabled;
			!0 value = this._shader.Value;
			float x = this._uColor.X;
			float y = this._uColor.Y;
			float z = this._uColor.Z;
			!0 value2 = this._shader.Value;
			float uSaturation = this._uSaturation;
			!0 value3 = this._shader.Value;
			float x2 = this._uSecondaryColor.X;
			float y2 = this._uSecondaryColor.Y;
			float z2 = this._uSecondaryColor.Z;
			!0 value4 = this._shader.Value;
			if ("uColor" == null)
			{
			}
			!0 value5 = this._shader.Value;
			float uOpacity = this._uOpacity;
			!0 value6 = this._shader.Value;
			float x3 = this._uTargetPosition.X;
			float y3 = this._uTargetPosition.Y;
			!0 value7 = this._shader.Value;
			!0 value8 = this._shader.Value;
			if ("uColor" == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			!0 value9 = this._shader.Value;
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00239318 File Offset: 0x00237518
		public virtual Color GetColor(Player player, Color lightColor)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x0023932C File Offset: 0x0023752C
		public HairShaderData UseColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0023933C File Offset: 0x0023753C
		public HairShaderData UseColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x0023934C File Offset: 0x0023754C
		public HairShaderData UseColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x0023935C File Offset: 0x0023755C
		public HairShaderData UseImage(string path)
		{
			if (!true)
			{
			}
			return this;
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00239370 File Offset: 0x00237570
		public HairShaderData UseOpacity(float alpha)
		{
			return this;
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00239380 File Offset: 0x00237580
		public HairShaderData UseSecondaryColor(float r, float g, float b)
		{
			return this;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00239390 File Offset: 0x00237590
		public HairShaderData UseSecondaryColor(Color color)
		{
			return this;
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x002393A0 File Offset: 0x002375A0
		public HairShaderData UseSecondaryColor(Vector3 color)
		{
			return this;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x002393B0 File Offset: 0x002375B0
		public HairShaderData UseSaturation(float saturation)
		{
			return this;
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x002393C0 File Offset: 0x002375C0
		public HairShaderData UseTargetPosition(Vector2 position)
		{
			return this;
		}

		// Token: 0x04007C46 RID: 31814
		protected Vector3 _uColor;

		// Token: 0x04007C47 RID: 31815
		protected Vector3 _uSecondaryColor;

		// Token: 0x04007C48 RID: 31816
		protected float _uSaturation;

		// Token: 0x04007C49 RID: 31817
		protected float _uOpacity;

		// Token: 0x04007C4A RID: 31818
		protected Asset<Texture2D> _uImage;

		// Token: 0x04007C4B RID: 31819
		protected bool _shaderDisabled;

		// Token: 0x04007C4C RID: 31820
		private Vector2 _uTargetPosition;
	}
}
