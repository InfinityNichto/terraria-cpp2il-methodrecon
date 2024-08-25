using System;
using System.Collections;
using System.Globalization;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x02000344 RID: 836
	internal class ConfigHandler : SmallXmlParser.IContentHandler
	{
		// Token: 0x06001BFA RID: 7162 RVA: 0x0003C6E8 File Offset: 0x0003A8E8
		public ConfigHandler(bool onlyDelayedChannels)
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0003C708 File Offset: 0x0003A908
		private void ValidatePath(string element, params string[] paths)
		{
			bool flag = this.CheckPath(element);
			string text = "Element " + element + " not allowed in this context";
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0003C730 File Offset: 0x0003A930
		private bool CheckPath(string path)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = this.currentXmlPath;
			return path == text;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0003C758 File Offset: 0x0003A958
		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0003C768 File Offset: 0x0003A968
		public void OnProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0003C778 File Offset: 0x0003A978
		public void OnIgnorableWhitespace(string s)
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0003C788 File Offset: 0x0003A988
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			bool flag = this.currentXmlPath.StartsWith("/configuration/system.runtime.remoting");
			this.ParseElement(name, attrs);
			string text = this.currentXmlPath + "/" + name;
			this.currentXmlPath = text;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		public void ParseElement(string name, SmallXmlParser.IAttrList attrs)
		{
			if (this.currentProviderData != null)
			{
				this.ReadCustomProviderData(name, attrs);
				return;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			bool flag = name == "channel";
			if ("channels" == null || "channels" != null)
			{
				int num2 = this.currentXmlPath.IndexOf("application");
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0003CB94 File Offset: 0x0003AD94
		public void OnEndElement(string name)
		{
			if (this.currentProviderData == null || this.currentProviderData == null)
			{
			}
			string text = this.currentXmlPath;
			int stringLength = name._stringLength;
			int stringLength2 = text._stringLength;
			string text2;
			this.currentXmlPath = text2;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
		private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
		{
			Stack stack = this.currentProviderData;
			if (stack != null)
			{
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0003CC0C File Offset: 0x0003AE0C
		private void ReadLifetine(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0003CC2C File Offset: 0x0003AE2C
		private TimeSpan ParseTime(string s)
		{
			bool flag = s == "";
			if (s != null)
			{
				int num;
				string text = s.Substring(num);
				long num2 = 0L;
				double num3 = double.Parse(s.Substring((int)num2, num));
				TimeSpan timeSpan = TimeSpan.FromDays(num3);
				bool flag2 = "S" == "H";
				if ("H" == null)
				{
				}
				TimeSpan timeSpan2 = TimeSpan.FromHours(num3);
				return "H";
			}
			return "MS";
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0003CD24 File Offset: 0x0003AF24
		private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			/*
An exception occurred when decompiling this method (06001C07)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.ProviderData System.Runtime.Remoting.ConfigHandler::ReadProvider(System.String,Mono.Xml.SmallXmlParser/IAttrList,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, call:bool(string::op_Equality, ldloc:string(name), ldstr:string("provider")))
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

		// Token: 0x06001C08 RID: 7176 RVA: 0x0003CD58 File Offset: 0x0003AF58
		private void ReadClientActivated(SmallXmlParser.IAttrList attrs)
		{
			string text;
			do
			{
				text = this.currentClientUrl;
			}
			while (text == null);
			bool flag = text == "";
			ArrayList arrayList = this.typeEntries;
			string text2 = this.currentClientUrl;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0003CD8C File Offset: 0x0003AF8C
		private void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
		{
			ArrayList arrayList = this.typeEntries;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
		{
			ArrayList arrayList = this.typeEntries;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0003CDB4 File Offset: 0x0003AFB4
		private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
		{
			string text;
			bool flag = text == "SingleCall";
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0003CDD8 File Offset: 0x0003AFD8
		private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
		{
			string[] array;
			string text = array.Trim().Trim();
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
		private void ReadPreload(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0003CE18 File Offset: 0x0003B018
		private string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
		{
			/*
An exception occurred when decompiling this method (06001C0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.ConfigHandler::GetNotNull(Mono.Xml.SmallXmlParser/IAttrList,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:IAttrList[exp:bool](attrs)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0003CE28 File Offset: 0x0003B028
		private string ExtractAssembly(string type)
		{
			string text2;
			string text = text2.Trim();
			string text4;
			string text3 = text4.Trim();
			return text;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0003CE50 File Offset: 0x0003B050
		public void OnChars(string ch)
		{
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0003CE60 File Offset: 0x0003B060
		public void OnEndParsing(SmallXmlParser parser)
		{
			ArrayList arrayList = this.channelInstances;
			bool flag = this.onlyDelayedChannels;
			if (!true)
			{
			}
			if (this.appName != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			bool flag2 = this.onlyDelayedChannels;
			if (flag2)
			{
				return;
			}
			ArrayList arrayList2 = this.typeEntries;
			if (!flag2)
			{
			}
			RemotingConfiguration.RegisterTypes(arrayList2);
		}

		// Token: 0x04000E3F RID: 3647
		private ArrayList typeEntries;

		// Token: 0x04000E40 RID: 3648
		private ArrayList channelInstances;

		// Token: 0x04000E41 RID: 3649
		private ChannelData currentChannel;

		// Token: 0x04000E42 RID: 3650
		private Stack currentProviderData;

		// Token: 0x04000E43 RID: 3651
		private string currentClientUrl;

		// Token: 0x04000E44 RID: 3652
		private string appName;

		// Token: 0x04000E45 RID: 3653
		private string currentXmlPath = "";

		// Token: 0x04000E46 RID: 3654
		private bool onlyDelayedChannels;
	}
}
