using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDayNightEffects : MonoBehaviour
{
	public Color dayLight;
	public Color dayDark;
	public Color nightLight;
	public Color nightDark;

	public SpriteRenderer darkness;

	public void ChangeToDay() {
		Camera.main.backgroundColor = dayDark;
		darkness.color = dayDark;
	}

	public void ChangeToNight() {
		Camera.main.backgroundColor = nightDark;
		darkness.color = nightDark;
	}
}
