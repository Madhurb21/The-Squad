using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletB : MonoBehaviour
{
    private Vector3 bulletDirection;
    public float speed;
    public float destroyTime;
    private float bulletTimePassed = 0;
    private Rigidbody2D rb;
    private Transform bulletTransform;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletTransform = GetComponent<Transform>();

        bulletDirection = bulletTransform.up;
    }

    private void Update() 
    {
        bulletTimePassed += Time.deltaTime;
        if(bulletTimePassed > destroyTime)
        {
            Destroy(this.gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = bulletDirection.normalized * speed;
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "boundary")
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "zombie")
        {
            Destroy(this.gameObject);
        }
    }
}
