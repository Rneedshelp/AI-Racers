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


	[SerializeField]
	private List<Transform> nodesList;

	// Use this for initialization
	void Start () {
		nodesList = new List<Transform> ();
		foreach (Transform child in transform) {
			nodesList.Add (child);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
