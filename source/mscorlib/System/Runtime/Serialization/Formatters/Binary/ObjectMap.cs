using System;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000413 RID: 1043
	internal sealed class ObjectMap
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x00046C5C File Offset: 0x00044E5C
		internal ObjectMap(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			int num = 1;
			this.isInitObjectInfo = num != 0;
			base..ctor();
			this.objectName = objectName;
			this.objectType = objectType;
			this.memberNames = memberNames;
			this.objectReader = objectReader;
			this.objectId = objectId;
			this.assemblyInfo = assemblyInfo;
			ReadObjectInfo readObjectInfo = objectReader.CreateReadObjectInfo(objectType);
			this.objectInfo = readObjectInfo;
			Type[] array = readObjectInfo.GetMemberTypes(memberNames, objectType);
			this.memberTypes = array;
			Type[] array2 = this.memberTypes;
			Type[] array3 = this.memberTypes;
			BinaryTypeEnum[] array4 = this.binaryTypeEnumA;
			object[] array5 = this.typeInformationA;
			if (objectType == null || objectType != null)
			{
				Type[] array6 = this.memberTypes;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00046CFC File Offset: 0x00044EFC
		internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			int num = 1;
			this.isInitObjectInfo = num != 0;
			base..ctor();
			this.objectName = objectName;
			this.memberNames = memberNames;
			this.binaryTypeEnumA = binaryTypeEnumA;
			this.typeInformationA = typeInformationA;
			this.objectReader = objectReader;
			this.objectId = objectId;
			Type type;
			this.objectType = type;
			object obj;
			if (obj != null)
			{
			}
			Type[] array = this.memberTypes;
			if (binaryTypeEnumA == null || binaryTypeEnumA != null)
			{
				Type type2 = this.objectType;
				ReadObjectInfo readObjectInfo;
				this.objectInfo = readObjectInfo;
				if (!readObjectInfo.isSi)
				{
					Type type3 = readObjectInfo.objectType;
					Type[] array2 = readObjectInfo.GetMemberTypes(memberNames, type3);
				}
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00046DA8 File Offset: 0x00044FA8
		internal ReadObjectInfo CreateObjectInfo(SerializationInfo si, object[] memberData)
		{
			/*
An exception occurred when decompiling this method (06002028)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo System.Runtime.Serialization.Formatters.Binary.ObjectMap::CreateObjectInfo(System.Runtime.Serialization.SerializationInfo,System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	call:void(ReadObjectInfo::InitDataStore, ldfld:ReadObjectInfo(ObjectMap::objectInfo, ldloc:ObjectMap(this)), ldloc:SerializationInfo(si), ldloc:object[](memberData))
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

		// Token: 0x06002029 RID: 8233 RVA: 0x0000207A File Offset: 0x0000027A
		internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0000207A File Offset: 0x0000027A
		internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400109D RID: 4253
		internal string objectName;

		// Token: 0x0400109E RID: 4254
		internal Type objectType;

		// Token: 0x0400109F RID: 4255
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x040010A0 RID: 4256
		internal object[] typeInformationA;

		// Token: 0x040010A1 RID: 4257
		internal Type[] memberTypes;

		// Token: 0x040010A2 RID: 4258
		internal string[] memberNames;

		// Token: 0x040010A3 RID: 4259
		internal ReadObjectInfo objectInfo;

		// Token: 0x040010A4 RID: 4260
		internal bool isInitObjectInfo;

		// Token: 0x040010A5 RID: 4261
		internal ObjectReader objectReader;

		// Token: 0x040010A6 RID: 4262
		internal int objectId;

		// Token: 0x040010A7 RID: 4263
		internal BinaryAssemblyInfo assemblyInfo;
	}
}
