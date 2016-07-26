using UnityEngine;
using System.Collections;

public class ControllerReaction : MonoBehaviour
{
    public bool stunned;
    public float stunDuration;
    public GameObject Boss;
    private Flip flip;
    private BossInfo bossInfo;
    private Animator anim;
    private ControllerVerticalMove vert;
    public CircleCollider2D pushCollider;
    public LayerMask objectLayer;
    public rotate rotateObj;
    private Rigidbody2D rb;

    void Start()
    {
        stunned = false;
        bossInfo = Boss.GetComponent<BossInfo>();
        anim = GetComponentInChildren<Animator>();
        vert = GetComponent<ControllerVerticalMove>();
        rb = GetComponent<Rigidbody2D>();
        flip = GetComponentInChildren<Flip>();
    }
    void Update()
    {
        //if (!pushCollider.IsTouchingLayers(objectLayer))
        //{
        //    EndPush();
        //}
        CheckForPush();
        if (rb.velocity.x != 0.0f)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        
       //if ((pushCollider.IsTouchingLayers(objectLayer))&&(rb.velocity.magnitude>0.1f))
       // {
       //     rotateObj.Rotate();
       //     Push();
       // }
       // else
       // {
       //     rotateObj.StopRotate();
       //     EndPush();
       // }
        
        //transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
        
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!stunned)
        {
            if (other.CompareTag("DangerZone"))
            {
                GetHit();
            }
            if (other.CompareTag("Bonus"))
            {
                GetBonus();
            }
        }
    }
    //void OnCollisionEnter2D(Collision2D coll)
    //{
    //    if ((Physics2D.IsTouching(coll.collider, pushCollider)) && (!stunned))
    //    {
    //        Push();
    //    }
    //}
    void CheckForPush()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, pushCollider.radius + 0.1f,objectLayer);
        if (colliders.Length > 0)
            //&&(rb.velocity.magnitude>0.2f))
        {
            
            Push(colliders[0].gameObject.transform);
        }
        else
        {
            EndPush();
        }

    }
    void GetBonus()
    {
        //bossInfo.Rage -= 15 * bossInfo.bonusCoefficient;
    }
    void GetHit()
    {
        anim.SetBool("Stun", true);
        stunned = true;
        StartCoroutine(Stun());
        //vert.speed = 0.0f;
    }
    void EndStun()
    {
        anim.SetBool("Stun", false);
        stunned = false;
    }
    void Push(Transform pushObj)
    {
        Vector3 moveDirection = pushObj.position - transform.position;
        float angle = Mathf.Atan2(moveDirection.y,moveDirection.x ) * Mathf.Rad2Deg;
        if (pushObj.position.x < transform.position.x)
            angle += 180;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (
            ((pushObj.position.x > transform.position.x) && (!flip.isFacingRight)) 
            ||
                ((pushObj.position.x < transform.position.x) && (flip.isFacingRight)))
        {
            flip.FlipCharacter();
        }

        anim.SetBool("Push", true);
    }
    void EndPush()
    {
        transform.rotation = Quaternion.identity;
        anim.SetBool("Push", false);
    }

    IEnumerator Stun()
    {
        yield return new WaitForSeconds(stunDuration);
        EndStun();
    }
}
