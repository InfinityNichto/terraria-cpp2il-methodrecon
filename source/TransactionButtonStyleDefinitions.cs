using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001C0 RID: 448
public class TransactionButtonStyleDefinitions : LayoutDefinition
{
	// Token: 0x06000BD7 RID: 3031 RVA: 0x0003AF70 File Offset: 0x00039170
	private void Awake()
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0003AF80 File Offset: 0x00039180
	public static TransactionButtonStyle_Definition GetDefinition(string id)
	{
		TransactionButtonStyleDefinitions component = GameObject.Find("TransactionButtons").GetComponent<TransactionButtonStyleDefinitions>();
		throw new OutOfMemoryException();
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0003AFB0 File Offset: 0x000391B0
	public TransactionButtonStyleDefinitions()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000EED RID: 3821
	public static TransactionButtonStyleDefinitions Instance;

	// Token: 0x04000EEE RID: 3822
	public List<TransactionButtonStyle_Definition> Definitions;
}
