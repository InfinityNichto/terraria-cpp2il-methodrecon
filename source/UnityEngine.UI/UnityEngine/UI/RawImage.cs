using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200005C RID: 92
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Raw Image", 12)]
	public class RawImage : MaskableGraphic
	{
		// Token: 0x0600036E RID: 878 RVA: 0x0000B410 File Offset: 0x00009610
		protected RawImage()
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000B424 File Offset: 0x00009624
		public override Texture mainTexture
		{
			get
			{
				Texture texture;
				return texture;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000B43C File Offset: 0x0000963C
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000B450 File Offset: 0x00009650
		public Texture texture
		{
			get
			{
				return this.m_Texture;
			}
			set
			{
				Texture texture = this.m_Texture;
				if (!true)
				{
				}
				bool flag = texture == value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000B478 File Offset: 0x00009678
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000B4B4 File Offset: 0x000096B4
		public Rect uvRect
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000372)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect UnityEngine.UI.RawImage::get_uvRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Rect::m_XMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](RawImage::m_UVRect, ldloc:RawImage(this))))
	stloc:float32(var_1_17, ldfld:float32(Rect::m_YMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](RawImage::m_UVRect, ldloc:RawImage(this))))
	stloc:float32(var_2_23, ldfld:float32(Rect::m_Width, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](RawImage::m_UVRect, ldloc:RawImage(this))))
	stloc:float32(var_3_2F, ldfld:float32(Rect::m_Height, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](RawImage::m_UVRect, ldloc:RawImage(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				float xmin = this.m_UVRect.m_XMin;
				float ymin = this.m_UVRect.m_YMin;
				float width = this.m_UVRect.m_Width;
				float height = this.m_UVRect.m_Height;
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000B4F8 File Offset: 0x000096F8
		public override void SetNativeSize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000B530 File Offset: 0x00009730
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			vh.Clear();
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float x = pixelAdjustedRect.x;
			float y = pixelAdjustedRect.y;
			float x2 = pixelAdjustedRect.x;
			float width = pixelAdjustedRect.width;
			float y2 = pixelAdjustedRect.y;
			float height = pixelAdjustedRect.height;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B5D4 File Offset: 0x000097D4
		protected override void OnDidApplyAnimationProperties()
		{
			base.SetRaycastDirty();
		}

		// Token: 0x040001AD RID: 429
		[SerializeField]
		[FormerlySerializedAs("m_Tex")]
		private Texture m_Texture;

		// Token: 0x040001AE RID: 430
		[SerializeField]
		private Rect m_UVRect;
	}
}
