using UnityEngine;

public class FollowGun : MonoBehaviour
{
    
        public Transform Gun;
        public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Gun.position + offset;
    }
}
