using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO
{
	// Token: 0x02000577 RID: 1399
	public class WorldFile_OldMobile
	{
		// Token: 0x060033F4 RID: 13300 RVA: 0x0020122C File Offset: 0x001FF42C
		public bool LoadSaveData(byte[] srcData)
		{
			if (!true)
			{
			}
			int num;
			this.saveRelease = num;
			long num2 = 0L;
			int num3 = 3;
			if (num2 == 0L)
			{
				long num4 = 0L;
				long num5;
				if (num3 == 0)
				{
					num5 = 0L;
				}
				if (num4 != 0L || num5 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000021DB File Offset: 0x000003DB
		private int loadWorldHeader(BinaryReader fileIO)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00201284 File Offset: 0x001FF484
		private static void DecryptWorldData(long offset, long encryptedSize)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x0020129C File Offset: 0x001FF49C
		private void BadMarker(BinaryReader reader, string marker)
		{
			if (!true)
			{
			}
			byte[] bytes = BitConverter.GetBytes(5678);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x002012EC File Offset: 0x001FF4EC
		private void loadWorldData(BinaryReader reader, int release)
		{
			this.worldTimestamp = reader;
			Guid guid = Guid.NewGuid();
			Main.GameMode = 0;
			WorldGen.clearWorld();
			Main.spawnTileY = Main.spawnTileY;
			if (reader == null)
			{
			}
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00201394 File Offset: 0x001FF594
		public static byte[] ReadAllBytes(Stream stream)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x002013C0 File Offset: 0x001FF5C0
		public static WorldFileData GetAllMetadata(string file, bool cloudSave)
		{
			DateTime now = DateTime.Now;
			long num = 0L;
			int num2 = 8;
			if (num != 0L || num2 != 0)
			{
				throw new OutOfMemoryException();
			}
			if (!false)
			{
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000021DB File Offset: 0x000003DB
		private static int loadWorldHeaderMeta(WorldFileData data, BinaryReader fileIO)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00201434 File Offset: 0x001FF634
		private static void loadWorldDataMeta(WorldFileData data, BinaryReader reader, int release)
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00201444 File Offset: 0x001FF644
		public WorldFile_OldMobile()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00201458 File Offset: 0x001FF658
		// Note: this type is marked as 'beforefieldinit'.
		static WorldFile_OldMobile()
		{
		}

		// Token: 0x04003E3A RID: 15930
		public const int VERSION_49 = 49;

		// Token: 0x04003E3B RID: 15931
		public const int VERSION_50 = 50;

		// Token: 0x04003E3C RID: 15932
		public const int VERSION_51 = 51;

		// Token: 0x04003E3D RID: 15933
		public const int VERSION_52 = 52;

		// Token: 0x04003E3E RID: 15934
		public const int VERSION_53 = 53;

		// Token: 0x04003E3F RID: 15935
		public const int VERSION_54 = 54;

		// Token: 0x04003E40 RID: 15936
		public const int VERSION_55 = 55;

		// Token: 0x04003E41 RID: 15937
		public const int VERSION_56 = 56;

		// Token: 0x04003E42 RID: 15938
		public const int VERSION_57 = 57;

		// Token: 0x04003E43 RID: 15939
		public const int VERSION_58 = 58;

		// Token: 0x04003E44 RID: 15940
		public const int VERSION_59 = 59;

		// Token: 0x04003E45 RID: 15941
		public const int VERSION_60 = 60;

		// Token: 0x04003E46 RID: 15942
		public const int VERSION_61 = 61;

		// Token: 0x04003E47 RID: 15943
		public const int VERSION_62 = 62;

		// Token: 0x04003E48 RID: 15944
		public const int VERSION_63 = 63;

		// Token: 0x04003E49 RID: 15945
		public const int VERSION_64 = 64;

		// Token: 0x04003E4A RID: 15946
		public const int VERSION_65 = 65;

		// Token: 0x04003E4B RID: 15947
		public const int VERSION_66 = 66;

		// Token: 0x04003E4C RID: 15948
		public const int VERSION_67 = 67;

		// Token: 0x04003E4D RID: 15949
		public const int VERSION_68 = 68;

		// Token: 0x04003E4E RID: 15950
		public const int VERSION_69 = 69;

		// Token: 0x04003E4F RID: 15951
		public const int VERSION_70 = 70;

		// Token: 0x04003E50 RID: 15952
		public const int VERSION_71 = 71;

		// Token: 0x04003E51 RID: 15953
		public const int VERSION_72 = 72;

		// Token: 0x04003E52 RID: 15954
		public const int VERSION_73 = 73;

		// Token: 0x04003E53 RID: 15955
		public const int VERSION_CURRENT = 73;

		// Token: 0x04003E54 RID: 15956
		public const int NEW_WORLD_DATA_VERSION = 73;

		// Token: 0x04003E55 RID: 15957
		private bool isCloudSave;

		// Token: 0x04003E56 RID: 15958
		private int worldID;

		// Token: 0x04003E57 RID: 15959
		private int worldTimestamp;

		// Token: 0x04003E58 RID: 15960
		private int hellLayer;

		// Token: 0x04003E59 RID: 15961
		private static Weather_OldMobile weather;

		// Token: 0x04003E5A RID: 15962
		private static NPCInfo_OldMobile npcInfo;

		// Token: 0x04003E5B RID: 15963
		private static TimeInfo_OldMobile tempTime;

		// Token: 0x04003E5C RID: 15964
		private static FishingInfo_OldMobile fishingInfo;

		// Token: 0x04003E5D RID: 15965
		private static RandomStyleInfo_OldMobile tree;

		// Token: 0x04003E5E RID: 15966
		private static RandomStyleInfo_OldMobile caveBack;

		// Token: 0x04003E5F RID: 15967
		private static TilInfo_OldMobile tileInfo;

		// Token: 0x04003E60 RID: 15968
		private static ChestInfo_OldMobile chestInfo;

		// Token: 0x04003E61 RID: 15969
		private static SignInfo_OldMobile signInfo;

		// Token: 0x04003E62 RID: 15970
		private static BlowFish worldDecrypter;

		// Token: 0x04003E63 RID: 15971
		private static byte[] inputData;

		// Token: 0x04003E64 RID: 15972
		private int saveRelease;

		// Token: 0x04003E65 RID: 15973
		private uint timestamp;

		// Token: 0x04003E66 RID: 15974
		private List<uint> timestamps;
	}
}
