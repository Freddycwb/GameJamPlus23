using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
	public GameEvent Event;
	public UnityEvent Response;

	public void OnEventRaised() {
		Response.Invoke();
	}

	private void OnEnable() {
		Event.Listen(this);
	}

	private void OnDestroy() {
		Event.StopListening(this);
	}
}
