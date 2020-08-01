using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateControllers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (OVRInput.Get(OVRInput.Button.One))
      {
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.RTouch);
        Debug.Log("Button.One pressed");
      }

      if (OVRInput.Get(OVRInput.Button.Three))
      {
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.LTouch);
        Debug.Log("Button.Three pressed");
      }

    }
}
