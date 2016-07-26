using UnityEngine;
using System.Collections;

public class BossReaction : MonoBehaviour
{
    Animator anim;
    BossInfo bossInfo;
    GameObject asd;
    BossVerticalMove bossVerticalMove;
    // Use this for initialization
    void Start()
    {
        bossVerticalMove = GetComponentInParent<BossVerticalMove>();
        bossInfo = GetComponent<BossInfo>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(bossInfo.HitByObjectsOfType))
        {
            HitByObject();
        }
    }

    void HitByObject()
    {
        bossVerticalMove.Charge();
        //bossInfo.Rage += 10*bossInfo.rageByObjectCoefficient;
    }

    //void GetBonus()
    //{
    //    bossInfo.Rage -= 15*bossInfo.bonusCoefficient;
    //}
    
}
