using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    Animator anim;    

    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(moveX, moveY).normalized * speed;
        if(rb.linearVelocity.magnitude > 0f)
        {
            anim.SetBool("Walks", true);
        }
        else
        {
            anim.SetBool("Walks", false);
            
        }
    }
}
