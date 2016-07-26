using UnityEngine;
using System.Collections;

public class IncreaseSpeedByTime : MonoBehaviour
{
    BossInfo bossInfo;
    // Use this for initialization
    void Start ()
    {
        bossInfo = GetComponent<BossInfo>();
        //StartCoroutine(IncreaseRage());
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    IEnumerator IncreaseRage()
    {
        while(true)
        {
            //bossInfo.Speed += bossInfo.rageIncreaseValue;
            //yield return new WaitForSeconds(bossInfo.rageIncreaseSpeed);
        }
    }
}
