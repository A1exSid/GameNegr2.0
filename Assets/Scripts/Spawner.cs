using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }


     IEnumerator Spawn()
    {
        while(true)
        {
            float delay = Random.Range(3f, 6f );
            yield return new WaitForSeconds(delay);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
