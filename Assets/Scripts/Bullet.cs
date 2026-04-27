using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage = 5f;  
    [SerializeField] private float destroyDelay = 0.1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Negr");
        Helthbar player = collision.gameObject.GetComponent<Helthbar>();
        
        if(player!= null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject, destroyDelay);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
