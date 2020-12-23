using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outeRing : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {


        GetComponentInParent<player_movement>().Invoke("Reset", 3f);
            GetComponentInParent<Rigidbody>().isKinematic = true;
            Debug.Log(gameObject.name + "you lost");
        }
        
    }
}
