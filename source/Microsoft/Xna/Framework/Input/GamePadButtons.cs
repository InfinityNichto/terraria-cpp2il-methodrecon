using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000342 RID: 834
	public struct GamePadButtons
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState A
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState B
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState Back
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState X
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState Y
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState Start
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState LeftShoulder
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState LeftStick
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState RightShoulder
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState RightStick
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x000021DB File Offset: 0x000003DB
		public ButtonState BigButton
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0005F900 File Offset: 0x0005DB00
		public GamePadButtons(Buttons buttons)
		{
			this._buttons = buttons;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0005F914 File Offset: 0x0005DB14
		internal GamePadButtons(params Buttons[] buttons)
		{
			long num = 0L;
			this._buttons = (Buttons)num;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(GamePadButtons left, GamePadButtons right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(GamePadButtons left, GamePadButtons right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0005F92C File Offset: 0x0005DB2C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000021DB File Offset: 0x000003DB
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0005F940 File Offset: 0x0005DB40
		public override string ToString()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			string text7;
			string text8;
			string text9;
			string text10;
			string text11;
			if (("[GamePadButtons: A=" == null || "[GamePadButtons: A=" != null) && (text == null || text != null) && (", B=" == null || ", B=" != null) && (text2 == null || text2 != null) && (", Back=" == null || ", Back=" != null) && (text3 == null || text3 != null) && (", X=" == null || ", X=" != null) && (text4 == null || text4 != null) && (", Y=" == null || ", Y=" != null) && (text5 == null || text5 != null) && (", Start=" == null || ", Start=" != null) && (text6 == null || text6 != null) && (", LeftShoulder=" == null || ", LeftShoulder=" != null) && (text7 == null || text7 != null) && (", LeftStick=" == null || ", LeftStick=" != null) && (text8 == null || text8 != null) && (", RightShoulder=" == null || ", RightShoulder=" != null) && (text9 == null || text9 != null) && (", RightStick=" == null || ", RightStick=" != null) && (text10 == null || text10 != null) && (", BigButton=" == null || ", BigButton=" != null) && (text11 == null || text11 != null) && ("]" == null || "]" != null))
			{
				string text12;
				return text12;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040022E2 RID: 8930
		internal readonly Buttons _buttons;
	}
}
