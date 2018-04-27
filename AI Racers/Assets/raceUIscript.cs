using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raceUIscript : MonoBehaviour {
    Text lapCounter;
    GameObject trackObj;
    TrackManager track;

    // Use this for initialization
    void Start ()
    {
        lapCounter = GameObject.Find("Lap").GetComponent<Text>();
        track = trackObj.GetComponent<TrackManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void updateLapCounter(int lap,int totalLaps)
    {
        lapCounter.text = "Lap: " + lap.ToString() + "/" + totalLaps.ToString();
    }
}
