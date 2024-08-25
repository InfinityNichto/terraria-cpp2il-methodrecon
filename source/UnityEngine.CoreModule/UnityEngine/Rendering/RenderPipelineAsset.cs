using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000114 RID: 276
	public abstract class RenderPipelineAsset : ScriptableObject
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x00009E54 File Offset: 0x00008054
		internal RenderPipeline InternalCreatePipeline()
		{
			throw new InvalidCastException();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00009E6C File Offset: 0x0000806C
		public virtual string[] renderingLayerMaskNames
		{
			get
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00009E7C File Offset: 0x0000807C
		public virtual string[] prefixedRenderingLayerMaskNames
		{
			get
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00009E8C File Offset: 0x0000808C
		public virtual Material defaultMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00009E9C File Offset: 0x0000809C
		public virtual Shader autodeskInteractiveShader
		{
			get
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00009EAC File Offset: 0x000080AC
		public virtual Shader autodeskInteractiveTransparentShader
		{
			get
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00009EBC File Offset: 0x000080BC
		public virtual Shader autodeskInteractiveMaskedShader
		{
			get
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00009ECC File Offset: 0x000080CC
		public virtual Shader terrainDetailLitShader
		{
			get
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00009EDC File Offset: 0x000080DC
		public virtual Shader terrainDetailGrassShader
		{
			get
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00009EEC File Offset: 0x000080EC
		public virtual Shader terrainDetailGrassBillboardShader
		{
			get
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00009EFC File Offset: 0x000080FC
		public virtual Material defaultParticleMaterial
		{
			get
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00009F0C File Offset: 0x0000810C
		public virtual Material defaultLineMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00009F1C File Offset: 0x0000811C
		public virtual Material defaultTerrainMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00009F2C File Offset: 0x0000812C
		public virtual Material defaultUIMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00009F3C File Offset: 0x0000813C
		public virtual Material defaultUIOverdrawMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00009F4C File Offset: 0x0000814C
		public virtual Material defaultUIETC1SupportedMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00009F5C File Offset: 0x0000815C
		public virtual Material default2DMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00009F6C File Offset: 0x0000816C
		public virtual Material default2DMaskMaterial
		{
			get
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00009F7C File Offset: 0x0000817C
		public virtual Shader defaultShader
		{
			get
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00009F8C File Offset: 0x0000818C
		public virtual Shader defaultSpeedTree7Shader
		{
			get
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00009F9C File Offset: 0x0000819C
		public virtual Shader defaultSpeedTree8Shader
		{
			get
			{
			}
		}

		// Token: 0x0600059C RID: 1436
		protected abstract RenderPipeline CreatePipeline();

		// Token: 0x0600059D RID: 1437 RVA: 0x00009FAC File Offset: 0x000081AC
		protected virtual void OnValidate()
		{
			if (!true)
			{
			}
			RenderPipelineManager.CleanupRenderPipeline();
			RenderPipelineManager.PrepareRenderPipeline(this);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00009FC8 File Offset: 0x000081C8
		protected virtual void OnDisable()
		{
			if (!true)
			{
			}
			RenderPipelineManager.CleanupRenderPipeline();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00009FE0 File Offset: 0x000081E0
		protected RenderPipelineAsset()
		{
		}
	}
}
