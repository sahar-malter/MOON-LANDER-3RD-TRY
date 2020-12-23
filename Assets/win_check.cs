using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_check : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {



            if (GetComponentInParent<Rigidbody>().velocity.magnitude > 1f)
            {
                //lose - expload
                GetComponentInParent<Rigidbody>().isKinematic = true;
                GetComponentInParent<player_movement>().Invoke("Reset", 3f);
                Debug.Log(gameObject.name + "you lost");
            }
            else
            {

                GetComponentInParent<Rigidbody>().isKinematic = true;
                //particles - you win
                Debug.Log(gameObject.name + "you win");

            }

        }
        
    }
}
