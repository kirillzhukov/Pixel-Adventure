using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CameraFollow : MonoBehaviour
{
	private LocationTransition m_LocationTransition;

	private GameObject _currentLevel;

    [Inject]
	private void Construct(LocationTransition locationTransition)
	{
        m_LocationTransition = locationTransition;
	}

    // Start is called before the first frame update
    void Start()
    {
		LevelEvents.OnLevelSwitch.AddListener(ChangePosition);
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangePosition()
    {
	    transform.position = new Vector3(m_LocationTransition.GetCurrentLevelPos().x, m_LocationTransition.GetCurrentLevelPos().y, transform.position.z);
    }
}
