using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphImplement : MonoBehaviour {

	class Node
	{
		Transform coordinates;
		bool visited = false;
	};

	class GraphAStar
	{
		Node root;
	};


    //private GraphAStar track = new GraphAStar();
    public float size = 0f;

    [SerializeField]
    private List<Transform> nodesList;

    // Use this for initialization
    void Start () {
		nodesList = new List<Transform> ();
		foreach (Transform child in transform) {
			nodesList.Add (child);
		}

        size = nodesList[0].GetComponent<SpriteRenderer>().size[0];



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
