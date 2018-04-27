using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour {
    public GameObject trackObj;
   

    TrackManager track;

	// Use this for initialization
	void Start ()
    {
        track = trackObj.GetComponent<TrackManager>();
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="car")
        {
            track.NextLap();
            
        }
    }
}
