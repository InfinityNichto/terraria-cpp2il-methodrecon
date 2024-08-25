using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ionic.Zip;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Content.Sources;
using ReLogic.Utilities;

namespace Terraria.IO
{
	// Token: 0x02000566 RID: 1382
	public class ResourcePack
	{
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00200248 File Offset: 0x001FE448
		public Texture2D Icon
		{
			get
			{
				if (this._icon == null)
				{
				}
				Texture2D texture2D;
				return texture2D;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00200260 File Offset: 0x001FE460
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x00200274 File Offset: 0x001FE474
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x00200288 File Offset: 0x001FE488
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x0020029C File Offset: 0x001FE49C
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.<Description>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x002002B0 File Offset: 0x001FE4B0
		// (set) Token: 0x060033A9 RID: 13225 RVA: 0x002002C4 File Offset: 0x001FE4C4
		public string Author
		{
			[CompilerGenerated]
			get
			{
				return this.<Author>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Author>k__BackingField = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x002002D8 File Offset: 0x001FE4D8
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x002002EC File Offset: 0x001FE4EC
		public ResourcePackVersion Version
		{
			[CompilerGenerated]
			get
			{
				return this.<Version>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x00200300 File Offset: 0x001FE500
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x00200314 File Offset: 0x001FE514
		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEnabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x00200324 File Offset: 0x001FE524
		// (set) Token: 0x060033AF RID: 13231 RVA: 0x00200338 File Offset: 0x001FE538
		public int SortingOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SortingOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SortingOrder>k__BackingField = value;
			}
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0020034C File Offset: 0x001FE54C
		public ResourcePack(IServiceProvider services, string path)
		{
			bool flag = File.Exists(path);
			this._isCompressed = true;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x002003C8 File Offset: 0x001FE5C8
		public void Refresh()
		{
			this._needsReload = true;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x002003DC File Offset: 0x001FE5DC
		public IContentSource GetContentSource()
		{
			if (this._needsReload)
			{
				bool isCompressed = this._isCompressed;
				string fullPath = this.FullPath;
				if (isCompressed)
				{
				}
			}
			return this._contentSource;
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00200408 File Offset: 0x001FE608
		private Texture2D CreateIcon()
		{
			bool flag = this.HasFile("icon.png");
			Stream stream = this.OpenStream("icon.png");
			Texture2D texture2D = this._services.Get<AssetReaderCollection>().Read<Texture2D>(stream, ".png");
			if (stream != null)
			{
			}
			if ("Images/UI/DefaultResourcePackIcon" == null)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x0020047C File Offset: 0x001FE67C
		private void LoadManifest()
		{
			bool flag = this.HasFile("pack.json");
			Stream stream = this.OpenStream("pack.json");
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00200564 File Offset: 0x001FE764
		private Stream OpenStream(string fileName)
		{
			/*
An exception occurred when decompiling this method (060033B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Terraria.IO.ResourcePack::OpenStream(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:FileStream(var_2_20, call:FileStream(File::OpenRead, ldloc:string(var_1)))
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

		// Token: 0x060033B6 RID: 13238 RVA: 0x00200594 File Offset: 0x001FE794
		private bool HasFile(string fileName)
		{
			if (this._isCompressed)
			{
				return this._zipFile.ContainsEntry(fileName);
			}
			return File.Exists(Path.Combine(this.FullPath, fileName));
		}

		// Token: 0x04003C55 RID: 15445
		public readonly string FullPath;

		// Token: 0x04003C56 RID: 15446
		public readonly string FileName;

		// Token: 0x04003C57 RID: 15447
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04003C58 RID: 15448
		[CompilerGenerated]
		private string <Description>k__BackingField;

		// Token: 0x04003C59 RID: 15449
		[CompilerGenerated]
		private string <Author>k__BackingField;

		// Token: 0x04003C5A RID: 15450
		[CompilerGenerated]
		private ResourcePackVersion <Version>k__BackingField;

		// Token: 0x04003C5B RID: 15451
		[CompilerGenerated]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x04003C5C RID: 15452
		[CompilerGenerated]
		private int <SortingOrder>k__BackingField;

		// Token: 0x04003C5D RID: 15453
		private readonly IServiceProvider _services;

		// Token: 0x04003C5E RID: 15454
		private readonly bool _isCompressed;

		// Token: 0x04003C5F RID: 15455
		private readonly ZipFile _zipFile;

		// Token: 0x04003C60 RID: 15456
		private Texture2D _icon;

		// Token: 0x04003C61 RID: 15457
		private IContentSource _contentSource;

		// Token: 0x04003C62 RID: 15458
		private bool _needsReload = true;

		// Token: 0x04003C63 RID: 15459
		private const string ICON_FILE_NAME = "icon.png";

		// Token: 0x04003C64 RID: 15460
		private const string PACK_FILE_NAME = "pack.json";
	}
}
