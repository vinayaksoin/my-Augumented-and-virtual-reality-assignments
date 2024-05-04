using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollectCoin : MonoBehaviour
{
    public int points =0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGui()
    {
        GUI.Label(new Rect(0,5,200,40),"Score: " + points);
    }
}
