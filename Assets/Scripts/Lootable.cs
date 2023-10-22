using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootable : MonoBehaviour
{
	public LootType type;

	[Tooltip("Randomizes the quantity between x and y")]
	public Vector2 quantityRange;
	[HideInInspector] public float quantity;

	private void OnEnable() {
		quantity = Random.Range((int)quantityRange.x, (int)quantityRange.y + 1);
	}
}
