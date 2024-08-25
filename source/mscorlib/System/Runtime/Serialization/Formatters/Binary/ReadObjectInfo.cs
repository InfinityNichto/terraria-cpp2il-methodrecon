using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041A RID: 1050
	internal sealed class ReadObjectInfo
	{
		// Token: 0x06002090 RID: 8336 RVA: 0x000480A0 File Offset: 0x000462A0
		internal ReadObjectInfo()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000480B4 File Offset: 0x000462B4
		internal void ObjectEnd()
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000480C4 File Offset: 0x000462C4
		internal void PrepareForReuse()
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000480D4 File Offset: 0x000462D4
		internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			ReadObjectInfo readObjectInfo;
			readObjectInfo.objectManager = objectManager;
			readObjectInfo.context = surrogateSelector;
			readObjectInfo.context.m_state = context;
			readObjectInfo.serObjectInfoInit = serObjectInfoInit;
			readObjectInfo.formatterConverter = converter;
			return readObjectInfo;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0004810C File Offset: 0x0004630C
		internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			this.objectType = objectType;
			this.objectManager = serObjectInfoInit;
			this.context = context;
			this.context.m_state = objectManager;
			this.serObjectInfoInit = converter;
			this.formatterConverter = bSimpleAssembly;
			this.InitReadConstructor(objectType, surrogateSelector, context);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00048158 File Offset: 0x00046358
		internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			ReadObjectInfo readObjectInfo;
			return readObjectInfo;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00048168 File Offset: 0x00046368
		internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			this.objectType = objectType;
			this.objectManager = serObjectInfoInit;
			this.wireMemberNames = memberNames;
			this.wireMemberTypes = memberTypes;
			this.context = context;
			this.context.m_state = objectManager;
			if (memberNames != null)
			{
				this.isNamed = true;
			}
			if (memberTypes != null)
			{
				this.isTyped = true;
			}
			if (objectType != null)
			{
				this.InitReadConstructor(objectType, surrogateSelector, context);
				return;
			}
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000481CC File Offset: 0x000463CC
		private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			bool isArray = objectType.IsArray;
			this.InitNoMembers();
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0004821C File Offset: 0x0004641C
		private void InitSiRead()
		{
			if (this.memberTypesList != null)
			{
			}
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00048234 File Offset: 0x00046434
		private void InitNoMembers()
		{
			Type type = this.objectType;
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00048248 File Offset: 0x00046448
		private void InitMemberInfo()
		{
			int num = 1;
			Type type = this.objectType;
			Type type2 = this.objectType;
			StreamingContext streamingContext = this.context;
			StreamingContextStates state = this.context.m_state;
			if (num == 0)
			{
			}
			MemberInfo[] serializableMembers = FormatterServices.GetSerializableMembers(type2, streamingContext);
			MemberInfo[] memberInfos = this.cache.memberInfos;
			this.count = streamingContext;
			int num2 = this.count;
			SerObjectInfoCache serObjectInfoCache = this.cache;
			int num3 = this.count;
			SerObjectInfoCache serObjectInfoCache2 = this.cache;
			MemberInfo[] memberInfos2 = serObjectInfoCache2.memberInfos;
			string[] memberNames = serObjectInfoCache2.memberNames;
			SerObjectInfoCache serObjectInfoCache3 = this.cache;
			MemberInfo[] memberInfos3 = serObjectInfoCache3.memberInfos;
			Type[] memberTypes = serObjectInfoCache3.memberTypes;
			Type type3;
			if (type3 == null || type3 != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000482F4 File Offset: 0x000464F4
		internal MemberInfo GetMemberInfo(string name)
		{
			SerObjectInfoCache serObjectInfoCache = this.cache;
			Type type;
			if (serObjectInfoCache != null)
			{
				if (!this.isSi)
				{
					if (serObjectInfoCache.memberInfos != null)
					{
						int num = this.Position(name);
						SerObjectInfoCache serObjectInfoCache2 = this.cache;
						MemberInfo[] memberInfos = serObjectInfoCache2.memberInfos;
						int num2 = this.Position(name);
						bool hasTypeForwardedFrom = serObjectInfoCache2.hasTypeForwardedFrom;
					}
					else
					{
						if (type == null)
						{
							goto IL_0060;
						}
						throw new ArrayTypeMismatchException();
					}
				}
			}
			type = this.objectType;
			if (type != null)
			{
				return "MemberInfo cannot be obtained for ISerialized Object '{0}'.";
			}
			IL_0060:
			return "No MemberInfo for Object {0}.";
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0004836C File Offset: 0x0004656C
		internal Type GetType(string name)
		{
			int num = this.Position(name);
			if (this.isTyped)
			{
				Type[] memberTypes = this.cache.memberTypes;
				if (num != 0)
				{
					goto IL_0029;
				}
			}
			if (this.memberTypesList != null)
			{
			}
			IL_0029:
			if (this.objectType == null)
			{
				return "Types not available for ISerializable object '{0}'.";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000483B8 File Offset: 0x000465B8
		internal void AddValue(string name, object value, SerializationInfo si, object[] memberData)
		{
			if (this.isSi)
			{
				return;
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000483DC File Offset: 0x000465DC
		internal void InitDataStore(SerializationInfo si, object[] memberData)
		{
			if (this.isSi)
			{
				Type type = this.objectType;
				IFormatterConverter formatterConverter = this.formatterConverter;
				return;
			}
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00048404 File Offset: 0x00046604
		internal void RecordFixup(long objectId, string name, long idRef)
		{
			if (this.isSi)
			{
				ObjectManager objectManager = this.objectManager;
				return;
			}
			int num = this.Position(name);
			SerObjectInfoCache serObjectInfoCache = this.cache;
			ObjectManager objectManager2 = this.objectManager;
			MemberInfo[] memberInfos = serObjectInfoCache.memberInfos;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00048440 File Offset: 0x00046640
		internal void PopulateObjectMembers(object obj, object[] memberData)
		{
			if (memberData != null && !this.isSi)
			{
				MemberInfo[] memberInfos = this.cache.memberInfos;
				object obj2 = FormatterServices.PopulateObjectMembers(obj, memberInfos, memberData);
				return;
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00048474 File Offset: 0x00046674
		private int Position(string name)
		{
			/*
An exception occurred when decompiling this method (060020A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo::Position(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0052:
	stfld:int32(ReadObjectInfo::lastPosition, ldloc:ReadObjectInfo(this), ldloc:int64[exp:int32](var_8))
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

		// Token: 0x060020A2 RID: 8354 RVA: 0x000484DC File Offset: 0x000466DC
		internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType)
		{
			bool flag = this.isSi;
			if (flag)
			{
				throw new ArrayTypeMismatchException();
			}
			Type[] memberTypes;
			if (!flag)
			{
				int num = this.count;
				SerObjectInfoCache serObjectInfoCache = this.cache;
				MemberInfo[] memberInfos = serObjectInfoCache.memberInfos;
				memberTypes = serObjectInfoCache.memberTypes;
				Type type;
				if (type != null && type == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			MemberInfo[] memberInfos2 = this.cache.memberInfos;
			SerObjectInfoCache serObjectInfoCache2 = this.cache;
			MemberInfo[] memberInfos3 = serObjectInfoCache2.memberInfos;
			bool hasTypeForwardedFrom = serObjectInfoCache2.hasTypeForwardedFrom;
			MemberInfo[] memberInfos4 = this.cache.memberInfos;
			if (this.cache.memberInfos == null)
			{
			}
			if (memberTypes != null)
			{
			}
			if (!this.bSimpleAssembly)
			{
				return memberTypes;
			}
			MemberInfo[] memberInfos5 = this.cache.memberInfos;
			return memberTypes;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000485D8 File Offset: 0x000467D8
		internal Type GetMemberType(MemberInfo objMember)
		{
			if (objMember != null)
			{
			}
			Type type = objMember.GetType();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000485F8 File Offset: 0x000467F8
		private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			int num = Interlocked.Increment(-1073741824);
			return -1073741824;
		}

		// Token: 0x0400111D RID: 4381
		internal int objectInfoId;

		// Token: 0x0400111E RID: 4382
		internal static int readObjectInfoCounter;

		// Token: 0x0400111F RID: 4383
		internal Type objectType;

		// Token: 0x04001120 RID: 4384
		internal ObjectManager objectManager;

		// Token: 0x04001121 RID: 4385
		internal int count;

		// Token: 0x04001122 RID: 4386
		internal bool isSi;

		// Token: 0x04001123 RID: 4387
		internal bool isNamed;

		// Token: 0x04001124 RID: 4388
		internal bool isTyped;

		// Token: 0x04001125 RID: 4389
		internal bool bSimpleAssembly;

		// Token: 0x04001126 RID: 4390
		internal SerObjectInfoCache cache;

		// Token: 0x04001127 RID: 4391
		internal string[] wireMemberNames;

		// Token: 0x04001128 RID: 4392
		internal Type[] wireMemberTypes;

		// Token: 0x04001129 RID: 4393
		private int lastPosition;

		// Token: 0x0400112A RID: 4394
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x0400112B RID: 4395
		internal StreamingContext context;

		// Token: 0x0400112C RID: 4396
		internal List<Type> memberTypesList;

		// Token: 0x0400112D RID: 4397
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x0400112E RID: 4398
		internal IFormatterConverter formatterConverter;
	}
}
