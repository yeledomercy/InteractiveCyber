using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateRightHandonCollision : MonoBehaviour
{
  private void OnTriggerEnter(Collider collider) {
      OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.RTouch);
  }

  private void OnTriggerStay(Collider collider) {
      OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.RTouch);
  }

  private void OnTriggerExit(Collider collider) {
      OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.RTouch);
  }
}
