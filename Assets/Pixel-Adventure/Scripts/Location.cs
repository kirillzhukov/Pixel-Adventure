using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Location : MonoBehaviour
{
	[SerializeField] private Transform _respawnPoint;
    private Transform m_PlayerTransform;

    // Start is called before the first frame update
    //void Start()
    //{
    // _playerTransform.position = _respawnPoint.position;
    //}
    [Inject]
    private void Construct(SupanthaPaul.PlayerController playerController)
    {
	    m_PlayerTransform = playerController.transform;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
	    m_PlayerTransform.position = _respawnPoint.position;
	}
}
