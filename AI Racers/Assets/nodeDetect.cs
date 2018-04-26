using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeDetect : MonoBehaviour {
    public GameObject driveObj;
    driving drive;

	// Use this for initialization
	void Start ()
    {
        drive = driveObj.GetComponent<driving>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("processing collision");
        if (collision.gameObject.tag == "node")//we've hit a node, let driving AI know it's time to move to the next one
        {
            
            drive.nextNode();
        }
    }

}
