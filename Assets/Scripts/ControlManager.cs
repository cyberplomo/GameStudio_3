using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public static bool tap, swipeLeft, swipeRight, SwipeUp, SwipeDown;

    private bool isDraging = false;

    private Vector2 startTouch, swipeDelta;

    private void Update()
    {
        tap = SwipeDown = SwipeUp = swipeLeft = swipeRight = false;
        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            isDraging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            Reset();
        }

        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                isDraging = true;
                startTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)

            {
                isDraging = false;
                Reset();
            }
        }
        swipeDelta = Vector2.zero;
        if (isDraging)
        {
            if (Input.touches.Length < 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0))
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
        }

        if (swipeDelta.magnitude > 125)
        {
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                //left/right
                if (x < 0)
                    swipeLeft = true;
                else
                    swipeRight = true;
                
            }
            else
            {
                //Up/down
                if (y < 0)
                    SwipeDown = true;
                else
                    SwipeUp = true;
            }

            Reset();
        }
            
    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDraging = false;
    }
   
}