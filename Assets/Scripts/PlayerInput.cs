using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IInput
{
	public GameObjectVariable player;

    private void Start()
    {
		player.Value = gameObject;
    }

    public Vector2 direction {
		get {
			Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
			return move.normalized;
		}
		set {
			direction = value;
		}
	}

	public bool fireDown {
		get {
			return Input.GetMouseButtonDown(0);
		}
	}

	public bool interactDown {
		get {
			return Input.GetKeyDown(KeyCode.E);
		}
	}
}
