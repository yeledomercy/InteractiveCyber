using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleByHeadRotation : MonoBehaviour {
    public GameObject Head;
    private float currentXHAngle;
    private Vector3 currentScale;
    private float OneDScale;
    private float StartScale;
    public VideoController MyController;
    private bool alreadyPlayed;


    // Use this for initialization
    void Start () {
        
        currentScale = transform.localScale;
        StartScale = currentScale.x;
        OneDScale = currentScale.x;
		
	}
	
	// Update is called once per frame
	void Update () {
        currentXHAngle = Head.transform.rotation.eulerAngles.x;
       // Debug.Log("angle" + currentXHAngle);
        if (currentXHAngle < 360 && currentXHAngle > 90)
        {
            currentXHAngle =  360 - currentXHAngle;
        }

        else if (currentXHAngle >0 && currentXHAngle < 90)
        {
            currentXHAngle = -1 * currentXHAngle;
        }
        OneDScale = Mathf.Clamp(StartScale + (currentXHAngle)/3, -20, 20);
       // Debug.Log(" scale: " + OneDScale);             
        gameObject.transform.localScale= new Vector3 (OneDScale, OneDScale, OneDScale);
		if (gameObject.transform.localScale.x == 20 & !alreadyPlayed)
        {
            Debug.Log("yes");
            MyController.PlayClip(1);
            alreadyPlayed = true;
        }
        else if (gameObject.transform.localScale.x == -20 & !alreadyPlayed)
        {
            Debug.Log("no");
            MyController.PlayClip(2);
            alreadyPlayed = true;
        }
    }
}
