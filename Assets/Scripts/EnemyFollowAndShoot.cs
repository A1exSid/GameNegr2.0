using UnityEngine;

public class EnemyFollowAndShoot : MonoBehaviour
{
    public Transform player;

    public float speed = 3f;
    public float stopDistance = 5f;

    public GameObject fireballPrefab;
    public Transform firePoint;

    public float shootCooldown = 1f;

    private float shootTimer;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        // Если игрок далеко — идём к нему
        if (distance > stopDistance)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
        // Если близко — стоим и стреляем
        else
        {
            shootTimer -= Time.deltaTime;

            if (shootTimer <= 0)
            {
                Shoot();
                shootTimer = shootCooldown;
            }
        }
    }

    void Shoot()
    {
        Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);
    }
}

