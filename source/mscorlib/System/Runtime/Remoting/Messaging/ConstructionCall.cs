using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A3 RID: 931
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
	{
		// Token: 0x06001DE1 RID: 7649 RVA: 0x000414BC File Offset: 0x0003F6BC
		internal ConstructionCall(Type type)
		{
			this._activationType = type;
			this._activationTypeName = type;
			this._isContextOk = true;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000414E4 File Offset: 0x0003F6E4
		internal ConstructionCall(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000414FC File Offset: 0x0003F6FC
		internal override void InitDictionary()
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0004150C File Offset: 0x0003F70C
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00041520 File Offset: 0x0003F720
		internal bool IsContextOk
		{
			get
			{
				return this._isContextOk;
			}
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00041530 File Offset: 0x0003F730
		public Type ActivationType
		{
			get
			{
				Type activationType = this._activationType;
				if (!true)
				{
				}
				string activationTypeName = this._activationTypeName;
				if (!true)
				{
				}
				this._activationType = activationTypeName;
				return this._activationType;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00041560 File Offset: 0x0003F760
		public string ActivationTypeName
		{
			get
			{
				return this._activationTypeName;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00041574 File Offset: 0x0003F774
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00041588 File Offset: 0x0003F788
		public IActivator Activator
		{
			get
			{
				return this._activator;
			}
			set
			{
				this._activator = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0004159C File Offset: 0x0003F79C
		public object[] CallSiteActivationAttributes
		{
			get
			{
				return this._activationAttributes;
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000415B0 File Offset: 0x0003F7B0
		internal void SetActivationAttributes(object[] attributes)
		{
			this._activationAttributes = attributes;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x000415C4 File Offset: 0x0003F7C4
		public IList ContextProperties
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001DEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IList System.Runtime.Remoting.Messaging.ConstructionCall::get_ContextProperties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:IList[exp:bool](ConstructionCall::_contextProperties, ldloc:ConstructionCall(this)))
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

		// Token: 0x06001DED RID: 7661 RVA: 0x000415D8 File Offset: 0x0003F7D8
		internal override void InitMethodProperty(string key, object value)
		{
			bool flag = key == "__Activator";
			if (value == null)
			{
				return;
			}
			if (value != null)
			{
				this._activator = value;
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00041640 File Offset: 0x0003F840
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (this._contextProperties != null)
			{
				return;
			}
			IActivator activator = this._activator;
			object[] activationAttributes = this._activationAttributes;
			string activationTypeName = this._activationTypeName;
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00041670 File Offset: 0x0003F870
		public override IDictionary Properties
		{
			get
			{
				while (this.ExternalProperties != null)
				{
				}
				return this.ExternalProperties;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0004168C File Offset: 0x0003F88C
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x000416A0 File Offset: 0x0003F8A0
		internal RemotingProxy SourceProxy
		{
			get
			{
				return this._sourceProxy;
			}
			set
			{
				this._sourceProxy = value;
			}
		}

		// Token: 0x04000F19 RID: 3865
		private IActivator _activator;

		// Token: 0x04000F1A RID: 3866
		private object[] _activationAttributes;

		// Token: 0x04000F1B RID: 3867
		private IList _contextProperties;

		// Token: 0x04000F1C RID: 3868
		private Type _activationType;

		// Token: 0x04000F1D RID: 3869
		private string _activationTypeName;

		// Token: 0x04000F1E RID: 3870
		private bool _isContextOk;

		// Token: 0x04000F1F RID: 3871
		[NonSerialized]
		private RemotingProxy _sourceProxy;
	}
}
