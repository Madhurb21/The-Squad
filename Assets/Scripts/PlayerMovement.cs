using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

public Rigidbody2D rb;
public float forwardforce = 200f;
public float speed = 5f ;


    // Update is called once per frame
    void FixedUpdate()
    {

        rb.velocity=new Vector3(rb.velocity.x,forwardforce*Time.deltaTime,0);
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal,0,0);
        gameObject.transform.Translate(direction.normalized*Time.deltaTime*speed);
    }}