using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x02000006 RID: 6
	public abstract class XContainer : XNode
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002414 File Offset: 0x00000614
		internal XContainer()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002428 File Offset: 0x00000628
		internal XContainer(XContainer other)
		{
			if (other == null)
			{
				throw new InvalidCastException();
			}
			object obj = other.content;
			if (obj != null)
			{
				object obj2 = other.content;
				return;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002460 File Offset: 0x00000660
		public XNode LastNode
		{
			get
			{
				do
				{
					if (this.content != null)
					{
					}
				}
				while (this.content == null);
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002484 File Offset: 0x00000684
		public void Add(object content)
		{
			bool flag = base.SkipNotify();
			this.AddContentSkipNotify(content);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000024DC File Offset: 0x000006DC
		public IEnumerable<XNode> Nodes()
		{
			/*
An exception occurred when decompiling this method (0600001C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XNode> System.Xml.Linq.XContainer::Nodes()

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

		// Token: 0x0600001D RID: 29 RVA: 0x000024F0 File Offset: 0x000006F0
		public void RemoveNodes()
		{
			bool flag = base.SkipNotify();
			this.RemoveNodesSkipNotify();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002544 File Offset: 0x00000744
		internal virtual void AddAttribute(XAttribute a)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002554 File Offset: 0x00000754
		internal virtual void AddAttributeSkipNotify(XAttribute a)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002564 File Offset: 0x00000764
		internal void AddContentSkipNotify(object content)
		{
			if (content == null)
			{
				return;
			}
			long num;
			if (content != null)
			{
				num = 0L;
				return;
			}
			if (num != 0L)
			{
				return;
			}
			string stringValue = XContainer.GetStringValue(num);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025AC File Offset: 0x000007AC
		internal void AddNode(XNode n)
		{
			if (n.parent != null)
			{
				return;
			}
			if (this.parent != null)
			{
				return;
			}
			this.ConvertTextToNode();
			this.AppendNode(n);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025D8 File Offset: 0x000007D8
		internal void AddNodeSkipNotify(XNode n)
		{
			while (n.parent == null)
			{
				if (this.parent == null)
				{
					this.ConvertTextToNode();
					this.AppendNodeSkipNotify(n);
					return;
				}
				if (this.parent == null)
				{
					return;
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000260C File Offset: 0x0000080C
		internal void AddString(string s)
		{
			int stringLength = s._stringLength;
			if (this.content != null)
			{
				this.ConvertTextToNode();
				if (this.content != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002654 File Offset: 0x00000854
		internal void AddStringSkipNotify(string s)
		{
			if (this.content != null)
			{
				int stringLength = s._stringLength;
				return;
			}
			this.content = s;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000268C File Offset: 0x0000088C
		internal void AppendNode(XNode n)
		{
			XContainer parent;
			do
			{
				if (!true)
				{
				}
				parent = n.parent;
			}
			while (parent != null);
			this.AppendNodeSkipNotify(n);
			if (parent == null)
			{
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026B4 File Offset: 0x000008B4
		internal void AppendNodeSkipNotify(XNode n)
		{
			n.parent = this;
			if (this.content != null)
			{
				return;
			}
			this.content = n;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000026E0 File Offset: 0x000008E0
		internal override void AppendText(StringBuilder sb)
		{
			if (this.content != null)
			{
				object obj = this.content;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002704 File Offset: 0x00000904
		internal void ConvertTextToNode()
		{
			if (this.content != null)
			{
				return;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000271C File Offset: 0x0000091C
		internal static string GetStringValue(object value)
		{
			return XmlConvert.ToString((double)16777216);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002794 File Offset: 0x00000994
		internal void RemoveNode(XNode n)
		{
			if (!true)
			{
			}
			XContainer parent = n.parent;
			object obj = this.content;
			if (obj != null)
			{
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000027D0 File Offset: 0x000009D0
		private void RemoveNodesSkipNotify()
		{
			if (this.content != null)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000027E8 File Offset: 0x000009E8
		internal virtual void ValidateNode(XNode node, XNode previous)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027F8 File Offset: 0x000009F8
		internal virtual void ValidateString(string s)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002808 File Offset: 0x00000A08
		internal void WriteContentTo(XmlWriter writer)
		{
			if (this.content != null)
			{
				object obj = this.content;
			}
		}

		// Token: 0x04000005 RID: 5
		internal object content;

		// Token: 0x02000007 RID: 7
		[CompilerGenerated]
		private sealed class <Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
		{
			// Token: 0x0600002F RID: 47 RVA: 0x0000282C File Offset: 0x00000A2C
			[DebuggerHidden]
			public <Nodes>d__18(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.<>l__initialThreadId = currentManagedThreadId;
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002858 File Offset: 0x00000A58
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00002868 File Offset: 0x00000A68
			private bool MoveNext()
			{
				int num = this.<>1__state;
				XContainer xcontainer = this.<>4__this;
				if (num == 0)
				{
					this.<>1__state = num;
					XNode lastNode = xcontainer.LastNode;
					this.<n>5__2 = lastNode;
					XNode xnode;
					if (lastNode == null)
					{
						xnode = this.<n>5__2;
						XContainer parent = xnode.parent;
					}
					XNode next = xnode.next;
					this.<>1__state = 1;
					this.<n>5__2 = next;
					this.<>2__current = next;
					return true;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000032 RID: 50 RVA: 0x000028D0 File Offset: 0x00000AD0
			XNode IEnumerator<XNode>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002367 File Offset: 0x00000567
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000034 RID: 52 RVA: 0x000028E4 File Offset: 0x00000AE4
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (06000034)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.Linq.XContainer/<Nodes>d__18::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XNode(var_0_06, ldfld:XNode('<Nodes>d__18'::<>2__current, ldloc:'<Nodes>d__18'(this)))
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

			// Token: 0x06000035 RID: 53 RVA: 0x000028F8 File Offset: 0x00000AF8
			[DebuggerHidden]
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06000035)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<System.Xml.Linq.XNode> System.Xml.Linq.XContainer/<Nodes>d__18::System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<Nodes>d__18'::<>1__state, ldloc:'<Nodes>d__18'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<Nodes>d__18'::<>l__initialThreadId, ldloc:'<Nodes>d__18'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:int32(var_5_1E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:XContainer(var_6_26, ldfld:XContainer('<Nodes>d__18'::<>4__this, ldloc:'<Nodes>d__18'(this)))
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

			// Token: 0x06000036 RID: 54 RVA: 0x0000292C File Offset: 0x00000B2C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06000036)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Xml.Linq.XContainer/<Nodes>d__18::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class System.Xml.Linq.XNode>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class System.Xml.Linq.XNode>]('<Nodes>d__18'::System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator, ldloc:'<Nodes>d__18'(this)))
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

			// Token: 0x04000006 RID: 6
			private int <>1__state;

			// Token: 0x04000007 RID: 7
			private XNode <>2__current;

			// Token: 0x04000008 RID: 8
			private int <>l__initialThreadId;

			// Token: 0x04000009 RID: 9
			public XContainer <>4__this;

			// Token: 0x0400000A RID: 10
			private XNode <n>5__2;
		}
	}
}
