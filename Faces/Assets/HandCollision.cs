using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider) {
      Debug.Log("Hand collision name: " + collider.gameObject.name);

      if (collider.gameObject.name == "Right Hand Sphere")
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.RTouch);
      if (collider.gameObject.name == "Left Hand Sphere")
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.LTouch);
    }

    private void OnTriggerStay(Collider collider) {
      if (collider.gameObject.name == "Right Hand Sphere")
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.RTouch);
      if (collider.gameObject.name == "Left Hand Sphere")
        OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.LTouch);
    }

    private void OnTriggerExit(Collider collider) {
      Debug.Log("Hand exit name: " + collider.gameObject.name);

      if (collider.gameObject.name == "Right Hand Sphere")
        OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.RTouch);
      if (collider.gameObject.name == "Left Hand Sphere")
        OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.LTouch);
    }
}
