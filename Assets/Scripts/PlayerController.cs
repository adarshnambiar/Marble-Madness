/// <summary>
/// Player Controller script.
/// Handles all the horizontal and vertical movement of Character.
/// Uses up,down,left,right arrow controls.
/// RigidBody must be attached to the player before using this script.
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody _rigidBody;//Using rigidbody for rolling the ball <physics>
    public float move_speed = 5.0f;//used for changing character speed from editor    
    public int itemCount = 0; //collectables count

    public GameObject countDisplay, winDisplay;
    // Use this for initialization
    void Start () {
        _rigidBody = transform.GetComponent<Rigidbody>();//Get the attached RigidBody component  
        countDisplay.GetComponent<Text>().text = "Items Collected: " + itemCount.ToString();       
	}
	
	// Update is called once per frame
	void Update () {

        float Hdirection = Input.GetAxis("Horizontal");//Defined in Editor Input Settings
        float Vdirection = Input.GetAxis("Vertical");//Defined in Editor Input Settings
        Vector3 direction = new Vector3(Hdirection, 0, Vdirection);//Calculate the combined 
        _rigidBody.AddForce(direction * move_speed);

        countDisplay.GetComponent<Text>().text = "Items Collected: " + itemCount.ToString();

        if (itemCount >= 12) {
            winDisplay.SetActive(true);
            countDisplay.SetActive(false);
        }

	}

    void OnTriggerEnter(Collider other){

        if (other.gameObject.CompareTag("Collectable")) {
            GameObject effect = Resources.Load("Explode") as GameObject;
            Instantiate(effect, other.gameObject.transform.position, Quaternion.identity);
            other.gameObject.SetActive(false);
            itemCount++;
        }
    }


}
