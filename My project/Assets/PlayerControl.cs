using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
        public float jumpHeight;
        public KeyCode Spacebar;
        public keyCode L;
        public keyCode R;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Spacebar))
        {
            Jump();
        }
        if(Input.Getkey(L))
        {
            GetComponent <Rigidbody2D>().velocity = new Vector2(-movSpeed,GetComponent<Rigidbody2D>().velocity.y);

        }
        if(Input.Getkey(R))
        {
            GetComponent <Rigidbody2D>().velocity = new Vector2(movSpeed,GetComponent<Rigidbody2D>().velocity.y);
            
        }
        void Jump()
        {
            GetComponent <Rigidbody2D>().velocity=new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight)
        }
    }
}
