using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x0200050C RID: 1292
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x00052E50 File Offset: 0x00051050
		internal BindingFlags BindingFlags
		{
			get
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00052E60 File Offset: 0x00051060
		public override Module Module
		{
			get
			{
				/*
An exception occurred when decompiling this method (060025A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Module System.Reflection.RuntimeFieldInfo::get_Module()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeModule(var_0_0B, call:RuntimeModule(RuntimeType::GetRuntimeModule, call:RuntimeType(RuntimeFieldInfo::GetDeclaringTypeInternal, ldloc:RuntimeFieldInfo(this))))
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

		// Token: 0x060025A4 RID: 9636 RVA: 0x00052E78 File Offset: 0x00051078
		internal RuntimeType GetDeclaringTypeInternal()
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00052E90 File Offset: 0x00051090
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

		// Token: 0x060025A6 RID: 9638 RVA: 0x00052EA8 File Offset: 0x000510A8
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00052EC0 File Offset: 0x000510C0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			RuntimeType reflectedTypeInternal = this.ReflectedTypeInternal;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0000207A File Offset: 0x0000027A
		internal override object UnsafeGetValue(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00052ED8 File Offset: 0x000510D8
		internal override void CheckConsistency(object target)
		{
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00052F10 File Offset: 0x00051110
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00052F20 File Offset: 0x00051120
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override void SetValueDirect(TypedReference obj, object value)
		{
			bool isNull = obj.IsNull;
			if (this != null)
			{
			}
			if (this != null)
			{
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00052F54 File Offset: 0x00051154
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00052F68 File Offset: 0x00051168
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				return this.fhandle;
			}
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x0000207A File Offset: 0x0000027A
		private Type ResolveType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00052F7C File Offset: 0x0005117C
		public override Type FieldType
		{
			get
			{
				Type type = this.type;
				if (!true)
				{
				}
				this.type = this;
				return this.type;
			}
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0000207A File Offset: 0x0000027A
		private Type GetParentType(bool declaring)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type ReflectedType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type DeclaringType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00052FA0 File Offset: 0x000511A0
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00052FB4 File Offset: 0x000511B4
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00052FCC File Offset: 0x000511CC
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00052FE4 File Offset: 0x000511E4
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0000207A File Offset: 0x0000027A
		internal override int GetFieldOffset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0000207A File Offset: 0x0000027A
		private object GetValueInternal(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00052FFC File Offset: 0x000511FC
		public override object GetValue(object obj)
		{
			/*
An exception occurred when decompiling this method (060025B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Reflection.RuntimeFieldInfo::GetValue(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:string(var_4_2B, call:string(string::Format, ldstr:string("Field {0} defined on type {1} is not a field on the target object which is of type {2}."), ldloc:RuntimeFieldInfo[exp:object](this), ldloc:RuntimeFieldInfo[exp:object](this), ldloc:Type[exp:object](var_3)))
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

		// Token: 0x060025BA RID: 9658 RVA: 0x00053038 File Offset: 0x00051238
		public override string ToString()
		{
			string text = this.name;
			return string.Format("{0} {1}", this, text);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00053058 File Offset: 0x00051258
		private static void SetValueInternal(FieldInfo fi, object obj, object value)
		{
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00053068 File Offset: 0x00051268
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			/*
An exception occurred when decompiling this method (060025BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Reflection.RuntimeFieldInfo::SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Globalization.CultureInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:string(var_7_48, call:string(string::Format, ldstr:string("Field {0} defined on type {1} is not a field on the target object which is of type {2}."), ldloc:RuntimeFieldInfo[exp:object](this), ldloc:RuntimeFieldInfo[exp:object](this), ldloc:Type[exp:object](var_6)))
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

		// Token: 0x060025BD RID: 9661 RVA: 0x0000207A File Offset: 0x0000027A
		public override object GetRawConstantValue()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000530C0 File Offset: 0x000512C0
		private void CheckGeneric()
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0000207A File Offset: 0x0000027A
		public override int MetadataToken
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int get_metadata_token(RuntimeFieldInfo monoField)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000530D0 File Offset: 0x000512D0
		public RuntimeFieldInfo()
		{
		}

		// Token: 0x040014E8 RID: 5352
		internal IntPtr klass;

		// Token: 0x040014E9 RID: 5353
		internal RuntimeFieldHandle fhandle;

		// Token: 0x040014EA RID: 5354
		private string name;

		// Token: 0x040014EB RID: 5355
		private Type type;

		// Token: 0x040014EC RID: 5356
		private FieldAttributes attrs;
	}
}
