using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public Button receptionButton, mainAreaButton;

    Vector3[] positions = new [] {
        new Vector3(0, 0, 0),
        new Vector3(3, 0, 0),
        new Vector3(6, 0, 0) };
    

    // Use this for initialization
    void Start ()
    {
        receptionButton.onClick.AddListener(delegate { transportToPositionNo(0); });
        mainAreaButton.onClick.AddListener(delegate { transportToPositionNo(1); });
    }
	
	// Update is called once per frame
	void Update () {
	}

    void transportToPositionNo (int positionNo)
    {
        Vector3 distance =  positions[positionNo] - transform.position;
        transform.position += distance;
    }
}
