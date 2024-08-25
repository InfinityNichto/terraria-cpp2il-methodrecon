using System;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0000B148 File Offset: 0x00009348
		internal Group(string text, int[] caps, int capcount, string name)
		{
			if (capcount != 0)
			{
				return;
			}
			base..ctor();
			this.<Text>k__BackingField = text;
			this._caps = caps;
			this._capcount = capcount;
			this.<Name>k__BackingField = name;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000B17C File Offset: 0x0000937C
		public bool Success
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.Group::get_Success()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Group::_capcount, ldloc:Group(this)))
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

		// Token: 0x060002EF RID: 751 RVA: 0x0000B190 File Offset: 0x00009390
		// Note: this type is marked as 'beforefieldinit'.
		static Group()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B1A0 File Offset: 0x000093A0
		internal Group()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000286 RID: 646
		internal static readonly Group s_emptyGroup;

		// Token: 0x04000287 RID: 647
		internal readonly int[] _caps;

		// Token: 0x04000288 RID: 648
		internal int _capcount;

		// Token: 0x04000289 RID: 649
		internal CaptureCollection _capcoll;

		// Token: 0x0400028A RID: 650
		[CompilerGenerated]
		private readonly string <Name>k__BackingField;
	}
}
