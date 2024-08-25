using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Metadata;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.Physics;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000A03 RID: 2563
	public static class GolfHelper
	{
		// Token: 0x06004BAB RID: 19371 RVA: 0x0026F6DC File Offset: 0x0026D8DC
		public static BallStepResult StepGolfBall(Entity entity, float angularVelocity)
		{
			if (!true)
			{
			}
			BallStepResult ballStepResult;
			return ballStepResult;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x0026F6F0 File Offset: 0x0026D8F0
		public static Vector2 FindVectorOnOval(Vector2 vector, Vector2 radius)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0026F710 File Offset: 0x0026D910
		public static GolfHelper.ShotStrength CalculateShotStrength(Vector2 shotVector, GolfHelper.ClubProperties clubProperties)
		{
			/*
An exception occurred when decompiling this method (06004BAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Golf.GolfHelper/ShotStrength Terraria.GameContent.Golf.GolfHelper::CalculateShotStrength(Microsoft.Xna.Framework.Vector2,Terraria.GameContent.Golf.GolfHelper/ClubProperties)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:float32(var_10_3E, call:float32(Math::Max, ldloc:float32(var_8_2D), ldloc:float32(var_6_1E)))
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

		// Token: 0x06004BAE RID: 19374 RVA: 0x0026F75C File Offset: 0x0026D95C
		public static bool IsPlayerHoldingClub(Player player)
		{
			Item item;
			while (item == null)
			{
			}
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x0026F770 File Offset: 0x0026D970
		public static GolfHelper.ShotStrength CalculateShotStrength(Projectile golfHelper, Entity golfBall)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			int screenHeight2 = Main.screenHeight;
			Vector2 center = golfHelper.Center;
			if (num == 0)
			{
			}
			if (17302 == 0)
			{
			}
			GolfHelper.ShotStrength shotStrength;
			return shotStrength;
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x0026F7C4 File Offset: 0x0026D9C4
		public static GolfHelper.ClubProperties GetClubPropertiesFromGolfHelper(Projectile golfHelper)
		{
			/*
An exception occurred when decompiling this method (06004BB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Golf.GolfHelper/ClubProperties Terraria.GameContent.Golf.GolfHelper::GetClubPropertiesFromGolfHelper(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:ClubProperties(var_2_0E, call:ClubProperties(GolfHelper::GetClubProperties, ldfld:int32[exp:int16](Item::type, ldloc:Item(var_1))))
	stfld:float32(ClubProperties::RoughLandResistance, ldloc:ClubProperties[exp:valuetype Terraria.GameContent.Golf.GolfHelper/ClubProperties&](var_0), ldloc:Item[exp:float32](var_1))
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

		// Token: 0x06004BB1 RID: 19377 RVA: 0x0026F7E8 File Offset: 0x0026D9E8
		public static GolfHelper.ClubProperties GetClubProperties(short itemId)
		{
			/*
An exception occurred when decompiling this method (06004BB1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Golf.GolfHelper/ClubProperties Terraria.GameContent.Golf.GolfHelper::GetClubProperties(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int32(var_2_11, ldc.i4:int32(16256))
	stfld:float32(ClubProperties::RoughLandResistance, ldloc:ClubProperties[exp:valuetype Terraria.GameContent.Golf.GolfHelper/ClubProperties&](var_0), ldloc:int32[exp:float32](var_2_11))
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

		// Token: 0x06004BB2 RID: 19378 RVA: 0x0026F810 File Offset: 0x0026DA10
		public static Projectile FindHelperFromGolfBall(Projectile golfBall)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0026F828 File Offset: 0x0026DA28
		public static Projectile FindGolfBallForHelper(Projectile golfHelper)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x0026F844 File Offset: 0x0026DA44
		public static bool IsGolfBallResting(Projectile golfBall)
		{
			while (32640 == 0)
			{
			}
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x0026F860 File Offset: 0x0026DA60
		public static bool IsGolfShotValid(Entity golfBall, Player player)
		{
			/*
An exception occurred when decompiling this method (06004BB5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Golf.GolfHelper::IsGolfShotValid(Terraria.Entity,Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_4_12, ldfld:int32(Entity::direction, ldloc:Entity(golfBall)))
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

		// Token: 0x06004BB6 RID: 19382 RVA: 0x0026F884 File Offset: 0x0026DA84
		public static bool ValidateShot(Entity golfBall, Player player, Vector2 shotVector)
		{
			/*
An exception occurred when decompiling this method (06004BB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Golf.GolfHelper::ValidateShot(Terraria.Entity,Terraria.Player,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001F:
	stloc:int32(var_11_28, ldfld:int32(Entity::direction, ldloc:Entity(golfBall)))
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

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0026F8C0 File Offset: 0x0026DAC0
		public static void HitGolfBall(Entity entity, Vector2 velocity, float roughLandResistance)
		{
			int num = 1;
			Vector2 bottom = entity.Bottom;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			ushort num2;
			TileMaterial byTileId = TileMaterials.GetByTileId(num2);
			float <ClubImpactDampening>k__BackingField = byTileId.<GolfPhysics>k__BackingField.<ClubImpactDampening>k__BackingField;
			TileGolfPhysics <GolfPhysics>k__BackingField = byTileId.<GolfPhysics>k__BackingField;
			float <ImpactDampeningResistanceEfficiency>k__BackingField = <GolfPhysics>k__BackingField.<ImpactDampeningResistanceEfficiency>k__BackingField;
			if (entity != null)
			{
				if (18000 == 0)
				{
				}
				GolfState localGolfState = Main.LocalGolfState;
			}
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0026F93C File Offset: 0x0026DB3C
		public static void DrawPredictionLine(Entity golfBall, Vector2 impactVelocity, float chargeProgress, float roughLandResistance)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Camera camera = Main.Camera;
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x0026F958 File Offset: 0x0026DB58
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		public static void UpdateDebugDraw(Vector2 position)
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x0026F968 File Offset: 0x0026DB68
		// Note: this type is marked as 'beforefieldinit'.
		static GolfHelper()
		{
		}

		// Token: 0x040085F9 RID: 34297
		private static FancyGolfPredictionLine _predictionLine;

		// Token: 0x040085FA RID: 34298
		public const int PointsNeededForLevel1 = 500;

		// Token: 0x040085FB RID: 34299
		public const int PointsNeededForLevel2 = 1000;

		// Token: 0x040085FC RID: 34300
		public const int PointsNeededForLevel3 = 2000;

		// Token: 0x040085FD RID: 34301
		public static readonly PhysicsProperties PhysicsProperties;

		// Token: 0x040085FE RID: 34302
		public static readonly GolfHelper.ContactListener Listener;

		// Token: 0x02000A04 RID: 2564
		public struct ClubProperties
		{
			// Token: 0x06004BBB RID: 19387 RVA: 0x0026F978 File Offset: 0x0026DB78
			public ClubProperties(Vector2 minimumStrength, Vector2 maximumStrength, float roughLandResistance)
			{
			}

			// Token: 0x040085FF RID: 34303
			public readonly Vector2 MinimumStrength;

			// Token: 0x04008600 RID: 34304
			public readonly Vector2 MaximumStrength;

			// Token: 0x04008601 RID: 34305
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000A05 RID: 2565
		public struct ShotStrength
		{
			// Token: 0x06004BBC RID: 19388 RVA: 0x0026F988 File Offset: 0x0026DB88
			public ShotStrength(float absoluteStrength, float relativeStrength, float roughLandResistance)
			{
			}

			// Token: 0x04008602 RID: 34306
			public readonly float AbsoluteStrength;

			// Token: 0x04008603 RID: 34307
			public readonly float RelativeStrength;

			// Token: 0x04008604 RID: 34308
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000A06 RID: 2566
		public class ContactListener : IBallContactListener
		{
			// Token: 0x06004BBD RID: 19389 RVA: 0x0026F998 File Offset: 0x0026DB98
			public void OnCollision(PhysicsProperties properties, Vector2 position, Vector2 velocity, BallCollisionEvent collision)
			{
				Tile tile = collision.Tile;
				TileMaterial tileMaterial;
				TileGolfPhysics <GolfPhysics>k__BackingField = tileMaterial.<GolfPhysics>k__BackingField;
				float x = velocity.X;
				float y = velocity.Y;
				float <SideImpactDampening>k__BackingField = <GolfPhysics>k__BackingField.<SideImpactDampening>k__BackingField;
				Vector2 normal = collision.Normal;
				float x2 = velocity.X;
				float y2 = velocity.Y;
				TileGolfPhysics <GolfPhysics>k__BackingField2 = tileMaterial.<GolfPhysics>k__BackingField;
				float <DirectImpactDampening>k__BackingField = <GolfPhysics>k__BackingField2.<DirectImpactDampening>k__BackingField;
				float <SideImpactDampening>k__BackingField2 = <GolfPhysics>k__BackingField2.<SideImpactDampening>k__BackingField;
				velocity.X = x2;
				if (collision.Entity != null)
				{
				}
			}

			// Token: 0x06004BBE RID: 19390 RVA: 0x0026FB78 File Offset: 0x0026DD78
			public void PutBallInCup(Projectile proj, BallCollisionEvent collision)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				bool shouldScoreHole = Main.LocalGolfState.ShouldScoreHole;
				float x = collision.ImpactPoint.X;
				float y = collision.ImpactPoint.Y;
				Vector2 normal = collision.Normal;
				Main.LocalGolfState.SetScoreTime();
				GolfState localGolfState = Main.LocalGolfState;
				GolfState localGolfState2 = Main.LocalGolfState;
				GolfState localGolfState3 = Main.LocalGolfState;
				Main.LocalGolfState.ResetScoreTime();
				bool netClient = Main.NetClient;
			}

			// Token: 0x06004BBF RID: 19391 RVA: 0x0026FC1C File Offset: 0x0026DE1C
			public static void PutBallInCup_TextAndEffects(Point hitLocation, int plr, int numberOfHits, int projid)
			{
				if (numberOfHits == 0)
				{
					return;
				}
				Vector2 vector;
				GolfHelper.ContactListener.EmitGolfballExplosion(vector);
				LocalizedText projectileName = Lang.GetProjectileName(projid);
				string key = projectileName.Key;
				if (projectileName == null)
				{
				}
				NetworkText networkText;
				if (networkText == null || networkText != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x06004BC0 RID: 19392 RVA: 0x0026FC9C File Offset: 0x0026DE9C
			public void OnPassThrough(PhysicsProperties properties, Vector2 position, Vector2 velocity, float angularVelocity, BallPassThroughEvent collision)
			{
				float x = velocity.X;
				float y = velocity.Y;
				if (!true)
				{
				}
			}

			// Token: 0x06004BC1 RID: 19393 RVA: 0x0026FD10 File Offset: 0x0026DF10
			public static void EmitGolfballExplosion_Old(Vector2 Center)
			{
				GolfHelper.ContactListener.EmitGolfballExplosion(Center);
			}

			// Token: 0x06004BC2 RID: 19394 RVA: 0x0026FD24 File Offset: 0x0026DF24
			public static void EmitGolfballExplosion(Vector2 Center)
			{
				if (!true)
				{
				}
				int num = 39322;
				int num2 = 1;
				Dust dust;
				float y = dust.position.Y;
				float x = dust.velocity.X;
				float y2 = dust.velocity.Y;
				dust.fadeIn = (float)num;
				dust.noGravity = num2 != 0;
				dust.position.Y = y;
				dust.velocity.X = y;
				dust.velocity.Y = y2;
				Color color;
				dust.color = color;
				int num3 = 13107;
				int num4 = 127;
				float num5;
				Vector2 vector = num5.ToRotationVector2();
				long num6 = 0L;
				Dust dust2;
				float y3 = dust2.position.Y;
				float x2 = dust2.velocity.X;
				float y4 = dust2.velocity.Y;
				int num7 = 1;
				dust2.fadeIn = (float)num3;
				dust2.scale = (float)num3;
				dust2.noGravity = num7 != 0;
				dust2.position.Y = y3;
				dust2.velocity.Y = y4;
				float scale = dust2.scale;
				dust2.scale = scale;
				if (num7 == 0)
				{
				}
				dust2.velocity.X = scale;
				dust2.velocity.Y = y4;
				dust2.color = num4;
				int num8 = 39322;
				int num9 = 1;
				Vector2 vector2 = ((float)num6).ToRotationVector2();
				Dust dust3;
				float y5 = dust3.position.Y;
				float x3 = dust3.velocity.X;
				float y6 = dust3.velocity.Y;
				dust3.fadeIn = (float)num8;
				dust3.noGravity = num9 != 0;
				dust3.position.Y = y5;
				dust3.velocity.X = y5;
				dust3.velocity.Y = y6;
				Color color2;
				dust3.color = color2;
				int num10 = 16320;
				int num11 = 1;
				float num12;
				Vector2 vector3 = num12.ToRotationVector2();
				Dust dust4;
				float x4 = dust4.velocity.X;
				float y7 = dust4.velocity.Y;
				dust4.fadeIn = (float)num10;
				dust4.noGravity = num11 != 0;
				dust4.velocity.X = x4;
				float x5 = dust4.position.X;
				float y8 = dust4.position.Y;
				dust4.velocity.Y = y7;
				dust4.position.X = x4;
				dust4.position.Y = y7;
				int num13 = 255;
				float num14;
				Color color3 = Main.hslToRgb(num14, num14, num12, (byte)num13);
				dust4.color = color3;
			}

			// Token: 0x06004BC3 RID: 19395 RVA: 0x00270004 File Offset: 0x0026E204
			private static void EmitGolfballExplosion_v1(Vector2 Center)
			{
				if (13107 == 0)
				{
				}
				Vector2 vector = 5.5102E-41f.ToRotationVector2();
				Dust dust;
				float y = dust.velocity.Y;
				float y2 = dust.position.Y;
				dust.fadeIn = 5.5102E-41f;
				dust.noGravity = true;
				dust.velocity.Y = y;
				Color color;
				dust.color = color;
				if (13107 == 0)
				{
				}
				Vector2 vector2 = 5.5102E-41f.ToRotationVector2();
				Dust dust2;
				float y3 = dust2.position.Y;
				float y4 = dust2.velocity.Y;
				dust2.fadeIn = 5.5102E-41f;
				dust2.noGravity = true;
				dust2.velocity.Y = y4;
				Color color2;
				dust2.color = color2;
				Vector2 vector3 = float.Epsilon.ToRotationVector2();
				Dust dust3;
				float x = dust3.velocity.X;
				float y5 = dust3.velocity.Y;
				dust3.fadeIn = (float)16320;
				dust3.noGravity = float.Epsilon != null;
				dust3.velocity.X = x;
				float x2;
				if (16320 == 0)
				{
					x2 = dust3.velocity.X;
				}
				float x3 = dust3.position.X;
				float y6 = dust3.position.Y;
				dust3.velocity.Y = y5;
				dust3.position.X = x2;
				dust3.position.Y = y5;
				if (16320 == 0)
				{
				}
				Color color3;
				dust3.color = color3;
			}

			// Token: 0x06004BC4 RID: 19396 RVA: 0x00270198 File Offset: 0x0026E398
			public ContactListener()
			{
			}
		}
	}
}
