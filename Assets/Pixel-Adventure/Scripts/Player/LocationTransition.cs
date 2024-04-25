using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTransition : MonoBehaviour
{
	[SerializeField] private Location _currentLocation;
	[SerializeField] private GameObject _hub;
	[SerializeField] private GameObject _level1;
	[SerializeField] private GameObject _level2;
	[SerializeField] private GameObject _level3;
	[SerializeField] private GameObject _level4;
	[SerializeField] private GameObject _level5;

	private bool m_CanTransition = false;
	//private GameObject m_CurrentLocation;
	private Location m_TriggeringLocation;

	private void Start()
	{
		//m_CurrentLocation = _hub;
		_currentLocation.RespawnPlayer();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && m_CanTransition)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				//_currentLocation.SetActive(false);
				//switch (m_TriggeringTag)
				//{
				//	case "Level1":
				//		_currentLocation = _level1;
				//		_currentLocation.GetComponent<Location>().RespawnPlayer();
				//		break;
				//	case "Level2":
				//		_currentLocation = _level2;
				//		_currentLocation.GetComponent<Location>().RespawnPlayer();
				//		break;
				//	case "Level3":
				//		_currentLocation = _level3;
				//		_currentLocation.GetComponent<Location>().RespawnPlayer();
				//		break;
				//	case "Level4":
				//		_currentLocation = _level4;
				//		_currentLocation.GetComponent<Location>().RespawnPlayer();
				//		break;
				//	case "Level5":
				//		_currentLocation = _level5;
				//		_currentLocation.GetComponent<Location>().RespawnPlayer();
				//		break;
				//}
				_currentLocation = m_TriggeringLocation;
				_currentLocation.RespawnPlayer();
				LevelEvents.SendLevelSwicth();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		//if (other.CompareTag("Level1"))
		//{
		//	m_CanTransition = true;
		//	m_TriggeringTag = other.tag;
		//}
		//else if (other.CompareTag("Level2"))
		//{
		//	m_CanTransition = true;
		//	m_TriggeringTag = other.tag;
		//}
		if (other.CompareTag("Door"))
		{
			m_CanTransition = true;
			m_TriggeringLocation = other.GetComponent<Door>().GetLocation();
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Door"))
		{
			m_CanTransition = false;
		}
	}

	public Vector2 GetCurrentLevelPos()
	{
		return _currentLocation.transform.position;
	}
}
