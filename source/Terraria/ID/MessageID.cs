using System;
using Terraria.Utilities;

namespace Terraria.ID
{
	// Token: 0x020005DA RID: 1498
	public class MessageID
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x0020E460 File Offset: 0x0020C660
		public MessageID()
		{
		}

		// Token: 0x0400644C RID: 25676
		public const byte NeverCalled = 0;

		// Token: 0x0400644D RID: 25677
		public const byte Hello = 1;

		// Token: 0x0400644E RID: 25678
		public const byte Kick = 2;

		// Token: 0x0400644F RID: 25679
		public const byte PlayerInfo = 3;

		// Token: 0x04006450 RID: 25680
		public const byte SyncPlayer = 4;

		// Token: 0x04006451 RID: 25681
		public const byte SyncEquipment = 5;

		// Token: 0x04006452 RID: 25682
		public const byte RequestWorldData = 6;

		// Token: 0x04006453 RID: 25683
		public const byte WorldData = 7;

		// Token: 0x04006454 RID: 25684
		public const byte SpawnTileData = 8;

		// Token: 0x04006455 RID: 25685
		public const byte StatusTextSize = 9;

		// Token: 0x04006456 RID: 25686
		public const byte TileSection = 10;

		// Token: 0x04006457 RID: 25687
		[Old("Deprecated. Framing happens as needed after TileSection is sent.")]
		public const byte TileFrameSection = 11;

		// Token: 0x04006458 RID: 25688
		public const byte PlayerSpawn = 12;

		// Token: 0x04006459 RID: 25689
		public const byte PlayerControls = 13;

		// Token: 0x0400645A RID: 25690
		public const byte PlayerActive = 14;

		// Token: 0x0400645B RID: 25691
		[Obsolete("Deprecated.")]
		public const byte Unknown15 = 15;

		// Token: 0x0400645C RID: 25692
		public const byte PlayerLifeMana = 16;

		// Token: 0x0400645D RID: 25693
		public const byte TileManipulation = 17;

		// Token: 0x0400645E RID: 25694
		public const byte SetTime = 18;

		// Token: 0x0400645F RID: 25695
		public const byte ToggleDoorState = 19;

		// Token: 0x04006460 RID: 25696
		public const byte Unknown20 = 20;

		// Token: 0x04006461 RID: 25697
		public const byte SyncItem = 21;

		// Token: 0x04006462 RID: 25698
		public const byte ItemOwner = 22;

		// Token: 0x04006463 RID: 25699
		public const byte SyncNPC = 23;

		// Token: 0x04006464 RID: 25700
		public const byte UnusedMeleeStrike = 24;

		// Token: 0x04006465 RID: 25701
		[Obsolete("Deprecated. Use NetTextModule instead.")]
		public const byte Unused25 = 25;

		// Token: 0x04006466 RID: 25702
		[Obsolete("Deprecated.")]
		public const byte Unused26 = 26;

		// Token: 0x04006467 RID: 25703
		public const byte SyncProjectile = 27;

		// Token: 0x04006468 RID: 25704
		public const byte DamageNPC = 28;

		// Token: 0x04006469 RID: 25705
		public const byte KillProjectile = 29;

		// Token: 0x0400646A RID: 25706
		public const byte TogglePVP = 30;

		// Token: 0x0400646B RID: 25707
		public const byte RequestChestOpen = 31;

		// Token: 0x0400646C RID: 25708
		public const byte SyncChestItem = 32;

		// Token: 0x0400646D RID: 25709
		public const byte SyncPlayerChest = 33;

		// Token: 0x0400646E RID: 25710
		public const byte ChestUpdates = 34;

		// Token: 0x0400646F RID: 25711
		public const byte PlayerHeal = 35;

		// Token: 0x04006470 RID: 25712
		public const byte SyncPlayerZone = 36;

		// Token: 0x04006471 RID: 25713
		public const byte RequestPassword = 37;

		// Token: 0x04006472 RID: 25714
		public const byte SendPassword = 38;

		// Token: 0x04006473 RID: 25715
		public const byte ReleaseItemOwnership = 39;

		// Token: 0x04006474 RID: 25716
		public const byte SyncTalkNPC = 40;

		// Token: 0x04006475 RID: 25717
		public const byte ShotAnimationAndSound = 41;

		// Token: 0x04006476 RID: 25718
		public const byte Unknown42 = 42;

		// Token: 0x04006477 RID: 25719
		public const byte Unknown43 = 43;

		// Token: 0x04006478 RID: 25720
		[Obsolete("Deprecated.")]
		public const byte Unknown44 = 44;

		// Token: 0x04006479 RID: 25721
		public const byte Unknown45 = 45;

		// Token: 0x0400647A RID: 25722
		public const byte Unknown46 = 46;

		// Token: 0x0400647B RID: 25723
		public const byte Unknown47 = 47;

		// Token: 0x0400647C RID: 25724
		[Obsolete("Deprecated. Use NetLiquidModule instead.")]
		public const byte LiquidUpdate = 48;

