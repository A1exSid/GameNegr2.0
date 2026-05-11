using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 7f;
    [SerializeField] private float damage = 5f;
    [SerializeField] private float destroyDelay = 0.1f;
    private Transform enemy;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Helthbar player = other.gameObject.GetComponent<Helthbar>();
        
            if(player!= null)
            {
                 player.TakeDamage(damage);
            }
            
            Destroy(gameObject);
           
        }
    }
     void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Player").transform;
       Destroy(gameObject, 3f);
    }

    void Update()
    {
        if (enemy != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                enemy.position,
                speed * Time.deltaTime
            );
             
        }
    }
}
