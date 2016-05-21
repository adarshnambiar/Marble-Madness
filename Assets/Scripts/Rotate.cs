/// <summary>
/// Add rotation to the collectables.
/// </summary>
using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float rotation_speed = 1f;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate((new Vector3(45, 45, 45)) * Time.deltaTime * rotation_speed);
	}
}
