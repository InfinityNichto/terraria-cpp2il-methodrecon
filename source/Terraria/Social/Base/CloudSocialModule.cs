using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.IO;

namespace Terraria.Social.Base
{
	// Token: 0x02000529 RID: 1321
	public abstract class CloudSocialModule : ISocialModule
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x001F8D58 File Offset: 0x001F6F58
		public virtual void Initialize()
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
			Preferences configuration2 = Main.Configuration;
		}

		// Token: 0x060031C2 RID: 12738
		public abstract void Shutdown();

		// Token: 0x060031C3 RID: 12739
		public abstract IEnumerable<string> GetFiles();

		// Token: 0x060031C4 RID: 12740
		public abstract bool Write(string path, byte[] data, int length);

		// Token: 0x060031C5 RID: 12741
		public abstract void Read(string path, byte[] buffer, int length);

		// Token: 0x060031C6 RID: 12742
		public abstract bool HasFile(string path);

		// Token: 0x060031C7 RID: 12743
		public abstract int GetFileSize(string path);

		// Token: 0x060031C8 RID: 12744
		public abstract bool Delete(string path);

		// Token: 0x060031C9 RID: 12745
		public abstract bool Forget(string path);

		// Token: 0x060031CA RID: 12746 RVA: 0x000021DB File Offset: 0x000003DB
		public byte[] Read(string path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x001F8D78 File Offset: 0x001F6F78
		public void Read(string path, byte[] buffer)
		{
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Write(string path, byte[] data)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x001F8D88 File Offset: 0x001F6F88
		protected CloudSocialModule()
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x001F8D9C File Offset: 0x001F6F9C
		[CompilerGenerated]
		private void <Initialize>b__1_0(Preferences preferences)
		{
			this.EnabledByDefault = true;
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x001F8DB0 File Offset: 0x001F6FB0
		[CompilerGenerated]
		private void <Initialize>b__1_1(Preferences preferences)
		{
			bool enabledByDefault = this.EnabledByDefault;
		}

		// Token: 0x04003B5E RID: 15198
		public bool EnabledByDefault;
	}
}
