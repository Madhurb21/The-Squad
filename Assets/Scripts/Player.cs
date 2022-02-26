using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int damageToCar=20;
    public int maxHealth=100;
    public int currentHealth;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(damageToCar);
        }
    }*/

    void OnTriggerEnter2D(Collider2D other){
        //Debug.Log("Hit");
        //TakeDamage(damag);
            if(other.gameObject.tag == "Zombie"){
                //Debug.Log("Hit");
                TakeDamage(damageToCar);
                Destroy(other.gameObject);
            }
    }

    void TakeDamage(int damage){
        currentHealth-=damage;

        healthBar.SetHealth(currentHealth);
    }
}
