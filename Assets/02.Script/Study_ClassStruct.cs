using UnityEngine;

public class Study_Class //heap
{
    public int number;
    public Study_Class(int _number) 
    {
        this.number = _number;
    }
}
public struct Study_Struct //stack
{
    public int number;
    public Study_Struct(int _number)
    {
        this.number = _number;
    }
}
public class Study_ClassStruct : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("클래스 ----------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        c1.number = 100;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");

        Debug.Log("구조체 ----------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        s1.number = 100;
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }
}
