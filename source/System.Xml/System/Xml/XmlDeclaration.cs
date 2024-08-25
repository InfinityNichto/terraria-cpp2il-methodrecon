using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000069 RID: 105
	public class XmlDeclaration : XmlLinkedNode
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x000119B4 File Offset: 0x0000FBB4
		protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc)
			: base(doc)
		{
			bool flag = this.IsValidXmlVersion(version);
			if (standalone != null)
			{
				int stringLength = standalone._stringLength;
				bool flag2 = standalone != "yes";
				bool flag3 = standalone != "no";
			}
			if (encoding == null)
			{
			}
			this.Standalone = standalone;
			this.version = version;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00011A18 File Offset: 0x0000FC18
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00011A2C File Offset: 0x0000FC2C
		public string Version
		{
			get
			{
				return this.version;
			}
			internal set
			{
				this.version = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00011A40 File Offset: 0x0000FC40
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00011A54 File Offset: 0x0000FC54
		public string Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				if (value == null)
				{
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00011A64 File Offset: 0x0000FC64
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00011A78 File Offset: 0x0000FC78
		public string Standalone
		{
			get
			{
				return this.standalone;
			}
			set
			{
				if (value != null)
				{
					if (value._stringLength != 0)
					{
						bool flag = value == "yes";
						bool flag2 = value == "no";
					}
					this.standalone = value;
					return;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		public override string Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00011B18 File Offset: 0x0000FD18
		public override string InnerText
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlDeclaration::get_InnerText()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(XmlDeclaration::version, ldloc:XmlDeclaration(this)))
	stloc:string(var_1_17, call:string(string::Concat, ldstr:string("version=\""), ldloc:string(var_0_06), ldstr:string("\"")))
	stloc:int32(var_2_23, ldfld:int32(string::_stringLength, ldfld:string(XmlDeclaration::encoding, ldloc:XmlDeclaration(this))))
	stloc:string(var_4_2A, ldfld:string(XmlDeclaration::encoding, ldloc:XmlDeclaration(this)))
	stloc:int32(var_7_37, ldfld:int32(string::_stringLength, ldfld:string(XmlDeclaration::standalone, ldloc:XmlDeclaration(this))))
	stloc:string(var_9_3F, ldfld:string(XmlDeclaration::standalone, ldloc:XmlDeclaration(this)))
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
				string text = this.version;
				string text2 = this.encoding;
				string text3 = this.standalone;
				if (value != null)
				{
				}
				this.version = value;
				if (value != null)
				{
					this.Standalone = value;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00011B7C File Offset: 0x0000FD7C
		public override string Name
		{
			get
			{
				return "xml";
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00003FFD File Offset: 0x000021FD
		public override string LocalName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00011B90 File Offset: 0x0000FD90
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		public override XmlNode CloneNode(bool deep)
		{
			/*
An exception occurred when decompiling this method (060004C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlDeclaration::CloneNode(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(XmlDeclaration::version, ldloc:XmlDeclaration(this)))
	stloc:string(var_1_0D, ldfld:string(XmlDeclaration::encoding, ldloc:XmlDeclaration(this)))
	stloc:string(var_2_14, ldfld:string(XmlDeclaration::standalone, ldloc:XmlDeclaration(this)))
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

		// Token: 0x060004C1 RID: 1217 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		private bool IsValidXmlVersion(string ver)
		{
			int stringLength = ver._stringLength;
			long num = 0L;
			char c = ver[(int)num];
			int num2 = 1;
			long num3 = 0L;
			char c2 = ver[num2];
			int stringLength2 = ver._stringLength;
			int num4 = 2;
			return XmlCharType.IsOnlyDigits(ver, num4, (int)num3);
		}

		// Token: 0x04000294 RID: 660
		private string version;

		// Token: 0x04000295 RID: 661
		private string encoding;

		// Token: 0x04000296 RID: 662
		private string standalone;
	}
}
