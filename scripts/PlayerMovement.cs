using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //declare player vars
    
    int xdir; //player x direction
    int ydir; //player y direction

    //Start (Lifecycle Function)
    void Start()
    {
        //init
        xdir = 0;
        ydir = 0;
    }

    //Update (Lifecycle Function)
    void Update()
    {
        xdir = 0;
        ydir = 0;
      
        
        //get keyboard inputs
        
        //up
        if (Input.GetKeyDown(KeyCode.W)) {
            ydir += 1;
        }
        
        //down
        if (Input.GetKeyDown(KeyCode.S)) {
            ydir -= 1;
        }
        
        //right
        if (Input.GetKeyDown(KeyCode.D)) {
            xdir += 1;
        }
        
        //left
        if (Input.GetKeyDown(KeyCode.A)) {
            xdir -= 1;
        }
        
        //dodge roll (with iframes)
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            
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
        
        //move north
        if (xdir == 0 && ydir == 1) {
          
        }
        
        //move northeast
        if (xdir == 1 && ydir == 1) {
          
        }
        
        //move east
        if (xdir == 1 && ydir == 0) {
          
        }
        
        //move southeast
        if (xdir == 0 && ydir == 1) {
          
        }
        
        //move south
        if (xdir == 0 && ydir == 1) {
          
        }
        
        //move southwest
        if (xdir == 0 && ydir == 1) {
          
        }
        
        //move west
        if (xdir == 0 && ydir == 1) {
          
        }
        
        //move northwest
        if (xdir == 0 && ydir == 1) {
          
        }
    }
    
    //Move Player
    void Move() {
      
    }
}
