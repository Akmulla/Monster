using UnityEngine;
using System.Collections;

public class AimShoot : MonoBehaviour
{
    private Pool pool;
    public float aimTime;
    public bool hold;
    // Use this for initialization
    void Start ()
    {
        hold = false;
        pool = GameObject.Find("PoolManager").GetComponent<PoolManager>().GetPool("dangerZone");
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (!hold)
        {
            
        }
	}
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (!hold)
    //    {
    //        if (other.name == "Controller")
    //        {
    //            hold = true;
    //            StartCoroutine(StartAim());
    //        }
    //    }
    //}



    IEnumerator StartAim()
    {
        yield return new WaitForSeconds(aimTime);
        hold = false;
        pool.Activate(transform.position, Quaternion.identity);
    }
}
