using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeCreator : MonoBehaviour, IInteractable
{
	public bool canInteract {
		get { return true; }
	}

	[SerializeField] private IntVariable type;
	[SerializeField] private int price;

	[SerializeField] private GameObject _barricade;
	[SerializeField] private Transform _barricadePos;

	public void Interact() {
		if (type.Value < price) return;
		type.Value -= price;
		Instantiate(_barricade, _barricadePos);
	}
}
