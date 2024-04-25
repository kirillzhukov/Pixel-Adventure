using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _player_rb;
	[SerializeField] private int _jumpForce = 27;

	private Animator m_Anim;
	private float collisionAngleThreshold = 0.5f;

	// Start is called before the first frame update
	void Start()
    {
		m_Anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
		

	    if (other.gameObject.CompareTag("Player"))
	    {
		    Vector2 normal = other.contacts[0].normal;
		    Vector2 downDirection = new Vector2(0, -1);

		    float angle = Vector2.Dot(normal, downDirection);

		    if (angle > collisionAngleThreshold)
		    {
				m_Anim.SetBool("Jump", true);
				_player_rb.velocity = new Vector2(_player_rb.velocity.x, _jumpForce);
			}
			
		}
    }
    public void EndJumpAnimation()
    {

	    m_Anim.SetBool("Jump", false);

    }
}
