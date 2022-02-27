using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRefill : MonoBehaviour
{
    public int refillValue;
    private int currHealth;
    private int zombieKillCount = 0;
    public int refillAfter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(zombieKillCount >= refillAfter)
        {
            healthRefill();
            zombieKillCount = 0;
        }
    }

    public void zombieKilled()
    {
        zombieKillCount++;
    }
    public void healthRefill()
    {
        FindObjectOfType<Player>().currentHealth += refillValue;
        FindObjectOfType<Player>().Refill();
    }
}
