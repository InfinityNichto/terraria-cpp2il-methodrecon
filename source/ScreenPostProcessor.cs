using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using UnityEngine;

// Token: 0x02000305 RID: 773
public class ScreenPostProcessor : MonoBehaviour
{
	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x060011EB RID: 4587 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x060011EC RID: 4588 RVA: 0x000578A4 File Offset: 0x00055AA4
	public static bool Enabled
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x060011ED RID: 4589 RVA: 0x000021DB File Offset: 0x000003DB
	public static List<ScreenPostProcessor> Instances
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x060011EE RID: 4590 RVA: 0x000021DB File Offset: 0x000003DB
	public static List<ScreenPostProcessor> UIInstances
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x060011EF RID: 4591 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x060011F0 RID: 4592 RVA: 0x000578B4 File Offset: 0x00055AB4
	public static List<Filter> Filters
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x000021DB File Offset: 0x000003DB
	public static void BeginUpdate()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x000021DB File Offset: 0x000003DB
	public static void AddFilter(Filter filter)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x000578C4 File Offset: 0x00055AC4
	public static void EndUpdate()
	{
		int num = 1;
		if (num == 0)
		{
		}
		ScreenPostProcessor.renderCheck = 0;
		if (num == 0)
		{
		}
		bool gameMenu = Main.gameMenu;
		List<ScreenPostProcessor> uiinstances = ScreenPostProcessor.UIInstances;
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0005795C File Offset: 0x00055B5C
	private static int countUpdate
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0005796C File Offset: 0x00055B6C
	private static int renderCheck
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x0005797C File Offset: 0x00055B7C
	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
		LocalUser user = this.User;
		if (user != null)
		{
			user.LoadThreadstate();
			LocalUser user2 = this.User;
			if (user2 != null)
			{
				LocalUserGameState gameState = user2.GameState;
				if (gameState != null)
				{
					int screenPostProcessor_renderCheck = gameState.ScreenPostProcessor_renderCheck;
					int size = ScreenPostProcessor.Filters._size;
					List<Filter> screenPostProcessor_Filters = this.User.GameState.ScreenPostProcessor_Filters;
					int renderCheck = ScreenPostProcessor.renderCheck;
					LocalUserGameState gameState2 = this.User.GameState;
					int screenPostProcessor_renderCheck2 = gameState2.ScreenPostProcessor_renderCheck;
					gameState2.ScreenPostProcessor_renderCheck = screenPostProcessor_renderCheck2;
					if (gameState2 == null)
					{
					}
					GraphicsDevice graphicsDevice;
					object <Tag>k__BackingField = graphicsDevice.Textures.<Tag>k__BackingField;
					GraphicsDevice graphicsDevice2;
					SurfaceFormat format = graphicsDevice2.Textures._format;
					GraphicsDevice graphicsDevice3;
					int sortingKey = graphicsDevice3.Textures._sortingKey;
					if (<Tag>k__BackingField != null)
					{
						return;
					}
					if (1073741824 == 0)
					{
					}
					if (format != SurfaceFormat.Color)
					{
						return;
					}
					if (1073741824 == 0)
					{
					}
					if (sortingKey != 0)
					{
						return;
					}
					if (1073741824 == 0)
					{
					}
					if (<Tag>k__BackingField != null)
					{
						return;
					}
					if (1073741824 == 0)
					{
					}
					return;
				}
			}
		}
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00057A60 File Offset: 0x00055C60
	public ScreenPostProcessor()
	{
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00057A74 File Offset: 0x00055C74
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenPostProcessor()
	{
		int num = Shader.PropertyToID("_MainTex");
		int num2 = Shader.PropertyToID("_SecondaryTex");
		int num3 = Shader.PropertyToID("_ThirdTex");
		int num4 = Shader.PropertyToID("_ForthTex");
		int num5 = Shader.PropertyToID("_ImageSize1");
	}

	// Token: 0x04002170 RID: 8560
	private int order;

	// Token: 0x04002171 RID: 8561
	private Filter filter;

	// Token: 0x04002172 RID: 8562
	private bool setActive;

	// Token: 0x04002173 RID: 8563
	public LocalUser User;

	// Token: 0x04002174 RID: 8564
	private static int MainTexId;

	// Token: 0x04002175 RID: 8565
	private static int SecTexId;

	// Token: 0x04002176 RID: 8566
	private static int ThirdTexId;

	// Token: 0x04002177 RID: 8567
	private static int ForthTexId;

	// Token: 0x04002178 RID: 8568
	private static int _imageSize1Id;
}
