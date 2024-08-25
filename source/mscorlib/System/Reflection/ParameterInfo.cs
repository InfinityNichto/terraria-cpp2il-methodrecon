using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004E3 RID: 1251
	[Serializable]
	[StructLayout(0)]
	public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
	{
		// Token: 0x06002407 RID: 9223 RVA: 0x00050C68 File Offset: 0x0004EE68
		protected ParameterInfo()
		{
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x00050C7C File Offset: 0x0004EE7C
		public virtual ParameterAttributes Attributes
		{
			get
			{
				return this.AttrsImpl;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x00050C90 File Offset: 0x0004EE90
		public virtual MemberInfo Member
		{
			get
			{
				return this.MemberImpl;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00050CA4 File Offset: 0x0004EEA4
		public virtual string Name
		{
			get
			{
				return this.NameImpl;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		public virtual Type ParameterType
		{
			get
			{
				return this.ClassImpl;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00050CCC File Offset: 0x0004EECC
		public virtual int Position
		{
			get
			{
				return this.PositionImpl;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsIn
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsOptional
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsOut
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		public virtual object DefaultValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002410)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Reflection.ParameterInfo::get_DefaultValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_1_07, callgetter:Exception(NotImplemented::get_ByDesign))
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

		// Token: 0x06002411 RID: 9233 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00050D08 File Offset: 0x0004EF08
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00050D1C File Offset: 0x0004EF1C
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06002413)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object[] System.Reflection.ParameterInfo::GetCustomAttributes(System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06002414 RID: 9236 RVA: 0x00050D2C File Offset: 0x0004EF2C
		public object GetRealObject(StreamingContext context)
		{
			MemberInfo memberImpl = this.MemberImpl;
			MemberInfo memberImpl2 = this.MemberImpl;
			int positionImpl = this.PositionImpl;
			if (this.MemberImpl != null && this.MemberImpl != null)
			{
				MemberInfo memberImpl3 = this.MemberImpl;
				MemberInfo memberImpl4 = this.MemberImpl;
			}
			return "Non existent ParameterInfo. Position bigger than member's parameters length.";
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00050D80 File Offset: 0x0004EF80
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x040013F8 RID: 5112
		protected ParameterAttributes AttrsImpl;

		// Token: 0x040013F9 RID: 5113
		protected Type ClassImpl;

		// Token: 0x040013FA RID: 5114
		protected object DefaultValueImpl;

		// Token: 0x040013FB RID: 5115
		protected MemberInfo MemberImpl;

		// Token: 0x040013FC RID: 5116
		protected string NameImpl;

		// Token: 0x040013FD RID: 5117
		protected int PositionImpl;

		// Token: 0x040013FE RID: 5118
		private const int MetadataToken_ParamDef = 134217728;
	}
}
