using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000045 RID: 69
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public class Renderer : Component
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		private Material GetMaterial()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002CF8 File Offset: 0x00000EF8
		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		private Material GetSharedMaterial()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002D0C File Offset: 0x00000F0C
		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		private void SetMaterial(Material m)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002D20 File Offset: 0x00000F20
		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		private void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002D34 File Offset: 0x00000F34
		public int sortingLayerID
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002D48 File Offset: 0x00000F48
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002D5C File Offset: 0x00000F5C
		public int sortingOrder
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

		// Token: 0x17000023 RID: 35
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002D70 File Offset: 0x00000F70
		public Material[] materials
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002D84 File Offset: 0x00000F84
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002D98 File Offset: 0x00000F98
		public Material material
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002DAC File Offset: 0x00000FAC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public Material sharedMaterial
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
	}
}
