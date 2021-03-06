﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animation anim;

    private AnimationClip clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("Cube_2");
            anim.PlayQueued("Cube_2");
            anim.Blend("Cube_2");
            anim.CrossFade("Cube_2");
            if (!anim.IsPlaying("Cube_2"))
                anim.Play("Cube_2");
            anim.Stop();
            anim.wrapMode = WrapMode.PingPong;
            anim.clip = clip;
            anim.animatePhysics = false;
        }
    }
}
