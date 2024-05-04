using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("I am in start");
    }

    // Update is called once per frame
    void Update()
    {
         //Debug.Log("Update");
         if(Input.GetKeyDown("space"))
         {
         GetComponent<Rigidbody>().velocity= new Vector3(0,5,0);
         }
         if(Input.GetKeyDown("up"))
	{
	GetComponent<Rigidbody>().velocity= new Vector3(5,0,0);
	}
	if(Input.GetKeyDown("right"))
	{
	GetComponent<Rigidbody>().velocity= new Vector3(5,0,0);
	}

	if(Input.GetKeyDown("left"))
	{
	GetComponent<Rigidbody>().velocity= new Vector3(-5,0,0);
	}

	if(Input.GetKeyDown("down"))
	{
	GetComponent<Rigidbody>().velocity= new Vector3(0,0,-5);;
	}
    }
}
