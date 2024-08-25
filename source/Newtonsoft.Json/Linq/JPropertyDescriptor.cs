using System;
using System.ComponentModel;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B9 RID: 185
	[Preserve]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x00011EE4 File Offset: 0x000100E4
		public JPropertyDescriptor(string name)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00011EF4 File Offset: 0x000100F4
		private static JObject CastInstance(object instance)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00011F08 File Offset: 0x00010108
		public override bool CanResetValue(object component)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00011F18 File Offset: 0x00010118
		public override object GetValue(object component)
		{
			/*
An exception occurred when decompiling this method (060006C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JPropertyDescriptor::GetValue(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JPropertyDescriptor::CastInstance, ldloc:object(component)))
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

		// Token: 0x060006C8 RID: 1736 RVA: 0x00011F2C File Offset: 0x0001012C
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00011F3C File Offset: 0x0001013C
		public override void SetValue(object component, object value)
		{
			if (value != null)
			{
			}
			JObject jobject = JPropertyDescriptor.CastInstance(component);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00011F54 File Offset: 0x00010154
		public override bool ShouldSerializeValue(object component)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00011F64 File Offset: 0x00010164
		public override Type ComponentType
		{
			get
			{
				if (!true)
				{
				}
				Type type;
				return type;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00011F78 File Offset: 0x00010178
		public override bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00011F88 File Offset: 0x00010188
		public override Type PropertyType
		{
			get
			{
				if (!true)
				{
				}
				Type type;
				return type;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00011F9C File Offset: 0x0001019C
		protected override int NameHashCode
		{
			get
			{
				return this.nameHash;
			}
		}
	}
}
