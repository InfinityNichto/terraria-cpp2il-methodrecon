using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000152 RID: 338
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class Exception : ISerializable
	{
		// Token: 0x06000D64 RID: 3428 RVA: 0x0001D24C File Offset: 0x0001B44C
		private void Init()
		{
			this._HResult = 5376;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0001D264 File Offset: 0x0001B464
		public Exception()
		{
			this.Init();
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0001D280 File Offset: 0x0001B480
		public Exception(string message)
		{
			this.Init();
			this._message = message;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		public Exception(string message, Exception innerException)
		{
			this.Init();
			this._message = message;
			this._innerException = innerException;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		protected Exception(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (06000D68)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Exception::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0147:
	stloc:string(var_17_151, call:string(Environment::GetResourceString, ldstr:string("Insufficient state to return the real object.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0001D428 File Offset: 0x0001B628
		public virtual string Message
		{
			get
			{
				string message = this._message;
				if (message != null)
				{
					return message;
				}
				if (this._className == null)
				{
					string className = this.GetClassName();
					this._className = className;
				}
				string className2 = this._className;
				if (className2 == null || className2 != null)
				{
					string text;
					return text;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0001D46C File Offset: 0x0001B66C
		public virtual IDictionary Data
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000D6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionary System.Exception::get_Data()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:IDictionary[exp:bool](Exception::_data, ldloc:Exception(this)))
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

		// Token: 0x06000D6B RID: 3435 RVA: 0x0001D480 File Offset: 0x0001B680
		private string GetClassName()
		{
			/*
An exception occurred when decompiling this method (06000D6B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Exception::GetClassName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_0E, call:Type(object::GetType, ldloc:Exception[exp:object](this)))
	stfld:string(Exception::_className, ldloc:Exception(this), ldloc:Type[exp:string](var_0_0E))
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
		public Exception InnerException
		{
			get
			{
				return this._innerException;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		public virtual string StackTrace
		{
			get
			{
				return this.GetStackTrace(true);
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		private string GetStackTrace(bool needFileInfo)
		{
			string stackTraceString = this._stackTraceString;
			string remoteStackTraceString = this._remoteStackTraceString;
			if (stackTraceString != null)
			{
				return remoteStackTraceString;
			}
			if (stackTraceString != null)
			{
				string text;
				return remoteStackTraceString + text;
			}
			return remoteStackTraceString;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		internal void SetErrorCode(int hr)
		{
			this._HResult = hr;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0001D50C File Offset: 0x0001B70C
		public virtual string Source
		{
			get
			{
				while (this._source == null)
				{
				}
				return this._source;
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0001D528 File Offset: 0x0001B728
		public override string ToString()
		{
			return this.ToString(true, true);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0001D540 File Offset: 0x0001B740
		private string ToString(bool needFileLineInfo, bool needMessage)
		{
			if (this != null)
			{
				string className = this._className;
				string className2 = this.GetClassName();
				string text;
				return text;
			}
			string className3 = this.GetClassName();
			long num;
			if (this._innerException != null)
			{
				if ((className3 == null || className3 != null) && (" ---> " == null || " ---> " != null))
				{
					Exception innerException = this._innerException;
					string text2;
					if (text2 == null || text2 != null)
					{
						string newLine = Environment.NewLine;
						if ((newLine == null || newLine != null) && ("   " == null || "   " != null))
						{
							string resourceString = Environment.GetResourceString("--- End of inner exception stack trace ---");
							if (resourceString == null || resourceString != null)
							{
								num = 0L;
								goto IL_0083;
							}
						}
					}
				}
				throw new ArrayTypeMismatchException();
			}
			IL_0083:
			string stackTrace = this.GetStackTrace(num != 0L);
			string text3;
			if (stackTrace != null)
			{
				string newLine2 = Environment.NewLine;
				return text3 + newLine2 + stackTrace;
			}
			return text3;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			string stackTrace;
			if (this._stackTraceString == null && this._stackTrace != null)
			{
				stackTrace = Environment.GetStackTrace(this, true);
			}
			if (this._source == null)
			{
				this._source = this;
			}
			string className = this.GetClassName();
			Type type;
			info.AddValue("ClassName", className, type);
			string message = this._message;
			Type type2;
			info.AddValue("Message", message, type2);
			IDictionary data = this._data;
			Exception innerException = this._innerException;
			Type type3;
			info.AddValue("InnerException", innerException, type3);
			string helpURL = this._helpURL;
			Type type4;
			info.AddValue("HelpURL", helpURL, type4);
			Type type5;
			info.AddValue("StackTraceString", stackTrace, type5);
			string remoteStackTraceString = this._remoteStackTraceString;
			Type type6;
			info.AddValue("RemoteStackTraceString", remoteStackTraceString, type6);
			int remoteStackIndex = this._remoteStackIndex;
			long num = 0L;
			info.AddValue("ExceptionMethod", num);
			int hresult = this._HResult;
			info.AddValue("HResult", hresult);
			string source = this._source;
			Type type7;
			info.AddValue("Source", source, type7);
			SafeSerializationManager safeSerializationManager = this._safeSerializationManager;
			if (safeSerializationManager != null)
			{
				bool isActive = safeSerializationManager.IsActive;
				SafeSerializationManager safeSerializationManager2 = this._safeSerializationManager;
				Type type8;
				info.AddValue("SafeSerializationManager", safeSerializationManager2, type8);
				SafeSerializationManager safeSerializationManager3 = this._safeSerializationManager;
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0001D730 File Offset: 0x0001B930
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			SafeSerializationManager safeSerializationManager = this._safeSerializationManager;
			if (safeSerializationManager != null)
			{
				safeSerializationManager.CompleteDeserialization(this);
				return;
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0001D750 File Offset: 0x0001B950
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			return stackTrace;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0001D760 File Offset: 0x0001B960
		internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
			object stackTrace = exceptionDispatchInfo.m_stackTrace;
			if (stackTrace != null)
			{
				if (stackTrace != null)
				{
					this.captured_traces = stackTrace;
					if (stackTrace != null)
					{
						return;
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0001D78C File Offset: 0x0001B98C
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		public int HResult
		{
			get
			{
				return this._HResult;
			}
			protected set
			{
				this._HResult = value;
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
		public new Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind)
		{
			return "";
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0001D7E4 File Offset: 0x0001B9E4
		internal Exception FixRemotingException()
		{
			int remoteStackIndex = this._remoteStackIndex;
			string newLine = Environment.NewLine;
			int remoteStackIndex2 = this._remoteStackIndex;
			int remoteStackIndex3 = this._remoteStackIndex;
			string text;
			this._remoteStackTraceString = text;
			this._remoteStackIndex = remoteStackIndex3;
			return this;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0001D820 File Offset: 0x0001BA20
		internal static void ReportUnhandledException(Exception exception)
		{
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0001D830 File Offset: 0x0001BA30
		// Note: this type is marked as 'beforefieldinit'.
		static Exception()
		{
		}

		// Token: 0x0400051F RID: 1311
		[OptionalField]
		private static object s_EDILock;

		// Token: 0x04000520 RID: 1312
		private string _className;

		// Token: 0x04000521 RID: 1313
		internal string _message;

		// Token: 0x04000522 RID: 1314
		private IDictionary _data;

		// Token: 0x04000523 RID: 1315
		private Exception _innerException;

		// Token: 0x04000524 RID: 1316
		private string _helpURL;

		// Token: 0x04000525 RID: 1317
		private object _stackTrace;

		// Token: 0x04000526 RID: 1318
		private string _stackTraceString;

		// Token: 0x04000527 RID: 1319
		private string _remoteStackTraceString;

		// Token: 0x04000528 RID: 1320
		private int _remoteStackIndex;

		// Token: 0x04000529 RID: 1321
		private object _dynamicMethods;

		// Token: 0x0400052A RID: 1322
		internal int _HResult;

		// Token: 0x0400052B RID: 1323
		private string _source;

		// Token: 0x0400052C RID: 1324
		[OptionalField(VersionAdded = 4)]
		private SafeSerializationManager _safeSerializationManager;

		// Token: 0x0400052D RID: 1325
		internal StackTrace[] captured_traces;

		// Token: 0x0400052E RID: 1326
		private IntPtr[] native_trace_ips;

		// Token: 0x0400052F RID: 1327
		private int caught_in_unmanaged;

		// Token: 0x04000530 RID: 1328
		private const int _COMPlusExceptionCode = -532462766;

		// Token: 0x02000153 RID: 339
		internal enum ExceptionMessageKind
		{
			// Token: 0x04000532 RID: 1330
			ThreadAbort = 1,
			// Token: 0x04000533 RID: 1331
			ThreadInterrupted,
			// Token: 0x04000534 RID: 1332
			OutOfMemory
		}
	}
}
