using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.NetModules;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Terraria.Net;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x020009E5 RID: 2533
	public class ParticleOrchestrator
	{
		// Token: 0x06004A9B RID: 19099 RVA: 0x00266AB4 File Offset: 0x00264CB4
		public static void RequestParticleSpawn(bool clientOnly, ParticleOrchestraType type, ParticleOrchestraSettings settings, [Optional] int? overrideInvokingPlayerIndex)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			settings.IndexOfPlayerWhoInvokedThis = (byte)myPlayer;
			settings.IndexOfPlayerWhoInvokedThis = (byte)myPlayer;
			int uniqueInfoPiece = settings.UniqueInfoPiece;
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00266AEC File Offset: 0x00264CEC
		public static void BroadcastParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			settings.IndexOfPlayerWhoInvokedThis = (byte)myPlayer;
			if (!true)
			{
			}
			int uniqueInfoPiece = settings.UniqueInfoPiece;
			NetPacket netPacket = NetParticlesModule.Serialize(type, settings);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00266B20 File Offset: 0x00264D20
		public static void BroadcastOrRequestParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			settings.IndexOfPlayerWhoInvokedThis = (byte)myPlayer;
			int uniqueInfoPiece = settings.UniqueInfoPiece;
			NetPacket netPacket = NetParticlesModule.Serialize(type, settings);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x000021DB File Offset: 0x000003DB
		private static FadingParticle GetNewFadingParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x000021DB File Offset: 0x000003DB
		private static LittleFlyingCritterParticle GetNewPooFlyParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000021DB File Offset: 0x000003DB
		private static ItemTransferParticle GetNewItemTransferParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000021DB File Offset: 0x000003DB
		private static FlameParticle GetNewFlameParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000021DB File Offset: 0x000003DB
		private static RandomizedFrameParticle GetNewRandomizedFrameParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000021DB File Offset: 0x000003DB
		private static PrettySparkleParticle GetNewPrettySparkleParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x000021DB File Offset: 0x000003DB
		private static GasParticle GetNewGasParticle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00266B58 File Offset: 0x00264D58
		public static void SpawnParticlesDirect(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00266C90 File Offset: 0x00264E90
		private static void Spawn_ShimmerTownNPCSend(ParticleOrchestraSettings settings)
		{
			Vector2 positionInWorld = settings.PositionInWorld;
			if (17008 == 0)
			{
			}
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00266CB8 File Offset: 0x00264EB8
		private static void Spawn_ShimmerTownNPC(ParticleOrchestraSettings settings)
		{
			Vector2 positionInWorld = settings.PositionInWorld;
			if (17008 == 0)
			{
			}
			int num = 13107;
			Rectangle rectangle;
			Vector2 vector = rectangle.TopLeft();
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				return;
			}
			int value = num.m_value;
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00266D54 File Offset: 0x00264F54
		private static void Spawn_PooFly(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (16968 == 0)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			if (16968 == 0)
			{
			}
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00266D80 File Offset: 0x00264F80
		private static void Spawn_Digestion(ParticleOrchestraSettings settings)
		{
			int num = 1;
			float x = settings.MovementVector.X;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00266DE8 File Offset: 0x00264FE8
		private static void Spawn_ShimmerBlock(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			Vector2 positionInWorld = settings.PositionInWorld;
			float x2 = settings.MovementVector.X;
			float y2 = settings.MovementVector.Y;
			if (16948 == 0)
			{
			}
			if (16948 == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00266E48 File Offset: 0x00265048
		private static void Spawn_LoadOutChange(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			byte indexOfPlayerWhoInvokedThis = settings.IndexOfPlayerWhoInvokedThis;
			byte indexOfPlayerWhoInvokedThis2 = settings.IndexOfPlayerWhoInvokedThis;
			if (indexOfPlayerWhoInvokedThis2 != 0)
			{
				int num = 1;
				if (indexOfPlayerWhoInvokedThis2 == 0)
				{
				}
				Dust dust;
				dust.noGravity = num != 0;
				float num2;
				dust.noLight = num2 != null;
				int num3 = 1;
				int num4 = 257;
				int num5 = 255;
				float num6;
				Color color = Main.hslToRgb(num6, num2, num2, (byte)num5);
				Dust dust2;
				dust2.noGravity = num3 != 0;
				dust2.noLight = num4 != 0;
			}
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00266ED4 File Offset: 0x002650D4
		private static void Spawn_TownSlimeTransform(ParticleOrchestraSettings settings)
		{
			if (settings.UniqueInfoPiece == 0)
			{
				int uniqueInfoPiece = settings.UniqueInfoPiece;
				return;
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00266F00 File Offset: 0x00265100
		private static void ElderSlimeEffect(ParticleOrchestraSettings settings)
		{
			Vector2 positionInWorld = settings.PositionInWorld;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			int num = 16320;
			Dust dust;
			float y2 = dust.velocity.Y;
			dust.fadeIn = (float)num;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				float y3 = dust.velocity.Y;
				dust.velocity.Y = y3;
			}
			int num3 = 1;
			dust.noGravity = num3 != 0;
			Vector2 positionInWorld2 = settings.PositionInWorld;
			if (num3 == 0)
			{
			}
			Gore gore;
			float x2 = gore.velocity.X;
			float y4 = gore.velocity.Y;
			gore.velocity.X = x2;
			gore.velocity.Y = y4;
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00266FE4 File Offset: 0x002651E4
		private static void NerdySlimeEffect(ParticleOrchestraSettings settings)
		{
			Vector2 positionInWorld = settings.PositionInWorld;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0026701C File Offset: 0x0026521C
		private static void CopperSlimeEffect(ParticleOrchestraSettings settings)
		{
			Vector2 positionInWorld = settings.PositionInWorld;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			Dust dust;
			float y2 = dust.velocity.Y;
			dust.fadeIn = (float)16320;
			int num;
			if (num == 0)
			{
				float y3 = dust.velocity.Y;
				dust.velocity.Y = y3;
			}
			dust.noGravity = true;
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00267098 File Offset: 0x00265298
		private static void Spawn_ShimmerArrow(ParticleOrchestraSettings settings)
		{
			float num;
			Vector2 vector = num.ToRotationVector2();
			int num2 = 16800;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Vector2 vector2 = num.ToRotationVector2();
			int num3 = 16800;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				return;
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			if (num3 == 0)
			{
			}
			int num4 = 13107;
			int num5 = 39322;
			int num6 = 1;
			Dust dust;
			dust.noGravity = num6 != 0;
			dust.scale = (float)num4;
			dust.fadeIn = (float)num5;
			dust.color.R = (byte)num;
			Vector2 positionInWorld2 = settings.PositionInWorld;
			Dust dust2;
			dust2.noGravity = num6 != 0;
			dust2.scale = (float)num4;
			dust2.fadeIn = (float)num5;
			dust2.color.R = (byte)num;
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x002671A8 File Offset: 0x002653A8
		private static void Spawn_ItemTransfer(ParticleOrchestraSettings settings)
		{
			int num = 1;
			Vector2 positionInWorld = settings.PositionInWorld;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 16896;
			Vector2 positionInWorld2 = settings.PositionInWorld;
			int uniqueInfoPiece = settings.UniqueInfoPiece;
			if (num2 == 0)
			{
			}
			if ("AnyAtomicType" == null)
			{
			}
			if ("AnyAtomicType" == null)
			{
			}
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00267220 File Offset: 0x00265420
		private static void Spawn_PetExchange(ParticleOrchestraSettings settings)
		{
			Gore gore;
			gore.alpha = 100;
			float num;
			Vector2 vector = num.ToRotationVector2();
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			gore.velocity.X = x;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00267278 File Offset: 0x00265478
		private static void Spawn_TerraBlade(ParticleOrchestraSettings settings)
		{
			int num = 1;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			if (num == 0)
			{
			}
			float num2;
			Vector2 vector = num2.ToRotationVector2();
			Vector2 vector2 = num2.ToRotationVector2();
			Vector2 vector3 = num2.ToRotationVector2();
			Vector2 vector4 = num2.ToRotationVector2();
			int num3 = 16880;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			if (num3 == 0)
			{
			}
			int num4 = 52429;
			int num5 = 1;
			Dust dust;
			dust.noGravity = num5 != 0;
			dust.scale = (float)num4;
			Vector2 positionInWorld2 = settings.PositionInWorld;
			int num6 = 13107;
			Dust dust2;
			dust2.noGravity = num5 != 0;
			dust2.scale = (float)num6;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x00267390 File Offset: 0x00265590
		private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
		{
			Vector2 vector = 3.689349E+19f.ToRotationVector2();
			int num = 13107;
			float num2;
			Vector2 vector2 = num2.ToRotationVector2();
			int num3 = 16880;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			if (num3 == 0)
			{
			}
			int num4 = 1;
			Dust dust;
			dust.noGravity = num4 != 0;
			dust.scale = (float)num;
			Vector2 positionInWorld2 = settings.PositionInWorld;
			Dust dust2;
			dust2.noGravity = num4 != 0;
			dust2.scale = (float)num;
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00267458 File Offset: 0x00265658
		private static void Spawn_SlapHand(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00267470 File Offset: 0x00265670
		private static void Spawn_WaffleIron(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00267488 File Offset: 0x00265688
		private static void Spawn_FlyMeal(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x002674A0 File Offset: 0x002656A0
		private static void Spawn_GasTrap(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			Vector2 positionInWorld2 = settings.PositionInWorld;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x002674FC File Offset: 0x002656FC
		private static void Spawn_TrueExcalibur(ParticleOrchestraSettings settings)
		{
			Vector2 vector = -0f.ToRotationVector2();
			int num = 13107;
			int num2 = 1;
			float num3;
			Vector2 vector2 = num3.ToRotationVector2();
			int num4 = 16912;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 != 0)
			{
				Vector2 positionInWorld = settings.PositionInWorld;
				if (num4 == 0)
				{
				}
				Dust dust;
				dust.noGravity = num2 != 0;
				dust.scale = (float)num;
				Vector2 positionInWorld2 = settings.PositionInWorld;
				Dust dust2;
				dust2.noGravity = num2 != 0;
				dust2.scale = (float)num;
			}
			Vector2 vector3 = 3.689349E+19f.ToRotationVector2();
			int num6 = 1;
			Vector2 vector4 = -0f.ToRotationVector2();
			int num7 = 16880;
			if (num7 == 0)
			{
			}
			if (num7 == 0)
			{
			}
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 != 0)
			{
				Vector2 positionInWorld3 = settings.PositionInWorld;
				if (num7 == 0)
				{
				}
				int num9 = 13107;
				Dust dust3;
				dust3.noGravity = num6 != 0;
				dust3.scale = (float)num9;
				Vector2 positionInWorld4 = settings.PositionInWorld;
				Dust dust4;
				dust4.scale = (float)num9;
				dust4.noGravity = num6 != 0;
			}
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00267680 File Offset: 0x00265880
		private static void Spawn_AshTreeShake(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			Vector2 vector = -0f.ToRotationVector2();
			int num = 13107;
			int num2 = 1;
			Vector2 vector2 = -0f.ToRotationVector2();
			Dust dust;
			dust.noGravity = num2 != 0;
			dust.scale = (float)num;
			Dust dust2;
			dust2.noGravity = num2 != 0;
			dust2.scale = (float)num;
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x0026774C File Offset: 0x0026594C
		private static void Spawn_LeafCrystalPassive(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			int num = 1;
			Vector2 vector = ((float)num).ToRotationVector2();
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x0026777C File Offset: 0x0026597C
		private static void Spawn_LeafCrystalShot(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			int uniqueInfoPiece = settings.UniqueInfoPiece;
			Vector2 movementVector = settings.MovementVector;
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x002677BC File Offset: 0x002659BC
		private static void Spawn_TrueNightsEdge(ParticleOrchestraSettings settings)
		{
			long num = 0L;
			Vector2 vector = 3.689349E+19f.ToRotationVector2();
			while (num == 0L)
			{
			}
			Vector2 vector2 = 3.689349E+19f.ToRotationVector2();
			if (16880 == 0)
			{
			}
			Vector2 positionInWorld = settings.PositionInWorld;
			if (16880 == 0)
			{
			}
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00267864 File Offset: 0x00265A64
		private static void Spawn_NightsEdge(ParticleOrchestraSettings settings)
		{
			Vector2 vector = 3.689349E+19f.ToRotationVector2();
			Vector2 vector2 = 3.689349E+19f.ToRotationVector2();
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x002678DC File Offset: 0x00265ADC
		private static void Spawn_SilverBulletSparkle(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			Vector2 positionInWorld = settings.PositionInWorld;
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x0026791C File Offset: 0x00265B1C
		private static void Spawn_PaladinsHammer(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			float num;
			Vector2 vector = num.ToRotationVector2();
			Vector2 positionInWorld = settings.PositionInWorld;
			Vector2 vector2 = num.ToRotationVector2();
			Vector2 positionInWorld2 = settings.PositionInWorld;
			Vector2 positionInWorld3 = settings.PositionInWorld;
			float x2 = settings.MovementVector.X;
			float y2 = settings.MovementVector.Y;
			Vector2 movementVector = settings.MovementVector;
			int num2;
			Dust dust = Dust.CloneDust(num2);
			float fadeIn = dust.fadeIn;
			dust.fadeIn = fadeIn;
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00267A44 File Offset: 0x00265C44
		private static void Spawn_PrincessWeapon(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			float num;
			Vector2 vector = num.ToRotationVector2();
			Vector2 vector2 = num.ToRotationVector2();
			int num2 = 255;
			float num3;
			float num4;
			Color color = Main.hslToRgb(num3, num, num4, (byte)num2);
			Vector2 positionInWorld = settings.PositionInWorld;
			Vector2 vector3 = num3.ToRotationVector2();
			Vector2 vector4 = num3.ToRotationVector2();
			Vector2 positionInWorld2 = settings.PositionInWorld;
			int num5 = 255;
			float num6;
			Color color2 = Main.hslToRgb(num6, num, num4, (byte)num5);
			Vector2 positionInWorld3 = settings.PositionInWorld;
			float x2 = settings.MovementVector.X;
			float y2 = settings.MovementVector.Y;
			Vector2 movementVector = settings.MovementVector;
			Dust dust;
			float scale = dust.scale;
			float fadeIn = dust.fadeIn;
			dust.scale = scale;
			dust.fadeIn = fadeIn;
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00267BD4 File Offset: 0x00265DD4
		private static void Spawn_StardustPunch(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			float num;
			Vector2 vector = num.ToRotationVector2();
			Vector2 vector2 = num.ToRotationVector2();
			int num2 = 255;
			float num3;
			float num4;
			Color color = Main.hslToRgb(num3, num, num4, (byte)num2);
			Vector2 positionInWorld = settings.PositionInWorld;
			float num5;
			Vector2 vector3 = num5.ToRotationVector2();
			Vector2 vector4 = num5.ToRotationVector2();
			Vector2 positionInWorld2 = settings.PositionInWorld;
			int num6 = 255;
			float num7;
			float num8;
			Color color2 = Main.hslToRgb(num7, num8, num4, (byte)num6);
			Vector2 positionInWorld3 = settings.PositionInWorld;
			float x2 = settings.MovementVector.X;
			float y2 = settings.MovementVector.Y;
			Dust dust;
			float scale = dust.scale;
			dust.scale = scale;
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00267D2C File Offset: 0x00265F2C
		private static void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float x = settings.MovementVector.X;
			float y = settings.MovementVector.Y;
			float num;
			Vector2 vector = num.ToRotationVector2();
			Vector2 vector2 = num.ToRotationVector2();
			int num2 = 255;
			float num3;
			float num4;
			Color color = Main.hslToRgb(num3, num, num4, (byte)num2);
			Vector2 positionInWorld = settings.PositionInWorld;
			Vector2 vector3 = num3.ToRotationVector2();
			Vector2 vector4 = num3.ToRotationVector2();
			Vector2 positionInWorld2 = settings.PositionInWorld;
			int num5 = 255;
			float num6;
			Color color2 = Main.hslToRgb(num6, num, num4, (byte)num5);
			Vector2 positionInWorld3 = settings.PositionInWorld;
			float x2 = settings.MovementVector.X;
			float y2 = settings.MovementVector.Y;
			Dust dust;
			float scale = dust.scale;
			float fadeIn = dust.fadeIn;
			dust.scale = scale;
			dust.fadeIn = fadeIn;
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00267E8C File Offset: 0x0026608C
		private static void Spawn_BlackLightningSmall(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00267EF8 File Offset: 0x002660F8
		private static void Spawn_BlackLightningHit(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00267F38 File Offset: 0x00266138
		private static void Spawn_StellarTune(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
			}
			float num2;
			Vector2 vector = num2.ToRotationVector2();
			Vector2 vector2 = num2.ToRotationVector2();
			Vector2 positionInWorld = settings.PositionInWorld;
			if (17008 == 0)
			{
			}
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00267F88 File Offset: 0x00266188
		private static void Spawn_Keybrand(ParticleOrchestraSettings settings)
		{
			if (!true)
			{
			}
			float num;
			Vector2 vector = num.ToRotationVector2();
			Vector2 vector2 = num.ToRotationVector2();
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00268044 File Offset: 0x00266244
		private static void Spawn_FlameWaders(ParticleOrchestraSettings settings)
		{
			int num = 1;
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
			byte indexOfPlayerWhoInvokedThis = settings.IndexOfPlayerWhoInvokedThis;
			Vector2 positionInWorld = settings.PositionInWorld;
			byte indexOfPlayerWhoInvokedThis2 = settings.IndexOfPlayerWhoInvokedThis;
			int num2;
			if (num2 == 0)
			{
				if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
				{
				}
				int num3;
				Dust dust;
				if (num3 != 0)
				{
					int num4 = 39322;
					dust.scale = (float)num4;
					return;
				}
				int num5 = 13107;
				dust.noGravity = num != 0;
				dust.fadeIn = (float)num5;
				float x = dust.velocity.X;
				float y = dust.velocity.Y;
				dust.noLight = num != 0;
				float y2 = dust.position.Y;
				ArmorShaderData armorShaderData;
				dust.shader = armorShaderData;
			}
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0026810C File Offset: 0x0026630C
		private static void Spawn_WallOfFleshGoatMountFlames(ParticleOrchestraSettings settings)
		{
			int num = 1;
			byte indexOfPlayerWhoInvokedThis = settings.IndexOfPlayerWhoInvokedThis;
			Vector2 positionInWorld = settings.PositionInWorld;
			byte indexOfPlayerWhoInvokedThis2 = settings.IndexOfPlayerWhoInvokedThis;
			int num2;
			if (num2 == 0)
			{
				int num3;
				Dust dust;
				if (num3 != 0)
				{
					int num4 = 39322;
					dust.scale = (float)num4;
					return;
				}
				int num5 = 13107;
				dust.noGravity = num != 0;
				dust.fadeIn = (float)num5;
				float x = dust.velocity.X;
				float y = dust.velocity.Y;
				if (num5 == 0)
				{
				}
				dust.noLight = num != 0;
				float y2 = dust.position.Y;
				if (num5 == 0)
				{
				}
				ArmorShaderData armorShaderData;
				dust.shader = armorShaderData;
			}
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x002681D0 File Offset: 0x002663D0
		public ParticleOrchestrator()
		{
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x002681E4 File Offset: 0x002663E4
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleOrchestrator()
		{
		}

		// Token: 0x04008524 RID: 34084
		private static ParticlePool<FadingParticle> _poolFading;

		// Token: 0x04008525 RID: 34085
		private static ParticlePool<FlameParticle> _poolFlame;

		// Token: 0x04008526 RID: 34086
		private static ParticlePool<RandomizedFrameParticle> _poolRandomizedFrame;

		// Token: 0x04008527 RID: 34087
		private static ParticlePool<PrettySparkleParticle> _poolPrettySparkle;

		// Token: 0x04008528 RID: 34088
		private static ParticlePool<ItemTransferParticle> _poolItemTransfer;

		// Token: 0x04008529 RID: 34089
		private static ParticlePool<LittleFlyingCritterParticle> _poolFlies;

		// Token: 0x0400852A RID: 34090
		private static ParticlePool<GasParticle> _poolGas;
	}
}
