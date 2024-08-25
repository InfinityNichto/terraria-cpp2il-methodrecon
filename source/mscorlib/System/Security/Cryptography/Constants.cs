using System;

namespace System.Security.Cryptography
{
	// Token: 0x0200030C RID: 780
	internal static class Constants
	{
		// Token: 0x04000D39 RID: 3385
		internal const int S_OK = 0;

		// Token: 0x04000D3A RID: 3386
		internal const int NTE_FILENOTFOUND = -2147024894;

		// Token: 0x04000D3B RID: 3387
		internal const int NTE_NO_KEY = -2146893811;

		// Token: 0x04000D3C RID: 3388
		internal const int NTE_BAD_KEYSET = -2146893802;

		// Token: 0x04000D3D RID: 3389
		internal const int NTE_KEYSET_NOT_DEF = -2146893799;

		// Token: 0x04000D3E RID: 3390
		internal const int KP_IV = 1;

		// Token: 0x04000D3F RID: 3391
		internal const int KP_MODE = 4;

		// Token: 0x04000D40 RID: 3392
		internal const int KP_MODE_BITS = 5;

		// Token: 0x04000D41 RID: 3393
		internal const int KP_EFFECTIVE_KEYLEN = 19;

		// Token: 0x04000D42 RID: 3394
		internal const int ALG_CLASS_SIGNATURE = 8192;

		// Token: 0x04000D43 RID: 3395
		internal const int ALG_CLASS_DATA_ENCRYPT = 24576;

		// Token: 0x04000D44 RID: 3396
		internal const int ALG_CLASS_HASH = 32768;

		// Token: 0x04000D45 RID: 3397
		internal const int ALG_CLASS_KEY_EXCHANGE = 40960;

		// Token: 0x04000D46 RID: 3398
		internal const int ALG_TYPE_DSS = 512;

		// Token: 0x04000D47 RID: 3399
		internal const int ALG_TYPE_RSA = 1024;

		// Token: 0x04000D48 RID: 3400
		internal const int ALG_TYPE_BLOCK = 1536;

		// Token: 0x04000D49 RID: 3401
		internal const int ALG_TYPE_STREAM = 2048;

		// Token: 0x04000D4A RID: 3402
		internal const int ALG_TYPE_ANY = 0;

		// Token: 0x04000D4B RID: 3403
		internal const int CALG_MD5 = 32771;

		// Token: 0x04000D4C RID: 3404
		internal const int CALG_SHA1 = 32772;

		// Token: 0x04000D4D RID: 3405
		internal const int CALG_SHA_256 = 32780;

		// Token: 0x04000D4E RID: 3406
		internal const int CALG_SHA_384 = 32781;

		// Token: 0x04000D4F RID: 3407
		internal const int CALG_SHA_512 = 32782;

		// Token: 0x04000D50 RID: 3408
		internal const int CALG_RSA_KEYX = 41984;

		// Token: 0x04000D51 RID: 3409
		internal const int CALG_RSA_SIGN = 9216;

		// Token: 0x04000D52 RID: 3410
		internal const int CALG_DSS_SIGN = 8704;

		// Token: 0x04000D53 RID: 3411
		internal const int CALG_DES = 26113;

		// Token: 0x04000D54 RID: 3412
		internal const int CALG_RC2 = 26114;

		// Token: 0x04000D55 RID: 3413
		internal const int CALG_3DES = 26115;

		// Token: 0x04000D56 RID: 3414
		internal const int CALG_3DES_112 = 26121;

		// Token: 0x04000D57 RID: 3415
		internal const int CALG_AES_128 = 26126;

		// Token: 0x04000D58 RID: 3416
		internal const int CALG_AES_192 = 26127;

		// Token: 0x04000D59 RID: 3417
		internal const int CALG_AES_256 = 26128;

		// Token: 0x04000D5A RID: 3418
		internal const int CALG_RC4 = 26625;

		// Token: 0x04000D5B RID: 3419
		internal const int PROV_RSA_FULL = 1;

		// Token: 0x04000D5C RID: 3420
		internal const int PROV_DSS_DH = 13;

