using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTravelled : MonoBehaviour
{
    private int distance;
    public float winDistance = 1000;
    private Transform playerTransform;
    public Text distanceText;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }
    void Update()
    {
        distance = (int)playerTransform.position.y;
        distanceText.text = "Distance: " + distance;
        if(distance >= winDistance)
        {
            FindObjectOfType<sceneManager>().gameWon();
        }
    }

    
}
