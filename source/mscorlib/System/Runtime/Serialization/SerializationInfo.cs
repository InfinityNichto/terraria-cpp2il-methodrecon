using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003ED RID: 1005
	[ComVisible(true)]
	public sealed class SerializationInfo
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x0004573C File Offset: 0x0004393C
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0004574C File Offset: 0x0004394C
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
		{
			do
			{
				base..ctor();
				if (type == null)
				{
					return;
				}
			}
			while (converter == null);
			this.objectType = type;
			this.m_fullTypeName = type;
			this.m_assemName = type;
			this.m_converter = converter;
			this.requireSameTokenInPartialTrust = requireSameTokenInPartialTrust;
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0004578C File Offset: 0x0004398C
		public string FullTypeName
		{
			get
			{
				return this.m_fullTypeName;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x000457A0 File Offset: 0x000439A0
		public string AssemblyName
		{
			get
			{
				return this.m_assemName;
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000457B4 File Offset: 0x000439B4
		public void SetType(Type type)
		{
			while (type == null)
			{
			}
			if (this.requireSameTokenInPartialTrust)
			{
				Type type2 = this.objectType;
			}
			Type type3 = this.objectType;
			this.objectType = type;
			this.m_fullTypeName = type;
			this.m_assemName = type;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000457F0 File Offset: 0x000439F0
		private static bool Compare(byte[] a, byte[] b)
		{
			for (;;)
			{
				long num = 0L;
				if (a != null && num != 0L)
				{
					return;
				}
			}
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00045808 File Offset: 0x00043A08
		internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			bool flag = SerializationInfo.IsAssemblyNameAssignmentSafe(originalAssemblyName, newAssemblyName);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00045820 File Offset: 0x00043A20
		internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			bool flag = "mscorlib" == originalAssemblyName;
			return true;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x00045848 File Offset: 0x00043A48
		public int MemberCount
		{
			get
			{
				return this.m_currMember;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0004585C File Offset: 0x00043A5C
		public Type ObjectType
		{
			get
			{
				return this.objectType;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00045870 File Offset: 0x00043A70
		public bool IsFullTypeNameSetExplicit
		{
			get
			{
				return this.isFullTypeNameSetExplicit;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00045884 File Offset: 0x00043A84
		public bool IsAssemblyNameSetExplicit
		{
			get
			{
				return this.isAssemblyNameSetExplicit;
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00045898 File Offset: 0x00043A98
		public SerializationInfoEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06001FAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.SerializationInfoEnumerator System.Runtime.Serialization.SerializationInfo::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](SerializationInfo::m_members, ldloc:SerializationInfo(this)))
	stloc:class System.Type[](var_1_0D, ldfld:class System.Type[](SerializationInfo::m_types, ldloc:SerializationInfo(this)))
	stloc:int32(var_2_14, ldfld:int32(SerializationInfo::m_currMember, ldloc:SerializationInfo(this)))
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

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000458BC File Offset: 0x00043ABC
		private void ExpandArrays()
		{
			int currMember = this.m_currMember;
			string[] members = this.m_members;
			int currMember2 = this.m_currMember;
			object[] data = this.m_data;
			int currMember3 = this.m_currMember;
			Type[] types = this.m_types;
			int currMember4 = this.m_currMember;
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00045900 File Offset: 0x00043B00
		public void AddValue(string name, object value, Type type)
		{
			while (name != null)
			{
				if (type != null)
				{
					this.AddValueInternal(name, value, type);
					return;
				}
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00045920 File Offset: 0x00043B20
		public void AddValue(string name, object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				return;
			}
			long num = 0L;
			Type type2;
			this.AddValue(name, num, type2);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00045944 File Offset: 0x00043B44
		public void AddValue(string name, bool value)
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00045954 File Offset: 0x00043B54
		public void AddValue(string name, byte value)
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00045964 File Offset: 0x00043B64
		public void AddValue(string name, short value)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00045974 File Offset: 0x00043B74
		public void AddValue(string name, int value)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00045984 File Offset: 0x00043B84
		public void AddValue(string name, long value)
		{
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00045994 File Offset: 0x00043B94
		[CLSCompliant(false)]
		public void AddValue(string name, ulong value)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000459A4 File Offset: 0x00043BA4
		public void AddValue(string name, float value)
		{
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000459B4 File Offset: 0x00043BB4
		public void AddValue(string name, DateTime value)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000459C4 File Offset: 0x00043BC4
		internal void AddValueInternal(string name, object value, Type type)
		{
			Dictionary<string, int> nameToIndex = this.m_nameToIndex;
			Dictionary<string, int> nameToIndex2 = this.m_nameToIndex;
			int currMember = this.m_currMember;
			string[] members = this.m_members;
			int currMember2 = this.m_currMember;
			this.ExpandArrays();
			string[] members2 = this.m_members;
			int currMember3 = this.m_currMember;
			if (name != null)
			{
				if (name == null)
				{
					goto IL_007D;
				}
				int currMember4 = this.m_currMember;
			}
			object[] data = this.m_data;
			if (value != null)
			{
				if (value == null)
				{
					goto IL_007D;
				}
				int currMember5 = this.m_currMember;
			}
			Type[] types = this.m_types;
			int currMember6;
			if (type != null)
			{
				if (type == null)
				{
					goto IL_007D;
				}
				currMember6 = this.m_currMember;
			}
			this.m_currMember = currMember6;
			return;
			IL_007D:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00045A60 File Offset: 0x00043C60
		internal void UpdateValue(string name, object value, Type type)
		{
			int num = this.FindElement(name);
			object[] data = this.m_data;
			if (value == null || value != null)
			{
				Type[] types = this.m_types;
				if (type == null || type != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00045A98 File Offset: 0x00043C98
		private int FindElement(string name)
		{
			/*
An exception occurred when decompiling this method (06001FBD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Serialization.SerializationInfo::FindElement(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.Dictionary`2<string, int32>(var_0_09, ldfld:class System.Collections.Generic.Dictionary`2<string, int32>(SerializationInfo::m_nameToIndex, ldloc:SerializationInfo(this)))
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

		// Token: 0x06001FBE RID: 8126 RVA: 0x00045AB0 File Offset: 0x00043CB0
		private object GetElement(string name, [Out] Type foundType)
		{
			int num = this.FindElement(name);
			Type[] types = this.m_types;
			object[] data = this.m_data;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00045ADC File Offset: 0x00043CDC
		[ComVisible(true)]
		private object GetElementNoThrow(string name, [Out] Type foundType)
		{
			/*
An exception occurred when decompiling this method (06001FBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.SerializationInfo::GetElementNoThrow(System.String,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(SerializationInfo::FindElement, ldloc:SerializationInfo(this), ldloc:string(name)))
	stloc:class System.Type[](var_1_0E, ldfld:class System.Type[](SerializationInfo::m_types, ldloc:SerializationInfo(this)))
	stloc:object[](var_2_15, ldfld:object[](SerializationInfo::m_data, ldloc:SerializationInfo(this)))
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

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00045B00 File Offset: 0x00043D00
		public object GetValue(string name, Type type)
		{
			/*
An exception occurred when decompiling this method (06001FC0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.SerializationInfo::GetValue(System.String,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:string(var_5_1F, call:string(Environment::GetResourceString, ldstr:string("Type must be a runtime Type object.")))
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

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00045B30 File Offset: 0x00043D30
		[ComVisible(true)]
		internal object GetValueNoThrow(string name, Type type)
		{
			/*
An exception occurred when decompiling this method (06001FC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.SerializationInfo::GetValueNoThrow(System.String,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Type[](var_2_18, ldfld:class System.Type[](SerializationInfo::m_types, ldloc:SerializationInfo(this)))
	stloc:IFormatterConverter(var_3_1F, ldfld:IFormatterConverter(SerializationInfo::m_converter, ldloc:SerializationInfo(this)))
	stloc:int64(var_4_26, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00045B64 File Offset: 0x00043D64
		public bool GetBoolean(string name)
		{
			IFormatterConverter converter = this.m_converter;
			throw new InvalidCastException();
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00045B80 File Offset: 0x00043D80
		public int GetInt32(string name)
		{
			IFormatterConverter converter = this.m_converter;
			throw new InvalidCastException();
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00045B9C File Offset: 0x00043D9C
		public long GetInt64(string name)
		{
			IFormatterConverter converter = this.m_converter;
			throw new InvalidCastException();
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00045BB8 File Offset: 0x00043DB8
		public float GetSingle(string name)
		{
			IFormatterConverter converter = this.m_converter;
			throw new InvalidCastException();
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00045BD4 File Offset: 0x00043DD4
		public string GetString(string name)
		{
			object obj;
			do
			{
				if (obj != null)
				{
					IFormatterConverter converter = this.m_converter;
				}
			}
			while (obj == null);
			throw new InvalidCastException();
		}

		// Token: 0x04000FCB RID: 4043
		private const int defaultSize = 4;

		// Token: 0x04000FCC RID: 4044
		private const string s_mscorlibAssemblySimpleName = "mscorlib";

		// Token: 0x04000FCD RID: 4045
		private const string s_mscorlibFileName = "mscorlib.dll";

		// Token: 0x04000FCE RID: 4046
		internal string[] m_members;

		// Token: 0x04000FCF RID: 4047
		internal object[] m_data;

		// Token: 0x04000FD0 RID: 4048
		internal Type[] m_types;

		// Token: 0x04000FD1 RID: 4049
		private Dictionary<string, int> m_nameToIndex;

		// Token: 0x04000FD2 RID: 4050
		internal int m_currMember;

		// Token: 0x04000FD3 RID: 4051
		internal IFormatterConverter m_converter;

		// Token: 0x04000FD4 RID: 4052
		private string m_fullTypeName;

		// Token: 0x04000FD5 RID: 4053
		private string m_assemName;

		// Token: 0x04000FD6 RID: 4054
		private Type objectType;

		// Token: 0x04000FD7 RID: 4055
		private bool isFullTypeNameSetExplicit;

		// Token: 0x04000FD8 RID: 4056
		private bool isAssemblyNameSetExplicit;

		// Token: 0x04000FD9 RID: 4057
		private bool requireSameTokenInPartialTrust;
	}
}
