using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000153 RID: 339
public static class GUILicenseCheck
{
	// Token: 0x0600094A RID: 2378 RVA: 0x000289E4 File Offset: 0x00026BE4
	public static void PerformCheck()
	{
		if ("MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtCJtRkNlq9NnJT7a8TMsIDo02vCyaIZ3T5fQRZKR/5iFcODxA5LtmAJlhA4g4rq2X+LqZHuonsOQVcGn9o5fQuST8KKtV3q6UlOWnT4+Y8EjE+OzYt+xtFxhQy7hHos80ApUqPBmXPa4+HxWqGL1acj5e9vMEsKBDBBlBYnt2S7rIdmFjToNaZ+T41ettcnWrOlGwK57l4E1kwkH1vG4feFmzXHU2t14ExUChqO0p9u4B9U/HO20idDJ8gb8jBehJrWdflJolbN4n8zX+mVDiitzgkJII+0D2iZktP6PjlRCOEj6gD9N08uMRUiFKvv1HPh8M6ja3RpXv/oLkTCNWwIDAQAB" == null || "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtCJtRkNlq9NnJT7a8TMsIDo02vCyaIZ3T5fQRZKR/5iFcODxA5LtmAJlhA4g4rq2X+LqZHuonsOQVcGn9o5fQuST8KKtV3q6UlOWnT4+Y8EjE+OzYt+xtFxhQy7hHos80ApUqPBmXPa4+HxWqGL1acj5e9vMEsKBDBBlBYnt2S7rIdmFjToNaZ+T41ettcnWrOlGwK57l4E1kwkH1vG4feFmzXHU2t14ExUChqO0p9u4B9U/HO20idDJ8gb8jBehJrWdflJolbN4n8zX+mVDiitzgkJII+0D2iZktP6PjlRCOEj6gD9N08uMRUiFKvv1HPh8M6ja3RpXv/oLkTCNWwIDAQAB" != null)
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00028A44 File Offset: 0x00026C44
	public static void FollowLink()
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x000021DB File Offset: 0x000003DB
	private static void Process()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00028A8C File Offset: 0x00026C8C
	public static void Draw()
	{
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			GUILicenseCheck.PerformCheck();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			GUILicenseCheck.FollowLink();
			return;
		}
	}

	// Token: 0x040008F0 RID: 2288
	public static bool RequiresDraw;

	// Token: 0x040008F1 RID: 2289
	private static int reason;

	// Token: 0x040008F2 RID: 2290
	private static string result;

	// Token: 0x040008F3 RID: 2291
	private static AndroidJavaObject activity;

	// Token: 0x040008F4 RID: 2292
	private static AndroidJavaObject lvlCheck;

	// Token: 0x040008F5 RID: 2293
	private static string packageName;

	// Token: 0x040008F6 RID: 2294
	private static float retryScale;
}
