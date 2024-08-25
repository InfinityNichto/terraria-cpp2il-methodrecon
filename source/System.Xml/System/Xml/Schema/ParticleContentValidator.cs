using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x020000D4 RID: 212
	internal sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x0001A5A8 File Offset: 0x000187A8
		public ParticleContentValidator(XmlSchemaContentType contentType)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0001A5B8 File Offset: 0x000187B8
		public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
		{
			if (!true)
			{
			}
			base..ctor();
			this.contentType = contentType;
			this.isEmptiable = true;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0001A5DC File Offset: 0x000187DC
		public void Start()
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001A5EC File Offset: 0x000187EC
		public void OpenGroup()
		{
			Stack stack = this.stack;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0001A600 File Offset: 0x00018800
		public void CloseGroup()
		{
			Stack stack = this.stack;
			if (stack != null)
			{
				if (this.stack != null)
				{
					Stack stack2 = this.stack;
					if (stack2 != null)
					{
						stack2._size = stack;
						return;
					}
					long num = 0L;
					Stack stack3 = this.stack;
					this.isPartial = num != 0L;
					return;
				}
				else
				{
					Stack stack2;
					this.contentNode = stack2;
				}
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0001A650 File Offset: 0x00018850
		public bool Exists(XmlQualifiedName name)
		{
			/*
An exception occurred when decompiling this method (06000859)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.ParticleContentValidator::Exists(System.Xml.XmlQualifiedName)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_0B, ldfld:Hashtable(SymbolsDictionary::names, ldfld:SymbolsDictionary(ParticleContentValidator::symbols, ldloc:ParticleContentValidator(this))))
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

		// Token: 0x0600085A RID: 2138 RVA: 0x0001A668 File Offset: 0x00018868
		public void AddName(XmlQualifiedName name, object particle)
		{
			SymbolsDictionary symbolsDictionary = this.symbols;
			Positions positions = this.positions;
			int num = symbolsDictionary.AddName(name, particle);
			int num2 = positions.Add(num, particle);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001A698 File Offset: 0x00018898
		public void AddNamespaceList(NamespaceList namespaceList, object particle)
		{
			SymbolsDictionary symbolsDictionary = this.symbols;
			long num = 0L;
			symbolsDictionary.AddNamespaceList(namespaceList, particle, num != 0L);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001A6B8 File Offset: 0x000188B8
		private void AddLeafNode(SyntaxTreeNode node)
		{
			Stack stack = this.stack;
			Stack stack2 = this.stack;
			if (stack2 != null)
			{
				stack2._size = node;
			}
			Stack stack3 = this.stack;
			int num = 1;
			this.isPartial = num != 0;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0001A6F4 File Offset: 0x000188F4
		public void AddChoice()
		{
			if (this.stack != null)
			{
			}
			Stack stack = this.stack;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001A718 File Offset: 0x00018918
		public void AddSequence()
		{
			if (this.stack != null)
			{
			}
			Stack stack = this.stack;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001A73C File Offset: 0x0001893C
		public void AddStar()
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0001A74C File Offset: 0x0001894C
		public void AddPlus()
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0001A75C File Offset: 0x0001895C
		public void AddQMark()
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001A76C File Offset: 0x0001896C
		private void Closure(InteriorNode node)
		{
			Stack stack = this.stack;
			Stack stack2 = this.stack;
			if (stack2 != null)
			{
			}
			node.leftChild = stack2;
			Stack stack3 = this.stack;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001A7D0 File Offset: 0x000189D0
		public ContentValidator Finish(bool useDFA)
		{
			if (this.contentNode != null)
			{
				SyntaxTreeNode syntaxTreeNode = this.contentNode;
				SymbolsDictionary symbolsDictionary = this.symbols;
				Positions positions = this.positions;
				if (syntaxTreeNode == null)
				{
				}
				long num = 0L;
				int num3;
				int num2 = positions.Add(num3, num);
				SyntaxTreeNode syntaxTreeNode2 = this.contentNode;
				SymbolsDictionary symbolsDictionary2 = this.symbols;
				Positions positions2 = this.positions;
				ArrayList arrayList = this.positions.positions;
				int num4 = this.minMaxNodesCount;
				if (this.enableUpaCheck)
				{
					BitSet bitSet;
					this.CheckCMUPAWithLeafRangeNodes(bitSet);
				}
				SymbolsDictionary symbolsDictionary3 = this.symbols;
				Positions positions3 = this.positions;
				XmlSchemaContentType contentType = this.contentType;
				int num5 = this.minMaxNodesCount;
			}
			int[][] array;
			if (array != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0001A874 File Offset: 0x00018A74
		private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, [Out] BitSet posWithRangeTerminals)
		{
			ArrayList arrayList = this.positions.positions;
			int num = this.minMaxNodesCount;
			Position position = this.positions[num];
			if (num != 0)
			{
			}
			int num2;
			Position position2 = this.positions[num2];
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		private void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			int last = this.symbols.last;
			int num;
			Position position = this.positions[num];
			if (last == 0 && (num == 0 || num != 0))
			{
				int num2 = curpos.NextSet(num);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001A900 File Offset: 0x00018B00
		private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos)
		{
			bool flag = curpos.Intersects(posWithRangeTerminals);
			ArrayList arrayList = this.positions.positions;
			BitSet bitSet = curpos.Clone();
			int num;
			Position position = this.positions[num];
			return curpos;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001A938 File Offset: 0x00018B38
		private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos)
		{
			this.CheckUniqueParticleAttribution(firstpos);
			ArrayList arrayList = this.positions.positions;
			this.CheckUniqueParticleAttribution(firstpos);
			Positions positions = this.positions;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001A968 File Offset: 0x00018B68
		private void CheckUniqueParticleAttribution(BitSet curpos)
		{
			int last = this.symbols.last;
			int num;
			Position position = this.positions[num];
			Position position2 = this.positions[num];
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos)
		{
			ArrayList arrayList = this.positions.positions;
			int last = this.symbols.last;
			int num;
			Position position = this.positions[num];
			return 42175368;
		}

		// Token: 0x04000437 RID: 1079
		private SymbolsDictionary symbols;

		// Token: 0x04000438 RID: 1080
		private Positions positions;

		// Token: 0x04000439 RID: 1081
		private Stack stack;

		// Token: 0x0400043A RID: 1082
		private SyntaxTreeNode contentNode;

		// Token: 0x0400043B RID: 1083
		private bool isPartial;

		// Token: 0x0400043C RID: 1084
		private int minMaxNodesCount;

		// Token: 0x0400043D RID: 1085
		private bool enableUpaCheck;
	}
}
