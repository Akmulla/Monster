using UnityEngine;
using System.Collections;

public class HandReaction : MonoBehaviour
{
    public Animator anim;
    private float damageEnd;
    private float damageDuration = 0.5f;
    private float invincibleEnd;
    private float invincibleDuration = 2.0f;
    public MonsterReaction head;
    public bool invincible;


	void Start ()
    {
        anim = GetComponentInChildren<Animator>();
        invincible = false;
	}
	

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("DangerZone")) && (!invincible))
        {
            GetHit();
        }
    }


    public void GetHit()
    {
        anim.SetBool("Burn", true);
        damageEnd = Time.time + damageDuration;
        invincibleEnd = Time.time+invincibleDuration;
        invincible = true;
        head.invincible = true;
        head.Burn();
    }
    void Update()
    {
        if (Time.time > damageEnd)
        {
            anim.SetBool("Burn", false);
            anim.SetBool("Invincible", true);
        }
        if (Time.time > invincibleEnd)
        {
            anim.SetBool("Invincible", false);
            invincible = false;
        }
    }

    public void GetInvincible()
    {
        anim.SetBool("Invincible", true);
        invincibleEnd = Time.time + invincibleDuration;
        invincible = true;
    }

    //   void OnCollisionEnter2D(Collision2D coll)
    //   {
    //       if (coll.gameObject.tag=="Bullet")
    //       {
    //           GetHit();    
    //       }
    //   }

    //   public void GetHit()
    //   {
    //       anim.SetBool("Damaged",true);
    //       damageEnd = Time.time + damageDuration;
    //   }
}
