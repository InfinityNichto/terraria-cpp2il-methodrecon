using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using Cpp2IlInjected;

namespace System.Security.Claims
{
	// Token: 0x0200032E RID: 814
	[ComVisible(true)]
	[Serializable]
	public class ClaimsIdentity : IIdentity
	{
		// Token: 0x06001B7B RID: 7035 RVA: 0x0003B018 File Offset: 0x00039218
		public ClaimsIdentity()
		{
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0003B028 File Offset: 0x00039228
		public ClaimsIdentity(IEnumerable<Claim> claims)
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0003B038 File Offset: 0x00039238
		public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0003B048 File Offset: 0x00039248
		internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (identity != null)
			{
				bool flag = string.IsNullOrEmpty(authenticationType);
				return;
			}
			this.m_authenticationType = identity;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0003B0D0 File Offset: 0x000392D0
		protected ClaimsIdentity(ClaimsIdentity other)
		{
			do
			{
				this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
				this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
				this.m_version = "1.0";
				base..ctor();
			}
			while (other == null);
			ClaimsIdentity actor = other.m_actor;
			if (actor != null)
			{
				this.m_actor = actor;
			}
			string label = other.m_label;
			this.m_label = label;
			if (other.m_userSerializationData != null)
			{
				object obj;
				this.m_userSerializationData = obj;
			}
			List<Claim> instanceClaims = other.m_instanceClaims;
			this.SafeAddClaims(instanceClaims);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0003B144 File Offset: 0x00039344
		protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
		{
			do
			{
				this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
				this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
				this.m_version = "1.0";
				base..ctor();
			}
			while (info == null);
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0003B17C File Offset: 0x0003937C
		public virtual string AuthenticationType
		{
			get
			{
				return this.m_authenticationType;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0003B190 File Offset: 0x00039390
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0003B1A4 File Offset: 0x000393A4
		public ClaimsIdentity Actor
		{
			get
			{
				return this.m_actor;
			}
			set
			{
				if (value != null && value.m_actor != null)
				{
					string resourceString = Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together.");
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0003B1C8 File Offset: 0x000393C8
		public virtual IEnumerable<Claim> Claims
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B84)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim> System.Security.Claims.ClaimsIdentity::get_Claims()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Environment::get_CurrentManagedThreadId))
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0003B1DC File Offset: 0x000393DC
		public virtual string Name
		{
			get
			{
				do
				{
					string nameType = this.m_nameType;
				}
				while (this == null);
				return this.m_nameType;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0003B1FC File Offset: 0x000393FC
		public string NameClaimType
		{
			get
			{
				return this.m_nameType;
			}
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0003B210 File Offset: 0x00039410
		public virtual ClaimsIdentity Clone()
		{
			/*
An exception occurred when decompiling this method (06001B87)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Claims.ClaimsIdentity System.Security.Claims.ClaimsIdentity::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:string(var_3_2A, call:string(Environment::GetResourceString, ldstr:string("Actor cannot be set so that circular directed graph will exist chaining the subjects together.")))
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

		// Token: 0x06001B88 RID: 7048 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual void AddClaim(Claim claim)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0000207A File Offset: 0x0000027A
		private void SafeAddClaims(IEnumerable<Claim> claims)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0000207A File Offset: 0x0000027A
		private void SafeAddClaim(Claim claim)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0003B248 File Offset: 0x00039448
		public virtual Claim FindFirst(string type)
		{
			if (type != null)
			{
				while (this == null)
				{
				}
				Collection<IEnumerable<Claim>> externalClaims = this.m_externalClaims;
				long num;
				if (this == null)
				{
					num = 0L;
					if (this != null)
					{
					}
				}
				if (num == 0L)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0003B284 File Offset: 0x00039484
		[OnSerializing]
		private void OnSerializingMethod(StreamingContext context)
		{
			if (this == null)
			{
				string text = this.SerializeClaims();
				this.m_serializedClaims = text;
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0003B2A4 File Offset: 0x000394A4
		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
			if (this == null)
			{
				bool flag = string.IsNullOrEmpty(this.m_serializedClaims);
				string serializedClaims = this.m_serializedClaims;
				this.DeserializeClaims(serializedClaims);
				bool flag2 = string.IsNullOrEmpty(this.m_serializedNameType);
				bool flag3 = string.IsNullOrEmpty(this.m_serializedRoleType);
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0003B2E8 File Offset: 0x000394E8
		[OnDeserializing]
		private void OnDeserializingMethod(StreamingContext context)
		{
			if (this == null)
			{
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0003B2F8 File Offset: 0x000394F8
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new OutOfMemoryException();
			}
			string version = this.m_version;
			info.AddValue("System.Security.ClaimsIdentity.version", version);
			bool flag = string.IsNullOrEmpty(this.m_authenticationType);
			string authenticationType = this.m_authenticationType;
			info.AddValue("System.Security.ClaimsIdentity.authenticationType", authenticationType);
			string nameType = this.m_nameType;
			info.AddValue("System.Security.ClaimsIdentity.nameClaimType", nameType);
			string roleType = this.m_roleType;
			info.AddValue("System.Security.ClaimsIdentity.roleClaimType", roleType);
			bool flag2 = string.IsNullOrEmpty(this.m_label);
			string label = this.m_label;
			info.AddValue("System.Security.ClaimsIdentity.label", label);
			if (this.m_actor != null)
			{
				ClaimsIdentity actor = this.m_actor;
				string text;
				info.AddValue("System.Security.ClaimsIdentity.actor", text);
				return;
			}
			string text2 = this.SerializeClaims();
			info.AddValue("System.Security.ClaimsIdentity.claims", text2);
			if (this.m_bootstrapContext != null)
			{
				object bootstrapContext = this.m_bootstrapContext;
				string text3;
				info.AddValue("System.Security.ClaimsIdentity.bootstrapContext", text3);
				return;
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0003B42C File Offset: 0x0003962C
		private void DeserializeClaims(string serializedClaims)
		{
			bool flag = string.IsNullOrEmpty(serializedClaims);
			byte[] array = Convert.FromBase64String(serializedClaims);
			object obj;
			this.m_instanceClaims = obj;
			int size = this.m_instanceClaims._size;
			if (size != 0)
			{
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0003B4A0 File Offset: 0x000396A0
		private string SerializeClaims()
		{
			List<Claim> instanceClaims = this.m_instanceClaims;
			if (!false)
			{
				string text;
				return text;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0003B4D4 File Offset: 0x000396D4
		private bool IsCircular(ClaimsIdentity subject)
		{
			if (subject.m_actor != null)
			{
				return true;
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0003B4EC File Offset: 0x000396EC
		private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			if (info != null)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000E00 RID: 3584
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000E01 RID: 3585
		[NonSerialized]
		private List<Claim> m_instanceClaims;

		// Token: 0x04000E02 RID: 3586
		[NonSerialized]
		private Collection<IEnumerable<Claim>> m_externalClaims;

		// Token: 0x04000E03 RID: 3587
		[NonSerialized]
		private string m_nameType;

		// Token: 0x04000E04 RID: 3588
		[NonSerialized]
		private string m_roleType;

		// Token: 0x04000E05 RID: 3589
		[OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x04000E06 RID: 3590
		[OptionalField(VersionAdded = 2)]
		private ClaimsIdentity m_actor;

		// Token: 0x04000E07 RID: 3591
		[OptionalField(VersionAdded = 2)]
		private string m_authenticationType;

		// Token: 0x04000E08 RID: 3592
		[OptionalField(VersionAdded = 2)]
		private object m_bootstrapContext;

		// Token: 0x04000E09 RID: 3593
		[OptionalField(VersionAdded = 2)]
		private string m_label;

		// Token: 0x04000E0A RID: 3594
		[OptionalField(VersionAdded = 2)]
		private string m_serializedNameType;

		// Token: 0x04000E0B RID: 3595
		[OptionalField(VersionAdded = 2)]
		private string m_serializedRoleType;

		// Token: 0x04000E0C RID: 3596
		[OptionalField(VersionAdded = 2)]
		private string m_serializedClaims;

		// Token: 0x0200032F RID: 815
		[CompilerGenerated]
		private sealed class <get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
		{
			// Token: 0x06001B94 RID: 7060 RVA: 0x0003B690 File Offset: 0x00039890
			[DebuggerHidden]
			public <get_Claims>d__51(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.<>l__initialThreadId = currentManagedThreadId;
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x0003B6BC File Offset: 0x000398BC
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
				this.<>m__Finally1();
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x0003B6D8 File Offset: 0x000398D8
			private bool MoveNext()
			{
				int num = this.<>1__state;
				ClaimsIdentity claimsIdentity = this.<>4__this;
				long num2;
				if (num == 0)
				{
					num2 = 0L;
					this.<>1__state = num;
					int num3 = this.<i>5__2;
					this.<i>5__2 = (int)num2;
					List<Claim> instanceClaims = claimsIdentity.m_instanceClaims;
					int size = instanceClaims._size;
					if (claimsIdentity.m_externalClaims == null)
					{
						throw new OutOfMemoryException();
					}
					IEnumerator<Claim> enumerator = this.<>7__wrap2;
					this.<>1__state = instanceClaims;
				}
				if (claimsIdentity.m_externalClaims[(int)num2] != null)
				{
					IEnumerable<Claim> enumerable = claimsIdentity.m_externalClaims[(int)num2];
				}
				int count = claimsIdentity.m_externalClaims.Count;
				throw new OutOfMemoryException();
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0003B77C File Offset: 0x0003997C
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator<Claim> enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0003B7A0 File Offset: 0x000399A0
			Claim IEnumerator<Claim>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x0000207A File Offset: 0x0000027A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0003B7B4 File Offset: 0x000399B4
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (06001B9A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Security.Claims.ClaimsIdentity/<get_Claims>d__51::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Claim(var_0_06, ldfld:Claim('<get_Claims>d__51'::<>2__current, ldloc:'<get_Claims>d__51'(this)))
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

			// Token: 0x06001B9B RID: 7067 RVA: 0x0003B7C8 File Offset: 0x000399C8
			[DebuggerHidden]
			IEnumerator<Claim> IEnumerable<Claim>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06001B9B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<System.Security.Claims.Claim> System.Security.Claims.ClaimsIdentity/<get_Claims>d__51::System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<get_Claims>d__51'::<>1__state, ldloc:'<get_Claims>d__51'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<get_Claims>d__51'::<>l__initialThreadId, ldloc:'<get_Claims>d__51'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:int32(var_5_1E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:ClaimsIdentity(var_6_26, ldfld:ClaimsIdentity('<get_Claims>d__51'::<>4__this, ldloc:'<get_Claims>d__51'(this)))
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

			// Token: 0x06001B9C RID: 7068 RVA: 0x0003B7FC File Offset: 0x000399FC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06001B9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Security.Claims.ClaimsIdentity/<get_Claims>d__51::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.IEnumerator`1<class System.Security.Claims.Claim>(var_0_06, call:IEnumerator`1[exp:class System.Collections.Generic.IEnumerator`1<class System.Security.Claims.Claim>]('<get_Claims>d__51'::System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator, ldloc:'<get_Claims>d__51'(this)))
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

			// Token: 0x04000E0D RID: 3597
			private int <>1__state;

			// Token: 0x04000E0E RID: 3598
			private Claim <>2__current;

			// Token: 0x04000E0F RID: 3599
			private int <>l__initialThreadId;

			// Token: 0x04000E10 RID: 3600
			public ClaimsIdentity <>4__this;

			// Token: 0x04000E11 RID: 3601
			private int <i>5__2;

			// Token: 0x04000E12 RID: 3602
			private IEnumerator<Claim> <>7__wrap2;
		}
	}
}
