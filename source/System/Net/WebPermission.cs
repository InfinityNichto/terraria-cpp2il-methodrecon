using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::System.Text.RegularExpressions.Regex MatchAllRegex
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00025428 File Offset: 0x00023628
		public IEnumerator ConnectList
		{
			get
			{
				if (!this.m_UnrestrictedConnect)
				{
					if (false)
					{
					}
					global::System.Text.RegularExpressions.Regex regex;
					if (regex != null)
					{
					}
					if (!false || regex != null)
					{
					}
					throw new InvalidCastException();
				}
				global::System.Text.RegularExpressions.Regex matchAllRegex = WebPermission.MatchAllRegex;
				if (matchAllRegex == null || matchAllRegex != null)
				{
					IEnumerator enumerator;
					return enumerator;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00025468 File Offset: 0x00023668
		public IEnumerator AcceptList
		{
			get
			{
				if (!this.m_UnrestrictedAccept)
				{
					if (false)
					{
					}
					global::System.Text.RegularExpressions.Regex regex;
					if (regex != null)
					{
					}
					if (!false || regex != null)
					{
					}
					throw new InvalidCastException();
				}
				global::System.Text.RegularExpressions.Regex matchAllRegex = WebPermission.MatchAllRegex;
				if (matchAllRegex == null || matchAllRegex != null)
				{
					IEnumerator enumerator;
					return enumerator;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000254A8 File Offset: 0x000236A8
		public WebPermission(PermissionState state)
		{
			this.m_noRestriction = true;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000254C4 File Offset: 0x000236C4
		internal WebPermission(bool unrestricted)
		{
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000254D8 File Offset: 0x000236D8
		public WebPermission()
		{
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000254EC File Offset: 0x000236EC
		internal WebPermission(NetworkAccess access)
		{
			this.m_UnrestrictedConnect = true;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00025508 File Offset: 0x00023708
		public WebPermission(NetworkAccess access, global::System.Text.RegularExpressions.Regex uriRegex)
		{
			this.AddPermission(access, uriRegex);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00025524 File Offset: 0x00023724
		public WebPermission(NetworkAccess access, string uriString)
		{
			this.AddPermission(access, uriString);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00025540 File Offset: 0x00023740
		internal WebPermission(NetworkAccess access, global::System.Uri uri)
		{
			this.AddPermission(access, uri);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0002555C File Offset: 0x0002375C
		public void AddPermission(NetworkAccess access, string uriString)
		{
			if (uriString == null)
			{
				throw new OutOfMemoryException();
			}
			if (!this.m_noRestriction)
			{
				return;
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000255F0 File Offset: 0x000237F0
		internal void AddPermission(NetworkAccess access, global::System.Uri uri)
		{
			if (!true)
			{
			}
			if (!this.m_noRestriction)
			{
				if (!this.m_UnrestrictedConnect)
				{
					ArrayList connectList = this.m_connectList;
				}
				if (!this.m_UnrestrictedAccept)
				{
					ArrayList acceptList = this.m_acceptList;
				}
				return;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002568C File Offset: 0x0002388C
		public void AddPermission(NetworkAccess access, global::System.Text.RegularExpressions.Regex uriRegex)
		{
			for (;;)
			{
				if (uriRegex != null)
				{
					if (this.m_noRestriction)
					{
						break;
					}
					if (!this.m_UnrestrictedConnect)
					{
						ArrayList connectList = this.m_connectList;
						this.m_UnrestrictedConnect = true;
					}
					if (!this.m_UnrestrictedAccept)
					{
						goto Block_3;
					}
				}
			}
			return;
			Block_3:
			ArrayList acceptList = this.m_acceptList;
			this.m_UnrestrictedAccept = true;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000256D4 File Offset: 0x000238D4
		internal void AddAsPattern(NetworkAccess access, DelayedRegex uriRegexPattern)
		{
			if (this.m_UnrestrictedConnect)
			{
				if (!this.m_UnrestrictedAccept)
				{
					ArrayList acceptList = this.m_acceptList;
					return;
				}
			}
			else
			{
				ArrayList connectList = this.m_connectList;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00025754 File Offset: 0x00023954
		public bool IsUnrestricted()
		{
			return this.m_noRestriction;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00025768 File Offset: 0x00023968
		public override IPermission Copy()
		{
			do
			{
				if (this.m_noRestriction)
				{
				}
				bool unrestrictedAccept = this.m_UnrestrictedAccept;
				bool unrestrictedConnect = this.m_UnrestrictedConnect;
				if (this.m_acceptList != null)
				{
				}
			}
			while (this.m_connectList == null);
			throw new InvalidCastException();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000257A4 File Offset: 0x000239A4
		public override bool IsSubsetOf(IPermission target)
		{
			if (target != null)
			{
			}
			if (!this.m_noRestriction && !this.m_UnrestrictedConnect && !this.m_UnrestrictedAccept && this.m_connectList == null)
			{
				ArrayList acceptList = this.m_acceptList;
				if (!this.m_noRestriction)
				{
					goto IL_0034;
				}
			}
			long num = 0L;
			IL_0034:
			ArrayList connectList2;
			if (num != 0L)
			{
				while (num != 0L)
				{
				}
				bool unrestrictedConnect = this.m_UnrestrictedConnect;
				ArrayList connectList = this.m_connectList;
				while (connectList == null)
				{
				}
				while (connectList == null)
				{
				}
				connectList2 = this.m_connectList;
				if (connectList2 != null)
				{
				}
				bool flag;
				return flag;
			}
			object syncRoot = connectList2._syncRoot;
			while (syncRoot == null)
			{
			}
			while (syncRoot == null)
			{
			}
			object syncRoot2 = connectList2._syncRoot;
			if (syncRoot2 != null)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000258A8 File Offset: 0x00023AA8
		private static bool isSpecialSubsetCase(string regexToCheck, ArrayList permList)
		{
			if (regexToCheck != null)
			{
			}
			string text2;
			string text = global::System.Text.RegularExpressions.Regex.Escape(text2);
			string text3 = global::System.Text.RegularExpressions.Regex.Escape(text2);
			int num;
			while (num != 0)
			{
			}
			long num2 = 0L;
			if (regexToCheck != null)
			{
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000258F0 File Offset: 0x00023AF0
		public override IPermission Union(IPermission target)
		{
			if (target == null || this.m_noRestriction)
			{
			}
			bool unrestrictedConnect = this.m_UnrestrictedConnect;
			if (unrestrictedConnect || unrestrictedConnect)
			{
				int num = 1;
				this.m_UnrestrictedConnect = num != 0;
				bool unrestrictedAccept = this.m_UnrestrictedAccept;
				if (!unrestrictedAccept && !unrestrictedAccept)
				{
					goto IL_0045;
				}
				int num2 = 1;
				this.m_UnrestrictedAccept = num2 != 0;
			}
			if (this == null)
			{
				ArrayList connectList = this.m_connectList;
				if (this.m_connectList != null)
				{
				}
				if (this.m_connectList != null)
				{
				}
				long num3 = 0L;
				ArrayList connectList2 = this.m_connectList;
				if (num3 == 0L || connectList2 != null)
				{
				}
				if (connectList2 != null)
				{
				}
				ArrayList connectList3 = this.m_connectList;
				goto IL_008F;
			}
			this.m_connectList = this;
			IL_0045:
			if (this != null)
			{
				this.m_acceptList = this;
				throw new InvalidCastException();
			}
			IL_008F:
			ArrayList acceptList = this.m_acceptList;
			if (this.m_acceptList != null)
			{
			}
			if (this.m_acceptList != null)
			{
			}
			long num4 = 0L;
			ArrayList acceptList2 = this.m_acceptList;
			if (num4 == 0L || acceptList2 != null)
			{
			}
			if (acceptList2 != null)
			{
			}
			ArrayList acceptList3 = this.m_acceptList;
			string @string = SR.GetString("Cannot cast target permission type.");
			throw new InvalidCastException();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000259D8 File Offset: 0x00023BD8
		public override IPermission Intersect(IPermission target)
		{
			/*
An exception occurred when decompiling this method (06000B76)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.IPermission System.Net.WebPermission::Intersect(System.Security.IPermission)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0094:
	stloc:string(var_8_9E, call:string(SR::GetString, ldstr:string("Cannot cast target permission type.")))
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

		// Token: 0x06000B77 RID: 2935 RVA: 0x00025A84 File Offset: 0x00023C84
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement == null)
			{
				return;
			}
			bool flag = securityElement.tag.Equals("IPermission");
			if (securityElement.Attribute("class") == null)
			{
				return;
			}
			Type type = base.GetType();
			int num;
			if (securityElement.Attribute("Unrestricted") != null && num == 0)
			{
				int num2 = 1;
				this.m_noRestriction = num2 != 0;
				return;
			}
			SecurityElement securityElement2 = securityElement.SearchForChildByTag("ConnectAccess");
			if (securityElement2 != null)
			{
				ArrayList children = securityElement2.children;
				return;
			}
			SecurityElement securityElement3 = securityElement.SearchForChildByTag("AcceptAccess");
			if (securityElement3 != null)
			{
				ArrayList children2 = securityElement3.children;
				return;
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00025C18 File Offset: 0x00023E18
		public override SecurityElement ToXml()
		{
			Type type = base.GetType();
			Type type2 = base.GetType();
			if (this.m_noRestriction)
			{
			}
			if (!this.m_UnrestrictedConnect)
			{
				ArrayList connectList = this.m_connectList;
			}
			bool unrestrictedConnect = this.m_UnrestrictedConnect;
			if (unrestrictedConnect)
			{
				if (!unrestrictedConnect)
				{
				}
				string text = SecurityElement.Escape(".*");
				if (!this.m_UnrestrictedAccept)
				{
					ArrayList acceptList = this.m_acceptList;
				}
				bool unrestrictedAccept = this.m_UnrestrictedAccept;
				if (!unrestrictedAccept)
				{
					goto IL_0097;
				}
				if (!unrestrictedAccept)
				{
				}
				string text2 = SecurityElement.Escape(".*");
			}
			if ("true" != null)
			{
			}
			if ("true" != null)
			{
			}
			string text4;
			string text3 = global::System.Text.RegularExpressions.Regex.Escape(text4);
			string text6;
			string text5 = SecurityElement.Escape(text6);
			IL_0097:
			string text8;
			string text7 = SecurityElement.Escape(text8);
			long num = 0L;
			int num2 = 15;
			if (num2 == 0)
			{
				long value = num.m_value;
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				while (num2 == 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00025D10 File Offset: 0x00023F10
		private static bool isMatchedURI(object uriToCheck, ArrayList uriPatternList)
		{
			string text2;
			global::System.Text.RegularExpressions.Match match2;
			do
			{
				long num = 0L;
				if (uriToCheck != null)
				{
				}
				Type type = uriToCheck.GetType();
				Type type2 = uriToCheck.GetType();
				bool flag = type == type2;
				if (num != 0L)
				{
					if (uriToCheck != null)
					{
					}
					int num2;
					while (num2 != 0)
					{
					}
				}
				if (num == 0L)
				{
				}
				global::System.Text.RegularExpressions.Regex regex;
				string text;
				global::System.Text.RegularExpressions.Match match = regex.Match(text);
				if (match != null && match.<Index>k__BackingField == 0)
				{
					int <Length>k__BackingField = match.<Length>k__BackingField;
					int stringLength = text._stringLength;
				}
				while (num != 0L)
				{
				}
				global::System.Text.RegularExpressions.Regex regex2;
				match2 = regex2.Match(text2);
				while (match2 == null)
				{
				}
			}
			while (match2.<Index>k__BackingField != 0);
			int <Length>k__BackingField2 = match2.<Length>k__BackingField;
			int stringLength2 = text2._stringLength;
			long num3 = 0L;
			if (uriToCheck == null || stringLength2 != 0)
			{
			}
			if (num3 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00025DDC File Offset: 0x00023FDC
		private static void intersectList(ArrayList A, ArrayList B, ArrayList result)
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00025F6C File Offset: 0x0002416C
		private static object intersectPair(object L, object R, [Out] bool isUri)
		{
			long num = 0L;
			if (L == null)
			{
				return "(?=(";
			}
			long num2 = 0L;
			if (true)
			{
				if (L != null)
				{
				}
				global::System.Text.RegularExpressions.Match match;
				if (match == null || match.<Index>k__BackingField != 0)
				{
					goto IL_00A9;
				}
				int <Length>k__BackingField = match.<Length>k__BackingField;
			}
			if (L != null)
			{
			}
			long num3 = 0L;
			while (num2 == 0L)
			{
			}
			while (num == 0L)
			{
			}
			if (("(?=(" == null || "(?=(" != null) && (num == 0L || num != 0L) && ("))(" == null || "))(" != null) && (num2 == 0L || num2 != 0L) && (")" == null || ")" != null))
			{
				string text;
				if (num3 == 0L || text != null)
				{
				}
				global::System.Text.RegularExpressions.Regex regex;
				global::System.Text.RegularExpressions.Match match2 = regex.Match(text);
				if (match2 != null && match2.<Index>k__BackingField == 0)
				{
					int <Length>k__BackingField2 = match2.<Length>k__BackingField;
					int stringLength = text._stringLength;
				}
			}
			IL_00A9:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040009EF RID: 2543
		private bool m_noRestriction;

		// Token: 0x040009F0 RID: 2544
		[OptionalField]
		private bool m_UnrestrictedConnect;

		// Token: 0x040009F1 RID: 2545
		[OptionalField]
		private bool m_UnrestrictedAccept;

		// Token: 0x040009F2 RID: 2546
		private ArrayList m_connectList;

		// Token: 0x040009F3 RID: 2547
		private ArrayList m_acceptList;

		// Token: 0x040009F4 RID: 2548
		internal const string MatchAll = ".*";

		// Token: 0x040009F5 RID: 2549
		private static global::System.Text.RegularExpressions.Regex s_MatchAllRegex;
	}
}
