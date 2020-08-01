using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateLeftHandonCollision : MonoBehaviour
{
  private void OnTriggerEnter(Collider collider) {
      OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.LTouch);
  }

  private void OnTriggerStay(Collider collider) {
      OVRInput.SetControllerVibration(1, 0.25f, OVRInput.Controller.LTouch);
  }

  private void OnTriggerExit(Collider collider) {
      OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.LTouch);
  }
}
