﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace ContentBuilder
{
	class Replace
	{

		const string SourcePath_CPlusPlus = @"C:\Users\Ezra\Desktop\Dir\Pwnee\CK\Source\CloudberryKingdomPort\Cloudberry-Kingdom-Port\Game\";

		public static void ReplaceWord(string newword, string word)
		{
			var files = ContentBuilder.GetFiles(SourcePath_CPlusPlus, true);
			foreach (var file in files)
			{
				var ext = Path.GetExtension(file);
				
				if (ext == ".cpp" || ext == ".h")
				{
					var text = File.ReadAllText(file);
					if (text.Contains(word))
					{
						text = text.Replace(word, newword);
						File.WriteAllText(file, text);
					}
				}
			}
		}

		public static void DoReplaceWord()
		{
ReplaceWord("Words_LoadTheFollowingSeedQuestion", "Words_LOAD_THE_FOLLOWING_SEED_QUESTION");
ReplaceWord("Words_SeedSavedSuccessfully", "Words_SEED_SAVED_SUCCESSFULLY");
ReplaceWord("Words_RemovePlayerQuestion", "Words_REMOVE_PLAYER_QUESTION");
ReplaceWord("Words_TheNextNinetyNine", "Words_THE_NEXT_NINETY_NINE");
ReplaceWord("Words_SecondsOnTheClock", "Words_SECONDS_ON_THE_CLOCK");
ReplaceWord("Words_LoadFromClipboard", "Words_LOAD_FROM_CLIPBOARD");
ReplaceWord("Words_ExitLevelQuestion", "Words_EXIT_LEVEL_QUESTION");
ReplaceWord("Words_SaveRandomSeedAs", "Words_SAVE_RANDOM_SEED_AS");
ReplaceWord("Words_ArrowThroughHead", "Words_ARROW_THROUGH_HEAD");
ReplaceWord("Words_DoubleJumpLength", "Words_DOUBLE_JUMP_LENGTH");
ReplaceWord("Words_DoubleJumpAccel", "Words_DOUBLE_JUMP_ACCEL");
ReplaceWord("Words_AGauntletOfDoom", "Words_AGAUNTLET_OF_DOOM");
ReplaceWord("Words_CoinsAddSeconds", "Words_COINS_ADD_SECONDS");
ReplaceWord("Words_CopyToClipboard", "Words_COPY_TO_CLIPBOARD");
ReplaceWord("Words_NewHeroUnlocked", "Words_NEW_HERO_UNLOCKED");
ReplaceWord("Words_ActivateSlowMo", "Words_ACTIVATE_SLOW_MO");
ReplaceWord("Words_BackToFreeplay", "Words_BACK_TO_FREEPLAY");
ReplaceWord("Words_JumpDifficulty", "Words_JUMP_DIFFICULTY");
ReplaceWord("Words_JetpackWheelie", "Words_JETPACK_WHEELIE");
ReplaceWord("Words_GetToTheExit", "Words_GET_TO_THE_EXIT");
ReplaceWord("Words_GetAHighScore", "Words_GET_AHIGH_SCORE");
ReplaceWord("Words_ToggleSlowMo", "Words_TOGGLE_SLOW_MO");
ReplaceWord("Words_FallingBlocks", "Words_FALLING_BLOCKS");
ReplaceWord("Words_MaxFallSpeed", "Words_MAX_FALL_SPEED");
ReplaceWord("Words_PhasedGravity", "Words_PHASED_GRAVITY");
ReplaceWord("Words_FallingSpikey", "Words_FALLING_SPIKEY");
ReplaceWord("Words_NewHighScore", "Words_NEW_HIGH_SCORE");
ReplaceWord("Words_WatchComputer", "Words_WATCH_COMPUTER");
ReplaceWord("Words_PressAnyKey", "Words_PRESS_ANY_KEY");
ReplaceWord("Words_EditControls", "Words_EDIT_CONTROLS");
ReplaceWord("Words_WindowBorder", "Words_WINDOW_BORDER");
ReplaceWord("Words_PowerUpMenu", "Words_POWER_UP_MENU");
ReplaceWord("Words_ReplayToggle", "Words_REPLAY_TOGGLE");
ReplaceWord("Words_PressToJoin", "Words_PRESS_TO_JOIN");
ReplaceWord("Words_KnightHelmet", "Words_KNIGHT_HELMET");
ReplaceWord("Words_MovingBlocks", "Words_MOVING_BLOCKS");
ReplaceWord("Words_BouncyBlocks", "Words_BOUNCY_BLOCKS");
ReplaceWord("Words_TheBeginning", "Words_THE_BEGINNING");
ReplaceWord("Words_TheMasochist", "Words_THE_MASOCHIST");
ReplaceWord("Words_NoNameGiven", "Words_NO_NAME_GIVEN");
ReplaceWord("Words_LevelCleared", "Words_LEVEL_CLEARED");
ReplaceWord("Words_KeepSettings", "Words_KEEP_SETTINGS");
ReplaceWord("Words_HeroUnlocked", "Words_HERO_UNLOCKED");
ReplaceWord("Words_SoundVolume", "Words_SOUND_VOLUME");
ReplaceWord("Words_MusicVolume", "Words_MUSIC_VOLUME");
ReplaceWord("Words_ForestGreen", "Words_FOREST_GREEN");
ReplaceWord("Words_BrightWhite", "Words_BRIGHT_WHITE");
ReplaceWord("Words_TrafficCone", "Words_TRAFFIC_CONE");
ReplaceWord("Words_ClassicGame", "Words_CLASSIC_GAME");
ReplaceWord("Words_HeroFactory", "Words_HERO_FACTORY");
ReplaceWord("Words_GhostBlocks", "Words_GHOST_BLOCKS");
ReplaceWord("Words_FlyingBlobs", "Words_FLYING_BLOBS");
ReplaceWord("Words_Firespinners", "Words_FIRESPINNERS");
ReplaceWord("Words_SpikeyLines", "Words_SPIKEY_LINES");
ReplaceWord("Words_Acceleration", "Words_ACCELERATION");
ReplaceWord("Words_MaxVelocity", "Words_MAX_VELOCITY");
ReplaceWord("Words_JetpackFuel", "Words_JETPACK_FUEL");
ReplaceWord("Words_PhasePeriod", "Words_PHASE_PERIOD");
ReplaceWord("Words_ClassicHero", "Words_CLASSIC_HERO");
ReplaceWord("Words_HeroInABox", "Words_HERO_IN_ABOX");
ReplaceWord("Words_CoinsOutOf", "Words_COINS_OUT_OF");
ReplaceWord("Words_AverageLife", "Words_AVERAGE_LIFE");
ReplaceWord("Words_WatchReplay", "Words_WATCH_REPLAY");
ReplaceWord("Words_PressStart", "Words_PRESS_START");
ReplaceWord("Words_FullScreen", "Words_FULL_SCREEN");
ReplaceWord("Words_QuickSpawn", "Words_QUICK_SPAWN");
ReplaceWord("Words_ReplayPrev", "Words_REPLAY_PREV");
ReplaceWord("Words_ReplayNext", "Words_REPLAY_NEXT");
ReplaceWord("Words_SantaClaus", "Words_SANTA_CLAUS");
ReplaceWord("Words_Masochistic", "Words_MASOCHISTIC");
ReplaceWord("Words_Checkpoints", "Words_CHECKPOINTS");
ReplaceWord("Words_LevelSpeed", "Words_LEVEL_SPEED");
ReplaceWord("Words_SpikeyGuys", "Words_SPIKEY_GUYS");
ReplaceWord("Words_JumpLength", "Words_JUMP_LENGTH");
ReplaceWord("Words_JetpackAcc", "Words_JETPACK_ACC");
ReplaceWord("Words_PhasedSize", "Words_PHASED_SIZE");
ReplaceWord("Words_DoubleJump", "Words_DOUBLE_JUMP");
ReplaceWord("Words_TimeMaster", "Words_TIME_MASTER");
ReplaceWord("Words_AlmostHero", "Words_ALMOST_HERO");
ReplaceWord("Words_TimeCrisis", "Words_TIME_CRISIS");
ReplaceWord("Words_HybridRush", "Words_HYBRID_RUSH");
ReplaceWord("Words_Leaderboard", "Words_LEADERBOARD");
ReplaceWord("Words_RandomSeed", "Words_RANDOM_SEED");
ReplaceWord("Words_SavedSeeds", "Words_SAVED_SEEDS");
ReplaceWord("Words_LevelsBeat", "Words_LEVELS_BEAT");
ReplaceWord("Words_Firespinner", "Words_FIRESPINNER");
ReplaceWord("Words_LeftBehind", "Words_LEFT_BEHIND");
ReplaceWord("Words_HighScores", "Words_HIGH_SCORES");
ReplaceWord("Words_Identifier", "Words_IDENTIFIER");
ReplaceWord("Words_TheArcade", "Words_THE_ARCADE");
ReplaceWord("Words_StoryMode", "Words_STORY_MODE");
ReplaceWord("Words_Resolution", "Words_RESOLUTION");
ReplaceWord("Words_LimeGreen", "Words_LIME_GREEN");
ReplaceWord("Words_Lumberjack", "Words_LUMBERJACK");
ReplaceWord("Words_OmNomNom", "Words_OM_NOM_NOM");
ReplaceWord("Words_RobinHood", "Words_ROBIN_HOOD");
ReplaceWord("Words_PirateHat", "Words_PIRATE_HAT");
ReplaceWord("Words_BunnyEars", "Words_BUNNY_EARS");
ReplaceWord("Words_WallLevel", "Words_WALL_LEVEL");
ReplaceWord("Words_Difficulty", "Words_DIFFICULTY");
ReplaceWord("Words_Unpleasant", "Words_UNPLEASANT");
ReplaceWord("Words_LoadLevel", "Words_LOAD_LEVEL");
ReplaceWord("Words_Aggressive", "Words_AGGRESSIVE");
ReplaceWord("Words_Escalation", "Words_ESCALATION");
ReplaceWord("Words_HighScore", "Words_HIGH_SCORE");
ReplaceWord("Words_BestLevel", "Words_BEST_LEVEL");
ReplaceWord("Words_ExtraLife", "Words_EXTRA_LIFE");
ReplaceWord("Words_Statistics", "Words_STATISTICS");
ReplaceWord("Words_ExitLevel", "Words_EXIT_LEVEL");
ReplaceWord("Words_SpikeyGuy", "Words_SPIKEY_GUY");
ReplaceWord("Words_TimeLimit", "Words_TIME_LIMIT");
ReplaceWord("Words_PlayAgain", "Words_PLAY_AGAIN");
ReplaceWord("Words_FreePlay", "Words_FREE_PLAY");
ReplaceWord("Words_ExitGame", "Words_EXIT_GAME");
ReplaceWord("Words_Manhattan", "Words_MANHATTAN");
ReplaceWord("Words_BrainHat", "Words_BRAIN_HAT");
ReplaceWord("Words_FourEyes", "Words_FOUR_EYES");
ReplaceWord("Words_BrownBag", "Words_BROWN_BAG");
ReplaceWord("Words_TikiMask", "Words_TIKI_MASK");
ReplaceWord("Words_Elevators", "Words_ELEVATORS");
ReplaceWord("Words_Pendulums", "Words_PENDULUMS");
ReplaceWord("Words_Fireballs", "Words_FIREBALLS");
ReplaceWord("Words_NumJumps", "Words_NUM_JUMPS");
ReplaceWord("Words_Spaceship", "Words_SPACESHIP");
ReplaceWord("Words_Rocketbox", "Words_ROCKETBOX");
ReplaceWord("Words_PhaseBob", "Words_PHASE_BOB");
ReplaceWord("Words_HeroRush", "Words_HERO_RUSH");
ReplaceWord("Words_SaveLoad", "Words_SAVE_LOAD");
ReplaceWord("Words_RemoveMe", "Words_REMOVE_ME");
ReplaceWord("Words_SaveSeed", "Words_SAVE_SEED");
ReplaceWord("Words_LoadSeed", "Words_LOAD_SEED");
ReplaceWord("Words_GameOver", "Words_GAME_OVER");
ReplaceWord("Words_ShowPath", "Words_SHOW_PATH");
ReplaceWord("Words_Language", "Words_LANGUAGE");
ReplaceWord("Words_Controls", "Words_CONTROLS");
ReplaceWord("Words_HotPink", "Words_HOT_PINK");
ReplaceWord("Words_Firehead", "Words_FIREHEAD");
ReplaceWord("Words_HardHat", "Words_HARD_HAT");
ReplaceWord("Words_PopeHat", "Words_POPE_HAT");
ReplaceWord("Words_RiceHat", "Words_RICE_HAT");
ReplaceWord("Words_Sombrero", "Words_SOMBRERO");
ReplaceWord("Words_Location", "Words_LOCATION");
ReplaceWord("Words_Training", "Words_TRAINING");
ReplaceWord("Words_Hardcore", "Words_HARDCORE");
ReplaceWord("Words_Continue", "Words_CONTINUE");
ReplaceWord("Words_Ceilings", "Words_CEILINGS");
ReplaceWord("Words_Boulders", "Words_BOULDERS");
ReplaceWord("Words_Friction", "Words_FRICTION");
ReplaceWord("Words_JumpAcc", "Words_JUMP_ACC");
ReplaceWord("Words_TinyBob", "Words_TINY_BOB");
ReplaceWord("Words_Viridian", "Words_VIRIDIAN");
ReplaceWord("Words_Fireball", "Words_FIREBALL");
ReplaceWord("Words_Previous", "Words_PREVIOUS");
ReplaceWord("Words_Options", "Words_OPTIONS");
ReplaceWord("Words_Vandyke", "Words_VANDYKE");
ReplaceWord("Words_TopHat", "Words_TOP_HAT");
ReplaceWord("Words_Pumpkin", "Words_PUMPKIN");
ReplaceWord("Words_Antlers", "Words_ANTLERS");
ReplaceWord("Words_Factory", "Words_FACTORY");
ReplaceWord("Words_Abusive", "Words_ABUSIVE");
ReplaceWord("Words_Passive", "Words_PASSIVE");
ReplaceWord("Words_Serpent", "Words_SERPENT");
ReplaceWord("Words_Gravity", "Words_GRAVITY");
ReplaceWord("Words_Wheelie", "Words_WHEELIE");
ReplaceWord("Words_FatBob", "Words_FAT_BOB");
ReplaceWord("Words_Meatboy", "Words_MEATBOY");
ReplaceWord("Words_Factory", "Words_FACTORY");
ReplaceWord("Words_Perfect", "Words_PERFECT");
ReplaceWord("Words_Grabbed", "Words_GRABBED");
ReplaceWord("Words_Percent", "Words_PERCENT");
ReplaceWord("Words_Boulder", "Words_BOULDER");
ReplaceWord("Words_Falling", "Words_FALLING");
ReplaceWord("Words_Loading", "Words_LOADING");
ReplaceWord("Words_Accept", "Words_ACCEPT");
ReplaceWord("Words_Custom", "Words_CUSTOM");
ReplaceWord("Words_Random", "Words_RANDOM");
ReplaceWord("Words_Lining", "Words_LINING");
ReplaceWord("Words_Cancel", "Words_CANCEL");
ReplaceWord("Words_Silver", "Words_SILVER");
ReplaceWord("Words_Indigo", "Words_INDIGO");
ReplaceWord("Words_Purple", "Words_PURPLE");
ReplaceWord("Words_Orange", "Words_ORANGE");
ReplaceWord("Words_Yellow", "Words_YELLOW");
ReplaceWord("Words_Rugged", "Words_RUGGED");
ReplaceWord("Words_Goatee", "Words_GOATEE");
ReplaceWord("Words_Viking", "Words_VIKING");
ReplaceWord("Words_Fedora", "Words_FEDORA");
ReplaceWord("Words_Bubble", "Words_BUBBLE");
ReplaceWord("Words_Reggae", "Words_REGGAE");
ReplaceWord("Words_Wizard", "Words_WIZARD");
ReplaceWord("Words_Bungee", "Words_BUNGEE");
ReplaceWord("Words_Length", "Words_LENGTH");
ReplaceWord("Words_Clouds", "Words_CLOUDS");
ReplaceWord("Words_Lasers", "Words_LASERS");
ReplaceWord("Words_Spikes", "Words_SPIKES");
ReplaceWord("Words_Sludge", "Words_SLUDGE");
ReplaceWord("Words_Jetman", "Words_JETMAN");
ReplaceWord("Words_Bouncy", "Words_BOUNCY");
ReplaceWord("Words_Forest", "Words_FOREST");
ReplaceWord("Words_Castle", "Words_CASTLE");
ReplaceWord("Words_Resume", "Words_RESUME");
ReplaceWord("Words_Hooray", "Words_HOORAY");
ReplaceWord("Words_Deaths", "Words_DEATHS");
ReplaceWord("Words_Global", "Words_GLOBAL");
ReplaceWord("Words_Paused", "Words_PAUSED");
ReplaceWord("Words_Single", "Words_SINGLE");
ReplaceWord("Words_Right", "Words_RIGHT");
ReplaceWord("Words_Reset", "Words_RESET");
ReplaceWord("Words_Color", "Words_COLOR");
ReplaceWord("Words_Beard", "Words_BEARD");
ReplaceWord("Words_White", "Words_WHITE");
ReplaceWord("Words_Black", "Words_BLACK");
ReplaceWord("Words_Brown", "Words_BROWN");
ReplaceWord("Words_Green", "Words_GREEN");
ReplaceWord("Words_Ninja", "Words_NINJA");
ReplaceWord("Words_Clear", "Words_CLEAR");
ReplaceWord("Words_Horns", "Words_HORNS");
ReplaceWord("Words_Start", "Words_START");
ReplaceWord("Words_Shape", "Words_SHAPE");
ReplaceWord("Words_Hills", "Words_HILLS");
ReplaceWord("Words_Cloud", "Words_CLOUD");
ReplaceWord("Words_Score", "Words_SCORE");
ReplaceWord("Words_Level", "Words_LEVEL");
ReplaceWord("Words_Ready", "Words_READY");
ReplaceWord("Words_Press", "Words_PRESS");
ReplaceWord("Words_Jumps", "Words_JUMPS");
ReplaceWord("Words_Coins", "Words_COINS");
ReplaceWord("Words_Blobs", "Words_BLOBS");
ReplaceWord("Words_Spike", "Words_SPIKE");
ReplaceWord("Words_Laser", "Words_LASER");
ReplaceWord("Words_Other", "Words_OTHER");
ReplaceWord("Words_Total", "Words_TOTAL");
ReplaceWord("Words_Local", "Words_LOCAL");
ReplaceWord("Words_Speed", "Words_SPEED");
ReplaceWord("Words_Pause", "Words_PAUSE");
ReplaceWord("Words_Exit", "Words_EXIT");
ReplaceWord("Words_Left", "Words_LEFT");
ReplaceWord("Words_Down", "Words_DOWN");
ReplaceWord("Words_Back", "Words_BACK");
ReplaceWord("Words_Menu", "Words_MENU");
ReplaceWord("Words_Done", "Words_DONE");
ReplaceWord("Words_Cape", "Words_CAPE");
ReplaceWord("Words_Gray", "Words_GRAY");
ReplaceWord("Words_Cyan", "Words_CYAN");
ReplaceWord("Words_Blue", "Words_BLUE");
ReplaceWord("Words_Teal", "Words_TEAL");
ReplaceWord("Words_Gold", "Words_GOLD");
ReplaceWord("Words_None", "Words_NONE");
ReplaceWord("Words_Afro", "Words_AFRO");
ReplaceWord("Words_Halo", "Words_HALO");
ReplaceWord("Words_Gosu", "Words_GOSU");
ReplaceWord("Words_Game", "Words_GAME");
ReplaceWord("Words_Hero", "Words_HERO");
ReplaceWord("Words_Base", "Words_BASE");
ReplaceWord("Words_Jump", "Words_JUMP");
ReplaceWord("Words_Play", "Words_PLAY");
ReplaceWord("Words_Test", "Words_TEST");
ReplaceWord("Words_Next", "Words_NEXT");
ReplaceWord("Words_Size", "Words_SIZE");
ReplaceWord("Words_Cave", "Words_CAVE");
ReplaceWord("Words_Lava", "Words_LAVA");
ReplaceWord("Words_Blob", "Words_BLOB");
ReplaceWord("Words_Step", "Words_STEP");
ReplaceWord("Words_Yes", "Words_YES");
ReplaceWord("Words_Off", "Words_OFF");
ReplaceWord("Words_Hat", "Words_HAT");
ReplaceWord("Words_Use", "Words_USE");
ReplaceWord("Words_Red", "Words_RED");
ReplaceWord("Words_Sea", "Words_SEA");
ReplaceWord("Words_All", "Words_ALL");
ReplaceWord("Words_End", "Words_END");
ReplaceWord("Words_No", "Words_NO");
ReplaceWord("Words_On", "Words_ON");
ReplaceWord("Words_Up", "Words_UP");
ReplaceWord("Words_Go", "Words_GO");
ReplaceWord("Words_Oh", "Words_OH");
		}
	}
}
