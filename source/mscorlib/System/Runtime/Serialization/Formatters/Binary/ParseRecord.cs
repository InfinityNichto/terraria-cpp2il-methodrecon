using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000423 RID: 1059
	internal sealed class ParseRecord
	{
		// Token: 0x0600211E RID: 8478 RVA: 0x0004B64C File Offset: 0x0004984C
		internal ParseRecord()
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0004B660 File Offset: 0x00049860
		internal void Init()
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0004B670 File Offset: 0x00049870
		// Note: this type is marked as 'beforefieldinit'.
		static ParseRecord()
		{
		}

		// Token: 0x04001184 RID: 4484
		internal static int parseRecordIdCount;

		// Token: 0x04001185 RID: 4485
		internal InternalParseTypeE PRparseTypeEnum;

		// Token: 0x04001186 RID: 4486
		internal InternalObjectTypeE PRobjectTypeEnum;

		// Token: 0x04001187 RID: 4487
		internal InternalArrayTypeE PRarrayTypeEnum;

		// Token: 0x04001188 RID: 4488
		internal InternalMemberTypeE PRmemberTypeEnum;

		// Token: 0x04001189 RID: 4489
		internal InternalMemberValueE PRmemberValueEnum;

		// Token: 0x0400118A RID: 4490
		internal InternalObjectPositionE PRobjectPositionEnum;

		// Token: 0x0400118B RID: 4491
		internal string PRname;

		// Token: 0x0400118C RID: 4492
		internal string PRvalue;

		// Token: 0x0400118D RID: 4493
		internal object PRvarValue;

		// Token: 0x0400118E RID: 4494
		internal string PRkeyDt;

		// Token: 0x0400118F RID: 4495
		internal Type PRdtType;

		// Token: 0x04001190 RID: 4496
		internal InternalPrimitiveTypeE PRdtTypeCode;

		// Token: 0x04001191 RID: 4497
		internal bool PRisEnum;

		// Token: 0x04001192 RID: 4498
		internal long PRobjectId;

		// Token: 0x04001193 RID: 4499
		internal long PRidRef;

		// Token: 0x04001194 RID: 4500
		internal string PRarrayElementTypeString;

		// Token: 0x04001195 RID: 4501
		internal Type PRarrayElementType;

		// Token: 0x04001196 RID: 4502
		internal bool PRisArrayVariant;

		// Token: 0x04001197 RID: 4503
		internal InternalPrimitiveTypeE PRarrayElementTypeCode;

		// Token: 0x04001198 RID: 4504
		internal int PRrank;

		// Token: 0x04001199 RID: 4505
		internal int[] PRlengthA;

		// Token: 0x0400119A RID: 4506
		internal int[] PRpositionA;

		// Token: 0x0400119B RID: 4507
		internal int[] PRlowerBoundA;

		// Token: 0x0400119C RID: 4508
		internal int[] PRupperBoundA;

		// Token: 0x0400119D RID: 4509
		internal int[] PRindexMap;

		// Token: 0x0400119E RID: 4510
		internal int PRmemberIndex;

		// Token: 0x0400119F RID: 4511
		internal int PRlinearlength;

		// Token: 0x040011A0 RID: 4512
		internal int[] PRrectangularMap;

		// Token: 0x040011A1 RID: 4513
		internal bool PRisLowerBound;

		// Token: 0x040011A2 RID: 4514
		internal long PRtopId;

		// Token: 0x040011A3 RID: 4515
		internal long PRheaderId;

		// Token: 0x040011A4 RID: 4516
		internal ReadObjectInfo PRobjectInfo;

		// Token: 0x040011A5 RID: 4517
		internal bool PRisValueTypeFixup;

		// Token: 0x040011A6 RID: 4518
		internal object PRnewObj;

		// Token: 0x040011A7 RID: 4519
		internal object[] PRobjectA;

		// Token: 0x040011A8 RID: 4520
		internal PrimitiveArray PRprimitiveArray;

		// Token: 0x040011A9 RID: 4521
		internal bool PRisRegistered;

		// Token: 0x040011AA RID: 4522
		internal object[] PRmemberData;

		// Token: 0x040011AB RID: 4523
		internal SerializationInfo PRsi;

		// Token: 0x040011AC RID: 4524
		internal int PRnullCount;
	}
}
