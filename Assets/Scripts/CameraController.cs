/// <summary>
/// Camera Controller script.
/// Always follows the player.
/// </summary>
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private GameObject player;//player GameObject
    private Vector3 camera_position;//postion of camera
    
	// Use this for initialization
	void Awake () {

        player = GameObject.Find("Player");
        camera_position = transform.position - player.transform.position;//Intitial position of camera
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 newPosition = player.transform.position + camera_position;//camera will move same distance as the player
        transform.position = newPosition;
        
	}
}
