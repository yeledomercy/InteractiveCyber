using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHead : MonoBehaviour
{
    public static ChangeHead instance;
    public enum HeadState {neutral, happy, angry, scared};
    public HeadState CurrentState;



    public delegate void OnHeadStateChange(string ChangedTo);

    public static OnHeadStateChange headStateChange;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentState = HeadState.neutral;

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (CurrentState <= HeadState.angry)
            {
                Debug.Log(CurrentState.ToString());
                CurrentState++;
                Debug.Log(CurrentState.ToString());
                headStateChange(CurrentState.ToString());
            }


        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if(CurrentState >= HeadState.happy)
            {
                CurrentState--;
                headStateChange(CurrentState.ToString());
                Debug.Log(CurrentState.ToString());
            }

        }

    }
}
