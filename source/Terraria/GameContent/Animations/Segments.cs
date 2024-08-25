using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Localization;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000995 RID: 2453
	public class Segments
	{
		// Token: 0x060048CD RID: 18637 RVA: 0x00260634 File Offset: 0x0025E834
		public Segments()
		{
		}

		// Token: 0x04008405 RID: 33797
		private const float PixelsToRollUpPerFrame = 0.5f;

		// Token: 0x02000996 RID: 2454
		public class LocalizedTextSegment : IAnimationSegment
		{
			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x060048CE RID: 18638 RVA: 0x000021DB File Offset: 0x000003DB
			public float DedicatedTimeNeeded
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060048CF RID: 18639 RVA: 0x00260648 File Offset: 0x0025E848
			public LocalizedTextSegment(float timeInAnimation, string textKey)
			{
				LocalizedText text = Language.GetText(textKey);
				this._text = text;
			}

			// Token: 0x060048D0 RID: 18640 RVA: 0x0026066C File Offset: 0x0025E86C
			public LocalizedTextSegment(float timeInAnimation, LocalizedText textObject, Vector2 anchorOffset)
			{
				this._text = textObject;
			}

			// Token: 0x060048D1 RID: 18641 RVA: 0x00260688 File Offset: 0x0025E888
			public void Draw(GameAnimationSegment info)
			{
				int timeInAnimation = info.TimeInAnimation;
				float timeToShowPeak = this._timeToShowPeak;
				if (!true)
				{
				}
				float timeToShowPeak2 = this._timeToShowPeak;
				float timeToShowPeak3 = this._timeToShowPeak;
				float x = info.AnchorPositionOnScreen.X;
				float y = info.AnchorPositionOnScreen.Y;
				if (17274 == 0)
				{
				}
				float x2 = this._anchorOffset.X;
				float y2 = this._anchorOffset.Y;
				LocalizedText text = this._text;
				string <Value>k__BackingField = text.<Value>k__BackingField;
				if (text == null)
				{
				}
				Color color2;
				float num;
				Color color = color2 * num * num;
				float displayOpacity = info.DisplayOpacity;
				Color color3 = color * num;
				if (text == null)
				{
				}
				float displayOpacity2 = info.DisplayOpacity;
				Color color5;
				Color color4 = color5 * num;
			}

			// Token: 0x04008406 RID: 33798
			private const int PixelsForALine = 120;

			// Token: 0x04008407 RID: 33799
			private LocalizedText _text;

			// Token: 0x04008408 RID: 33800
			private float _timeToShowPeak;

			// Token: 0x04008409 RID: 33801
			private Vector2 _anchorOffset;
		}

		// Token: 0x02000997 RID: 2455
		public abstract class AnimationSegmentWithActions<T> : IAnimationSegment
		{
			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x060048D2 RID: 18642 RVA: 0x00260748 File Offset: 0x0025E948
			public float DedicatedTimeNeeded
			{
				get
				{
					/*
An exception occurred when decompiling this method (060048D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Animations.Segments/AnimationSegmentWithActions`1::get_DedicatedTimeNeeded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(AnimationSegmentWithActions`1::_dedicatedTimeNeeded, ldloc:AnimationSegmentWithActions`1(this)))
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

			// Token: 0x060048D3 RID: 18643 RVA: 0x0026075C File Offset: 0x0025E95C
			public AnimationSegmentWithActions(int targetTime)
			{
				this._targetTime = targetTime;
			}

			// Token: 0x060048D4 RID: 18644 RVA: 0x00260778 File Offset: 0x0025E978
			protected void ProcessActions(T obj, float localTimeForObject)
			{
			}

			// Token: 0x060048D5 RID: 18645 RVA: 0x00260788 File Offset: 0x0025E988
			public Segments.AnimationSegmentWithActions<T> Then(IAnimationSegmentAction<T> act)
			{
				int dedicatedTimeNeeded = this._dedicatedTimeNeeded;
				int dedicatedTimeNeeded2 = this._dedicatedTimeNeeded;
				this._lastDedicatedTimeNeeded = dedicatedTimeNeeded2;
				return this;
			}

			// Token: 0x060048D6 RID: 18646 RVA: 0x002607AC File Offset: 0x0025E9AC
			public Segments.AnimationSegmentWithActions<T> With(IAnimationSegmentAction<T> act)
			{
				int lastDedicatedTimeNeeded = this._lastDedicatedTimeNeeded;
				return this;
			}

			// Token: 0x060048D7 RID: 18647
			protected abstract void Bind(IAnimationSegmentAction<T> act);

			// Token: 0x060048D8 RID: 18648
			public abstract void Draw(GameAnimationSegment info);

			// Token: 0x0400840A RID: 33802
			private int _dedicatedTimeNeeded;

			// Token: 0x0400840B RID: 33803
			private int _lastDedicatedTimeNeeded;

			// Token: 0x0400840C RID: 33804
			protected int _targetTime;

			// Token: 0x0400840D RID: 33805
			private List<IAnimationSegmentAction<T>> _actions;
		}

		// Token: 0x02000998 RID: 2456
		public class PlayerSegment : Segments.AnimationSegmentWithActions<Player>
		{
			// Token: 0x060048D9 RID: 18649 RVA: 0x002607C4 File Offset: 0x0025E9C4
			public PlayerSegment(int targetTime, Vector2 anchorOffset, Vector2 normalizedHitboxOrigin)
				: base(targetTime)
			{
			}

			// Token: 0x060048DA RID: 18650 RVA: 0x002607D8 File Offset: 0x0025E9D8
			public Segments.PlayerSegment UseShaderEffect(Segments.PlayerSegment.IShaderEffect shaderEffect)
			{
				this._shaderEffect = shaderEffect;
				return this;
			}

			// Token: 0x060048DB RID: 18651 RVA: 0x002607F0 File Offset: 0x0025E9F0
			protected override void Bind(IAnimationSegmentAction<Player> act)
			{
				Player player = this._player;
			}

			// Token: 0x060048DC RID: 18652 RVA: 0x00260808 File Offset: 0x0025EA08
			public override void Draw(GameAnimationSegment info)
			{
				int timeInAnimation = info.TimeInAnimation;
				float dedicatedTimeNeeded = base.DedicatedTimeNeeded;
				int timeInAnimation2 = info.TimeInAnimation;
				this.ResetPlayerAnimation(info);
				int timeInAnimation3 = info.TimeInAnimation;
				Player player = this._player;
				float displayOpacity = info.DisplayOpacity;
				this._player.ResetEffects();
				this._player.ResetVisibleAccessories();
				this._player.UpdateMiscCounter();
				this._player.UpdateDyes();
				this._player.PlayerFrame();
				Player player2 = this._player;
				int num = 1;
				player2.socialIgnoreLight = num != 0;
				float x = player2.position.X;
				float y = player2.position.Y;
				if (num == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				if (num == 0)
				{
				}
				player2.position.X = displayOpacity;
				Player player3 = this._player;
				int width = player3.width;
				int height = player3.height;
				float x2 = player3.position.X;
				float y2 = player3.position.Y;
				player3.position.X = displayOpacity;
				player3.position.Y = (float)height;
				Player player4 = this._player;
				float displayOpacity2 = info.DisplayOpacity;
				float opacityForAnimation = player4.opacityForAnimation;
				Item[] inventory = player4.inventory;
				player4.opacityForAnimation = displayOpacity2;
				Vector2 position = player2.position;
				if (player4 == null)
				{
				}
				if (this._shaderEffect != null)
				{
					return;
				}
				Camera camera = Main.Camera;
				Player player5 = this._player;
				float x3 = player5.position.X;
				float y3 = player5.position.Y;
				float x4 = player5.fullRotationOrigin.X;
				float y4 = player5.fullRotationOrigin.Y;
			}

			// Token: 0x060048DD RID: 18653 RVA: 0x002609D8 File Offset: 0x0025EBD8
			private void ResetPlayerAnimation(GameAnimationSegment info)
			{
				Player player = this._player;
				if (!true)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				player.CopyVisuals(localPlayer);
				Player player2 = this._player;
				float x = info.AnchorPositionOnScreen.X;
				float y = info.AnchorPositionOnScreen.Y;
				float x2 = this._anchorOffset.X;
				float y2 = this._anchorOffset.Y;
				if (!true)
				{
				}
				this._player.opacityForAnimation = (float)16256;
			}

			// Token: 0x060048DE RID: 18654 RVA: 0x00260A50 File Offset: 0x0025EC50
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerSegment()
			{
			}

			// Token: 0x0400840E RID: 33806
			private Player _player;

			// Token: 0x0400840F RID: 33807
			private Vector2 _anchorOffset;

			// Token: 0x04008410 RID: 33808
			private Vector2 _normalizedOriginForHitbox;

			// Token: 0x04008411 RID: 33809
			private Segments.PlayerSegment.IShaderEffect _shaderEffect;

			// Token: 0x04008412 RID: 33810
			private static Item _blankItem;

			// Token: 0x02000999 RID: 2457
			public interface IShaderEffect
			{
				// Token: 0x060048DF RID: 18655
				void BeforeDrawing(GameAnimationSegment info);

				// Token: 0x060048E0 RID: 18656
				void AfterDrawing(GameAnimationSegment info);
			}

			// Token: 0x0200099A RID: 2458
			public class ImmediateSpritebatchForPlayerDyesEffect : Segments.PlayerSegment.IShaderEffect
			{
				// Token: 0x060048E1 RID: 18657 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BeforeDrawing(GameAnimationSegment info)
				{
				}

				// Token: 0x060048E2 RID: 18658 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void AfterDrawing(GameAnimationSegment info)
				{
				}

				// Token: 0x060048E3 RID: 18659 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public ImmediateSpritebatchForPlayerDyesEffect()
				{
				}
			}
		}

		// Token: 0x0200099B RID: 2459
		public class NPCSegment : Segments.AnimationSegmentWithActions<NPC>
		{
			// Token: 0x060048E4 RID: 18660 RVA: 0x00260A60 File Offset: 0x0025EC60
			public NPCSegment(int targetTime, int npcId, Vector2 anchorOffset, Vector2 normalizedNPCHitboxOrigin)
				: base(targetTime)
			{
				if (!true)
				{
				}
				this._npc.IsABestiaryIconDummy = true;
			}

			// Token: 0x060048E5 RID: 18661 RVA: 0x00260A84 File Offset: 0x0025EC84
			protected override void Bind(IAnimationSegmentAction<NPC> act)
			{
				NPC npc = this._npc;
			}

			// Token: 0x060048E6 RID: 18662 RVA: 0x00260A9C File Offset: 0x0025EC9C
			public override void Draw(GameAnimationSegment info)
			{
				int timeInAnimation = info.TimeInAnimation;
				float dedicatedTimeNeeded = base.DedicatedTimeNeeded;
				int timeInAnimation2 = info.TimeInAnimation;
				this.ResetNPCAnimation(info);
				int timeInAnimation3 = info.TimeInAnimation;
				NPC npc = this._npc;
				NPC npc2 = this._npc;
				int alpha = npc2.alpha;
				npc2.FindFrame();
				if (alpha == 0)
				{
				}
				int type = this._npc.type;
				if (alpha == 0)
				{
				}
				NPC npc3 = this._npc;
			}

			// Token: 0x060048E7 RID: 18663 RVA: 0x00260B50 File Offset: 0x0025ED50
			private void ResetNPCAnimation(GameAnimationSegment info)
			{
			}

			// Token: 0x04008413 RID: 33811
			private NPC _npc;

			// Token: 0x04008414 RID: 33812
			private Vector2 _anchorOffset;

			// Token: 0x04008415 RID: 33813
			private Vector2 _normalizedOriginForHitbox;
		}

		// Token: 0x0200099C RID: 2460
		public class LooseSprite
		{
			// Token: 0x060048E8 RID: 18664 RVA: 0x00260BD0 File Offset: 0x0025EDD0
			public LooseSprite(DrawData data, Asset<Texture2D> asset)
			{
				this._asset = asset;
				int num = 1;
				Asset<Texture2D> asset2 = this._asset;
				this._originalDrawData = num;
				int num2 = 16256;
				this.CurrentOpacity = (float)num2;
			}

			// Token: 0x060048E9 RID: 18665 RVA: 0x00260C08 File Offset: 0x0025EE08
			public void Reset()
			{
				Asset<Texture2D> asset = this._asset;
				this._originalDrawData = asset;
				int num = 16256;
				this.CurrentDrawData.effect = (SpriteEffects)num;
			}

			// Token: 0x04008416 RID: 33814
			private DrawData _originalDrawData;

			// Token: 0x04008417 RID: 33815
			private Asset<Texture2D> _asset;

			// Token: 0x04008418 RID: 33816
			public DrawData CurrentDrawData;

			// Token: 0x04008419 RID: 33817
			public float CurrentOpacity;
		}

		// Token: 0x0200099D RID: 2461
		public class SpriteSegment : Segments.AnimationSegmentWithActions<Segments.LooseSprite>
		{
			// Token: 0x060048EA RID: 18666 RVA: 0x00260C38 File Offset: 0x0025EE38
			public SpriteSegment(Asset<Texture2D> asset, int targetTime, DrawData data, Vector2 anchorOffset)
				: base(targetTime)
			{
			}

			// Token: 0x060048EB RID: 18667 RVA: 0x00260C4C File Offset: 0x0025EE4C
			protected override void Bind(IAnimationSegmentAction<Segments.LooseSprite> act)
			{
				Segments.LooseSprite sprite = this._sprite;
			}

			// Token: 0x060048EC RID: 18668 RVA: 0x00260C64 File Offset: 0x0025EE64
			public Segments.SpriteSegment UseShaderEffect(Segments.SpriteSegment.IShaderEffect shaderEffect)
			{
				this._shaderEffect = shaderEffect;
				return this;
			}

			// Token: 0x060048ED RID: 18669 RVA: 0x00260C7C File Offset: 0x0025EE7C
			public override void Draw(GameAnimationSegment info)
			{
				int timeInAnimation = info.TimeInAnimation;
				float dedicatedTimeNeeded = base.DedicatedTimeNeeded;
				int timeInAnimation2 = info.TimeInAnimation;
				Segments.LooseSprite sprite = this._sprite;
				Asset<Texture2D> asset = sprite._asset;
				sprite._originalDrawData = asset;
				int num = 16256;
				sprite.CurrentDrawData.effect = (SpriteEffects)num;
				int timeInAnimation3 = info.TimeInAnimation;
				Segments.LooseSprite sprite2 = this._sprite;
				Segments.LooseSprite sprite3 = this._sprite;
				float x = info.AnchorPositionOnScreen.X;
				float y = info.AnchorPositionOnScreen.Y;
				float x2 = this._anchorOffset.X;
				float y2 = this._anchorOffset.Y;
				if (sprite3 == null)
				{
				}
				Segments.LooseSprite sprite4 = this._sprite;
				float displayOpacity = info.DisplayOpacity;
				float currentOpacity = sprite4.CurrentOpacity;
				if (this._shaderEffect != null)
				{
					return;
				}
				if (this._shaderEffect != null)
				{
					return;
				}
			}

			// Token: 0x060048EE RID: 18670 RVA: 0x00260D4C File Offset: 0x0025EF4C
			private void ResetSpriteAnimation(GameAnimationSegment info)
			{
				Segments.LooseSprite sprite = this._sprite;
				Asset<Texture2D> asset = sprite._asset;
				sprite._originalDrawData = asset;
				int num = 16256;
				sprite.CurrentDrawData.effect = (SpriteEffects)num;
			}

			// Token: 0x0400841A RID: 33818
			private Segments.LooseSprite _sprite;

			// Token: 0x0400841B RID: 33819
			private Vector2 _anchorOffset;

			// Token: 0x0400841C RID: 33820
			private Segments.SpriteSegment.IShaderEffect _shaderEffect;

			// Token: 0x0200099E RID: 2462
			public interface IShaderEffect
			{
				// Token: 0x060048EF RID: 18671
				void BeforeDrawing(GameAnimationSegment info, DrawData drawData);

				// Token: 0x060048F0 RID: 18672
				void AfterDrawing(GameAnimationSegment info, DrawData drawData);
			}

			// Token: 0x0200099F RID: 2463
			public class MaskedFadeEffect : Segments.SpriteSegment.IShaderEffect
			{
				// Token: 0x060048F1 RID: 18673 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public MaskedFadeEffect([Optional] Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction fetchMatrixMethod, string shaderKey = "MaskedFade", int verticalFrameCount = 1, int verticalFrameWait = 1)
				{
				}

				// Token: 0x060048F2 RID: 18674 RVA: 0x00260D80 File Offset: 0x0025EF80
				private Matrix DefaultFetchMatrix()
				{
					return default(Matrix);
				}

				// Token: 0x060048F3 RID: 18675 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BeforeDrawing(GameAnimationSegment info, DrawData drawData)
				{
				}

				// Token: 0x060048F4 RID: 18676 RVA: 0x00003B83 File Offset: 0x00001D83
				public Segments.SpriteSegment.MaskedFadeEffect WithPanX(Segments.Panning panning)
				{
					return null;
				}

				// Token: 0x060048F5 RID: 18677 RVA: 0x00003B83 File Offset: 0x00001D83
				public Segments.SpriteSegment.MaskedFadeEffect WithPanY(Segments.Panning panning)
				{
					return null;
				}

				// Token: 0x060048F6 RID: 18678 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void AfterDrawing(GameAnimationSegment info, DrawData drawData)
				{
				}

				// Token: 0x0400841D RID: 33821
				private readonly string _shaderKey;

				// Token: 0x0400841E RID: 33822
				private readonly int _verticalFrameCount;

				// Token: 0x0400841F RID: 33823
				private readonly int _verticalFrameWait;

				// Token: 0x04008420 RID: 33824
				private Segments.Panning _panX;

				// Token: 0x04008421 RID: 33825
				private Segments.Panning _panY;

				// Token: 0x04008422 RID: 33826
				private Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction _fetchMatrix;

				// Token: 0x020009A0 RID: 2464
				// (Invoke) Token: 0x060048F8 RID: 18680
				public delegate Matrix GetMatrixAction();
			}
		}

		// Token: 0x020009A1 RID: 2465
		public struct Panning
		{
			// Token: 0x060048FB RID: 18683 RVA: 0x00260D98 File Offset: 0x0025EF98
			public float GetPanAmount(float time)
			{
				/*
An exception occurred when decompiling this method (060048FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Animations.Segments/Panning::GetPanAmount(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Panning::Delay, ldloc:valuetype Terraria.GameContent.Animations.Segments/Panning&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Panning::Duration, ldloc:valuetype Terraria.GameContent.Animations.Segments/Panning&(this)))
	stloc:float32(var_4_16, ldfld:float32(Panning::AmountOverTime, ldloc:valuetype Terraria.GameContent.Animations.Segments/Panning&(this)))
	stloc:float32(var_5_1E, ldfld:float32(Panning::StartAmount, ldloc:valuetype Terraria.GameContent.Animations.Segments/Panning&(this)))
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

			// Token: 0x04008423 RID: 33827
			public float AmountOverTime;

			// Token: 0x04008424 RID: 33828
			public float StartAmount;

			// Token: 0x04008425 RID: 33829
			public float Delay;

			// Token: 0x04008426 RID: 33830
			public float Duration;
		}

		// Token: 0x020009A2 RID: 2466
		public class EmoteSegment : IAnimationSegment
		{
			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x060048FC RID: 18684 RVA: 0x00260DC4 File Offset: 0x0025EFC4
			// (set) Token: 0x060048FD RID: 18685 RVA: 0x00260DD8 File Offset: 0x0025EFD8
			public float DedicatedTimeNeeded
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (060048FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Animations.Segments/EmoteSegment::get_DedicatedTimeNeeded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(EmoteSegment::<DedicatedTimeNeeded>k__BackingField, ldloc:EmoteSegment(this)))
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
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060048FE RID: 18686 RVA: 0x00260DE8 File Offset: 0x0025EFE8
			public EmoteSegment(int emoteId, int targetTime, int timeToPlay, Vector2 position, SpriteEffects drawEffect, [Optional] Vector2 velocity)
			{
				this._effect = position;
				this._velocity = emoteId;
				this._targetTime = targetTime;
			}

			// Token: 0x060048FF RID: 18687 RVA: 0x00260E14 File Offset: 0x0025F014
			public void Draw(GameAnimationSegment info)
			{
				int timeInAnimation = info.TimeInAnimation;
				int targetTime = this._targetTime;
				float num = this.<DedicatedTimeNeeded>k__BackingField;
				float x = info.AnchorPositionOnScreen.X;
				float y = info.AnchorPositionOnScreen.Y;
				float x2 = this._offset.X;
				float y2 = this._offset.Y;
				float x3 = this._velocity.X;
				float y3 = this._velocity.Y;
			}

			// Token: 0x06004900 RID: 18688 RVA: 0x00260EC4 File Offset: 0x0025F0C4
			private Rectangle GetFrame(int wrappedTime)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int emoteId = this._emoteId;
				if (num == 0)
				{
				}
				Rectangle rectangle;
				return rectangle;
			}

			// Token: 0x04008427 RID: 33831
			[CompilerGenerated]
			private float <DedicatedTimeNeeded>k__BackingField;

			// Token: 0x04008428 RID: 33832
			private int _targetTime;

			// Token: 0x04008429 RID: 33833
			private Vector2 _offset;

			// Token: 0x0400842A RID: 33834
			private SpriteEffects _effect;

			// Token: 0x0400842B RID: 33835
			private int _emoteId;

			// Token: 0x0400842C RID: 33836
			private Vector2 _velocity;
		}
	}
}
