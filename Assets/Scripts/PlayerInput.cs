using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IInput
{
	public Vector2 direction {
		get {
			Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
			return move.normalized;
		}
		set {
			direction = value;
		}
	}
}
