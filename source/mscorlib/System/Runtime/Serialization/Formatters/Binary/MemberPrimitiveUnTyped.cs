using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040F RID: 1039
	internal sealed class MemberPrimitiveUnTyped
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x00046A54 File Offset: 0x00044C54
		internal MemberPrimitiveUnTyped()
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00046A68 File Offset: 0x00044C68
		internal void Set(InternalPrimitiveTypeE typeInformation, object value)
		{
			this.typeInformation = typeInformation;
			this.value = value;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00046A84 File Offset: 0x00044C84
		internal void Set(InternalPrimitiveTypeE typeInformation)
		{
			this.typeInformation = typeInformation;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00046A98 File Offset: 0x00044C98
		public void Write(__BinaryWriter sout)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.typeInformation;
			object obj = this.value;
			sout.WriteValue(internalPrimitiveTypeE, obj);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00046ABC File Offset: 0x00044CBC
		public void Read(__BinaryParser input)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.typeInformation;
			object obj = input.ReadValue(internalPrimitiveTypeE);
			this.value = obj;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00046AE0 File Offset: 0x00044CE0
		public void Dump()
		{
		}

		// Token: 0x04001099 RID: 4249
		internal InternalPrimitiveTypeE typeInformation;

		// Token: 0x0400109A RID: 4250
		internal object value;
	}
}
