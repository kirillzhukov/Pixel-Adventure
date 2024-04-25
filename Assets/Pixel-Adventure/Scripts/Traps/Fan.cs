using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _player_rb;
	[SerializeField] private float _fanForce = 7f;

	private Vector2 m_FanDirection;
    private Transform m_FanTransform;

    // Start is called before the first frame update
    void Start()
    {
		m_FanTransform = GetComponent<Transform>();

		m_FanDirection = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
	    if (other.gameObject.CompareTag("Player"))
	    {
			//_player_rb.velocity = m_FanDirection * _fanForce;

			Vector2 fanDirection = Vector2.zero; 

			float angle = transform.rotation.eulerAngles.z;

			if (angle == 0f)
				fanDirection = Vector2.up;
			else if (angle == 90f)
				fanDirection = Vector2.left; 
			else if (angle == 180f)
				fanDirection = Vector2.down; 
			else if (angle == 270f)
				fanDirection = Vector2.right; 

			Vector2 targetVelocity = fanDirection * _fanForce;
			_player_rb.AddForce(targetVelocity, ForceMode2D.Force);
			//_player_rb.velocity = targetVelocity;
		}
    }
}
