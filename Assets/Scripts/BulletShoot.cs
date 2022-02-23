using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private Transform turretTransform;
    private float timePassed = 0f;
    public float bulletTime;
    public GameObject bullet;
    public AudioSource bulletSound;
    void Start()
    {
        turretTransform = GetComponent<Transform>();
    }
    void Update()
    {
        timePassed += Time.deltaTime;
        if(Input.GetKey(KeyCode.Space) && (timePassed > bulletTime))
        {
            Shoot();
            timePassed = 0;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playSound();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Invoke("pauseSound", 0.1f);
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, turretTransform.position, turretTransform.rotation);
    }
    private void playSound()
    {
        bulletSound.Play();
    }
    private void pauseSound()
    {
        bulletSound.Pause();
    }
}

