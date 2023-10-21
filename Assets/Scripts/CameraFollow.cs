using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private Transform _target;
	[SerializeField] private float _movePercentage;
	private float _minMove = 0.01f;

	private void Update() {
		Vector2 move = Vector2.Lerp(transform.position, _target.position, _movePercentage) - (Vector2)transform.position;
		if ((move - (Vector2)transform.position).magnitude < _minMove) {
			move = Vector2.ClampMagnitude(_target.position - transform.position, _minMove);
		}

		transform.position += (Vector3)move;
	}
}
