using System;
using UnityEngine;

// Token: 0x020002C0 RID: 704
public class PlatformPictureLoadRequest
{
	// Token: 0x06001047 RID: 4167 RVA: 0x0004FFCC File Offset: 0x0004E1CC
	public virtual void UpdateLoad()
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0004FFDC File Offset: 0x0004E1DC
	public PlatformPictureLoadRequest()
	{
	}

	// Token: 0x04001F38 RID: 7992
	public bool isDone;

	// Token: 0x04001F39 RID: 7993
	public bool Error;

	// Token: 0x04001F3A RID: 7994
	public Texture2D Result;
}
