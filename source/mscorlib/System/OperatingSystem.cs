using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	public sealed class OperatingSystem : ISerializable, ICloneable
	{
		// Token: 0x06000BD2 RID: 3026 RVA: 0x0001A4EC File Offset: 0x000186EC
		public OperatingSystem(PlatformID platform, Version version)
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0001A4FC File Offset: 0x000186FC
		internal OperatingSystem(PlatformID platform, Version version, string servicePack)
		{
			do
			{
				base..ctor();
			}
			while (version == null);
			this._platform = platform;
			this._version = version;
			this._servicePack = servicePack;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0000207A File Offset: 0x0000027A
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0001A528 File Offset: 0x00018728
		public PlatformID Platform
		{
			get
			{
				return this._platform;
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0001A53C File Offset: 0x0001873C
		public object Clone()
		{
			/*
An exception occurred when decompiling this method (06000BD6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.OperatingSystem::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PlatformID(var_0_06, ldfld:PlatformID(OperatingSystem::_platform, ldloc:OperatingSystem(this)))
	stloc:Version(var_1_0D, ldfld:Version(OperatingSystem::_version, ldloc:OperatingSystem(this)))
	stloc:string(var_2_14, ldfld:string(OperatingSystem::_servicePack, ldloc:OperatingSystem(this)))
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

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0001A560 File Offset: 0x00018760
		public override string ToString()
		{
			return this.VersionString;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0001A574 File Offset: 0x00018774
		public string VersionString
		{
			get
			{
				string versionString = this._versionString;
				if (versionString == null)
				{
					PlatformID platform = this._platform;
					return versionString;
				}
				string text;
				return text;
			}
		}

		// Token: 0x040004CA RID: 1226
		private readonly Version _version;

		// Token: 0x040004CB RID: 1227
		private readonly PlatformID _platform;

		// Token: 0x040004CC RID: 1228
		private readonly string _servicePack;

		// Token: 0x040004CD RID: 1229
		private string _versionString;
	}
}
