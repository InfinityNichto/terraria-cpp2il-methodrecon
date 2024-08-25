using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.U2D
{
	// Token: 0x020000ED RID: 237
	[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	public class SpriteAtlasManager
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x000092EC File Offset: 0x000074EC
		[RequiredByNativeCode]
		private static bool RequestAtlas(string tag)
		{
			return true;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000515 RID: 1301 RVA: 0x000092FC File Offset: 0x000074FC
		// (remove) Token: 0x06000516 RID: 1302 RVA: 0x00009318 File Offset: 0x00007518
		public static event Action<SpriteAtlas> atlasRegistered
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00009334 File Offset: 0x00007534
		[RequiredByNativeCode]
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00009344 File Offset: 0x00007544
		internal static void Register(SpriteAtlas spriteAtlas)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string, Action<SpriteAtlas>> atlasRequested;

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<SpriteAtlas> atlasRegistered;
	}
}
