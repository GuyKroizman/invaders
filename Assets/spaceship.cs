using UnityEngine;
using System.Collections;

public class spaceship : MonoBehaviour {

    public float m_speed = 4.0f;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * m_speed * Time.deltaTime;
    }
}
