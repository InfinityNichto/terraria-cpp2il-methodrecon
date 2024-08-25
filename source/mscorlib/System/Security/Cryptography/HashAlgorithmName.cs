using System;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002BE RID: 702
	public readonly struct HashAlgorithmName : IEquatable<HashAlgorithmName>
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00033504 File Offset: 0x00031704
		public static HashAlgorithmName MD5
		{
			get
			{
				return "MD5";
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00033518 File Offset: 0x00031718
		public static HashAlgorithmName SHA1
		{
			get
			{
				return "SHA1";
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0003352C File Offset: 0x0003172C
		public static HashAlgorithmName SHA256
		{
			get
			{
				return "SHA256";
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00033540 File Offset: 0x00031740
		public static HashAlgorithmName SHA384
		{
			get
			{
				return "SHA384";
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00033554 File Offset: 0x00031754
		public static HashAlgorithmName SHA512
		{
			get
			{
				return "SHA512";
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00033568 File Offset: 0x00031768
		public HashAlgorithmName(string name)
		{
			this._name = name;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0000207A File Offset: 0x0000027A
		public string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0003357C File Offset: 0x0003177C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00033590 File Offset: 0x00031790
		public bool Equals(HashAlgorithmName other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000335A0 File Offset: 0x000317A0
		public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x000335B0 File Offset: 0x000317B0
		public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x04000C64 RID: 3172
		private readonly string _name;
	}
}
