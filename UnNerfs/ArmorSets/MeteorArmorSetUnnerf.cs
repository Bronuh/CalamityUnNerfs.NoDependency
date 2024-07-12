﻿using CalamityMod.CalPlayer;
using CalamityUnNerfs.Config;
using CalamityUnNerfs.IL;
using Mono.Cecil.Cil;
using MonoMod.Cil;

namespace CalamityUnNerfs.UnNerfs.ArmorSets;

internal class MeteorArmorSetUnnerf : BaseUnNerf
{
	public override bool Active(UnNerfsConfig config) => config.MeteorArmorSet;

	public override void LateApply()
	{
		base.LateApply();
		IlCalPlayer.ForceVariousEffects += IlCalPlayer_ForceVariousEffects;
	}

	private void IlCalPlayer_ForceVariousEffects(ILContext il)
	{
		var cursor = new ILCursor(il);
		if (!cursor.TryGotoNext(MoveType.After,
			i => i.MatchLdfld<CalamityPlayer>("meteorSet")
			))
		{
			CalamityFly.Instance.Logger.Warn("unable to edit IlCalPlayer_ForceVariousEffects (error:1)");
			return;
		}
		if (!cursor.TryGotoNext(MoveType.Before,
			i => i.Match(OpCodes.Ldc_I4_0)
			))
		{
			CalamityFly.Instance.Logger.Warn("unable to edit IlCalPlayer_ForceVariousEffects (error:2)");
			return;
		}
		cursor.Remove();
		cursor.Emit(OpCodes.Ldc_I4_1);
	}

	public override void Revert()
	{
		IlCalPlayer.ForceVariousEffects -= IlCalPlayer_ForceVariousEffects;
	}
}
