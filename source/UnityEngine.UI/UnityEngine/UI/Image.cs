using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Serialization;
using UnityEngine.Sprites;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	// Token: 0x02000022 RID: 34
	[AddComponentMenu("UI/Image", 11)]
	[RequireComponent(typeof(CanvasRenderer))]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004BC4 File Offset: 0x00002DC4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00004BD8 File Offset: 0x00002DD8
		public Sprite sprite
		{
			get
			{
				return this.m_Sprite;
			}
			set
			{
				Sprite sprite = this.m_Sprite;
				if (!true)
				{
				}
				Sprite sprite2 = this.m_Sprite;
				if (!true)
				{
				}
				bool flag = sprite2 != value;
				Vector2 size = this.m_Sprite.rect.size;
				if (!true)
				{
				}
				bool flag2 = value;
				Vector2 size2 = value.rect.size;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004C7C File Offset: 0x00002E7C
		public void DisableSpriteOptimizations()
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00004C8C File Offset: 0x00002E8C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public Sprite overrideSprite
		{
			get
			{
				return this.activeSprite;
			}
			set
			{
				this.TrackSprite();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00004CB4 File Offset: 0x00002EB4
		private Sprite activeSprite
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000140)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Sprite UnityEngine.UI.Image::get_activeSprite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:Sprite(var_0_06, ldfld:Sprite(Image::m_OverrideSprite, ldloc:Image(this)))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00004CCC File Offset: 0x00002ECC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public Image.Type type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00004CF0 File Offset: 0x00002EF0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00004D04 File Offset: 0x00002F04
		public bool preserveAspect
		{
			get
			{
				return this.m_PreserveAspect;
			}
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00004D14 File Offset: 0x00002F14
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00004D28 File Offset: 0x00002F28
		public bool fillCenter
		{
			get
			{
				return this.m_FillCenter;
			}
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00004D38 File Offset: 0x00002F38
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00004D4C File Offset: 0x00002F4C
		public Image.FillMethod fillMethod
		{
			get
			{
				return this.m_FillMethod;
			}
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00004D5C File Offset: 0x00002F5C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00004D70 File Offset: 0x00002F70
		public float fillAmount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_fillAmount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Image::m_FillAmount, ldloc:Image(this)))
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
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00004D80 File Offset: 0x00002F80
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00004D94 File Offset: 0x00002F94
		public bool fillClockwise
		{
			get
			{
				return this.m_FillClockwise;
			}
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00004DA4 File Offset: 0x00002FA4
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public int fillOrigin
		{
			get
			{
				return this.m_FillOrigin;
			}
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00004DC8 File Offset: 0x00002FC8
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00004DDC File Offset: 0x00002FDC
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600014F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_eventAlphaThreshold()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Image::m_AlphaHitTestMinimumThreshold, ldloc:Image(this)))
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
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00004DEC File Offset: 0x00002FEC
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00004E00 File Offset: 0x00003000
		public float alphaHitTestMinimumThreshold
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000151)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_alphaHitTestMinimumThreshold()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Image::m_AlphaHitTestMinimumThreshold, ldloc:Image(this)))
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
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00004E10 File Offset: 0x00003010
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00004E24 File Offset: 0x00003024
		public bool useSpriteMesh
		{
			get
			{
				return this.m_UseSpriteMesh;
			}
			set
			{
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00004E34 File Offset: 0x00003034
		protected Image()
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004E50 File Offset: 0x00003050
		public static Material defaultETC1GraphicMaterial
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000156)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Material UnityEngine.UI.Image::get_defaultETC1GraphicMaterial()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Material(var_2_0A, call:Material(Canvas::GetETC1SupportedCanvasMaterial))
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
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00004E68 File Offset: 0x00003068
		public override Texture mainTexture
		{
			get
			{
				Sprite activeSprite = this.activeSprite;
				Texture texture;
				return texture;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00004E8C File Offset: 0x0000308C
		public bool hasBorder
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000158)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Image::get_hasBorder()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Sprite(var_0_06, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this)))
	stloc:Vector4(var_2_12, callgetter:Vector4(Sprite::get_border, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
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
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00004EB0 File Offset: 0x000030B0
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00004EC4 File Offset: 0x000030C4
		public float pixelsPerUnitMultiplier
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000159)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_pixelsPerUnitMultiplier()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Image::m_PixelsPerUnitMultiplier, ldloc:Image(this)))
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
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00004ED4 File Offset: 0x000030D4
		public float pixelsPerUnit
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600015B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_pixelsPerUnit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, call:bool(Object::op_Implicit, callgetter:Sprite[exp:Object](Image::get_activeSprite, ldloc:Image(this))))
	stloc:float32(var_1_17, callgetter:float32(Sprite::get_pixelsPerUnit, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:bool(var_2_23, call:bool(Object::op_Implicit, callgetter:Canvas[exp:Object](Graphic::get_canvas, ldloc:Image[exp:Graphic](this))))
	stloc:float32(var_3_2F, callgetter:float32(Canvas::get_referencePixelsPerUnit, callgetter:Canvas(Graphic::get_canvas, ldloc:Image[exp:Graphic](this))))
	stloc:float32(var_4_36, ldfld:float32(Image::m_CachedReferencePixelsPerUnit, ldloc:Image(this)))
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
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004F18 File Offset: 0x00003118
		protected float multipliedPixelsPerUnit
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600015C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_multipliedPixelsPerUnit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, callgetter:float32(Image::get_pixelsPerUnit, ldloc:Image(this)))
	stloc:float32(var_1_0D, ldfld:float32(Image::m_PixelsPerUnitMultiplier, ldloc:Image(this)))
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
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00004F70 File Offset: 0x00003170
		public override Material material
		{
			get
			{
				Material material = this.m_Material;
				if (!true)
				{
				}
				return this.m_Material;
			}
			set
			{
				base.material = value;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00004F84 File Offset: 0x00003184
		public virtual void OnBeforeSerialize()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004F94 File Offset: 0x00003194
		public virtual void OnAfterDeserialize()
		{
			int fillOrigin = this.m_FillOrigin;
			Image.FillMethod fillMethod = this.m_FillMethod;
			float fillAmount = this.m_FillAmount;
			this.m_FillAmount = fillAmount;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004FC0 File Offset: 0x000031C0
		private void PreserveSpriteAspectRatio(Rect rect, Vector2 spriteSize)
		{
			float width = rect.width;
			float height = rect.height;
			float height2 = rect.height;
			float width2 = rect.width;
			rect.height = width2;
			float y = rect.y;
			float height3 = rect.height;
			Vector2 pivot = base.rectTransform.pivot;
			rect.y = height3;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005054 File Offset: 0x00003254
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			Vector4 padding = DataUtility.GetPadding(this.activeSprite);
			Sprite activeSprite = this.activeSprite;
			float width = this.activeSprite.rect.width;
			float height = this.activeSprite.rect.height;
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000050B8 File Offset: 0x000032B8
		public override void SetNativeSize()
		{
			Sprite activeSprite = this.activeSprite;
			float width = this.activeSprite.rect.width;
			float pixelsPerUnit = this.pixelsPerUnit;
			float height = this.activeSprite.rect.height;
			float pixelsPerUnit2 = this.pixelsPerUnit;
			RectTransform rectTransform = base.rectTransform;
			Vector2 anchorMin = base.rectTransform.anchorMin;
			RectTransform rectTransform2 = base.rectTransform;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000511C File Offset: 0x0000331C
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			Sprite activeSprite = this.activeSprite;
			base.OnPopulateMesh(toFill);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005188 File Offset: 0x00003388
		private void TrackSprite()
		{
			Sprite activeSprite = this.activeSprite;
			Texture2D texture = this.activeSprite.texture;
			Image.TrackImage(this);
			this.m_Tracked = true;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000051B8 File Offset: 0x000033B8
		protected override void OnEnable()
		{
			base.OnEnable();
			this.TrackSprite();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000051D4 File Offset: 0x000033D4
		protected override void OnDisable()
		{
			base.OnDisable();
			if (this.m_Tracked)
			{
				Image.UnTrackImage(this);
				return;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000051F8 File Offset: 0x000033F8
		protected override void UpdateMaterial()
		{
			base.UpdateMaterial();
			Sprite activeSprite = this.activeSprite;
			CanvasRenderer canvasRenderer = base.canvasRenderer;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005234 File Offset: 0x00003434
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			Canvas canvas = base.canvas;
			int num = 17096;
			this.m_CachedReferencePixelsPerUnit = (float)num;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005288 File Offset: 0x00003488
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
			Sprite activeSprite = this.activeSprite;
			Vector4 outerUV = DataUtility.GetOuterUV(this.activeSprite);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000530C File Offset: 0x0000350C
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
			float width = this.activeSprite.rect.width;
			float height = this.activeSprite.rect.height;
			Vector2 pivot = this.activeSprite.pivot;
			Vector2 pivot2 = base.rectTransform.pivot;
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			Vector3 size = this.activeSprite.bounds.size;
			vh.Clear();
			Vector2[] vertices = this.activeSprite.vertices;
			Vector2[] uv = this.activeSprite.uv;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000053AC File Offset: 0x000035AC
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
			bool hasBorder = this.hasBorder;
			Sprite activeSprite = this.activeSprite;
			Vector4 outerUV = DataUtility.GetOuterUV(this.activeSprite);
			Vector4 innerUV = DataUtility.GetInnerUV(this.activeSprite);
			Vector4 padding = DataUtility.GetPadding(this.activeSprite);
			Vector4 border = this.activeSprite.border;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005460 File Offset: 0x00003660
		private void GenerateTiledSprite(VertexHelper toFill)
		{
			Sprite activeSprite = this.activeSprite;
			Vector4 outerUV = DataUtility.GetOuterUV(this.activeSprite);
			Vector4 innerUV = DataUtility.GetInnerUV(this.activeSprite);
			Vector4 border = this.activeSprite.border;
			Vector2 size = this.activeSprite.rect.size;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005688 File Offset: 0x00003888
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
			int currentVertCount = vertexHelper.currentVertCount;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000056A0 File Offset: 0x000038A0
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
			int currentVertCount = vertexHelper.currentVertCount;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000056B4 File Offset: 0x000038B4
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			Rect rect = base.rectTransform.rect;
			long num = 0L;
			Vector2 size = rect.size;
			while (num == 0L)
			{
			}
			return 1;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000056DC File Offset: 0x000038DC
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
			long num = 0L;
			toFill.Clear();
			float fillAmount = this.m_FillAmount;
			Vector4 drawingDimensions = this.GetDrawingDimensions(num != 0L);
			Sprite activeSprite = this.activeSprite;
			Vector4 outerUV = DataUtility.GetOuterUV(this.activeSprite);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005804 File Offset: 0x00003A04
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return true;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005814 File Offset: 0x00003A14
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005828 File Offset: 0x00003A28
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005838 File Offset: 0x00003A38
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005848 File Offset: 0x00003A48
		public virtual float preferredWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000177)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_preferredWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Sprite(var_0_06, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this)))
	stloc:Type(var_2_0D, ldfld:Type(Image::m_Type, ldloc:Image(this)))
	stloc:Vector2(var_3_19, call:Vector2(DataUtility::GetMinSize, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:Vector2(var_5_21, callgetter:Vector2(Rect::get_size, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_4)))
	stloc:float32(var_6_29, callgetter:float32(Image::get_pixelsPerUnit, ldloc:Image(this)))
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
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00005880 File Offset: 0x00003A80
		public virtual float preferredHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600017A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Image::get_preferredHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Sprite(var_0_06, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this)))
	stloc:Type(var_2_0D, ldfld:Type(Image::m_Type, ldloc:Image(this)))
	stloc:Vector2(var_3_19, call:Vector2(DataUtility::GetMinSize, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:Vector2(var_5_21, callgetter:Vector2(Rect::get_size, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_4)))
	stloc:float32(var_6_29, callgetter:float32(Image::get_pixelsPerUnit, ldloc:Image(this)))
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
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000058B8 File Offset: 0x00003AB8
		public virtual int layoutPriority
		{
			get
			{
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000058C8 File Offset: 0x00003AC8
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			/*
An exception occurred when decompiling this method (0600017D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Image::IsRaycastLocationValid(UnityEngine.Vector2,UnityEngine.Camera)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Image::m_AlphaHitTestMinimumThreshold, ldloc:Image(this)))
	stloc:Sprite(var_1_0D, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this)))
	stloc:RectTransform(var_4_16, callgetter:RectTransform(Graphic::get_rectTransform, ldloc:Image[exp:Graphic](this)))
	stloc:Rect(var_6_1E, call:Rect(Graphic::GetPixelAdjustedRect, ldloc:Image[exp:Graphic](this)))
	stloc:Vector2(var_7_2B, callgetter:Vector2(RectTransform::get_pivot, callgetter:RectTransform(Graphic::get_rectTransform, ldloc:Image[exp:Graphic](this))))
	stloc:Vector2(var_9_38, callgetter:Vector2(RectTransform::get_pivot, callgetter:RectTransform(Graphic::get_rectTransform, ldloc:Image[exp:Graphic](this))))
	stloc:float32(var_12_4A, callgetter:float32(Rect::get_x, callgetter:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](Sprite::get_textureRect, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this)))))
	stloc:Texture2D(var_13_57, callgetter:Texture2D(Sprite::get_texture, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:Texture2D(var_15_64, callgetter:Texture2D(Sprite::get_texture, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:Texture2D(var_16_71, callgetter:Texture2D(Sprite::get_texture, callgetter:Sprite(Image::get_activeSprite, ldloc:Image(this))))
	stloc:float32(var_19_7C, ldfld:float32(Image::m_AlphaHitTestMinimumThreshold, ldloc:Image(this)))
	call:void(Debug::LogError, ldloc:string[exp:object](var_21), ldloc:Image[exp:Object](this))
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

		// Token: 0x0600017E RID: 382 RVA: 0x00005960 File Offset: 0x00003B60
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			Rect rect2 = this.activeSprite.rect;
			if (this.m_Type == Image.Type.Simple)
			{
				float width = rect2.width;
				float width2 = rect2.width;
				float height = rect2.height;
				float height2 = rect2.height;
			}
			Vector4 border = this.activeSprite.border;
			float pixelsPerUnit = this.pixelsPerUnit;
			long num = 0L;
			Image.Type type = this.m_Type;
			while (num == 0L)
			{
			}
			return 1;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000059CC File Offset: 0x00003BCC
		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Sprite sprite;
			bool flag = spriteAtlas.CanBindTo(sprite);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000059F0 File Offset: 0x00003BF0
		private static void TrackImage(Image g)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005A08 File Offset: 0x00003C08
		private static void UnTrackImage(Image g)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005A18 File Offset: 0x00003C18
		protected override void OnDidApplyAnimationProperties()
		{
			base.SetRaycastDirty();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005A2C File Offset: 0x00003C2C
		// Note: this type is marked as 'beforefieldinit'.
		static Image()
		{
		}

		// Token: 0x04000091 RID: 145
		protected static Material s_ETC1DefaultUI;

		// Token: 0x04000092 RID: 146
		[FormerlySerializedAs("m_Frame")]
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x04000093 RID: 147
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x04000094 RID: 148
		[SerializeField]
		private Image.Type m_Type;

		// Token: 0x04000095 RID: 149
		[SerializeField]
		private bool m_PreserveAspect;

		// Token: 0x04000096 RID: 150
		[SerializeField]
		private bool m_FillCenter;

		// Token: 0x04000097 RID: 151
		[SerializeField]
		private Image.FillMethod m_FillMethod;

		// Token: 0x04000098 RID: 152
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FillAmount;

		// Token: 0x04000099 RID: 153
		[SerializeField]
		private bool m_FillClockwise = true;

		// Token: 0x0400009A RID: 154
		[SerializeField]
		private int m_FillOrigin;

		// Token: 0x0400009B RID: 155
		private float m_AlphaHitTestMinimumThreshold;

		// Token: 0x0400009C RID: 156
		private bool m_Tracked;

		// Token: 0x0400009D RID: 157
		[SerializeField]
		private bool m_UseSpriteMesh;

		// Token: 0x0400009E RID: 158
		[SerializeField]
		private float m_PixelsPerUnitMultiplier;

		// Token: 0x0400009F RID: 159
		private float m_CachedReferencePixelsPerUnit;

		// Token: 0x040000A0 RID: 160
		private static readonly Vector2[] s_VertScratch;

		// Token: 0x040000A1 RID: 161
		private static readonly Vector2[] s_UVScratch;

		// Token: 0x040000A2 RID: 162
		private static readonly Vector3[] s_Xy;

		// Token: 0x040000A3 RID: 163
		private static readonly Vector3[] s_Uv;

		// Token: 0x040000A4 RID: 164
		private static List<Image> m_TrackedTexturelessImages;

		// Token: 0x040000A5 RID: 165
		private static bool s_Initialized;

		// Token: 0x02000023 RID: 35
		public enum Type
		{
			// Token: 0x040000A7 RID: 167
			Simple,
			// Token: 0x040000A8 RID: 168
			Sliced,
			// Token: 0x040000A9 RID: 169
			Tiled,
			// Token: 0x040000AA RID: 170
			Filled
		}

		// Token: 0x02000024 RID: 36
		public enum FillMethod
		{
			// Token: 0x040000AC RID: 172
			Horizontal,
			// Token: 0x040000AD RID: 173
			Vertical,
			// Token: 0x040000AE RID: 174
			Radial90,
			// Token: 0x040000AF RID: 175
			Radial180,
			// Token: 0x040000B0 RID: 176
			Radial360
		}

		// Token: 0x02000025 RID: 37
		public enum OriginHorizontal
		{
			// Token: 0x040000B2 RID: 178
			Left,
			// Token: 0x040000B3 RID: 179
			Right
		}

		// Token: 0x02000026 RID: 38
		public enum OriginVertical
		{
			// Token: 0x040000B5 RID: 181
			Bottom,
			// Token: 0x040000B6 RID: 182
			Top
		}

		// Token: 0x02000027 RID: 39
		public enum Origin90
		{
			// Token: 0x040000B8 RID: 184
			BottomLeft,
			// Token: 0x040000B9 RID: 185
			TopLeft,
			// Token: 0x040000BA RID: 186
			TopRight,
			// Token: 0x040000BB RID: 187
			BottomRight
		}

		// Token: 0x02000028 RID: 40
		public enum Origin180
		{
			// Token: 0x040000BD RID: 189
			Bottom,
			// Token: 0x040000BE RID: 190
			Left,
			// Token: 0x040000BF RID: 191
			Top,
			// Token: 0x040000C0 RID: 192
			Right
		}

		// Token: 0x02000029 RID: 41
		public enum Origin360
		{
			// Token: 0x040000C2 RID: 194
			Bottom,
			// Token: 0x040000C3 RID: 195
			Right,
			// Token: 0x040000C4 RID: 196
			Top,
			// Token: 0x040000C5 RID: 197
			Left
		}
	}
}
