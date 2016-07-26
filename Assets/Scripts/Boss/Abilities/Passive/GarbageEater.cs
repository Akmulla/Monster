using UnityEngine;
using System.Collections;

public class GarbageEater : MonoBehaviour
{
    BossInfo bossInfo;
	// Use this for initialization
	void Start ()
    {
        bossInfo = GetComponent<BossInfo>();
        //bossInfo.HitByObjectsOfType ="None";
        //bossInfo.rageIncreaseSpeed = 0.5f;
        //bossInfo.rageByObjectCoefficient = -1;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
