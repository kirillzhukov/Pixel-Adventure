using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float doubleJumpForce = 5f;
    private bool isJumping = false;
    private bool isDoubleJumping = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Перемещение влево и вправо
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        // Прыжок
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
        // Двойной прыжок
        else if (Input.GetButtonDown("Jump") && isJumping && !isDoubleJumping)
        {
            rb.AddForce(new Vector2(0f, doubleJumpForce), ForceMode2D.Impulse);
            isDoubleJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Сброс состояния прыжков при касании земли
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            isDoubleJumping = false;
        }
    }
}
