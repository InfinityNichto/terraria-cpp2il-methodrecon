using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000169 RID: 361
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public sealed class AppDomainSetup
	{
		// Token: 0x06000E91 RID: 3729 RVA: 0x0001F7DC File Offset: 0x0001D9DC
		public AppDomainSetup()
		{
		}

		// Token: 0x04000630 RID: 1584
		private string application_base;

		// Token: 0x04000631 RID: 1585
		private string application_name;

		// Token: 0x04000632 RID: 1586
		private string cache_path;

		// Token: 0x04000633 RID: 1587
		private string configuration_file;

		// Token: 0x04000634 RID: 1588
		private string dynamic_base;

		// Token: 0x04000635 RID: 1589
		private string license_file;

		// Token: 0x04000636 RID: 1590
		private string private_bin_path;

		// Token: 0x04000637 RID: 1591
		private string private_bin_path_probe;

		// Token: 0x04000638 RID: 1592
		private string shadow_copy_directories;

		// Token: 0x04000639 RID: 1593
		private string shadow_copy_files;

		// Token: 0x0400063A RID: 1594
		private bool publisher_policy;

		// Token: 0x0400063B RID: 1595
		private bool path_changed;

		// Token: 0x0400063C RID: 1596
		private int loader_optimization;

		// Token: 0x0400063D RID: 1597
		private bool disallow_binding_redirects;

		// Token: 0x0400063E RID: 1598
		private bool disallow_code_downloads;

		// Token: 0x0400063F RID: 1599
		private object _activationArguments;

		// Token: 0x04000640 RID: 1600
		private object domain_initializer;

		// Token: 0x04000641 RID: 1601
		private object application_trust;

		// Token: 0x04000642 RID: 1602
		private string[] domain_initializer_args;

		// Token: 0x04000643 RID: 1603
		private bool disallow_appbase_probe;

		// Token: 0x04000644 RID: 1604
		private byte[] configuration_bytes;

		// Token: 0x04000645 RID: 1605
		private byte[] serialized_non_primitives;

		// Token: 0x04000646 RID: 1606
		private string manager_assembly;

		// Token: 0x04000647 RID: 1607
		private string manager_type;

		// Token: 0x04000648 RID: 1608
		private string[] partial_visible_assemblies;

		// Token: 0x04000649 RID: 1609
		[CompilerGenerated]
		private string <TargetFrameworkName>k__BackingField;
	}
}
