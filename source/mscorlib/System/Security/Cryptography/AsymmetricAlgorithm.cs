using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002C4 RID: 708
	[ComVisible(true)]
	public abstract class AsymmetricAlgorithm : IDisposable
	{
		// Token: 0x060017F9 RID: 6137 RVA: 0x00033898 File Offset: 0x00031A98
		protected AsymmetricAlgorithm()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000338AC File Offset: 0x00031AAC
		public void Dispose()
		{
			this.Clear();
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000338C0 File Offset: 0x00031AC0
		public void Clear()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000338D4 File Offset: 0x00031AD4
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x000338E4 File Offset: 0x00031AE4
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x000338F8 File Offset: 0x00031AF8
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				int skipSize = this.LegalKeySizesValue.m_skipSize;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00033920 File Offset: 0x00031B20
		public virtual KeySizes[] LegalKeySizes
		{
			get
			{
				KeySizes[] legalKeySizesValue = this.LegalKeySizesValue;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual string SignatureAlgorithm
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual string KeyExchangeAlgorithm
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0000207A File Offset: 0x0000027A
		public static AsymmetricAlgorithm Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00033940 File Offset: 0x00031B40
		public static AsymmetricAlgorithm Create(string algName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void FromXmlString(string xmlString)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual string ToXmlString(bool includePrivateParameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual byte[] ExportPkcs8PrivateKey()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual byte[] ExportSubjectPublicKeyInfo()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, ReadOnlySpan<byte> source, [Out] int bytesRead)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, ReadOnlySpan<byte> source, [Out] int bytesRead)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void ImportPkcs8PrivateKey(ReadOnlySpan<byte> source, [Out] int bytesRead)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void ImportSubjectPublicKeyInfo(ReadOnlySpan<byte> source, [Out] int bytesRead)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters, Span<byte> destination, [Out] int bytesWritten)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters, Span<byte> destination, [Out] int bytesWritten)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool TryExportPkcs8PrivateKey(Span<byte> destination, [Out] int bytesWritten)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool TryExportSubjectPublicKeyInfo(Span<byte> destination, [Out] int bytesWritten)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000C77 RID: 3191
		protected int KeySizeValue;

		// Token: 0x04000C78 RID: 3192
		protected KeySizes[] LegalKeySizesValue;
	}
}
