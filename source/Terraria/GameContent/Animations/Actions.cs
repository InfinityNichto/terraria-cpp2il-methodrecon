using System;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000972 RID: 2418
	public class Actions
	{
		// Token: 0x06004847 RID: 18503 RVA: 0x0026038C File Offset: 0x0025E58C
		public Actions()
		{
		}

		// Token: 0x02000973 RID: 2419
		public class Players
		{
			// Token: 0x06004848 RID: 18504 RVA: 0x002603A0 File Offset: 0x0025E5A0
			public Players()
			{
			}

			// Token: 0x02000974 RID: 2420
			public interface IPlayerAction : IAnimationSegmentAction<Player>
			{
			}

			// Token: 0x02000975 RID: 2421
			public class Fade : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x06004849 RID: 18505 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(float opacityTarget)
				{
				}

				// Token: 0x0600484A RID: 18506 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(float opacityTarget, int duration)
				{
				}

				// Token: 0x0600484B RID: 18507 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Player obj)
				{
				}

				// Token: 0x1700082F RID: 2095
				// (get) Token: 0x0600484C RID: 18508 RVA: 0x002603B4 File Offset: 0x0025E5B4
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600484D RID: 18509 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x0600484E RID: 18510 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x040083BC RID: 33724
				private int _duration;

				// Token: 0x040083BD RID: 33725
				private float _opacityTarget;

				// Token: 0x040083BE RID: 33726
				private float _delay;
			}

			// Token: 0x02000976 RID: 2422
			public class Wait : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x0600484F RID: 18511 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x06004850 RID: 18512 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000830 RID: 2096
				// (get) Token: 0x06004851 RID: 18513 RVA: 0x002603CC File Offset: 0x0025E5CC
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004852 RID: 18514 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x06004853 RID: 18515 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083BF RID: 33727
				private int _duration;

				// Token: 0x040083C0 RID: 33728
				private float _delay;
			}

			// Token: 0x02000977 RID: 2423
			public class LookAt : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x06004854 RID: 18516 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public LookAt(int direction)
				{
				}

				// Token: 0x06004855 RID: 18517 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000831 RID: 2097
				// (get) Token: 0x06004856 RID: 18518 RVA: 0x002603E4 File Offset: 0x0025E5E4
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004857 RID: 18519 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x06004858 RID: 18520 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083C1 RID: 33729
				private int _direction;

				// Token: 0x040083C2 RID: 33730
				private float _delay;
			}

			// Token: 0x02000978 RID: 2424
			public class MoveWithAcceleration : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x06004859 RID: 18521 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
				}

				// Token: 0x0600485A RID: 18522 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000832 RID: 2098
				// (get) Token: 0x0600485B RID: 18523 RVA: 0x002603FC File Offset: 0x0025E5FC
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600485C RID: 18524 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x0600485D RID: 18525 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x040083C3 RID: 33731
				private Vector2 _offsetPerFrame;

				// Token: 0x040083C4 RID: 33732
				private Vector2 _accelerationPerFrame;

				// Token: 0x040083C5 RID: 33733
				private int _duration;

				// Token: 0x040083C6 RID: 33734
				private float _delay;
			}
		}

		// Token: 0x02000979 RID: 2425
		public class NPCs
		{
			// Token: 0x0600485E RID: 18526 RVA: 0x00260414 File Offset: 0x0025E614
			public NPCs()
			{
			}

			// Token: 0x0200097A RID: 2426
			public interface INPCAction : IAnimationSegmentAction<NPC>
			{
			}

			// Token: 0x0200097B RID: 2427
			public class Fade : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600485F RID: 18527 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(int alphaPerFrame)
				{
				}

				// Token: 0x06004860 RID: 18528 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(int alphaPerFrame, int duration)
				{
				}

				// Token: 0x06004861 RID: 18529 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000833 RID: 2099
				// (get) Token: 0x06004862 RID: 18530 RVA: 0x00260428 File Offset: 0x0025E628
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004863 RID: 18531 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06004864 RID: 18532 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083C7 RID: 33735
				private int _duration;

				// Token: 0x040083C8 RID: 33736
				private int _alphaPerFrame;

				// Token: 0x040083C9 RID: 33737
				private float _delay;
			}

			// Token: 0x0200097C RID: 2428
			public class ShowItem : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004865 RID: 18533 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public ShowItem(int durationInFrames, int itemIdToShow)
				{
				}

				// Token: 0x06004866 RID: 18534 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000834 RID: 2100
				// (get) Token: 0x06004867 RID: 18535 RVA: 0x00260440 File Offset: 0x0025E640
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004868 RID: 18536 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06004869 RID: 18537 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x0600486A RID: 18538 RVA: 0x00003BB6 File Offset: 0x00001DB6
				private void FixNPCIfWasHoldingItem(NPC obj)
				{
				}

				// Token: 0x040083CA RID: 33738
				private int _itemIdToShow;

				// Token: 0x040083CB RID: 33739
				private int _duration;

				// Token: 0x040083CC RID: 33740
				private float _delay;
			}

			// Token: 0x0200097D RID: 2429
			public class Move : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600486B RID: 18539 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Move(Vector2 offsetPerFrame, int durationInFrames)
				{
				}

				// Token: 0x0600486C RID: 18540 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000835 RID: 2101
				// (get) Token: 0x0600486D RID: 18541 RVA: 0x00260458 File Offset: 0x0025E658
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600486E RID: 18542 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x0600486F RID: 18543 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083CD RID: 33741
				private Vector2 _offsetPerFrame;

				// Token: 0x040083CE RID: 33742
				private int _duration;

				// Token: 0x040083CF RID: 33743
				private float _delay;
			}

			// Token: 0x0200097E RID: 2430
			public class MoveWithAcceleration : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004870 RID: 18544 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
				}

				// Token: 0x06004871 RID: 18545 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000836 RID: 2102
				// (get) Token: 0x06004872 RID: 18546 RVA: 0x00260470 File Offset: 0x0025E670
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004873 RID: 18547 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06004874 RID: 18548 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083D0 RID: 33744
				private Vector2 _offsetPerFrame;

				// Token: 0x040083D1 RID: 33745
				private Vector2 _accelerationPerFrame;

				// Token: 0x040083D2 RID: 33746
				private int _duration;

				// Token: 0x040083D3 RID: 33747
				private float _delay;
			}

			// Token: 0x0200097F RID: 2431
			public class MoveWithRotor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004875 RID: 18549 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public MoveWithRotor(Vector2 radialOffset, float rotationPerFrame, Vector2 resultMultiplier, int durationInFrames)
				{
				}

				// Token: 0x06004876 RID: 18550 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000837 RID: 2103
				// (get) Token: 0x06004877 RID: 18551 RVA: 0x00260488 File Offset: 0x0025E688
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004878 RID: 18552 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06004879 RID: 18553 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083D4 RID: 33748
				private Vector2 _offsetPerFrame;

				// Token: 0x040083D5 RID: 33749
				private Vector2 _resultMultiplier;

				// Token: 0x040083D6 RID: 33750
				private float _radialOffset;

				// Token: 0x040083D7 RID: 33751
				private int _duration;

				// Token: 0x040083D8 RID: 33752
				private float _delay;
			}

			// Token: 0x02000980 RID: 2432
			public class DoBunnyRestAnimation : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600487A RID: 18554 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public DoBunnyRestAnimation(int durationInFrames)
				{
				}

				// Token: 0x0600487B RID: 18555 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000838 RID: 2104
				// (get) Token: 0x0600487C RID: 18556 RVA: 0x002604A0 File Offset: 0x0025E6A0
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600487D RID: 18557 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x0600487E RID: 18558 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083D9 RID: 33753
				private int _duration;

				// Token: 0x040083DA RID: 33754
				private float _delay;
			}

			// Token: 0x02000981 RID: 2433
			public class Wait : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600487F RID: 18559 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x06004880 RID: 18560 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000839 RID: 2105
				// (get) Token: 0x06004881 RID: 18561 RVA: 0x002604B8 File Offset: 0x0025E6B8
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004882 RID: 18562 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06004883 RID: 18563 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083DB RID: 33755
				private int _duration;

				// Token: 0x040083DC RID: 33756
				private float _delay;
			}

			// Token: 0x02000982 RID: 2434
			public class Blink : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004884 RID: 18564 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Blink(int durationInFrames)
				{
				}

				// Token: 0x06004885 RID: 18565 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083A RID: 2106
				// (get) Token: 0x06004886 RID: 18566 RVA: 0x002604D0 File Offset: 0x0025E6D0
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004887 RID: 18567 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06004888 RID: 18568 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083DD RID: 33757
				private int _duration;

				// Token: 0x040083DE RID: 33758
				private float _delay;
			}

			// Token: 0x02000983 RID: 2435
			public class LookAt : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004889 RID: 18569 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public LookAt(int direction)
				{
				}

				// Token: 0x0600488A RID: 18570 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083B RID: 2107
				// (get) Token: 0x0600488B RID: 18571 RVA: 0x002604E8 File Offset: 0x0025E6E8
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600488C RID: 18572 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x0600488D RID: 18573 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083DF RID: 33759
				private int _direction;

				// Token: 0x040083E0 RID: 33760
				private float _delay;
			}

			// Token: 0x02000984 RID: 2436
			public class PartyHard : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600488E RID: 18574 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public PartyHard()
				{
				}

				// Token: 0x0600488F RID: 18575 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083C RID: 2108
				// (get) Token: 0x06004890 RID: 18576 RVA: 0x00260500 File Offset: 0x0025E700
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004891 RID: 18577 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06004892 RID: 18578 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}
			}

			// Token: 0x02000985 RID: 2437
			public class ForceAltTexture : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004893 RID: 18579 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public ForceAltTexture(int altTexture)
				{
				}

				// Token: 0x06004894 RID: 18580 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083D RID: 2109
				// (get) Token: 0x06004895 RID: 18581 RVA: 0x00260518 File Offset: 0x0025E718
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x06004896 RID: 18582 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06004897 RID: 18583 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083E1 RID: 33761
				private int _altTexture;
			}

			// Token: 0x02000986 RID: 2438
			public class Variant : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06004898 RID: 18584 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Variant(int variant)
				{
				}

				// Token: 0x06004899 RID: 18585 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083E RID: 2110
				// (get) Token: 0x0600489A RID: 18586 RVA: 0x00260530 File Offset: 0x0025E730
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x0600489B RID: 18587 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x0600489C RID: 18588 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083E2 RID: 33762
				private int _variant;
			}

			// Token: 0x02000987 RID: 2439
			public class ZombieKnockOnDoor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600489D RID: 18589 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public ZombieKnockOnDoor(int durationInFrames)
				{
				}

				// Token: 0x0600489E RID: 18590 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x1700083F RID: 2111
				// (get) Token: 0x0600489F RID: 18591 RVA: 0x00260548 File Offset: 0x0025E748
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048A0 RID: 18592 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048A1 RID: 18593 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x040083E3 RID: 33763
				private int _duration;

				// Token: 0x040083E4 RID: 33764
				private float _delay;

				// Token: 0x040083E5 RID: 33765
				private Vector2 bumpOffset;

				// Token: 0x040083E6 RID: 33766
				private Vector2 bumpVelocity;
			}
		}

		// Token: 0x02000988 RID: 2440
		public class Sprites
		{
			// Token: 0x060048A2 RID: 18594 RVA: 0x00260560 File Offset: 0x0025E760
			public Sprites()
			{
			}

			// Token: 0x02000989 RID: 2441
			public interface ISpriteAction : IAnimationSegmentAction<Segments.LooseSprite>
			{
			}

			// Token: 0x0200098A RID: 2442
			public class Fade : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048A3 RID: 18595 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(float opacityTarget)
				{
				}

				// Token: 0x060048A4 RID: 18596 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Fade(float opacityTarget, int duration)
				{
				}

				// Token: 0x060048A5 RID: 18597 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000840 RID: 2112
				// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00260574 File Offset: 0x0025E774
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048A7 RID: 18599 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048A8 RID: 18600 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x040083E7 RID: 33767
				private int _duration;

				// Token: 0x040083E8 RID: 33768
				private float _opacityTarget;

				// Token: 0x040083E9 RID: 33769
				private float _delay;
			}

			// Token: 0x0200098B RID: 2443
			public abstract class AScale : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048A9 RID: 18601 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public AScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x060048AA RID: 18602 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public AScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x060048AB RID: 18603 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000841 RID: 2113
				// (get) Token: 0x060048AC RID: 18604 RVA: 0x0026058C File Offset: 0x0025E78C
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048AD RID: 18605 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048AE RID: 18606 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x060048AF RID: 18607
				protected abstract float GetProgress(float durationInFramesToApply);

				// Token: 0x040083EA RID: 33770
				protected int Duration;

				// Token: 0x040083EB RID: 33771
				private Vector2 _scaleTarget;

				// Token: 0x040083EC RID: 33772
				private float _delay;
			}

			// Token: 0x0200098C RID: 2444
			public class LinearScale : Actions.Sprites.AScale
			{
				// Token: 0x060048B0 RID: 18608 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public LinearScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x060048B1 RID: 18609 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public LinearScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x060048B2 RID: 18610 RVA: 0x002605A4 File Offset: 0x0025E7A4
				protected override float GetProgress(float durationInFramesToApply)
				{
					return 0f;
				}
			}

			// Token: 0x0200098D RID: 2445
			public class OutCircleScale : Actions.Sprites.AScale
			{
				// Token: 0x060048B3 RID: 18611 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public OutCircleScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x060048B4 RID: 18612 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public OutCircleScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x060048B5 RID: 18613 RVA: 0x002605BC File Offset: 0x0025E7BC
				protected override float GetProgress(float durationInFramesToApply)
				{
					return 0f;
				}
			}

			// Token: 0x0200098E RID: 2446
			public class Wait : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048B6 RID: 18614 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x060048B7 RID: 18615 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000842 RID: 2114
				// (get) Token: 0x060048B8 RID: 18616 RVA: 0x002605D4 File Offset: 0x0025E7D4
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048B9 RID: 18617 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x060048BA RID: 18618 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x040083ED RID: 33773
				private int _duration;

				// Token: 0x040083EE RID: 33774
				private float _delay;
			}

			// Token: 0x0200098F RID: 2447
			public class SimulateGravity : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048BB RID: 18619 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public SimulateGravity(Vector2 initialVelocity, Vector2 gravityPerFrame, float rotationPerFrame, int duration)
				{
				}

				// Token: 0x060048BC RID: 18620 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000843 RID: 2115
				// (get) Token: 0x060048BD RID: 18621 RVA: 0x002605EC File Offset: 0x0025E7EC
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048BE RID: 18622 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048BF RID: 18623 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x040083EF RID: 33775
				private int _duration;

				// Token: 0x040083F0 RID: 33776
				private float _delay;

				// Token: 0x040083F1 RID: 33777
				private Vector2 _initialVelocity;

				// Token: 0x040083F2 RID: 33778
				private Vector2 _gravityPerFrame;

				// Token: 0x040083F3 RID: 33779
				private float _rotationPerFrame;
			}

			// Token: 0x02000990 RID: 2448
			public class SetFrame : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048C0 RID: 18624 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public SetFrame(int frameX, int frameY, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x060048C1 RID: 18625 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000844 RID: 2116
				// (get) Token: 0x060048C2 RID: 18626 RVA: 0x00260604 File Offset: 0x0025E804
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048C3 RID: 18627 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048C4 RID: 18628 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x040083F4 RID: 33780
				private int _targetFrameX;

				// Token: 0x040083F5 RID: 33781
				private int _targetFrameY;

				// Token: 0x040083F6 RID: 33782
				private int _paddingX;

				// Token: 0x040083F7 RID: 33783
				private int _paddingY;

				// Token: 0x040083F8 RID: 33784
				private float _delay;
			}

			// Token: 0x02000991 RID: 2449
			public class SetFrameSequence : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060048C5 RID: 18629 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public SetFrameSequence(int duration, Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x060048C6 RID: 18630 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public SetFrameSequence(Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x060048C7 RID: 18631 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000845 RID: 2117
				// (get) Token: 0x060048C8 RID: 18632 RVA: 0x0026061C File Offset: 0x0025E81C
				public int ExpectedLengthOfActionInFrames
				{
					get
					{
						return 0;
					}
				}

				// Token: 0x060048C9 RID: 18633 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void SetDelay(float delay)
				{
				}

				// Token: 0x060048CA RID: 18634 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x040083F9 RID: 33785
				private Point[] _frameIndices;

				// Token: 0x040083FA RID: 33786
				private int _timePerFrame;

				// Token: 0x040083FB RID: 33787
				private int _paddingX;

				// Token: 0x040083FC RID: 33788
				private int _paddingY;

				// Token: 0x040083FD RID: 33789
				private float _delay;

				// Token: 0x040083FE RID: 33790
				private int _duration;

				// Token: 0x040083FF RID: 33791
				private bool _loop;
			}
		}
	}
}
