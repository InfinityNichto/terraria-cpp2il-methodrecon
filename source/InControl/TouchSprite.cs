using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000058 RID: 88
	[Serializable]
	public class TouchSprite
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000D510 File Offset: 0x0000B710
		public bool Dirty
		{
			[CompilerGenerated]
			get
			{
				return this.<Dirty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000D520 File Offset: 0x0000B720
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000D534 File Offset: 0x0000B734
		public bool Ready
		{
			[CompilerGenerated]
			get
			{
				return this.<Ready>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000D544 File Offset: 0x0000B744
		public TouchSprite()
		{
			this.lockAspectRatio = true;
			base..ctor();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000D560 File Offset: 0x0000B760
		public TouchSprite(float size)
		{
			int num = 1;
			this.idleColor.g = size;
			this.lockAspectRatio = num != 0;
			base..ctor();
			this.size.x = size;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000D594 File Offset: 0x0000B794
		public void Create(string gameObjectName, Transform parentTransform, int sortingOrder)
		{
			GameObject gameObject = this.CreateSpriteGameObject(gameObjectName, parentTransform);
			Sprite sprite = this.idleSprite;
			this.spriteGameObject = gameObject;
			float r = this.idleColor.r;
			float g = this.idleColor.g;
			float b = this.idleColor.b;
			float a = this.idleColor.a;
			SpriteRenderer spriteRenderer;
			this.spriteRenderer = spriteRenderer;
			this.<Ready>k__BackingField = true;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		public void Delete()
		{
			GameObject gameObject = this.spriteGameObject;
			if (!true)
			{
			}
			global::UnityEngine.Object.Destroy(gameObject);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000D61C File Offset: 0x0000B81C
		public void Update()
		{
			long num = 0L;
			this.Update(num != 0L);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000D634 File Offset: 0x0000B834
		public void Update(bool forceUpdate)
		{
			bool flag = this.<Dirty>k__BackingField;
			if (!flag)
			{
			}
			SpriteRenderer spriteRenderer = this.spriteRenderer;
			if (!flag)
			{
			}
			bool flag2 = this.state;
			SpriteRenderer spriteRenderer2 = this.spriteRenderer;
			TouchUnitType touchUnitType = this.sizeUnitType;
			float x = this.size.x;
			float y = this.size.y;
			GameObject gameObject = this.spriteGameObject;
			SpriteRenderer spriteRenderer3 = this.spriteRenderer;
			float pixelToWorld = TouchManager.PixelToWorld;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000D748 File Offset: 0x0000B948
		private GameObject CreateSpriteGameObject(string name, Transform parentTransform)
		{
			/*
An exception occurred when decompiling this method (0600041D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GameObject InControl.TouchSprite::CreateSpriteGameObject(System.String,UnityEngine.Transform)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	callsetter:Transform(Transform::set_parent, ldloc:Transform(var_0), ldloc:Transform(parentTransform))
	stloc:int32(var_3_12, callgetter:int32(GameObject::get_layer, callgetter:GameObject(Component::get_gameObject, ldloc:Transform[exp:Component](parentTransform))))
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

		// Token: 0x0600041E RID: 1054 RVA: 0x0000D768 File Offset: 0x0000B968
		private SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder)
		{
			SpriteRenderer spriteRenderer = spriteGameObject.AddComponent<SpriteRenderer>();
			spriteRenderer.sprite = sprite;
			spriteRenderer.sortingOrder = sortingOrder;
			Shader shader = Shader.Find("Sprites/Default");
			Material sharedMaterial = spriteRenderer.sharedMaterial;
			return spriteRenderer;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		private void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Sprite sprite = spriteRenderer.sprite;
			float width = spriteRenderer.sprite.rect.width;
			Vector3 vector = spriteRenderer.sprite.bounds.size;
			float pixelToWorld = TouchManager.PixelToWorld;
			float width2 = spriteRenderer.sprite.rect.width;
			float height = spriteRenderer.sprite.rect.height;
			Transform transform = spriteGameObject.transform;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000D814 File Offset: 0x0000BA14
		private void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Sprite sprite = spriteRenderer.sprite;
			bool flag = this.lockAspectRatio;
			Vector3 viewSize = TouchManager.ViewSize;
			if (flag)
			{
				Vector3 viewSize2 = TouchManager.ViewSize;
				Vector3 vector = spriteRenderer.sprite.bounds.size;
				return;
			}
			Vector3 vector2 = spriteRenderer.sprite.bounds.size;
			Vector3 viewSize3 = TouchManager.ViewSize;
			Vector3 vector3 = spriteRenderer.sprite.bounds.size;
			Transform transform = spriteGameObject.transform;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000D890 File Offset: 0x0000BA90
		public bool Contains(Vector2 testWorldPoint)
		{
			/*
An exception occurred when decompiling this method (06000421)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.TouchSprite::Contains(UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0036:
	stloc:float32(var_9_41, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](TouchSprite::worldSize, ldloc:TouchSprite(this))))
	stloc:Vector3(var_10_49, callgetter:Vector3(TouchSprite::get_Position, ldloc:TouchSprite(this)))
	stloc:float32(var_11_56, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](TouchSprite::worldSize, ldloc:TouchSprite(this))))
	stloc:float32(var_12_63, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](TouchSprite::worldSize, ldloc:TouchSprite(this))))
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

		// Token: 0x06000422 RID: 1058 RVA: 0x0000D904 File Offset: 0x0000BB04
		public bool Contains(Touch touch)
		{
			float x = touch.position.x;
			float y = touch.position.y;
			bool flag;
			return flag;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000D92C File Offset: 0x0000BB2C
		public void DrawGizmos(Vector3 position, Color color)
		{
			TouchSpriteShape touchSpriteShape = this.shape;
			float x = this.worldSize.x;
			float y = this.worldSize.y;
			if (!true)
			{
			}
			if (touchSpriteShape != TouchSpriteShape.Oval)
			{
				return;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000D964 File Offset: 0x0000BB64
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000D978 File Offset: 0x0000BB78
		public bool State
		{
			get
			{
				return this.state;
			}
			set
			{
				bool flag = this.state;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000D994 File Offset: 0x0000BB94
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		public Sprite BusySprite
		{
			get
			{
				return this.busySprite;
			}
			set
			{
				Sprite sprite = this.busySprite;
				if (!true)
				{
				}
				bool flag = sprite != value;
				this.busySprite = value;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000D9D8 File Offset: 0x0000BBD8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		public Sprite IdleSprite
		{
			get
			{
				return this.idleSprite;
			}
			set
			{
				Sprite sprite = this.idleSprite;
				if (!true)
				{
				}
				bool flag = sprite != value;
				this.idleSprite = value;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013C RID: 316
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0000DA1C File Offset: 0x0000BC1C
		public Sprite Sprite
		{
			set
			{
				Sprite sprite = this.idleSprite;
				if (!true)
				{
				}
				bool flag = sprite != value;
				this.idleSprite = value;
				this.<Dirty>k__BackingField = true;
				Sprite sprite2 = this.busySprite;
				if (!true)
				{
				}
				bool flag2 = sprite2 != value;
				this.busySprite = value;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
		public Color BusyColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600042B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color InControl.TouchSprite::get_BusyColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::busyColor, ldloc:TouchSprite(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::busyColor, ldloc:TouchSprite(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::busyColor, ldloc:TouchSprite(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::busyColor, ldloc:TouchSprite(this))))
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
				float r = this.busyColor.r;
				float g = this.busyColor.g;
				float b = this.busyColor.b;
				float a = this.busyColor.a;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000DAEC File Offset: 0x0000BCEC
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public Color IdleColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600042D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color InControl.TouchSprite::get_IdleColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::idleColor, ldloc:TouchSprite(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::idleColor, ldloc:TouchSprite(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::idleColor, ldloc:TouchSprite(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](TouchSprite::idleColor, ldloc:TouchSprite(this))))
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
				float r = this.idleColor.r;
				float g = this.idleColor.g;
				float b = this.idleColor.b;
				float a = this.idleColor.a;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000DB80 File Offset: 0x0000BD80
		public TouchSpriteShape Shape
		{
			get
			{
				return this.shape;
			}
			set
			{
				TouchSpriteShape touchSpriteShape = this.shape;
				this.shape = value;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public TouchUnitType SizeUnitType
		{
			get
			{
				return this.sizeUnitType;
			}
			set
			{
				TouchUnitType touchUnitType = this.sizeUnitType;
				this.sizeUnitType = value;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000DBDC File Offset: 0x0000BDDC
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0000DC04 File Offset: 0x0000BE04
		public Vector2 Size
		{
			get
			{
				float x = this.size.x;
				float y = this.size.y;
				Vector2 vector;
				return vector;
			}
			set
			{
				float x = this.size.x;
				float y = this.size.y;
				this.<Dirty>k__BackingField = true;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public Vector2 WorldSize
		{
			get
			{
				float x = this.worldSize.x;
				float y = this.worldSize.y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000DC58 File Offset: 0x0000BE58
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0000DC88 File Offset: 0x0000BE88
		public Vector3 Position
		{
			get
			{
				GameObject gameObject = this.spriteGameObject;
				if (!true)
				{
				}
				bool flag = gameObject;
				Vector3 position = this.spriteGameObject.transform.position;
				return 1;
			}
			set
			{
				GameObject gameObject = this.spriteGameObject;
				if (!true)
				{
				}
				bool flag = gameObject;
				Transform transform = this.spriteGameObject.transform;
			}
		}

		// Token: 0x040003B7 RID: 951
		[SerializeField]
		private Sprite idleSprite;

		// Token: 0x040003B8 RID: 952
		[SerializeField]
		private Sprite busySprite;

		// Token: 0x040003B9 RID: 953
		[SerializeField]
		private Color idleColor;

		// Token: 0x040003BA RID: 954
		[SerializeField]
		private Color busyColor;

		// Token: 0x040003BB RID: 955
		[SerializeField]
		private TouchSpriteShape shape;

		// Token: 0x040003BC RID: 956
		[SerializeField]
		private TouchUnitType sizeUnitType;

		// Token: 0x040003BD RID: 957
		[SerializeField]
		private Vector2 size;

		// Token: 0x040003BE RID: 958
		[SerializeField]
		private bool lockAspectRatio;

		// Token: 0x040003BF RID: 959
		[SerializeField]
		[HideInInspector]
		private Vector2 worldSize;

		// Token: 0x040003C0 RID: 960
		private GameObject spriteGameObject;

		// Token: 0x040003C1 RID: 961
		private SpriteRenderer spriteRenderer;

		// Token: 0x040003C2 RID: 962
		private bool state;

		// Token: 0x040003C3 RID: 963
		[CompilerGenerated]
		private bool <Dirty>k__BackingField;

		// Token: 0x040003C4 RID: 964
		[CompilerGenerated]
		private bool <Ready>k__BackingField;
	}
}
