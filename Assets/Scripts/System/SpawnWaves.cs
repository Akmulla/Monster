using UnityEngine;
using System.Collections;

public class SpawnWaves : MonoBehaviour
{
    private PoolManager poolManager;
    [Header("Pool")]
    private Pool bonusPool;
    private Pool truckPool;
    private Pool boxPool;
    private Pool dangerZonePool;
    [Header("Wave Rates")]
    //public float citizenWaveRate;
    public float bonusWaveRate;
    public float truckWaveRate;
    public float boxWaveRate;
    public float dangerZoneWaveRate;
    [Space(20)]
    public float startWait;
    public LayerMask objLayer;

    void Start ()
    {
        poolManager = GameObject.Find("PoolManager").GetComponent<PoolManager>();
        bonusPool = poolManager.GetPool("bonus");
        truckPool = poolManager.GetPool("truck");
        boxPool = poolManager.GetPool("box");
        dangerZonePool= poolManager.GetPool("dangerZone");
        //StartCoroutine(SpawnCitizen());

        //StartCoroutine(SpawnTruck());
        //StartCoroutine(SpawnBox());
        //StartCoroutine(SpawnDangerZone());

        StartCoroutine(SpawnBonus());
        StartCoroutine(SpawnObject(truckPool, truckWaveRate));
        StartCoroutine(SpawnObject(boxPool, boxWaveRate));
        StartCoroutine(SpawnObject(dangerZonePool, dangerZoneWaveRate));
    }
    IEnumerator SpawnObject(Pool pool,float waveRate)
    {
        yield return new WaitForSeconds(Random.Range(0f, 2f));
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge, (float)Edges.rightEdge), Edges.topEdge + 1);
            //Instantiate(flameThrower, spawnPosition, Quaternion.identity);
            while (Physics2D.OverlapCircle(spawnPosition,0.75f,objLayer))
            {
                spawnPosition.y += 2.0f;
            }
            pool.Activate(spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(waveRate);
        }
    }

    IEnumerator SpawnBonus()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0f, 2f));
            float edge = (Random.Range(0.0f, 1.0f) > 0.5f) ? Edges.leftEdge : Edges.rightEdge;
            Vector2 spawnPosition = new Vector2(edge, Edges.topEdge + 1);
            //Instantiate(citizen, spawnPosition, Quaternion.identity);

            bonusPool.Activate(spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(bonusWaveRate);
        }
    }

    //IEnumerator SpawnTruck()
    //{
    //    yield return new WaitForSeconds(Random.Range(0f, 2f));
    //    while (true)
    //    {
    //        Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge, (float)Edges.rightEdge), Edges.topEdge+1);
    //        //Instantiate(flameThrower, spawnPosition, Quaternion.identity);
    //        truckPool.Activate(spawnPosition, Quaternion.Euler(new Vector3(0f,0f,Random.Range(0f,360f))));
    //        yield return new WaitForSeconds(truckWaveRate);
    //    }
    //}

    //IEnumerator SpawnBox()
    //{
    //    yield return new WaitForSeconds(Random.Range(0f, 2f));
    //    while (true)
    //    {
    //        Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge, (float)Edges.rightEdge), Edges.topEdge+1);
    //        //Instantiate(flameThrower, spawnPosition, Quaternion.identity);
    //        boxPool.Activate(spawnPosition, Quaternion.Euler(new Vector3(0f, 0f, Random.Range(0f, 360f))));
    //        yield return new WaitForSeconds(boxWaveRate);
    //    }
    //}

    //IEnumerator SpawnDangerZone()
    //{
    //    yield return new WaitForSeconds(Random.Range(0f,2f));
    //    while (true)
    //    {
    //        Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge, (float)Edges.rightEdge), Edges.topEdge+1);
    //        //Instantiate(flameThrower, spawnPosition, Quaternion.identity);
    //        dangerZonePool.Activate(spawnPosition, Quaternion.identity);
    //        yield return new WaitForSeconds(dangerZoneWaveRate);
    //    }
    //}


}
