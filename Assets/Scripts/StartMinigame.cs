using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour, IInteractable
{
	[SerializeField] private Generator _gen;

	public bool canInteract {
		get { return _gen.type.Value >= _gen.price; }
	}

	public void Interact() {
		Debug.Log("b");
		_gen.Begin();
	}
}
