using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animal         // MonoBehaviour을 상속하지 않으면 컴포넌트로서의 기능 상실
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}
