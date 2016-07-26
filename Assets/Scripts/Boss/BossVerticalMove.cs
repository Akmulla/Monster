using UnityEngine;
using System.Collections;

public class BossVerticalMove : MonoBehaviour
{

    public float maxSpeed;
    public float maxGlobalSpeed;
    public float maxChargeSpeed;
    public float chargeTime;
    public float speed;
    public float chargeValue;
    public float speedIncreasePerSecond;
    private bool inCharge;


    void Start()
    {
        StartCoroutine(IncreaseSpeedByTime());
        inCharge = false;
        //speed = maxSpeed;

    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
    }
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if ((value <= maxSpeed) && (value >= 0))
            {
                speed = value;
            }
            else
            {
                if (value > maxSpeed)
                {
                    speed = maxSpeed;
                }
                else
                {
                    if (value < 0)
                    {
                        speed = 0;
                    }
                }
            }
        }
    }

    public void Charge()
    {
        if (!inCharge)
        {
            StartCoroutine(goCharge());
        }
    }
    IEnumerator goCharge()
    {
        inCharge = true;
        maxSpeed = maxChargeSpeed;
        Speed += chargeValue;

        yield return new WaitForSeconds(chargeTime);

        inCharge = false;
        maxSpeed = maxGlobalSpeed;
        Speed -= chargeValue;
    }

    IEnumerator IncreaseSpeedByTime()
    {
        while (true)
        {

            Speed += speedIncreasePerSecond/2;
            //bossInfo.Speed += bossInfo.rageIncreaseValue;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
