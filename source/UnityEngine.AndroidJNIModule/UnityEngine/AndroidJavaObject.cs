using System;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AndroidJavaObject : IDisposable
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00003810 File Offset: 0x00001A10
		public AndroidJavaObject(string className, string[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003830 File Offset: 0x00001A30
		public AndroidJavaObject(string className, AndroidJavaObject[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003850 File Offset: 0x00001A50
		public AndroidJavaObject(string className, AndroidJavaClass[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003870 File Offset: 0x00001A70
		public AndroidJavaObject(string className, AndroidJavaProxy[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003890 File Offset: 0x00001A90
		public AndroidJavaObject(string className, AndroidJavaRunnable[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000038B0 File Offset: 0x00001AB0
		public AndroidJavaObject(string className, params object[] args)
		{
			this._AndroidJavaObject(className, args);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000038CC File Offset: 0x00001ACC
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000038E0 File Offset: 0x00001AE0
		public void Call<T>(string methodName, T[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000038FC File Offset: 0x00001AFC
		public void Call(string methodName, params object[] args)
		{
			this._Call(methodName, args);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003914 File Offset: 0x00001B14
		public void CallStatic<T>(string methodName, T[] args)
		{
			if (args == null || args != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003930 File Offset: 0x00001B30
		public void CallStatic(string methodName, params object[] args)
		{
			this._CallStatic(methodName, args);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000353A File Offset: 0x0000173A
		public FieldType Get<FieldType>(string fieldName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003948 File Offset: 0x00001B48
		public void Set<FieldType>(string fieldName, FieldType val)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000353A File Offset: 0x0000173A
		public FieldType GetStatic<FieldType>(string fieldName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003958 File Offset: 0x00001B58
		public void SetStatic<FieldType>(string fieldName, FieldType val)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003968 File Offset: 0x00001B68
		public IntPtr GetRawObject()
		{
			/*
An exception occurred when decompiling this method (06000086)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr UnityEngine.AndroidJavaObject::GetRawObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:GlobalJavaObjectRef[exp:bool](AndroidJavaObject::m_jobject, ldloc:AndroidJavaObject(this))))
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

		// Token: 0x06000087 RID: 135 RVA: 0x0000397C File Offset: 0x00001B7C
		public IntPtr GetRawClass()
		{
			return this.m_jclass.m_jobject;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003994 File Offset: 0x00001B94
		public AndroidJavaObject CloneReference()
		{
			/*
An exception occurred when decompiling this method (06000088)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.AndroidJavaObject UnityEngine.AndroidJavaObject::CloneReference()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	stloc:native int(var_3_30, ldfld:native int(GlobalJavaObjectRef::m_jobject, ldloc:GlobalJavaObjectRef(var_1)))
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

		// Token: 0x06000089 RID: 137 RVA: 0x000039D4 File Offset: 0x00001BD4
		public ReturnType Call<ReturnType, T>(string methodName, T[] args)
		{
			if (args == null || args != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000353A File Offset: 0x0000173A
		public ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000039EC File Offset: 0x00001BEC
		public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args)
		{
			if (args == null || args != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000353A File Offset: 0x0000173A
		public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003A04 File Offset: 0x00001C04
		protected void DebugPrint(string msg)
		{
			Debug.Log(msg);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003A18 File Offset: 0x00001C18
		protected void DebugPrint(string call, string methodName, string signature, object[] args)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003A78 File Offset: 0x00001C78
		private void _AndroidJavaObject(string className, params object[] args)
		{
			string text = "Creating AndroidJavaObject from " + className;
			if (args == null)
			{
			}
			string text2;
			AndroidJNISafe.DeleteLocalRef(AndroidJNISafe.FindClass(text2));
			string text3;
			IntPtr constructorID = _AndroidJNIHelper.GetConstructorID(this.m_jclass.m_jobject, text3);
			jvalue[] array;
			AndroidJNISafe.DeleteLocalRef(AndroidJNISafe.NewObject(this.m_jclass.m_jobject, constructorID, array));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003AE4 File Offset: 0x00001CE4
		internal AndroidJavaObject(IntPtr jobject)
		{
			AndroidJNISafe.DeleteLocalRef(AndroidJNISafe.GetObjectClass(jobject));
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003B04 File Offset: 0x00001D04
		internal AndroidJavaObject()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003B18 File Offset: 0x00001D18
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003B4C File Offset: 0x00001D4C
		protected virtual void Dispose(bool disposing)
		{
			GlobalJavaObjectRef jobject = this.m_jobject;
			if (jobject != null)
			{
				jobject.Dispose();
			}
			GlobalJavaObjectRef jclass = this.m_jclass;
			if (jclass != null)
			{
				jclass.Dispose();
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003B7C File Offset: 0x00001D7C
		protected void _Call(string methodName, params object[] args)
		{
			if (args == null)
			{
			}
			IntPtr jobject = this.m_jclass.m_jobject;
			long num = 0L;
			string text;
			IntPtr methodID = _AndroidJNIHelper.GetMethodID(jobject, methodName, text, num != 0L);
			jvalue[] array;
			AndroidJNISafe.CallVoidMethod(this.m_jobject.m_jobject, methodID, array);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000353A File Offset: 0x0000173A
		protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003BCC File Offset: 0x00001DCC
		protected FieldType _Get<FieldType>(string fieldName)
		{
			IntPtr intPtr = this.m_jclass;
			Type type;
			bool flag = AndroidReflection.IsPrimitive(type);
			char charField = AndroidJNISafe.GetCharField(this.m_jobject, intPtr);
			Type type2;
			Type type3;
			bool flag2 = AndroidReflection.IsAssignableFrom(type2, type3);
			IntPtr intPtr2;
			IntPtr objectField = AndroidJNISafe.GetObjectField(intPtr2, intPtr);
			IntPtr intPtr3;
			int intField = AndroidJNISafe.GetIntField(intPtr3, intPtr);
			IntPtr intPtr4;
			string stringField = AndroidJNISafe.GetStringField(intPtr4, intPtr);
			IntPtr intPtr5;
			bool booleanField = AndroidJNISafe.GetBooleanField(intPtr5, intPtr);
			IntPtr intPtr6;
			AndroidJavaClass androidJavaClass = AndroidJavaObject.AndroidJavaClassDeleteLocalRef(AndroidJNISafe.GetObjectField(intPtr6, intPtr));
			Debug.LogWarning("Field type <Byte> for Java get field call is obsolete, use field type <SByte> instead");
			IntPtr intPtr7;
			sbyte sbyteField = AndroidJNISafe.GetSByteField(intPtr7, intPtr);
			IntPtr intPtr8;
			IntPtr objectField2 = AndroidJNISafe.GetObjectField(intPtr8, intPtr);
			IntPtr intPtr9;
			sbyte sbyteField2 = AndroidJNISafe.GetSByteField(intPtr9, intPtr);
			IntPtr intPtr10;
			short shortField = AndroidJNISafe.GetShortField(intPtr10, intPtr);
			IntPtr intPtr11;
			long longField = AndroidJNISafe.GetLongField(intPtr11, intPtr);
			IntPtr intPtr12;
			float floatField = AndroidJNISafe.GetFloatField(intPtr12, intPtr);
			IntPtr intPtr13;
			double doubleField = AndroidJNISafe.GetDoubleField(intPtr13, intPtr);
			throw new InvalidCastException();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003CA8 File Offset: 0x00001EA8
		protected void _Set<FieldType>(string fieldName, FieldType val)
		{
			IntPtr intPtr = this.m_jclass;
			Type type;
			bool flag = AndroidReflection.IsPrimitive(type);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003D20 File Offset: 0x00001F20
		protected void _CallStatic(string methodName, params object[] args)
		{
			if (args == null)
			{
			}
			string text;
			IntPtr methodID = _AndroidJNIHelper.GetMethodID(this.m_jclass.m_jobject, methodName, text, true);
			jvalue[] array;
			AndroidJNISafe.CallStaticVoidMethod(this.m_jclass.m_jobject, methodID, array);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000353A File Offset: 0x0000173A
		protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003D6C File Offset: 0x00001F6C
		protected FieldType _GetStatic<FieldType>(string fieldName)
		{
			IntPtr intPtr = this.m_jclass;
			Type type;
			bool flag = AndroidReflection.IsPrimitive(type);
			char staticCharField = AndroidJNISafe.GetStaticCharField(this.m_jclass, intPtr);
			Type type2;
			Type type3;
			bool flag2 = AndroidReflection.IsAssignableFrom(type2, type3);
			IntPtr intPtr2;
			IntPtr staticObjectField = AndroidJNISafe.GetStaticObjectField(intPtr2, intPtr);
			IntPtr intPtr3;
			int staticIntField = AndroidJNISafe.GetStaticIntField(intPtr3, intPtr);
			IntPtr intPtr4;
			string staticStringField = AndroidJNISafe.GetStaticStringField(intPtr4, intPtr);
			IntPtr intPtr5;
			bool staticBooleanField = AndroidJNISafe.GetStaticBooleanField(intPtr5, intPtr);
			IntPtr intPtr6;
			AndroidJavaClass androidJavaClass = AndroidJavaObject.AndroidJavaClassDeleteLocalRef(AndroidJNISafe.GetStaticObjectField(intPtr6, intPtr));
			Debug.LogWarning("Field type <Byte> for Java get field call is obsolete, use field type <SByte> instead");
			IntPtr intPtr7;
			sbyte staticSByteField = AndroidJNISafe.GetStaticSByteField(intPtr7, intPtr);
			IntPtr intPtr8;
			IntPtr staticObjectField2 = AndroidJNISafe.GetStaticObjectField(intPtr8, intPtr);
			IntPtr intPtr9;
			sbyte staticSByteField2 = AndroidJNISafe.GetStaticSByteField(intPtr9, intPtr);
			IntPtr intPtr10;
			short staticShortField = AndroidJNISafe.GetStaticShortField(intPtr10, intPtr);
			IntPtr intPtr11;
			long staticLongField = AndroidJNISafe.GetStaticLongField(intPtr11, intPtr);
			IntPtr intPtr12;
			float staticFloatField = AndroidJNISafe.GetStaticFloatField(intPtr12, intPtr);
			IntPtr intPtr13;
			double staticDoubleField = AndroidJNISafe.GetStaticDoubleField(intPtr13, intPtr);
			throw new InvalidCastException();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003E48 File Offset: 0x00002048
		protected void _SetStatic<FieldType>(string fieldName, FieldType val)
		{
			IntPtr intPtr = this.m_jclass;
			Type type;
			bool flag = AndroidReflection.IsPrimitive(type);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003EC0 File Offset: 0x000020C0
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000353A File Offset: 0x0000173A
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003EDC File Offset: 0x000020DC
		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
		{
			bool flag;
			AndroidJNISafe.DeleteLocalRef(flag ? 1 : 0);
			throw new InvalidCastException();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003F10 File Offset: 0x00002110
		protected IntPtr _GetRawObject()
		{
			/*
An exception occurred when decompiling this method (0600009F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr UnityEngine.AndroidJavaObject::_GetRawObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:GlobalJavaObjectRef[exp:bool](AndroidJavaObject::m_jobject, ldloc:AndroidJavaObject(this))))
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

		// Token: 0x060000A0 RID: 160 RVA: 0x00003F24 File Offset: 0x00002124
		protected IntPtr _GetRawClass()
		{
			return this.m_jclass.m_jobject;
		}

		// Token: 0x04000009 RID: 9
		private static bool enableDebugPrints;

		// Token: 0x0400000A RID: 10
		internal GlobalJavaObjectRef m_jobject;

		// Token: 0x0400000B RID: 11
		internal GlobalJavaObjectRef m_jclass;
	}
}
