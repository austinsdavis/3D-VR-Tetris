using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {
    public bool isMoving = true;
    private float time;
    public GameObject previous = null;
    public float current = 0.0f;
    public OVRInput.Controller controller;
    private float usermovedelay;
    public bool colliding = false;
    private int direction;
    private bool interior = false;
    private bool exterior = false;

    void Start()
    {

        
        time = Time.time;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled = false;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].enabled = false;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].enabled = false;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].enabled = false;


        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled = false;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].enabled = false;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].enabled = false;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].enabled = false;


        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled = false;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].enabled = false;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].enabled = false;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].enabled = false;




        ////////////////////////////////


        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].isTrigger = true;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].isTrigger = true;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].isTrigger = true;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].isTrigger = true;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].isTrigger = true;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].isTrigger = true;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].isTrigger = true;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].isTrigger = true;


        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].isTrigger = true;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].isTrigger = true;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].isTrigger = true;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].isTrigger = true;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].isTrigger = true;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].isTrigger = true;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].isTrigger = true;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].isTrigger = true;


        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].isTrigger = true;
        transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].isTrigger = true;

        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].isTrigger = true;
        transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].isTrigger = true;

        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].isTrigger = true;
        transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].isTrigger = true;

        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].isTrigger = true;
        transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].isTrigger = true;




    }


    // Update is called once per frame
    void Update () {
       
        //if ((OVRInput.GetDown(OVRInput.Button.One)) && this.isMoving == true)
       //{
          //  this.transform.Rotate(0, 90f, 0);
         //   transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = false;

        if (exterior == true)
        {
            if (interior == true)
            {
                if (direction == 0 && this.isMoving == true)
                {
                    this.transform.Translate(0f, 0f, -.1f, Space.World);

                }
                else if (direction == 1 && this.isMoving == true)
                {
                    this.transform.Translate(-.1f, 0f, 0f, Space.World);
                }
                else if (direction == 2 && this.isMoving == true)
                {
                    this.transform.Translate(0f, 0f, .1f, Space.World);
                }
                else if (direction == 3 && this.isMoving == true)
                {
                    this.transform.Translate(.1f, 0f, 0f, Space.World);
                }
            }
            else
            {
                this.isMoving = false;
            }
            
        }

        exterior = false;
        interior = false;

        if ((OVRInput.GetDown(OVRInput.Button.Two)) && this.isMoving == true)
        {
            this.transform.Rotate(90f, 0, 0, Space.World);
          

            if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].enabled = true;
                }

                else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].enabled = true;
                }
           
                else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].enabled = true;
                }

                else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].enabled = true;
                }

                else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
                }

                else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled == true)
                {
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                    transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                    transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                    transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                    transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].enabled = true;
                }
        }

        if ((OVRInput.GetDown(OVRInput.Button.One)) && this.isMoving == true)
        {
            this.transform.Rotate(0, 90f, 0, Space.World);
            
            if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].enabled = true;
            }

            else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].enabled = true;
            }

            else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].enabled = true;
            }
             
            else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[1].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[0].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[1].enabled = true;
            }

            else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[3].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[2].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[3].enabled = true;
            }

            else if (transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled == true)
            {
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                transform.GetChild(0).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                transform.GetChild(1).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                transform.GetChild(2).gameObject.GetComponents<BoxCollider>()[5].enabled = true;

                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[4].enabled = false;
                transform.GetChild(3).gameObject.GetComponents<BoxCollider>()[5].enabled = true;
            }
               
            
        }

        if ((OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)) && (Time.time - usermovedelay) >= 0.25f && this.isMoving == true)
        {
            direction = 0;

            this.transform.Translate(0f, 0f, .1f, Space.World);

            usermovedelay = Time.time;
        }

       else if ((OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown)) && (Time.time - usermovedelay) >= 0.25f && this.isMoving == true)
        {
            direction = 2;
            this.transform.Translate(0f, 0f, -.1f, Space.World);
            usermovedelay = Time.time;
        }

        else if ((OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft)) && (Time.time - usermovedelay) >= 0.25f && this.isMoving == true)
        {
            direction = 3;
            this.transform.Translate(-.1f, 0f, 0f, Space.World);
            usermovedelay = Time.time;
        }

        else if ((OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight)) && (Time.time - usermovedelay) >= 0.25f && this.isMoving == true)
        {
            direction = 1;
            this.transform.Translate(.1f, 0f, 0f, Space.World);
            usermovedelay = Time.time;
        }

        if (Time.time >= time + 0.5f && isMoving == true)
        {
            

            this.transform.Translate(0f, -.1f, 0f, Space.World);
            time = Time.time;
        }

        //this.colliding = false;
    }

    private void OnTriggerEnter(Collider c)
    {
        // if (collision.gameObject.tag == "Boundary"){
        //     this.colliding = true;
        //  }
        // else
        // {

        // if (isMoving == true)
        // {
        //     this.transform.Translate(0f, .1f, 0f, Space.World);
        // }

        BoxCollider cc = (BoxCollider)c;
        print(cc.size);

        if (cc.size != new Vector3(0.3f, 0.3f, 0.3f))
        {
            exterior = true;
        }

        else 
        {
            interior = true;
        
           // this.isMoving = true;

           /* if (direction == 0 && this.isMoving == true)
            {
                this.transform.Translate(0f, 0f, -.1f, Space.World);

            }
            else if (direction == 1 && this.isMoving == true)
            {
                this.transform.Translate(-.1f, 0f, 0f, Space.World);
            }
            else if (direction == 2 && this.isMoving == true)
            {
                this.transform.Translate(0f, 0f, .1f, Space.World);
            }
            else if (direction == 3 && this.isMoving == true)
            {
                this.transform.Translate(.1f, 0f, 0f, Space.World);
            } */

        }

       
        
        
        // }
        //if ((previous.Equals(collision.gameObject))) //&& ((Time.time - current) >= 1))
        // {
        //     isMoving = false;
        //     previous = null;
        //      current = 0.0f;
        //  }
        //  current = Time.time;
        //  previous = collision.gameObject;
        //  isMoving = true;
    }
}


