using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using Cpp2IlInjected;

namespace System.Security.Principal
{
	// Token: 0x0200032B RID: 811
	[ComVisible(true)]
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
	{
		// Token: 0x06001B59 RID: 7001 RVA: 0x0003AB60 File Offset: 0x00038D60
		public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
			this._type = type;
			this._account = acctType;
			this.SetToken(userToken);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0003AB84 File Offset: 0x00038D84
		public WindowsIdentity(SerializationInfo info, StreamingContext context)
		{
			this._info = info;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0003AB98 File Offset: 0x00038D98
		internal WindowsIdentity(ClaimsIdentity claimsIdentity, IntPtr userToken)
			: base(claimsIdentity)
		{
			long num = 0L;
			this.SetToken(num);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0003ABB8 File Offset: 0x00038DB8
		[ComVisible(false)]
		public void Dispose()
		{
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0003ABC8 File Offset: 0x00038DC8
		public static WindowsIdentity GetCurrent()
		{
			/*
An exception occurred when decompiling this method (06001B5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Principal.WindowsIdentity System.Security.Principal.WindowsIdentity::GetCurrent()

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

		// Token: 0x06001B5E RID: 7006 RVA: 0x0003ABD8 File Offset: 0x00038DD8
		public virtual WindowsImpersonationContext Impersonate()
		{
			/*
An exception occurred when decompiling this method (06001B5E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Principal.WindowsImpersonationContext System.Security.Principal.WindowsIdentity::Impersonate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(WindowsIdentity::_token, ldloc:WindowsIdentity(this)))
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override string AuthenticationType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0003ABEC File Offset: 0x00038DEC
		public override string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B60)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Principal.WindowsIdentity::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_0E, ldfld:native int(WindowsIdentity::_token, ldloc:WindowsIdentity(this)))
	stfld:string(WindowsIdentity::_name, ldloc:WindowsIdentity(this), ldloc:native int[exp:string](var_0_0E))
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

		// Token: 0x06001B61 RID: 7009 RVA: 0x0003AC10 File Offset: 0x00038E10
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			for (;;)
			{
				if (!true)
				{
				}
				string text;
				if (text != null)
				{
					break;
				}
				if ("Token-Name mismatch." != null)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			if ("m_type" == null)
			{
			}
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0003AC38 File Offset: 0x00038E38
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr token = this._token;
			string name = this._name;
			info.AddValue("m_name", name);
			string type = this._type;
			info.AddValue("m_type", type);
			WindowsAccountType account = this._account;
			bool authenticated = this._authenticated;
			info.AddValue("m_isAuthenticated", authenticated);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0003AC90 File Offset: 0x00038E90
		internal ClaimsIdentity CloneAsBase()
		{
			return base.Clone();
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		internal IntPtr GetTokenInternal()
		{
			return this._token;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0003ACB8 File Offset: 0x00038EB8
		private void SetToken(IntPtr token)
		{
			bool isUnix = Environment.IsUnix;
			string type = this._type;
			this._token = token;
			if (type == null)
			{
				this._type = "POSIX";
			}
			this._account = WindowsAccountType.System;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0000207A File Offset: 0x0000027A
		internal static IntPtr GetCurrentToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetTokenName(IntPtr token)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0003AD24 File Offset: 0x00038F24
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsIdentity()
		{
		}

		// Token: 0x04000DEE RID: 3566
		private IntPtr _token;

		// Token: 0x04000DEF RID: 3567
		private string _type;

		// Token: 0x04000DF0 RID: 3568
		private WindowsAccountType _account;

		// Token: 0x04000DF1 RID: 3569
		private bool _authenticated;

		// Token: 0x04000DF2 RID: 3570
		private string _name;

		// Token: 0x04000DF3 RID: 3571
		private SerializationInfo _info;

		// Token: 0x04000DF4 RID: 3572
		private static IntPtr invalidWindows;
	}
}
