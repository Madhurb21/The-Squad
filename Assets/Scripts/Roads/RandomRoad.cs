using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRoad : MonoBehaviour
{
    public Sprite[] roadType;
    private int randomNum;
    void Start()
    {
        randomNum = Random.Range(0, roadType.Length);
        GetComponent<SpriteRenderer>().sprite = roadType[randomNum];   
    }
    void Update()
    {
        
    }
}
