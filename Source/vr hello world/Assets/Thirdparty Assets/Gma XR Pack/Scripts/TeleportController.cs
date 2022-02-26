using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportController : MonoBehaviour {

    public XRController teleportRay;

    public InputHelpers.Button teleportActivationButton;
    public InputHelpers.Button grabButton;

    public float activationThreshold = 0.1f;

    private GameObject currentRecticle;


    private void Start() {
        currentRecticle = teleportRay.GetComponent<XRInteractorLineVisual>().reticle;
        currentRecticle.SetActive(false);
    }

    private void Update() {

        if (teleportRay) {
            teleportRay.gameObject.SetActive(CheckIfActivated(teleportRay));
        }
    }



    public bool CheckIfActivated (XRController controller) {
        InputHelpers.IsPressed(controller.inputDevice, grabButton, out bool isGrabbing, activationThreshold);

        if(isGrabbing == false) {
            InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
            currentRecticle.SetActive(isActivated);
            return isActivated;
        } else {
            currentRecticle.SetActive(false);
            return false;
        }
        
    }


}
