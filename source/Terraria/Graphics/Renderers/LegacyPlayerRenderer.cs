using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075D RID: 1885
	public class LegacyPlayerRenderer : IPlayerRenderer
	{
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x0023AF94 File Offset: 0x00239194
		public static SamplerState MountedSamplerState
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003DFA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SamplerState Terraria.Graphics.Renderers.LegacyPlayerRenderer::get_MountedSamplerState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06003DFB RID: 15867 RVA: 0x0023AFA4 File Offset: 0x002391A4
		public void DrawPlayers(Camera camera, IEnumerable<Player> players)
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			int num = 32640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x0023B034 File Offset: 0x00239234
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
		{
			int num = 1;
			bool shouldNotDraw = drawPlayer.ShouldNotDraw;
			if (num == 0)
			{
			}
			List<int> dust = this._dust;
			int version = dust._version;
			dust._syncRoot = version;
			List<int> gore = this._gore;
			int version2 = gore._version;
			gore._syncRoot = version2;
			DrawData[] drawData = this._drawData;
			if (version2 == 0)
			{
			}
			SpriteBatchItem.PopClippedImageRegion();
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x0023B0AC File Offset: 0x002392AC
		private void RenderOutlines(int count, float alpha, float scale, Color borderColor)
		{
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0023B13C File Offset: 0x0023933C
		public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
		{
			bool shouldNotDraw = drawPlayer.ShouldNotDraw;
			List<int> dust = this._dust;
			int version = dust._version;
			dust._syncRoot = version;
			List<int> gore = this._gore;
			int version2 = gore._version;
			gore._syncRoot = version2;
			DrawData[] drawData = this._drawData;
			if (version2 == 0)
			{
			}
			if (version2 == 0)
			{
			}
			if (version2 == 0)
			{
			}
			if (version2 == 0)
			{
			}
			if (version2 == 0 || version2 == 0)
			{
			}
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0023B1A4 File Offset: 0x002393A4
		private static void DrawPlayer_MountTransformation(PlayerDrawSet drawInfo)
		{
			if (!true)
			{
			}
			PlayerDrawLayers.DrawPlayer_02_MountBehindPlayer(drawInfo);
			PlayerDrawLayers.DrawPlayer_23_MountFront(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_MountPlus(drawInfo);
			PlayerDrawLayers.DrawPlayer_26_SolarShield(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_MountMinus(drawInfo);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x0023B1D4 File Offset: 0x002393D4
		private static void DrawPlayer_UseNormalLayers(PlayerDrawSet drawInfo)
		{
			if (!true)
			{
			}
			PlayerDrawLayers.DrawPlayer_extra_TorsoPlus(drawInfo);
			PlayerDrawLayers.DrawPlayer_01_2_JimsCloak(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoMinus(drawInfo);
			PlayerDrawLayers.DrawPlayer_02_MountBehindPlayer(drawInfo);
			PlayerDrawLayers.DrawPlayer_03_Carpet(drawInfo);
			PlayerDrawLayers.DrawPlayer_03_PortableStool(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoPlus(drawInfo);
			PlayerDrawLayers.DrawPlayer_04_ElectrifiedDebuffBack(drawInfo);
			PlayerDrawLayers.DrawPlayer_05_ForbiddenSetRing(drawInfo);
			PlayerDrawLayers.DrawPlayer_05_2_SafemanSun(drawInfo);
			PlayerDrawLayers.DrawPlayer_06_WebbedDebuffBack(drawInfo);
			PlayerDrawLayers.DrawPlayer_07_LeinforsHairShampoo(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoMinus(drawInfo);
			PlayerDrawLayers.DrawPlayer_08_Backpacks(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoPlus(drawInfo);
			PlayerDrawLayers.DrawPlayer_08_1_Tails(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoMinus(drawInfo);
			PlayerDrawLayers.DrawPlayer_09_Wings(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoPlus(drawInfo);
			PlayerDrawLayers.DrawPlayer_01_BackHair(drawInfo);
			PlayerDrawLayers.DrawPlayer_10_BackAcc(drawInfo);
			PlayerDrawLayers.DrawPlayer_01_3_BackHead(drawInfo);
			PlayerDrawLayers.DrawPlayer_extra_TorsoMinus(drawInfo);
			PlayerDrawLayers.DrawPlayer_11_Balloons(drawInfo);
			WeaponDrawOrder weaponDrawOrder = drawInfo.weaponDrawOrder;
			if (weaponDrawOrder == WeaponDrawOrder.BehindBackArm)
			{
				if (weaponDrawOrder == WeaponDrawOrder.BehindBackArm)
				{
				}
				PlayerDrawLayers.DrawPlayer_27_HeldItem(drawInfo);
			}
			if (weaponDrawOrder == WeaponDrawOrder.BehindBackArm)
			{
			}
			PlayerDrawLayers.DrawPlayer_12_Skin(drawInfo);
			Player drawPlayer = drawInfo.drawPlayer;
			int body;
			if (drawPlayer.wearsRobe)
			{
				body = drawPlayer.body;
			}
			if (body == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_13_Leggings(drawInfo);
			PlayerDrawLayers.DrawPlayer_14_Shoes(drawInfo);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x0023B3E4 File Offset: 0x002395E4
		private void DrawPlayerFull(Camera camera, Player drawPlayer)
		{
			if (!true)
			{
			}
			bool active = drawPlayer.mount._active;
			if (active)
			{
				float fullRotation = drawPlayer.fullRotation;
				if (!active)
				{
				}
				SamplerState mountedSamplerState = LegacyPlayerRenderer.MountedSamplerState;
			}
			if (!active)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				drawPlayer.PlayerFrame();
			}
			bool ghost = drawPlayer.ghost;
			if (ghost)
			{
				float x = drawPlayer.position.X;
				float y = drawPlayer.position.Y;
				float x2 = drawPlayer.velocity.X;
				float y2 = drawPlayer.velocity.Y;
				if (!ghost)
				{
				}
				float x3 = drawPlayer.position.X;
				float y3 = drawPlayer.position.Y;
				return;
			}
			if (drawPlayer.inventory.position == null)
			{
				int head = drawPlayer.head;
				int wings = drawPlayer.wings;
			}
			int itemFlameCount = drawPlayer.itemFlameCount;
			drawPlayer.itemFlameCount = itemFlameCount;
			int num2 = 5;
			drawPlayer.itemFlameCount = num2;
			Vector2[] itemFlamePos = drawPlayer.itemFlamePos;
			if (num2 == 0)
			{
			}
			Vector2[] itemFlamePos2 = drawPlayer.itemFlamePos;
			if (drawPlayer.armorEffectDrawShadowEOCShield)
			{
				int eocDash = drawPlayer.eocDash;
				Vector2[] shadowPos = drawPlayer.shadowPos;
				float[] shadowRotation = drawPlayer.shadowRotation;
				Vector2[] shadowOrigin = drawPlayer.shadowOrigin;
			}
			if (drawPlayer.invis)
			{
				Vector2 position = drawPlayer.position;
				int aggro = drawPlayer.aggro;
				float fullRotation2 = drawPlayer.fullRotation;
				float x4 = drawPlayer.fullRotationOrigin.X;
				float y4 = drawPlayer.fullRotationOrigin.Y;
				int num3 = 1;
				drawPlayer.invis = num3 != 0;
				return;
			}
			bool armorEffectDrawOutlines = drawPlayer.armorEffectDrawOutlines;
			if (armorEffectDrawOutlines)
			{
				if (!armorEffectDrawOutlines)
				{
				}
				float ghostFade = drawPlayer.ghostFade;
				if (!armorEffectDrawOutlines)
				{
					float ghostDir = drawPlayer.ghostDir;
					drawPlayer.ghostFade = ghostFade;
				}
				return;
			}
			if (drawPlayer.armorEffectDrawShadowBasilisk)
			{
				float basiliskCharge = drawPlayer.basiliskCharge;
				Vector2[] shadowPos2 = drawPlayer.shadowPos;
				float[] shadowRotation2 = drawPlayer.shadowRotation;
				Vector2[] shadowOrigin2 = drawPlayer.shadowOrigin;
				return;
			}
			Vector2[] shadowOrigin3;
			if (drawPlayer.armorEffectDrawShadow)
			{
				Vector2[] shadowPos3 = drawPlayer.shadowPos;
				float[] shadowRotation3 = drawPlayer.shadowRotation;
				shadowOrigin3 = drawPlayer.shadowOrigin;
				float x5 = shadowPos3.X;
				float y5 = shadowPos3.Y;
				float value = shadowRotation3.m_value;
			}
			Vector2[] shadowOrigin4;
			if (drawPlayer.armorEffectDrawShadowLokis)
			{
				Vector2[] shadowPos4 = drawPlayer.shadowPos;
				float gfxOffY = drawPlayer.gfxOffY;
				float x6 = drawPlayer.position.X;
				float y6 = drawPlayer.position.Y;
				float x7 = shadowPos4.X;
				float y7 = shadowPos4.Y;
				if (shadowPos4 == null)
				{
				}
				float[] shadowRotation4 = drawPlayer.shadowRotation;
				shadowOrigin4 = drawPlayer.shadowOrigin;
				float value2 = shadowRotation4.m_value;
			}
			if (drawPlayer.armorEffectDrawShadowSubtle)
			{
				if (shadowOrigin3 == null)
				{
				}
				Vector2 position2 = drawPlayer.position;
				float y8 = drawPlayer.position.Y;
				float gfxOffY2 = drawPlayer.gfxOffY;
				float fullRotation3 = drawPlayer.fullRotation;
				float x8 = drawPlayer.fullRotationOrigin.X;
				float y9 = drawPlayer.fullRotationOrigin.Y;
				if (shadowOrigin4 == null)
				{
				}
			}
			bool shadowDodge = drawPlayer.shadowDodge;
			float shadowDodgeCount = drawPlayer.shadowDodgeCount;
			if (shadowDodge)
			{
				drawPlayer.shadowDodgeCount = shadowDodgeCount;
				int num4 = 16880;
				drawPlayer.shadowDodgeCount = (float)num4;
				return;
			}
			drawPlayer.shadowDodgeCount = shadowDodgeCount;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x0023B8C4 File Offset: 0x00239AC4
		private void DrawPlayerStoned(Camera camera, Player drawPlayer, Vector2 position)
		{
			if (!drawPlayer.dead)
			{
				int direction = drawPlayer.direction;
				if (!true)
				{
				}
				Vector2 unscaledPosition = camera.UnscaledPosition;
				int width = drawPlayer.bodyFrame.Width;
				int width2 = drawPlayer.width;
				Vector2 unscaledPosition2 = camera.UnscaledPosition;
				int height = drawPlayer.height;
				int height2 = drawPlayer.bodyFrame.Height;
				int num = 32640;
				float x = drawPlayer.bodyPosition.X;
				float y = drawPlayer.bodyPosition.Y;
				if (num == 0)
				{
				}
				int width3 = drawPlayer.bodyFrame.Width;
				int height3 = drawPlayer.bodyFrame.Height;
				int width4 = drawPlayer.width;
				bool wet = drawPlayer.wet;
				if (width3 == 0)
				{
				}
			}
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0023B980 File Offset: 0x00239B80
		private void DrawGhost(Camera camera, Player drawPlayer, Vector2 position, float shadow = 0f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int direction = drawPlayer.direction;
			int height = drawPlayer.height;
			float x = drawPlayer.position.X;
			float y = drawPlayer.position.Y;
			int height2 = drawPlayer.height;
			if (num == 0)
			{
			}
			if (63488 == 0)
			{
			}
			int ghostFrame = drawPlayer.ghostFrame;
			if (!true)
			{
			}
			Vector2 unscaledPosition = camera.UnscaledPosition;
			Vector2 unscaledPosition2 = camera.UnscaledPosition;
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x0023B9F8 File Offset: 0x00239BF8
		public LegacyPlayerRenderer()
		{
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x0023BA0C File Offset: 0x00239C0C
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyPlayerRenderer()
		{
		}

		// Token: 0x04007CC4 RID: 31940
		private readonly DrawData[] _drawData;

		// Token: 0x04007CC5 RID: 31941
		private readonly List<int> _dust;

		// Token: 0x04007CC6 RID: 31942
		private readonly List<int> _gore;

		// Token: 0x04007CC7 RID: 31943
		private static Vector2[] OutlineOffsets;
	}
}
