using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damageToZombie=20;
    public int maxHealth=100;
    public int currentHealth;

    public ZombieHealth zombieHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        zombieHealth.SetMaxHealth(maxHealth);
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
            if(other.gameObject.tag == "Bullet"){
                //Debug.Log("Hit");
                TakeDamage(damageToZombie);
                //Destroy(other.gameObject);
            }
    }

    void TakeDamage(int damage){
        currentHealth-=damage;

        zombieHealth.SetHealth(currentHealth);
    }
}
