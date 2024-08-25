using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000347 RID: 839
	public struct GamePadThumbSticks
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00060890 File Offset: 0x0005EA90
		public Vector2 Left
		{
			get
			{
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x000608A0 File Offset: 0x0005EAA0
		public Vector2 Right
		{
			get
			{
				float x = this._right.X;
				float y = this._right.Y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000608C8 File Offset: 0x0005EAC8
		public GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000608D8 File Offset: 0x0005EAD8
		internal GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00060908 File Offset: 0x0005EB08
		private Vector2 ApplyDeadZone(GamePadDeadZone deadZoneMode, float deadZone, Vector2 thumbstickPosition)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00060930 File Offset: 0x0005EB30
		private Vector2 ExcludeIndependentAxesDeadZone(Vector2 value, float deadZone)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000021DB File Offset: 0x000003DB
		private float ExcludeAxisDeadZone(float value, float deadZone)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00060944 File Offset: 0x0005EB44
		private Vector2 ExcludeCircularDeadZone(Vector2 value, float deadZone)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00060960 File Offset: 0x0005EB60
		public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			float x = left._left.X;
			float y = left._left.Y;
			if (!true)
			{
			}
			float x2 = left._right.X;
			float y2 = left._right.Y;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000609B0 File Offset: 0x0005EBB0
		public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			float y = left._right.Y;
			bool flag;
			return flag;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000609CC File Offset: 0x0005EBCC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			float y = this._right.Y;
			bool flag;
			return flag;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000609EC File Offset: 0x0005EBEC
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000609FC File Offset: 0x0005EBFC
		public override string ToString()
		{
			string text;
			string text2;
			if (("[GamePadThumbSticks: Left=" == null || "[GamePadThumbSticks: Left=" != null) && (text == null || text != null) && (", Right=" == null || ", Right=" != null) && (text2 == null || text2 != null) && ("]" == null || "]" != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400230E RID: 8974
		private const float leftThumbDeadZone = 0.24f;

		// Token: 0x0400230F RID: 8975
		private const float rightThumbDeadZone = 0.265f;

		// Token: 0x04002310 RID: 8976
		internal readonly Buttons _virtualButtons;

		// Token: 0x04002311 RID: 8977
		private readonly Vector2 _left;

		// Token: 0x04002312 RID: 8978
		private readonly Vector2 _right;
	}
}
