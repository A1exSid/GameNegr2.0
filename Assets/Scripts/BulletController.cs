using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] GameObject prefabBullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float speedBullet = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefabBullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Vector2 direction = (mousePos - firePoint.position).normalized;
        rb.linearVelocity = direction * speedBullet;

        Destroy (bullet, 5f);
    }
}
