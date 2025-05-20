using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2; // 멤버변수 (필드)

    void Start()
    {
        int addResult = AddMethod(); // 함수 호출
        int MinusResult = MinusMethod(); // 함수 호출
        Debug.Log($"더한값 : {addResult} / 뺀 값 : {MinusResult}");;
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
