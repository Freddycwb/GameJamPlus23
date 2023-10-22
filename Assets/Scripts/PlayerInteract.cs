using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
	[SerializeField] private List<IntVariable> materials;

	[SerializeField] private PlayerInput _input;
	private GameObject lastCollision;

	private void OnTriggerEnter2D(Collider2D other) {
		lastCollision = other.gameObject;
	}

	private void OnTriggerExit2D() {
		lastCollision = null;
	}

	private void Update() {
		if (_input.interactDown && lastCollision != null) {
			Collect(lastCollision.GetComponent<Lootable>());
		}
	}

	private void Collect(Lootable lootable) {
		if (!lootable.enabled) return;

		int typeInt = (int)(lootable.type) - 1;
		if (typeInt >= 0 && typeInt < materials.Count) {
			materials[typeInt].Value += lootable.quantity;
			lootable.enabled = false;
		} else {
			Debug.LogError($"loot type enum of {lastCollision.name} is not in the list of type enums");
		}
	}
}
