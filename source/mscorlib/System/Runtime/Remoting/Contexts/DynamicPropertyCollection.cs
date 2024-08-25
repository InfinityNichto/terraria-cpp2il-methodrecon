using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000366 RID: 870
	internal class DynamicPropertyCollection
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		public bool HasProperties
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001CFF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Contexts.DynamicPropertyCollection::get_HasProperties()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(DynamicPropertyCollection::_properties, ldloc:DynamicPropertyCollection(this)))
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

		// Token: 0x06001D00 RID: 7424 RVA: 0x0003F404 File Offset: 0x0003D604
		public bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			ArrayList properties = this._properties;
			if (prop != null)
			{
			}
			long num = 0L;
			int num2;
			this._properties = num2;
			Monitor.Exit(this);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0003F450 File Offset: 0x0003D650
		public bool UnregisterDynamicProperty(string name)
		{
			int num = this.FindProperty(name);
			long num2 = 0L;
			Monitor.Exit(this);
			if (num2 == 0L)
			{
				return true;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0003F490 File Offset: 0x0003D690
		public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
			ArrayList properties = this._properties;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0003F544 File Offset: 0x0003D744
		private int FindProperty(string name)
		{
			ArrayList properties = this._properties;
			ArrayList properties2 = this._properties;
			if (properties2 != null)
			{
			}
			object[] items = properties2._items;
			ArrayList properties3 = this._properties;
			throw new InvalidCastException();
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0003F578 File Offset: 0x0003D778
		public DynamicPropertyCollection()
		{
		}

		// Token: 0x04000EB0 RID: 3760
		private ArrayList _properties;

		// Token: 0x02000367 RID: 871
		private class DynamicPropertyReg
		{
			// Token: 0x06001D05 RID: 7429 RVA: 0x0003F58C File Offset: 0x0003D78C
			public DynamicPropertyReg()
			{
			}

			// Token: 0x04000EB1 RID: 3761
			public IDynamicProperty Property;

			// Token: 0x04000EB2 RID: 3762
			public IDynamicMessageSink Sink;
		}
	}
}
