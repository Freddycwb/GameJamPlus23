using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

	[SerializeField] private TextMeshPro text;
	public Vector3 offset;

	[SerializeField] private GameObject timerText;

	private void Start() {
		arrow.target = door;
		arrow.gameObject.SetActive(true);
		text.text = "It's Daytime, Go Outside";
		text.transform.position = arrow.target.position + offset;
	}

	public void OnDoorReached(int houseNumber) {
		if (!enteredNeighbour) {
			arrow.target = loot[houseNumber];
			enteredNeighbour = true;
			text.text = "Gather Resources\nE to Interact";
			text.transform.position = arrow.target.position + offset;
		}
	}

	public void OnInteract() {
		if (enteredNeighbour && !started) {
			startedEvent.Raise();
			arrow.gameObject.SetActive(false);
			started = true;
			text.text = "";
			timerText.SetActive(true);
		}
	}

	public void OnDayIsOver() {
		if (enteredNeighbour && started && !nightStarted) {
			arrow.target = plant;
			arrow.gameObject.SetActive(true);
			nightStarted = true;
			text.text = "Take Care of it\nThey Want to Destroy it";
			text.transform.position = arrow.target.position + offset;
			timerText.SetActive(false);
		}
	}

	public void OnPlantInteracted() {
		if (enteredNeighbour && started && nightStarted && !plantInteracted) {
			arrow.gameObject.SetActive(false);
			plantInteracted = true;
			text.text = "";
		}
	}
}
