using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using Cpp2IlInjected;

namespace System.Resources
{
	// Token: 0x020004B7 RID: 1207
	[ComVisible(true)]
	public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
	{
		// Token: 0x0600232B RID: 9003 RVA: 0x0004F510 File Offset: 0x0004D710
		internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
		{
			this._resCache = resCache;
			Encoding utf = Encoding.UTF8;
			if (stream != null)
			{
			}
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0004F548 File Offset: 0x0004D748
		public void Close()
		{
			if (this._store != null)
			{
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0004F560 File Offset: 0x0004D760
		public void Dispose()
		{
			if (this._store != null)
			{
			}
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0004F578 File Offset: 0x0004D778
		private void Dispose(bool disposing)
		{
			if (this._store != null)
			{
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static int ReadUnalignedI4(int* p)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0004F590 File Offset: 0x0004D790
		private void SkipString()
		{
			int num = this._store.Read7BitEncodedInt();
			BinaryReader store = this._store;
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0004F5BC File Offset: 0x0004D7BC
		private int GetNameHash(int index)
		{
			/*
An exception occurred when decompiling this method (06002331)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Resources.ResourceReader::GetNameHash(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int32[](var_1_15, ldfld:int32[](ResourceReader::_nameHashes, ldloc:ResourceReader(this)))
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

		// Token: 0x06002332 RID: 9010 RVA: 0x0004F5E0 File Offset: 0x0004D7E0
		private unsafe int GetNamePosition(int index)
		{
			if (this._ums != null)
			{
				int* namePositionsPtr = this._namePositionsPtr;
			}
			int[] namePositions = this._namePositions;
			long nameSectionOffset = this._nameSectionOffset;
			long dataSectionOffset = this._dataSectionOffset;
			return namePositions;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0004F61C File Offset: 0x0004D81C
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Resources.ResourceReader::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IDictionaryEnumerator(var_0_06, call:IDictionaryEnumerator(ResourceReader::GetEnumerator, ldloc:ResourceReader(this)))
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

		// Token: 0x06002334 RID: 9012 RVA: 0x0004F630 File Offset: 0x0004D830
		public IDictionaryEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002334)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionaryEnumerator System.Resources.ResourceReader::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_0_12, call:string(Environment::GetResourceString, ldstr:string("ResourceReader is closed.")))
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

		// Token: 0x06002335 RID: 9013 RVA: 0x0000207A File Offset: 0x0000027A
		internal ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0004F650 File Offset: 0x0004D850
		internal int FindPosForResource(string name)
		{
			if (!true)
			{
			}
			int num = FastResourceComparer.HashFunction(name);
			int numResources = this._numResources;
			int num2;
			return num2;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0004F700 File Offset: 0x0004D900
		private unsafe bool CompareStringEqualsName(string name)
		{
			int num = this._store.Read7BitEncodedInt();
			UnmanagedMemoryStream ums = this._ums;
			UnmanagedMemoryStream ums3;
			if (ums != null)
			{
				byte* positionPointer = ums.PositionPointer;
				UnmanagedMemoryStream ums2 = this._ums;
				ums3 = this._ums;
				if (this._ums == null)
				{
				}
			}
			if (ums3._identity != null)
			{
			}
			string resourceString = Environment.GetResourceString("Corrupt .resources file. A resource name extends past the end of the stream.");
			return "Corrupt .resources file. String length must be non-negative." != null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0004F764 File Offset: 0x0004D964
		private unsafe string AllocateStringForNameIndex(int index, [Out] int dataOffset)
		{
			int namePosition = this.GetNamePosition(index);
			Monitor.Enter(this, index != 0);
			BinaryReader store = this._store;
			long nameSectionOffset = this._nameSectionOffset;
			int num = this._store.Read7BitEncodedInt();
			if (this._ums != null)
			{
				UnmanagedMemoryStream ums = this._ums;
				byte* positionPointer = this._ums.PositionPointer;
				string text;
				return text;
			}
			if (this._store != null)
			{
				BinaryReader store2 = this._store;
				dataOffset.m_value = store2;
				BinaryReader store3 = this._store;
				long dataSectionOffset = this._dataSectionOffset;
				long num2 = 0L;
				UnmanagedMemoryStream ums2 = this._ums;
				BinaryReader store4 = this._store;
				num2.m_value = store4;
				BinaryReader store5 = this._store;
				long dataSectionOffset2 = this._dataSectionOffset;
				long num3 = 0L;
				int num4 = 20;
				if (dataSectionOffset2 != 0L)
				{
					Monitor.Exit(this);
				}
				if (num3 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num4 == 0)
				{
					Encoding unicode = Encoding.Unicode;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0004F884 File Offset: 0x0004DA84
		private object GetValueForNameIndex(int index)
		{
			int namePosition = this.GetNamePosition(index);
			Monitor.Enter(this, index != 0);
			BinaryReader store = this._store;
			long nameSectionOffset = this._nameSectionOffset;
			this.SkipString();
			BinaryReader store2 = this._store;
			BinaryReader store3 = this._store;
			long dataSectionOffset = this._dataSectionOffset;
			int version = this._version;
			object obj;
			return obj;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0004F90C File Offset: 0x0004DB0C
		internal string LoadString(int pos)
		{
			BinaryReader store = this._store;
			long dataSectionOffset = this._dataSectionOffset;
			int num = this._store.Read7BitEncodedInt();
			int version = this._version;
			RuntimeType runtimeType = this.FindType(num);
			if (dataSectionOffset == 0L)
			{
			}
			Type type;
			bool flag = runtimeType != type;
			RuntimeType runtimeType2 = this.FindType(num);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0004F980 File Offset: 0x0004DB80
		internal object LoadObject(int pos)
		{
			int version = this._version;
			return this.LoadObjectV1(pos);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		internal object LoadObject(int pos, [Out] ResourceTypeCode typeCode)
		{
			int version = this._version;
			object obj = this.LoadObjectV1(pos);
			if (obj != null)
			{
			}
			typeCode.value__ = 64;
			return obj;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0004F9CC File Offset: 0x0004DBCC
		internal object LoadObjectV1(int pos)
		{
			return this._LoadObjectV1(pos);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0004F9F0 File Offset: 0x0004DBF0
		private object _LoadObjectV1(int pos)
		{
			BinaryReader store = this._store;
			long dataSectionOffset = this._dataSectionOffset;
			int num = this._store.Read7BitEncodedInt();
			RuntimeType runtimeType = this.FindType(num);
			if (dataSectionOffset == 0L)
			{
			}
			Type type;
			bool flag = runtimeType == type;
			BinaryReader store2 = this._store;
			if (dataSectionOffset == 0L)
			{
			}
			Type type2;
			bool flag2 = runtimeType == type2;
			BinaryReader store3 = this._store;
			if (dataSectionOffset == 0L)
			{
			}
			Type type3;
			bool flag3 = runtimeType == type3;
			if (dataSectionOffset == 0L)
			{
			}
			Type type4;
			bool flag4 = runtimeType == type4;
			if (dataSectionOffset == 0L)
			{
			}
			Type type5;
			bool flag5 = runtimeType == type5;
			if (dataSectionOffset == 0L)
			{
			}
			Type type6;
			bool flag6 = runtimeType == type6;
			if (dataSectionOffset == 0L)
			{
			}
			Type type7;
			bool flag7 = runtimeType == type7;
			if (dataSectionOffset == 0L)
			{
			}
			Type type8;
			bool flag8 = runtimeType == type8;
			if (dataSectionOffset == 0L)
			{
			}
			Type type9;
			bool flag9 = runtimeType == type9;
			if (dataSectionOffset == 0L)
			{
			}
			Type type10;
			bool flag10 = runtimeType == type10;
			if (dataSectionOffset == 0L)
			{
			}
			Type type11;
			bool flag11 = runtimeType == type11;
			if (dataSectionOffset == 0L)
			{
			}
			Type type12;
			bool flag12 = runtimeType == type12;
			if (dataSectionOffset == 0L)
			{
			}
			Type type13;
			bool flag13 = runtimeType == type13;
			if (dataSectionOffset == 0L)
			{
			}
			Type type14;
			bool flag14 = runtimeType == type14;
			object obj;
			return obj;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0004FAF0 File Offset: 0x0004DCF0
		internal object LoadObjectV2(int pos, [Out] ResourceTypeCode typeCode)
		{
			return this._LoadObjectV2(pos, typeCode);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0004FB14 File Offset: 0x0004DD14
		private object _LoadObjectV2(int pos, [Out] ResourceTypeCode typeCode)
		{
			BinaryReader store = this._store;
			Dictionary<string, ResourceLocator> resCache = this._resCache;
			long num = 0L;
			int num2;
			typeCode.value__ = num2;
			return this.DeserializeObject((int)num);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0004FB58 File Offset: 0x0004DD58
		private object DeserializeObject(int typeIndex)
		{
			RuntimeType runtimeType = this.FindType(typeIndex);
			BinaryReader store = this._store;
			BinaryFormatter objFormatter = this._objFormatter;
			object obj;
			bool flag = obj.GetType() != runtimeType;
			return obj;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		private void ReadResources()
		{
			this._ReadResources();
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		private void _ReadResources()
		{
			BinaryReader store = this._store;
			BinaryReader store2 = this._store;
			BinaryReader store3 = this._store;
			BinaryReader store4 = this._store;
			this.SkipString();
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0004FD68 File Offset: 0x0004DF68
		private RuntimeType FindType(int typeIndex)
		{
			RuntimeType[] typeTable = this._typeTable;
			MonoTypeInfo type_info = typeTable.type_info;
			object genericCache = typeTable.GenericCache;
			if (type_info == null)
			{
			}
			BinaryReader store = this._store;
			BinaryReader store2 = this._store;
			int[] typeNamePositions = this._typeNamePositions;
			BinaryReader store3 = this._store;
			RuntimeType[] typeTable2 = this._typeTable;
			if (store3 != null && store3 == null)
			{
				throw new ArrayTypeMismatchException();
			}
			long num = 0L;
			int num2 = 6;
			BinaryReader store4 = this._store;
			if (num == 0L)
			{
				if (num2 == 0)
				{
					object genericCache2 = this._typeTable.GenericCache;
				}
				string resourceString = Environment.GetResourceString("Corrupt .resources file.  The specified type doesn't exist.");
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400133F RID: 4927
		private BinaryReader _store;

		// Token: 0x04001340 RID: 4928
		internal Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04001341 RID: 4929
		private long _nameSectionOffset;

		// Token: 0x04001342 RID: 4930
		private long _dataSectionOffset;

		// Token: 0x04001343 RID: 4931
		private int[] _nameHashes;

		// Token: 0x04001344 RID: 4932
		private unsafe int* _nameHashesPtr;

		// Token: 0x04001345 RID: 4933
		private int[] _namePositions;

		// Token: 0x04001346 RID: 4934
		private unsafe int* _namePositionsPtr;

		// Token: 0x04001347 RID: 4935
		private RuntimeType[] _typeTable;

		// Token: 0x04001348 RID: 4936
		private int[] _typeNamePositions;

		// Token: 0x04001349 RID: 4937
		private BinaryFormatter _objFormatter;

		// Token: 0x0400134A RID: 4938
		private int _numResources;

		// Token: 0x0400134B RID: 4939
		private UnmanagedMemoryStream _ums;

		// Token: 0x0400134C RID: 4940
		private int _version;

		// Token: 0x020004B8 RID: 1208
		internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002345 RID: 9029 RVA: 0x0004FE1C File Offset: 0x0004E01C
			internal ResourceEnumerator(ResourceReader reader)
			{
				this._reader = reader;
			}

			// Token: 0x06002346 RID: 9030 RVA: 0x0004FE38 File Offset: 0x0004E038
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002346)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Resources.ResourceReader/ResourceEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ResourceEnumerator::_currentName, ldloc:ResourceEnumerator(this)))
	stloc:int32(var_2_18, ldfld:int32(ResourceReader::_numResources, ldfld:ResourceReader(ResourceEnumerator::_reader, ldloc:ResourceEnumerator(this))))
	stloc:int32(var_3_1A, ldc.i4:int32(1))
	stfld:bool(ResourceEnumerator::_currentIsValid, ldloc:ResourceEnumerator(this), ldloc:int32[exp:bool](var_3_1A))
	stloc:int32(var_5_2A, ldc.i4:int32(32768))
	stfld:int32(ResourceEnumerator::_currentName, ldloc:ResourceEnumerator(this), ldloc:int32(var_5_2A))
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

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x06002347 RID: 9031 RVA: 0x0004FE78 File Offset: 0x0004E078
			public object Key
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002347)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Resources.ResourceReader/ResourceEnumerator::get_Key()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:string(var_3_38, call:string(Environment::GetResourceString, ldstr:string("ResourceReader is closed.")))
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
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06002348 RID: 9032 RVA: 0x0004FEC0 File Offset: 0x0004E0C0
			public object Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002348)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Resources.ResourceReader/ResourceEnumerator::get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DictionaryEntry(var_0_06, callgetter:DictionaryEntry(ResourceEnumerator::get_Entry, ldloc:ResourceEnumerator(this)))
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

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x06002349 RID: 9033 RVA: 0x0004FED4 File Offset: 0x0004E0D4
			internal int DataPosition
			{
				get
				{
					return this._dataPosition;
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x0600234A RID: 9034 RVA: 0x0004FEE8 File Offset: 0x0004E0E8
			public DictionaryEntry Entry
			{
				get
				{
					int currentName = this._currentName;
					if (this._currentIsValid)
					{
						ResourceReader reader = this._reader;
						if (reader._resCache != null)
						{
							Dictionary<string, ResourceLocator> resCache = this._reader._resCache;
							long num = 0L;
							ResourceReader reader2 = this._reader;
							int currentName2 = this._currentName;
							string text = reader2.AllocateStringForNameIndex(currentName2, (int)num);
							ResourceReader reader3 = this._reader;
							Dictionary<string, ResourceLocator> resCache2 = reader3._resCache;
							int dataPosition = this._dataPosition;
							object obj = this._reader.LoadObject(dataPosition);
							int currentName3 = this._currentName;
							long num2 = 0L;
							int num3 = 14;
							if (reader3 != null)
							{
								Monitor.Exit(resCache);
							}
							if (num2 != 0L)
							{
								throw new OutOfMemoryException();
							}
							long num4 = 0L;
							long num5;
							if (num3 == 0)
							{
								num5 = 0L;
							}
							if (reader3 != null)
							{
								Monitor.Exit(reader);
							}
							if (num4 == 0L)
							{
								if (num5 == 0L)
								{
								}
								return "Enumeration already finished.";
							}
						}
						else
						{
							string resourceString = Environment.GetResourceString("ResourceReader is closed.");
						}
						throw new OutOfMemoryException();
					}
					return "Enumeration has not started. Call MoveNext.";
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x0600234B RID: 9035 RVA: 0x00050004 File Offset: 0x0004E204
			public object Value
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600234B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Resources.ResourceReader/ResourceEnumerator::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:string(var_2_3C, call:string(Environment::GetResourceString, ldstr:string("ResourceReader is closed.")))
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
			}

			// Token: 0x0600234C RID: 9036 RVA: 0x00050050 File Offset: 0x0004E250
			public void Reset()
			{
				/*
An exception occurred when decompiling this method (0600234C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Resources.ResourceReader/ResourceEnumerator::Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:string(var_1_21, call:string(Environment::GetResourceString, ldstr:string("ResourceReader is closed.")))
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

			// Token: 0x0400134D RID: 4941
			private ResourceReader _reader;

			// Token: 0x0400134E RID: 4942
			private bool _currentIsValid;

			// Token: 0x0400134F RID: 4943
			private int _currentName;

			// Token: 0x04001350 RID: 4944
			private int _dataPosition;
		}
	}
}
