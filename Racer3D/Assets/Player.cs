using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public float movementSpeed = 10.0f;
public float rotationSpeed = 200.0f;

AudioSource CoinAudio;


    // Start is called before the first frame update
    void Start()
    {
        CoinAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Handy();
        Computer();
        Quit();
    }

        void Handy()
    {
    transform.Rotate(0, UltimateJoystick.GetHorizontalAxis( "movement" ) * Time.deltaTime * rotationSpeed, 0);
    transform.Translate(0,0, UltimateJoystick.GetVerticalAxis( "movement" ) * Time.deltaTime * movementSpeed);  
    }

    void Computer()
    {
    transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
    transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed); 
    }

    void Quit(){
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }


    //enemy berührt?
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {

            Debug.Log("Getroffen");
            
            Destroy(collision.gameObject);

            gameObject.SetActive(false);
            //particleExplosion.Play();
            //explosionAudio.Play();

            //KeepScore.Score += 1;
        }

        if (collision.transform.tag == "coin")
        {
            CoinAudio.Play();
        }
    }






}
