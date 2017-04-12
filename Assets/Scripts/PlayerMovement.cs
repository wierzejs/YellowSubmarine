using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5f;


    private int score = 0;



	void Update () {
	if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0)*Time.deltaTime * moveSpeed);
        }
    if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed);
        }
    if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * moveSpeed);
        }
    if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * moveSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEneter2D" + other.gameObject.name);
        if (other.gameObject.name == "plasticbag")
        {
            Destroy(other.gameObject);
            Debug.Log("Plastic bag collected");
            score += 1;
        }
    }
    
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + score);
    }
    
}
