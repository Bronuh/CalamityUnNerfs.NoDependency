﻿using CalamityUnNerfs.Config;
using CalamityMod.ILEditing;
using MonoMod.RuntimeDetour.HookGen;
using System.Reflection;
using System;
using Terraria;

namespace CalamityUnNerfs.UnNerfs;
/*
internal class Teleporters : BaseUnNerf
{
	protected override bool Active(UnNerfsConfig config) => config.Teleporters;

	protected override void Apply()
	{
		var origT = typeof(Wiring);
		var origM = origT.GetMethod("Teleport", BindingFlags.Static | BindingFlags.NonPublic);
		var modT = typeof(ILChanges);
		var modM = modT.GetMethod("DisableTeleporters", BindingFlags.Static | BindingFlags.NonPublic);
		if (modM != null)
		{
			Delegate del = modM.CreateDelegate(typeof(global::On.Terraria.Wiring.hook_Teleport));
			HookEndpointManager.Remove(origM, del);
		}
		else
		{
			Logger.Warn("Unable to apply Teleporters unnerf");
		}	
	}

	protected override void Revert()
	{}
}
*/