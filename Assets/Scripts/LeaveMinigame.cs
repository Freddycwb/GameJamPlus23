using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveMinigame : MonoBehaviour, IInteractable
{
	[SerializeField] private Generator _gen;

	public bool canInteract {
		get { return true; }
	}

	public void Interact() {
		_gen.Leave();
	}
}
