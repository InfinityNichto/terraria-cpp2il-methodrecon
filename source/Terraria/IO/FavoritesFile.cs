using System;
using System.Collections.Generic;
using System.Text;

namespace Terraria.IO
{
	// Token: 0x0200055D RID: 1373
	public class FavoritesFile
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x001FF428 File Offset: 0x001FD628
		public FavoritesFile(string path, bool isCloud)
		{
			this.Path = path;
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x001FF444 File Offset: 0x001FD644
		public void SaveFavorite(FileData fileData)
		{
			Dictionary<string, Dictionary<string, bool>> data = this._data;
			string type = fileData.Type;
			Dictionary<string, Dictionary<string, bool>> data2 = this._data;
			string type2 = fileData.Type;
			Dictionary<string, Dictionary<string, bool>> data3 = this._data;
			string type3 = fileData.Type;
			string fileName = fileData.GetFileName(true);
			bool isFavorite = fileData._isFavorite;
			this.Save();
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x001FF494 File Offset: 0x001FD694
		public void ClearEntry(FileData fileData)
		{
			Dictionary<string, Dictionary<string, bool>> data = this._data;
			string type = fileData.Type;
			Dictionary<string, Dictionary<string, bool>> data2 = this._data;
			string type2 = fileData.Type;
			string fileName = fileData.GetFileName(true);
			this.Save();
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x001FF4D0 File Offset: 0x001FD6D0
		public bool IsFavorite(FileData fileData)
		{
			/*
An exception occurred when decompiling this method (06003363)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.FavoritesFile::IsFavorite(Terraria.IO.FileData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.Dictionary`2<string, bool>>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.Dictionary`2<string, bool>>(FavoritesFile::_data, ldloc:FavoritesFile(this)))
	stloc:string(var_1_0D, ldfld:string(FileData::Type, ldloc:FileData(fileData)))
	stloc:string(var_2_15, call:string(FileData::GetFileName, ldloc:FileData(fileData), ldc.i4:bool(1)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.Dictionary`2<string, bool>>(var_3_1C, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class [mscorlib]System.Collections.Generic.Dictionary`2<string, bool>>(FavoritesFile::_data, ldloc:FavoritesFile(this)))
	stloc:string(var_4_23, ldfld:string(FileData::Type, ldloc:FileData(fileData)))
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

		// Token: 0x06003364 RID: 13156 RVA: 0x001FF504 File Offset: 0x001FD704
		public void Save()
		{
			int num = 1;
			Dictionary<string, Dictionary<string, bool>> data = this._data;
			if (num == 0)
			{
			}
			Encoding utf = Encoding.UTF8;
			string path = this.Path;
			bool isCloudSave = this.IsCloudSave;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x001FF544 File Offset: 0x001FD744
		public void Load()
		{
			int num = 1;
			string path = this.Path;
			bool isCloudSave = this.IsCloudSave;
			if (num == 0)
			{
			}
			string path2 = this.Path;
			bool isCloudSave2 = this.IsCloudSave;
			if (num == 0)
			{
			}
			Encoding utf = Encoding.UTF8;
			this._data = utf;
			if (utf == null)
			{
			}
		}

		// Token: 0x04003C32 RID: 15410
		public readonly string Path;

		// Token: 0x04003C33 RID: 15411
		public readonly bool IsCloudSave;

		// Token: 0x04003C34 RID: 15412
		private Dictionary<string, Dictionary<string, bool>> _data;
	}
}
