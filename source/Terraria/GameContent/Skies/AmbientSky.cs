using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.Ambience;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009B4 RID: 2484
	public class AmbientSky : CustomSky
	{
		// Token: 0x06004983 RID: 18819 RVA: 0x002628D8 File Offset: 0x00260AD8
		public override void Activate(Vector2 position, params object[] args)
		{
			this._isActive = true;
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x002628EC File Offset: 0x00260AEC
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x002628FC File Offset: 0x00260AFC
		private bool AnActiveSkyConflictsWithAmbience()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00262910 File Offset: 0x00260B10
		public override void Update(GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				int frameCounter = this._frameCounter;
				this._frameCounter = frameCounter;
				if (frameCounter == 0)
				{
				}
				bool logicClient = Main.LogicClient;
				if (frameCounter == 0)
				{
				}
				SlotVector<AmbientSky.SkyEntity> entities = this._entities;
				return;
			}
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x002629B4 File Offset: 0x00260BB4
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				this._entities.Clear();
			}
			SlotVector<AmbientSky.SkyEntity> entities = this._entities;
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00262A20 File Offset: 0x00260C20
		public override bool IsActive()
		{
			return this._isActive;
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x00262A34 File Offset: 0x00260C34
		public override void Reset()
		{
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x00262A44 File Offset: 0x00260C44
		public void Spawn(Player player, SkyEntityType type, int seed)
		{
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00262AE4 File Offset: 0x00260CE4
		public AmbientSky()
		{
		}

		// Token: 0x04008468 RID: 33896
		private bool _isActive;

		// Token: 0x04008469 RID: 33897
		private readonly SlotVector<AmbientSky.SkyEntity> _entities;

		// Token: 0x0400846A RID: 33898
		private int _frameCounter;

		// Token: 0x020009B5 RID: 2485
		private abstract class SkyEntity
		{
			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x0600498C RID: 18828 RVA: 0x00262AF8 File Offset: 0x00260CF8
			public Rectangle SourceRectangle
			{
				get
				{
					Asset<Texture2D> texture = this.Texture;
					Rectangle rectangle;
					return rectangle;
				}
			}

			// Token: 0x0600498D RID: 18829 RVA: 0x00262B10 File Offset: 0x00260D10
			protected void NextFrame()
			{
				byte currentRow = this.Frame._currentRow;
				byte rowCount = this.Frame.RowCount;
				this.Frame._currentRow = currentRow;
			}

			// Token: 0x0600498E RID: 18830
			public abstract Color GetColor(Color backgroundColor);

			// Token: 0x0600498F RID: 18831
			public abstract void Update(int frameCount);

			// Token: 0x06004990 RID: 18832 RVA: 0x00262B44 File Offset: 0x00260D44
			protected void SetPositionInWorldBasedOnScreenSpace(Vector2 actualWorldSpace)
			{
				if (!true)
				{
				}
				Vector2 center = Main.Camera.Center;
				if (!true)
				{
				}
				Vector2 center2 = Main.Camera.Center;
				float depth = this.Depth;
				this.Position.X = depth;
			}

			// Token: 0x06004991 RID: 18833
			public abstract Vector2 GetDrawPosition();

			// Token: 0x06004992 RID: 18834 RVA: 0x00262B90 File Offset: 0x00260D90
			public virtual void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				this.CommonDraw(spriteBatch, depthScale, minDepth, maxDepth);
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x00262BA8 File Offset: 0x00260DA8
			public void CommonDraw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				float depth = this.Depth;
				Vector2 drawPositionByDepth = this.GetDrawPositionByDepth();
				if (!true)
				{
				}
				Vector2 vector = this.SourceRectangle.Size();
				float depth2 = this.Depth;
				Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
				Asset<Texture2D> texture = this.Texture;
				Rectangle sourceRectangle = this.SourceRectangle;
				float rotation = this.Rotation;
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x06004994 RID: 18836 RVA: 0x00262C10 File Offset: 0x00260E10
			internal Vector2 GetDrawPositionByDepth()
			{
				/*
An exception occurred when decompiling this method (06004994)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.GameContent.Skies.AmbientSky/SkyEntity::GetDrawPositionByDepth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_1_0C, callgetter:Vector2(Camera::get_Center, callgetter:Camera(Main::get_Camera)))
	stloc:float32(var_4_15, ldfld:float32(SkyEntity::Depth, ldloc:SkyEntity(this)))
	stloc:Vector2(var_8_27, callgetter:Vector2(Camera::get_Center, callgetter:Camera(Main::get_Camera)))
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

			// Token: 0x06004995 RID: 18837 RVA: 0x00262C48 File Offset: 0x00260E48
			internal float Helper_GetOpacityWithAccountingForOceanWaterLine()
			{
				Vector2 drawPositionByDepth = this.GetDrawPositionByDepth();
				if (!true)
				{
				}
				Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
				if (!true)
				{
				}
				Rectangle sourceRectangle = this.SourceRectangle;
				return float.Epsilon;
			}

			// Token: 0x06004996 RID: 18838 RVA: 0x00262C80 File Offset: 0x00260E80
			protected SkyEntity()
			{
			}

			// Token: 0x0400846B RID: 33899
			public Vector2 Position;

			// Token: 0x0400846C RID: 33900
			public Asset<Texture2D> Texture;

			// Token: 0x0400846D RID: 33901
			public SpriteFrame Frame;

			// Token: 0x0400846E RID: 33902
			public float Depth;

			// Token: 0x0400846F RID: 33903
			public SpriteEffects Effects;

			// Token: 0x04008470 RID: 33904
			public bool IsActive = true;

			// Token: 0x04008471 RID: 33905
			public float Rotation;
		}

		// Token: 0x020009B6 RID: 2486
		private class FadingSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x06004997 RID: 18839 RVA: 0x00262C9C File Offset: 0x00260E9C
			public FadingSkyEntity()
			{
				this.IsActive = true;
				base..ctor();
				this.OpacityNormalizedTimeToFadeOut = (float)26214;
			}

			// Token: 0x06004998 RID: 18840 RVA: 0x00262CC4 File Offset: 0x00260EC4
			public override void Update(int frameCount)
			{
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = frameCount;
				int lifeTime = this.LifeTime;
				this.UpdateOpacity(frameCount);
				int frameOffset = this.FrameOffset;
				int framingSpeed = this.FramingSpeed;
				if (frameOffset == 0)
				{
					byte currentRow = this.Frame._currentRow;
					byte rowCount = this.Frame.RowCount;
					this.Frame._currentRow = currentRow;
				}
				float x = this.Position.X;
				float y = this.Position.Y;
				float x2 = this.Velocity.X;
				float y2 = this.Velocity.Y;
			}

			// Token: 0x06004999 RID: 18841 RVA: 0x00262D60 File Offset: 0x00260F60
			public virtual void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x0600499A RID: 18842 RVA: 0x00262D70 File Offset: 0x00260F70
			private void UpdateOpacity(int frameCount)
			{
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				float opacityNormalizedTimeToFadeIn = this.OpacityNormalizedTimeToFadeIn;
			}

			// Token: 0x0600499B RID: 18843 RVA: 0x00262DA4 File Offset: 0x00260FA4
			private bool IsMovementDone(int frameCount)
			{
				/*
An exception occurred when decompiling this method (0600499B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Skies.AmbientSky/FadingSkyEntity::IsMovementDone(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(FadingSkyEntity::TimeEntitySpawnedIn, ldloc:FadingSkyEntity(this)))
	stfld:int32(FadingSkyEntity::TimeEntitySpawnedIn, ldloc:FadingSkyEntity(this), ldloc:int32(frameCount))
	stloc:int32(var_1_14, ldfld:int32(FadingSkyEntity::LifeTime, ldloc:FadingSkyEntity(this)))
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

			// Token: 0x0600499C RID: 18844 RVA: 0x00262DCC File Offset: 0x00260FCC
			public override Color GetColor(Color backgroundColor)
			{
				if (!true)
				{
				}
				float brightnessLerper = this.BrightnessLerper;
				float opacity = this.Opacity;
				float finalOpacityMultiplier = this.FinalOpacityMultiplier;
				float num = base.Helper_GetOpacityWithAccountingForOceanWaterLine();
				return 1;
			}

			// Token: 0x0600499D RID: 18845 RVA: 0x00262DFC File Offset: 0x00260FFC
			public void StartFadingOut(int currentFrameCount)
			{
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num;
			}

			// Token: 0x0600499E RID: 18846 RVA: 0x00262E2C File Offset: 0x0026102C
			public override Vector2 GetDrawPosition()
			{
				float x = this.Position.X;
				float y = this.Position.Y;
				Vector2 vector;
				return vector;
			}

			// Token: 0x04008472 RID: 33906
			protected int LifeTime;

			// Token: 0x04008473 RID: 33907
			protected Vector2 Velocity;

			// Token: 0x04008474 RID: 33908
			protected int FramingSpeed;

			// Token: 0x04008475 RID: 33909
			protected int TimeEntitySpawnedIn;

			// Token: 0x04008476 RID: 33910
			protected float Opacity;

			// Token: 0x04008477 RID: 33911
			protected float BrightnessLerper;

			// Token: 0x04008478 RID: 33912
			protected float FinalOpacityMultiplier;

			// Token: 0x04008479 RID: 33913
			protected float OpacityNormalizedTimeToFadeIn;

			// Token: 0x0400847A RID: 33914
			protected float OpacityNormalizedTimeToFadeOut;

			// Token: 0x0400847B RID: 33915
			protected int FrameOffset;
		}

		// Token: 0x020009B7 RID: 2487
		private class ButterfliesSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600499F RID: 18847 RVA: 0x00262E54 File Offset: 0x00261054
			public ButterfliesSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049A0 RID: 18848 RVA: 0x00262EFC File Offset: 0x002610FC
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049A1 RID: 18849 RVA: 0x00262F18 File Offset: 0x00261118
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}
		}

		// Token: 0x020009B8 RID: 2488
		private class LostKiteSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049A2 RID: 18850 RVA: 0x00262F64 File Offset: 0x00261164
			public LostKiteSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049A3 RID: 18851 RVA: 0x00263000 File Offset: 0x00261200
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
				this.Velocity = 1;
			}

			// Token: 0x060049A4 RID: 18852 RVA: 0x00263024 File Offset: 0x00261224
			public override void Update(int frameCount)
			{
				if (!true)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				int num2;
				if (num != 0)
				{
					num2 = 4;
					this.FramingSpeed = num2;
				}
				if (num2 == 0)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
				base.Update(frameCount);
				if (num3 == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num4 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num4;
			}
		}

		// Token: 0x020009B9 RID: 2489
		private class PegasusSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049A5 RID: 18853 RVA: 0x00263084 File Offset: 0x00261284
			public PegasusSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049A6 RID: 18854 RVA: 0x002630FC File Offset: 0x002612FC
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049A7 RID: 18855 RVA: 0x00263118 File Offset: 0x00261318
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x060049A8 RID: 18856 RVA: 0x00263164 File Offset: 0x00261364
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/PegasusSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Color(var_0_07, call:Color(FadingSkyEntity::GetColor, ldloc:PegasusSkyEntity[exp:FadingSkyEntity](this), ldloc:Color(backgroundColor)))
	stloc:float32[](var_2_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

		// Token: 0x020009BA RID: 2490
		private class VultureSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049A9 RID: 18857 RVA: 0x00263180 File Offset: 0x00261380
			public VultureSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049AA RID: 18858 RVA: 0x002631F8 File Offset: 0x002613F8
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049AB RID: 18859 RVA: 0x00263214 File Offset: 0x00261414
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x060049AC RID: 18860 RVA: 0x00263260 File Offset: 0x00261460
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/VultureSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_2_07, callgetter:float32[](Main::get_bgAlphaFrontLayer))
	stloc:float32[](var_4_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

		// Token: 0x020009BB RID: 2491
		private class PixiePosseSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049AD RID: 18861 RVA: 0x00263280 File Offset: 0x00261480
			public PixiePosseSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.pixieType = num;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049AE RID: 18862 RVA: 0x00263314 File Offset: 0x00261514
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049AF RID: 18863 RVA: 0x00263330 File Offset: 0x00261530
			public override void Update(int frameCount)
			{
				base.Update(frameCount);
				int num = this.pixieType;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					int num2 = this.pixieType;
					if (num2 == 0)
					{
					}
					if (num2 == 0)
					{
						if (num2 == 0)
						{
						}
						bool isItRaining = Main.IsItRaining;
						if (num2 == 0)
						{
						}
					}
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num3 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num3;
			}

			// Token: 0x060049B0 RID: 18864 RVA: 0x00263394 File Offset: 0x00261594
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				base.CommonDraw(spriteBatch, depthScale, minDepth, maxDepth);
			}

			// Token: 0x0400847C RID: 33916
			private int pixieType;
		}

		// Token: 0x020009BC RID: 2492
		private class BirdsPackSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049B1 RID: 18865 RVA: 0x002633AC File Offset: 0x002615AC
			public BirdsPackSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049B2 RID: 18866 RVA: 0x00263420 File Offset: 0x00261620
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049B3 RID: 18867 RVA: 0x0026343C File Offset: 0x0026163C
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}
		}

		// Token: 0x020009BD RID: 2493
		private class SeagullsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049B4 RID: 18868 RVA: 0x00263488 File Offset: 0x00261688
			public SeagullsGroupSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049B5 RID: 18869 RVA: 0x0026354C File Offset: 0x0026174C
			public override void UpdateVelocity(int frameCount)
			{
				float x = this._magnetAccelerations.X;
				float y = this._magnetAccelerations.Y;
				float x2 = this._magnetPointTarget.X;
				float x3 = this._positionVsMagnet.X;
				if (!true)
				{
				}
				float y2 = this._magnetPointTarget.Y;
				float y3 = this._positionVsMagnet.Y;
				if (!true)
				{
				}
				float x4 = this._velocityVsMagnet.X;
				float y4 = this._velocityVsMagnet.Y;
				float x5 = this._positionVsMagnet.X;
				float y5 = this._positionVsMagnet.Y;
				this._velocityVsMagnet.Y = y4;
				SpriteEffects effects = this.Effects;
				this._positionVsMagnet.X = x5;
				this._positionVsMagnet.Y = y5;
				float x6 = this._velocityVsMagnet.X;
				float y6 = this._velocityVsMagnet.Y;
				if (effects == SpriteEffects.None)
				{
				}
				this.Velocity.X = x5;
				this.Velocity.Y = y5;
			}

			// Token: 0x060049B6 RID: 18870 RVA: 0x00263658 File Offset: 0x00261858
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x060049B7 RID: 18871 RVA: 0x002636A4 File Offset: 0x002618A4
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x060049B8 RID: 18872 RVA: 0x002636B4 File Offset: 0x002618B4
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/SeagullsGroupSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Color(var_0_07, call:Color(FadingSkyEntity::GetColor, ldloc:SeagullsGroupSkyEntity[exp:FadingSkyEntity](this), ldloc:Color(backgroundColor)))
	stloc:float32[](var_2_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

			// Token: 0x060049B9 RID: 18873 RVA: 0x002636D0 File Offset: 0x002618D0
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				base.CommonDraw(spriteBatch, depthScale, minDepth, maxDepth);
			}

			// Token: 0x060049BA RID: 18874 RVA: 0x002636E8 File Offset: 0x002618E8
			public static List<AmbientSky.SeagullsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				if (!true)
				{
				}
				int num = 49864;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x0400847D RID: 33917
			private Vector2 _magnetAccelerations;

			// Token: 0x0400847E RID: 33918
			private Vector2 _magnetPointTarget;

			// Token: 0x0400847F RID: 33919
			private Vector2 _positionVsMagnet;

			// Token: 0x04008480 RID: 33920
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x020009BE RID: 2494
		private class GastropodGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049BB RID: 18875 RVA: 0x00263730 File Offset: 0x00261930
			public GastropodGroupSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049BC RID: 18876 RVA: 0x0026379C File Offset: 0x0026199C
			public override void UpdateVelocity(int frameCount)
			{
				float x = this._magnetAccelerations.X;
				float y = this._magnetAccelerations.Y;
				float x2 = this._magnetPointTarget.X;
				float x3 = this._positionVsMagnet.X;
				if (!true)
				{
				}
				float y2 = this._magnetPointTarget.Y;
				float y3 = this._positionVsMagnet.Y;
				if (!true)
				{
				}
				float x4 = this._velocityVsMagnet.X;
				float y4 = this._velocityVsMagnet.Y;
				this._velocityVsMagnet.Y = y4;
				this._positionVsMagnet.X = x4;
				this._positionVsMagnet.Y = y3;
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
				float x5 = this._velocityVsMagnet.X;
				float y5 = this._velocityVsMagnet.Y;
				if (!true)
				{
				}
				this.Velocity.X = x4;
				this.Velocity.Y = y3;
				this.Rotation = x4;
			}

			// Token: 0x060049BD RID: 18877 RVA: 0x00263898 File Offset: 0x00261A98
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x060049BE RID: 18878 RVA: 0x002638E4 File Offset: 0x00261AE4
			public override Color GetColor(Color backgroundColor)
			{
				if (!true)
				{
				}
				float brightnessLerper = this.BrightnessLerper;
				if (!true)
				{
				}
				float opacity = this.Opacity;
				float finalOpacityMultiplier = this.FinalOpacityMultiplier;
				return 1;
			}

			// Token: 0x060049BF RID: 18879 RVA: 0x00263910 File Offset: 0x00261B10
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				base.CommonDraw(spriteBatch, depthScale, minDepth, maxDepth);
			}

			// Token: 0x060049C0 RID: 18880 RVA: 0x00263928 File Offset: 0x00261B28
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x060049C1 RID: 18881 RVA: 0x00263938 File Offset: 0x00261B38
			public static List<AmbientSky.GastropodGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				if (!true)
				{
				}
				if (49864 == 0)
				{
					return;
				}
			}

			// Token: 0x04008481 RID: 33921
			private Vector2 _magnetAccelerations;

			// Token: 0x04008482 RID: 33922
			private Vector2 _magnetPointTarget;

			// Token: 0x04008483 RID: 33923
			private Vector2 _positionVsMagnet;

			// Token: 0x04008484 RID: 33924
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x020009BF RID: 2495
		private class SlimeBalloonGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049C2 RID: 18882 RVA: 0x00263974 File Offset: 0x00261B74
			public SlimeBalloonGroupSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049C3 RID: 18883 RVA: 0x002639EC File Offset: 0x00261BEC
			public override void UpdateVelocity(int frameCount)
			{
				float x = this._magnetAccelerations.X;
				float y = this._magnetAccelerations.Y;
				float x2 = this._magnetPointTarget.X;
				float x3 = this._positionVsMagnet.X;
				if (!true)
				{
				}
				float y2 = this._magnetPointTarget.Y;
				float y3 = this._positionVsMagnet.Y;
				if (!true)
				{
				}
				float x4 = this._velocityVsMagnet.X;
				float y4 = this._velocityVsMagnet.Y;
				float x5 = this._positionVsMagnet.X;
				float y5 = this._positionVsMagnet.Y;
				this._velocityVsMagnet.Y = y4;
				this._positionVsMagnet.X = x5;
				this._positionVsMagnet.Y = y5;
				if (!true)
				{
				}
				if (!true)
				{
				}
				float x6 = this._velocityVsMagnet.X;
				float y6 = this._velocityVsMagnet.Y;
				this.Velocity.X = x5;
				this.Rotation = x5;
			}

			// Token: 0x060049C4 RID: 18884 RVA: 0x00263AEC File Offset: 0x00261CEC
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num3 = 1;
				if (num3 == 0)
				{
				}
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					bool isItRaining = Main.IsItRaining;
					if (num3 == 0)
					{
					}
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num4 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num4;
			}

			// Token: 0x060049C5 RID: 18885 RVA: 0x00263B4C File Offset: 0x00261D4C
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x060049C6 RID: 18886 RVA: 0x00263B5C File Offset: 0x00261D5C
			public static List<AmbientSky.SlimeBalloonGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				if (!true)
				{
				}
				if (49864 == 0)
				{
					return;
				}
			}

			// Token: 0x04008485 RID: 33925
			private Vector2 _magnetAccelerations;

			// Token: 0x04008486 RID: 33926
			private Vector2 _magnetPointTarget;

			// Token: 0x04008487 RID: 33927
			private Vector2 _positionVsMagnet;

			// Token: 0x04008488 RID: 33928
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x020009C0 RID: 2496
		private class HellBatsGoupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049C7 RID: 18887 RVA: 0x00263B9C File Offset: 0x00261D9C
			public HellBatsGoupSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049C8 RID: 18888 RVA: 0x00263C84 File Offset: 0x00261E84
			public override void UpdateVelocity(int frameCount)
			{
				float x = this._magnetAccelerations.X;
				float y = this._magnetAccelerations.Y;
				float x2 = this._magnetPointTarget.X;
				float x3 = this._positionVsMagnet.X;
				if (!true)
				{
				}
				float y2 = this._magnetPointTarget.Y;
				float y3 = this._positionVsMagnet.Y;
				if (!true)
				{
				}
				float x4 = this._velocityVsMagnet.X;
				float y4 = this._velocityVsMagnet.Y;
				float x5 = this._positionVsMagnet.X;
				float y5 = this._positionVsMagnet.Y;
				this._velocityVsMagnet.Y = y4;
				this._positionVsMagnet.X = x5;
				this._positionVsMagnet.Y = y5;
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
				float x6 = this._velocityVsMagnet.X;
				float y6 = this._velocityVsMagnet.Y;
				if (!true)
				{
				}
				this.Velocity.X = x5;
				this.Velocity.Y = y5;
			}

			// Token: 0x060049C9 RID: 18889 RVA: 0x00263D94 File Offset: 0x00261F94
			public override void Update(int frameCount)
			{
				base.Update(frameCount);
			}

			// Token: 0x060049CA RID: 18890 RVA: 0x00263DA8 File Offset: 0x00261FA8
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x060049CB RID: 18891 RVA: 0x00263DB8 File Offset: 0x00261FB8
			public override Color GetColor(Color backgroundColor)
			{
				if (!true)
				{
				}
				float depth = this.Depth;
				float opacity = this.Opacity;
				float finalOpacityMultiplier = this.FinalOpacityMultiplier;
				Color color2;
				float num;
				Color color = color2 * num;
				return 1;
			}

			// Token: 0x060049CC RID: 18892 RVA: 0x00263DEC File Offset: 0x00261FEC
			public static List<AmbientSky.HellBatsGoupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				if (!true)
				{
				}
				int num = 49864;
				if (num == 0)
				{
				}
				int underworldLayer = Main.UnderworldLayer;
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x060049CD RID: 18893 RVA: 0x00263E38 File Offset: 0x00262038
			internal float Helper_GetOpacityWithAccountingForBackgroundsOff()
			{
				/*
An exception occurred when decompiling this method (060049CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.AmbientSky/HellBatsGoupSkyEntity::Helper_GetOpacityWithAccountingForBackgroundsOff()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:bool(var_1_0D, callgetter:bool(Main::get_BackgroundEnabled))
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

			// Token: 0x04008489 RID: 33929
			private Vector2 _magnetAccelerations;

			// Token: 0x0400848A RID: 33930
			private Vector2 _magnetPointTarget;

			// Token: 0x0400848B RID: 33931
			private Vector2 _positionVsMagnet;

			// Token: 0x0400848C RID: 33932
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x020009C1 RID: 2497
		private class BatsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049CE RID: 18894 RVA: 0x00263E54 File Offset: 0x00262054
			public BatsGroupSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x00263F30 File Offset: 0x00262130
			public override void UpdateVelocity(int frameCount)
			{
				float x = this._magnetAccelerations.X;
				float y = this._magnetAccelerations.Y;
				float x2 = this._magnetPointTarget.X;
				float x3 = this._positionVsMagnet.X;
				if (!true)
				{
				}
				float y2 = this._magnetPointTarget.Y;
				float y3 = this._positionVsMagnet.Y;
				if (!true)
				{
				}
				float x4 = this._velocityVsMagnet.X;
				float y4 = this._velocityVsMagnet.Y;
				float x5 = this._positionVsMagnet.X;
				float y5 = this._positionVsMagnet.Y;
				this._velocityVsMagnet.Y = y4;
				this._positionVsMagnet.X = x5;
				this._positionVsMagnet.Y = y5;
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
				float x6 = this._velocityVsMagnet.X;
				float y6 = this._velocityVsMagnet.Y;
				if (!true)
				{
				}
				this.Velocity.X = x5;
				this.Velocity.Y = y5;
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x0026403C File Offset: 0x0026223C
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x00264088 File Offset: 0x00262288
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x060049D2 RID: 18898 RVA: 0x00264098 File Offset: 0x00262298
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/BatsGroupSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Color(var_0_07, call:Color(FadingSkyEntity::GetColor, ldloc:BatsGroupSkyEntity[exp:FadingSkyEntity](this), ldloc:Color(backgroundColor)))
	stloc:float32[](var_2_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
	stloc:float32[](var_4_17, callgetter:float32[](Main::get_bgAlphaFrontLayer))
	stloc:float32[](var_6_21, callgetter:float32[](Main::get_bgAlphaFrontLayer))
	stloc:float32[](var_8_2B, callgetter:float32[](Main::get_bgAlphaFrontLayer))
	stloc:float32[](var_10_35, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

			// Token: 0x060049D3 RID: 18899 RVA: 0x002640DC File Offset: 0x002622DC
			public static List<AmbientSky.BatsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				if (!true)
				{
				}
				int num = 49864;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x0400848D RID: 33933
			private Vector2 _magnetAccelerations;

			// Token: 0x0400848E RID: 33934
			private Vector2 _magnetPointTarget;

			// Token: 0x0400848F RID: 33935
			private Vector2 _positionVsMagnet;

			// Token: 0x04008490 RID: 33936
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x020009C2 RID: 2498
		private class WyvernSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049D4 RID: 18900 RVA: 0x00264124 File Offset: 0x00262324
			public WyvernSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				int num3 = 1;
				if (num3 == 0)
				{
				}
				this.Effects = (SpriteEffects)num3;
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x002641A0 File Offset: 0x002623A0
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}
		}

		// Token: 0x020009C3 RID: 2499
		private class NormalizedBackgroundLayerSpaceSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x060049D6 RID: 18902 RVA: 0x000021DB File Offset: 0x000003DB
			public override Color GetColor(Color backgroundColor)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x002641BC File Offset: 0x002623BC
			public override Vector2 GetDrawPosition()
			{
				float x = this.Position.X;
				float y = this.Position.Y;
				Vector2 vector;
				return vector;
			}

			// Token: 0x060049D8 RID: 18904 RVA: 0x002641E4 File Offset: 0x002623E4
			public override void Update(int frameCount)
			{
			}

			// Token: 0x060049D9 RID: 18905 RVA: 0x002641F4 File Offset: 0x002623F4
			public NormalizedBackgroundLayerSpaceSkyEntity()
			{
				this.IsActive = true;
				base..ctor();
			}
		}

		// Token: 0x020009C4 RID: 2500
		private class BoneSerpentSkyEntity : AmbientSky.NormalizedBackgroundLayerSpaceSkyEntity
		{
			// Token: 0x060049DA RID: 18906 RVA: 0x00264210 File Offset: 0x00262410
			public BoneSerpentSkyEntity()
			{
				this.IsActive = true;
				base..ctor();
			}
		}

		// Token: 0x020009C5 RID: 2501
		private class AirshipSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049DB RID: 18907 RVA: 0x0026422C File Offset: 0x0026242C
			public AirshipSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.TimeEntitySpawnedIn = num;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				this.Effects = (SpriteEffects)num;
				int num3;
				if (num3 != 0)
				{
					return;
				}
				if (49864 == 0)
				{
				}
				float x = this.Position.X;
				float y = this.Position.Y;
				if (num2 != 0)
				{
				}
			}

			// Token: 0x060049DC RID: 18908 RVA: 0x002642C4 File Offset: 0x002624C4
			public override void UpdateVelocity(int frameCount)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				SpriteEffects effects = this.Effects;
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x002642E0 File Offset: 0x002624E0
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}
		}

		// Token: 0x020009C6 RID: 2502
		private class AirBalloonSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049DE RID: 18910 RVA: 0x0026432C File Offset: 0x0026252C
			public AirBalloonSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				if (17096 == 0)
				{
				}
				if (num2 != 0)
				{
				}
			}

			// Token: 0x060049DF RID: 18911 RVA: 0x002643AC File Offset: 0x002625AC
			public override void UpdateVelocity(int frameCount)
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
				float y = this.Position.Y;
			}

			// Token: 0x060049E0 RID: 18912 RVA: 0x002643DC File Offset: 0x002625DC
			public override void Update(int frameCount)
			{
				int num = 1;
				base.Update(frameCount);
				if (num == 0)
				{
				}
				bool isItRaining = Main.IsItRaining;
				if (num == 0)
				{
				}
				int lifeTime = this.LifeTime;
				float opacityNormalizedTimeToFadeOut = this.OpacityNormalizedTimeToFadeOut;
				int num2 = 32640;
				int timeEntitySpawnedIn = this.TimeEntitySpawnedIn;
				this.TimeEntitySpawnedIn = num2;
			}

			// Token: 0x04008491 RID: 33937
			private const int RANDOM_TILE_SPAWN_RANGE = 100;
		}

		// Token: 0x020009C7 RID: 2503
		private class CrimeraSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x060049E1 RID: 18913 RVA: 0x00264428 File Offset: 0x00262628
			public CrimeraSkyEntity(Player player, FastRandom random)
				: base(player, random)
			{
				float depth = this.Depth;
				if (2 == 0)
				{
				}
				string text2;
				string text = "Images/Backgrounds/Ambience/Crimera" + text2;
			}

			// Token: 0x060049E2 RID: 18914 RVA: 0x00264460 File Offset: 0x00262660
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/CrimeraSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Color(var_0_07, call:Color(FadingSkyEntity::GetColor, ldloc:CrimeraSkyEntity[exp:FadingSkyEntity](this), ldloc:Color(backgroundColor)))
	stloc:float32[](var_2_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

		// Token: 0x020009C8 RID: 2504
		private class EOSSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x060049E3 RID: 18915 RVA: 0x0026447C File Offset: 0x0026267C
			public EOSSkyEntity(Player player, FastRandom random)
				: base(player, random)
			{
				float depth = this.Depth;
				if (2 == 0)
				{
				}
				string text2;
				string text = "Images/Backgrounds/Ambience/EOS" + text2;
			}

			// Token: 0x060049E4 RID: 18916 RVA: 0x002644B4 File Offset: 0x002626B4
			public override Color GetColor(Color backgroundColor)
			{
				/*
An exception occurred when decompiling this method (060049E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Skies.AmbientSky/EOSSkyEntity::GetColor(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Color(var_0_07, call:Color(FadingSkyEntity::GetColor, ldloc:EOSSkyEntity[exp:FadingSkyEntity](this), ldloc:Color(backgroundColor)))
	stloc:float32[](var_2_0F, callgetter:float32[](Main::get_bgAlphaFrontLayer))
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

		// Token: 0x020009C9 RID: 2505
		private class EOCSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049E5 RID: 18917 RVA: 0x002644D0 File Offset: 0x002626D0
			public EOCSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				if (num2 != 0)
				{
				}
			}

			// Token: 0x060049E6 RID: 18918 RVA: 0x0026453C File Offset: 0x0026273C
			private void BeginZigZag(FastRandom random, VirtualCamera camera, int direction)
			{
				this._state = 1;
				int num = random.Next(18, 31);
				this.LifeTime = 60;
				this._direction = direction;
				float num2 = random.NextFloat();
			}

			// Token: 0x060049E7 RID: 18919 RVA: 0x00264574 File Offset: 0x00262774
			private void BeginChasingPlayer(FastRandom random, VirtualCamera camera)
			{
				this._state = 2;
				int num = random.Next(18, 31);
				this.LifeTime = 60;
				float num2 = random.NextFloat();
				float num3 = random.NextFloat();
				if (60 == 0)
				{
				}
			}

			// Token: 0x060049E8 RID: 18920 RVA: 0x002645B4 File Offset: 0x002627B4
			public override void UpdateVelocity(int frameCount)
			{
				int state = this._state;
				this.ZigzagMove(frameCount);
			}

			// Token: 0x060049E9 RID: 18921 RVA: 0x002645F4 File Offset: 0x002627F4
			private void ZigzagMove(int frameCount)
			{
				int num = 1;
				int direction = this._direction;
				if (num == 0)
				{
				}
				int num2 = 17558;
				float waviness = this._waviness;
				this.Velocity = num2;
			}

			// Token: 0x060049EA RID: 18922 RVA: 0x00264624 File Offset: 0x00262824
			private void ChasePlayerTop(int frameCount)
			{
				if (!true)
				{
				}
				Vector2 center = Main.LocalPlayer.Center;
				float x = this.Position.X;
				float y = this.Position.Y;
				Vector2 vector;
				float num = vector.Length();
				float x2 = this.Velocity.X;
				int num2 = Math.Sign(num);
				float y2 = this.Velocity.Y;
				int num3 = Math.Sign(num);
				float x3 = this.Velocity.X;
			}

			// Token: 0x04008492 RID: 33938
			private const int STATE_ZIGZAG = 1;

			// Token: 0x04008493 RID: 33939
			private const int STATE_GOOVERPLAYER = 2;

			// Token: 0x04008494 RID: 33940
			private int _state;

			// Token: 0x04008495 RID: 33941
			private int _direction;

			// Token: 0x04008496 RID: 33942
			private float _waviness;
		}

		// Token: 0x020009CA RID: 2506
		private class MeteorSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x060049EB RID: 18923 RVA: 0x002646A8 File Offset: 0x002628A8
			public MeteorSkyEntity(Player player, FastRandom random)
			{
				int num = 1;
				this.IsActive = num != 0;
				base..ctor();
				int num2 = 26214;
				this.OpacityNormalizedTimeToFadeOut = (float)num2;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x020009CB RID: 2507
		private sealed class EntityFactoryMethod : MulticastDelegate
		{
			// Token: 0x060049EC RID: 18924 RVA: 0x0026477C File Offset: 0x0026297C
			public EntityFactoryMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060049ED RID: 18925 RVA: 0x002647D8 File Offset: 0x002629D8
			public AmbientSky.SkyEntity Invoke(Player player, int seed)
			{
				/*
An exception occurred when decompiling this method (060049ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Skies.AmbientSky/SkyEntity Terraria.GameContent.Skies.AmbientSky/EntityFactoryMethod::Invoke(Terraria.Player,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:EntityFactoryMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:EntityFactoryMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:EntityFactoryMethod[exp:Delegate](this)))
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

			// Token: 0x060049EE RID: 18926 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, int seed, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060049EF RID: 18927 RVA: 0x000021DB File Offset: 0x000003DB
			public AmbientSky.SkyEntity EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
