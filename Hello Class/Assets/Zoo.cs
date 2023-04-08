using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        Animal tom = new Animal();
        // Monobehaviour�� ������Ʈ ����� �����ϱ� ������ ��ǰ���μ��� ������ �� �ִ�.
        // ��, new�� ����� �� ����.
        // �׷��� Animal Ŭ������ Monobehaviour�� ��ӽ�Ű�� �ʾҴ�.
        tom.name = "��";
        tom.sound = "�Ŀ�!";

        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "����!";

        jerry = tom;
        jerry.name = "��Ű";
        // Ŭ������ �������� ���� Ÿ���̴� <new> (������)
        // ��, ���� �ڵ�� jerry�� tom�� ����Ű���� ������̴�.
        // ����, tom ���� �̸��� "��Ű"�� �ٲ�Եȴ�.

        tom.PlaySound();
        jerry.PlaySound();
    }

    // �� Ÿ�� = C# ���� ���� (int, bool, float, ...), struct<����ü> Ÿ�� (Vector3, Color, ...)
    // ���� Ÿ�� = class Ÿ��, ����Ƽ�� ��� ������Ʈ, MonoBehaviour�� ��ӹ޴� Ŭ����
}
