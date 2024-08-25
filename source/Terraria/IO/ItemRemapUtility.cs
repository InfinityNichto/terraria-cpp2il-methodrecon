using System;
using Cpp2IlInjected;

namespace Terraria.IO
{
	// Token: 0x0200057C RID: 1404
	public static class ItemRemapUtility
	{
		// Token: 0x06003404 RID: 13316 RVA: 0x0020153C File Offset: 0x001FF73C
		public static bool IsForbidden(int id)
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x0020154C File Offset: 0x001FF74C
		public static short RemapItemID(int itemID, bool remapENGINEItems)
		{
			/*
An exception occurred when decompiling this method (06003405)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int16 Terraria.IO.ItemRemapUtility::RemapItemID(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_08, call:int32(ItemRemapUtility::RemapENGINEItemID, ldloc:int32(var_1)))
	call:void(Debug::LogWarning, ldloc:string[exp:object](var_3))
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

		// Token: 0x06003406 RID: 13318 RVA: 0x0020156C File Offset: 0x001FF76C
		public static int RemapNegativeItemID(int itemID)
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000021DB File Offset: 0x000003DB
		public static int RemapENGINEItemID(int itemID)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x0020157C File Offset: 0x001FF77C
		public static void RemapENGINEMannequin(short tileFrameX, short tileFrameY)
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000021DB File Offset: 0x000003DB
		private static int RemapENGINEHeadSlot(int headSlot)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000021DB File Offset: 0x000003DB
		private static int RemapENGINEBodySlot(int bodySlot)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000021DB File Offset: 0x000003DB
		private static int RemapENGINELegsSlot(int legsSlot)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040040B1 RID: 16561
		public const short DragonMask = 10000;

		// Token: 0x040040B2 RID: 16562
		public const short DragonBreastplate = 10001;

		// Token: 0x040040B3 RID: 16563
		public const short DragonGreaves = 10002;

		// Token: 0x040040B4 RID: 16564
		public const short SpectralHeadgear = 10003;

		// Token: 0x040040B5 RID: 16565
		public const short SpectralArmor = 10004;

		// Token: 0x040040B6 RID: 16566
		public const short SpectralSubligar = 10005;

		// Token: 0x040040B7 RID: 16567
		public const short TitanHelmet = 10006;

		// Token: 0x040040B8 RID: 16568
		public const short TitanMail = 10007;

		// Token: 0x040040B9 RID: 16569
		public const short TitanLeggings = 10008;

		// Token: 0x040040BA RID: 16570
		public const short OcramMask = 10009;

		// Token: 0x040040BB RID: 16571
		public const short HornedGodMask = 10010;

		// Token: 0x040040BC RID: 16572
		public const short HornedGodRobe = 10011;

		// Token: 0x040040BD RID: 16573
		public const short HornedGodBoots = 10012;

		// Token: 0x040040BE RID: 16574
		public const short OcramTrophy = 10013;

		// Token: 0x040040BF RID: 16575
		public const short AlbinoAntlionBanner = 10014;

		// Token: 0x040040C0 RID: 16576
		public const short ArchWyvernBanner = 10015;

		// Token: 0x040040C1 RID: 16577
		public const short ArchDemonBanner = 10016;

		// Token: 0x040040C2 RID: 16578
		public const short DragonSnatcherBanner = 10017;

		// Token: 0x040040C3 RID: 16579
		public const short OrcaBanner = 10018;

		// Token: 0x040040C4 RID: 16580
		public const short ShadowHammerBanner = 10019;

		// Token: 0x040040C5 RID: 16581
		public const short ShadowMummyBanner = 10020;

		// Token: 0x040040C6 RID: 16582
		public const short SpectralGastropodBanner = 10021;

		// Token: 0x040040C7 RID: 16583
		public const short SpectralElementalBanner = 10022;

		// Token: 0x040040C8 RID: 16584
		public const short VampireMinerBanner = 10023;

		// Token: 0x040040C9 RID: 16585
		public const short MusicBoxTutorial = 10024;

		// Token: 0x040040CA RID: 16586
		public const short StarTopper4 = 10025;

		// Token: 0x040040CB RID: 16587
		public const short StarTopper5 = 10026;

		// Token: 0x040040CC RID: 16588
		public const short ShirenHat = 10027;

		// Token: 0x040040CD RID: 16589
		public const short ShirenShirt = 10028;

		// Token: 0x040040CE RID: 16590
		public const short ShirenPants = 10029;

		// Token: 0x040040CF RID: 16591
		public const short MonokumaHead = 10030;

		// Token: 0x040040D0 RID: 16592
		public const short MonokumaBody = 10031;

		// Token: 0x040040D1 RID: 16593
		public const short MonokumaLegs = 10032;

		// Token: 0x040040D2 RID: 16594
		public const short WhiteThread = 10033;

		// Token: 0x040040D3 RID: 16595
		public const short MonomiHead = 10034;

		// Token: 0x040040D4 RID: 16596
		public const short MonomiBody = 10035;

		// Token: 0x040040D5 RID: 16597
		public const short MonomiLegs = 10036;

		// Token: 0x040040D6 RID: 16598
		public const short TorosHead = 10037;

		// Token: 0x040040D7 RID: 16599
		public const short TorosBody = 10038;

		// Token: 0x040040D8 RID: 16600
		public const short TorosLegs = 10039;
	}
}
