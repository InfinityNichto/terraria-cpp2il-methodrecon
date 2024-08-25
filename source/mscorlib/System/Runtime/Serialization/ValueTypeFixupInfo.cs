using System;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D6 RID: 982
	internal sealed class ValueTypeFixupInfo
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x00043B60 File Offset: 0x00041D60
		public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex)
		{
			if (parentIndex == null)
			{
			}
			if (containerID == 0L)
			{
				this._parentField = member;
				this._parentIndex = parentIndex;
			}
			if (parentIndex == null)
			{
				if (containerID == 0L)
				{
				}
				this._containerID = containerID;
				this._parentField = member;
				this._parentIndex = parentIndex;
				return;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00043BA4 File Offset: 0x00041DA4
		public long ContainerID
		{
			get
			{
				return this._containerID;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00043BB8 File Offset: 0x00041DB8
		public FieldInfo ParentField
		{
			get
			{
				return this._parentField;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x00043BCC File Offset: 0x00041DCC
		public int[] ParentIndex
		{
			get
			{
				return this._parentIndex;
			}
		}

		// Token: 0x04000F8B RID: 3979
		private readonly long _containerID;

		// Token: 0x04000F8C RID: 3980
		private readonly FieldInfo _parentField;

		// Token: 0x04000F8D RID: 3981
		private readonly int[] _parentIndex;
	}
}
