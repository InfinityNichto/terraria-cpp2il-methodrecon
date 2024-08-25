using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000100 RID: 256
	internal struct MovedFromAttributeData
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00009894 File Offset: 0x00007A94
		public void Set(bool autoUpdateAPI, [Optional] string sourceNamespace, [Optional] string sourceAssembly, [Optional] string sourceClassName)
		{
			this.className = sourceClassName;
			this.nameSpace = sourceNamespace;
			this.assembly = sourceAssembly;
		}

		// Token: 0x04000425 RID: 1061
		public string className;

		// Token: 0x04000426 RID: 1062
		public string nameSpace;

		// Token: 0x04000427 RID: 1063
		public string assembly;

		// Token: 0x04000428 RID: 1064
		public bool classHasChanged;

		// Token: 0x04000429 RID: 1065
		public bool nameSpaceHasChanged;

		// Token: 0x0400042A RID: 1066
		public bool assemblyHasChanged;

		// Token: 0x0400042B RID: 1067
		public bool autoUdpateAPI;
	}
}
