using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;
using Terraria.ID;

namespace Terraria.Audio
{
	// Token: 0x02000689 RID: 1673
	public class LegacySoundPlayer
	{
		// Token: 0x060037DE RID: 14302 RVA: 0x002228EC File Offset: 0x00220AEC
		public LegacySoundPlayer(IServiceProvider services)
		{
			if (!true)
			{
			}
			base..ctor();
			this._services = services;
			this.LoadAll();
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00222918 File Offset: 0x00220B18
		public void Reload()
		{
			this.CreateAllSoundInstances();
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0022292C File Offset: 0x00220B2C
		private void LoadAll()
		{
			Asset<SoundEffect>[] soundMech = this.SoundMech;
			Asset<SoundEffect> asset = this.Load("Sounds/Mech_0");
			if (asset == null || asset != null)
			{
				Asset<SoundEffect> asset2 = this.Load("Sounds/Grab");
				this.SoundGrab = asset2;
				Asset<SoundEffect> asset3 = this.Load("Sounds/Pixie");
				this.SoundPixie = asset3;
				Asset<SoundEffect>[] soundDig = this.SoundDig;
				Asset<SoundEffect> asset4 = this.Load("Sounds/Dig_0");
				if (asset4 == null || asset4 != null)
				{
					Asset<SoundEffect>[] soundDig2 = this.SoundDig;
					Asset<SoundEffect> asset5 = this.Load("Sounds/Dig_1");
					if (asset5 == null || asset5 != null)
					{
						Asset<SoundEffect>[] soundDig3 = this.SoundDig;
						Asset<SoundEffect> asset6 = this.Load("Sounds/Dig_2");
						if (asset6 == null || asset6 != null)
						{
							Asset<SoundEffect>[] soundThunder = this.SoundThunder;
							Asset<SoundEffect> asset7 = this.Load("Sounds/Thunder_0");
							if (asset7 == null || asset7 != null)
							{
								Asset<SoundEffect>[] soundThunder2 = this.SoundThunder;
								Asset<SoundEffect> asset8 = this.Load("Sounds/Thunder_1");
								if (asset8 == null || asset8 != null)
								{
									Asset<SoundEffect>[] soundThunder3 = this.SoundThunder;
									Asset<SoundEffect> asset9 = this.Load("Sounds/Thunder_2");
									if (asset9 == null || asset9 != null)
									{
										Asset<SoundEffect>[] soundThunder4 = this.SoundThunder;
										Asset<SoundEffect> asset10 = this.Load("Sounds/Thunder_3");
										if (asset10 == null || asset10 != null)
										{
											Asset<SoundEffect>[] soundThunder5 = this.SoundThunder;
											Asset<SoundEffect> asset11 = this.Load("Sounds/Thunder_4");
											if (asset11 == null || asset11 != null)
											{
												Asset<SoundEffect>[] soundThunder6 = this.SoundThunder;
												Asset<SoundEffect> asset12 = this.Load("Sounds/Thunder_5");
												if (asset12 == null || asset12 != null)
												{
													Asset<SoundEffect>[] soundThunder7 = this.SoundThunder;
													Asset<SoundEffect> asset13 = this.Load("Sounds/Thunder_6");
													if (asset13 == null || asset13 != null)
													{
														Asset<SoundEffect>[] soundResearch = this.SoundResearch;
														Asset<SoundEffect> asset14 = this.Load("Sounds/Research_0");
														if (asset14 == null || asset14 != null)
														{
															Asset<SoundEffect>[] soundResearch2 = this.SoundResearch;
															Asset<SoundEffect> asset15 = this.Load("Sounds/Research_1");
															if (asset15 == null || asset15 != null)
															{
																Asset<SoundEffect>[] soundResearch3 = this.SoundResearch;
																Asset<SoundEffect> asset16 = this.Load("Sounds/Research_2");
																if (asset16 == null || asset16 != null)
																{
																	Asset<SoundEffect>[] soundResearch4 = this.SoundResearch;
																	Asset<SoundEffect> asset17 = this.Load("Sounds/Research_3");
																	if (asset17 == null || asset17 != null)
																	{
																		Asset<SoundEffect>[] soundTink = this.SoundTink;
																		Asset<SoundEffect> asset18 = this.Load("Sounds/Tink_0");
																		if (asset18 == null || asset18 != null)
																		{
																			Asset<SoundEffect>[] soundTink2 = this.SoundTink;
																			Asset<SoundEffect> asset19 = this.Load("Sounds/Tink_1");
																			if (asset19 == null || asset19 != null)
																			{
																				Asset<SoundEffect>[] soundTink3 = this.SoundTink;
																				Asset<SoundEffect> asset20 = this.Load("Sounds/Tink_2");
																				if (asset20 == null || asset20 != null)
																				{
																					Asset<SoundEffect>[] soundPlayerHit = this.SoundPlayerHit;
																					Asset<SoundEffect> asset21 = this.Load("Sounds/Player_Hit_0");
																					if (asset21 == null || asset21 != null)
																					{
																						Asset<SoundEffect>[] soundPlayerHit2 = this.SoundPlayerHit;
																						Asset<SoundEffect> asset22 = this.Load("Sounds/Player_Hit_1");
																						if (asset22 == null || asset22 != null)
																						{
																							Asset<SoundEffect>[] soundPlayerHit3 = this.SoundPlayerHit;
																							Asset<SoundEffect> asset23 = this.Load("Sounds/Player_Hit_2");
																							if (asset23 == null || asset23 != null)
																							{
																								Asset<SoundEffect>[] soundFemaleHit = this.SoundFemaleHit;
																								Asset<SoundEffect> asset24 = this.Load("Sounds/Female_Hit_0");
																								if (asset24 == null || asset24 != null)
																								{
																									Asset<SoundEffect>[] soundFemaleHit2 = this.SoundFemaleHit;
																									Asset<SoundEffect> asset25 = this.Load("Sounds/Female_Hit_1");
																									if (asset25 == null || asset25 != null)
																									{
																										Asset<SoundEffect>[] soundFemaleHit3 = this.SoundFemaleHit;
																										Asset<SoundEffect> asset26 = this.Load("Sounds/Female_Hit_2");
																										if (asset26 == null || asset26 != null)
																										{
																											Asset<SoundEffect> asset27 = this.Load("Sounds/Player_Killed");
																											this.SoundPlayerKilled = asset27;
																											Asset<SoundEffect> asset28 = this.Load("Sounds/Chat");
																											this.SoundChat = asset28;
																											Asset<SoundEffect> asset29 = this.Load("Sounds/Grass");
																											this.SoundGrass = asset29;
																											Asset<SoundEffect> asset30 = this.Load("Sounds/Door_Opened");
																											this.SoundDoorOpen = asset30;
																											Asset<SoundEffect> asset31 = this.Load("Sounds/Door_Closed");
																											this.SoundDoorClosed = asset31;
																											Asset<SoundEffect> asset32 = this.Load("Sounds/Menu_Tick");
																											this.SoundMenuTick = asset32;
																											Asset<SoundEffect> asset33 = this.Load("Sounds/Menu_Open");
																											this.SoundMenuOpen = asset33;
																											Asset<SoundEffect> asset34 = this.Load("Sounds/Menu_Close");
																											this.SoundMenuClose = asset34;
																											Asset<SoundEffect> asset35 = this.Load("Sounds/Shatter");
																											this.SoundShatter = asset35;
																											Asset<SoundEffect> asset36 = this.Load("Sounds/Camera");
																											this.SoundCamera = asset36;
																											Asset<SoundEffect>[] soundCoin = this.SoundCoin;
																											string text2;
																											string text = "Sounds/Coin_" + text2;
																											Asset<SoundEffect> asset37 = this.Load(text);
																											if (asset37 == null || asset37 != null)
																											{
																												Asset<SoundEffect>[] soundCoin2 = this.SoundCoin;
																												Asset<SoundEffect>[] soundDrip = this.SoundDrip;
																												string text4;
																												string text3 = "Sounds/Drip_" + text4;
																												Asset<SoundEffect> asset38 = this.Load(text3);
																												if (asset38 == null || asset38 != null)
																												{
																													Asset<SoundEffect>[] soundDrip2 = this.SoundDrip;
																													Asset<SoundEffect>[] soundZombie = this.SoundZombie;
																													string text6;
																													string text5 = "Sounds/Zombie_" + text6;
																													Asset<SoundEffect> asset39 = this.Load(text5);
																													if (asset39 == null || asset39 != null)
																													{
																														Asset<SoundEffect>[] soundZombie2 = this.SoundZombie;
																														Asset<SoundEffect>[] soundLiquid = this.SoundLiquid;
																														string text8;
																														string text7 = "Sounds/Liquid_" + text8;
																														Asset<SoundEffect> asset40 = this.Load(text7);
																														if (asset40 == null || asset40 != null)
																														{
																															Asset<SoundEffect>[] soundLiquid2 = this.SoundLiquid;
																															Asset<SoundEffect>[] soundRoar = this.SoundRoar;
																															string text10;
																															string text9 = "Sounds/Roar_" + text10;
																															Asset<SoundEffect> asset41 = this.Load(text9);
																															if (asset41 == null || asset41 != null)
																															{
																																Asset<SoundEffect>[] soundRoar2 = this.SoundRoar;
																																string text12;
																																string text11 = "Sounds/Splash_" + text12;
																																Asset<SoundEffect> asset42 = this.Load(text11);
																																if (asset42 == null || asset42 != null)
																																{
																																	Asset<SoundEffect>[] soundSplash = this.SoundSplash;
																																	Asset<SoundEffect> asset43 = this.Load("Sounds/Double_Jump");
																																	this.SoundDoubleJump = asset43;
																																	Asset<SoundEffect> asset44 = this.Load("Sounds/Run");
																																	this.SoundRun = asset44;
																																	Asset<SoundEffect> asset45 = this.Load("Sounds/Coins");
																																	this.SoundCoins = asset45;
																																	Asset<SoundEffect> asset46 = this.Load("Sounds/Unlock");
																																	this.SoundUnlock = asset46;
																																	Asset<SoundEffect> asset47 = this.Load("Sounds/MaxMana");
																																	this.SoundMaxMana = asset47;
																																	Asset<SoundEffect> asset48 = this.Load("Sounds/Drown");
																																	this.SoundDrown = asset48;
																																	Asset<SoundEffect>[] soundItem = this.SoundItem;
																																	string text14;
																																	string text13 = "Sounds/Item_" + text14;
																																	Asset<SoundEffect> asset49 = this.Load(text13);
																																	if (asset49 == null || asset49 != null)
																																	{
																																		Asset<SoundEffect>[] soundItem2 = this.SoundItem;
																																		Asset<SoundEffect>[] soundNpcHit = this.SoundNpcHit;
																																		string text16;
																																		string text15 = "Sounds/NPC_Hit_" + text16;
																																		Asset<SoundEffect> asset50 = this.Load(text15);
																																		if (asset50 == null || asset50 != null)
																																		{
																																			Asset<SoundEffect>[] soundNpcHit2 = this.SoundNpcHit;
																																			Asset<SoundEffect>[] soundNpcKilled = this.SoundNpcKilled;
																																			string text18;
																																			string text17 = "Sounds/NPC_Killed_" + text18;
																																			Asset<SoundEffect> asset51 = this.Load(text17);
																																			if (asset51 == null || asset51 != null)
																																			{
																																				Asset<SoundEffect>[] soundNpcKilled2 = this.SoundNpcKilled;
																																				int trackableLegacySoundCount = SoundID.TrackableLegacySoundCount;
																																				Asset<SoundEffect>[] trackableSounds = this.TrackableSounds;
																																				string trackableLegacySoundPath = SoundID.GetTrackableLegacySoundPath(0);
																																				string text20;
																																				string text19 = "Sounds/Custom" + text20 + trackableLegacySoundPath;
																																				Asset<SoundEffect> asset52 = this.Load(text19);
																																				if (asset52 == null || asset52 != null)
																																				{
																																					Asset<SoundEffect>[] trackableSounds2 = this.TrackableSounds;
																																					return;
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x000021DB File Offset: 0x000003DB
		public void CreateAllSoundInstances()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x000021DB File Offset: 0x000003DB
		private SoundEffectInstance CreateInstance(Asset<SoundEffect> asset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00222FD4 File Offset: 0x002211D4
		private Asset<SoundEffect> Load(string assetName)
		{
			/*
An exception occurred when decompiling this method (060037E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Content.Asset`1<Microsoft.Xna.Framework.Audio.SoundEffect> Terraria.Audio.LegacySoundPlayer::Load(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IAssetRepository(var_0_0B, call:IAssetRepository(XnaExtensions::Get, ldfld:IServiceProvider(LegacySoundPlayer::_services, ldloc:LegacySoundPlayer(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00222FEC File Offset: 0x002211EC
		public SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				float soundVolume = Main.soundVolume;
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				bool netHostOnly = Main.NetHostOnly;
				if (num2 == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				int screenWidth = Main.screenWidth;
				Vector2 screenPosition2 = Main.screenPosition;
				int screenHeight = Main.screenHeight;
				if (!false)
				{
				}
				int num3 = 1;
				long num4 = 49152L;
				if (num3 == 0)
				{
				}
				float ambientVolume = Main.ambientVolume;
				if (num4 == 0L)
				{
				}
				bool gameMenu = Main.gameMenu;
				int num5 = 1;
				long num6 = 1904L;
				if (num5 == 0)
				{
				}
				float soundVolume2 = Main.soundVolume;
				Asset<SoundEffect>[] soundDrip = this.SoundDrip;
				SoundEffectInstance[] soundInstanceDrip = this.SoundInstanceDrip;
				SoundEffectInstance soundEffectInstance;
				if (soundEffectInstance != null && soundEffectInstance == null)
				{
					goto IL_17A3;
				}
				float volume = this.SoundInstanceDrip._volume;
				float volume2 = this.SoundInstanceDrip._volume;
				float volume3 = this.SoundInstanceDrip._volume;
				if (num6 == 0L)
				{
				}
				SoundEffectInstance[] soundInstanceDrip2 = this.SoundInstanceDrip;
				int digLastFrame = this._digLastFrame;
				if (num6 == 0L)
				{
				}
				if (this.SoundDigPlayCount == null)
				{
				}
				this.SoundDigPlayCount.m_value = (int)num6;
				float volume4 = this.SoundInstanceDig._volume;
				if (volume4 != null)
				{
					if (volume4 == null)
					{
						goto IL_14D2;
					}
					if (this.SoundInstanceDig._volume != null)
					{
						int screenWidth2 = Main.screenWidth;
						if (!true)
						{
						}
						SoundEffectInstance[] soundInstanceZombie = this.SoundInstanceZombie;
						int num7;
						if (num7 != 0)
						{
							if (num7 == 0)
							{
								goto IL_1756;
							}
							SoundEffectInstance[] soundInstanceZombie2 = this.SoundInstanceZombie;
						}
						Asset<SoundEffect>[] soundZombie = this.SoundZombie;
						SoundEffectInstance soundEffectInstance2;
						if (soundEffectInstance2 != null && soundEffectInstance2 == null)
						{
							throw new ArrayTypeMismatchException();
						}
						float volume5 = this.SoundInstanceZombie._volume;
						float volume6 = this.SoundInstanceZombie._volume;
						SoundEffectInstance[] soundInstanceZombie3 = this.SoundInstanceZombie;
						float volume7 = soundInstanceZombie3._volume;
						if (num6 == 0L)
						{
						}
						SoundEffectInstance[] soundInstanceZombie4 = this.SoundInstanceZombie;
						float volume8 = soundInstanceZombie3._volume;
						if (volume8 != null)
						{
							if (volume8 == null)
							{
								goto IL_1756;
							}
							SoundEffectInstance[] soundInstanceZombie5 = this.SoundInstanceZombie;
						}
						Asset<SoundEffect>[] soundZombie2 = this.SoundZombie;
						SoundEffectInstance soundEffectInstance3;
						if (soundEffectInstance3 != null && soundEffectInstance3 == null)
						{
							throw new ArrayTypeMismatchException();
						}
						float volume9 = this.SoundInstanceZombie._volume;
						float volume10 = this.SoundInstanceZombie._volume;
						float volume11 = this.SoundInstanceZombie._volume;
						if (num6 == 0L)
						{
						}
						SoundEffectInstance[] soundInstanceResearch;
						if (this.SoundInstanceResearch._volume != null)
						{
							soundInstanceResearch = this.SoundInstanceResearch;
						}
						Asset<SoundEffect>[] soundResearch = this.SoundResearch;
						SoundEffectInstance soundEffectInstance4;
						if (soundEffectInstance4 != null && soundEffectInstance4 == null)
						{
							throw new ArrayTypeMismatchException();
						}
						soundInstanceResearch._volume = soundEffectInstance4;
						float volume12 = this.SoundInstanceResearch._volume;
						float volume13 = this.SoundInstanceResearch._volume;
						SoundEffectInstance[] soundInstanceResearch2 = this.SoundInstanceResearch;
						if (soundInstanceResearch2 == null)
						{
						}
						SoundEffectInstance[] soundInstanceResearch3 = this.SoundInstanceResearch;
						if (soundInstanceResearch2._volume != null)
						{
							SoundEffectInstance[] soundInstanceResearch4 = this.SoundInstanceResearch;
						}
						Asset<SoundEffect>[] soundResearch2 = this.SoundResearch;
						SoundEffectInstance soundEffectInstance5;
						if (soundEffectInstance5 != null && soundEffectInstance5 == null)
						{
							throw new ArrayTypeMismatchException();
						}
						float volume14 = this.SoundInstanceResearch._volume;
						float volume15 = this.SoundInstanceResearch._volume;
						SoundEffectInstance[] soundInstanceResearch5 = this.SoundInstanceResearch;
						SoundEffectInstance[] soundInstanceZombie6 = this.SoundInstanceZombie;
						if (volume15 != null)
						{
							if (volume15 == null)
							{
								goto IL_1756;
							}
							SoundEffectInstance[] soundInstanceZombie7 = this.SoundInstanceZombie;
						}
						Asset<SoundEffect>[] soundZombie3 = this.SoundZombie;
						SoundEffectInstance soundEffectInstance6;
						if (soundEffectInstance6 == null || soundEffectInstance6 != null)
						{
							SoundEffectInstance[] soundInstanceZombie8 = this.SoundInstanceZombie;
							soundEffectInstance6.Volume = pitchOffset;
							SoundEffectInstance[] soundInstanceZombie9 = this.SoundInstanceZombie;
							soundEffectInstance6.Pan = pitchOffset;
							SoundEffectInstance[] soundInstanceZombie10 = this.SoundInstanceZombie;
							if (num6 == 0L)
							{
							}
							soundEffectInstance6.Pitch = pitchOffset;
							SoundEffectInstance[] soundInstanceZombie11 = this.SoundInstanceZombie;
							return soundEffectInstance6;
						}
						throw new ArrayTypeMismatchException();
					}
				}
				SoundEffectInstance[] soundInstanceNpcHit = this.SoundInstanceNpcHit;
				SoundEffectInstance[] array;
				if (array._volume != null)
				{
					SoundEffectInstance[] soundInstanceNpcHit2 = this.SoundInstanceNpcHit;
				}
				Asset<SoundEffect>[] soundNpcHit = this.SoundNpcHit;
				SoundEffectInstance soundEffectInstance7;
				if (soundEffectInstance7 != null && soundEffectInstance7 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				float volume16 = this.SoundInstanceNpcHit._volume;
				float volume17 = this.SoundInstanceNpcHit._volume;
				float volume18 = this.SoundInstanceNpcHit._volume;
				int num8;
				if (num8 == 0)
				{
				}
				float volume19 = this.SoundInstanceItem._volume;
				long num9;
				if (volume19 != null)
				{
					if (volume19 != null)
					{
						if (this.SoundInstanceItem._volume != null)
						{
						}
					}
					else
					{
						SoundEffectInstance[] array2;
						float volume20 = array2._volume;
						float volume21 = array2._volume;
						float volume22 = array2._volume;
						if (num8 == 0)
						{
						}
						if (num8 == 0)
						{
						}
						if (num8 == 0)
						{
						}
						if (num8 == 0)
						{
						}
						if (num8 == 0)
						{
						}
						if (num8 == 0)
						{
						}
						num9 = 1024L;
						if (num9 == 0L)
						{
						}
						SoundEffectInstance soundEffectInstance8;
						if (soundEffectInstance8 == null || soundEffectInstance8 != null)
						{
							soundEffectInstance8.Volume = pitchOffset;
							soundEffectInstance8.Pan = pitchOffset;
							if (num9 == 0L)
							{
							}
							soundEffectInstance8.Pitch = pitchOffset;
							goto IL_14D2;
						}
						throw new ArrayTypeMismatchException();
					}
				}
				Asset<SoundEffect>[] soundItem = this.SoundItem;
				SoundEffectInstance[] soundInstanceItem = this.SoundInstanceItem;
				SoundEffectInstance soundEffectInstance9;
				if (soundEffectInstance9 == null || soundEffectInstance9 != null)
				{
					return soundEffectInstance9;
				}
				throw new ArrayTypeMismatchException();
				IL_14D2:
				SoundEffectInstance soundEffectInstance10;
				if (soundEffectInstance10 != null && soundEffectInstance10 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (num9 == 0L)
				{
				}
				SoundEffectInstance soundEffectInstance11;
				if (soundEffectInstance11 != null && soundEffectInstance11 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (num9 == 0L)
				{
				}
				SoundEffectInstance soundEffectInstance12;
				if (soundEffectInstance12 == null || soundEffectInstance12 != null)
				{
					soundEffectInstance12.Volume = pitchOffset;
					soundEffectInstance12.Pan = pitchOffset;
					return soundEffectInstance12;
				}
				throw new ArrayTypeMismatchException();
			}
			IL_1756:
			SoundEffectInstance soundEffectInstance13;
			DateTime finishTime = soundEffectInstance13._playingInstance.FinishTime;
			DateTime finishTime2 = soundEffectInstance13._playingInstance.FinishTime;
			bool fading = soundEffectInstance13._playingInstance._fading;
			bool fading2 = soundEffectInstance13._playingInstance._fading;
			IL_17A3:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00224890 File Offset: 0x00222A90
		public SoundEffect GetTrackableSoundByStyleId(int id)
		{
			/*
An exception occurred when decompiling this method (060037E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Audio.SoundEffect Terraria.Audio.LegacySoundPlayer::GetTrackableSoundByStyleId(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Audio.SoundEffect>[](var_0_06, ldfld:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Audio.SoundEffect>[](LegacySoundPlayer::TrackableSounds, ldloc:LegacySoundPlayer(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x002248A4 File Offset: 0x00222AA4
		public void StopAmbientSounds()
		{
			bool loop = this.SoundInstanceLiquid._loop;
			if (this != null)
			{
				SoundEffectInstance[] soundInstanceLiquid = this.SoundInstanceLiquid;
			}
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000021DB File Offset: 0x000003DB
		public bool DoesSoundScaleWithAmbientVolume(int soundType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040078B4 RID: 30900
		public Asset<SoundEffect>[] SoundDrip;

		// Token: 0x040078B5 RID: 30901
		public SoundEffectInstance[] SoundInstanceDrip;

		// Token: 0x040078B6 RID: 30902
		public Asset<SoundEffect>[] SoundLiquid;

		// Token: 0x040078B7 RID: 30903
		public SoundEffectInstance[] SoundInstanceLiquid;

		// Token: 0x040078B8 RID: 30904
		public Asset<SoundEffect>[] SoundMech;

		// Token: 0x040078B9 RID: 30905
		public SoundEffectInstance[] SoundInstanceMech;

		// Token: 0x040078BA RID: 30906
		public Asset<SoundEffect>[] SoundDig;

		// Token: 0x040078BB RID: 30907
		public SoundEffectInstance[] SoundInstanceDig;

		// Token: 0x040078BC RID: 30908
		private int _digLastFrame = 1;

		// Token: 0x040078BD RID: 30909
		public int[] SoundDigPlayCount;

		// Token: 0x040078BE RID: 30910
		public Asset<SoundEffect>[] SoundThunder;

		// Token: 0x040078BF RID: 30911
		public SoundEffectInstance[] SoundInstanceThunder;

		// Token: 0x040078C0 RID: 30912
		public Asset<SoundEffect>[] SoundResearch;

		// Token: 0x040078C1 RID: 30913
		public SoundEffectInstance[] SoundInstanceResearch;

		// Token: 0x040078C2 RID: 30914
		public Asset<SoundEffect>[] SoundTink;

		// Token: 0x040078C3 RID: 30915
		public SoundEffectInstance[] SoundInstanceTink;

		// Token: 0x040078C4 RID: 30916
		public Asset<SoundEffect>[] SoundCoin;

		// Token: 0x040078C5 RID: 30917
		public SoundEffectInstance[] SoundInstanceCoin;

		// Token: 0x040078C6 RID: 30918
		public Asset<SoundEffect>[] SoundPlayerHit;

		// Token: 0x040078C7 RID: 30919
		public SoundEffectInstance[] SoundInstancePlayerHit;

		// Token: 0x040078C8 RID: 30920
		public Asset<SoundEffect>[] SoundFemaleHit;

		// Token: 0x040078C9 RID: 30921
		public SoundEffectInstance[] SoundInstanceFemaleHit;

		// Token: 0x040078CA RID: 30922
		public Asset<SoundEffect> SoundPlayerKilled;

		// Token: 0x040078CB RID: 30923
		public SoundEffectInstance SoundInstancePlayerKilled;

		// Token: 0x040078CC RID: 30924
		public Asset<SoundEffect> SoundGrass;

		// Token: 0x040078CD RID: 30925
		public SoundEffectInstance SoundInstanceGrass;

		// Token: 0x040078CE RID: 30926
		public Asset<SoundEffect> SoundGrab;

		// Token: 0x040078CF RID: 30927
		public SoundEffectInstance SoundInstanceGrab;

		// Token: 0x040078D0 RID: 30928
		public Asset<SoundEffect> SoundPixie;

		// Token: 0x040078D1 RID: 30929
		public SoundEffectInstance SoundInstancePixie;

		// Token: 0x040078D2 RID: 30930
		public Asset<SoundEffect>[] SoundItem;

		// Token: 0x040078D3 RID: 30931
		public SoundEffectInstance[] SoundInstanceItem;

		// Token: 0x040078D4 RID: 30932
		public Asset<SoundEffect>[] SoundNpcHit;

		// Token: 0x040078D5 RID: 30933
		public SoundEffectInstance[] SoundInstanceNpcHit;

		// Token: 0x040078D6 RID: 30934
		public Asset<SoundEffect>[] SoundNpcKilled;

		// Token: 0x040078D7 RID: 30935
		public SoundEffectInstance[] SoundInstanceNpcKilled;

		// Token: 0x040078D8 RID: 30936
		public SoundEffectInstance SoundInstanceMoonlordCry;

		// Token: 0x040078D9 RID: 30937
		public Asset<SoundEffect> SoundDoorOpen;

		// Token: 0x040078DA RID: 30938
		public SoundEffectInstance SoundInstanceDoorOpen;

		// Token: 0x040078DB RID: 30939
		public Asset<SoundEffect> SoundDoorClosed;

		// Token: 0x040078DC RID: 30940
		public SoundEffectInstance SoundInstanceDoorClosed;

		// Token: 0x040078DD RID: 30941
		public Asset<SoundEffect> SoundMenuOpen;

		// Token: 0x040078DE RID: 30942
		public SoundEffectInstance SoundInstanceMenuOpen;

		// Token: 0x040078DF RID: 30943
		public Asset<SoundEffect> SoundMenuClose;

		// Token: 0x040078E0 RID: 30944
		public SoundEffectInstance SoundInstanceMenuClose;

		// Token: 0x040078E1 RID: 30945
		public Asset<SoundEffect> SoundMenuTick;

		// Token: 0x040078E2 RID: 30946
		public SoundEffectInstance SoundInstanceMenuTick;

		// Token: 0x040078E3 RID: 30947
		public Asset<SoundEffect> SoundShatter;

		// Token: 0x040078E4 RID: 30948
		public SoundEffectInstance SoundInstanceShatter;

		// Token: 0x040078E5 RID: 30949
		public Asset<SoundEffect> SoundCamera;

		// Token: 0x040078E6 RID: 30950
		public SoundEffectInstance SoundInstanceCamera;

		// Token: 0x040078E7 RID: 30951
		public Asset<SoundEffect>[] SoundZombie;

		// Token: 0x040078E8 RID: 30952
		public SoundEffectInstance[] SoundInstanceZombie;

		// Token: 0x040078E9 RID: 30953
		public Asset<SoundEffect>[] SoundRoar;

		// Token: 0x040078EA RID: 30954
		public SoundEffectInstance[] SoundInstanceRoar;

		// Token: 0x040078EB RID: 30955
		public Asset<SoundEffect>[] SoundSplash;

		// Token: 0x040078EC RID: 30956
		public SoundEffectInstance[] SoundInstanceSplash;

		// Token: 0x040078ED RID: 30957
		public Asset<SoundEffect> SoundDoubleJump;

		// Token: 0x040078EE RID: 30958
		public SoundEffectInstance SoundInstanceDoubleJump;

		// Token: 0x040078EF RID: 30959
		public Asset<SoundEffect> SoundRun;

		// Token: 0x040078F0 RID: 30960
		public SoundEffectInstance SoundInstanceRun;

		// Token: 0x040078F1 RID: 30961
		public Asset<SoundEffect> SoundCoins;

		// Token: 0x040078F2 RID: 30962
		public SoundEffectInstance SoundInstanceCoins;

		// Token: 0x040078F3 RID: 30963
		public Asset<SoundEffect> SoundUnlock;

		// Token: 0x040078F4 RID: 30964
		public SoundEffectInstance SoundInstanceUnlock;

		// Token: 0x040078F5 RID: 30965
		public Asset<SoundEffect> SoundChat;

		// Token: 0x040078F6 RID: 30966
		public SoundEffectInstance SoundInstanceChat;

		// Token: 0x040078F7 RID: 30967
		public Asset<SoundEffect> SoundMaxMana;

		// Token: 0x040078F8 RID: 30968
		public SoundEffectInstance SoundInstanceMaxMana;

		// Token: 0x040078F9 RID: 30969
		public Asset<SoundEffect> SoundDrown;

		// Token: 0x040078FA RID: 30970
		public SoundEffectInstance SoundInstanceDrown;

		// Token: 0x040078FB RID: 30971
		public Asset<SoundEffect>[] TrackableSounds;

		// Token: 0x040078FC RID: 30972
		public SoundEffectInstance[] TrackableSoundInstances;

		// Token: 0x040078FD RID: 30973
		private readonly IServiceProvider _services;

		// Token: 0x040078FE RID: 30974
		private List<SoundEffectInstance> _trackedInstances;
	}
}
