using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Terraria.DataStructures
{
	// Token: 0x02000636 RID: 1590
	public class MethodSequenceListItem
	{
		// Token: 0x0600362D RID: 13869 RVA: 0x00212464 File Offset: 0x00210664
		public MethodSequenceListItem(string name, Func<bool> method, [Optional] MethodSequenceListItem parent)
		{
			this.Parent = parent;
			this.Method = method;
			this.Name = name;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0021248C File Offset: 0x0021068C
		public bool ShouldAct(List<MethodSequenceListItem> sequence)
		{
			while (!this.Skip)
			{
				if (this.Parent == null)
				{
					return true;
				}
			}
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x002124AC File Offset: 0x002106AC
		public bool Act()
		{
			/*
An exception occurred when decompiling this method (0600362F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.MethodSequenceListItem::Act()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Func`1<bool>(var_0_06, ldfld:class [mscorlib]System.Func`1<bool>(MethodSequenceListItem::Method, ldloc:MethodSequenceListItem(this)))
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

		// Token: 0x06003630 RID: 13872 RVA: 0x002124C0 File Offset: 0x002106C0
		public static void ExecuteSequence(List<MethodSequenceListItem> sequence)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x002124E4 File Offset: 0x002106E4
		public override string ToString()
		{
			if ("name: " == null || "name: " != null)
			{
				string name = this.Name;
				string text;
				if ((name == null || name != null) && (" skip: " == null || " skip: " != null) && (text == null || text != null) && (" parent: " == null || " parent: " != null))
				{
					MethodSequenceListItem parent = this.Parent;
					if (parent == null || parent == null || parent != null)
					{
						string text2;
						return text2;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040076EE RID: 30446
		public string Name;

		// Token: 0x040076EF RID: 30447
		public MethodSequenceListItem Parent;

		// Token: 0x040076F0 RID: 30448
		public Func<bool> Method;

		// Token: 0x040076F1 RID: 30449
		public bool Skip;
	}
}
