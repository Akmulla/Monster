using UnityEngine;

public class PoolManager : MonoBehaviour
{
    //public Pool citizenPool;
    
    //public Pool truckPool;

    //public Pool boxPool;

    //public Pool dangerZonePool;

    public Pool[] pools;

    //private int size;

    // Use this for initialization
    void Awake ()
    {
        pools = GetComponents<Pool>();
    }

    public Pool GetPool(string nameObj)
    {
        for (int i = 0; i < pools.Length; i++)
        {
            if (pools[i].objName == nameObj)
            {
                return pools[i];
            }

        }
        return null;



        //switch (nameObj)
        //{
        //    case "citizen":
        //        return citizenPool;
        //    case "truck":
        //        return truckPool;
        //    case "box":
        //        return boxPool;
        //    case "dangerZone":
        //        return dangerZonePool;
        //    default:
        //        return null;
        //}



    }

    void Update()
    {
        
    }
}
