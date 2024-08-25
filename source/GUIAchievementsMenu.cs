using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Achievements;
using Terraria.Graphics;

// Token: 0x02000256 RID: 598
public class GUIAchievementsMenu
{
	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0003FC38 File Offset: 0x0003DE38
	private GUIContollerTransactionButtonList FilterListOptionsController
	{
		get
		{
			GUIContollerTransactionButtonList filterListOptionsController = this._filterListOptionsController;
			if (filterListOptionsController != null || (filterListOptionsController != null && filterListOptionsController == null) || (filterListOptionsController != null && filterListOptionsController == null) || (filterListOptionsController != null && filterListOptionsController == null) || filterListOptionsController == null || filterListOptionsController != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0003FC6C File Offset: 0x0003DE6C
	public void GotoAchievement(Achievement achievement)
	{
		int id = achievement.Id;
		int size = this.SortedAchievementsData._size;
		int id2 = achievement.Id;
		int size2 = this.SortedAchievementsData._size;
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0003FCBC File Offset: 0x0003DEBC
	private List<Achievement> Achievements
	{
		get
		{
			List<Achievement> list;
			if (this._achievements == null)
			{
				list = Main.Achievements.CreateAchievementsList();
				this._achievements = list;
			}
			return list;
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0003FCE8 File Offset: 0x0003DEE8
	public void Open(int backTo, int selected = -1)
	{
		this._source = backTo;
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0003FD94 File Offset: 0x0003DF94
	private void DrawFilters()
	{
		List<bool> list = this.catButtonsActive;
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
	public void Draw()
	{
		if (this.displayFilters)
		{
			GUIContollerTransactionButtonList filterListOptionsController = this.FilterListOptionsController;
			GUIContollerTransactionButtonList filterListOptionsController2 = this.FilterListOptionsController;
			GUIContollerTransactionButtonList filterListOptionsController3 = this.FilterListOptionsController;
			int num = 3;
			filterListOptionsController3._selectedItem = num;
			return;
		}
		GUIControllerAchievements controllerInput = this._controllerInput;
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x0003FE6C File Offset: 0x0003E06C
	public void Back()
	{
		int source = this._source;
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x000021DB File Offset: 0x000003DB
	private void AchievementDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x000021DB File Offset: 0x000003DB
	private float AchievementScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
	private void AchievementOver(int index)
	{
		this.achievementOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		bool flag = this.allowItemClicking;
		if (!flag)
		{
			if (!flag)
			{
			}
			bool mouseLeftRelease2 = Main.mouseLeftRelease;
			this.allowItemClicking = true;
		}
		if (!true)
		{
		}
		bool mouseLeft2 = Main.mouseLeft;
		DateTime lastTouchTime = this.LastTouchTime;
		if (!true)
		{
		}
		bool flag2 = this.allowItemClicking;
		if (flag2)
		{
			if (!flag2)
			{
			}
			DateTime now = DateTime.Now;
			this.LastTouchTime = now;
			if (!flag2)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			this.LastTouchMouse = flag2;
		}
		if (!flag2)
		{
		}
		bool mouseLeft3 = Main.mouseLeft;
		DateTime lastTouchTime2 = this.LastTouchTime;
		if (!flag2)
		{
		}
		if (!flag2)
		{
		}
		DateTime now2 = DateTime.Now;
		DateTime lastTouchTime3 = this.LastTouchTime;
		double totalMilliseconds = (now2 - lastTouchTime3).TotalMilliseconds;
		float x = this.LastTouchMouse.X;
		float y = this.LastTouchMouse.Y;
		int mouseX2 = Main.mouseX;
		int mouseY2 = Main.mouseY;
		this.SelectedItem = index;
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x0003FFE8 File Offset: 0x0003E1E8
	public static void LoadContent()
	{
		Texture2D texture2D = TextureManager.Load("Images/UI/Achievement_Categories");
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x000021DB File Offset: 0x000003DB
	public void UpdateAchievements()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x000021DB File Offset: 0x000003DB
	public void SortAndFilderAchievements()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00040000 File Offset: 0x0003E200
	private int SortEntry(Achievement a, Achievement b)
	{
		bool isCompleted = a.IsCompleted;
		bool isCompleted2 = b.IsCompleted;
		bool isCompleted3 = a.IsCompleted;
		bool isCompleted4 = b.IsCompleted;
		return 1;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00040040 File Offset: 0x0003E240
	private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		int num2 = 1;
		if (num2 == 0)
		{
		}
		int value = num2.m_value;
		if (!true)
		{
		}
		int num3 = 1;
		if (num3 == 0)
		{
		}
		int value2 = num3.m_value;
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (32768 == 0)
		{
		}
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00040128 File Offset: 0x0003E328
	public GUIAchievementsMenu()
	{
		if (!true)
		{
		}
		this.LastTouchTime = 1;
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.allowItemClicking = true;
		this.LastTouchMouse = 1;
		this._tooltip = "";
		this.achievementOver = "";
		base..ctor();
	}

	// Token: 0x040018B9 RID: 6329
	private GUIControllerAchievements _controllerInput;

	// Token: 0x040018BA RID: 6330
	private GUIContollerTransactionButtonList _filterListOptionsController;

	// Token: 0x040018BB RID: 6331
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x040018BC RID: 6332
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x040018BD RID: 6333
	private DateTime LastTouchTime;

	// Token: 0x040018BE RID: 6334
	private Vector2 LastTouchMouse;

	// Token: 0x040018BF RID: 6335
	private int _source;

	// Token: 0x040018C0 RID: 6336
	private bool allowItemClicking;

	// Token: 0x040018C1 RID: 6337
	private float TitleScale;

	// Token: 0x040018C2 RID: 6338
	private float BackScale;

	// Token: 0x040018C3 RID: 6339
	public float ScrollOffset;

	// Token: 0x040018C4 RID: 6340
	private float ScrollMomentum;

	// Token: 0x040018C5 RID: 6341
	private int ScrollDragging;

	// Token: 0x040018C6 RID: 6342
	private Vector2 DragOffset;

	// Token: 0x040018C7 RID: 6343
	public int SelectedItem;

	// Token: 0x040018C8 RID: 6344
	public int SelectedItemId;

	// Token: 0x040018C9 RID: 6345
	private Vector2 InGameWindowShift;

	// Token: 0x040018CA RID: 6346
	private List<bool> catButtonsActive;

	// Token: 0x040018CB RID: 6347
	private List<Achievement> _achievements;

	// Token: 0x040018CC RID: 6348
	public List<Achievement> SortedAchievementsData;

	// Token: 0x040018CD RID: 6349
	private static Texture2D AchievementsIcons;

	// Token: 0x040018CE RID: 6350
	private static Texture2D AchievementsCategories;

	// Token: 0x040018CF RID: 6351
	private static Texture2D AchievementsIconBorder;

	// Token: 0x040018D0 RID: 6352
	private string _tooltip;

	// Token: 0x040018D1 RID: 6353
	private bool _tooltipShow;

	// Token: 0x040018D2 RID: 6354
	private Vector2 _tooltipLocation;

	// Token: 0x040018D3 RID: 6355
	private DateTime _tooltipTime;

	// Token: 0x040018D4 RID: 6356
	private Vector2 startPoint;

	// Token: 0x040018D5 RID: 6357
	private float[] catScale;

	// Token: 0x040018D6 RID: 6358
	private bool displayFilters;

	// Token: 0x040018D7 RID: 6359
	private float filtersScale;

	// Token: 0x040018D8 RID: 6360
	private int achievementOver;

	// Token: 0x02000257 RID: 599
	public class AchievementFileData
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x00040170 File Offset: 0x0003E370
		public AchievementFileData()
		{
		}

		// Token: 0x040018D9 RID: 6361
		public string Name;
	}
}
