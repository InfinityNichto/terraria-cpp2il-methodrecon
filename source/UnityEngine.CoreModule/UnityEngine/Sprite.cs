using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E9 RID: 233
	[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType("Runtime/Graphics/SpriteFrame.h")]
	public sealed class Sprite : Object
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00008F70 File Offset: 0x00007170
		[RequiredByNativeCode]
		private Sprite()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00008F88 File Offset: 0x00007188
		internal int GetPackingMode()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00008F9C File Offset: 0x0000719C
		internal int GetPacked()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00008FB0 File Offset: 0x000071B0
		internal Rect GetTextureRect()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00008FC4 File Offset: 0x000071C4
		internal Vector4 GetInnerUVs()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00008FD8 File Offset: 0x000071D8
		internal Vector4 GetOuterUVs()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00008FEC File Offset: 0x000071EC
		internal Vector4 GetPadding()
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00009000 File Offset: 0x00007200
		public Bounds bounds
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00009014 File Offset: 0x00007214
		public Rect rect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00009028 File Offset: 0x00007228
		public Vector4 border
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000903C File Offset: 0x0000723C
		public Texture2D texture
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00009050 File Offset: 0x00007250
		public float pixelsPerUnit
		{
			[NativeMethod("GetPixelsToUnits")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00009064 File Offset: 0x00007264
		public Texture2D associatedAlphaSplitTexture
		{
			[NativeMethod("GetAlphaTexture")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00009078 File Offset: 0x00007278
		public Vector2 pivot
		{
			[NativeMethod("GetPivotInPixels")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000908C File Offset: 0x0000728C
		public bool packed
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000090A0 File Offset: 0x000072A0
		public SpritePackingMode packingMode
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000090B4 File Offset: 0x000072B4
		public Rect textureRect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000090DC File Offset: 0x000072DC
		public Vector2[] vertices
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000090F0 File Offset: 0x000072F0
		public ushort[] triangles
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00009104 File Offset: 0x00007304
		public Vector2[] uv
		{
			[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00009118 File Offset: 0x00007318
		private void GetTextureRect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000912C File Offset: 0x0000732C
		private void GetInnerUVs_Injected([Out] Vector4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00009140 File Offset: 0x00007340
		private void GetOuterUVs_Injected([Out] Vector4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00009154 File Offset: 0x00007354
		private void GetPadding_Injected([Out] Vector4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00009168 File Offset: 0x00007368
		private void get_bounds_Injected([Out] Bounds ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000917C File Offset: 0x0000737C
		private void get_rect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00009190 File Offset: 0x00007390
		private void get_border_Injected([Out] Vector4 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000091A4 File Offset: 0x000073A4
		private void get_pivot_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}
	}
}
