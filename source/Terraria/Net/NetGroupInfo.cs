using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Net
{
	// Token: 0x020006A1 RID: 1697
	public class NetGroupInfo
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x000021DB File Offset: 0x000003DB
		public NetGroupInfo()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00226110 File Offset: 0x00224310
		public string ComposeInfo()
		{
			List<NetGroupInfo.INetGroupInfoProvider> infoProviders = this._infoProviders;
			if (this._separatorBetweenIdAndInfo != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0022615C File Offset: 0x0022435C
		public Dictionary<NetGroupInfo.InfoProviderId, string> DecomposeInfo(string info)
		{
			/*
An exception occurred when decompiling this method (06003892)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<Terraria.Net.NetGroupInfo/InfoProviderId,System.String> Terraria.Net.NetGroupInfo::DecomposeInfo(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_1_08, ldfld:string[](NetGroupInfo::_separatorBetweenInfos, ldloc:NetGroupInfo(this)))
	stloc:string[](var_5_11, ldfld:string[](NetGroupInfo::_separatorBetweenIdAndInfo, ldloc:NetGroupInfo(this)))
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

		// Token: 0x06003893 RID: 14483 RVA: 0x0022617C File Offset: 0x0022437C
		private string ConvertToSafeInfo(string text)
		{
			if (!true)
			{
			}
			return Uri.EscapeDataString(text);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00226194 File Offset: 0x00224394
		private string ConvertFromSafeInfo(string text)
		{
			if (!true)
			{
			}
			return Uri.UnescapeDataString(text);
		}

		// Token: 0x04007948 RID: 31048
		private readonly string[] _separatorBetweenInfos;

		// Token: 0x04007949 RID: 31049
		private readonly string[] _separatorBetweenIdAndInfo;

		// Token: 0x0400794A RID: 31050
		private List<NetGroupInfo.INetGroupInfoProvider> _infoProviders;

		// Token: 0x020006A2 RID: 1698
		public enum InfoProviderId
		{
			// Token: 0x0400794C RID: 31052
			IPAddress,
			// Token: 0x0400794D RID: 31053
			Steam
		}

		// Token: 0x020006A3 RID: 1699
		private interface INetGroupInfoProvider
		{
			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06003895 RID: 14485
			NetGroupInfo.InfoProviderId Id { get; }

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06003896 RID: 14486
			bool HasValidInfo { get; }

			// Token: 0x06003897 RID: 14487
			string ProvideInfoNeededToJoin();
		}

		// Token: 0x020006A4 RID: 1700
		private class IPAddressInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06003898 RID: 14488 RVA: 0x002261AC File Offset: 0x002243AC
			public NetGroupInfo.InfoProviderId Id
			{
				get
				{
				}
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06003899 RID: 14489 RVA: 0x002261BC File Offset: 0x002243BC
			public bool HasValidInfo
			{
				get
				{
				}
			}

			// Token: 0x0600389A RID: 14490 RVA: 0x002261CC File Offset: 0x002243CC
			public string ProvideInfoNeededToJoin()
			{
				return "";
			}

			// Token: 0x0600389B RID: 14491 RVA: 0x002261E0 File Offset: 0x002243E0
			public IPAddressInfoProvider()
			{
			}
		}

		// Token: 0x020006A5 RID: 1701
		private class SteamLobbyInfoProvider : NetGroupInfo.INetGroupInfoProvider
		{
			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x0600389C RID: 14492 RVA: 0x002261F4 File Offset: 0x002243F4
			public NetGroupInfo.InfoProviderId Id
			{
				get
				{
					return NetGroupInfo.InfoProviderId.Steam;
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x0600389D RID: 14493 RVA: 0x00226204 File Offset: 0x00224404
			public bool HasValidInfo
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600389D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Net.NetGroupInfo/SteamLobbyInfoProvider::get_HasValidInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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
			}

			// Token: 0x0600389E RID: 14494 RVA: 0x00226214 File Offset: 0x00224414
			public string ProvideInfoNeededToJoin()
			{
				if (!true)
				{
				}
				string text;
				return text;
			}

			// Token: 0x0600389F RID: 14495 RVA: 0x00226228 File Offset: 0x00224428
			public SteamLobbyInfoProvider()
			{
			}
		}
	}
}
