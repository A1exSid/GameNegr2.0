using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Image healthBar;
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float HP; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar = GetComponent<Image>();
         HP = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = HP / maxHealth;
    }
    
}
