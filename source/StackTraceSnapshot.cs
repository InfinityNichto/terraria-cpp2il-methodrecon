using System;
using UnityEngine;

// Token: 0x02000064 RID: 100
public class StackTraceSnapshot : MonoBehaviour
{
	// Token: 0x06000214 RID: 532 RVA: 0x000060D0 File Offset: 0x000042D0
	public void UpdateStackTrace()
	{
		if (!true)
		{
		}
		string text = StackTraceUtility.ExtractStackTrace();
		this.StackTrace = text;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x000060F0 File Offset: 0x000042F0
	public StackTraceSnapshot()
	{
	}

	// Token: 0x040001F9 RID: 505
	public string StackTrace;
}
