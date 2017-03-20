using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {
	public GameObject projectile; 

	public Transform[] SpawnProjectile;

	public float time = 0.0f;

	float counter;

	void Start() {
		counter = time;
	}

	void Update() {

		counter -= Time.deltaTime;

		if (counter <= 0) {

			counter = time;

			Transform shootingPoint = ShootPoint ();

			var positionX = shootingPoint.transform.position.x;

			var positionY = 1.6f;

			var randomZ = Random.Range(-360,360);

			Vector3 randomDir = new Vector3(positionX,positionY,randomZ);

			GameObject bullet = Instantiate (projectile, shootingPoint.position, Quaternion.identity) as GameObject;
			//bullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 10);
			bullet.GetComponent<Rigidbody>().AddForce(randomDir * 5);
		}
	}

	Transform ShootPoint() {
		var number = Random.Range (0, SpawnProjectile.Length);
		return SpawnProjectile [number].transform;
	}
}
