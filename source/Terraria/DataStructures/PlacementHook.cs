using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200063B RID: 1595
	public struct PlacementHook
	{
		// Token: 0x06003649 RID: 13897 RVA: 0x002128F8 File Offset: 0x00210AF8
		public PlacementHook(Func<int, int, int, int, int, int, int> hook, int badReturn, int badResponse, bool processedCoordinates)
		{
			this.hook = hook;
			this.badReturn = badReturn;
			this.processedCoordinates = badResponse != 0;
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0021291C File Offset: 0x00210B1C
		public static bool operator ==(PlacementHook first, PlacementHook second)
		{
			int num = first.badResponse;
			int num2 = first.badReturn;
			bool flag = first.processedCoordinates;
			bool flag2;
			return flag2;
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00212944 File Offset: 0x00210B44
		public static bool operator !=(PlacementHook first, PlacementHook second)
		{
			int num = first.badResponse;
			int num2 = first.badReturn;
			bool flag = first.processedCoordinates;
			bool flag2;
			return flag2;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0021296C File Offset: 0x00210B6C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			int num = this.badReturn;
			bool flag = this.processedCoordinates;
			bool flag2 = this.processedCoordinates;
			throw new InvalidCastException();
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0021299C File Offset: 0x00210B9C
		public override int GetHashCode()
		{
			bool flag = this.processedCoordinates;
			int num;
			return num;
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x002129B4 File Offset: 0x00210BB4
		// Note: this type is marked as 'beforefieldinit'.
		static PlacementHook()
		{
		}

		// Token: 0x04007701 RID: 30465
		public Func<int, int, int, int, int, int, int> hook;

		// Token: 0x04007702 RID: 30466
		public int badReturn;

		// Token: 0x04007703 RID: 30467
		public int badResponse;

		// Token: 0x04007704 RID: 30468
		public bool processedCoordinates;

		// Token: 0x04007705 RID: 30469
		public static PlacementHook Empty;

		// Token: 0x04007706 RID: 30470
		public const int Response_AllInvalid = 0;
	}
}
