using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2; // ������� (�ʵ�)

    void Start()
    {
        int addResult = AddMethod(); // �Լ� ȣ��
        int MinusResult = MinusMethod(); // �Լ� ȣ��
        Debug.Log($"���Ѱ� : {addResult} / �� �� : {MinusResult}");;
    }

    int AddMethod()
    {
        int result = number1 + number2;
        return result;
    }
    int MinusMethod()
    {
        int result = number1 - number2;
        return result;
    }
}
