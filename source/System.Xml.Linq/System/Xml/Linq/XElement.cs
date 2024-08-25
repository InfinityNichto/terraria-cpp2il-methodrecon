using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x0200000B RID: 11
	[XmlTypeConvertor("ConvertForAssignment")]
	[XmlSchemaProvider(null, IsAny = true)]
	public class XElement : XContainer
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public XElement(XName name)
		{
			do
			{
				base..ctor();
			}
			while (name == null);
			this.name = name;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public XElement(XElement other)
			: base(other)
		{
			XName xname = other.name;
			this.name = xname;
			XAttribute xattribute = other.lastAttr;
			if (xattribute != null)
			{
				XAttribute next = xattribute.next;
				XAttribute xattribute2 = this.lastAttr;
				if (xattribute2 != null)
				{
					XAttribute next2 = xattribute2.next;
					return;
				}
				XAttribute xattribute3 = other.lastAttr;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002D48 File Offset: 0x00000F48
		public XElement(XStreamingElement other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
			XName xname = other.name;
			this.name = xname;
			object content = other.content;
			base.AddContentSkipNotify(content);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002D7C File Offset: 0x00000F7C
		public bool IsEmpty
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600005A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Linq.XElement::get_IsEmpty()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(XContainer::content, ldloc:XElement[exp:XContainer](this)))
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002D90 File Offset: 0x00000F90
		public XName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Element;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002DB4 File Offset: 0x00000FB4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public string Value
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600005D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Linq.XElement::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(StringBuilderCache::Release, call:StringBuilder(StringBuilderCache::Acquire, ldc.i4:int32(16)))
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
			set
			{
				while (value == null)
				{
				}
				base.RemoveNodes();
				base.Add(value);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public XAttribute Attribute(XName name)
		{
			XAttribute xattribute = this.lastAttr;
			if (xattribute != null)
			{
				XName xname = xattribute.next.name;
				return;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002E18 File Offset: 0x00001018
		public IEnumerable<XAttribute> Attributes()
		{
			IEnumerable<XAttribute> enumerable;
			return enumerable;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002E28 File Offset: 0x00001028
		public string GetPrefixOfNamespace(XNamespace ns)
		{
			while (ns == null)
			{
			}
			string namespaceName = ns._namespaceName;
			XAttribute xattribute = this.lastAttr;
			string namespaceOfPrefixInScope;
			if (xattribute != null)
			{
				XAttribute next = xattribute.next;
				bool isNamespaceDeclaration = next.IsNamespaceDeclaration;
				bool flag = next.value == namespaceName;
				XName xname = next.name;
				if (xname._ns._namespaceName._stringLength != 0)
				{
					string localName = xname._localName;
					namespaceOfPrefixInScope = this.GetNamespaceOfPrefixInScope(localName, this);
					if (namespaceOfPrefixInScope == null)
					{
						return next.name._localName;
					}
				}
				XAttribute xattribute2 = this.lastAttr;
			}
			if (this.parent != null)
			{
				while (this != null)
				{
				}
			}
			return namespaceOfPrefixInScope;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002EC4 File Offset: 0x000010C4
		public override void WriteTo(XmlWriter writer)
		{
			while (writer == null)
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002ED4 File Offset: 0x000010D4
		internal override void AddAttribute(XAttribute a)
		{
			XAttribute xattribute = this.lastAttr;
			if (xattribute != null)
			{
				XName xname = a.name;
				XAttribute next = xattribute.next;
				XName xname2 = next.name;
				return;
			}
			if (a.parent != null)
			{
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002F0C File Offset: 0x0000110C
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			XAttribute xattribute = this.lastAttr;
			if (xattribute != null)
			{
				XName xname = a.name;
				XAttribute next = xattribute.next;
				XName xname2 = next.name;
				return;
			}
			XAttribute xattribute2;
			if (a.parent != null)
			{
				xattribute2 = this.lastAttr;
			}
			if (xattribute2 != null)
			{
				XAttribute next2 = xattribute2.next;
				return;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002F5C File Offset: 0x0000115C
		internal void AppendAttribute(XAttribute a)
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (a.parent != null);
			a.parent = this;
			XAttribute xattribute = this.lastAttr;
			if (xattribute != null)
			{
				XAttribute next = xattribute.next;
				a.next = next;
				return;
			}
			this.lastAttr = a;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002FA4 File Offset: 0x000011A4
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
			a.parent = this;
			XAttribute xattribute = this.lastAttr;
			if (xattribute != null)
			{
				XAttribute next = xattribute.next;
				a.next = next;
				return;
			}
			this.lastAttr = a;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002367 File Offset: 0x00000567
		internal override XNode CloneNode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002FD8 File Offset: 0x000011D8
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			/*
An exception occurred when decompiling this method (06000068)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XAttribute> System.Xml.Linq.XElement::GetAttributes(System.Xml.Linq.XName)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Environment::get_CurrentManagedThreadId))
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

		// Token: 0x06000069 RID: 105 RVA: 0x00002FEC File Offset: 0x000011EC
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			XAttribute xattribute = this.lastAttr;
			XAttribute next;
			if (xattribute != null)
			{
				next = xattribute.next;
				bool isNamespaceDeclaration = next.IsNamespaceDeclaration;
				bool flag = next.name._localName == prefix;
				XAttribute xattribute2 = this.lastAttr;
			}
			if (this.parent != null)
			{
			}
			return next.value;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003040 File Offset: 0x00001240
		internal override void ValidateNode(XNode node, XNode previous)
		{
			if (node != null)
			{
			}
		}

		// Token: 0x04000013 RID: 19
		internal XName name;

		// Token: 0x04000014 RID: 20
		internal XAttribute lastAttr;

		// Token: 0x0200000C RID: 12
		[CompilerGenerated]
		private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
		{
			// Token: 0x0600006B RID: 107 RVA: 0x00003054 File Offset: 0x00001254
			[DebuggerHidden]
			public <GetAttributes>d__116(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.<>l__initialThreadId = currentManagedThreadId;
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00003080 File Offset: 0x00001280
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00003090 File Offset: 0x00001290
			private bool MoveNext()
			{
				XElement xelement;
				XAttribute lastAttr;
				do
				{
					int num = this.<>1__state;
					xelement = this.<>4__this;
					if (num != 0)
					{
						goto IL_0060;
					}
					this.<>1__state = num;
					lastAttr = xelement.lastAttr;
					this.<a>5__2 = lastAttr;
				}
				while (lastAttr != null);
				XAttribute next = this.<a>5__2.next;
				XName xname = this.name;
				this.<a>5__2 = next;
				if (xname != null)
				{
					XName xname2 = next.name;
					XContainer parent = next.parent;
					XAttribute lastAttr2 = xelement.lastAttr;
				}
				IL_0060:
				this.<>2__current = next;
				this.<>1__state = 1;
				return true;
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600006E RID: 110 RVA: 0x0000310C File Offset: 0x0000130C
			XAttribute IEnumerator<XAttribute>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00002367 File Offset: 0x00000567
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00003120 File Offset: 0x00001320
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (06000070)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Linq.XElement/<GetAttributes>d__116::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XAttribute(var_0_06, ldfld:XAttribute('<GetAttributes>d__116'::<>2__current, ldloc:'<GetAttributes>d__116'(this)))
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

			// Token: 0x06000071 RID: 113 RVA: 0x00003134 File Offset: 0x00001334
			[DebuggerHidden]
			IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06000071)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<System.Xml.Linq.XAttribute> System.Xml.Linq.XElement/<GetAttributes>d__116::System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<GetAttributes>d__116'::<>1__state, ldloc:'<GetAttributes>d__116'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<GetAttributes>d__116'::<>l__initialThreadId, ldloc:'<GetAttributes>d__116'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:int32(var_5_1E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:XElement(var_6_26, ldfld:XElement('<GetAttributes>d__116'::<>4__this, ldloc:'<GetAttributes>d__116'(this)))
	stloc:XName(var_7_2E, ldfld:XName('<GetAttributes>d__116'::<>3__name, ldloc:'<GetAttributes>d__116'(this)))
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

			// Token: 0x06000072 RID: 114 RVA: 0x00003170 File Offset: 0x00001370
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06000072)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Xml.Linq.XElement/<GetAttributes>d__116::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class System.Xml.Linq.XAttribute>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class System.Xml.Linq.XAttribute>]('<GetAttributes>d__116'::System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator, ldloc:'<GetAttributes>d__116'(this)))
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

			// Token: 0x04000015 RID: 21
			private int <>1__state;

			// Token: 0x04000016 RID: 22
			private XAttribute <>2__current;

			// Token: 0x04000017 RID: 23
			private int <>l__initialThreadId;

			// Token: 0x04000018 RID: 24
			public XElement <>4__this;

			// Token: 0x04000019 RID: 25
			private XName name;

			// Token: 0x0400001A RID: 26
			public XName <>3__name;

			// Token: 0x0400001B RID: 27
			private XAttribute <a>5__2;
		}
	}
}
