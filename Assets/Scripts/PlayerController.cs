using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(moveX, moveY).normalized * speed;
    }
}
