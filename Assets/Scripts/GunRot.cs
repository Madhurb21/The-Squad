using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRot : MonoBehaviour
{
    private Transform gunTransform;
    private Vector3 rotationVector = new Vector3(0, 0, 1);
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        gunTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            gunTransform.Rotate(rotationSpeed * rotationVector * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            gunTransform.Rotate(rotationSpeed * (-rotationVector) * Time.deltaTime);
        }
    }
}
