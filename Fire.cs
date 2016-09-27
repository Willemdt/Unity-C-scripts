using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public GameObject objectPrefab; //Defines and object to link in engine
	private Transform myTransform;
	public float bulletSpeed = 150; //Bullet speed is public so it can be changed in the engine
	// Use this for initialization
	void Start () 
	{
		setInitialReferances (); //Set initial values
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) //Reads button push
		{
			spawnBullet ();
		}
	}

	void setInitialReferances()
	{
		myTransform = transform; //Sets position to objects current position
	}

	void spawnBullet(){
		GameObject go = (GameObject)Instantiate (objectPrefab, myTransform.TransformPoint (0,0,0.5f), myTransform.rotation); //Spawn point
		go.GetComponent<Rigidbody>().AddForce (myTransform.forward * bulletSpeed,ForceMode.Impulse); //Adds physics force to bullet
		Destroy (go,5); //Stays active for 5 seconds
	}
}
