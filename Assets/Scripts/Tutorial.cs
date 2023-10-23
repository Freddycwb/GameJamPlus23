using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	[SerializeField] private TutorialArrow arrow;
	[SerializeField] private Transform door;

	[SerializeField] private List<Transform> loot = new List<Transform>();

	private bool enteredNeighbour = false;
	[SerializeField] private GameEvent startedEvent;

	private bool started = false;

	private bool nightStarted = false;
	[SerializeField] private Transform plant;

	private bool plantInteracted = false;

	private void Start() {
		arrow.target = door;
		arrow.gameObject.SetActive(true);
	}

	public void OnDoorReached(int houseNumber) {
		if (!enteredNeighbour) {
			arrow.target = loot[houseNumber];
			enteredNeighbour = true;
		}
	}

	public void OnInteract() {
		if (enteredNeighbour && !started) {
			startedEvent.Raise();
			arrow.gameObject.SetActive(false);
			started = true;
		}
	}

	public void OnDayIsOver() {
		if (enteredNeighbour && started && !nightStarted) {
			arrow.target = plant;
			arrow.gameObject.SetActive(true);
			nightStarted = true;
		}
	}

	public void OnPlantInteracted() {
		if (enteredNeighbour && started && nightStarted && !plantInteracted) {
			arrow.gameObject.SetActive(false);
			plantInteracted = true;
		}
	}
}
