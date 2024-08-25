using System;
using Cpp2IlInjected;

// Token: 0x0200022B RID: 555
public class PageControllerLayoutDefinition<T> : LayoutDefinition where T : PageControllerLayoutDefinition<T>
{
	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000021DB File Offset: 0x000003DB
	public static T Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000021DB File Offset: 0x000003DB
	public bool RightPageController
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0003E7A4 File Offset: 0x0003C9A4
	protected void Awake()
	{
		bool rightPageController = this._rightPageController;
		bool rightPageController2 = this._rightPageController;
		bool rightPageController3 = this._rightPageController;
		if (this != null && this == null)
		{
			throw new InvalidCastException();
		}
		if (this == null || this != null)
		{
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0003E800 File Offset: 0x0003CA00
	public PageControllerLayoutDefinition()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040015F8 RID: 5624
	public static T InstanceNormal;

	// Token: 0x040015F9 RID: 5625
	public static T InstanceConsoleLeft;

	// Token: 0x040015FA RID: 5626
	public static T InstanceConsoleRight;

	// Token: 0x040015FB RID: 5627
	private bool _rightPageController;
}
