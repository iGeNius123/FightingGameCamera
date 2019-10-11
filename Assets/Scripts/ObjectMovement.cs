using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {
    float timeCounter = 0;
    GameObject anotherPlayer;
    // Use this for initialization
    void Start () {
        string nextName = gameObject.name.Equals("Player1") ? "Player2" : "Player1";
        anotherPlayer = GameObject.Find(nextName);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = new Vector3();
        if (this.gameObject.name.Equals("Player1"))
        {
            timeCounter -= Time.deltaTime * 3;
            offset = new Vector3(4f, .5f, 4f);
        }
        else
        {
            timeCounter += Time.deltaTime * 3; // multiply all this with some speed variable (* speed);
            offset = new Vector3(-4f, .5f, -4f);

        }

        float x = Mathf.Cos(timeCounter);
        float z = Mathf.Sin(timeCounter);
        float y = 0;
        transform.position = (new Vector3(x, y, z)) * 2 + offset;
        transform.LookAt(anotherPlayer.transform.position);
    }
}
