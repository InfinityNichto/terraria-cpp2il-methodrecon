using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D2 RID: 978
	internal sealed class SerializationEvents
	{
		// Token: 0x06001EEB RID: 7915 RVA: 0x000438AC File Offset: 0x00041AAC
		internal SerializationEvents(Type t)
		{
			if (!true)
			{
			}
			List<MethodInfo> list;
			this._onSerializingMethods = list;
			List<MethodInfo> list2;
			this._onSerializedMethods = list2;
			List<MethodInfo> list3;
			this._onDeserializingMethods = list3;
			List<MethodInfo> list4;
			this._onDeserializedMethods = list4;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000438E0 File Offset: 0x00041AE0
		private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
		{
			/*
An exception occurred when decompiling this method (06001EEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Reflection.MethodInfo> System.Runtime.Serialization.SerializationEvents::GetMethodsWithAttribute(System.Type,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:bool(var_4_11, call:bool(Type::op_Inequality, ldloc:Type(t), ldloc:Type(var_3)))
	brtrue(IL_0000, ldloc:int64[exp:bool](var_1_03))
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

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00043908 File Offset: 0x00041B08
		internal bool HasOnSerializingEvents
		{
			get
			{
				return this._onSerializingMethods == null || true;
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00043920 File Offset: 0x00041B20
		internal void InvokeOnSerializing(object obj, StreamingContext context)
		{
			List<MethodInfo> onSerializingMethods = this._onSerializingMethods;
			SerializationEventHandler serializationEventHandler;
			if (serializationEventHandler != null)
			{
				IntPtr method_code = serializationEventHandler.method_code;
				IntPtr invoke_impl = serializationEventHandler.invoke_impl;
				IntPtr method = serializationEventHandler.method;
				return;
			}
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00043950 File Offset: 0x00041B50
		internal void InvokeOnDeserializing(object obj, StreamingContext context)
		{
			List<MethodInfo> onDeserializingMethods = this._onDeserializingMethods;
			SerializationEventHandler serializationEventHandler;
			if (serializationEventHandler != null)
			{
				IntPtr method_code = serializationEventHandler.method_code;
				IntPtr invoke_impl = serializationEventHandler.invoke_impl;
				IntPtr method = serializationEventHandler.method;
				return;
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00043980 File Offset: 0x00041B80
		internal void InvokeOnDeserialized(object obj, StreamingContext context)
		{
			List<MethodInfo> onDeserializedMethods = this._onDeserializedMethods;
			SerializationEventHandler serializationEventHandler;
			if (serializationEventHandler != null)
			{
				IntPtr method_code = serializationEventHandler.method_code;
				IntPtr invoke_impl = serializationEventHandler.invoke_impl;
				IntPtr method = serializationEventHandler.method;
				return;
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000439B0 File Offset: 0x00041BB0
		internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
		{
			List<MethodInfo> onSerializedMethods = this._onSerializedMethods;
			return SerializationEvents.AddOnDelegate(obj, handler, onSerializedMethods);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000439CC File Offset: 0x00041BCC
		internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
		{
			List<MethodInfo> onDeserializedMethods = this._onDeserializedMethods;
			return SerializationEvents.AddOnDelegate(obj, handler, onDeserializedMethods);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000439E8 File Offset: 0x00041BE8
		private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods)
		{
			SerializationEventHandler serializationEventHandler;
			if (serializationEventHandler != null)
			{
				IntPtr method_code = serializationEventHandler.method_code;
				IntPtr invoke_impl = serializationEventHandler.invoke_impl;
				IntPtr method = serializationEventHandler.method;
				return;
			}
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00043A10 File Offset: 0x00041C10
		private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods)
		{
			if (handler != null)
			{
				if (handler != null)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x04000F81 RID: 3969
		private readonly List<MethodInfo> _onSerializingMethods;

		// Token: 0x04000F82 RID: 3970
		private readonly List<MethodInfo> _onSerializedMethods;

		// Token: 0x04000F83 RID: 3971
		private readonly List<MethodInfo> _onDeserializingMethods;

		// Token: 0x04000F84 RID: 3972
		private readonly List<MethodInfo> _onDeserializedMethods;
	}
}
