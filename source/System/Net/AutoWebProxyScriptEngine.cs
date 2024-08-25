using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x02000221 RID: 545
	internal class AutoWebProxyScriptEngine
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		public AutoWebProxyScriptEngine(WebProxy proxy, bool useRegistry)
		{
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0002C3D4 File Offset: 0x0002A5D4
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		public global::System.Uri AutomaticConfigurationScript
		{
			[CompilerGenerated]
			get
			{
				return this.<AutomaticConfigurationScript>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AutomaticConfigurationScript>k__BackingField = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0002C410 File Offset: 0x0002A610
		public bool AutomaticallyDetectSettings
		{
			[CompilerGenerated]
			get
			{
				return this.<AutomaticallyDetectSettings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0002C420 File Offset: 0x0002A620
		public bool GetProxies(global::System.Uri destination, [Out] IList<string> proxyList)
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0002C430 File Offset: 0x0002A630
		public bool GetProxies(global::System.Uri destination, [Out] IList<string> proxyList, int syncStatus)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002C440 File Offset: 0x0002A640
		public void Close()
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002C450 File Offset: 0x0002A650
		public void Abort(int syncStatus)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0002C460 File Offset: 0x0002A660
		public void CheckForChanges()
		{
		}

		// Token: 0x04000B7E RID: 2942
		[CompilerGenerated]
		private global::System.Uri <AutomaticConfigurationScript>k__BackingField;

		// Token: 0x04000B7F RID: 2943
		[CompilerGenerated]
		private bool <AutomaticallyDetectSettings>k__BackingField;
	}
}
