using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AbilityManager : MonoBehaviour
{
    public List<Component> abilities;
	// Use this for initialization
	void Start ()
    {
        Component[] components;
        components = GetComponents<Component>();
        abilities = new List<Component>();
        for (int i = 0; i < components.Length; i++)
        {
            if ((components[i].GetType() != transform.GetType()) && (components[i].GetType() != this.GetType()))
            {
                abilities.Add(components[i]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
