using System;
using System.ComponentModel;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200013E RID: 318
	public enum GraphicsFormat
	{
		// Token: 0x0400057A RID: 1402
		None,
		// Token: 0x0400057B RID: 1403
		R8_SRGB,
		// Token: 0x0400057C RID: 1404
		R8G8_SRGB,
		// Token: 0x0400057D RID: 1405
		R8G8B8_SRGB,
		// Token: 0x0400057E RID: 1406
		R8G8B8A8_SRGB,
		// Token: 0x0400057F RID: 1407
		R8_UNorm,
		// Token: 0x04000580 RID: 1408
		R8G8_UNorm,
		// Token: 0x04000581 RID: 1409
		R8G8B8_UNorm,
		// Token: 0x04000582 RID: 1410
		R8G8B8A8_UNorm,
		// Token: 0x04000583 RID: 1411
		R8_SNorm,
		// Token: 0x04000584 RID: 1412
		R8G8_SNorm,
		// Token: 0x04000585 RID: 1413
		R8G8B8_SNorm,
		// Token: 0x04000586 RID: 1414
		R8G8B8A8_SNorm,
		// Token: 0x04000587 RID: 1415
		R8_UInt,
		// Token: 0x04000588 RID: 1416
		R8G8_UInt,
		// Token: 0x04000589 RID: 1417
		R8G8B8_UInt,
		// Token: 0x0400058A RID: 1418
		R8G8B8A8_UInt,
		// Token: 0x0400058B RID: 1419
		R8_SInt,
		// Token: 0x0400058C RID: 1420
		R8G8_SInt,
		// Token: 0x0400058D RID: 1421
		R8G8B8_SInt,
		// Token: 0x0400058E RID: 1422
		R8G8B8A8_SInt,
		// Token: 0x0400058F RID: 1423
		R16_UNorm,
		// Token: 0x04000590 RID: 1424
		R16G16_UNorm,
		// Token: 0x04000591 RID: 1425
		R16G16B16_UNorm,
		// Token: 0x04000592 RID: 1426
		R16G16B16A16_UNorm,
		// Token: 0x04000593 RID: 1427
		R16_SNorm,
		// Token: 0x04000594 RID: 1428
		R16G16_SNorm,
		// Token: 0x04000595 RID: 1429
		R16G16B16_SNorm,
		// Token: 0x04000596 RID: 1430
		R16G16B16A16_SNorm,
		// Token: 0x04000597 RID: 1431
		R16_UInt,
		// Token: 0x04000598 RID: 1432
		R16G16_UInt,
		// Token: 0x04000599 RID: 1433
		R16G16B16_UInt,
		// Token: 0x0400059A RID: 1434
		R16G16B16A16_UInt,
		// Token: 0x0400059B RID: 1435
		R16_SInt,
		// Token: 0x0400059C RID: 1436
		R16G16_SInt,
		// Token: 0x0400059D RID: 1437
		R16G16B16_SInt,
		// Token: 0x0400059E RID: 1438
		R16G16B16A16_SInt,
		// Token: 0x0400059F RID: 1439
		R32_UInt,
		// Token: 0x040005A0 RID: 1440
		R32G32_UInt,
		// Token: 0x040005A1 RID: 1441
		R32G32B32_UInt,
		// Token: 0x040005A2 RID: 1442
		R32G32B32A32_UInt,
		// Token: 0x040005A3 RID: 1443
		R32_SInt,
		// Token: 0x040005A4 RID: 1444
		R32G32_SInt,
		// Token: 0x040005A5 RID: 1445
		R32G32B32_SInt,
		// Token: 0x040005A6 RID: 1446
		R32G32B32A32_SInt,
		// Token: 0x040005A7 RID: 1447
		R16_SFloat,
		// Token: 0x040005A8 RID: 1448
		R16G16_SFloat,
		// Token: 0x040005A9 RID: 1449
		R16G16B16_SFloat,
		// Token: 0x040005AA RID: 1450
		R16G16B16A16_SFloat,
		// Token: 0x040005AB RID: 1451
		R32_SFloat,
		// Token: 0x040005AC RID: 1452
		R32G32_SFloat,
		// Token: 0x040005AD RID: 1453
		R32G32B32_SFloat,
		// Token: 0x040005AE RID: 1454
		R32G32B32A32_SFloat,
		// Token: 0x040005AF RID: 1455
		B8G8R8_SRGB = 56,
		// Token: 0x040005B0 RID: 1456
		B8G8R8A8_SRGB,
		// Token: 0x040005B1 RID: 1457
		B8G8R8_UNorm,
		// Token: 0x040005B2 RID: 1458
		B8G8R8A8_UNorm,
		// Token: 0x040005B3 RID: 1459
		B8G8R8_SNorm,
		// Token: 0x040005B4 RID: 1460
		B8G8R8A8_SNorm,
		// Token: 0x040005B5 RID: 1461
		B8G8R8_UInt,
		// Token: 0x040005B6 RID: 1462
		B8G8R8A8_UInt,
		// Token: 0x040005B7 RID: 1463
		B8G8R8_SInt,
		// Token: 0x040005B8 RID: 1464
		B8G8R8A8_SInt,
		// Token: 0x040005B9 RID: 1465
		R4G4B4A4_UNormPack16,
		// Token: 0x040005BA RID: 1466
		B4G4R4A4_UNormPack16,
		// Token: 0x040005BB RID: 1467
		R5G6B5_UNormPack16,
		// Token: 0x040005BC RID: 1468
		B5G6R5_UNormPack16,
		// Token: 0x040005BD RID: 1469
		R5G5B5A1_UNormPack16,
		// Token: 0x040005BE RID: 1470
		B5G5R5A1_UNormPack16,
		// Token: 0x040005BF RID: 1471
		A1R5G5B5_UNormPack16,
		// Token: 0x040005C0 RID: 1472
		E5B9G9R9_UFloatPack32,
		// Token: 0x040005C1 RID: 1473
		B10G11R11_UFloatPack32,
		// Token: 0x040005C2 RID: 1474
		A2B10G10R10_UNormPack32,
		// Token: 0x040005C3 RID: 1475
		A2B10G10R10_UIntPack32,
		// Token: 0x040005C4 RID: 1476
		A2B10G10R10_SIntPack32,
		// Token: 0x040005C5 RID: 1477
		A2R10G10B10_UNormPack32,
		// Token: 0x040005C6 RID: 1478
		A2R10G10B10_UIntPack32,
		// Token: 0x040005C7 RID: 1479
		A2R10G10B10_SIntPack32,
		// Token: 0x040005C8 RID: 1480
		A2R10G10B10_XRSRGBPack32,
		// Token: 0x040005C9 RID: 1481
		A2R10G10B10_XRUNormPack32,
		// Token: 0x040005CA RID: 1482
		R10G10B10_XRSRGBPack32,
		// Token: 0x040005CB RID: 1483
		R10G10B10_XRUNormPack32,
		// Token: 0x040005CC RID: 1484
		A10R10G10B10_XRSRGBPack32,
		// Token: 0x040005CD RID: 1485
		A10R10G10B10_XRUNormPack32,
		// Token: 0x040005CE RID: 1486
		D16_UNorm = 90,
		// Token: 0x040005CF RID: 1487
		D24_UNorm,
		// Token: 0x040005D0 RID: 1488
		D24_UNorm_S8_UInt,
		// Token: 0x040005D1 RID: 1489
		D32_SFloat,
		// Token: 0x040005D2 RID: 1490
		D32_SFloat_S8_UInt,
		// Token: 0x040005D3 RID: 1491
		S8_UInt,
		// Token: 0x040005D4 RID: 1492
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", true)]
		RGB_DXT1_SRGB,
		// Token: 0x040005D5 RID: 1493
		RGBA_DXT1_SRGB = 96,
		// Token: 0x040005D6 RID: 1494
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		RGB_DXT1_UNorm,
		// Token: 0x040005D7 RID: 1495
		RGBA_DXT1_UNorm = 97,
		// Token: 0x040005D8 RID: 1496
		RGBA_DXT3_SRGB,
		// Token: 0x040005D9 RID: 1497
		RGBA_DXT3_UNorm,
		// Token: 0x040005DA RID: 1498
		RGBA_DXT5_SRGB,
		// Token: 0x040005DB RID: 1499
		RGBA_DXT5_UNorm,
		// Token: 0x040005DC RID: 1500
		R_BC4_UNorm,
		// Token: 0x040005DD RID: 1501
		R_BC4_SNorm,
		// Token: 0x040005DE RID: 1502
		RG_BC5_UNorm,
		// Token: 0x040005DF RID: 1503
		RG_BC5_SNorm,
		// Token: 0x040005E0 RID: 1504
		RGB_BC6H_UFloat,
		// Token: 0x040005E1 RID: 1505
		RGB_BC6H_SFloat,
		// Token: 0x040005E2 RID: 1506
		RGBA_BC7_SRGB,
		// Token: 0x040005E3 RID: 1507
		RGBA_BC7_UNorm,
		// Token: 0x040005E4 RID: 1508
		RGB_PVRTC_2Bpp_SRGB,
		// Token: 0x040005E5 RID: 1509
		RGB_PVRTC_2Bpp_UNorm,
		// Token: 0x040005E6 RID: 1510
		RGB_PVRTC_4Bpp_SRGB,
		// Token: 0x040005E7 RID: 1511
		RGB_PVRTC_4Bpp_UNorm,
		// Token: 0x040005E8 RID: 1512
		RGBA_PVRTC_2Bpp_SRGB,
		// Token: 0x040005E9 RID: 1513
		RGBA_PVRTC_2Bpp_UNorm,
		// Token: 0x040005EA RID: 1514
		RGBA_PVRTC_4Bpp_SRGB,
		// Token: 0x040005EB RID: 1515
		RGBA_PVRTC_4Bpp_UNorm,
		// Token: 0x040005EC RID: 1516
		RGB_ETC_UNorm,
		// Token: 0x040005ED RID: 1517
		RGB_ETC2_SRGB,
		// Token: 0x040005EE RID: 1518
		RGB_ETC2_UNorm,
		// Token: 0x040005EF RID: 1519
		RGB_A1_ETC2_SRGB,
		// Token: 0x040005F0 RID: 1520
		RGB_A1_ETC2_UNorm,
		// Token: 0x040005F1 RID: 1521
		RGBA_ETC2_SRGB,
		// Token: 0x040005F2 RID: 1522
		RGBA_ETC2_UNorm,
		// Token: 0x040005F3 RID: 1523
		R_EAC_UNorm,
		// Token: 0x040005F4 RID: 1524
		R_EAC_SNorm,
		// Token: 0x040005F5 RID: 1525
		RG_EAC_UNorm,
		// Token: 0x040005F6 RID: 1526
		RG_EAC_SNorm,
		// Token: 0x040005F7 RID: 1527
		RGBA_ASTC4X4_SRGB,
		// Token: 0x040005F8 RID: 1528
		RGBA_ASTC4X4_UNorm,
		// Token: 0x040005F9 RID: 1529
		RGBA_ASTC5X5_SRGB,
		// Token: 0x040005FA RID: 1530
		RGBA_ASTC5X5_UNorm,
		// Token: 0x040005FB RID: 1531
		RGBA_ASTC6X6_SRGB,
		// Token: 0x040005FC RID: 1532
		RGBA_ASTC6X6_UNorm,
		// Token: 0x040005FD RID: 1533
		RGBA_ASTC8X8_SRGB,
		// Token: 0x040005FE RID: 1534
		RGBA_ASTC8X8_UNorm,
		// Token: 0x040005FF RID: 1535
		RGBA_ASTC10X10_SRGB,
		// Token: 0x04000600 RID: 1536
		RGBA_ASTC10X10_UNorm,
		// Token: 0x04000601 RID: 1537
		RGBA_ASTC12X12_SRGB,
		// Token: 0x04000602 RID: 1538
		RGBA_ASTC12X12_UNorm,
		// Token: 0x04000603 RID: 1539
		YUV2,
		// Token: 0x04000604 RID: 1540
		[Obsolete("Enum member GraphicsFormat.DepthAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", false)]
		DepthAuto,
		// Token: 0x04000605 RID: 1541
		[Obsolete("Enum member GraphicsFormat.ShadowAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default shadow buffer format.", false)]
		ShadowAuto,
		// Token: 0x04000606 RID: 1542
		[Obsolete("Enum member GraphicsFormat.VideoAuto has been deprecated. Use DefaultFormat instead.", false)]
		VideoAuto,
		// Token: 0x04000607 RID: 1543
		RGBA_ASTC4X4_UFloat,
		// Token: 0x04000608 RID: 1544
		RGBA_ASTC5X5_UFloat,
		// Token: 0x04000609 RID: 1545
		RGBA_ASTC6X6_UFloat,
		// Token: 0x0400060A RID: 1546
		RGBA_ASTC8X8_UFloat,
		// Token: 0x0400060B RID: 1547
		RGBA_ASTC10X10_UFloat,
		// Token: 0x0400060C RID: 1548
		RGBA_ASTC12X12_UFloat
	}
}
