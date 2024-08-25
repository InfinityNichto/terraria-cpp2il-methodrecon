using System;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class InspectorNameAttribute : PropertyAttribute
	{
		// Token: 0x0600027E RID: 638 RVA: 0x00005A44 File Offset: 0x00003C44
		public InspectorNameAttribute(string displayName)
		{
			this.displayName = displayName;
		}

		// Token: 0x04000321 RID: 801
		public readonly string displayName;
	}
}
