using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO pretty sure that this can now just be merged with attack
public class CuteAlienAttack : Attack
{
    // this is how many active frames 


    public void Update()
    {
        //Debug.Log("current frame: " + currentActiveFrame);
        if (currentActiveFrame == disableHitboxFrame)
        {
            hitboxes[0].stopCheckingCollision();
            UnityEngine.Debug.Log("Stop checking collision");
        }
        else if (currentActiveFrame == enableHitboxFrame)
        {
            hitboxes[0].startCheckingCollision();
        }
        else if (currentActiveFrame >= totalFrames)
        {
            characterController.setNormalState();
            currentActiveFrame = 0;
            enabled = false;
            return;
        }

        hitboxes[0].hitboxUpdate();

        currentActiveFrame++;

    }
}