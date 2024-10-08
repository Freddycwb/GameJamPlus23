using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
	Vector2 direction { get; set; }

	bool fireDown { get; }
	bool interactDown { get; }
}
