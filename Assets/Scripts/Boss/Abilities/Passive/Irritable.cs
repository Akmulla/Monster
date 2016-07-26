using UnityEngine;
using System.Collections;

public class Irritable : MonoBehaviour
{
    BossInfo bossInfo;
    // Use this for initialization
    void Start ()
    {
        bossInfo = GetComponent<BossInfo>();
        //bossInfo.rageByObjectCoefficient = 2;
        //bossInfo.bonusCoefficient = 2;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
