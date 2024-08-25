using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200013B RID: 315
	internal sealed class TrackingValidationObjectDictionary : global::System.Collections.Specialized.StringDictionary
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x0001ABAC File Offset: 0x00018DAC
		internal TrackingValidationObjectDictionary(Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> validators)
		{
			this._validators = validators;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		private void PersistValue(string key, string value, bool addValue)
		{
			string text = key.ToLowerInvariant();
			bool flag = string.IsNullOrEmpty(value);
			if (this._validators == null)
			{
				return;
			}
			if (this._internalObjects != null)
			{
				return;
			}
			this.<IsChanged>k__BackingField = true;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0001ABFC File Offset: 0x00018DFC
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x0001AC10 File Offset: 0x00018E10
		internal bool IsChanged
		{
			[CompilerGenerated]
			get
			{
				return this.<IsChanged>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001AC20 File Offset: 0x00018E20
		internal object InternalGet(string key)
		{
			/*
An exception occurred when decompiling this method (06000783)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Net.TrackingValidationObjectDictionary::InternalGet(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_0_0F, callgetter:string(StringDictionary::get_Item, ldloc:TrackingValidationObjectDictionary[exp:StringDictionary](this), ldloc:string(key)))
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

		// Token: 0x06000784 RID: 1924 RVA: 0x0001AC3C File Offset: 0x00018E3C
		internal void InternalSet(string key, object value)
		{
			if (this._internalObjects == null)
			{
			}
			this.<IsChanged>k__BackingField = true;
		}

		// Token: 0x17000191 RID: 401
		public override string this[string key]
		{
			get
			{
				return base[key];
			}
			set
			{
				long num = 0L;
				this.PersistValue(key, value, num != 0L);
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001AC84 File Offset: 0x00018E84
		public override void Add(string key, string value)
		{
			this.PersistValue(key, value, true);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001AC9C File Offset: 0x00018E9C
		public override void Clear()
		{
			if (this._internalObjects != null)
			{
			}
			base.Clear();
			this.<IsChanged>k__BackingField = true;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		public override void Remove(string key)
		{
			if (this._internalObjects != null)
			{
			}
			base.Remove(key);
			this.<IsChanged>k__BackingField = true;
		}

		// Token: 0x040005EF RID: 1519
		private readonly Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> _validators;

		// Token: 0x040005F0 RID: 1520
		private Dictionary<string, object> _internalObjects;

		// Token: 0x040005F1 RID: 1521
		[CompilerGenerated]
		private bool <IsChanged>k__BackingField;

		// Token: 0x0200013C RID: 316
		internal sealed class ValidateAndParseValue : MulticastDelegate
		{
			// Token: 0x0600078A RID: 1930 RVA: 0x0001ACE4 File Offset: 0x00018EE4
			public ValidateAndParseValue(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x0001AD44 File Offset: 0x00018F44
			public object Invoke(object valueToValidate)
			{
				/*
An exception occurred when decompiling this method (0600078B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Net.TrackingValidationObjectDictionary/ValidateAndParseValue::Invoke(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ValidateAndParseValue[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ValidateAndParseValue[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ValidateAndParseValue[exp:Delegate](this)))
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

			// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(object valueToValidate, AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
			public object EndInvoke(IAsyncResult result)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
