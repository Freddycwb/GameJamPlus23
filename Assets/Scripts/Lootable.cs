using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lootable : MonoBehaviour, IInteractable
{
	public ChangeColorSprite cco;
	public InvokeAfterCollision iac;

	public bool canInteract {
		get { return enabled; }
		set { canInteract = value; }
	}

	public IntVariable type;

	[Tooltip("Randomizes the quantity between x and y")]
	[SerializeField] private Vector2 quantityRange;
	private int quantity;

	public UnityEvent LootEvent;

	private void OnEnable() {
		quantity = Random.Range((int)quantityRange.x, (int)quantityRange.y + 1);
	}

	public void Interact() {
		type.Value += quantity;
		cco.Normal();
		cco.Darken();
		cco.enabled = false;
		Destroy(iac);
		LootEvent?.Invoke();
		enabled = false;
	}
}
