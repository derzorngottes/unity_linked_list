using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList : MonoBehaviour {
	public Node head;
	public Node current;
	public int count;
	public int maxLength;

	// Use this for initialization
	void Start () {
		Node head = new Node();
		Node tail = head;
		maxLength = 20;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddAtEnd(string value) {
		if (count >= maxLength) {
			// TODO display warning text to user
			return;
		}

		Node newNode = new Node (value);

		// create Node node
		current.next = newNode;
		newNode.next = null;
		count++;

		// create physical node
		GameObject newNodeObj = MakeNewNode(value);
	}

	public void RemoveFromEnd() {
		// iterate over LL until next == current
		Node curNode = head;
		while (curNode.next != current) {
			curNode = curNode.next;
		}

	}


	/*
	 *  UNITY SPECIFIC FUNCTIONS
	 *  For implementing the structure in 3D space
	 */

	public GameObject MakeNewNode(string value) {
		// create sphere to represent node
		GameObject newNode = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		// create text mesh to display value and attach to node
		TextMesh newNodeValue = new TextMesh ();
		newNodeValue.text = value;
		//newNodeValue.transform.parent = newNode;
		// size and place node on map according to LL position
		newNode.transform.localScale += new Vector3(5.0f, 5.0f, 5.0f);
		newNode.transform.position = new Vector3 (current.position.x + 10.0f, current.position.y, current.position.z);
		return newNode;
	}
}

public class Node : MonoBehaviour {
	string Value;
	public Node next;
	public Vector3 position;
}
