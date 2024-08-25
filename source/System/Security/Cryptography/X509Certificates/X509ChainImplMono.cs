using System;
using System.Collections;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000113 RID: 275
	internal class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x00017788 File Offset: 0x00015988
		public X509ChainImplMono(bool useMachineContext)
		{
			this.location = StoreLocation.CurrentUser;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x000177A4 File Offset: 0x000159A4
		public override bool IsValid
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000177B4 File Offset: 0x000159B4
		public override X509ChainElementCollection ChainElements
		{
			get
			{
				return this.elements;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000177C8 File Offset: 0x000159C8
		public override X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.policy;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000177DC File Offset: 0x000159DC
		public override void AddStatus(X509ChainStatusFlags error)
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000177EC File Offset: 0x000159EC
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public override bool Build(X509Certificate2 certificate)
		{
			if (certificate != null)
			{
				X509ChainStatusFlags x509ChainStatusFlags = this.BuildChainFrom(certificate);
				this.ValidateChain(x509ChainStatusFlags);
				X509ChainElementEnumerator enumerator = this.elements.GetEnumerator();
				bool flag = enumerator.MoveNext();
				X509ChainStatus[] array = enumerator.Current.status;
				bool flag2 = enumerator.MoveNext();
				if (x509ChainStatusFlags != X509ChainStatusFlags.NoError)
				{
					string information = X509ChainStatus.GetInformation(x509ChainStatusFlags);
				}
				if (this.status != null)
				{
					AsymmetricAlgorithm asymmetricAlgorithm = this.working_public_key;
					X509ChainStatus[] array2 = this.status;
					AsymmetricAlgorithm asymmetricAlgorithm2 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm3 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm4 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm5 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm6 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm7 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm8 = this.working_public_key;
					AsymmetricAlgorithm asymmetricAlgorithm9 = this.working_public_key;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000178B4 File Offset: 0x00015AB4
		public override void Reset()
		{
			X509ChainStatus[] array = this.status;
			if (array == null || array != null)
			{
			}
			ArrayList list = this.elements._list;
			ArrayList list2 = this.elements._list;
			X509Store x509Store = this.user_root_store;
			if (x509Store != null)
			{
				x509Store.Close();
			}
			X509Store x509Store2 = this.root_store;
			if (x509Store2 != null)
			{
				x509Store2.Close();
			}
			X509Store x509Store3 = this.user_ca_store;
			if (x509Store3 != null)
			{
				x509Store3.Close();
			}
			X509Store x509Store4 = this.ca_store;
			if (x509Store4 != null)
			{
				x509Store4.Close();
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00017930 File Offset: 0x00015B30
		private X509Certificate2Collection Roots
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000660)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Certificate2Collection System.Security.Cryptography.X509Certificates.X509ChainImplMono::get_Roots()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Store(var_0_0E, callgetter:X509Store(X509ChainImplMono::get_LMRootStore, ldloc:X509ChainImplMono(this)))
	stloc:StoreLocation(var_1_15, ldfld:StoreLocation(X509ChainImplMono::location, ldloc:X509ChainImplMono(this)))
	stloc:X509Certificate2Collection(var_2_21, callgetter:X509Certificate2Collection(X509Store::get_Certificates, callgetter:X509Store(X509ChainImplMono::get_UserRootStore, ldloc:X509ChainImplMono(this))))
	stloc:X509Certificate2Collection(var_3_28, callgetter:X509Certificate2Collection(X509Store::get_Certificates, ldloc:X509Store(var_0_0E)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00017968 File Offset: 0x00015B68
		private X509Certificate2Collection CertificateAuthorities
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000661)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Certificate2Collection System.Security.Cryptography.X509Certificates.X509ChainImplMono::get_CertificateAuthorities()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Store(var_0_0E, callgetter:X509Store(X509ChainImplMono::get_LMCAStore, ldloc:X509ChainImplMono(this)))
	stloc:StoreLocation(var_1_15, ldfld:StoreLocation(X509ChainImplMono::location, ldloc:X509ChainImplMono(this)))
	stloc:X509Certificate2Collection(var_2_21, callgetter:X509Certificate2Collection(X509Store::get_Certificates, callgetter:X509Store(X509ChainImplMono::get_UserCAStore, ldloc:X509ChainImplMono(this))))
	stloc:X509Certificate2Collection(var_3_28, callgetter:X509Certificate2Collection(X509Store::get_Certificates, ldloc:X509Store(var_0_0E)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000179A0 File Offset: 0x00015BA0
		private X509Store LMRootStore
		{
			get
			{
				if (this.root_store == null)
				{
				}
				return this.root_store;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000179C0 File Offset: 0x00015BC0
		private X509Store UserRootStore
		{
			get
			{
				if (this.user_root_store == null)
				{
				}
				return this.user_root_store;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000179E0 File Offset: 0x00015BE0
		private X509Store LMCAStore
		{
			get
			{
				if (this.ca_store == null)
				{
				}
				return this.ca_store;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00017A00 File Offset: 0x00015C00
		private X509Store UserCAStore
		{
			get
			{
				if (this.user_ca_store == null)
				{
				}
				return this.user_ca_store;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00017A20 File Offset: 0x00015C20
		private X509Certificate2Collection CertificateCollection
		{
			get
			{
				while (this.collection != null)
				{
				}
				X509Certificate2Collection x509Certificate2Collection = this.Roots;
				X509Certificate2Collection x509Certificate2Collection2 = this.collection;
				X509Certificate2Collection certificateAuthorities = this.CertificateAuthorities;
				x509Certificate2Collection2.AddRange(certificateAuthorities);
				return this.collection;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00017A58 File Offset: 0x00015C58
		private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
		{
			this.elements.Add(certificate);
			bool flag = this.IsChainComplete(certificate);
			X509Certificate2 x509Certificate = this.FindParent(certificate);
			if (x509Certificate != null)
			{
				bool flag2 = this.elements.Contains(x509Certificate);
				X509ChainElementCollection x509ChainElementCollection = this.elements;
				bool flag3 = this.Roots.Contains(x509Certificate);
				ArrayList list = this.elements._list;
				X509ChainElement x509ChainElement;
				X509ChainStatusFlags compressed_status_flags = x509ChainElement.compressed_status_flags;
				x509ChainElement.compressed_status_flags = compressed_status_flags;
				return;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00017AD4 File Offset: 0x00015CD4
		private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
		{
			X509Certificate2 x509Certificate;
			if (c.Count != 0)
			{
				long num = 0L;
				x509Certificate = c[(int)num];
				return x509Certificate;
			}
			return x509Certificate;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00017B40 File Offset: 0x00015D40
		private X509Certificate2 FindParent(X509Certificate2 certificate)
		{
			X509Certificate2Collection certificateCollection = this.CertificateCollection;
			string issuer = certificate.Issuer;
			long num = 0L;
			X509Certificate2Collection x509Certificate2Collection = certificateCollection.Find(X509FindType.FindBySubjectDistinguishedName, issuer, num != 0L);
			string authorityKeyIdentifier = X509ChainImplMono.GetAuthorityKeyIdentifier(certificate);
			if (authorityKeyIdentifier != null)
			{
				int stringLength = authorityKeyIdentifier._stringLength;
				X509Certificate2Collection certificateCollection2 = this.CertificateCollection;
				long num2 = 0L;
				X509Certificate2Collection x509Certificate2Collection2 = certificateCollection2.Find(X509FindType.FindBySubjectKeyIdentifier, authorityKeyIdentifier, num2 != 0L);
				x509Certificate2Collection.AddRange(x509Certificate2Collection2);
			}
			X509Certificate2 x509Certificate = this.SelectBestFromCollection(certificate, x509Certificate2Collection);
			return certificate;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00017BAC File Offset: 0x00015DAC
		private bool IsChainComplete(X509Certificate2 certificate)
		{
			int version = certificate.Version;
			string text;
			bool flag = string.IsNullOrEmpty(text);
			string authorityKeyIdentifier = X509ChainImplMono.GetAuthorityKeyIdentifier(certificate);
			bool flag2 = string.IsNullOrEmpty(authorityKeyIdentifier);
			return true;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00017BE8 File Offset: 0x00015DE8
		private bool IsSelfIssued(X509Certificate2 certificate)
		{
			string issuer = certificate.Issuer;
			string subject = certificate.Subject;
			return issuer == subject;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00017C0C File Offset: 0x00015E0C
		private void ValidateChain(X509ChainStatusFlags flag)
		{
			ArrayList list = this.elements._list;
			X509ChainElementCollection x509ChainElementCollection = this.elements;
			X509ChainElement x509ChainElement;
			X509Certificate2 certificate = x509ChainElement.certificate;
			AsymmetricAlgorithm key = certificate.PublicKey.Key;
			this.working_public_key = key;
			X500DistinguishedName issuerName = certificate.IssuerName;
			this.working_issuer_name = issuerName;
			long num = 0L;
			this.Process((int)num);
			this.CheckRevocationOnChain(flag);
			this.WrapUp();
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00017C8C File Offset: 0x00015E8C
		private void Process(int n)
		{
			X509ChainElement x509ChainElement = this.elements[n];
			X509Certificate2 certificate = x509ChainElement.certificate;
			X509Certificate monoCertificate = X509Helper2.GetMonoCertificate(certificate);
			ArrayList list = this.elements._list;
			if (monoCertificate == null)
			{
				X509ChainElementCollection x509ChainElementCollection = this.elements;
				X509ChainElement x509ChainElement2;
				X509Certificate monoCertificate2 = X509Helper2.GetMonoCertificate(x509ChainElement2.certificate);
			}
			AsymmetricAlgorithm asymmetricAlgorithm = this.working_public_key;
			if (asymmetricAlgorithm != null)
			{
				return;
			}
			AsymmetricAlgorithm key = certificate.PublicKey.Key;
			if (key != null)
			{
				bool flag = X509Helper2.GetMonoCertificate(certificate).VerifySignature(key);
			}
			if (asymmetricAlgorithm != null)
			{
				ArrayList list2 = this.elements._list;
			}
			X509ChainStatusFlags compressed_status_flags = x509ChainElement.compressed_status_flags;
			x509ChainElement.compressed_status_flags = compressed_status_flags;
			X509ChainElement x509ChainElement3 = this.bce_restriction;
			DateTime notBefore = certificate.GetNotBefore();
			X509ChainElement x509ChainElement4 = this.bce_restriction;
			DateTime notAfter = certificate.GetNotAfter();
			X509ChainStatusFlags compressed_status_flags2 = x509ChainElement.compressed_status_flags;
			x509ChainElement.compressed_status_flags = compressed_status_flags2;
			if (asymmetricAlgorithm != null)
			{
				X500DistinguishedName issuerName = certificate.IssuerName;
				X500DistinguishedName x500DistinguishedName = this.working_issuer_name;
				bool flag2 = X500DistinguishedName.AreEqual(issuerName, x500DistinguishedName);
				X509ChainStatusFlags compressed_status_flags3 = x509ChainElement.compressed_status_flags;
				x509ChainElement.compressed_status_flags = compressed_status_flags3;
				return;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00017D88 File Offset: 0x00015F88
		private void PrepareForNextCertificate(int n)
		{
			X509ChainElement x509ChainElement = this.elements[n];
			X509Certificate2 certificate = x509ChainElement.certificate;
			X500DistinguishedName subjectName = certificate.SubjectName;
			this.working_issuer_name = subjectName;
			AsymmetricAlgorithm key = certificate.PublicKey.Key;
			this.working_public_key = key;
			if (certificate.Extensions["2.5.29.19"] != null)
			{
			}
			int version = certificate.Version;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00017E74 File Offset: 0x00016074
		private void WrapUp()
		{
			X509ChainElementCollection x509ChainElementCollection = this.elements;
			long num = 0L;
			X509Certificate2 certificate = x509ChainElementCollection[(int)num].certificate;
			ArrayList list = this.elements._list;
			X509ChainElementCollection x509ChainElementCollection2 = this.elements;
			X509ChainElement x509ChainElement;
			x509ChainElement.UncompressFlags();
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00017EB4 File Offset: 0x000160B4
		private void ProcessCertificateExtensions(X509ChainElement element)
		{
			X509ExtensionEnumerator enumerator = element.certificate.Extensions.GetEnumerator();
			bool flag = enumerator.MoveNext();
			X509Extension x509Extension = enumerator.Current;
			if (x509Extension._critical)
			{
				string value = x509Extension._oid._value;
				bool flag2 = value == "2.5.29.15";
				bool flag3 = value == "2.5.29.19";
				X509ChainStatusFlags compressed_status_flags = element.compressed_status_flags;
				element.compressed_status_flags = compressed_status_flags;
			}
			bool flag4 = enumerator.MoveNext();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00017F28 File Offset: 0x00016128
		private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
		{
			if (pubkey != null)
			{
				return X509Helper2.GetMonoCertificate(signed).VerifySignature(pubkey);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00017F48 File Offset: 0x00016148
		private string GetSubjectKeyIdentifier(X509Certificate2 certificate)
		{
			if (certificate.Extensions["2.5.29.14"] != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00017F68 File Offset: 0x00016168
		private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
		{
			X509Certificate x509Certificate;
			return X509ChainImplMono.GetAuthorityKeyIdentifier(x509Certificate.extensions["2.5.29.35"]);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00017F8C File Offset: 0x0001618C
		private static string GetAuthorityKeyIdentifier(X509Crl crl)
		{
			X509Extension x509Extension;
			return X509ChainImplMono.GetAuthorityKeyIdentifier(x509Extension);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00017FA0 File Offset: 0x000161A0
		private static string GetAuthorityKeyIdentifier(X509Extension ext)
		{
			byte[] array;
			while (array == null)
			{
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00017FB4 File Offset: 0x000161B4
		private void CheckRevocationOnChain(X509ChainStatusFlags flag)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001802C File Offset: 0x0001622C
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
		{
			X509Certificate2 certificate2 = this.elements[ca].certificate;
			ArrayList list = this.elements._list;
			X509ChainElementCollection x509ChainElementCollection = this.elements;
			X509ChainStatusFlags x509ChainStatusFlags;
			return x509ChainStatusFlags;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00018064 File Offset: 0x00016264
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
		{
			if (ca_cert.Extensions["2.5.29.15"] != null)
			{
			}
			X509Crl x509Crl = this.FindCrl(ca_cert);
			if (x509Crl == null)
			{
				return X509ChainStatusFlags.RevocationStatusUnknown;
			}
			AsymmetricAlgorithm key = ca_cert.PublicKey.Key;
			bool flag = x509Crl.VerifySignature(key);
			X509Certificate monoCertificate = X509Helper2.GetMonoCertificate(certificate);
			X509Crl.X509CrlEntry crlEntry = x509Crl.GetCrlEntry(monoCertificate);
			if (crlEntry != null)
			{
				DateTime revocationDate = crlEntry.revocationDate;
				X509ChainElement x509ChainElement = this.bce_restriction;
				return X509ChainStatusFlags.Revoked;
			}
			DateTime nextUpdate = x509Crl.nextUpdate;
			X509ChainElement x509ChainElement2 = this.bce_restriction;
			return X509ChainStatusFlags.RevocationStatusUnknown;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000180E0 File Offset: 0x000162E0
		private static X509Crl CheckCrls(string subject, string ski, X509Store store)
		{
			ArrayList arrayList;
			if (ski != null)
			{
				if (arrayList != null)
				{
				}
				object[] items = arrayList._items;
				int stringLength = subject._stringLength;
				if (stringLength != 0)
				{
					if (stringLength == 0)
					{
					}
					string text;
					bool flag = subject == text;
				}
			}
			long num = 0L;
			if (arrayList != null)
			{
			}
			if (num == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001813C File Offset: 0x0001633C
		private X509Crl FindCrl(X509Certificate2 caCertificate)
		{
			for (;;)
			{
				X500DistinguishedName subjectName = caCertificate.SubjectName;
				X509Store store = this.LMCAStore.store;
				string text;
				string text2;
				if (X509ChainImplMono.CheckCrls(text, text2, store) == null)
				{
					StoreLocation storeLocation = this.location;
					X509Store store2 = this.UserCAStore.store;
					if (X509ChainImplMono.CheckCrls(text, text2, store2) == null)
					{
						X509Store store3 = this.LMRootStore.store;
						if (X509ChainImplMono.CheckCrls(text, text2, store3) == null)
						{
							StoreLocation storeLocation2 = this.location;
							X509Store store4 = this.UserRootStore.store;
							if (X509ChainImplMono.CheckCrls(text, text2, store4) == null)
							{
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000181C0 File Offset: 0x000163C0
		private bool ProcessCrlExtensions(X509Crl crl)
		{
			IEnumerator enumerator = crl.extensions.GetEnumerator();
			if (enumerator != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00018204 File Offset: 0x00016404
		private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
		{
			IEnumerator enumerator = entry.extensions.GetEnumerator();
			if (enumerator != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00018248 File Offset: 0x00016448
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplMono()
		{
		}

		// Token: 0x0400050E RID: 1294
		private StoreLocation location;

		// Token: 0x0400050F RID: 1295
		private X509ChainElementCollection elements;

		// Token: 0x04000510 RID: 1296
		private X509ChainPolicy policy;

		// Token: 0x04000511 RID: 1297
		private X509ChainStatus[] status;

		// Token: 0x04000512 RID: 1298
		private static X509ChainStatus[] Empty;

		// Token: 0x04000513 RID: 1299
		private int max_path_length;

		// Token: 0x04000514 RID: 1300
		private X500DistinguishedName working_issuer_name;

		// Token: 0x04000515 RID: 1301
		private AsymmetricAlgorithm working_public_key;

		// Token: 0x04000516 RID: 1302
		private X509ChainElement bce_restriction;

		// Token: 0x04000517 RID: 1303
		private X509Certificate2Collection roots;

		// Token: 0x04000518 RID: 1304
		private X509Certificate2Collection cas;

		// Token: 0x04000519 RID: 1305
		private X509Store root_store;

		// Token: 0x0400051A RID: 1306
		private X509Store ca_store;

		// Token: 0x0400051B RID: 1307
		private X509Store user_root_store;

		// Token: 0x0400051C RID: 1308
		private X509Store user_ca_store;

		// Token: 0x0400051D RID: 1309
		private X509Certificate2Collection collection;
	}
}
