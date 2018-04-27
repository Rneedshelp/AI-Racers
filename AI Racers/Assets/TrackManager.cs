using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour {
    public List<GameObject> NodeList;
    public int totalLaps;
    int curLap=1;
    float raceTimer=0;
    bool raceStart = false;


    public GameObject ui;
    raceUIscript raceUI;
    // Use this for initialization
    void Start ()
    {
        raceUI = ui.GetComponent<raceUIscript>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		//increment the race timer. used for overall calculations as well as for other cars to calculate their times
        if(raceStart)
        {
            raceTimer += Time.deltaTime;
        }
	}

    public void NextLap()
    {
        curLap += 1;
        raceUI.updateLapCounter(curLap, totalLaps);
    }
}
