using System;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x02000022 RID: 34
	public struct InputControlState
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00004B00 File Offset: 0x00002D00
		public void Reset()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00004B10 File Offset: 0x00002D10
		public void Set(float value)
		{
			if (!true)
			{
			}
			bool flag = Utility.IsNotZero(value);
			this.State = true;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00004B30 File Offset: 0x00002D30
		public void Set(float value, float threshold)
		{
			if (!true)
			{
			}
			bool flag = Utility.AbsoluteIsOverThreshold(value, threshold);
			this.State = true;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00004B54 File Offset: 0x00002D54
		public void Set(bool state)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000025E1 File Offset: 0x000007E1
		public static implicit operator bool(InputControlState state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000025E1 File Offset: 0x000007E1
		public static implicit operator float(InputControlState state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004B64 File Offset: 0x00002D64
		public static bool operator ==(InputControlState a, InputControlState b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004B78 File Offset: 0x00002D78
		public static bool operator !=(InputControlState a, InputControlState b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x04000141 RID: 321
		public bool State;

		// Token: 0x04000142 RID: 322
		public float Value;

		// Token: 0x04000143 RID: 323
		public float RawValue;
	}
}
