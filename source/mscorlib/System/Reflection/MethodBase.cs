using System;
using System.Diagnostics;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004DD RID: 1245
	[Serializable]
	public abstract class MethodBase : MemberInfo
	{
		// Token: 0x060023C6 RID: 9158 RVA: 0x000508FC File Offset: 0x0004EAFC
		protected MethodBase()
		{
		}

		// Token: 0x060023C7 RID: 9159
		public abstract ParameterInfo[] GetParameters();

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060023C8 RID: 9160
		public abstract MethodAttributes Attributes { get; }

		// Token: 0x060023C9 RID: 9161
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		// Token: 0x060023CA RID: 9162 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual MethodBody GetMethodBody()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00050910 File Offset: 0x0004EB10
		public virtual CallingConventions CallingConvention
		{
			get
			{
				return CallingConventions.Standard;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsAbstract
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x00050920 File Offset: 0x0004EB20
		public bool IsConstructor
		{
			get
			{
				if (this != null)
				{
					return;
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsStatic
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsVirtual
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsPublic
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00050934 File Offset: 0x0004EB34
		public virtual bool IsGenericMethod
		{
			get
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x00050944 File Offset: 0x0004EB44
		public virtual bool IsGenericMethodDefinition
		{
			get
			{
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual Type[] GetGenericArguments()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x00050954 File Offset: 0x0004EB54
		public virtual bool ContainsGenericParameters
		{
			get
			{
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0000207A File Offset: 0x0000027A
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke(object obj, object[] parameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023D6 RID: 9174
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060023D7 RID: 9175
		public abstract RuntimeMethodHandle MethodHandle { get; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x00050964 File Offset: 0x0004EB64
		public virtual bool IsSecurityCritical
		{
			get
			{
				/*
An exception occurred when decompiling this method (060023D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.MethodBase::get_IsSecurityCritical()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_1_07, callgetter:Exception(NotImplemented::get_ByDesign))
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

		// Token: 0x060023D9 RID: 9177 RVA: 0x00050978 File Offset: 0x0004EB78
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0005098C File Offset: 0x0004EB8C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			for (;;)
			{
				int num = 1;
				if (left != null)
				{
					if (left != null)
					{
					}
					long num2 = 0L;
					if (num == 0)
					{
					}
					long num3 = 0L;
					if (num2 != 0L && num3 != 0L)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000509CC File Offset: 0x0004EBCC
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual int GetParametersCount()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual string FormatNameAndSig(bool serialization)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000509DC File Offset: 0x0004EBDC
		internal virtual Type[] GetParameterTypes()
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual ParameterInfo[] GetParametersNoCopy()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000509F0 File Offset: 0x0004EBF0
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			MethodBase methodBase;
			return methodBase;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00050A20 File Offset: 0x0004EC20
		internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
		{
		}
	}
}
