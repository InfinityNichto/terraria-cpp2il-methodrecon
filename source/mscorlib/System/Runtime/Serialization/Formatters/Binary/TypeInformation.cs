using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041D RID: 1053
	internal sealed class TypeInformation
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0004867C File Offset: 0x0004687C
		internal string FullTypeName
		{
			get
			{
				return this.fullTypeName;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00048690 File Offset: 0x00046890
		internal string AssemblyString
		{
			get
			{
				return this.assemblyString;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x000486A4 File Offset: 0x000468A4
		internal bool HasTypeForwardedFrom
		{
			get
			{
				return this.hasTypeForwardedFrom;
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000486B8 File Offset: 0x000468B8
		internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
		{
			this.fullTypeName = fullTypeName;
			this.assemblyString = assemblyString;
		}

		// Token: 0x04001138 RID: 4408
		private string fullTypeName;

		// Token: 0x04001139 RID: 4409
		private string assemblyString;

		// Token: 0x0400113A RID: 4410
		private bool hasTypeForwardedFrom;
	}
}
