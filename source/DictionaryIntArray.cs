using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200000D RID: 13
public struct DictionaryIntArray
{
	// Token: 0x17000015 RID: 21
	public int this[int index]
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
			if (value != 0)
			{
				return;
			}
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002794 File Offset: 0x00000994
	public void Reset()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000027A4 File Offset: 0x000009A4
	public int EntryCount()
	{
		throw new OutOfMemoryException();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000027C4 File Offset: 0x000009C4
	public void DecrementEntries()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000027E8 File Offset: 0x000009E8
	// Note: this type is marked as 'beforefieldinit'.
	static DictionaryIntArray()
	{
	}

	// Token: 0x04000015 RID: 21
	private static List<int> keysToDecrement;

	// Token: 0x04000016 RID: 22
	private Dictionary<int, int> data;
}
