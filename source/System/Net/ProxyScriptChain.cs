using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001F8 RID: 504
	internal class ProxyScriptChain : ProxyChain
	{
		// Token: 0x06000C6D RID: 3181 RVA: 0x00027AC0 File Offset: 0x00025CC0
		internal ProxyScriptChain(WebProxy proxy, global::System.Uri destination)
			: base(destination)
		{
			this.m_Proxy = proxy;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00027ADC File Offset: 0x00025CDC
		protected override bool GetNextProxy([Out] global::System.Uri proxy)
		{
			/*
An exception occurred when decompiling this method (06000C6E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ProxyScriptChain::GetNextProxy(System.Uri)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	stloc:WebProxy(var_6_45, ldfld:WebProxy(ProxyScriptChain::m_Proxy, ldloc:ProxyScriptChain(this)))
	stloc:Uri(var_7_4D, ldfld:Uri(ProxyChain::m_Destination, ldloc:ProxyScriptChain[exp:ProxyChain](this)))
	stloc:Uri(var_8_58, call:Uri(WebProxy::GetProxyAutoFailover, ldloc:WebProxy(var_6_45), ldloc:Uri(var_7_4D)))
	stfld:int32(ProxyScriptChain::m_CurrentIndex, ldloc:ProxyScriptChain(this), ldloc:int32(var_0_06))
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

		// Token: 0x06000C6F RID: 3183 RVA: 0x00027B4C File Offset: 0x00025D4C
		internal override void Abort()
		{
			if (this.m_Proxy.m_ScriptEngine != null)
			{
				return;
			}
		}

		// Token: 0x04000AAA RID: 2730
		private WebProxy m_Proxy;

		// Token: 0x04000AAB RID: 2731
		private global::System.Uri[] m_ScriptProxies;

		// Token: 0x04000AAC RID: 2732
		private int m_CurrentIndex;

		// Token: 0x04000AAD RID: 2733
		private int m_SyncStatus;
	}
}
