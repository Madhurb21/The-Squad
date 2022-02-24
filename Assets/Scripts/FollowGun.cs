using UnityEngine;

public class FollowGun : MonoBehaviour
{
    
        public Transform Gun;
        public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, Gun.position.y, 0) + offset;
    }
}
