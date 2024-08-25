using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000514 RID: 1300
	[Serializable]
	[StructLayout(0)]
	internal class RuntimePropertyInfo : PropertyInfo, ISerializable
	{
		// Token: 0x06002640 RID: 9792 RVA: 0x00053B9C File Offset: 0x00051D9C
		internal static void get_property_info(RuntimePropertyInfo prop, MonoPropertyInfo info, PInfo req_info)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x00053BAC File Offset: 0x00051DAC
		internal BindingFlags BindingFlags
		{
			get
			{
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x00053BBC File Offset: 0x00051DBC
		public override Module Module
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002642)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Module System.Reflection.RuntimePropertyInfo::get_Module()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeModule(var_0_0B, call:RuntimeModule(RuntimeType::GetRuntimeModule, call:RuntimeType(RuntimePropertyInfo::GetDeclaringTypeInternal, ldloc:RuntimePropertyInfo(this))))
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

		// Token: 0x06002643 RID: 9795 RVA: 0x00053BD4 File Offset: 0x00051DD4
		internal RuntimeType GetDeclaringTypeInternal()
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00053BEC File Offset: 0x00051DEC
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				if (this != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00053C04 File Offset: 0x00051E04
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00053C1C File Offset: 0x00051E1C
		public override string ToString()
		{
			long num = 0L;
			return this.FormatNameAndSig(num != 0L);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00053C34 File Offset: 0x00051E34
		private string FormatNameAndSig(bool serialization)
		{
			/*
An exception occurred when decompiling this method (06002647)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Reflection.RuntimePropertyInfo::FormatNameAndSig(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:native int[exp:bool](RuntimePropertyInfo::prop, ldloc:RuntimePropertyInfo(this))))
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

		// Token: 0x06002648 RID: 9800 RVA: 0x00053C48 File Offset: 0x00051E48
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			RuntimeType reflectedTypeInternal = this.ReflectedTypeInternal;
			string text = this.FormatNameAndSig(true);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00053C68 File Offset: 0x00051E68
		internal string SerializationToString()
		{
			return this.FormatNameAndSig(true);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00053C7C File Offset: 0x00051E7C
		private void CachePropertyInfo(PInfo flags)
		{
			PInfo pinfo = this.cached;
			PInfo pinfo2 = this.cached;
			this.cached = pinfo2;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x00053CA0 File Offset: 0x00051EA0
		public override bool CanRead
		{
			get
			{
				PInfo pinfo = this.cached;
				PInfo pinfo2 = this.cached;
				this.cached = pinfo2;
				MethodInfo get_method = this.info.get_method;
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00053CD0 File Offset: 0x00051ED0
		public override bool CanWrite
		{
			get
			{
				PInfo pinfo = this.cached;
				PInfo pinfo2 = this.cached;
				this.cached = pinfo2;
				MethodInfo set_method = this.info.set_method;
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00053D00 File Offset: 0x00051F00
		public override Type PropertyType
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600264D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Reflection.RuntimePropertyInfo::get_PropertyType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PInfo(var_0_06, ldfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this)))
	stloc:PInfo(var_1_0D, ldfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this)))
	stfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this), ldloc:PInfo(var_1_0D))
	stloc:MethodInfo(var_2_20, ldfld:MethodInfo(MonoPropertyInfo::get_method, ldfld:MonoPropertyInfo[exp:valuetype System.Reflection.MonoPropertyInfo&](RuntimePropertyInfo::info, ldloc:RuntimePropertyInfo(this))))
	stloc:MethodInfo(var_4_2C, ldfld:MethodInfo(MonoPropertyInfo::get_method, ldfld:MonoPropertyInfo[exp:valuetype System.Reflection.MonoPropertyInfo&](RuntimePropertyInfo::info, ldloc:RuntimePropertyInfo(this))))
	stloc:MethodInfo(var_5_39, ldfld:MethodInfo(MonoPropertyInfo::set_method, ldfld:MonoPropertyInfo[exp:valuetype System.Reflection.MonoPropertyInfo&](RuntimePropertyInfo::info, ldloc:RuntimePropertyInfo(this))))
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x00053D48 File Offset: 0x00051F48
		public override Type ReflectedType
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600264E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Reflection.RuntimePropertyInfo::get_ReflectedType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PInfo(var_0_06, ldfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this)))
	stloc:PInfo(var_1_0D, ldfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this)))
	stfld:PInfo(RuntimePropertyInfo::cached, ldloc:RuntimePropertyInfo(this), ldloc:PInfo(var_1_0D))
	stloc:MonoPropertyInfo(var_2_1B, ldfld:MonoPropertyInfo(RuntimePropertyInfo::info, ldloc:RuntimePropertyInfo(this)))
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00053D70 File Offset: 0x00051F70
		public override Type DeclaringType
		{
			get
			{
				PInfo pinfo = this.cached;
				PInfo pinfo2 = this.cached;
				this.cached = pinfo2;
				return this.info.declaring_type;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00053DA0 File Offset: 0x00051FA0
		public override string Name
		{
			get
			{
				PInfo pinfo = this.cached;
				PInfo pinfo2 = this.cached;
				this.cached = pinfo2;
				return this.info.name;
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00053DD0 File Offset: 0x00051FD0
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			PInfo pinfo = this.cached;
			PInfo pinfo2 = this.cached;
			this.cached = pinfo2;
			MethodInfo get_method = this.info.get_method;
			bool isPublic = this.info.get_method.IsPublic;
			return this.info.get_method;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00053E1C File Offset: 0x0005201C
		public override ParameterInfo[] GetIndexParameters()
		{
			PInfo pinfo = this.cached;
			PInfo pinfo2 = this.cached;
			this.cached = pinfo2;
			MethodInfo get_method = this.info.get_method;
			MethodInfo get_method2 = this.info.get_method;
			MethodInfo set_method = this.info.set_method;
			MethodInfo set_method2 = this.info.set_method;
			ParameterInfo parameterInfo;
			if (parameterInfo == null || parameterInfo != null)
			{
				return parameterInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00053E84 File Offset: 0x00052084
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			PInfo pinfo = this.cached;
			PInfo pinfo2 = this.cached;
			this.cached = pinfo2;
			MethodInfo set_method = this.info.set_method;
			bool isPublic = this.info.set_method.IsPublic;
			return this.info.set_method;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00053ED0 File Offset: 0x000520D0
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			long num = 0L;
			return MonoCustomAttrs.IsDefined(this, attributeType, num != 0L);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00053EEC File Offset: 0x000520EC
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			long num = 0L;
			return MonoCustomAttrs.GetCustomAttributes(this, num != 0L);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00053F08 File Offset: 0x00052108
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			long num = 0L;
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, num != 0L);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00053F24 File Offset: 0x00052124
		private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj)
		{
			while (getter == null || getter != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0000207A File Offset: 0x0000027A
		private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0000207A File Offset: 0x0000027A
		public override object GetValue(object obj, object[] index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00053F3C File Offset: 0x0005213C
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			if (index != null)
			{
				return;
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00053F50 File Offset: 0x00052150
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			if (index != null)
			{
				if (value == null || value != null)
				{
					return;
				}
			}
			else if (value == null || value != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x0000207A File Offset: 0x0000027A
		public override int MetadataToken
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int get_metadata_token(RuntimePropertyInfo monoProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0000207A File Offset: 0x0000027A
		private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00053F78 File Offset: 0x00052178
		internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
		{
			return "The handle is invalid.";
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00053F8C File Offset: 0x0005218C
		public RuntimePropertyInfo()
		{
		}

		// Token: 0x0400150D RID: 5389
		internal IntPtr klass;

		// Token: 0x0400150E RID: 5390
		internal IntPtr prop;

		// Token: 0x0400150F RID: 5391
		private MonoPropertyInfo info;

		// Token: 0x04001510 RID: 5392
		private PInfo cached;

		// Token: 0x04001511 RID: 5393
		private RuntimePropertyInfo.GetterAdapter cached_getter;

		// Token: 0x02000515 RID: 1301
		private sealed class GetterAdapter : MulticastDelegate
		{
			// Token: 0x06002661 RID: 9825 RVA: 0x00053FA0 File Offset: 0x000521A0
			public GetterAdapter(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002662 RID: 9826 RVA: 0x00054000 File Offset: 0x00052200
			public object Invoke(object _this)
			{
				/*
An exception occurred when decompiling this method (06002662)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Reflection.RuntimePropertyInfo/GetterAdapter::Invoke(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetterAdapter[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetterAdapter[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetterAdapter[exp:Delegate](this)))
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

		// Token: 0x02000516 RID: 1302
		private sealed class Getter<T, R> : MulticastDelegate
		{
			// Token: 0x06002663 RID: 9827 RVA: 0x00054024 File Offset: 0x00052224
			public Getter(object @object, IntPtr method)
			{
			}

			// Token: 0x06002664 RID: 9828 RVA: 0x0000207A File Offset: 0x0000027A
			public R Invoke(T _this)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000517 RID: 1303
		private sealed class StaticGetter<R> : MulticastDelegate
		{
			// Token: 0x06002665 RID: 9829 RVA: 0x00054044 File Offset: 0x00052244
			public StaticGetter(object @object, IntPtr method)
			{
			}

			// Token: 0x06002666 RID: 9830 RVA: 0x0000207A File Offset: 0x0000027A
			public R Invoke()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
