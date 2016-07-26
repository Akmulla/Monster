using UnityEngine;
using System.Collections;

public class ControllerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 movement=Vector2.zero;
    public float speed;
    public float rotationSpeed;
    private ControllerReaction controllerReaction;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controllerReaction = GetComponent<ControllerReaction>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }


    void FixedUpdate()
    {
        if (!controllerReaction.stunned)
        {
            rb.velocity = movement;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    void Move()
    {
        Touch myTouch;
        if (Input.touchCount > 0)
        {
            myTouch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(myTouch.position);
            touchPosition.z = 0;

            //transform.position = Vector3.Lerp(transform.position, touchPosition, speed);
            

            Vector3 moveDirection = touchPosition - transform.position;
            if (moveDirection.magnitude > 0.2f)
            {
                movement = moveDirection.normalized * speed;
            }
            else
            {
                movement = Vector2.zero;
            }
            //float angle = Mathf.Atan2(moveDirection.x, -moveDirection.y) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed);

        }
        else
        {
            movement = Vector2.zero;
        }
    }

    
}
