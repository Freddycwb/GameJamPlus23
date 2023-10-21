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
			Collect();
		}
	}

	private void Collect() {
		Lootable lootable = lastCollision.GetComponent<Lootable>();
		Debug.Log(lootable.type);
		Debug.Log(lootable.quantity);
		int typeInt = (int)(lootable.type) - 1;
		if (typeInt >= 0 && typeInt < materials.Count) {
			materials[typeInt].Value += lootable.quantity;
		}
	}
}
