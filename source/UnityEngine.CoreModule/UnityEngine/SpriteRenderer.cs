using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E7 RID: 231
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x00008EE0 File Offset: 0x000070E0
		[RequiredByNativeCode]
		private void InvokeSpriteChanged()
		{
			if (this.m_SpriteChangeEvent != null)
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00008EF8 File Offset: 0x000070F8
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00008F0C File Offset: 0x0000710C
		public Sprite sprite
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00008F20 File Offset: 0x00007120
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00008F34 File Offset: 0x00007134
		public Color color
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00008F48 File Offset: 0x00007148
		private void get_color_Injected([Out] Color ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00008F5C File Offset: 0x0000715C
		private void set_color_Injected(Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040003FC RID: 1020
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;
	}
}
