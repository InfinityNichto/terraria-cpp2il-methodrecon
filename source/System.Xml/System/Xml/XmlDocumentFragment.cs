using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200006B RID: 107
	public class XmlDocumentFragment : XmlNode
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00012618 File Offset: 0x00010818
		protected internal XmlDocumentFragment(XmlDocument ownerDocument)
		{
			/*
An exception occurred when decompiling this method (06000514)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.XmlDocumentFragment::.ctor(System.Xml.XmlDocument)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_0_1B, call:string(Res::GetString, ldstr:string("Cannot create a node without an owner document.")))
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00012640 File Offset: 0x00010840
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentFragment;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00012650 File Offset: 0x00010850
		public override XmlNode ParentNode
		{
			get
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00012660 File Offset: 0x00010860
		public override XmlDocument OwnerDocument
		{
			get
			{
				if (this.parentNode != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000129 RID: 297
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0001267C File Offset: 0x0001087C
		public override string InnerXml
		{
			set
			{
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003FFD File Offset: 0x000021FD
		public override XmlNode CloneNode(bool deep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001268C File Offset: 0x0001088C
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001269C File Offset: 0x0001089C
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000126B0 File Offset: 0x000108B0
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000126C4 File Offset: 0x000108C4
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return true;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000126D8 File Offset: 0x000108D8
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			while (refChild == null)
			{
			}
			return true;
		}

		// Token: 0x040002C3 RID: 707
		private XmlLinkedNode lastChild;
	}
}
