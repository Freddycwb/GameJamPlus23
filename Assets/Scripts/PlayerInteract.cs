using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
	public UnityEvent InteractEvent;

	[SerializeField] private PlayerInput _input;
	private GameObject currentCollision;

	private void OnTriggerStay2D(Collider2D other) {
		currentCollision = other.gameObject;
	}

	private void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject == currentCollision) currentCollision = null;
	}

	private void Update() {
		if (_input.interactDown && currentCollision != null) {
			IInteractable interactable = currentCollision.GetComponent<IInteractable>();
			if (interactable.canInteract) {
				interactable.Interact();
				InteractEvent?.Invoke();
			}
		}
	}
}