		// Token: 0x04000D5D RID: 3421
		internal const int PROV_RSA_AES = 24;

		// Token: 0x04000D5E RID: 3422
		internal const int AT_KEYEXCHANGE = 1;

		// Token: 0x04000D5F RID: 3423
		internal const int AT_SIGNATURE = 2;

		// Token: 0x04000D60 RID: 3424
		internal const int PUBLICKEYBLOB = 6;

		// Token: 0x04000D61 RID: 3425
		internal const int PRIVATEKEYBLOB = 7;

		// Token: 0x04000D62 RID: 3426
		internal const int CRYPT_OAEP = 64;

		// Token: 0x04000D63 RID: 3427
		internal const uint CRYPT_VERIFYCONTEXT = 4026531840U;

		// Token: 0x04000D64 RID: 3428
		internal const uint CRYPT_NEWKEYSET = 8U;

		// Token: 0x04000D65 RID: 3429
		internal const uint CRYPT_DELETEKEYSET = 16U;

		// Token: 0x04000D66 RID: 3430
		internal const uint CRYPT_MACHINE_KEYSET = 32U;

		// Token: 0x04000D67 RID: 3431
		internal const uint CRYPT_SILENT = 64U;

		// Token: 0x04000D68 RID: 3432
		internal const uint CRYPT_EXPORTABLE = 1U;

		// Token: 0x04000D69 RID: 3433
		internal const uint CLR_KEYLEN = 1U;

		// Token: 0x04000D6A RID: 3434
		internal const uint CLR_PUBLICKEYONLY = 2U;

		// Token: 0x04000D6B RID: 3435
		internal const uint CLR_EXPORTABLE = 3U;

		// Token: 0x04000D6C RID: 3436
		internal const uint CLR_REMOVABLE = 4U;

		// Token: 0x04000D6D RID: 3437
		internal const uint CLR_HARDWARE = 5U;

		// Token: 0x04000D6E RID: 3438
		internal const uint CLR_ACCESSIBLE = 6U;

		// Token: 0x04000D6F RID: 3439
		internal const uint CLR_PROTECTED = 7U;

		// Token: 0x04000D70 RID: 3440
		internal const uint CLR_UNIQUE_CONTAINER = 8U;

		// Token: 0x04000D71 RID: 3441
		internal const uint CLR_ALGID = 9U;

		// Token: 0x04000D72 RID: 3442
		internal const uint CLR_PP_CLIENT_HWND = 10U;

		// Token: 0x04000D73 RID: 3443
		internal const uint CLR_PP_PIN = 11U;

		// Token: 0x04000D74 RID: 3444
		internal const string OID_RSA_SMIMEalgCMS3DESwrap = "1.2.840.113549.1.9.16.3.6";

		// Token: 0x04000D75 RID: 3445
		internal const string OID_RSA_MD5 = "1.2.840.113549.2.5";

		// Token: 0x04000D76 RID: 3446
		internal const string OID_RSA_RC2CBC = "1.2.840.113549.3.2";

		// Token: 0x04000D77 RID: 3447
		internal const string OID_RSA_DES_EDE3_CBC = "1.2.840.113549.3.7";

		// Token: 0x04000D78 RID: 3448
		internal const string OID_OIWSEC_desCBC = "1.3.14.3.2.7";

		// Token: 0x04000D79 RID: 3449
		internal const string OID_OIWSEC_SHA1 = "1.3.14.3.2.26";

		// Token: 0x04000D7A RID: 3450
		internal const string OID_OIWSEC_SHA256 = "2.16.840.1.101.3.4.2.1";

		// Token: 0x04000D7B RID: 3451
		internal const string OID_OIWSEC_SHA384 = "2.16.840.1.101.3.4.2.2";

		// Token: 0x04000D7C RID: 3452
		internal const string OID_OIWSEC_SHA512 = "2.16.840.1.101.3.4.2.3";

		// Token: 0x04000D7D RID: 3453
		internal const string OID_OIWSEC_RIPEMD160 = "1.3.36.3.2.1";
	}
}
