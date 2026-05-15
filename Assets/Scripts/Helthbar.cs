
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Helthbar : MonoBehaviour
{

    [SerializeField] Image healthBar;
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float HP; 
     [SerializeField]GameObject panel; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
         HP = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            HP = 0;
            if(gameObject.tag == "Player")
            {
                panel.SetActive(true);
            Time.timeScale = 0;
            }
            else{
                Destroy(gameObject);
            }
            
           
        }
       
       
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = HP / maxHealth;
    }
}
