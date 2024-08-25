using System;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041E RID: 1054
	internal sealed class ObjectReader
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x000486DC File Offset: 0x000468DC
		private SerStack ValueFixupStack
		{
			get
			{
				/*
An exception occurred when decompiling this method (060020AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.Formatters.Binary.SerStack System.Runtime.Serialization.Formatters.Binary.ObjectReader::get_ValueFixupStack()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:SerStack[exp:bool](ObjectReader::valueFixupStack, ldloc:ObjectReader(this)))
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
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000486F0 File Offset: 0x000468F0
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00048704 File Offset: 0x00046904
		internal object TopObject
		{
			get
			{
				return this.m_topObject;
			}
			set
			{
				ObjectManager objectManager = this.m_objectManager;
				this.m_topObject = value;
				if (objectManager != null)
				{
					objectManager.m_topObject = value;
				}
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0004872C File Offset: 0x0004692C
		internal ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
			/*
An exception occurred when decompiling this method (060020AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.Serialization.Formatters.Binary.ObjectReader::.ctor(System.IO.Stream,System.Runtime.Serialization.ISurrogateSelector,System.Runtime.Serialization.StreamingContext,System.Runtime.Serialization.Formatters.Binary.InternalFE,System.Runtime.Serialization.SerializationBinder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0034:
	stloc:string(var_0_3E, call:string(Environment::GetResourceString, ldstr:string("Stream cannot be null.")))
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

		// Token: 0x060020B0 RID: 8368 RVA: 0x00048778 File Offset: 0x00046978
		internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			int num = 1;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			Type type;
			if (type != null)
			{
			}
			bool flag;
			bool value;
			if (flag)
			{
				if (!flag)
				{
					throw new InvalidCastException();
				}
				if (!flag)
				{
					throw new InvalidCastException();
				}
				value = flag.m_value;
				if (value)
				{
				}
			}
			if (value)
			{
			}
			if (handler != null)
			{
				IntPtr invoke_impl = handler.invoke_impl;
				IntPtr method_code = handler.method_code;
				IntPtr method = handler.method;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000487E4 File Offset: 0x000469E4
		private bool HasSurrogate(Type t)
		{
			/*
An exception occurred when decompiling this method (060020B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.Formatters.Binary.ObjectReader::HasSurrogate(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:int64(var_2_21, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x060020B2 RID: 8370 RVA: 0x00048814 File Offset: 0x00046A14
		private void CheckSerializable(Type t)
		{
			bool flag = this.HasSurrogate(t);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00048848 File Offset: 0x00046A48
		private void InitFullDeserialization()
		{
			this.bFullDeserialization = true;
			ISurrogateSelector surrogates = this.m_surrogates;
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
			if (this.m_formatterConverter == null)
			{
			}
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00048880 File Offset: 0x00046A80
		internal object CrossAppDomainArray(int index)
		{
			/*
An exception occurred when decompiling this method (060020B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.Formatters.Binary.ObjectReader::CrossAppDomainArray(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_06, ldfld:object[](ObjectReader::crossAppDomainArray, ldloc:ObjectReader(this)))
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

		// Token: 0x060020B5 RID: 8373 RVA: 0x00048894 File Offset: 0x00046A94
		internal ReadObjectInfo CreateReadObjectInfo(Type objectType)
		{
			ISurrogateSelector surrogates = this.m_surrogates;
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
			ObjectManager objectManager = this.m_objectManager;
			SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
			IFormatterConverter formatterConverter = this.m_formatterConverter;
			bool flag = this.bSimpleAssembly;
			ReadObjectInfo readObjectInfo;
			return readObjectInfo;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000488DC File Offset: 0x00046ADC
		internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes)
		{
			ISurrogateSelector surrogates = this.m_surrogates;
			StreamingContext context = this.m_context;
			StreamingContextStates state = this.m_context.m_state;
			ObjectManager objectManager = this.m_objectManager;
			SerObjectInfoInit serObjectInfoInit = this.serObjectInfoInit;
			IFormatterConverter formatterConverter = this.m_formatterConverter;
			bool flag = this.bSimpleAssembly;
			ReadObjectInfo readObjectInfo;
			return readObjectInfo;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00048924 File Offset: 0x00046B24
		internal void Parse(ParseRecord pr)
		{
			InternalParseTypeE prparseTypeEnum = pr.PRparseTypeEnum;
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00048974 File Offset: 0x00046B74
		private void ParseError(ParseRecord processing, ParseRecord onStack)
		{
			string prname = onStack.PRname;
			if ((prname == null || prname != null) && (" " == null || " " != null))
			{
				InternalParseTypeE prparseTypeEnum = onStack.PRparseTypeEnum;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000489E8 File Offset: 0x00046BE8
		private void ParseSerializedStreamHeader(ParseRecord pr)
		{
			this.stack.Push(pr);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00048A04 File Offset: 0x00046C04
		private void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
			object[] objects = this.stack.objects;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00048A20 File Offset: 0x00046C20
		private void ParseObject(ParseRecord pr)
		{
			if (!this.bFullDeserialization)
			{
				this.InitFullDeserialization();
			}
			InternalObjectPositionE probjectPositionEnum = pr.PRobjectPositionEnum;
			long probjectId = pr.PRobjectId;
			this.topId = probjectId;
			InternalParseTypeE prparseTypeEnum = pr.PRparseTypeEnum;
			this.stack.Push(pr);
			InternalObjectTypeE probjectTypeEnum = pr.PRobjectTypeEnum;
			this.ParseArray(pr);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00048B90 File Offset: 0x00046D90
		private void ParseObjectEnd(ParseRecord pr)
		{
			SerStack serStack = this.stack;
			int top = serStack.top;
			object[] objects = serStack.objects;
			if (serStack == null)
			{
			}
			SerStack serStack2 = this.stack;
			int top2 = serStack2.top;
			object[] objects2 = serStack2.objects;
			object[] objects3 = this.stack.objects;
			throw new InvalidCastException();
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00048C2C File Offset: 0x00046E2C
		private void ParseArray(ParseRecord pr)
		{
			InternalArrayTypeE prarrayTypeEnum = pr.PRarrayTypeEnum;
			string prvalue = pr.PRvalue;
			int stringLength = prvalue._stringLength;
			byte[] array = Convert.FromBase64String(prvalue);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00048E84 File Offset: 0x00047084
		private void NextRectangleMap(ParseRecord pr)
		{
			int prrank = pr.PRrank;
			int[] prrectangularMap = pr.PRrectangularMap;
			int[] prlengthA = pr.PRlengthA;
			int prrank2 = pr.PRrank;
			int[] prindexMap = pr.PRindexMap;
			Array.Copy(prrectangularMap, prindexMap, prrank2);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00048EC0 File Offset: 0x000470C0
		private void ParseArrayMember(ParseRecord pr)
		{
			object[] objects = this.stack.objects;
			throw new InvalidCastException();
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00048FA8 File Offset: 0x000471A8
		private void ParseArrayMemberEnd(ParseRecord pr)
		{
			InternalMemberValueE prmemberValueEnum = pr.PRmemberValueEnum;
			this.ParseObjectEnd(pr);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00048FC4 File Offset: 0x000471C4
		private void ParseMember(ParseRecord pr)
		{
			object[] objects = this.stack.objects;
			throw new InvalidCastException();
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000490F4 File Offset: 0x000472F4
		private void ParseMemberEnd(ParseRecord pr)
		{
			InternalMemberTypeE prmemberTypeEnum = pr.PRmemberTypeEnum;
			InternalMemberValueE prmemberValueEnum = pr.PRmemberValueEnum;
			this.ParseObjectEnd(pr);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00049130 File Offset: 0x00047330
		private void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
			if (pr.PRisRegistered)
			{
				return;
			}
			long probjectId = pr.PRobjectId;
			string prvalue = pr.PRvalue;
			this.RegisterObject(prvalue, pr, parentPr, true);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00049160 File Offset: 0x00047360
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr)
		{
			long num = 0L;
			this.RegisterObject(obj, pr, objectPr, num != 0L);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0004917C File Offset: 0x0004737C
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
			if (pr.PRisRegistered)
			{
				return;
			}
			pr.PRisRegistered = true;
			if (objectPr != null)
			{
				int[] prindexMap = objectPr.PRindexMap;
				ReadObjectInfo probjectInfo = objectPr.PRobjectInfo;
				long probjectId = objectPr.PRobjectId;
				if (probjectInfo != null && !probjectInfo.isSi)
				{
					string prname = pr.PRname;
					MemberInfo memberInfo = probjectInfo.GetMemberInfo(prname);
					return;
				}
			}
			SerializationInfo prsi = pr.PRsi;
			ObjectManager objectManager = this.m_objectManager;
			long probjectId2 = pr.PRobjectId;
			if (obj != null)
			{
			}
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000491F0 File Offset: 0x000473F0
		internal long GetId(long objectId)
		{
			bool flag = this.bFullDeserialization;
			if (!flag)
			{
				this.InitFullDeserialization();
			}
			if (!flag)
			{
			}
			if (objectId == 0L)
			{
			}
			return objectId;
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00049218 File Offset: 0x00047418
		internal Type Bind(string assemblyString, string typeString)
		{
			SerializationBinder binder = this.m_binder;
			if (binder == null || binder != null)
			{
			}
			return this.FastBindToType(assemblyString, typeString);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0004923C File Offset: 0x0004743C
		internal Type FastBindToType(string assemblyName, string typeName)
		{
			do
			{
				if (this.typeCache.GetCachedValue(typeName) != null)
				{
				}
				if (this.bSimpleAssembly)
				{
					if (typeName == null)
					{
						break;
					}
					NameCache nameCache = this.typeCache;
				}
			}
			while (FormatterServices.GetTypeFromAssembly(Assembly.Load(assemblyName), typeName) != null);
			throw new InvalidCastException();
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0000207A File Offset: 0x0000027A
		private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00049288 File Offset: 0x00047488
		private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, Type type)
		{
			if (!true)
			{
			}
			if (FormatterServices.GetTypeFromAssembly(assm, typeName) == null)
			{
			}
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x000492A8 File Offset: 0x000474A8
		internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			string text = this.previousName;
			if (text != null)
			{
				int stringLength = text._stringLength;
				int stringLength2 = name._stringLength;
				bool flag = text.Equals(name);
				string text2 = this.previousAssemblyString;
				if (text2 != null)
				{
					string assemblyString = assemblyInfo.assemblyString;
					int stringLength3 = text2._stringLength;
					int stringLength4 = assemblyString._stringLength;
					bool flag2 = text2.Equals(assemblyString);
					Type type = this.previousType;
				}
			}
			string assemblyString2 = assemblyInfo.assemblyString;
			Type type2 = this.Bind(assemblyString2, name);
			if (type2 != null)
			{
				return type2;
			}
			Assembly assembly = assemblyInfo.GetAssembly();
			if (this.bSimpleAssembly)
			{
			}
			Type typeFromAssembly = FormatterServices.GetTypeFromAssembly(assembly, name);
			string assemblyString3 = assemblyInfo.assemblyString;
			this.previousType = typeFromAssembly;
			this.previousAssemblyString = assemblyString3;
			this.previousName = name;
			return typeFromAssembly;
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00049364 File Offset: 0x00047564
		private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType)
		{
			if (!true)
			{
			}
			bool flag = FormatterServices.UnsafeTypeForwardersIsEnabled();
			bool flag2 = sourceAssembly != destAssembly;
			TypeInformation typeInformation = BinaryFormatter.GetTypeInformation(resolvedType);
			if (typeInformation.hasTypeForwardedFrom)
			{
				string assemblyString = typeInformation.assemblyString;
				Assembly assembly = Assembly.Load(assemblyString);
			}
		}

		// Token: 0x0400113B RID: 4411
		internal Stream m_stream;

		// Token: 0x0400113C RID: 4412
		internal ISurrogateSelector m_surrogates;

		// Token: 0x0400113D RID: 4413
		internal StreamingContext m_context;

		// Token: 0x0400113E RID: 4414
		internal ObjectManager m_objectManager;

		// Token: 0x0400113F RID: 4415
		internal InternalFE formatterEnums;

		// Token: 0x04001140 RID: 4416
		internal SerializationBinder m_binder;

		// Token: 0x04001141 RID: 4417
		internal long topId;

		// Token: 0x04001142 RID: 4418
		internal bool bSimpleAssembly;

		// Token: 0x04001143 RID: 4419
		internal object handlerObject;

		// Token: 0x04001144 RID: 4420
		internal object m_topObject;

		// Token: 0x04001145 RID: 4421
		internal Header[] headers;

		// Token: 0x04001146 RID: 4422
		internal HeaderHandler handler;

		// Token: 0x04001147 RID: 4423
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04001148 RID: 4424
		internal IFormatterConverter m_formatterConverter;

		// Token: 0x04001149 RID: 4425
		internal SerStack stack;

		// Token: 0x0400114A RID: 4426
		private SerStack valueFixupStack;

		// Token: 0x0400114B RID: 4427
		internal object[] crossAppDomainArray;

		// Token: 0x0400114C RID: 4428
		private bool bFullDeserialization;

		// Token: 0x0400114D RID: 4429
		private bool bOldFormatDetected;

		// Token: 0x0400114E RID: 4430
		private IntSizedArray valTypeObjectIdTable;

		// Token: 0x0400114F RID: 4431
		private NameCache typeCache;

		// Token: 0x04001150 RID: 4432
		private string previousAssemblyString;

		// Token: 0x04001151 RID: 4433
		private string previousName;

		// Token: 0x04001152 RID: 4434
		private Type previousType;

		// Token: 0x0200041F RID: 1055
		internal class TypeNAssembly
		{
			// Token: 0x060020CD RID: 8397 RVA: 0x000493AC File Offset: 0x000475AC
			public TypeNAssembly()
			{
			}

			// Token: 0x04001153 RID: 4435
			public Type type;

			// Token: 0x04001154 RID: 4436
			public string assemblyName;
		}

		// Token: 0x02000420 RID: 1056
		internal sealed class TopLevelAssemblyTypeResolver
		{
			// Token: 0x060020CE RID: 8398 RVA: 0x000493C0 File Offset: 0x000475C0
			public TopLevelAssemblyTypeResolver(Assembly topLevelAssembly)
			{
				this.m_topLevelAssembly = topLevelAssembly;
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x000493DC File Offset: 0x000475DC
			public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				/*
An exception occurred when decompiling this method (060020CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Runtime.Serialization.Formatters.Binary.ObjectReader/TopLevelAssemblyTypeResolver::ResolveType(System.Reflection.Assembly,System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Assembly(var_1_06, ldfld:Assembly(TopLevelAssemblyTypeResolver::m_topLevelAssembly, ldloc:TopLevelAssemblyTypeResolver(this)))
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

			// Token: 0x04001155 RID: 4437
			private Assembly m_topLevelAssembly;
		}
	}
}
