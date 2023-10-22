using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public IntVariable type;
	public int price;

	[SerializeField] private GameObject _minigame;
	[SerializeField] private GameObject _startArea;
	[SerializeField] private GameObject _leaveArea;
	[SerializeField] private Move _playerMove;

	public void OnMinigameCorrect() {
		type.Value -= price;
		if (type.Value < price) {
			Leave();
		}
	}

	public void Leave() {
		_minigame.SetActive(false);
		_startArea.SetActive(true);
		_playerMove.enabled = true;
		_leaveArea.SetActive(false);
	}

	public void Begin() {
		_minigame.SetActive(true);
		_leaveArea.SetActive(true);
		_playerMove.enabled = false;
		_startArea.SetActive(false);
	}
}
