using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTrap : MonoBehaviour, IInteractable
{
	public bool canInteract {
		get { return true; }
	}

	[SerializeField] private GameObject _trapPrefab;
	[SerializeField] private Transform _placePosition;

	public void Interact() {
		Instantiate(_trapPrefab, _placePosition.position, Quaternion.identity);
		gameObject.SetActive(false);
	}
}
