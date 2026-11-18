using System.Collections;
using UnityEngine;

namespace MalachiTemp.Backend;

public class CR : MonoBehaviour
{
	public static CR instance;

	private void Awake()
	{
		instance = this;
	}

	public static Coroutine Start(IEnumerator e)
	{
		return ((MonoBehaviour)instance).StartCoroutine(e);
	}
}
