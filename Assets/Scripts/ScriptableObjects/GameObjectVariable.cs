using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameObjectVariable : ScriptableObject
{
	public GameObject Value;

	[Tooltip("If true, Value will be reset on awake and on application quit")]
	public bool isVolatile;

	private void OnEnable() {
		if (isVolatile) Value = null;
	}

	private void OnApplicationQuit() {
		if (isVolatile) Value = null;
	}
}
