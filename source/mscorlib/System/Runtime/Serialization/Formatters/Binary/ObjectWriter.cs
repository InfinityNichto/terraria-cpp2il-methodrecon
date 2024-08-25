using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000421 RID: 1057
	internal sealed class ObjectWriter
	{
		// Token: 0x060020D0 RID: 8400 RVA: 0x000493F0 File Offset: 0x000475F0
		internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
			this.m_surrogates = selector;
			this.m_context = context;
			this.m_context.m_state = formatterEnums;
			this.m_currentId = 1;
			this.formatterEnums = binder;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0004942C File Offset: 0x0004762C
		internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
			if (graph != null)
			{
				if (serWriter != null)
				{
					this.serWriter = serWriter;
					this.headers = inHeaders;
					serWriter.WriteBegin();
					object obj = this.previousObj;
					ObjectIDGenerator idGenerator = this.m_idGenerator;
					int currentId = this.m_currentId;
					idGenerator.m_currentCount = currentId;
					this.m_currentId = currentId;
					this.previousObj = graph;
					this.previousId = idGenerator;
					return;
				}
			}
			else
			{
				string resourceString = Environment.GetResourceString("Object Graph cannot be null.");
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000495D4 File Offset: 0x000477D4
		internal SerializationObjectManager ObjectManager
		{
			get
			{
				return this.m_objectManager;
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000495E8 File Offset: 0x000477E8
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			int num = 1;
			if (objectInfo.obj == null)
			{
				string resourceString = Environment.GetResourceString("Object cannot be null.");
				throw new ArrayTypeMismatchException();
			}
			Type objectType = objectInfo.objectType;
			long objectId = objectInfo.objectId;
			if (num == 0)
			{
			}
			if (objectInfo.isArray)
			{
				return;
			}
			if (!objectInfo.isSi)
			{
				FormatterTypeStyle fetypeFormat = this.formatterEnums.FEtypeFormat;
			}
			int num2 = 1;
			typeNameInfo.NItransmitTypeOnObject = num2 != 0;
			typeNameInfo.NIisParentTypeOnObject = num2 != 0;
			if (objectId == 0L)
			{
				return;
			}
			Type type;
			if (this.ToCode(type) == InternalPrimitiveTypeE.Invalid)
			{
				if (num2 == 0)
				{
				}
				ISurrogateSelector surrogates = this.m_surrogates;
				StreamingContext context = this.m_context;
				StreamingContextStates state = this.m_context.m_state;
				SerializationBinder binder = this.m_binder;
				SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
				IFormatterConverter formatterConverter = this.m_formatterConverter;
				return;
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00049704 File Offset: 0x00047904
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos)
		{
			long objectId = objectInfo.objectId;
			__BinaryWriter _BinaryWriter = this.serWriter;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000497E8 File Offset: 0x000479E8
		private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo)
		{
			NameInfo nameInfo = this.GetNameInfo();
			nameInfo.NIFullName = memberName;
			if (memberObjectInfo != null)
			{
				long assemId = memberObjectInfo.assemId;
				nameInfo.NItype = memberType;
				nameInfo.NIassemId = assemId;
				Type objectType = memberObjectInfo.objectType;
				InternalPrimitiveTypeE internalPrimitiveTypeE = this.ToCode(objectType);
				return;
			}
			nameInfo.NItype = memberType;
			InternalPrimitiveTypeE internalPrimitiveTypeE2 = this.ToCode(memberType);
			NameInfo nameInfo2 = this.GetNameInfo();
			nameInfo2.NIprimitiveTypeEnum = internalPrimitiveTypeE2;
			nameInfo2.NItype = memberType;
			bool nitransmitTypeOnObject = memberNameInfo.NItransmitTypeOnObject;
			nameInfo.NItransmitTypeOnObject = nitransmitTypeOnObject;
			bool niisParentTypeOnObject = memberNameInfo.NIisParentTypeOnObject;
			nameInfo.NIisParentTypeOnObject = niisParentTypeOnObject;
			this.niPool.Push(nameInfo);
			this.niPool.Push(nameInfo2);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00049898 File Offset: 0x00047A98
		private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
			Type nitype = memberNameInfo.NItype;
			if (!true)
			{
			}
			if (Nullable.GetUnderlyingType(nitype) != null)
			{
				memberTypeNameInfo.NItransmitTypeOnMember = true;
				memberNameInfo.NItransmitTypeOnMember = true;
			}
			FormatterTypeStyle fetypeFormat = this.formatterEnums.FEtypeFormat;
			if (objectInfo.isSi)
			{
				memberTypeNameInfo.NItransmitTypeOnObject = true;
				memberNameInfo.NItransmitTypeOnObject = true;
				memberNameInfo.NIisParentTypeOnObject = true;
			}
			if (memberTypeNameInfo.NIprimitiveTypeEnum != InternalPrimitiveTypeE.Invalid)
			{
				return;
			}
			Type type = memberData.GetType();
			memberTypeNameInfo.NItransmitTypeOnMember = true;
			memberNameInfo.NItransmitTypeOnMember = true;
			if (!true)
			{
			}
			if (memberObjectInfo == null)
			{
				return;
			}
			long num;
			if (memberObjectInfo.isArray)
			{
				if (type == null)
				{
					Type type2 = memberData.GetType();
				}
				this.serWriter.WriteMemberNested(memberNameInfo);
				memberObjectInfo.objectId = num;
				memberNameInfo.NIobjectId = num;
				return;
			}
			bool flag = this.WriteKnownValueClass(memberNameInfo, memberTypeNameInfo, num);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000499F8 File Offset: 0x00047BF8
		private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
			while (memberNameInfo == null)
			{
				Type objectType = objectInfo.objectType;
				InternalPrimitiveTypeE internalPrimitiveTypeE = this.ToCode(objectType);
				int num = 1;
				int num2 = 1;
				NameInfo nameInfo;
				nameInfo.NIisArray = num2 != 0;
				long objectId = objectInfo.objectId;
				nameInfo.NIobjectId = objectId;
				object obj = objectInfo.obj;
				if (obj != null)
				{
				}
				Type objectType2 = objectInfo.objectType;
				bool isPrimitive = objectType2.IsPrimitive;
				ISurrogateSelector surrogates = this.m_surrogates;
				StreamingContext context = this.m_context;
				StreamingContextStates state = this.m_context.m_state;
				SerializationBinder binder = this.m_binder;
				SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
				IFormatterConverter formatterConverter = this.m_formatterConverter;
				WriteObjectInfo writeObjectInfo;
				long assemblyId = this.GetAssemblyId(writeObjectInfo);
				writeObjectInfo.assemId = assemblyId;
				if (writeObjectInfo != null)
				{
					Type objectType3 = writeObjectInfo.objectType;
					InternalPrimitiveTypeE internalPrimitiveTypeE2 = this.ToCode(objectType3);
					NameInfo nameInfo2;
					Type nitype = nameInfo2.NItype;
					return;
				}
				InternalPrimitiveTypeE internalPrimitiveTypeE3 = this.ToCode(objectType2);
				NameInfo nameInfo3 = this.GetNameInfo();
				nameInfo3.NIprimitiveTypeEnum = internalPrimitiveTypeE3;
				nameInfo3.NItype = objectType2;
				bool isArray = objectType2.IsArray;
				int num3 = 1;
				nameInfo.NIobjectId = objectId;
				nameInfo.NIisArray = num3 != 0;
				nameInfo3.NIobjectId = objectId;
				bool nitransmitTypeOnMember = nameInfo.NItransmitTypeOnMember;
				nameInfo3.NItransmitTypeOnMember = nitransmitTypeOnMember;
				bool nitransmitTypeOnObject = nameInfo.NItransmitTypeOnObject;
				nameInfo3.NItransmitTypeOnObject = nitransmitTypeOnObject;
				bool niisParentTypeOnObject = nameInfo.NIisParentTypeOnObject;
				nameInfo3.NIisParentTypeOnObject = niisParentTypeOnObject;
				long num4 = 0L;
				int num5;
				num.m_value = num5;
				bool niisArray = nameInfo3.NIisArray;
				int num6 = 2;
				nameInfo3.NIarrayEnum = (InternalArrayTypeE)num4;
				if (!niisArray)
				{
				}
				if (num6 != 0)
				{
					if (num6 == 0)
					{
					}
					if (Nullable.GetUnderlyingType(objectType2) != null)
					{
						int num7 = 1;
						nameInfo3.NItransmitTypeOnMember = num7 != 0;
					}
					FormatterTypeStyle fetypeFormat = this.formatterEnums.FEtypeFormat;
					int num8 = 1;
					nameInfo3.NItransmitTypeOnObject = num8 != 0;
					__BinaryWriter _BinaryWriter = this.serWriter;
					bool flag = Converter.IsWriteAsByteArray(nameInfo3.NIprimitiveTypeEnum);
					bool isValueType = objectType2.IsValueType;
					if (obj != null)
					{
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
					else
					{
						if (false)
						{
							return;
						}
						__BinaryWriter _BinaryWriter2 = this.serWriter;
						this.niPool.Push(nameInfo3);
						SerStack serStack = this.niPool;
						return;
					}
				}
				else
				{
					__BinaryWriter _BinaryWriter3 = this.serWriter;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
					return;
				}
			}
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00049C28 File Offset: 0x00047E28
		private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data)
		{
			arrayElemTypeNameInfo.NIisArrayItem = true;
			bool flag = this.CheckForNull(objectInfo, arrayElemTypeNameInfo, arrayElemTypeNameInfo, data);
			if (arrayElemTypeNameInfo.NItransmitTypeOnMember)
			{
				Type type = data.GetType();
				NameInfo nameInfo = this.GetNameInfo();
				InternalPrimitiveTypeE internalPrimitiveTypeE;
				nameInfo.NIprimitiveTypeEnum = internalPrimitiveTypeE;
				nameInfo.NItype = type;
				nameInfo.NItransmitTypeOnMember = true;
				return;
			}
			bool niisSealed;
			if (arrayElemTypeNameInfo.NIsealedStatusChecked)
			{
				niisSealed = arrayElemTypeNameInfo.NIisSealed;
				return;
			}
			bool isSealed = arrayElemTypeNameInfo.NItype.IsSealed;
			arrayElemTypeNameInfo.NIisSealed = niisSealed;
			arrayElemTypeNameInfo.NIsealedStatusChecked = true;
			if (niisSealed)
			{
				arrayElemTypeNameInfo.NIisArrayItem = true;
				bool flag2 = this.WriteKnownValueClass(arrayElemTypeNameInfo, arrayElemTypeNameInfo, data);
				Type nitype = arrayElemTypeNameInfo.NItype;
				if (!true)
				{
				}
				Type nitype2 = arrayElemTypeNameInfo.NItype;
				long num;
				arrayElemTypeNameInfo.NIobjectId = num;
				arrayElemTypeNameInfo.NIobjectId = num;
				this.serWriter.WriteItemObjectRef(arrayElemTypeNameInfo, (int)num);
				return;
			}
			WriteObjectInfo writeObjectInfo;
			Type type2 = writeObjectInfo.GetType();
			Type nitype3 = arrayElemTypeNameInfo.NItype;
			while (type2 != null)
			{
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00049DC0 File Offset: 0x00047FC0
		private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA)
		{
			if (lowerBoundA != null)
			{
				return;
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00049DD8 File Offset: 0x00047FD8
		private object GetNext([Out] long objID)
		{
			if (this.m_objectQueue != null)
			{
				Queue objectQueue = this.m_objectQueue;
				if (objectQueue != null)
				{
					int head = objectQueue._head;
				}
			}
			ObjectIDGenerator idGenerator = this.m_idGenerator;
			objID.m_value = idGenerator;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00049E14 File Offset: 0x00048014
		private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, [Out] bool isNew)
		{
			/*
An exception occurred when decompiling this method (060020DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Runtime.Serialization.Formatters.Binary.ObjectWriter::InternalGetId(System.Object,System.Boolean,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0045:
	stfld:int32(ObjectWriter::m_currentId, ldloc:ObjectWriter(this), ldloc:int32(var_5))
	stfld:object(ObjectWriter::previousObj, ldloc:ObjectWriter(this), ldloc:object(obj))
	stfld:int64(ObjectWriter::previousId, ldloc:ObjectWriter(this), ldloc:ObjectIDGenerator[exp:int64](var_6))
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

		// Token: 0x060020DC RID: 8412 RVA: 0x00049E7C File Offset: 0x0004807C
		private long Schedule(object obj, bool assignUniqueIdToValueType, Type type)
		{
			long num;
			return num;
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00049E8C File Offset: 0x0004808C
		private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo)
		{
			while (obj != null)
			{
				Queue objectQueue = this.m_objectQueue;
				if (objectInfo != null)
				{
					break;
				}
			}
			return 0L;
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00049EA8 File Offset: 0x000480A8
		private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			Type nitype = typeNameInfo.NItype;
			if (!true)
			{
			}
			if (typeNameInfo.NIprimitiveTypeEnum != InternalPrimitiveTypeE.Invalid)
			{
				bool niisArray = typeNameInfo.NIisArray;
				__BinaryWriter _BinaryWriter = this.serWriter;
				if (niisArray)
				{
					_BinaryWriter.WriteItem(memberNameInfo, typeNameInfo, data);
					this.WriteString(memberNameInfo, typeNameInfo, data);
				}
			}
			return true;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00049EF0 File Offset: 0x000480F0
		private void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
			this.serWriter.WriteMemberObjectRef(nameInfo, (int)objectId);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00049F0C File Offset: 0x0004810C
		private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject)
		{
			FormatterTypeStyle fetypeFormat = this.formatterEnums.FEtypeFormat;
			object obj = this.previousObj;
			ObjectIDGenerator idGenerator = this.m_idGenerator;
			int currentId = this.m_currentId;
			idGenerator.m_currentCount = currentId;
			this.m_currentId = currentId;
			this.previousObj = stringObject;
			this.previousId = idGenerator;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00049F88 File Offset: 0x00048188
		private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			if (data != null)
			{
			}
			if (memberNameInfo.NIisArrayItem || memberNameInfo.NItransmitTypeOnObject || memberNameInfo.NItransmitTypeOnMember || !objectInfo.isSi)
			{
			}
			if (typeNameInfo.NIisArrayItem)
			{
				InternalArrayTypeE niarrayEnum = typeNameInfo.NIarrayEnum;
			}
			return true;
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00049FCC File Offset: 0x000481CC
		private void WriteSerializedStreamHeader(long topId, long headerId)
		{
			__BinaryWriter _BinaryWriter = this.serWriter;
			long num = 0L;
			_BinaryWriter.WriteSerializationHeader((int)topId, (int)headerId, 1, (int)num);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00049FEC File Offset: 0x000481EC
		private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			/*
An exception occurred when decompiling this method (060020E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.Formatters.Binary.NameInfo System.Runtime.Serialization.Formatters.Binary.ObjectWriter::TypeToNameInfo(System.Type,System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo,System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE,System.Runtime.Serialization.Formatters.Binary.NameInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	brtrue(IL_003B, ldloc:WriteObjectInfo[exp:bool](objectInfo))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060020E4 RID: 8420 RVA: 0x0004A038 File Offset: 0x00048238
		private NameInfo TypeToNameInfo(Type type)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.ToCode(type);
			NameInfo nameInfo;
			nameInfo.NIprimitiveTypeEnum = internalPrimitiveTypeE;
			nameInfo.NItype = type;
			return nameInfo;
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0004A05C File Offset: 0x0004825C
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			Type objectType = objectInfo.objectType;
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.ToCode(objectType);
			NameInfo nameInfo;
			return nameInfo;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0004A07C File Offset: 0x0004827C
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			/*
An exception occurred when decompiling this method (060020E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.Formatters.Binary.NameInfo System.Runtime.Serialization.Formatters.Binary.ObjectWriter::TypeToNameInfo(System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo,System.Runtime.Serialization.Formatters.Binary.NameInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, ldfld:Type(WriteObjectInfo::objectType, ldloc:WriteObjectInfo(objectInfo)))
	stloc:InternalPrimitiveTypeE(var_1_0E, call:InternalPrimitiveTypeE(ObjectWriter::ToCode, ldloc:ObjectWriter(this), ldloc:Type(var_0_06)))
	stloc:NameInfo(var_2_19, call:NameInfo(ObjectWriter::TypeToNameInfo, ldloc:ObjectWriter(this), ldloc:Type(var_0_06), ldloc:WriteObjectInfo(objectInfo), ldloc:InternalPrimitiveTypeE(var_1_0E), ldloc:NameInfo(nameInfo)))
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x0004A0A4 File Offset: 0x000482A4
		private void TypeToNameInfo(Type type, NameInfo nameInfo)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.ToCode(type);
			if (nameInfo != null)
			{
				return;
			}
			NameInfo nameInfo2 = this.GetNameInfo();
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0004A0C4 File Offset: 0x000482C4
		private NameInfo MemberToNameInfo(string name)
		{
			NameInfo nameInfo = this.GetNameInfo();
			nameInfo.NIFullName = name;
			return nameInfo;
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0004A0E0 File Offset: 0x000482E0
		internal InternalPrimitiveTypeE ToCode(Type type)
		{
			InternalPrimitiveTypeE internalPrimitiveTypeE;
			do
			{
				Type type2 = this.previousType;
				internalPrimitiveTypeE = Converter.ToCode(type);
			}
			while (internalPrimitiveTypeE == InternalPrimitiveTypeE.Invalid);
			this.previousType = type;
			this.previousCode = internalPrimitiveTypeE;
			return internalPrimitiveTypeE;
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0004A114 File Offset: 0x00048314
		private long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			if (this.assemblyToIdTable == null)
			{
			}
			string assemblyString = objectInfo.GetAssemblyString();
			int stringLength = assemblyString._stringLength;
			long num;
			if (stringLength != 0)
			{
				if (stringLength == 0)
				{
				}
				Hashtable hashtable = this.assemblyToIdTable;
				Hashtable hashtable2 = this.assemblyToIdTable;
				num = 0L;
			}
			string text = "___AssemblyString___" + assemblyString;
			object obj = this.previousObj;
			ObjectIDGenerator idGenerator = this.m_idGenerator;
			int currentId = this.m_currentId;
			idGenerator.m_currentCount = currentId;
			this.m_currentId = currentId;
			this.previousObj = text;
			this.previousId = idGenerator;
			long num2 = this.previousId;
			Hashtable hashtable3 = this.assemblyToIdTable;
			__BinaryWriter _BinaryWriter = this.serWriter;
			Type objectType = objectInfo.objectType;
			_BinaryWriter.WriteAssembly(objectType, assemblyString, (int)num2, num != 0L);
			return num2;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0004A1D0 File Offset: 0x000483D0
		private Type GetType(object obj)
		{
			return obj.GetType();
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0004A1E4 File Offset: 0x000483E4
		private NameInfo GetNameInfo()
		{
			object[] objects = this.niPool.objects;
			if (this != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0000207A File Offset: 0x0000027A
		private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0004A208 File Offset: 0x00048408
		private void PutNameInfo(NameInfo nameInfo)
		{
			this.niPool.Push(nameInfo);
		}

		// Token: 0x04001156 RID: 4438
		private Queue m_objectQueue;

		// Token: 0x04001157 RID: 4439
		private ObjectIDGenerator m_idGenerator;

		// Token: 0x04001158 RID: 4440
		private int m_currentId;

		// Token: 0x04001159 RID: 4441
		private ISurrogateSelector m_surrogates;

		// Token: 0x0400115A RID: 4442
		private StreamingContext m_context;

		// Token: 0x0400115B RID: 4443
		private __BinaryWriter serWriter;

		// Token: 0x0400115C RID: 4444
		private SerializationObjectManager m_objectManager;

		// Token: 0x0400115D RID: 4445
		private long topId;

		// Token: 0x0400115E RID: 4446
		private string topName;

		// Token: 0x0400115F RID: 4447
		private Header[] headers;

		// Token: 0x04001160 RID: 4448
		private InternalFE formatterEnums;

		// Token: 0x04001161 RID: 4449
		private SerializationBinder m_binder;

		// Token: 0x04001162 RID: 4450
		private SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04001163 RID: 4451
		private IFormatterConverter m_formatterConverter;

		// Token: 0x04001164 RID: 4452
		internal object[] crossAppDomainArray;

		// Token: 0x04001165 RID: 4453
		private object previousObj;

		// Token: 0x04001166 RID: 4454
		private long previousId;

		// Token: 0x04001167 RID: 4455
		private Type previousType;

		// Token: 0x04001168 RID: 4456
		private InternalPrimitiveTypeE previousCode;

		// Token: 0x04001169 RID: 4457
		private Hashtable assemblyToIdTable;

		// Token: 0x0400116A RID: 4458
		private SerStack niPool;
	}
}
