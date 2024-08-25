using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000076 RID: 118
	public class XmlNamedNodeMap : IEnumerable
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00013DD0 File Offset: 0x00011FD0
		internal XmlNamedNodeMap(XmlNode parent)
		{
			this.parent = parent;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00013DEC File Offset: 0x00011FEC
		public virtual XmlNode GetNamedItem(string name)
		{
			object obj;
			do
			{
				int num = this.FindNodeOffset(name);
			}
			while (obj == null);
			throw new InvalidCastException();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00013E0C File Offset: 0x0001200C
		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			if (node != null)
			{
				return;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00013E20 File Offset: 0x00012020
		public virtual int Count
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00013E30 File Offset: 0x00012030
		public virtual IEnumerator GetEnumerator()
		{
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00013E40 File Offset: 0x00012040
		internal int FindNodeOffset(string name)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00013E54 File Offset: 0x00012054
		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00013E68 File Offset: 0x00012068
		internal virtual XmlNode AddNode(XmlNode node)
		{
			return node;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00013EA0 File Offset: 0x000120A0
		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			XmlNode xmlNode = this.parent;
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(node, xmlNode);
			if (insertEventArgsForLoad != null)
			{
			}
			XmlNode xmlNode2 = this.parent;
			if (insertEventArgsForLoad != null)
			{
			}
			return node;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00013ECC File Offset: 0x000120CC
		internal virtual XmlNode RemoveNodeAt(int i)
		{
			if (this.parent != null)
			{
				XmlNode xmlNode = this.parent;
				return this.parent;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00003FFD File Offset: 0x000021FD
		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00013EF4 File Offset: 0x000120F4
		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			return node;
		}

		// Token: 0x040002ED RID: 749
		internal XmlNode parent;

		// Token: 0x040002EE RID: 750
		internal XmlNamedNodeMap.SmallXmlNodeList nodes;

		// Token: 0x02000077 RID: 119
		internal struct SmallXmlNodeList
		{
			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00013F2C File Offset: 0x0001212C
			public int Count
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x17000173 RID: 371
			public object this[int index]
			{
				get
				{
					/*
An exception occurred when decompiling this method (060005B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Xml.XmlNamedNodeMap/SmallXmlNodeList::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:int32[exp:bool](index))
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

			// Token: 0x060005BA RID: 1466 RVA: 0x00013F4C File Offset: 0x0001214C
			public void Add(object value)
			{
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x00013F60 File Offset: 0x00012160
			public void RemoveAt(int index)
			{
				while (index != 0)
				{
				}
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x00013F74 File Offset: 0x00012174
			public void Insert(int index, object value)
			{
				while (index != 0)
				{
				}
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x00003FFD File Offset: 0x000021FD
			public IEnumerator GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040002EF RID: 751
			private object field;

			// Token: 0x02000078 RID: 120
			private class SingleObjectEnumerator : IEnumerator
			{
				// Token: 0x060005BE RID: 1470 RVA: 0x00010C2A File Offset: 0x0000EE2A
				public SingleObjectEnumerator(object value)
				{
				}

				// Token: 0x17000174 RID: 372
				// (get) Token: 0x060005BF RID: 1471 RVA: 0x00013F95 File Offset: 0x00012195
				public object Current
				{
					get
					{
						return null;
					}
				}

				// Token: 0x060005C0 RID: 1472 RVA: 0x00013F98 File Offset: 0x00012198
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x060005C1 RID: 1473 RVA: 0x00010C2A File Offset: 0x0000EE2A
				public void Reset()
				{
				}

				// Token: 0x040002F0 RID: 752
				private object loneValue;

				// Token: 0x040002F1 RID: 753
				private int position;
			}
		}
	}
}
