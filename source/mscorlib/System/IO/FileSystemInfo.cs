using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000551 RID: 1361
	[Serializable]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		// Token: 0x0600288E RID: 10382 RVA: 0x00058200 File Offset: 0x00056400
		protected FileSystemInfo()
		{
			if (this != null)
			{
				return;
			}
			long num = 0L;
			this._fileStatus.<InitiallyDirectory>k__BackingField = num != 0L;
			this._fileStatus._fileStatusInitialized = (int)num;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00058234 File Offset: 0x00056434
		internal void Invalidate()
		{
		}

		// Token: 0x170005D1 RID: 1489
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x00058244 File Offset: 0x00056444
		public FileAttributes Attributes
		{
			set
			{
				string fullPath = this.FullPath;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x00058258 File Offset: 0x00056458
		internal bool ExistsCore
		{
			get
			{
				string fullPath = this.FullPath;
				if (fullPath != null)
				{
					char rawStringData = fullPath.GetRawStringData();
					int stringLength = fullPath._stringLength;
					while (fullPath != null)
					{
					}
				}
				int fileStatusInitialized = this._fileStatus._fileStatusInitialized;
				if (this._fileStatus._exists)
				{
					bool <InitiallyDirectory>k__BackingField = this._fileStatus.<InitiallyDirectory>k__BackingField;
					bool isDirectory = this._fileStatus._isDirectory;
					return;
				}
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000582B8 File Offset: 0x000564B8
		internal DateTimeOffset CreationTimeCore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002892)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystemInfo::get_CreationTimeCore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	brtrue(IL_001A, ldloc:string[exp:bool](var_0_06))
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

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000582E4 File Offset: 0x000564E4
		internal DateTimeOffset LastAccessTimeCore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002893)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystemInfo::get_LastAccessTimeCore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	brtrue(IL_001A, ldloc:string[exp:bool](var_0_06))
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

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x00058310 File Offset: 0x00056510
		internal DateTimeOffset LastWriteTimeCore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002894)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystemInfo::get_LastWriteTimeCore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	brtrue(IL_001A, ldloc:string[exp:bool](var_0_06))
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

		// Token: 0x06002895 RID: 10389 RVA: 0x0005833C File Offset: 0x0005653C
		internal static void ThrowNotFound(string path)
		{
			/*
An exception occurred when decompiling this method (06002895)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.FileSystemInfo::ThrowNotFound(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_10, call:bool(Directory::Exists, call:string(Path::GetDirectoryName, call:string(PathInternal::TrimEndingDirectorySeparator, ldloc:string(path)))))
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

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0005835C File Offset: 0x0005655C
		internal string NormalizedPath
		{
			get
			{
				return this.FullPath;
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00058370 File Offset: 0x00056570
		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
			do
			{
				base..ctor();
			}
			while (info == null);
			string fullPathInternal = Path.GetFullPathInternal(info.GetString("FullPath"));
			this.FullPath = fullPathInternal;
			string @string = info.GetString("OriginalPath");
			this.OriginalPath = @string;
			string string2 = info.GetString("Name");
			this._name = string2;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000583C4 File Offset: 0x000565C4
		[ComVisible(false)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			string originalPath = this.OriginalPath;
			if (!true)
			{
			}
			Type type;
			info.AddValue("OriginalPath", originalPath, type);
			string fullPath = this.FullPath;
			Type type2;
			info.AddValue("FullPath", fullPath, type2);
			Type type3;
			info.AddValue("Name", this, type3);
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0005840C File Offset: 0x0005660C
		public virtual string FullName
		{
			get
			{
				return this.FullPath;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x00058420 File Offset: 0x00056620
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x00058434 File Offset: 0x00056634
		public virtual bool Exists
		{
			get
			{
				return this.ExistsCore;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x0005844C File Offset: 0x0005664C
		public DateTime CreationTime
		{
			get
			{
				DateTime dateTime = this.CreationTimeCore.UtcDateTime.ToLocalTime();
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0005846C File Offset: 0x0005666C
		public DateTime CreationTimeUtc
		{
			get
			{
				DateTime utcDateTime = this.CreationTimeCore.UtcDateTime;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x00058488 File Offset: 0x00056688
		public DateTime LastAccessTime
		{
			get
			{
				DateTime dateTime = this.LastAccessTimeCore.UtcDateTime.ToLocalTime();
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000584A8 File Offset: 0x000566A8
		public DateTime LastAccessTimeUtc
		{
			get
			{
				DateTime utcDateTime = this.LastAccessTimeCore.UtcDateTime;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000584C4 File Offset: 0x000566C4
		public DateTime LastWriteTime
		{
			get
			{
				DateTime dateTime = this.LastWriteTimeCore.UtcDateTime.ToLocalTime();
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000584E4 File Offset: 0x000566E4
		public DateTime LastWriteTimeUtc
		{
			get
			{
				DateTime utcDateTime = this.LastWriteTimeCore.UtcDateTime;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00058500 File Offset: 0x00056700
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060028A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.FileSystemInfo::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:string[exp:bool](FileSystemInfo::OriginalPath, ldloc:FileSystemInfo(this)))
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

		// Token: 0x040015CF RID: 5583
		private FileStatus _fileStatus;

		// Token: 0x040015D0 RID: 5584
		protected string FullPath;

		// Token: 0x040015D1 RID: 5585
		protected string OriginalPath;

		// Token: 0x040015D2 RID: 5586
		internal string _name;
	}
}
