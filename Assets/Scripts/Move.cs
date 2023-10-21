using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	private IInput _input;

	[SerializeField] private float _maxVelocity;
	[SerializeField] private float _acceleration;
	private Vector2 velocity;

	private void Awake() {
		_input = GetComponent<IInput>();
	}

	private void Update() {
		Vector2 goalVel = _input.direction * _maxVelocity;
		Vector2 diff = goalVel - velocity;
		velocity += Vector2.ClampMagnitude(diff, _acceleration);

		transform.position += (Vector3)velocity * Time.deltaTime;
	}
}
