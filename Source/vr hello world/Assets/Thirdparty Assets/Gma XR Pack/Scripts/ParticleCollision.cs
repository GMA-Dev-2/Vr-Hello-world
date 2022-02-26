using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour {

    public int value = 5;
    public string[] destroyList;
    public string[] damageList;

    private void OnParticleCollision(GameObject other) {
        
        foreach(string target in destroyList) {
            if (other.CompareTag(target)) {
                other.SetActive(false);
            }
        }


        foreach (string target in destroyList) {
            if (other.CompareTag(target)) {
                Lifepoint damagable = other.GetComponent<Lifepoint>();
                if(damagable != null) {
                    damagable.TakeDamage(value);
                }
                
            }
        }


    }


}
