using GTAG_NotificationLib;
using GorillaLocomotion;
using HarmonyLib;
using MalachiTemp.Backend;
using MalachiTemp.UI;
using UnityEngine;

namespace Malachis_Temp;

[HarmonyPatch(typeof(GTPlayer), "FixedUpdate")]
internal class UpdatePatch
{
	private static bool a;

	public static GameObject g;

	private static void Postfix()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		if (!a)
		{
			a = true;
			g = new GameObject();
			g.AddComponent<Plugin>();
			g.AddComponent<WristMenu>();
			g.AddComponent<CR>();
			g.AddComponent<RigShit>();
			g.AddComponent<Mods>();
			g.AddComponent<GhostPatch>();
			g.AddComponent<NotifiLib>();
			Mods.Load();
			Mods.Load1();
			Mods.LoadFavs();
			Object.DontDestroyOnLoad((Object)(object)g);
		}
	}
}
