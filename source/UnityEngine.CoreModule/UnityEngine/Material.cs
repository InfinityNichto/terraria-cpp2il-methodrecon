using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005E RID: 94
	[NativeHeader("Runtime/Shaders/Material.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public class Material : Object
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00004490 File Offset: 0x00002690
		[FreeFunction("MaterialScripting::CreateWithShader")]
		private static void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000044A4 File Offset: 0x000026A4
		[FreeFunction("MaterialScripting::CreateWithMaterial")]
		private static void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000044B8 File Offset: 0x000026B8
		[FreeFunction("MaterialScripting::CreateWithString")]
		private static void CreateWithString([Writable] Material self)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000044CC File Offset: 0x000026CC
		public Material(Shader shader)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000044E8 File Offset: 0x000026E8
		[RequiredByNativeCode]
		public Material(Material source)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004504 File Offset: 0x00002704
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
		public Material(string contents)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00004520 File Offset: 0x00002720
		public Shader shader
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00004534 File Offset: 0x00002734
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00004554 File Offset: 0x00002754
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00004568 File Offset: 0x00002768
		public Texture mainTexture
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000458C File Offset: 0x0000278C
		[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
		private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000045A0 File Offset: 0x000027A0
		[NativeName("HasPropertyFromScript")]
		public bool HasProperty(int nameID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000045B4 File Offset: 0x000027B4
		public bool HasProperty(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000056 RID: 86
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000045CC File Offset: 0x000027CC
		public int renderQueue
		{
			[NativeName("SetCustomRenderQueue")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000045E0 File Offset: 0x000027E0
		public void EnableKeyword(string keyword)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000045F4 File Offset: 0x000027F4
		public void DisableKeyword(string keyword)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00004608 File Offset: 0x00002808
		[NativeName("SetFloatFromScript")]
		private void SetFloatImpl(int name, float value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000461C File Offset: 0x0000281C
		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004630 File Offset: 0x00002830
		[NativeName("SetTextureFromScript")]
		private void SetTextureImpl(int name, Texture value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004644 File Offset: 0x00002844
		[NativeName("GetColorFromScript")]
		private Color GetColorImpl(int name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004658 File Offset: 0x00002858
		[NativeName("GetTextureFromScript")]
		private Texture GetTextureImpl(int name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000466C File Offset: 0x0000286C
		public void SetFloat(string name, float value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00004688 File Offset: 0x00002888
		public void SetFloat(int nameID, float value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000469C File Offset: 0x0000289C
		public void SetColor(string name, Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000046B0 File Offset: 0x000028B0
		public void SetColor(int nameID, Color value)
		{
			this.SetColorImpl(nameID, value);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000046C8 File Offset: 0x000028C8
		public void SetVector(int nameID, Vector4 value)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000046D8 File Offset: 0x000028D8
		public void SetTexture(int nameID, Texture value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000046EC File Offset: 0x000028EC
		public Color GetColor(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00004700 File Offset: 0x00002900
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00004714 File Offset: 0x00002914
		public Texture GetTexture(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000472C File Offset: 0x0000292C
		public Texture GetTexture(int nameID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00004740 File Offset: 0x00002940
		private void SetColorImpl_Injected(int name, Color value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00004754 File Offset: 0x00002954
		private void GetColorImpl_Injected(int name, [Out] Color ret)
		{
			throw new MissingMethodException();
		}
	}
}
