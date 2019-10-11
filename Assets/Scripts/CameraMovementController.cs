using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour {

    public float height;
    float timeCounter = 0;

    private List<GameObject> players = new List<GameObject>();
    // Use this for initialization
    void Start () {
        players.Add(GameObject.Find("Player1"));
        players.Add(GameObject.Find("Player2"));
    }
	
	// Update is called once per frame
	void Update () {
        CircularMovement();
        LookAtMidPoint();
	}

    public void LookAtMidPoint()
    {
        GameObject nextPlayer = players[1];
        GameObject currentPlayer = players[0];
        Vector3 currentPos = currentPlayer.transform.position;
        Vector3 lookAtPosition = nextPlayer.gameObject.transform.position;
        lookAtPosition = (lookAtPosition + currentPos) / 2;
        this.transform.LookAt(lookAtPosition, Vector3.up);
    }

    public void CircularMovement()
    {
        GameObject p1 = players[0];
        GameObject p2 = players[1];
        Vector3 p1Pos = p1.transform.position;
        Vector3 p2Pos = p2.gameObject.transform.position;
        Vector3 center = (p1Pos + p2Pos) / 2;
        float radius = (p1Pos - p2Pos).magnitude * 1.5f;
        timeCounter += Time.deltaTime; // multiply all this with some speed variable (* speed);
        float x = radius * Mathf.Cos(timeCounter);
        float z = radius * Mathf.Sin(timeCounter);
        float y = 4;
        Vector3 relativePos = new Vector3(x, y, z);

        transform.position = relativePos + center;
    }

    public void CircularSwitch()
    {
        GameObject p1 = players[0];
        GameObject p2 = players[1];
        Vector3 p1Pos = p1.transform.position;
        Vector3 p2Pos = p2.gameObject.transform.position;
        Vector3 center = (p1Pos + p2Pos) / 2;
        float radius = (p1Pos - p2Pos).magnitude * 1.5f;
        timeCounter += Time.deltaTime; // multiply all this with some speed variable (* speed);
        float x = radius * Mathf.Cos(timeCounter);
        float z = radius * Mathf.Sin(timeCounter);
        float y = 4;
        Vector3 relativePos = new Vector3(x, y, z);

        transform.position = relativePos + center;
    }
}
