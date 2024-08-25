using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	// Token: 0x020003E3 RID: 995
	[ComVisible(true)]
	[TypeConverter(typeof(ComponentConverter))]
	[global::System.ComponentModel.Design.Serialization.RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	public interface IComponent : IDisposable
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001A4E RID: 6734
		// (set) Token: 0x06001A4F RID: 6735
		ISite Site { get; set; }

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001A50 RID: 6736
		// (remove) Token: 0x06001A51 RID: 6737
		event EventHandler Disposed;
	}
}
