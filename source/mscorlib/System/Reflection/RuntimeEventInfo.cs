using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x0200050A RID: 1290
	[Serializable]
	[StructLayout(0)]
	internal sealed class RuntimeEventInfo : EventInfo, ISerializable
	{
		// Token: 0x06002588 RID: 9608 RVA: 0x00052CC4 File Offset: 0x00050EC4
		private static void get_event_info(RuntimeEventInfo ev, [Out] MonoEventInfo info)
		{
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00052CD4 File Offset: 0x00050ED4
		internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
		{
			MonoEventInfo monoEventInfo;
			return monoEventInfo;
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x00052CE4 File Offset: 0x00050EE4
		public override Module Module
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600258A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Module System.Reflection.RuntimeEventInfo::get_Module()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeModule(var_0_0B, call:RuntimeModule(RuntimeType::GetRuntimeModule, call:RuntimeType(RuntimeEventInfo::GetDeclaringTypeInternal, ldloc:RuntimeEventInfo(this))))
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00052CFC File Offset: 0x00050EFC
		internal BindingFlags BindingFlags
		{
			get
			{
				return this.GetBindingFlags();
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00052D10 File Offset: 0x00050F10
		internal RuntimeType GetDeclaringTypeInternal()
		{
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00052D28 File Offset: 0x00050F28
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

		// Token: 0x0600258E RID: 9614 RVA: 0x00052D40 File Offset: 0x00050F40
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00052D58 File Offset: 0x00050F58
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			RuntimeType reflectedTypeInternal = this.ReflectedTypeInternal;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00052D70 File Offset: 0x00050F70
		internal BindingFlags GetBindingFlags()
		{
			long num = 0L;
			RuntimeType declaringTypeInternal = this.GetDeclaringTypeInternal();
			long num2 = 0L;
			long num3 = 0L;
			return RuntimeType.FilterPreCalculate(num != 0L, num3 != 0L, num2 != 0L);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00052D9C File Offset: 0x00050F9C
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00052DAC File Offset: 0x00050FAC
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00052DBC File Offset: 0x00050FBC
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type DeclaringType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type ReflectedType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00052DCC File Offset: 0x00050FCC
		public override string ToString()
		{
			if (this != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00052DE0 File Offset: 0x00050FE0
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00052DF8 File Offset: 0x00050FF8
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00052E10 File Offset: 0x00051010
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0000207A File Offset: 0x0000027A
		public override int MetadataToken
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int get_metadata_token(RuntimeEventInfo monoEvent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00052E28 File Offset: 0x00051028
		public RuntimeEventInfo()
		{
		}

		// Token: 0x040014E6 RID: 5350
		private IntPtr klass;

		// Token: 0x040014E7 RID: 5351
		private IntPtr handle;
	}
}
