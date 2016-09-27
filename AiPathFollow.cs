using UnityEngine;
using System.Collections;

public class AiPathFollow : MonoBehaviour {

	public Transform [] path;
	public float followSpeed = 5.0f;
	public float reachDistance = 1.0f;
	public int currentPoint = 0;

	void Start(){

	}

	void Update(){
		Vector3 dir = path [currentPoint].position - transform.position;

		transform.position += dir * Time.deltaTime * followSpeed;

		if (dir.magnitude <= reachDistance) {
			currentPoint++;
		}

		if (currentPoint >= path.Length) {
			currentPoint = 0;
		}
	}
	void DrawOnGizmos()
	{
		if (path.Length > 0) {
			for (int k = 0; k < path.Length; k++) {
				if (path [k] != null) {
					Gizmos.DrawSphere (path [k].position, reachDistance);
				}
			}
		}
	}
}

