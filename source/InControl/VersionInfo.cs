using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	public struct VersionInfo : IComparable<VersionInfo>
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x00010378 File Offset: 0x0000E578
		public VersionInfo(int major, int minor, int patch, int build)
		{
			this.major = major;
			this.patch = minor;
			this.patch = patch;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000025E1 File Offset: 0x000007E1
		public static VersionInfo InControlVersion()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001039C File Offset: 0x0000E59C
		public static VersionInfo UnityVersion()
		{
			/*
An exception occurred when decompiling this method (06000546)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.VersionInfo InControl.VersionInfo::UnityVersion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Match(var_1_11, call:Match(Regex::Match, callgetter:string(Application::get_unityVersion), ldstr:string("^(\\d+)\\.(\\d+)\\.(\\d+)f(\\d+)")))
	stloc:int32(var_3_1D, call:int32(Convert::ToInt32, callgetter:string(Capture::get_Value, ldloc:Group[exp:Capture](var_2))))
	stloc:int32(var_5_2A, call:int32(Convert::ToInt32, callgetter:string(Capture::get_Value, ldloc:Group[exp:Capture](var_4))))
	stloc:int32(var_7_38, call:int32(Convert::ToInt32, callgetter:string(Capture::get_Value, ldloc:Group[exp:Capture](var_6))))
	stloc:int32(var_9_46, call:int32(Convert::ToInt32, callgetter:string(Capture::get_Value, ldloc:Group[exp:Capture](var_8))))
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public static VersionInfo Min
		{
			get
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00010404 File Offset: 0x0000E604
		public static VersionInfo Max
		{
			get
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00010418 File Offset: 0x0000E618
		public VersionInfo Next
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000549)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.VersionInfo InControl.VersionInfo::get_Next()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(VersionInfo::patch, ldloc:valuetype InControl.VersionInfo&(this)))
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001042C File Offset: 0x0000E62C
		public int Build
		{
			get
			{
				return this.build;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00010440 File Offset: 0x0000E640
		public int CompareTo(VersionInfo other)
		{
			int num = this.minor;
			int num2 = this.patch;
			return 1;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator ==(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator !=(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator <=(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator >=(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator <(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000025E1 File Offset: 0x000007E1
		public static bool operator >(VersionInfo a, VersionInfo b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00010460 File Offset: 0x0000E660
		public override bool Equals(object other)
		{
			/*
An exception occurred when decompiling this method (06000552)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.VersionInfo::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0B, ldfld:int32(VersionInfo::major, ldloc:valuetype InControl.VersionInfo&(this)))
	stloc:int32(var_2_12, ldfld:int32(VersionInfo::patch, ldloc:valuetype InControl.VersionInfo&(this)))
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

		// Token: 0x06000553 RID: 1363 RVA: 0x00010480 File Offset: 0x0000E680
		public override int GetHashCode()
		{
			int num;
			return num.GetHashCode().GetHashCode().GetHashCode();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000104A0 File Offset: 0x0000E6A0
		public override string ToString()
		{
			if (this.build != 0)
			{
				int num = this.minor;
				int num2 = this.patch;
				int num3 = this.build;
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000104D4 File Offset: 0x0000E6D4
		public string ToShortString()
		{
			if (this.build != 0)
			{
				int num = this.minor;
				int num2 = this.patch;
				int num3 = this.build;
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x040003FD RID: 1021
		[SerializeField]
		private int major;

		// Token: 0x040003FE RID: 1022
		[SerializeField]
		private int minor;

		// Token: 0x040003FF RID: 1023
		[SerializeField]
		private int patch;

		// Token: 0x04000400 RID: 1024
		[SerializeField]
		private int build;
	}
}
