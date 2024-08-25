using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Terraria.GameContent
{
	// Token: 0x020007FA RID: 2042
	public class TownNPCProfiles
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x00247F14 File Offset: 0x00246114
		public bool GetProfile(int npcId, [Out] ITownNPCProfile profile)
		{
			/*
An exception occurred when decompiling this method (0600418A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TownNPCProfiles::GetProfile(System.Int32,Terraria.GameContent.ITownNPCProfile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.ITownNPCProfile>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.ITownNPCProfile>(TownNPCProfiles::_townNPCProfiles, ldloc:TownNPCProfiles(this)))
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

		// Token: 0x0600418B RID: 16779 RVA: 0x00247F28 File Offset: 0x00246128
		public static ITownNPCProfile LegacyWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniquePartyTexture = true, bool uniquePartyTextureShimmered = true)
		{
			string text2;
			string text = "Images/TownNPCs/Shimmered/" + text2;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00247F48 File Offset: 0x00246148
		public static ITownNPCProfile TransformableWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniqueCreditTexture = true, bool uniqueCreditTextureShimmered = true)
		{
			string text2;
			string text = "Images/TownNPCs/Shimmered/" + text2;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00247F68 File Offset: 0x00246168
		public static int GetHeadIndexSafe(NPC npc)
		{
			if (!true)
			{
			}
			return NPC.TypeToDefaultHeadIndex(int.MinValue);
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00247F8C File Offset: 0x0024618C
		public TownNPCProfiles()
		{
			long num = 0L;
			long num2 = 0L;
			ITownNPCProfile townNPCProfile = TownNPCProfiles.LegacyWithSimpleShimmer("Guide", 1, 72, num != 0L, num2 != 0L);
			long num3 = 0L;
			long num4 = 0L;
			ITownNPCProfile townNPCProfile2 = TownNPCProfiles.LegacyWithSimpleShimmer("Dryad", 5, 73, num3 != 0L, num4 != 0L);
			long num5 = 0L;
			long num6 = 0L;
			ITownNPCProfile townNPCProfile3 = TownNPCProfiles.LegacyWithSimpleShimmer("ArmsDealer", 6, 74, num5 != 0L, num6 != 0L);
			long num7 = 0L;
			long num8 = 0L;
			ITownNPCProfile townNPCProfile4 = TownNPCProfiles.LegacyWithSimpleShimmer("GoblinTinkerer", 9, 75, num7 != 0L, num8 != 0L);
			long num9 = 0L;
			long num10 = 0L;
			ITownNPCProfile townNPCProfile5 = TownNPCProfiles.LegacyWithSimpleShimmer("Truffle", 12, 76, num9 != 0L, num10 != 0L);
			long num11 = 0L;
			long num12 = 0L;
			ITownNPCProfile townNPCProfile6 = TownNPCProfiles.LegacyWithSimpleShimmer("PartyGirl", 15, 77, num11 != 0L, num12 != 0L);
			long num13 = 0L;
			long num14 = 0L;
			ITownNPCProfile townNPCProfile7 = TownNPCProfiles.LegacyWithSimpleShimmer("WitchDoctor", 18, 78, num13 != 0L, num14 != 0L);
			long num15 = 0L;
			long num16 = 0L;
			ITownNPCProfile townNPCProfile8 = TownNPCProfiles.LegacyWithSimpleShimmer("Tavernkeep", 24, 79, num15 != 0L, num16 != 0L);
			long num17 = 0L;
			ITownNPCProfile townNPCProfile9 = TownNPCProfiles.LegacyWithSimpleShimmer("Angler", 22, 55, true, num17 != 0L);
			long num18 = 0L;
			ITownNPCProfile townNPCProfile10 = TownNPCProfiles.LegacyWithSimpleShimmer("Clothier", 7, 57, true, num18 != 0L);
			ITownNPCProfile townNPCProfile11 = TownNPCProfiles.LegacyWithSimpleShimmer("Cyborg", 16, 58, true, true);
			ITownNPCProfile townNPCProfile12 = TownNPCProfiles.LegacyWithSimpleShimmer("Demolitionist", 4, 59, true, true);
			ITownNPCProfile townNPCProfile13 = TownNPCProfiles.LegacyWithSimpleShimmer("DyeTrader", 14, 60, true, true);
			long num19 = 0L;
			ITownNPCProfile townNPCProfile14 = TownNPCProfiles.LegacyWithSimpleShimmer("Golfer", 25, 61, true, num19 != 0L);
			ITownNPCProfile townNPCProfile15 = TownNPCProfiles.LegacyWithSimpleShimmer("Mechanic", 8, 62, true, true);
			ITownNPCProfile townNPCProfile16 = TownNPCProfiles.LegacyWithSimpleShimmer("Merchant", 2, 63, true, true);
			ITownNPCProfile townNPCProfile17 = TownNPCProfiles.LegacyWithSimpleShimmer("Nurse", 3, 64, true, true);
			long num20 = 0L;
			ITownNPCProfile townNPCProfile18 = TownNPCProfiles.LegacyWithSimpleShimmer("Painter", 17, 65, true, num20 != 0L);
			ITownNPCProfile townNPCProfile19 = TownNPCProfiles.LegacyWithSimpleShimmer("Pirate", 19, 66, true, true);
			ITownNPCProfile townNPCProfile20 = TownNPCProfiles.LegacyWithSimpleShimmer("Pirate", 11, 67, true, true);
			long num21 = 0L;
			ITownNPCProfile townNPCProfile21 = TownNPCProfiles.LegacyWithSimpleShimmer("Steampunker", 13, 68, true, num21 != 0L);
			ITownNPCProfile townNPCProfile22 = TownNPCProfiles.LegacyWithSimpleShimmer("Stylist", 20, 69, true, true);
			ITownNPCProfile townNPCProfile23 = TownNPCProfiles.LegacyWithSimpleShimmer("TaxCollector", 23, 70, true, true);
			ITownNPCProfile townNPCProfile24 = TownNPCProfiles.LegacyWithSimpleShimmer("Wizard", 10, 71, true, true);
			ITownNPCProfile townNPCProfile25 = TownNPCProfiles.LegacyWithSimpleShimmer("Princess", 45, 54, true, true);
			long num22 = 0L;
			ITownNPCProfile townNPCProfile26 = TownNPCProfiles.TransformableWithSimpleShimmer("BestiaryGirl", 26, 56, true, num22 != 0L);
			ITownNPCProfile townNPCProfile27 = TownNPCProfiles.LegacyWithSimpleShimmer("TravelingMerchant", 21, 80, true, true);
			if (("Siamese" == null || "Siamese" != null) && ("Black" == null || "Black" != null) && ("OrangeTabby" == null || "OrangeTabby" != null) && ("RussianBlue" == null || "RussianBlue" != null) && ("Silver" == null || "Silver" != null) && ("White" == null || "White" != null) && ("Labrador" == null || "Labrador" != null) && ("PitBull" == null || "PitBull" != null) && ("Beagle" == null || "Beagle" != null) && ("Corgi" == null || "Corgi" != null) && ("Dalmation" == null || "Dalmation" != null) && ("Husky" == null || "Husky" != null) && ("White" == null || "White" != null) && ("Angora" == null || "Angora" != null) && ("Dutch" == null || "Dutch" != null) && ("Flemish" == null || "Flemish" != null) && ("Lop" == null || "Lop" != null) && ("Silver" == null || "Silver" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x002482F0 File Offset: 0x002464F0
		// Note: this type is marked as 'beforefieldinit'.
		static TownNPCProfiles()
		{
		}

		// Token: 0x0400806D RID: 32877
		private const string DefaultNPCFileFolderPath = "Images/TownNPCs/";

		// Token: 0x0400806E RID: 32878
		private const string ShimmeredNPCFileFolderPath = "Images/TownNPCs/Shimmered/";

		// Token: 0x0400806F RID: 32879
		private static readonly int[] CatHeadIDs;

		// Token: 0x04008070 RID: 32880
		private static readonly int[] DogHeadIDs;

		// Token: 0x04008071 RID: 32881
		private static readonly int[] BunnyHeadIDs;

		// Token: 0x04008072 RID: 32882
		private static readonly int[] SlimeHeadIDs;

		// Token: 0x04008073 RID: 32883
		private Dictionary<int, ITownNPCProfile> _townNPCProfiles;

		// Token: 0x04008074 RID: 32884
		public static TownNPCProfiles Instance;
	}
}
