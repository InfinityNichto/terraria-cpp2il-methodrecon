using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Light.h")]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Light : Behaviour
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002BCC File Offset: 0x00000DCC
		public LightShadows shadows
		{
			[NativeMethod("GetShadowType")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public float cookieSize
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public Texture cookie
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002C08 File Offset: 0x00000E08
		[NativeProperty("LightType")]
		public LightType type
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002C1C File Offset: 0x00000E1C
		public float spotAngle
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002C30 File Offset: 0x00000E30
		public Color color
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002C44 File Offset: 0x00000E44
		public float colorTemperature
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002C58 File Offset: 0x00000E58
		public bool useColorTemperature
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002C6C File Offset: 0x00000E6C
		public float intensity
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002C80 File Offset: 0x00000E80
		public float bounceIntensity
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002C94 File Offset: 0x00000E94
		public float range
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public LightBakingOutput bakingOutput
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002CBC File Offset: 0x00000EBC
		private void get_color_Injected([Out] Color ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private void get_bakingOutput_Injected([Out] LightBakingOutput ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400020F RID: 527
		private int m_BakedIndex;
	}
}
