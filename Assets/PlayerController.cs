using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //if up arrow pressed, move up
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //if down arrow pressed, move down
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //if lrft arrow pressed, move left
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) //if right arrow pressed, move right
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0); //if no arrow pressed, stop
        }
        
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Speed * Time.deltaTime);

        
    }
}
