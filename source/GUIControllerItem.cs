using System;
using Microsoft.Xna.Framework;

// Token: 0x02000093 RID: 147
public interface GUIControllerItem
{
	// Token: 0x0600038B RID: 907
	void Activate();

	// Token: 0x0600038C RID: 908
	GUIControllerItem Navigate(Vector2 navigationVector);

	// Token: 0x0600038D RID: 909
	Rectangle GetSelectedItemRegion();

	// Token: 0x0600038E RID: 910
	int GetNavigationOutDirs();
}
