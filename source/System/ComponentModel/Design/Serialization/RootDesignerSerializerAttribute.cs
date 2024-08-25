using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel.Design.Serialization
{
	// Token: 0x02000415 RID: 1045
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		// Token: 0x06001C1C RID: 7196 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			this.<SerializerTypeName>k__BackingField = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerTypeName;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0004D0DC File Offset: 0x0004B2DC
		public string SerializerBaseTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<SerializerBaseTypeName>k__BackingField;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0004D0F0 File Offset: 0x0004B2F0
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001C1E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0E, ldfld:string(RootDesignerSerializerAttribute::<SerializerBaseTypeName>k__BackingField, ldloc:RootDesignerSerializerAttribute(this)))
	stloc:int64(var_2_10, ldc.i4:int64(0))
	stloc:string(var_3_19, call:string(string::Substring, ldloc:string(var_0_0E), ldloc:int64[exp:int32](var_2_10), ldloc:int32(var_1)))
	stloc:Type(var_4_20, call:Type(object::GetType, ldloc:RootDesignerSerializerAttribute[exp:object](this)))
	stfld:string(RootDesignerSerializerAttribute::_typeId, ldloc:RootDesignerSerializerAttribute(this), ldloc:string(var_5))
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

		// Token: 0x04001391 RID: 5009
		private string _typeId;

		// Token: 0x04001392 RID: 5010
		[CompilerGenerated]
		private readonly bool <Reloadable>k__BackingField;

		// Token: 0x04001393 RID: 5011
		[CompilerGenerated]
		private readonly string <SerializerTypeName>k__BackingField;

		// Token: 0x04001394 RID: 5012
		[CompilerGenerated]
		private readonly string <SerializerBaseTypeName>k__BackingField;
	}
}
