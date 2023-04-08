using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        // Monobehaviour는 컴포넌트 기능을 수행하기 때문에 부품으로서만 존재할 수 있다.
        // 즉, new를 사용할 수 없다.
        // 그래서 Animal 클래스에 Monobehaviour을 상속시키지 않았다.
        tom.name = "톰";
        tom.sound = "냐옹!";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍!";

        jerry = tom;
        jerry.name = "미키";
        // 클래스의 변수들은 참조 타입이다 <new> (포인터)
        // 즉, 위의 코드는 jerry가 tom을 가리키도록 만든것이다.
        // 따라서, tom 역시 이름이 "미키"로 바뀌게된다.

        tom.PlaySound();
        jerry.PlaySound();
    }

    // 값 타입 = C# 내장 변수 (int, bool, float, ...), struct<구조체> 타입 (Vector3, Color, ...)
    // 참조 타입 = class 타입, 유니티의 모든 컴포넌트, MonoBehaviour을 상속받는 클래스
}
