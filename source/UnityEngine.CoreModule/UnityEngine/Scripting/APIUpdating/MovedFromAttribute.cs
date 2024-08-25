using System;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000101 RID: 257
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x000098B8 File Offset: 0x00007AB8
		public MovedFromAttribute(string sourceNamespace)
		{
			this.data.nameSpace = sourceNamespace;
			this.data.assemblyHasChanged = 256 != 0;
		}

		// Token: 0x0400042C RID: 1068
		internal MovedFromAttributeData data;
	}
}
