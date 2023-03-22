using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //declare player vars
    
    public float speed = .02f;
    public float roll_iframes_duration = 0.2f;
    public float roll_duration = 0.4f;
    
    int xdir; //player x direction
    int ydir; //player y direction
    int idledirx; //used to determine roll direction from idle state
    int idlediry;
    
    bool invincible = false; //true during i-frames
    bool rolling = false;
    //bool superarmor = false; //immune to negative effects or being pushed

    //Start (Lifecycle Function)
    void Start()
    {
        //init
        xdir = 0;
        ydir = 0;
        idledirx = 0;
        idlediry = 0;
    }

    //Update (Lifecycle Function)
    void Update()
    {
        xdir = 0;
        ydir = 0;
      
        
        //get keyboard inputs
        
        //up
        if (Input.GetKey(KeyCode.W)) {
            ydir += 1;
        }
        
        //down
        if (Input.GetKey(KeyCode.S)) {
            ydir -= 1;
        }
        
        //right
        if (Input.GetKey(KeyCode.D)) {
            xdir += 1;
        }
        
        //left
        if (Input.GetKey(KeyCode.A)) {
            xdir -= 1;
        }
        
        
        idledirx = xdir;
        idlediry = ydir;
        
        
        //dodge roll (with iframes)
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            invincible = true;
            rolling = true;
            StartCoroutine(EndRollInvincibility());
            StartCoroutine(EndRoll());
        }
        
        //grappling hook
        if (Input.GetKeyDown(KeyCode.E)) {

        }
        
        
        //left mouse button
        if (Input.GetMouseButtonDown(0)) {
          
        }
        
        //right mouse button
        if (Input.GetMouseButtonDown(1)) {
          
        }
        
        //middle mouse button
        if (Input.GetMouseButtonDown(2)) {
          
        }
        
        
        //player physics
        
        
        //move north
        if (xdir == 0 && ydir == 1) {
            Move(0f, 1f);
        }
        
        //move northeast
        if (xdir == 1 && ydir == 1) {
            Move(0.7071f, 0.7071f);
        }
        
        //move east
        if (xdir == 1 && ydir == 0) {
            Move(1f, 0f);
        }
        
        //move southeast
        if (xdir == 1 && ydir == -1) {
            Move(0.7071f, -0.7071f);
        }
        
        //move south
        if (xdir == 0 && ydir == -1) {
            Move(0f, -1f);
        }
        
        //move southwest
        if (xdir == -1 && ydir == -1) {
            Move(-0.7071f, -0.7071f);
        }
        
        //move west
        if (xdir == -1 && ydir == 0) {
            Move(-1f, 0f);
        }
        
        //move northwest
        if (xdir == -1 && ydir == 1) {
            Move(-0.7071f, 0.7071f);
        }
    }
    
    //Move Player
    void Move(float x, float y) {
        float X = x * speed;
        float Y = y * speed;
        Vector3 pos = transform.position;
        pos.x += X;
        pos.y += Y;
        transform.position = pos;
    }
    
    //End roll coroutines
    IEnumerator EndRollInvincibility() {
        yield return new WaitForSeconds(roll_iframes_duration);
        
        //disable i-frames
        invincible = false;
    }
    
    IEnumerator EndRoll() {
        yield return new WaitForSeconds(roll_duration);
        
        //end roll
        rolling = false;
    }
}
