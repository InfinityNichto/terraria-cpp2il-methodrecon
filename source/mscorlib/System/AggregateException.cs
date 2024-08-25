using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	// Token: 0x02000081 RID: 129
	[DebuggerDisplay("Count = {InnerExceptionCount}")]
	[Serializable]
	public class AggregateException : Exception
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x0000BB84 File Offset: 0x00009D84
		public AggregateException()
		{
			if (!true)
			{
			}
			base..ctor("One or more errors occurred.");
			if (!true)
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		public AggregateException(IEnumerable<Exception> innerExceptions)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public AggregateException(params Exception[] innerExceptions)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		public AggregateException(string message, IEnumerable<Exception> innerExceptions)
		{
			if (innerExceptions == null && innerExceptions != null)
			{
				return;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public AggregateException(string message, params Exception[] innerExceptions)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		private AggregateException(string message, IList<Exception> innerExceptions)
		{
			if (innerExceptions != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000BC14 File Offset: 0x00009E14
		internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000BC24 File Offset: 0x00009E24
		internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
		{
			if (innerExceptionInfos == null && innerExceptionInfos != null)
			{
				return;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000BC38 File Offset: 0x00009E38
		private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
		{
			if (innerExceptionInfos != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000BC74 File Offset: 0x00009E74
		protected AggregateException(SerializationInfo info, StreamingContext context)
		{
			Type type;
			do
			{
				if (!true)
				{
				}
				base..ctor(info, context);
				if (info == null)
				{
					return;
				}
			}
			while (info.GetValue("InnerExceptions", type) == null);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			ReadOnlyCollection<Exception> innerExceptions = this.m_innerExceptions;
			if (this.m_innerExceptions == null)
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public ReadOnlyCollection<Exception> InnerExceptions
		{
			get
			{
				return this.m_innerExceptions;
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		public AggregateException Flatten()
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public override string Message
		{
			get
			{
				if (this.m_innerExceptions != null)
				{
					StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
					string message = base.Message;
					StringBuilder stringBuilder2 = stringBuilder.Append(message);
					int num = 32;
					StringBuilder stringBuilder3 = stringBuilder.Append((char)num);
					ReadOnlyCollection<Exception> innerExceptions = this.m_innerExceptions;
					int num2 = 40;
					StringBuilder stringBuilder4 = stringBuilder.Append((char)num2);
					ReadOnlyCollection<Exception> innerExceptions2 = this.m_innerExceptions;
					StringBuilder stringBuilder5 = stringBuilder.Append(") ");
					ReadOnlyCollection<Exception> innerExceptions3 = this.m_innerExceptions;
					long num3 = 0L;
					int length = stringBuilder.Length;
					stringBuilder.Length = (int)num3;
					return StringBuilderCache.GetStringAndRelease(stringBuilder);
				}
				return base.Message;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000BD78 File Offset: 0x00009F78
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060003C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.AggregateException::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:CultureInfo(var_8_1E, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:class System.Collections.ObjectModel.ReadOnlyCollection`1<class System.Exception>(var_10_26, ldfld:class System.Collections.ObjectModel.ReadOnlyCollection`1<class System.Exception>(AggregateException::m_innerExceptions, ldloc:AggregateException(this)))
	stloc:class System.Collections.ObjectModel.ReadOnlyCollection`1<class System.Exception>(var_14_2E, ldfld:class System.Collections.ObjectModel.ReadOnlyCollection`1<class System.Exception>(AggregateException::m_innerExceptions, ldloc:AggregateException(this)))
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

		// Token: 0x040001DA RID: 474
		private ReadOnlyCollection<Exception> m_innerExceptions;
	}
}
