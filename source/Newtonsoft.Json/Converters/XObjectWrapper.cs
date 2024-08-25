using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Cpp2IlInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011A RID: 282
	internal class XObjectWrapper : IXmlNode
	{
		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001A350 File Offset: 0x00018550
		public XObjectWrapper(XObject xmlObject)
		{
			this._xmlObject = xmlObject;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0001A36C File Offset: 0x0001856C
		public object WrappedNode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AF6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.XObjectWrapper::get_WrappedNode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XObject(var_0_06, ldfld:XObject(XObjectWrapper::_xmlObject, ldloc:XObjectWrapper(this)))
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0001A380 File Offset: 0x00018580
		public virtual XmlNodeType NodeType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AF7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNodeType Newtonsoft.Json.Converters.XObjectWrapper::get_NodeType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XObject(var_0_06, ldfld:XObject(XObjectWrapper::_xmlObject, ldloc:XObjectWrapper(this)))
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0001A394 File Offset: 0x00018594
		public virtual string LocalName
		{
			get
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0001A3A4 File Offset: 0x000185A4
		public virtual List<IXmlNode> ChildNodes
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0001A3B8 File Offset: 0x000185B8
		public virtual List<IXmlNode> Attributes
		{
			get
			{
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0001A3C8 File Offset: 0x000185C8
		public virtual IXmlNode ParentNode
		{
			get
			{
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0001A3D8 File Offset: 0x000185D8
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0000212A File Offset: 0x0000032A
		public virtual string Value
		{
			get
			{
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0000212A File Offset: 0x0000032A
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0001A3E8 File Offset: 0x000185E8
		public virtual string NamespaceUri
		{
			get
			{
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001A3F8 File Offset: 0x000185F8
		// Note: this type is marked as 'beforefieldinit'.
		static XObjectWrapper()
		{
		}

		// Token: 0x04000417 RID: 1047
		private static readonly List<IXmlNode> EmptyChildNodes;

		// Token: 0x04000418 RID: 1048
		private readonly XObject _xmlObject;
	}
}
