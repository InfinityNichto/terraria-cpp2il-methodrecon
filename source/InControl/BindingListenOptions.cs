using System;

namespace InControl
{
	// Token: 0x02000002 RID: 2
	public class BindingListenOptions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource)
		{
			if (this.OnBindingFound != null)
			{
			}
			return true;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource)
		{
			if (this.OnBindingAdded != null)
			{
				return;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		public void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType)
		{
			if (this.OnBindingRejected != null)
			{
				return;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		public void CallOnBindingEnded(PlayerAction playerAction)
		{
			if (this.OnBindingEnded != null)
			{
				return;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000002B0
		public BindingListenOptions()
		{
		}

		// Token: 0x04000001 RID: 1
		public bool IncludeControllers = true;

		// Token: 0x04000002 RID: 2
		public bool IncludeUnknownControllers;

		// Token: 0x04000003 RID: 3
		public bool IncludeNonStandardControls = true;

		// Token: 0x04000004 RID: 4
		public bool IncludeMouseButtons;

		// Token: 0x04000005 RID: 5
		public bool IncludeMouseScrollWheel;

		// Token: 0x04000006 RID: 6
		public bool IncludeKeys = true;

		// Token: 0x04000007 RID: 7
		public bool IncludeModifiersAsFirstClassKeys;

		// Token: 0x04000008 RID: 8
		public uint MaxAllowedBindings;

		// Token: 0x04000009 RID: 9
		public uint MaxAllowedBindingsPerType;

		// Token: 0x0400000A RID: 10
		public bool AllowDuplicateBindingsPerSet;

		// Token: 0x0400000B RID: 11
		public bool UnsetDuplicateBindingsOnSet;

		// Token: 0x0400000C RID: 12
		public bool RejectRedundantBindings;

		// Token: 0x0400000D RID: 13
		public BindingSource ReplaceBinding;

		// Token: 0x0400000E RID: 14
		public Func<PlayerAction, BindingSource, bool> OnBindingFound;

		// Token: 0x0400000F RID: 15
		public Action<PlayerAction, BindingSource> OnBindingAdded;

		// Token: 0x04000010 RID: 16
		public Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected;

		// Token: 0x04000011 RID: 17
		public Action<PlayerAction> OnBindingEnded;
	}
}
