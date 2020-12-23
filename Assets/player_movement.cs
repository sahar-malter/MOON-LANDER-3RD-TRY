using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player_movement : MonoBehaviour
{
    public float forceUP;
    public float ForceSIDE;
    private Rigidbody RB;
    private Camera cam;
    public Vector3 Camera_Offset;
    public ParticleSystem Thrust_particle;
    public Text speed_text;

    private float first_z_rotation;
    // Start is called before the first frame update
    void Start()
    {
        first_z_rotation = Random.Range(0, 360);
        cam = Camera.main;
        RB = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, 0, first_z_rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            RB.AddForce(Vector3.up * forceUP);
            Thrust_particle.gameObject.SetActive(true);
        }
        else 
        {
            Thrust_particle.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RB.AddTorque(Vector3.forward * ForceSIDE);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RB.AddTorque(-Vector3.forward * ForceSIDE);
        }

        speed_text.text = string.Format("Speed: " +"{0:0.00}",RB.velocity.magnitude);
    }


    void FixedUpdate()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.position,transform.position + Camera_Offset,0.25f);


    }



   

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
