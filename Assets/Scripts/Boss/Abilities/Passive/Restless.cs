using UnityEngine;
using System.Collections;

public class Restless : MonoBehaviour
{
    BossInfo bossInfo;
    // Use this for initialization
    void Start ()
    {
        bossInfo = GetComponent<BossInfo>();
        //bossInfo.rageCoefficient = 3;
        //bossInfo.bonusCoefficient = 2;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
