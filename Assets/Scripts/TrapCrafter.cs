using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCrafter : MonoBehaviour, IInteractable
{
	public bool canInteract {
		get { return true; }
	}

	[SerializeField] private IntVariable _material;
	[SerializeField] private int _price;

	[SerializeField] private GameObject _playerTrap;

	public void Interact() {
		if (_material.Value < _price) return;
		_material.Value -= _price;

		_playerTrap.SetActive(true);
	}
}
