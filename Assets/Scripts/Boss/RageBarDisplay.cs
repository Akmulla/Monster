using UnityEngine;
using System.Collections;

public class RageBarDisplay : MonoBehaviour
{
    public GUISkin mySkin;
    BossInfo bossInfo;
    public Texture image;

    // Use this for initialization
    void Start ()
    {
        bossInfo = GetComponent<BossInfo>();
    }
	
	// Update is called once per frame
	void OnGUI ()
    {
        //float RageBarLen = (float)bossInfo.Rage / bossInfo.maxRage;
        //GUI.Box(new Rect(10, 15, 254 * RageBarLen, 15), " ", GUI.skin.GetStyle("HPBar"));
        //GUI.DrawTexture(new Rect(0, 0, Camera.main.pixelWidth*RageBarLen, (float)Camera.main.pixelHeight/5.0f),image);
    }
}
