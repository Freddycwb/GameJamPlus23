using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootable : MonoBehaviour, IInteractable
{
	public bool canInteract {
		get { return enabled; }
		set { canInteract = value; }
	}

	public IntVariable type;

	[Tooltip("Randomizes the quantity between x and y")]
<<<<<<< HEAD
	public Vector2 quantityRange;
	[HideInInspector] public int quantity;
=======
	[SerializeField] private Vector2 quantityRange;
	private float quantity;
>>>>>>> aca831e (Craft)

	private void OnEnable() {
		quantity = Random.Range((int)quantityRange.x, (int)quantityRange.y + 1);
	}

	public void Interact() {
		type.Value += quantity;
		enabled = false;
	}
}
