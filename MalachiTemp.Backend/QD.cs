using HarmonyLib;

namespace MalachiTemp.Backend;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
public class QD
{
	private static bool Prefix()
	{
		return false;
	}
}
