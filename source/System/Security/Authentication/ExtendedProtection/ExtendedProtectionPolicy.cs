using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x020000EA RID: 234
	[global::System.ComponentModel.TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
	[MonoTODO]
	[Serializable]
	public class ExtendedProtectionPolicy : ISerializable
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x00015100 File Offset: 0x00013300
		[MonoTODO("Not implemented.")]
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00015114 File Offset: 0x00013314
		protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06000545)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(object::.ctor, ldloc:ExtendedProtectionPolicy[exp:object](this))
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		public ChannelBinding CustomChannelBinding
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		public PolicyEnforcement PolicyEnforcement
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00015128 File Offset: 0x00013328
		[MonoTODO]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
