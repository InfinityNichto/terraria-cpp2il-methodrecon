using System;
using System.Runtime.CompilerServices;

// Token: 0x02000069 RID: 105
public class CachedFile
{
	// Token: 0x06000233 RID: 563 RVA: 0x0000652C File Offset: 0x0000472C
	public CachedFile(string filename)
	{
		this.Filename = filename;
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00006550 File Offset: 0x00004750
	// (set) Token: 0x06000235 RID: 565 RVA: 0x00006564 File Offset: 0x00004764
	public byte[] Data
	{
		[CompilerGenerated]
		get
		{
			return this.<Data>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			this.<Data>k__BackingField = value;
		}
	}

	// Token: 0x04000205 RID: 517
	public CachedFile.Modifications ModificationFlag = CachedFile.Modifications.None;

	// Token: 0x04000206 RID: 518
	public readonly string Filename;

	// Token: 0x04000207 RID: 519
	[CompilerGenerated]
	private byte[] <Data>k__BackingField;

	// Token: 0x0200006A RID: 106
	public enum Modifications
	{
		// Token: 0x04000209 RID: 521
		Delete,
		// Token: 0x0400020A RID: 522
		Write,
		// Token: 0x0400020B RID: 523
		None
	}
}
