using UnityEngine;
using System.Collections;

public class temp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision col)
	{
		Debug.Log("OnCollisionEnter");
	}
	void OnCollisionExit(Collision col)
	{
		Debug.Log("OnCollisionExit");
	}
	void OnCollisionStay(Collision col)
	{
		Debug.Log("OnCollisionStay");
	}
}
