using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200039E RID: 926
	internal class CADMessageBase
	{
		// Token: 0x06001DC2 RID: 7618 RVA: 0x00040F28 File Offset: 0x0003F128
		public CADMessageBase(IMethodMessage msg)
		{
			MemoryStream memoryStream;
			this.serializedMethod = memoryStream;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00040F44 File Offset: 0x0003F144
		internal MethodBase GetMethod()
		{
			if (CADSerializer.DeserializeObjectSafe(this.serializedMethod) != null)
			{
			}
			MethodBase methodBase;
			return methodBase;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00040F68 File Offset: 0x0003F168
		protected static Type[] GetSignature(MethodBase methodBase, bool load)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00040F80 File Offset: 0x0003F180
		internal static int MarshalProperties(IDictionary dict, ArrayList args)
		{
			long num = 0L;
			IDictionary dictionary;
			if (dictionary != null)
			{
			}
			long num2 = 0L;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			long value = num2.m_value;
			long num3 = 0L;
			int num4 = 3;
			if (dictionary != null)
			{
			}
			if (num3 == 0L)
			{
				while (num4 != 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00040FF8 File Offset: 0x0003F1F8
		private static bool IsPossibleToIgnoreMarshal(object obj)
		{
			Type type;
			bool isPrimitive = type.IsPrimitive;
			Type type2;
			bool flag = type == type2;
			bool isArray = type.IsArray;
			bool isPrimitive2 = type.IsPrimitive;
			throw new InvalidCastException();
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00041034 File Offset: 0x0003F234
		protected object MarshalArgument(object arg, ArrayList args)
		{
			/*
An exception occurred when decompiling this method (06001DC8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Messaging.CADMessageBase::MarshalArgument(System.Object,System.Collections.ArrayList)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int32(var_4_18, call:int32(Thread::GetDomainID))
	stloc:uint8[](var_5_20, call:uint8[](ObjRef::SerializeType, ldloc:ObjRef(var_2)))
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

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00041064 File Offset: 0x0003F264
		protected object UnmarshalArgument(object arg, ArrayList args)
		{
			if (arg != null)
			{
				TypeCode typeCode = Type.GetTypeCode(arg.GetType());
			}
			ObjRef objRef;
			return RemotingServices.Unmarshal(objRef);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000410C0 File Offset: 0x0003F2C0
		internal object[] MarshalArguments(object[] arguments, ArrayList args)
		{
			object obj;
			if (obj == null || obj != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000410DC File Offset: 0x0003F2DC
		internal object[] UnmarshalArguments(object[] arguments, ArrayList args)
		{
			object obj;
			if (obj == null || obj != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000410F8 File Offset: 0x0003F2F8
		protected void SaveLogicalCallContext(IMethodMessage msg, ArrayList serializeList)
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0004110C File Offset: 0x0003F30C
		internal LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			do
			{
				CADArgHolder callContext = this._callContext;
				if (callContext == null)
				{
					return;
				}
				int index = callContext.index;
			}
			while (args == null);
			throw new InvalidCastException();
		}

		// Token: 0x04000F0D RID: 3853
		protected object[] _args;

		// Token: 0x04000F0E RID: 3854
		protected byte[] _serializedArgs;

		// Token: 0x04000F0F RID: 3855
		protected int _propertyCount;

		// Token: 0x04000F10 RID: 3856
		protected CADArgHolder _callContext;

		// Token: 0x04000F11 RID: 3857
		internal byte[] serializedMethod;
	}
}
