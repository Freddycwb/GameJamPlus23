using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
	public int Value;
	public int defaultValue;

	[Tooltip("If true, Value will be reset on awake and on application quit")]
	public bool isVolatile;

	private void OnEnable() {
		if (isVolatile) Value = defaultValue;
	}

	private void OnApplicationQuit() {
		if (isVolatile) Value = defaultValue;
	}

	public void SetValue(int newValue) {
		Value = newValue;
	}

	public void DecreaseValue() {
		Value--;
	}
}
