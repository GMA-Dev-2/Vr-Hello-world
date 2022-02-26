using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverTeleporter : MonoBehaviour
{
    public Transform destination;
    public float delayTeleport;

    private GameObject player;


    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    public void StartTeletraportRoutine () {
        if(!IsInvoking("ChangePosition")) {
            Invoke("ChangePosition", delayTeleport);
        }
    }


    public void StopTeletraportRoutine() {
        CancelInvoke("ChangePosition");
    }


    public void ChangePosition(){
        Transform new_position = destination;
        player.transform.position = new_position.position;
        player.transform.rotation = new_position.rotation;
    }


    public void ChangePosition (Transform new_position) {
        player.transform.position = new_position.position;
        player.transform.rotation = new_position.rotation;
    }



}
