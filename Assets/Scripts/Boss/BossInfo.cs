using UnityEngine;
using System.Collections.Generic;

public class BossInfo : MonoBehaviour
{
    public string HitByObjectsOfType = "Object";
    public float speedByObjectCoefficient = 1;
    public float bonusCoefficient = 1;


    // Use this for initialization
    void Start ()
    {
        for (int i=0;i<2;i++)
        {
            //GetAbilities();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void GetAbilities()
    {
        List<Component> abilities = GameObject.Find("AbilityManager").GetComponent<AbilityManager>().abilities;
        Component component = abilities[Random.Range(0, abilities.Count)];
        abilities.Remove(component);
        System.Type type = component.GetType();
        Component addedComponent=gameObject.AddComponent(type);

        System.Reflection.FieldInfo[] fields = type.GetFields();
        foreach (System.Reflection.FieldInfo field in fields)
        {
            field.SetValue(addedComponent, field.GetValue(component));
        }
        //gameObject.AddComponent<Sniper>();
    }

    


}
