using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public struct InputDeviceMatcher
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000025E1 File Offset: 0x000007E1
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public OptionalUInt16 VendorID
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.vendorID = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007AD8 File Offset: 0x00005CD8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00007AEC File Offset: 0x00005CEC
		public OptionalUInt16 ProductID
		{
			get
			{
				return this.productID;
			}
			set
			{
				this.productID = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00007B14 File Offset: 0x00005D14
		public OptionalUInt32 VersionNumber
		{
			get
			{
				return this.versionNumber;
			}
			set
			{
				this.versionNumber = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00007B28 File Offset: 0x00005D28
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00007B3C File Offset: 0x00005D3C
		public OptionalInputDeviceDriverType DriverType
		{
			get
			{
				return this.driverType;
			}
			set
			{
				this.driverType = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00007B50 File Offset: 0x00005D50
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00007B64 File Offset: 0x00005D64
		public OptionalInputDeviceTransportType TransportType
		{
			get
			{
				return this.transportType;
			}
			set
			{
				this.transportType = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00007B78 File Offset: 0x00005D78
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00007B8C File Offset: 0x00005D8C
		public string NameLiteral
		{
			get
			{
				return this.nameLiteral;
			}
			set
			{
				this.nameLiteral = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00007BA0 File Offset: 0x00005DA0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00007BB4 File Offset: 0x00005DB4
		public string NamePattern
		{
			get
			{
				return this.namePattern;
			}
			set
			{
				this.namePattern = value;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007BC8 File Offset: 0x00005DC8
		internal bool Matches(InputDeviceInfo deviceInfo)
		{
			ushort num = deviceInfo.vendorID;
			OptionalUInt16 optionalUInt = this.productID;
			ushort num2 = deviceInfo.productID;
			OptionalUInt32 optionalUInt2 = this.versionNumber;
			uint num3 = deviceInfo.versionNumber;
			OptionalInputDeviceDriverType optionalInputDeviceDriverType = this.driverType;
			InputDeviceDriverType inputDeviceDriverType = deviceInfo.driverType;
			OptionalInputDeviceTransportType optionalInputDeviceTransportType = this.transportType;
			InputDeviceTransportType inputDeviceTransportType = deviceInfo.transportType;
			bool flag = string.IsNullOrEmpty(this.nameLiteral);
			string text = this.nameLiteral;
			bool flag2 = string.IsNullOrEmpty(this.namePattern);
			string text2 = this.namePattern;
			return true;
		}

		// Token: 0x0400024E RID: 590
		[Hexadecimal]
		[SerializeField]
		private OptionalUInt16 vendorID;

		// Token: 0x0400024F RID: 591
		[SerializeField]
		private OptionalUInt16 productID;

		// Token: 0x04000250 RID: 592
		[SerializeField]
		[Hexadecimal]
		private OptionalUInt32 versionNumber;

		// Token: 0x04000251 RID: 593
		[SerializeField]
		private OptionalInputDeviceDriverType driverType;

		// Token: 0x04000252 RID: 594
		[SerializeField]
		private OptionalInputDeviceTransportType transportType;

		// Token: 0x04000253 RID: 595
		[SerializeField]
		private string nameLiteral;

		// Token: 0x04000254 RID: 596
		[SerializeField]
		private string namePattern;
	}
}
