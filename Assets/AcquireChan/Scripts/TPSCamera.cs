using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour {

    public GameObject player;
    private Vector3 offset; 

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(new Vector3(0, 1, 0), 90 * Time.deltaTime);
        }
	}
}
