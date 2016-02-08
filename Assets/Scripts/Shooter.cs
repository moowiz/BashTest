using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile;
	public MeshFilter gunBody;
	public Vector3 originPoint;

	// Use this for initialization
	void Start () {
		originPoint = new Vector3 (0, 0.5f, -4.5f);
	}

	void Fire() {
		GameObject instance = (GameObject)Instantiate (projectile, GetComponent<Transform> ().position + originPoint, gunBody.transform.rotation);
		instance.GetComponent<Rigidbody> ().AddForce (0, 0, -5, ForceMode.Impulse);
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.T)) {
			Fire ();
		}
	}
}
