using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject blast; //allows us to set object for blast
    private Vector2 myLocation; //makes Vector 2 for blast position
                                // Start is called before the first frame update

    public Quaternion blastRot; // Saves the transform.rotation to a variable

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var objectPos = Camera.main.WorldToScreenPoint(transform.position);

        var dir = Input.mousePosition - objectPos;


        blastRot = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg));

        if (Input.GetKeyDown(KeyCode.Mouse0))
        { //if space button is press
            myLocation = gameObject.transform.position; //sets blast location at player position

            Instantiate(blast, new Vector2(myLocation.x, myLocation.y), blastRot); //makes new blast in blastRot direction
        }
    }
}
