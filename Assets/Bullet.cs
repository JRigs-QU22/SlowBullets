using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Xspeed; //sets a variable for vertical speed

    public bool SloMo;
    // Start is called before the first frame update
    void Start()
    {
        SloMo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SloMo == true)
        {
            transform.Translate(Xspeed/4, 0, 0);
        }
        else
        {
            transform.Translate(Xspeed, 0, 0); //transforms the blast position on the y-axis
        }


        //   if (transform.position.y > 20f) //if blast goes above 20f, destroy it
        // {
        //   Destroy(gameObject);
        // }
        //if (transform.position.y > -10f) //if blast goes below -10f, destroy it
        // {
        //  Destroy(gameObject);
        //}
        if (Input.GetKeyDown(KeyCode.Mouse1) && SloMo == false)
        {
            SloMo = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && SloMo == true)
        {
            SloMo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy") //if alien is hit by object with bottom tag
        {
            Destroy(gameObject); //destroy object immeadiately
        }
    }
}
