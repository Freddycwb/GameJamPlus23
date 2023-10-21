using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
	public float Value;

	[Tooltip("If true, Value will be reset on awake and on application quit")]
	public bool isVolatile;

	private void OnEnable() {
		if (isVolatile) Value = 0;
	}

	private void OnApplicationQuit() {
		if (isVolatile) Value = 0;
	}
}
