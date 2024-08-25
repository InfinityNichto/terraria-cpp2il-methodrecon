using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000640 RID: 1600
	public struct PlayerDrawSet
	{
		// Token: 0x06003662 RID: 13922 RVA: 0x00212C78 File Offset: 0x00210E78
		public void AddDrawData(DrawData data)
		{
			DrawData[] drawDataCache = this.DrawDataCache;
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00212C8C File Offset: 0x00210E8C
		public void AddDrawData(DrawData data)
		{
			DrawData[] drawDataCache = this.DrawDataCache;
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x00212CA0 File Offset: 0x00210EA0
		public Vector2 Center
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003664)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.DataStructures.PlayerDrawSet::get_Center()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_0_06, ldfld:Player(PlayerDrawSet::drawPlayer, ldloc:valuetype Terraria.DataStructures.PlayerDrawSet&(this)))
	stloc:float32(var_1_12, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](PlayerDrawSet::Position, ldloc:valuetype Terraria.DataStructures.PlayerDrawSet&(this))))
	stloc:float32(var_2_1E, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](PlayerDrawSet::Position, ldloc:valuetype Terraria.DataStructures.PlayerDrawSet&(this))))
	stloc:int32(var_3_25, ldfld:int32(Entity::width, ldloc:Player[exp:Entity](var_0_06)))
	stloc:bool(var_4_2C, ldfld:bool(Entity::wet, ldloc:Player[exp:Entity](var_0_06)))
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

		// Token: 0x06003665 RID: 13925 RVA: 0x000021DB File Offset: 0x000003DB
		public void BoringSetup(Player player, DrawData[] drawData, List<int> dust, List<int> gore, Vector2 drawPosition, float shadowOpacity, float rotation, Vector2 rotationOrigin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00212CDC File Offset: 0x00210EDC
		private void AdjustmentsForWolfMount()
		{
			Player player = this.drawPlayer;
			int num = 1;
			this.hideEntirePlayer = num != 0;
			int direction = player.direction;
			float x = this.Position.X;
			float y = this.Position.Y;
			if (direction == 0)
			{
			}
			Player player2 = this.drawPlayer;
			float x2 = this.Position.X;
			Item item = this.heldItem;
			int direction2 = player2.direction;
			this.Position.X = x2;
			int heldProj = player2.heldProj;
			byte useStyle = item.useStyle;
			float x3 = this.ItemLocation.X;
			float y2 = this.ItemLocation.Y;
			if (direction2 == 0)
			{
			}
			this.ItemLocation.X = x2;
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00212E7C File Offset: 0x0021107C
		private void CreateCompositeData()
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
			Player player = this.drawPlayer;
			int body = player.body;
			if (player == null)
			{
			}
			Player player2 = this.drawPlayer;
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00213108 File Offset: 0x00211308
		private void CreateCompositeData_DetermineShoulderOffsets(int armor, int targetFrameNumber)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000021DB File Offset: 0x000003DB
		private Rectangle CreateCompositeFrameRect(Point pt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0021313C File Offset: 0x0021133C
		private void UpdateCompositeArm(Player.CompositeArmData data, float rotation, Point frameIndex, int targetX)
		{
		}

		// Token: 0x0400771A RID: 30490
		public int DrawDataCacheCount;

		// Token: 0x0400771B RID: 30491
		public DrawData[] DrawDataCache;

		// Token: 0x0400771C RID: 30492
		public List<int> DustCache;

		// Token: 0x0400771D RID: 30493
		public List<int> GoreCache;

		// Token: 0x0400771E RID: 30494
		public Player drawPlayer;

		// Token: 0x0400771F RID: 30495
		public float shadow;

		// Token: 0x04007720 RID: 30496
		public Vector2 Position;

		// Token: 0x04007721 RID: 30497
		public int projectileDrawPosition;

		// Token: 0x04007722 RID: 30498
		public Vector2 ItemLocation;

		// Token: 0x04007723 RID: 30499
		public int armorAdjust;

		// Token: 0x04007724 RID: 30500
		public bool missingHand;

		// Token: 0x04007725 RID: 30501
		public bool missingArm;

		// Token: 0x04007726 RID: 30502
		public bool heldProjOverHand;

		// Token: 0x04007727 RID: 30503
		public int skinVar;

		// Token: 0x04007728 RID: 30504
		public bool fullHair;

		// Token: 0x04007729 RID: 30505
		public bool drawsBackHairWithoutHeadgear;

		// Token: 0x0400772A RID: 30506
		public bool hatHair;

		// Token: 0x0400772B RID: 30507
		public bool hideHair;

		// Token: 0x0400772C RID: 30508
		public int hairDyePacked;

		// Token: 0x0400772D RID: 30509
		public int skinDyePacked;

		// Token: 0x0400772E RID: 30510
		public float mountOffSet;

		// Token: 0x0400772F RID: 30511
		public int cHead;

		// Token: 0x04007730 RID: 30512
		public int cBody;

		// Token: 0x04007731 RID: 30513
		public int cLegs;

		// Token: 0x04007732 RID: 30514
		public int cHandOn;

		// Token: 0x04007733 RID: 30515
		public int cHandOff;

		// Token: 0x04007734 RID: 30516
		public int cBack;

		// Token: 0x04007735 RID: 30517
		public int cFront;

		// Token: 0x04007736 RID: 30518
		public int cShoe;

		// Token: 0x04007737 RID: 30519
		public int cFlameWaker;

		// Token: 0x04007738 RID: 30520
		public int cWaist;

		// Token: 0x04007739 RID: 30521
		public int cShield;

		// Token: 0x0400773A RID: 30522
		public int cNeck;

		// Token: 0x0400773B RID: 30523
		public int cFace;

		// Token: 0x0400773C RID: 30524
		public int cBalloon;

		// Token: 0x0400773D RID: 30525
		public int cWings;

		// Token: 0x0400773E RID: 30526
		public int cCarpet;

		// Token: 0x0400773F RID: 30527
		public int cPortableStool;

		// Token: 0x04007740 RID: 30528
		public int cFloatingTube;

		// Token: 0x04007741 RID: 30529
		public int cUnicornHorn;

		// Token: 0x04007742 RID: 30530
		public int cAngelHalo;

		// Token: 0x04007743 RID: 30531
		public int cBeard;

		// Token: 0x04007744 RID: 30532
		public int cLeinShampoo;

		// Token: 0x04007745 RID: 30533
		public int cBackpack;

		// Token: 0x04007746 RID: 30534
		public int cTail;

		// Token: 0x04007747 RID: 30535
		public int cFaceHead;

		// Token: 0x04007748 RID: 30536
		public int cFaceFlower;

		// Token: 0x04007749 RID: 30537
		public int cBalloonFront;

		// Token: 0x0400774A RID: 30538
		public SpriteEffects playerEffect;

		// Token: 0x0400774B RID: 30539
		public SpriteEffects itemEffect;

		// Token: 0x0400774C RID: 30540
		public Color colorHair;

		// Token: 0x0400774D RID: 30541
		public Color colorEyeWhites;

		// Token: 0x0400774E RID: 30542
		public Color colorEyes;

		// Token: 0x0400774F RID: 30543
		public Color colorHead;

		// Token: 0x04007750 RID: 30544
		public Color colorBodySkin;

		// Token: 0x04007751 RID: 30545
		public Color colorLegs;

		// Token: 0x04007752 RID: 30546
		public Color colorShirt;

		// Token: 0x04007753 RID: 30547
		public Color colorUnderShirt;

		// Token: 0x04007754 RID: 30548
		public Color colorPants;

		// Token: 0x04007755 RID: 30549
		public Color colorShoes;

		// Token: 0x04007756 RID: 30550
		public Color colorArmorHead;

		// Token: 0x04007757 RID: 30551
		public Color colorArmorBody;

		// Token: 0x04007758 RID: 30552
		public Color colorMount;

		// Token: 0x04007759 RID: 30553
		public Color colorArmorLegs;

		// Token: 0x0400775A RID: 30554
		public Color colorElectricity;

		// Token: 0x0400775B RID: 30555
		public Color colorDisplayDollSkin;

		// Token: 0x0400775C RID: 30556
		public int headGlowMask;

		// Token: 0x0400775D RID: 30557
		public int bodyGlowMask;

		// Token: 0x0400775E RID: 30558
		public int armGlowMask;

		// Token: 0x0400775F RID: 30559
		public int legsGlowMask;

		// Token: 0x04007760 RID: 30560
		public Color headGlowColor;

		// Token: 0x04007761 RID: 30561
		public Color bodyGlowColor;

		// Token: 0x04007762 RID: 30562
		public Color armGlowColor;

		// Token: 0x04007763 RID: 30563
		public Color legsGlowColor;

		// Token: 0x04007764 RID: 30564
		public Color ArkhalisColor;

		// Token: 0x04007765 RID: 30565
		public float stealth;

		// Token: 0x04007766 RID: 30566
		public Vector2 legVect;

		// Token: 0x04007767 RID: 30567
		public Vector2 bodyVect;

		// Token: 0x04007768 RID: 30568
		public Vector2 headVect;

		// Token: 0x04007769 RID: 30569
		public Color selectionGlowColor;

		// Token: 0x0400776A RID: 30570
		public float torsoOffset;

		// Token: 0x0400776B RID: 30571
		public bool hidesTopSkin;

		// Token: 0x0400776C RID: 30572
		public bool hidesBottomSkin;

		// Token: 0x0400776D RID: 30573
		public float rotation;

		// Token: 0x0400776E RID: 30574
		public Vector2 rotationOrigin;

		// Token: 0x0400776F RID: 30575
		public Rectangle hairFrontFrame;

		// Token: 0x04007770 RID: 30576
		public Rectangle hairBackFrame;

		// Token: 0x04007771 RID: 30577
		public bool backHairDraw;

		// Token: 0x04007772 RID: 30578
		public Color itemColor;

		// Token: 0x04007773 RID: 30579
		public bool usesCompositeTorso;

		// Token: 0x04007774 RID: 30580
		public bool usesCompositeFrontHandAcc;

		// Token: 0x04007775 RID: 30581
		public bool usesCompositeBackHandAcc;

		// Token: 0x04007776 RID: 30582
		public bool compShoulderOverFrontArm;

		// Token: 0x04007777 RID: 30583
		public Rectangle compBackShoulderFrame;

		// Token: 0x04007778 RID: 30584
		public Rectangle compFrontShoulderFrame;

		// Token: 0x04007779 RID: 30585
		public Rectangle compBackArmFrame;

		// Token: 0x0400777A RID: 30586
		public Rectangle compFrontArmFrame;

		// Token: 0x0400777B RID: 30587
		public Rectangle compTorsoFrame;

		// Token: 0x0400777C RID: 30588
		public float compositeBackArmRotation;

		// Token: 0x0400777D RID: 30589
		public float compositeFrontArmRotation;

		// Token: 0x0400777E RID: 30590
		public bool hideCompositeShoulders;

		// Token: 0x0400777F RID: 30591
		public Vector2 frontShoulderOffset;

		// Token: 0x04007780 RID: 30592
		public Vector2 backShoulderOffset;

		// Token: 0x04007781 RID: 30593
		public WeaponDrawOrder weaponDrawOrder;

		// Token: 0x04007782 RID: 30594
		public bool weaponOverFrontArm;

		// Token: 0x04007783 RID: 30595
		public bool isSitting;

		// Token: 0x04007784 RID: 30596
		public bool isSleeping;

		// Token: 0x04007785 RID: 30597
		public float seatYOffset;

		// Token: 0x04007786 RID: 30598
		public int sittingIndex;

		// Token: 0x04007787 RID: 30599
		public bool drawFrontAccInNeckAccLayer;

		// Token: 0x04007788 RID: 30600
		public Item heldItem;

		// Token: 0x04007789 RID: 30601
		public bool drawFloatingTube;

		// Token: 0x0400778A RID: 30602
		public bool drawUnicornHorn;

		// Token: 0x0400778B RID: 30603
		public bool drawAngelHalo;

		// Token: 0x0400778C RID: 30604
		public Color floatingTubeColor;

		// Token: 0x0400778D RID: 30605
		public Vector2 hairOffset;

		// Token: 0x0400778E RID: 30606
		public Vector2 helmetOffset;

		// Token: 0x0400778F RID: 30607
		public Vector2 legsOffset;

		// Token: 0x04007790 RID: 30608
		public bool hideEntirePlayer;
	}
}
