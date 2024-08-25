using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004FE RID: 1278
	[Serializable]
	internal class MemberInfoSerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x060024F8 RID: 9464 RVA: 0x00051C64 File Offset: 0x0004FE64
		public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type)
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00051C74 File Offset: 0x0004FE74
		public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments)
		{
			while (info == null)
			{
			}
			Type type2;
			info.SetType(type2);
			Type type3;
			info.AddValue("Name", name, type3);
			Type type4;
			info.AddValue("AssemblyName", reflectedClass, type4);
			Type type5;
			info.AddValue("ClassName", reflectedClass, type5);
			Type type6;
			info.AddValue("Signature", signature, type6);
			Type type7;
			info.AddValue("Signature2", signature2, type7);
			Type type8;
			info.AddValue("GenericArguments", signature2, type8);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00051CE0 File Offset: 0x0004FEE0
		internal MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (060024FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Reflection.MemberInfoSerializationHolder::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A8:
	stloc:string(var_8_B2, call:string(Environment::GetResourceString, ldstr:string("Insufficient state to return the real object.")))
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

		// Token: 0x060024FB RID: 9467 RVA: 0x00051DA0 File Offset: 0x0004FFA0
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (060024FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Reflection.MemberInfoSerializationHolder::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Method is not supported.")))
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

		// Token: 0x060024FC RID: 9468 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		public virtual object GetRealObject(StreamingContext context)
		{
			if (this.m_memberName != null)
			{
				RuntimeType reflectedType = this.m_reflectedType;
				MemberTypes memberType = this.m_memberType;
				if (this.m_signature != null)
				{
					string memberName = this.m_memberName;
					RuntimeType reflectedType2 = this.m_reflectedType;
					MonoTypeInfo type_info = reflectedType2.type_info;
					if (this.m_signature2 != null)
					{
						if (reflectedType2 != null)
						{
						}
						string signature = this.m_signature2;
					}
					string signature2 = this.m_signature;
					string text;
					bool flag = text.Equals(signature2);
					string memberName2 = this.m_memberName;
					RuntimeType reflectedType3 = this.m_reflectedType;
					if (reflectedType3.type_info != null)
					{
						return reflectedType3.GenericCache;
					}
					string memberName3 = this.m_memberName;
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				string resourceString = Environment.GetResourceString("Insufficient state to return the real object.");
				string resourceString2 = Environment.GetResourceString("Unknown member type.");
			}
			return "The method signature cannot be null.";
		}

		// Token: 0x040014A6 RID: 5286
		private string m_memberName;

		// Token: 0x040014A7 RID: 5287
		private RuntimeType m_reflectedType;

		// Token: 0x040014A8 RID: 5288
		private string m_signature;

		// Token: 0x040014A9 RID: 5289
		private string m_signature2;

		// Token: 0x040014AA RID: 5290
		private MemberTypes m_memberType;

		// Token: 0x040014AB RID: 5291
		private SerializationInfo m_info;
	}
}
