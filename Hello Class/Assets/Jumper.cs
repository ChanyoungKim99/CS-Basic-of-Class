using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Rigidbody 타입의 변수는 실제 Rigidbody 오브젝트를 참고할 수 있다.

    void Start()
    {
        myRigidbody.AddForce(0, 500, 0);    
    }

}
