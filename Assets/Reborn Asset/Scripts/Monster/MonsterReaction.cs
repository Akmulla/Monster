using UnityEngine;
using System.Collections;

public class MonsterReaction : MonoBehaviour
{
    public Animator headAnim;
    public Animator bodyAnim;
    private VerticalMove vert;
    private float nextIncrease;
    public BoxCollider2D helicopterCollider;
    public BoxCollider2D helicopterTarget;
    private float invincibleDuration = 4.0f;
    private float invincibleEnd;
    private bool b=true;
    public HandReaction hand;
    public GameObject body;
    public bool invincible = false;

    private SpriteRenderer srBody;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start ()
    {
        vert = GetComponentInParent<VerticalMove>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {

        
        //if ((Time.time > nextIncrease) && (vert.speed < vert.maxSpeed))
        {
            vert.speed += 0.1f;
            nextIncrease = Time.time + 1f;

            
        }
        if (b&&(helicopterCollider.IsTouching(helicopterTarget)))
        {
            headAnim.SetTrigger("EatHelicopter");
            b = false;
        }

        if (Time.time > invincibleEnd)
        {
            invincible = false;
            hand.invincible = false;
            hand.anim.SetBool("Invincible", true);

            int a = headAnim.GetLayerIndex("Invincible");
            headAnim.SetLayerWeight(a, 0.0f);

            a = bodyAnim.GetLayerIndex("Invincible");
            bodyAnim.SetLayerWeight(a, 0.0f);
        }

        //if (!invincible)
        //{
        //    int a = headAnim.GetLayerIndex("Invincible");
        //    headAnim.SetLayerWeight(a, 0.0f);
        //}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            headAnim.SetTrigger("Eat");
        }

        if ((other.gameObject.tag == "Slower")&&(!invincible))
        {
            GetHit();
            hand.GetInvincible();
            invincible = true;
            hand.invincible = true;

            int a = headAnim.GetLayerIndex("Invincible");
            headAnim.SetLayerWeight(a, 1.0f);

            a = bodyAnim.GetLayerIndex("Invincible");
            bodyAnim.SetLayerWeight(a, 1.0f);

            //StartCoroutine(SwitchSprite());
        }

        //if (other.gameObject.name == "Helicopter")
        //{
        //    anim.SetTrigger("EatHelicopter");
        //}
    }

   

    public void GetHit()
    {
        vert.speed -= 0.5f;
        if (vert.speed < 0) vert.speed = 0;
        headAnim.SetTrigger("GetHit");
        invincibleEnd = Time.time + invincibleDuration;
    }

    public void Burn()
    {
        vert.speed -= 0.5f;
        if (vert.speed < 0) vert.speed = 0;
        headAnim.SetTrigger("Burn");
        invincibleEnd = Time.time + invincibleDuration;

        int a = headAnim.GetLayerIndex("Invincible");
        headAnim.SetLayerWeight(a, 1.0f);
    }

    

}
