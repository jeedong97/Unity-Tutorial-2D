using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public List<int> listNumber = new List<int>();
    void Start()
    {
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        Debug.Log($"���� list�� �ִ� ������ �� : {listNumber.Count}");
        Debug.Log($"���� list�� �ִ� ������ ������ : {listNumber[listNumber.Count-1]}");
    }
}
