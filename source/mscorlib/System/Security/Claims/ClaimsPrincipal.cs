using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using Cpp2IlInjected;

namespace System.Security.Claims
{
	// Token: 0x02000330 RID: 816
	[ComVisible(true)]
	[Serializable]
	public class ClaimsPrincipal : IPrincipal
	{
		// Token: 0x06001B9D RID: 7069 RVA: 0x0003B810 File Offset: 0x00039A10
		private static ClaimsIdentity SelectPrimaryIdentity(IEnumerable<ClaimsIdentity> identities)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0003B838 File Offset: 0x00039A38
		public static Func<ClaimsPrincipal> ClaimsPrincipalSelector
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B9E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Func`1<System.Security.Claims.ClaimsPrincipal> System.Security.Claims.ClaimsPrincipal::get_ClaimsPrincipalSelector()

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
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0003B848 File Offset: 0x00039A48
		public ClaimsPrincipal()
		{
			this.m_version = "1.0";
			base..ctor();
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0003B868 File Offset: 0x00039A68
		protected ClaimsPrincipal(SerializationInfo info, StreamingContext context)
		{
			do
			{
				this.m_version = "1.0";
				base..ctor();
			}
			while (info == null);
			this.Deserialize(info, context);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0003B894 File Offset: 0x00039A94
		[OnSerializing]
		private void OnSerializingMethod(StreamingContext context)
		{
			if (this == null)
			{
				string text = this.SerializeIdentities();
				this.m_serializedClaimsIdentities = text;
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0003B8B4 File Offset: 0x00039AB4
		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
			if (this == null)
			{
				string serializedClaimsIdentities = this.m_serializedClaimsIdentities;
				this.DeserializeIdentities(serializedClaimsIdentities);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0003B8D4 File Offset: 0x00039AD4
		private void Deserialize(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			string name = enumerator.Name;
			bool flag2 = name == "System.Security.ClaimsPrincipal.Identities";
			string @string = info.GetString("System.Security.ClaimsPrincipal.Identities");
			this.DeserializeIdentities(@string);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000207A File Offset: 0x0000027A
		private void DeserializeIdentities(string identities)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0003B948 File Offset: 0x00039B48
		private string SerializeIdentities()
		{
			int num = 1;
			List<ClaimsIdentity> identities = this.m_identities;
			Type type = base.GetType();
			if (num == 0)
			{
			}
			Type type2;
			bool flag = type == type2;
			if (this != null)
			{
			}
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0003BA4C File Offset: 0x00039C4C
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimsPrincipal()
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x04000E13 RID: 3603
		[OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x04000E14 RID: 3604
		[OptionalField(VersionAdded = 2)]
		private string m_serializedClaimsIdentities;

		// Token: 0x04000E15 RID: 3605
		[NonSerialized]
		private List<ClaimsIdentity> m_identities;

		// Token: 0x04000E16 RID: 3606
		[NonSerialized]
		private static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> s_identitySelector;

		// Token: 0x04000E17 RID: 3607
		[NonSerialized]
		private static Func<ClaimsPrincipal> s_principalSelector;
	}
}
