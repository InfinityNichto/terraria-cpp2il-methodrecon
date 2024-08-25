using System;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020000F0 RID: 240
	public sealed class Oid
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x000158C8 File Offset: 0x00013AC8
		public Oid()
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000158DC File Offset: 0x00013ADC
		public Oid(string oid)
		{
			if (!true)
			{
			}
			this._value = 1;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000158FC File Offset: 0x00013AFC
		public Oid(string value, string friendlyName)
		{
			this._value = value;
			this._friendlyName = friendlyName;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00015920 File Offset: 0x00013B20
		public Oid(Oid oid)
		{
			do
			{
				base..ctor();
			}
			while (oid == null);
			string value = oid._value;
			this._value = value;
			OidGroup group = oid._group;
			this._group = group;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00015954 File Offset: 0x00013B54
		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			/*
An exception occurred when decompiling this method (06000576)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.Oid System.Security.Cryptography.Oid::FromOidValue(System.String,System.Security.Cryptography.OidGroup)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:string[exp:bool](var_0)))
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00015964 File Offset: 0x00013B64
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00015978 File Offset: 0x00013B78
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001598C File Offset: 0x00013B8C
		public string FriendlyName
		{
			get
			{
				while (this._friendlyName != null)
				{
				}
				string value = this._value;
				if (value != null)
				{
					OidGroup group = this._group;
					string text = Internal.Cryptography.OidLookup.ToFriendlyName(value, group, true);
					this._friendlyName = text;
					return text;
				}
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000159C8 File Offset: 0x00013BC8
		private Oid(string value, string friendlyName, OidGroup group)
		{
			this._value = value;
			this._friendlyName = friendlyName;
			this._group = group;
		}

		// Token: 0x04000459 RID: 1113
		private string _value;

		// Token: 0x0400045A RID: 1114
		private string _friendlyName;

		// Token: 0x0400045B RID: 1115
		private OidGroup _group;
	}
}
