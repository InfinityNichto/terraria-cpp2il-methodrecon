using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000419 RID: 1049
	internal sealed class WriteObjectInfo
	{
		// Token: 0x0600207E RID: 8318 RVA: 0x00047B20 File Offset: 0x00045D20
		internal WriteObjectInfo()
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00047B34 File Offset: 0x00045D34
		internal void ObjectEnd()
		{
			this.serObjectInfoInit.oiPool.Push(this);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00047B54 File Offset: 0x00045D54
		private void InternalInit()
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00047B64 File Offset: 0x00045D64
		internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			return WriteObjectInfo.GetObjectInfo(serObjectInfoInit);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00047B78 File Offset: 0x00045D78
		internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			this.context = context;
			this.context.m_state = serObjectInfoInit;
			this.obj = obj;
			this.serObjectInfoInit = converter;
			Type type = obj.GetType();
			this.objectType = type;
			bool flag = type.IsArray;
			int num = 1;
			this.isArray = num != 0;
			this.InitNoMembers();
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00047C98 File Offset: 0x00045E98
		internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			return WriteObjectInfo.GetObjectInfo(serObjectInfoInit);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00047CAC File Offset: 0x00045EAC
		internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			this.objectType = objectType;
			this.context = context;
			this.context.m_state = serObjectInfoInit;
			this.serObjectInfoInit = converter;
			bool flag = objectType.IsArray;
			this.InitNoMembers();
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00047D58 File Offset: 0x00045F58
		private void InitSiWrite()
		{
			SerializationInfo serializationInfo = this.si;
			int num = 1;
			this.isSi = num != 0;
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			SerializationInfo serializationInfo2 = this.si;
			int currMember = serializationInfo2.m_currMember;
			bool isFullTypeNameSetExplicit = serializationInfo2.isFullTypeNameSetExplicit;
			string assemName = serializationInfo2.m_assemName;
			if (isFullTypeNameSetExplicit)
			{
				return;
			}
			Type type = serializationInfo2.objectType;
			if (!isFullTypeNameSetExplicit)
			{
			}
			TypeInformation typeInformation = BinaryFormatter.GetTypeInformation(type);
			bool hasTypeForwardedFrom = typeInformation.hasTypeForwardedFrom;
			SerializationInfo serializationInfo3 = this.si;
			if (!serializationInfo3.isAssemblyNameSetExplicit)
			{
				TypeInformation typeInformation2;
				if (typeInformation == null)
				{
					Type type2 = serializationInfo3.objectType;
					if (!isFullTypeNameSetExplicit)
					{
					}
					typeInformation2 = BinaryFormatter.GetTypeInformation(type2);
				}
				bool hasTypeForwardedFrom2 = typeInformation2.hasTypeForwardedFrom;
				string assemblyString = typeInformation2.assemblyString;
			}
			SerObjectInfoCache serObjectInfoCache = this.cache;
			SerializationInfoEnumerator enumerator2 = this.si.GetEnumerator();
			int numItems = enumerator2._numItems;
			bool current = enumerator2._current;
			int num2 = 1;
			enumerator2._currItem = (current ? 1 : 0);
			enumerator2._current = num2 != 0;
			string[] memberNames = this.cache.memberNames;
			string name = enumerator2.Name;
			if (name == null || name != null)
			{
				Type[] memberTypes = this.cache.memberTypes;
				Type type3 = enumerator2.ObjectType;
				if (type3 == null || type3 != null)
				{
					object[] array = this.memberData;
					object value = enumerator2.Value;
					if (value == null || value != null)
					{
						int numItems2 = enumerator2._numItems;
						bool current2 = enumerator2._current;
						return;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00047EA4 File Offset: 0x000460A4
		private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
		{
			if (binderAssemblyString == null && cache.hasTypeForwardedFrom)
			{
				bool flag = FormatterServices.UnsafeTypeForwardersIsEnabled();
				string assemblyString = cache.assemblyString;
			}
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00047ED0 File Offset: 0x000460D0
		private void InitNoMembers()
		{
			SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
			Type type = this.objectType;
			Hashtable seenBeforeTable = serObjectInfoInit.seenBeforeTable;
			if (seenBeforeTable != null)
			{
				this.cache = seenBeforeTable;
				return;
			}
			Type type2 = this.objectType;
			SerObjectInfoInit serObjectInfoInit2 = this.serObjectInfoInit;
			Type type3 = this.objectType;
			Hashtable seenBeforeTable2 = serObjectInfoInit2.seenBeforeTable;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00047F24 File Offset: 0x00046124
		private void InitMemberInfo()
		{
			SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
			Type type = this.objectType;
			Hashtable seenBeforeTable = serObjectInfoInit.seenBeforeTable;
			if (seenBeforeTable != null)
			{
				this.cache = seenBeforeTable;
				throw new InvalidCastException();
			}
			object obj = this.obj;
			Type type2 = this.objectType;
			Type type3;
			if (type3 == null || type3 != null)
			{
				SerObjectInfoInit serObjectInfoInit2 = this.serObjectInfoInit;
				Type type4 = this.objectType;
				SerObjectInfoCache serObjectInfoCache = this.cache;
				Hashtable seenBeforeTable2 = serObjectInfoInit2.seenBeforeTable;
				if (this.obj != null)
				{
					object[] array;
					this.memberData = array;
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00047FA4 File Offset: 0x000461A4
		internal string GetTypeFullName()
		{
			string text = this.binderTypeName;
			if (text != null)
			{
				return text;
			}
			return this.cache.fullTypeName;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00047FC8 File Offset: 0x000461C8
		internal string GetAssemblyString()
		{
			string text = this.binderAssemblyString;
			if (text != null)
			{
				return text;
			}
			return this.cache.assemblyString;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00047FEC File Offset: 0x000461EC
		private void InvokeSerializationBinder(SerializationBinder binder)
		{
			if (binder != null)
			{
				Type type = this.objectType;
				return;
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00048004 File Offset: 0x00046204
		internal Type GetMemberType(MemberInfo objMember)
		{
			if (objMember != null)
			{
			}
			Type type = objMember.GetType();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00048024 File Offset: 0x00046224
		internal void GetMemberInfo([Out] string[] outMemberNames, [Out] Type[] outMemberTypes, [Out] object[] outMemberData)
		{
			/*
An exception occurred when decompiling this method (0600208D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo::GetMemberInfo(System.String[],System.Type[],System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:string(var_3_3A, call:string(Environment::GetResourceString, ldstr:string("MemberInfo requested for ISerializable type.")))
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

		// Token: 0x0600208E RID: 8334 RVA: 0x0004806C File Offset: 0x0004626C
		private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00048084 File Offset: 0x00046284
		private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			serObjectInfoInit.oiPool.Push(objectInfo);
		}

		// Token: 0x0400110C RID: 4364
		internal int objectInfoId;

		// Token: 0x0400110D RID: 4365
		internal object obj;

		// Token: 0x0400110E RID: 4366
		internal Type objectType;

		// Token: 0x0400110F RID: 4367
		internal bool isSi;

		// Token: 0x04001110 RID: 4368
		internal bool isNamed;

		// Token: 0x04001111 RID: 4369
		internal bool isTyped;

		// Token: 0x04001112 RID: 4370
		internal bool isArray;

		// Token: 0x04001113 RID: 4371
		internal SerializationInfo si;

		// Token: 0x04001114 RID: 4372
		internal SerObjectInfoCache cache;

		// Token: 0x04001115 RID: 4373
		internal object[] memberData;

		// Token: 0x04001116 RID: 4374
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x04001117 RID: 4375
		internal StreamingContext context;

		// Token: 0x04001118 RID: 4376
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04001119 RID: 4377
		internal long objectId;

		// Token: 0x0400111A RID: 4378
		internal long assemId;

		// Token: 0x0400111B RID: 4379
		private string binderTypeName;

		// Token: 0x0400111C RID: 4380
		private string binderAssemblyString;
	}
}
