using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameInput;

// Token: 0x020002D4 RID: 724
public class LockOnHelperStaticData
{
	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060010B2 RID: 4274 RVA: 0x000021DB File Offset: 0x000003DB
	public static LockOnHelperStaticData Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00051F40 File Offset: 0x00050140
	public LockOnHelperStaticData()
	{
		int num = 2;
		this.UseMode = (LockOnHelper.LockOnMode)num;
		int num2 = 1;
		this.LockOnAvailable = num2 != 0;
		base..ctor();
	}

	// Token: 0x04001FA1 RID: 8097
	public LockOnHelper.LockOnMode UseMode;

	// Token: 0x04001FA2 RID: 8098
	public bool _enabled;

	// Token: 0x04001FA3 RID: 8099
	public bool _canLockOn;

	// Token: 0x04001FA4 RID: 8100
	public List<int> _targets;

	// Token: 0x04001FA5 RID: 8101
	public int _pickedTarget;

	// Token: 0x04001FA6 RID: 8102
	public int _lifeTimeCounter;

	// Token: 0x04001FA7 RID: 8103
	public int _lifeTimeArrowDisplay;

	// Token: 0x04001FA8 RID: 8104
	public int _threeDSTarget;

	// Token: 0x04001FA9 RID: 8105
	public int _targetClosestTarget;

	// Token: 0x04001FAA RID: 8106
	public bool ForceUsability;

	// Token: 0x04001FAB RID: 8107
	public bool LockOnAvailable;

	// Token: 0x04001FAC RID: 8108
	public int _lastFrame;

	// Token: 0x04001FAD RID: 8109
	public float[,] _drawProgress;
}
