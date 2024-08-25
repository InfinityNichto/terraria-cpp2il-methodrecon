using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004D4 RID: 1236
	[Serializable]
	public abstract class FieldInfo : MemberInfo
	{
		// Token: 0x06002390 RID: 9104 RVA: 0x0005060C File Offset: 0x0004E80C
		protected FieldInfo()
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x00050620 File Offset: 0x0004E820
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Field;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002392 RID: 9106
		public abstract FieldAttributes Attributes { get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002393 RID: 9107
		public abstract Type FieldType { get; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsInitOnly
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsLiteral
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsNotSerialized
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsStatic
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsPrivate
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsPublic
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600239A RID: 9114
		public abstract RuntimeFieldHandle FieldHandle { get; }

		// Token: 0x0600239B RID: 9115 RVA: 0x00050630 File Offset: 0x0004E830
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00050644 File Offset: 0x0004E844
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00050658 File Offset: 0x0004E858
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			if (left != null)
			{
			}
			return true;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0005066C File Offset: 0x0004E86C
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			/*
An exception occurred when decompiling this method (0600239E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.FieldInfo::op_Inequality(System.Reflection.FieldInfo,System.Reflection.FieldInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:FieldInfo[exp:bool](left)))
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

		// Token: 0x0600239F RID: 9119
		public abstract object GetValue(object obj);

		// Token: 0x060023A0 RID: 9120 RVA: 0x0005067C File Offset: 0x0004E87C
		[DebuggerStepThrough]
		[DebuggerHidden]
		public void SetValue(object obj, object value)
		{
			if (!true)
			{
			}
			Binder defaultBinder = Type.DefaultBinder;
		}

		// Token: 0x060023A1 RID: 9121
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		// Token: 0x060023A2 RID: 9122 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public virtual void SetValueDirect(TypedReference obj, object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual object GetRawConstantValue()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0000207A File Offset: 0x0000027A
		private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0000207A File Offset: 0x0000027A
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00050694 File Offset: 0x0004E894
		[ComVisible(false)]
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			bool flag;
			while (!flag)
			{
			}
			return "The handle is invalid.";
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual int GetFieldOffset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0000207A File Offset: 0x0000027A
		private MarshalAsAttribute get_marshal_info()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000506AC File Offset: 0x0004E8AC
		internal object[] GetPseudoCustomAttributes()
		{
			if (this != null)
			{
			}
			if (this == null || this != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000506CC File Offset: 0x0004E8CC
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			if (this != null)
			{
			}
			Type type;
			Type type2;
			if ((type == null || type != null) && this != null && (type2 == null || type2 != null))
			{
			}
			throw new ArrayTypeMismatchException();
		}
	}
}
