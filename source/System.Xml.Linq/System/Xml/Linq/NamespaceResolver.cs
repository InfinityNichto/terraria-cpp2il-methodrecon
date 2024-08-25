using System;

namespace System.Xml.Linq
{
	// Token: 0x02000012 RID: 18
	internal struct NamespaceResolver
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00003560 File Offset: 0x00001760
		public void PushScope()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003570 File Offset: 0x00001770
		public void PopScope()
		{
			NamespaceResolver.NamespaceDeclaration declaration = this._declaration;
			if (declaration != null)
			{
				NamespaceResolver.NamespaceDeclaration prev = declaration.prev;
				int scope = prev.scope;
				NamespaceResolver.NamespaceDeclaration prev2 = prev.prev;
				declaration.prev = prev2;
				return;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000035B0 File Offset: 0x000017B0
		public void Add(string prefix, XNamespace ns)
		{
			NamespaceResolver.NamespaceDeclaration declaration = this._declaration;
			if (declaration != null)
			{
				NamespaceResolver.NamespaceDeclaration prev = declaration.prev;
				return;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000035D0 File Offset: 0x000017D0
		public void AddFirst(string prefix, XNamespace ns)
		{
			NamespaceResolver.NamespaceDeclaration declaration = this._declaration;
			if (declaration != null)
			{
				NamespaceResolver.NamespaceDeclaration prev = declaration.prev;
				return;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000035F0 File Offset: 0x000017F0
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			NamespaceResolver.NamespaceDeclaration rover = this._rover;
			if (rover != null)
			{
				XNamespace ns2 = rover.ns;
			}
			NamespaceResolver.NamespaceDeclaration declaration = this._declaration;
			NamespaceResolver.NamespaceDeclaration prev;
			if (declaration != null)
			{
				prev = declaration.prev;
				XNamespace ns3 = prev.ns;
				string prefix = declaration.prev.prefix;
				string prefix2 = prev.prefix;
				bool flag = prefix != prefix2;
				int stringLength = prev.prefix._stringLength;
				NamespaceResolver.NamespaceDeclaration declaration2 = this._declaration;
			}
			this._rover = prev;
			return prev.prefix;
		}

		// Token: 0x04000026 RID: 38
		private int _scope;

		// Token: 0x04000027 RID: 39
		private NamespaceResolver.NamespaceDeclaration _declaration;

		// Token: 0x04000028 RID: 40
		private NamespaceResolver.NamespaceDeclaration _rover;

		// Token: 0x02000013 RID: 19
		private class NamespaceDeclaration
		{
			// Token: 0x0600008B RID: 139 RVA: 0x0000366C File Offset: 0x0000186C
			public NamespaceDeclaration()
			{
			}

			// Token: 0x04000029 RID: 41
			public string prefix;

			// Token: 0x0400002A RID: 42
			public XNamespace ns;

			// Token: 0x0400002B RID: 43
			public int scope;

			// Token: 0x0400002C RID: 44
			public NamespaceResolver.NamespaceDeclaration prev;
		}
	}
}
