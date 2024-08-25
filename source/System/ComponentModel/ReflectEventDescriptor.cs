using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020003B3 RID: 947
	internal sealed class ReflectEventDescriptor : EventDescriptor
	{
		// Token: 0x06001942 RID: 6466 RVA: 0x00046BA4 File Offset: 0x00044DA4
		public ReflectEventDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
			: base(name, attributes)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._type = type;
			this._componentClass = componentClass;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00046BE0 File Offset: 0x00044DE0
		public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo)
		{
			if (!true)
			{
			}
			this._componentClass = componentClass;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00046C08 File Offset: 0x00044E08
		public ReflectEventDescriptor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes)
			: base(oldReflectEventDescriptor, attributes)
		{
			this._componentClass = componentType;
			this._type = oldReflectEventDescriptor;
			this._filledMethods = true;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00046C34 File Offset: 0x00044E34
		public override Type ComponentType
		{
			get
			{
				return this._componentClass;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00046C48 File Offset: 0x00044E48
		public override Type EventType
		{
			get
			{
				this.FillMethods();
				return this._type;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00046C64 File Offset: 0x00044E64
		public override bool IsMulticast
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001947)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ReflectEventDescriptor::get_IsMulticast()

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

		// Token: 0x06001948 RID: 6472 RVA: 0x00046C74 File Offset: 0x00044E74
		public override void AddEventHandler(object component, Delegate value)
		{
			this.FillMethods();
			if (component == null)
			{
				return;
			}
			ISite site = MemberDescriptor.GetSite(component);
			if (site != null)
			{
				return;
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00046D04 File Offset: 0x00044F04
		protected override void FillAttributes(IList attributes)
		{
			this.FillMethods();
			EventInfo realEvent = this._realEvent;
			EventInfo realEvent2 = this._realEvent;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00046D3C File Offset: 0x00044F3C
		private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
		{
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00046D70 File Offset: 0x00044F70
		private void FillMethods()
		{
			if (this._filledMethods)
			{
				return;
			}
			EventInfo realEvent = this._realEvent;
			Type componentClass = this._componentClass;
			EventInfo eventInfo;
			this._realEvent = eventInfo;
			Type type = this._type;
			if (type == null || type != null)
			{
				Type componentClass2 = this._componentClass;
				MethodInfo methodInfo;
				this._addMethod = methodInfo;
				Type componentClass3 = this._componentClass;
				MethodInfo addMethod = this._addMethod;
				MethodInfo methodInfo2;
				this._removeMethod = methodInfo2;
				MethodInfo removeMethod = this._removeMethod;
				string text = SR.Format("Accessor methods for the {0} event are missing.", this);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00046DF4 File Offset: 0x00044FF4
		private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
		{
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00046E28 File Offset: 0x00045028
		public override void RemoveEventHandler(object component, Delegate value)
		{
			this.FillMethods();
			if (component == null)
			{
				return;
			}
			ISite site = MemberDescriptor.GetSite(component);
			if (site != null)
			{
				return;
			}
		}

		// Token: 0x040012BC RID: 4796
		private Type _type;

		// Token: 0x040012BD RID: 4797
		private readonly Type _componentClass;

		// Token: 0x040012BE RID: 4798
		private MethodInfo _addMethod;

		// Token: 0x040012BF RID: 4799
		private MethodInfo _removeMethod;

		// Token: 0x040012C0 RID: 4800
		private EventInfo _realEvent;

		// Token: 0x040012C1 RID: 4801
		private bool _filledMethods;
	}
}
