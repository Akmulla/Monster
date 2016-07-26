using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    private Pool pool;

    void Start()
    {
        pool = GetComponentInParent<EnemyInfo>().pool;
    }
	
	
	void DestroyObj()
    {
        pool.Deactivate(transform.parent.gameObject);
    }
    void DisableObj()
    { 
        gameObject.transform.parent.gameObject.tag = "None";
    }
  
}
