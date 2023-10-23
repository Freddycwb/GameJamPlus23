using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	[SerializeField] private TutorialArrow arrow;
	[SerializeField] private Transform door;

	private bool started = false;
	[SerializeField] private GameEvent startedEvent;

	private void Start() {
		arrow.target = door;
		arrow.gameObject.SetActive(true);
	}

	public void OnDoorReached() {
		if (!started) {
			startedEvent.Raise();
			arrow.gameObject.SetActive(false);
			started = true;
		}
	}
}
