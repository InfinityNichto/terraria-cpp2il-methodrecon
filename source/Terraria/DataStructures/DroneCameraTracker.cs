using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000623 RID: 1571
	public class DroneCameraTracker
	{
		// Token: 0x060035E8 RID: 13800 RVA: 0x00211E1C File Offset: 0x0021001C
		public void Track(Projectile proj)
		{
			this._trackedProjectile = proj;
			int type = proj.type;
			this._lastTrackedType = type;
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00211E40 File Offset: 0x00210040
		public void Clear()
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00211E50 File Offset: 0x00210050
		public void WorldClear()
		{
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00211E60 File Offset: 0x00210060
		private void ValidateTrackedProjectile()
		{
			Projectile trackedProjectile = this._trackedProjectile;
			if (trackedProjectile != null && trackedProjectile.active)
			{
				int type = trackedProjectile.type;
				int lastTrackedType = this._lastTrackedType;
				int owner = trackedProjectile.owner;
				if (type == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (trackedProjectile == null)
				{
				}
				if (!Main.LocalPlayer.remoteVisionForDrone)
				{
				}
			}
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00211EB4 File Offset: 0x002100B4
		public bool IsInUse()
		{
			return this._inUse;
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00211EC8 File Offset: 0x002100C8
		public bool TryTracking([Out] Vector2 cameraPosition)
		{
			this.ValidateTrackedProjectile();
			Projectile trackedProjectile = this._trackedProjectile;
			if (trackedProjectile != null)
			{
				Vector2 center = trackedProjectile.Center;
			}
			this._inUse = true;
			return true;
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00211EF4 File Offset: 0x002100F4
		public DroneCameraTracker()
		{
		}

		// Token: 0x040076C0 RID: 30400
		private Projectile _trackedProjectile;

		// Token: 0x040076C1 RID: 30401
		private int _lastTrackedType;

		// Token: 0x040076C2 RID: 30402
		private bool _inUse;
	}
}
