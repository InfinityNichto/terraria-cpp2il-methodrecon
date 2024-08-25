using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010E RID: 270
	[UsedByNativeCode]
	public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00009B2C File Offset: 0x00007D2C
		public VertexAttribute attribute
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
				this.<attribute>k__BackingField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00009B40 File Offset: 0x00007D40
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00009B54 File Offset: 0x00007D54
		public VertexAttributeFormat format
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<format>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<format>k__BackingField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00009B68 File Offset: 0x00007D68
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00009B7C File Offset: 0x00007D7C
		public int dimension
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<dimension>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dimension>k__BackingField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00009B90 File Offset: 0x00007D90
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00009BA4 File Offset: 0x00007DA4
		public int stream
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<stream>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<stream>k__BackingField = value;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00009BB8 File Offset: 0x00007DB8
		public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			this.<attribute>k__BackingField = attribute;
			this.dimension = (int)format;
			this.dimension = dimension;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00009BDC File Offset: 0x00007DDC
		public override string ToString()
		{
			VertexAttributeFormat vertexAttributeFormat = this.<format>k__BackingField;
			int num = this.<dimension>k__BackingField;
			int num2 = this.<stream>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00009C08 File Offset: 0x00007E08
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000574)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:VertexAttribute(var_0_06, ldfld:VertexAttribute(VertexAttributeDescriptor::<attribute>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
	stloc:int32(var_1_0D, ldfld:int32(VertexAttributeDescriptor::<dimension>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
	stloc:int32(var_2_14, ldfld:int32(VertexAttributeDescriptor::<dimension>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
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

		// Token: 0x06000575 RID: 1397 RVA: 0x00009C2C File Offset: 0x00007E2C
		public override bool Equals(object other)
		{
			if (other != null)
			{
				VertexAttributeFormat vertexAttributeFormat = this.<format>k__BackingField;
				int num = this.<dimension>k__BackingField;
				int num2 = this.<stream>k__BackingField;
				return;
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00009C54 File Offset: 0x00007E54
		public bool Equals(VertexAttributeDescriptor other)
		{
			/*
An exception occurred when decompiling this method (06000576)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Rendering.VertexAttributeDescriptor::Equals(UnityEngine.Rendering.VertexAttributeDescriptor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:VertexAttributeFormat(var_0_06, ldfld:VertexAttributeFormat(VertexAttributeDescriptor::<format>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
	stloc:int32(var_1_0D, ldfld:int32(VertexAttributeDescriptor::<dimension>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
	stloc:int32(var_2_14, ldfld:int32(VertexAttributeDescriptor::<stream>k__BackingField, ldloc:valuetype UnityEngine.Rendering.VertexAttributeDescriptor&(this)))
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

		// Token: 0x04000474 RID: 1140
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VertexAttribute <attribute>k__BackingField;

		// Token: 0x04000475 RID: 1141
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private VertexAttributeFormat <format>k__BackingField;

		// Token: 0x04000476 RID: 1142
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int <dimension>k__BackingField;

		// Token: 0x04000477 RID: 1143
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int <stream>k__BackingField;
	}
}
