using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Terraria.Social.Base;

namespace Terraria.Social.iOS
{
	// Token: 0x02000514 RID: 1300
	public class CloudSocialModule : CloudSocialModule
	{
		// Token: 0x0600315B RID: 12635 RVA: 0x001F8048 File Offset: 0x001F6248
		public override void Initialize()
		{
			base.Initialize();
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x001F805C File Offset: 0x001F625C
		public override void Shutdown()
		{
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x001F806C File Offset: 0x001F626C
		public void SyncFiles(string path)
		{
			string text = this.cacheFolder;
			this.SyncPath = path;
			string text2 = text + path;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x001F8090 File Offset: 0x001F6290
		public bool HasFinishedSync()
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x001F80A0 File Offset: 0x001F62A0
		public bool IsRequired()
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x001F80B0 File Offset: 0x001F62B0
		public bool IsAvailable()
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x001F80C0 File Offset: 0x001F62C0
		public bool IsConnected()
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x001F80D0 File Offset: 0x001F62D0
		public override IEnumerable<string> GetFiles()
		{
			/*
An exception occurred when decompiling this method (06003162)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.String> Terraria.Social.iOS.CloudSocialModule::GetFiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(CloudSocialModule::cacheFolder, ldloc:CloudSocialModule(this)))
	stloc:DirectoryInfo(var_1_0D, call:DirectoryInfo(Directory::CreateDirectory, ldloc:string(var_0_06)))
	stloc:string[](var_2_19, call:string[](Directory::GetFiles, ldloc:string(var_0_06), ldstr:string("*.*")))
	stloc:int32(var_4_27, ldfld:int32(string::_stringLength, ldfld:string(CloudSocialModule::cacheFolder, ldloc:CloudSocialModule(this))))
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

		// Token: 0x06003163 RID: 12643 RVA: 0x001F8108 File Offset: 0x001F6308
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			if (!true)
			{
			}
			Match match;
			Group group;
			if (match != null && group != null)
			{
				Group group2;
				return group2.Value;
			}
			return "";
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x001F812C File Offset: 0x001F632C
		public override bool Write(string path, byte[] data, int length)
		{
			string text = this.cacheFolder + path;
			long num = 0L;
			string parentFolderPath = CloudSocialModule.GetParentFolderPath(text, num != 0L);
			bool flag = parentFolderPath != "";
			DirectoryInfo directoryInfo = Directory.CreateDirectory(parentFolderPath);
			return true;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x001F8168 File Offset: 0x001F6368
		public override void Read(string path, byte[] buffer, int length)
		{
			string text = this.cacheFolder + path;
			string text2 = this.cacheFolder;
			long num = 0L;
			Array.Copy(File.ReadAllBytes(text2 + path), buffer, (int)num);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x001F81A0 File Offset: 0x001F63A0
		public override bool HasFile(string path)
		{
			return File.Exists(this.cacheFolder + path);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x001F81C0 File Offset: 0x001F63C0
		public override int GetFileSize(string path)
		{
			/*
An exception occurred when decompiling this method (06003167)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Social.iOS.CloudSocialModule::GetFileSize(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_11, call:uint8[](File::ReadAllBytes, call:string(string::Concat, ldfld:string(CloudSocialModule::cacheFolder, ldloc:CloudSocialModule(this)), ldloc:string(path))))
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

		// Token: 0x06003168 RID: 12648 RVA: 0x001F81E0 File Offset: 0x001F63E0
		public override bool Delete(string path)
		{
			File.Delete(this.cacheFolder + path);
			return true;
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x001F8200 File Offset: 0x001F6400
		public override bool Forget(string path)
		{
			return true;
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x001F8210 File Offset: 0x001F6410
		public CloudSocialModule()
		{
			if (!true)
			{
			}
			string text = Main.SavePath + "/RemoteCloudCache/";
			this.editorRemoteCache = text;
			string text2 = Main.SavePath + "/CloudCache/";
			this.cacheFolder = text2;
			base..ctor();
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x001F8258 File Offset: 0x001F6458
		// Note: this type is marked as 'beforefieldinit'.
		static CloudSocialModule()
		{
		}

		// Token: 0x04003B18 RID: 15128
		private string editorRemoteCache;

		// Token: 0x04003B19 RID: 15129
		private string cacheFolder;

		// Token: 0x04003B1A RID: 15130
		private static Regex FileNameRegex;

		// Token: 0x04003B1B RID: 15131
		private string SyncPath;

		// Token: 0x04003B1C RID: 15132
		private DateTime SyncStarted;
	}
}
