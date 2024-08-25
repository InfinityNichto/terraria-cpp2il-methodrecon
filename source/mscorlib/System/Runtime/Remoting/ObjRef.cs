using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	// Token: 0x02000342 RID: 834
	[ComVisible(true)]
	[Serializable]
	public class ObjRef : IObjectReference, ISerializable
	{
		// Token: 0x06001BD4 RID: 7124 RVA: 0x0003BEF4 File Offset: 0x0003A0F4
		public ObjRef()
		{
			this.UpdateChannelInfo();
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0003BF10 File Offset: 0x0003A110
		internal ObjRef(string uri, IChannelInfo cinfo)
		{
			this.channel_info = cinfo;
			this.uri = uri;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0003BF34 File Offset: 0x0003A134
		internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
		{
			string text = string.Copy(this.uri);
			object obj = CADSerializer.DeserializeObjectSafe(tInfo);
			if (obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0003BF60 File Offset: 0x0003A160
		internal byte[] SerializeType()
		{
			/*
An exception occurred when decompiling this method (06001BD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Runtime.Remoting.ObjRef::SerializeType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:IRemotingTypeInfo[exp:bool](ObjRef::typeInfo, ldloc:ObjRef(this))))
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

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0003BF74 File Offset: 0x0003A174
		internal ObjRef(Type type, string url, object remoteChannelData)
		{
			this.uri = url;
			if (remoteChannelData != null)
			{
			}
			int num = this.flags;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0003BF98 File Offset: 0x0003A198
		protected ObjRef(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			string name = enumerator.Name;
			bool flag2 = name == "uri";
			object value = enumerator.Value;
			if (value != null)
			{
				this.uri = value;
				return;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0003C098 File Offset: 0x0003A298
		internal bool IsReferenceToWellKnow
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BDA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.ObjRef::get_IsReferenceToWellKnow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(ObjRef::flags, ldloc:ObjRef(this)))
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		public virtual IChannelInfo ChannelInfo
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.channel_info;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0003C0D8 File Offset: 0x0003A2D8
		public virtual IEnvoyInfo EnvoyInfo
		{
			get
			{
				return this.envoyInfo;
			}
			set
			{
				this.envoyInfo = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0003C0EC File Offset: 0x0003A2EC
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0003C100 File Offset: 0x0003A300
		public virtual IRemotingTypeInfo TypeInfo
		{
			get
			{
				return this.typeInfo;
			}
			set
			{
				this.typeInfo = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0003C114 File Offset: 0x0003A314
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0003C128 File Offset: 0x0003A328
		public virtual string URI
		{
			get
			{
				return this.uri;
			}
			set
			{
				this.uri = value;
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0003C13C File Offset: 0x0003A33C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			Type type = base.GetType();
			string text = this.uri;
			IRemotingTypeInfo remotingTypeInfo = this.typeInfo;
			if (!true)
			{
			}
			IEnvoyInfo envoyInfo = this.envoyInfo;
			IChannelInfo channelInfo = this.channel_info;
			int num = this.flags;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0003C17C File Offset: 0x0003A37C
		public virtual object GetRealObject(StreamingContext context)
		{
			int num = this.flags;
			if (!true)
			{
			}
			return RemotingServices.Unmarshal(this);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0003C19C File Offset: 0x0003A39C
		internal void UpdateChannelInfo()
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0003C1AC File Offset: 0x0003A3AC
		internal Type ServerType
		{
			get
			{
				int num = 1;
				Type serverType = this._serverType;
				if (num == 0)
				{
				}
				IRemotingTypeInfo remotingTypeInfo = this.typeInfo;
				return this._serverType;
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRef()
		{
		}

		// Token: 0x04000E2A RID: 3626
		private IChannelInfo channel_info;

		// Token: 0x04000E2B RID: 3627
		private string uri;

		// Token: 0x04000E2C RID: 3628
		private IRemotingTypeInfo typeInfo;

		// Token: 0x04000E2D RID: 3629
		private IEnvoyInfo envoyInfo;

		// Token: 0x04000E2E RID: 3630
		private int flags;

		// Token: 0x04000E2F RID: 3631
		private Type _serverType;

		// Token: 0x04000E30 RID: 3632
		private static int MarshalledObjectRef;

		// Token: 0x04000E31 RID: 3633
		private static int WellKnowObjectRef;
	}
}
