using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartMinigame : MonoBehaviour, IInteractable
{
	[SerializeField] private Generator _gen;
	public UnityEvent MinigameEvent;

	public bool canInteract {
		get { return _gen.type.Value >= _gen.price; }
	}

	public void Interact() {
		_gen.Begin();
		MinigameEvent?.Invoke();
	}
}
