using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000372 RID: 882
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		// Token: 0x060016FF RID: 5887 RVA: 0x00042A8C File Offset: 0x00040C8C
		public EditorAttribute()
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00042AA0 File Offset: 0x00040CA0
		public EditorAttribute(string typeName, string baseTypeName)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = typeName.ToUpper(invariantCulture);
			this.EditorBaseTypeName = baseTypeName;
			this.EditorTypeName = typeName;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00042AD4 File Offset: 0x00040CD4
		public EditorAttribute(string typeName, Type baseType)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = typeName.ToUpper(invariantCulture);
			this.EditorTypeName = typeName;
			this.EditorBaseTypeName = baseType;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00042B08 File Offset: 0x00040D08
		public EditorAttribute(Type type, Type baseType)
		{
			this.EditorTypeName = type;
			this.EditorBaseTypeName = baseType;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00042B2C File Offset: 0x00040D2C
		public string EditorBaseTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<EditorBaseTypeName>k__BackingField;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x00042B40 File Offset: 0x00040D40
		public string EditorTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<EditorTypeName>k__BackingField;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00042B54 File Offset: 0x00040D54
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001705)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.EditorAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0E, ldfld:string(EditorAttribute::<EditorBaseTypeName>k__BackingField, ldloc:EditorAttribute(this)))
	stloc:int64(var_2_10, ldc.i4:int64(0))
	stloc:string(var_3_19, call:string(string::Substring, ldloc:string(var_0_0E), ldloc:int64[exp:int32](var_2_10), ldloc:int32(var_1)))
	stloc:Type(var_4_20, call:Type(object::GetType, ldloc:EditorAttribute[exp:object](this)))
	stfld:string(EditorAttribute::_typeId, ldloc:EditorAttribute(this), ldloc:string(var_5))
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

		// Token: 0x06001706 RID: 5894 RVA: 0x00042B8C File Offset: 0x00040D8C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.<EditorTypeName>k__BackingField;
				string text2 = this.<EditorBaseTypeName>k__BackingField;
				bool flag;
				return flag;
			}
			return true;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00042BB0 File Offset: 0x00040DB0
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04001218 RID: 4632
		private string _typeId;

		// Token: 0x04001219 RID: 4633
		[CompilerGenerated]
		private readonly string <EditorBaseTypeName>k__BackingField;

		// Token: 0x0400121A RID: 4634
		[CompilerGenerated]
		private readonly string <EditorTypeName>k__BackingField;
	}
}
