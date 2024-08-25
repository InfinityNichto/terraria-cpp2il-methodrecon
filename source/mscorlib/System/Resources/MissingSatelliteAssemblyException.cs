using System;
using System.Runtime.Serialization;

namespace System.Resources
{
	// Token: 0x020004A7 RID: 1191
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		// Token: 0x060022C6 RID: 8902 RVA: 0x0004E044 File Offset: 0x0004C244
		public MissingSatelliteAssemblyException()
			: base("Resource lookup fell back to the ultimate fallback resources in a satellite assembly, but that satellite either was not found or could not be loaded. Please consider reinstalling or repairing the application.")
		{
			this._HResult = 5430;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0004E068 File Offset: 0x0004C268
		public MissingSatelliteAssemblyException(string message, string cultureName)
			: base(message)
		{
			this._HResult = 5430;
			this._cultureName = cultureName;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0004E090 File Offset: 0x0004C290
		protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x040012F6 RID: 4854
		private string _cultureName;
	}
}
