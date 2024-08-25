using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x020000AD RID: 173
	[Serializable]
	public class XmlQualifiedName
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0001946C File Offset: 0x0001766C
		public XmlQualifiedName()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001947C File Offset: 0x0001767C
		public XmlQualifiedName(string name)
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001948C File Offset: 0x0001768C
		public XmlQualifiedName(string name, string ns)
		{
			if (ns == null)
			{
			}
			if (name == null)
			{
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000194A8 File Offset: 0x000176A8
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000194BC File Offset: 0x000176BC
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000194D0 File Offset: 0x000176D0
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060007A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlQualifiedName::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:int32(var_1_22, ldfld:int32(string::_stringLength, ldfld:string(XmlQualifiedName::name, ldloc:XmlQualifiedName(this))))
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00019500 File Offset: 0x00017700
		public bool IsEmpty
		{
			get
			{
				while (this.name._stringLength == 0)
				{
				}
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001951C File Offset: 0x0001771C
		public override string ToString()
		{
			string text = this.name;
			string text2 = this.ns;
			if (text2._stringLength != 0)
			{
				return text2 + ":" + text;
			}
			return text;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00019550 File Offset: 0x00017750
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			string text = this.name;
			string text2 = this.ns;
			bool flag;
			return flag;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00019578 File Offset: 0x00017778
		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			while (a == null)
			{
			}
			string text = a.name;
			string text2 = a.ns;
			bool flag;
			return flag;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000195A0 File Offset: 0x000177A0
		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000195B4 File Offset: 0x000177B4
		private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			MethodInfo method;
			Type type2;
			do
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				Type type;
				method = type.GetMethod("InternalMarvin32HashString", BindingFlags.Static | BindingFlags.NonPublic);
			}
			while (Delegate.CreateDelegate(type2, method) == null);
			throw new InvalidCastException();
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000195E8 File Offset: 0x000177E8
		private static bool IsRandomizedHashingDisabled()
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00003FFD File Offset: 0x000021FD
		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000195F8 File Offset: 0x000177F8
		internal void Init(string name, string ns)
		{
			this.name = name;
			this.ns = ns;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00019614 File Offset: 0x00017814
		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, [Out] string prefix)
		{
			/*
An exception occurred when decompiling this method (060007B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlQualifiedName System.Xml.XmlQualifiedName::Parse(System.String,System.Xml.IXmlNamespaceResolver,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldloc:string[exp:bool](s))
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x00019628 File Offset: 0x00017828
		// Note: this type is marked as 'beforefieldinit'.
		static XmlQualifiedName()
		{
		}

		// Token: 0x040003E1 RID: 993
		private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;

		// Token: 0x040003E2 RID: 994
		private string name;

		// Token: 0x040003E3 RID: 995
		private string ns;

		// Token: 0x040003E4 RID: 996
		[NonSerialized]
		private int hash;

		// Token: 0x040003E5 RID: 997
		public static readonly XmlQualifiedName Empty;

		// Token: 0x020000AE RID: 174
		private sealed class HashCodeOfStringDelegate : MulticastDelegate
		{
			// Token: 0x060007B3 RID: 1971 RVA: 0x00019638 File Offset: 0x00017838
			public HashCodeOfStringDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060007B4 RID: 1972 RVA: 0x0001968C File Offset: 0x0001788C
			public int Invoke(string s, int sLen, long additionalEntropy)
			{
				/*
An exception occurred when decompiling this method (060007B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.XmlQualifiedName/HashCodeOfStringDelegate::Invoke(System.String,System.Int32,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:HashCodeOfStringDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:HashCodeOfStringDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:HashCodeOfStringDelegate[exp:Delegate](this)))
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
	}
}
