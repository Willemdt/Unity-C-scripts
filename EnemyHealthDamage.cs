using UnityEngine;
using System.Collections;

public class EnemyHealthDamage : MonoBehaviour {

	public GameObject enemy;
	public int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (enemy.gameObject);
			Debug.Log ("The enemy has been destroyed");
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "Bullet") {
			health -= 50;
			Debug.Log (health);
		}
	}
}
