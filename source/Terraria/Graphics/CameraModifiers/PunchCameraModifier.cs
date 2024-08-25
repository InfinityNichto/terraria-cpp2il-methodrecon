using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x02000772 RID: 1906
	public class PunchCameraModifier : ICameraModifier
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x0023D3D8 File Offset: 0x0023B5D8
		// (set) Token: 0x06003E71 RID: 15985 RVA: 0x0023D3EC File Offset: 0x0023B5EC
		public string UniqueIdentity
		{
			[CompilerGenerated]
			get
			{
				return this.<UniqueIdentity>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UniqueIdentity>k__BackingField = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x0023D400 File Offset: 0x0023B600
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x0023D414 File Offset: 0x0023B614
		public bool Finished
		{
			[CompilerGenerated]
			get
			{
				return this.<Finished>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0023D424 File Offset: 0x0023B624
		public PunchCameraModifier(Vector2 startPosition, Vector2 direction, float strength, float vibrationCyclesPerSecond, int frames, float distanceFalloff = -1f, [Optional] string uniqueIdentity)
		{
			this._framesToLast = startPosition;
			this.UniqueIdentity = direction;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0023D448 File Offset: 0x0023B648
		public void Update(CameraInfo cameraInfo)
		{
			int num = 1;
			int framesLasted = this._framesLasted;
			float vibrationCyclesPerSecond = this._vibrationCyclesPerSecond;
			if (num == 0)
			{
				int framesLasted2 = this._framesLasted;
			}
			int num2 = 17008;
			int framesToLast = this._framesToLast;
			if (num2 == 0)
			{
			}
			float x = this._startPosition.X;
			float y = this._startPosition.Y;
			float x2 = cameraInfo.OriginalCameraCenter.X;
			float y2 = cameraInfo.OriginalCameraCenter.Y;
			if (num2 == 0)
			{
			}
			float distanceFalloff = this._distanceFalloff;
			float y3 = this._direction.Y;
			float distanceFalloff2 = this._distanceFalloff;
			Vector2 cameraPosition = cameraInfo.CameraPosition;
			float x3 = this._direction.X;
			if (num2 == 0)
			{
			}
			float strength = this._strength;
			int framesLasted3 = this._framesLasted;
			int framesToLast2 = this._framesToLast;
			this._framesLasted = framesLasted3;
			int num3 = 1;
			this.<Finished>k__BackingField = num3 != 0;
		}

		// Token: 0x04007D24 RID: 32036
		private int _framesToLast;

		// Token: 0x04007D25 RID: 32037
		private Vector2 _startPosition;

		// Token: 0x04007D26 RID: 32038
		private Vector2 _direction;

		// Token: 0x04007D27 RID: 32039
		private float _distanceFalloff;

		// Token: 0x04007D28 RID: 32040
		private float _strength;

		// Token: 0x04007D29 RID: 32041
		private float _vibrationCyclesPerSecond;

		// Token: 0x04007D2A RID: 32042
		private int _framesLasted;

		// Token: 0x04007D2B RID: 32043
		[CompilerGenerated]
		private string <UniqueIdentity>k__BackingField;

		// Token: 0x04007D2C RID: 32044
		[CompilerGenerated]
		private bool <Finished>k__BackingField;
	}
}