		// Token: 0x0400647D RID: 25725
		public const byte InitialSpawn = 49;

		// Token: 0x0400647E RID: 25726
		public const byte PlayerBuffs = 50;

		// Token: 0x0400647F RID: 25727
		public const byte MiscDataSync = 51;

		// Token: 0x04006480 RID: 25728
		public const byte LockAndUnlock = 52;

		// Token: 0x04006481 RID: 25729
		public const byte AddNPCBuff = 53;

		// Token: 0x04006482 RID: 25730
		public const byte NPCBuffs = 54;

		// Token: 0x04006483 RID: 25731
		public const byte AddPlayerBuff = 55;

		// Token: 0x04006484 RID: 25732
		public const byte UniqueTownNPCInfoSyncRequest = 56;

		// Token: 0x04006485 RID: 25733
		public const byte Unknown57 = 57;

		// Token: 0x04006486 RID: 25734
		public const byte InstrumentSound = 58;

		// Token: 0x04006487 RID: 25735
		public const byte HitSwitch = 59;

		// Token: 0x04006488 RID: 25736
		public const byte Unknown60 = 60;

		// Token: 0x04006489 RID: 25737
		public const byte SpawnBossUseLicenseStartEvent = 61;

		// Token: 0x0400648A RID: 25738
		public const byte Unknown62 = 62;

		// Token: 0x0400648B RID: 25739
		public const byte Unknown63 = 63;

		// Token: 0x0400648C RID: 25740
		public const byte Unknown64 = 64;

		// Token: 0x0400648D RID: 25741
		public const byte TeleportEntity = 65;

		// Token: 0x0400648E RID: 25742
		public const byte Unknown66 = 66;

		// Token: 0x0400648F RID: 25743
		public const byte Unknown67 = 67;

		// Token: 0x04006490 RID: 25744
		public const byte Unknown68 = 68;

		// Token: 0x04006491 RID: 25745
		public const byte ChestName = 69;

		// Token: 0x04006492 RID: 25746
		public const byte BugCatching = 70;

		// Token: 0x04006493 RID: 25747
		public const byte BugReleasing = 71;

		// Token: 0x04006494 RID: 25748
		public const byte TravelMerchantItems = 72;

		// Token: 0x04006495 RID: 25749
		public const byte RequestTeleportationByServer = 73;

		// Token: 0x04006496 RID: 25750
		public const byte AnglerQuest = 74;

		// Token: 0x04006497 RID: 25751
		public const byte AnglerQuestFinished = 75;

		// Token: 0x04006498 RID: 25752
		public const byte QuestsCountSync = 76;

		// Token: 0x04006499 RID: 25753
		public const byte TemporaryAnimation = 77;

		// Token: 0x0400649A RID: 25754
		public const byte InvasionProgressReport = 78;

		// Token: 0x0400649B RID: 25755
		public const byte PlaceObject = 79;

		// Token: 0x0400649C RID: 25756
		public const byte SyncPlayerChestIndex = 80;

		// Token: 0x0400649D RID: 25757
		public const byte CombatTextInt = 81;

		// Token: 0x0400649E RID: 25758
		public const byte NetModules = 82;

		// Token: 0x0400649F RID: 25759
		public const byte NPCKillCountDeathTally = 83;

		// Token: 0x040064A0 RID: 25760
		public const byte PlayerStealth = 84;

		// Token: 0x040064A1 RID: 25761
		public const byte QuickStackChests = 85;

		// Token: 0x040064A2 RID: 25762
		public const byte TileEntitySharing = 86;

		// Token: 0x040064A3 RID: 25763
		public const byte TileEntityPlacement = 87;

		// Token: 0x040064A4 RID: 25764
		public const byte ItemTweaker = 88;

		// Token: 0x040064A5 RID: 25765
		public const byte ItemFrameTryPlacing = 89;

		// Token: 0x040064A6 RID: 25766
		public const byte InstancedItem = 90;

		// Token: 0x040064A7 RID: 25767
		public const byte SyncEmoteBubble = 91;

		// Token: 0x040064A8 RID: 25768
		public const byte SyncExtraValue = 92;

		// Token: 0x040064A9 RID: 25769
		public const byte SocialHandshake = 93;

		// Token: 0x040064AA RID: 25770
		public const byte Deprecated1 = 94;

		// Token: 0x040064AB RID: 25771
		public const byte MurderSomeoneElsesPortal = 95;

		// Token: 0x040064AC RID: 25772
		public const byte TeleportPlayerThroughPortal = 96;

		// Token: 0x040064AD RID: 25773
		public const byte AchievementMessageNPCKilled = 97;

		// Token: 0x040064AE RID: 25774
		public const byte AchievementMessageEventHappened = 98;

		// Token: 0x040064AF RID: 25775
		public const byte MinionRestTargetUpdate = 99;

		// Token: 0x040064B0 RID: 25776
		public const byte TeleportNPCThroughPortal = 100;

		// Token: 0x040064B1 RID: 25777
		public const byte UpdateTowerShieldStrengths = 101;

