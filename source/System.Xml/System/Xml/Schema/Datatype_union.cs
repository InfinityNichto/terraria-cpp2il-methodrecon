using System;

namespace System.Xml.Schema
{
	// Token: 0x020000E0 RID: 224
	internal class Datatype_union : Datatype_anySimpleType
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0001AF30 File Offset: 0x00019130
		internal bool HasAtomicMembers()
		{
			/*
An exception occurred when decompiling this method (06000897)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.Datatype_union::HasAtomicMembers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Xml.Schema.XmlSchemaSimpleType[](var_0_06, ldfld:class System.Xml.Schema.XmlSchemaSimpleType[](Datatype_union::types, ldloc:Datatype_union(this)))
	stloc:XmlSchemaType(var_1_0D, ldfld:XmlSchemaType(XmlSchemaType::baseSchemaType, ldloc:class System.Xml.Schema.XmlSchemaSimpleType[][exp:XmlSchemaType](var_0_06)))
	stloc:XmlSchemaDatatype(var_3_16, ldfld:XmlSchemaDatatype(XmlSchemaType::datatype, ldloc:class System.Xml.Schema.XmlSchemaSimpleType[][exp:XmlSchemaType](var_0_06)))
	stloc:class System.Xml.Schema.XmlSchemaSimpleType[](var_4_1D, ldfld:class System.Xml.Schema.XmlSchemaSimpleType[](Datatype_union::types, ldloc:Datatype_union(this)))
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

		// Token: 0x06000898 RID: 2200 RVA: 0x0001AF64 File Offset: 0x00019164
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_union()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040004CE RID: 1230
		private static readonly Type atomicValueType;

		// Token: 0x040004CF RID: 1231
		private static readonly Type listValueType;

		// Token: 0x040004D0 RID: 1232
		private XmlSchemaSimpleType[] types;
	}
}