/*




 if ((OVRInput.GetDown(OVRInput.Button.One)) && this.isMoving == true)
        {
    this.transform.Rotate(0, 90f, 0);
    if (this.GetComponentsInChildren<BoxCollider>()[0].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[0].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[3].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[6].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[9].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[12].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[15].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[18].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[21].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[2].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[2].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[4].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[8].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[10].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[14].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[16].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[20].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[22].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[4].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[4].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[2].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[10].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[8].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[16].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[14].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[22].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[20].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[1].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[5].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[1].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[11].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[7].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[17].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[13].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[23].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[19].enabled = false;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[3].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[0].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[3].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[6].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[9].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[12].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[15].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[18].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[21].enabled = false;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[5].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[1].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[5].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[7].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[11].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[13].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[17].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[19].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[23].enabled = false;
    }

}

        if ((OVRInput.GetDown(OVRInput.Button.Two)) && this.isMoving == true)
        {
    this.transform.Rotate(90f, 0, 0);
    if (this.GetComponentsInChildren<BoxCollider>()[0].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[0].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[1].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[6].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[7].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[12].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[13].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[18].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[19].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[2].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[2].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[3].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[8].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[9].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[14].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[15].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[20].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[21].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[4].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[4].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[5].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[10].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[11].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[16].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[17].enabled = true;

        this.GetComponentsInChildren<BoxCollider>()[22].enabled = false;
        this.GetComponentsInChildren<BoxCollider>()[23].enabled = true;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[1].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[0].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[1].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[6].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[7].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[12].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[13].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[18].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[19].enabled = false;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[3].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[2].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[3].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[8].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[9].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[14].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[15].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[20].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[21].enabled = false;
    }

    if (this.GetComponentsInChildren<BoxCollider>()[5].enabled == true)
    {
        this.GetComponentsInChildren<BoxCollider>()[4].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[5].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[10].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[11].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[16].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[17].enabled = false;

        this.GetComponentsInChildren<BoxCollider>()[22].enabled = true;
        this.GetComponentsInChildren<BoxCollider>()[23].enabled = false;
    }
}


*/