using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bloodSplat;
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
            if(other.gameObject.tag == "Player")
            {
                killedByCar();
            }
    }

    void TakeDamage(int damage){
        currentHealth-=damage;

        zombieHealth.SetHealth(currentHealth);
    }
    public void killedByCar()
    {
        currentHealth = 0;
    }
    private void Update() 
    {
        if(currentHealth <= 0)
        {
            FindObjectOfType<HealthRefill>().zombieKilled();
            Instantiate(bloodSplat, transform.position, Quaternion.identity);
            FindObjectOfType<SplatSound>().zombieKillSound();
            Destroy(this.gameObject);
        }
    }
}