		// Token: 0x040064B2 RID: 25778
		public const byte NebulaLevelupRequest = 102;

		// Token: 0x040064B3 RID: 25779
		public const byte MoonlordHorror = 103;

		// Token: 0x040064B4 RID: 25780
		public const byte ShopOverride = 104;

		// Token: 0x040064B5 RID: 25781
		public const byte GemLockToggle = 105;

		// Token: 0x040064B6 RID: 25782
		public const byte PoofOfSmoke = 106;

		// Token: 0x040064B7 RID: 25783
		public const byte SmartTextMessage = 107;

		// Token: 0x040064B8 RID: 25784
		public const byte WiredCannonShot = 108;

		// Token: 0x040064B9 RID: 25785
		public const byte MassWireOperation = 109;

		// Token: 0x040064BA RID: 25786
		public const byte MassWireOperationPay = 110;

		// Token: 0x040064BB RID: 25787
		public const byte ToggleParty = 111;

		// Token: 0x040064BC RID: 25788
		public const byte SpecialFX = 112;

		// Token: 0x040064BD RID: 25789
		public const byte CrystalInvasionStart = 113;

		// Token: 0x040064BE RID: 25790
		public const byte CrystalInvasionWipeAllTheThingsss = 114;

		// Token: 0x040064BF RID: 25791
		public const byte MinionAttackTargetUpdate = 115;

		// Token: 0x040064C0 RID: 25792
		public const byte CrystalInvasionSendWaitTime = 116;

		// Token: 0x040064C1 RID: 25793
		public const byte PlayerHurtV2 = 117;

		// Token: 0x040064C2 RID: 25794
		public const byte PlayerDeathV2 = 118;

		// Token: 0x040064C3 RID: 25795
		public const byte CombatTextString = 119;

		// Token: 0x040064C4 RID: 25796
		public const byte Emoji = 120;

		// Token: 0x040064C5 RID: 25797
		public const byte TEDisplayDollItemSync = 121;

		// Token: 0x040064C6 RID: 25798
		public const byte RequestTileEntityInteraction = 122;

		// Token: 0x040064C7 RID: 25799
		public const byte WeaponsRackTryPlacing = 123;

		// Token: 0x040064C8 RID: 25800
		public const byte TEHatRackItemSync = 124;

		// Token: 0x040064C9 RID: 25801
		public const byte SyncTilePicking = 125;

		// Token: 0x040064CA RID: 25802
		public const byte SyncRevengeMarker = 126;

		// Token: 0x040064CB RID: 25803
		public const byte RemoveRevengeMarker = 127;

		// Token: 0x040064CC RID: 25804
		public const byte LandGolfBallInCup = 128;

		// Token: 0x040064CD RID: 25805
		public const byte FinishedConnectingToServer = 129;

		// Token: 0x040064CE RID: 25806
		public const byte FishOutNPC = 130;

		// Token: 0x040064CF RID: 25807
		public const byte TamperWithNPC = 131;

		// Token: 0x040064D0 RID: 25808
		public const byte PlayLegacySound = 132;

		// Token: 0x040064D1 RID: 25809
		public const byte FoodPlatterTryPlacing = 133;

		// Token: 0x040064D2 RID: 25810
		public const byte UpdatePlayerLuckFactors = 134;

		// Token: 0x040064D3 RID: 25811
		public const byte DeadPlayer = 135;

		// Token: 0x040064D4 RID: 25812
		public const byte SyncCavernMonsterType = 136;

		// Token: 0x040064D5 RID: 25813
		public const byte RequestNPCBuffRemoval = 137;

		// Token: 0x040064D6 RID: 25814
		public const byte ClientSyncedInventory = 138;

		// Token: 0x040064D7 RID: 25815
		public const byte SetCountsAsHostForGameplay = 139;

		// Token: 0x040064D8 RID: 25816
		public const byte SetMiscEventValues = 140;

		// Token: 0x040064D9 RID: 25817
		public const byte RequestLucyPopup = 141;

		// Token: 0x040064DA RID: 25818
		public const byte SyncProjectileTrackers = 142;

		// Token: 0x040064DB RID: 25819
		public const byte CrystalInvasionRequestedToSkipWaitTime = 143;

		// Token: 0x040064DC RID: 25820
		public const byte RequestQuestEffect = 144;

		// Token: 0x040064DD RID: 25821
		public const byte SyncItemsWithShimmer = 145;

		// Token: 0x040064DE RID: 25822
		public const byte ShimmerActions = 146;

		// Token: 0x040064DF RID: 25823
		public const byte SyncLoadout = 147;

		// Token: 0x040064E0 RID: 25824
		public const byte SyncItemCannotBeTakenByEnemies = 148;

		// Token: 0x040064E1 RID: 25825
		public const byte ServerInfo = 149;

		// Token: 0x040064E2 RID: 25826
		public const byte PlayerPlatformInfo = 150;

		// Token: 0x040064E3 RID: 25827
		public const byte Count = 151;
	}
}
