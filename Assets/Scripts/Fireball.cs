using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 7f;
    [SerializeField] private float damage = 5f;
    [SerializeField] private float destroyDelay = 0.1f;

    private Transform player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
             Helthbar player = other.gameObject.GetComponent<Helthbar>();
        
            if(player!= null)
            {
                 player.TakeDamage(damage);
            }
            Destroy(gameObject,destroyDelay);
        }
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       Destroy(gameObject, 3f);
    }

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }
}
