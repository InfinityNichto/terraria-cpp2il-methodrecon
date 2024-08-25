using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace InControl
{
	// Token: 0x02000003 RID: 3
	public abstract class BindingSource : IEquatable<BindingSource>
	{
		// Token: 0x06000006 RID: 6
		public abstract float GetValue(InputDevice inputDevice);

		// Token: 0x06000007 RID: 7
		public abstract bool GetState(InputDevice inputDevice);

		// Token: 0x06000008 RID: 8
		public abstract bool Equals(BindingSource other);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9
		public abstract string Name { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10
		public abstract string DeviceName { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11
		public abstract InputDeviceClass DeviceClass { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		public abstract InputDeviceStyle DeviceStyle { get; }

		// Token: 0x0600000D RID: 13 RVA: 0x000020D8 File Offset: 0x000002D8
		public static bool operator ==(BindingSource a, BindingSource b)
		{
			while (a == null)
			{
			}
			return true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020F0 File Offset: 0x000002F0
		public static bool operator !=(BindingSource a, BindingSource b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002100 File Offset: 0x00000300
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002118 File Offset: 0x00000318
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17
		public abstract BindingSourceType BindingSourceType { get; }

		// Token: 0x06000012 RID: 18
		public abstract void Save(BinaryWriter writer);

		// Token: 0x06000013 RID: 19
		public abstract void Load(BinaryReader reader, ushort dataFormatVersion);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002140 File Offset: 0x00000340
		internal PlayerAction BoundTo
		{
			[CompilerGenerated]
			get
			{
				return this.<BoundTo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BoundTo>k__BackingField = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002154 File Offset: 0x00000354
		internal virtual bool IsValid
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002164 File Offset: 0x00000364
		protected BindingSource()
		{
		}

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		private PlayerAction <BoundTo>k__BackingField;
	}
}
