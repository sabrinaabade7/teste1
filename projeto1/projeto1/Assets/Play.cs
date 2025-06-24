using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float checkRadius = 0.2f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento horizontal
        float inputX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);

        // Verificar se está tocando o chão
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        // Pulo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
    }

    void OnDrawGizmos()
    {
        // Visualização da área de verificação do chão no editor
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
    }
}