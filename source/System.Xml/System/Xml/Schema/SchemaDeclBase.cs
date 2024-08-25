using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x0200012F RID: 303
	internal abstract class SchemaDeclBase
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x0001D198 File Offset: 0x0001B398
		protected SchemaDeclBase(XmlQualifiedName name, string prefix)
		{
			if (!true)
			{
			}
			this.name = 1;
			base..ctor();
			this.name = name;
			this.prefix = prefix;
			this.maxLength = 1L;
			this.minLength = 1L;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
		protected SchemaDeclBase()
		{
			if (!true)
			{
			}
			this.name = 1;
			base..ctor();
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		internal XmlQualifiedName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001D208 File Offset: 0x0001B408
		internal string Prefix
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaDeclBase::get_Prefix()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaDeclBase::prefix, ldloc:SchemaDeclBase(this)))
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0001D21C File Offset: 0x0001B41C
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x0001D230 File Offset: 0x0001B430
		internal bool IsDeclaredInExternal
		{
			get
			{
				return this.isDeclaredInExternal;
			}
			set
			{
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0001D240 File Offset: 0x0001B440
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0001D254 File Offset: 0x0001B454
		internal SchemaDeclBase.Use Presence
		{
			get
			{
				return this.presence;
			}
			set
			{
				this.presence = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0001D268 File Offset: 0x0001B468
		internal XmlSchemaType SchemaType
		{
			set
			{
				this.schemaType = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0001D27C File Offset: 0x0001B47C
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0001D290 File Offset: 0x0001B490
		internal XmlSchemaDatatype Datatype
		{
			get
			{
				return this.datatype;
			}
			set
			{
				this.datatype = value;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		internal void AddValue(string value)
		{
			if (this.values == null)
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0001D2BC File Offset: 0x0001B4BC
		internal List<string> Values
		{
			get
			{
				return this.values;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		internal string DefaultValueRaw
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Schema.SchemaDeclBase::get_DefaultValueRaw()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](SchemaDeclBase::defaultValueRaw, ldloc:SchemaDeclBase(this)))
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		internal object DefaultValueTyped
		{
			get
			{
				return this.defaultValueTyped;
			}
			set
			{
				this.defaultValueTyped = value;
			}
		}

		// Token: 0x04000524 RID: 1316
		protected XmlQualifiedName name;

		// Token: 0x04000525 RID: 1317
		protected string prefix;

		// Token: 0x04000526 RID: 1318
		protected bool isDeclaredInExternal;

		// Token: 0x04000527 RID: 1319
		protected SchemaDeclBase.Use presence;

		// Token: 0x04000528 RID: 1320
		protected XmlSchemaType schemaType;

		// Token: 0x04000529 RID: 1321
		protected XmlSchemaDatatype datatype;

		// Token: 0x0400052A RID: 1322
		protected string defaultValueRaw;

		// Token: 0x0400052B RID: 1323
		protected object defaultValueTyped;

		// Token: 0x0400052C RID: 1324
		protected long maxLength;

		// Token: 0x0400052D RID: 1325
		protected long minLength;

		// Token: 0x0400052E RID: 1326
		protected List<string> values;

		// Token: 0x02000130 RID: 304
		internal enum Use
		{
			// Token: 0x04000530 RID: 1328
			Default,
			// Token: 0x04000531 RID: 1329
			Required,
			// Token: 0x04000532 RID: 1330
			Implied,
			// Token: 0x04000533 RID: 1331
			Fixed,
			// Token: 0x04000534 RID: 1332
			RequiredFixed
		}
	}
}
