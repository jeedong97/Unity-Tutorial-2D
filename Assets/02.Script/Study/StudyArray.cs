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

        Debug.Log($"현재 list에 있는 데이터 수 : {listNumber.Count}");
        Debug.Log($"현재 list에 있는 마지막 데이터 : {listNumber[listNumber.Count-1]}");
    }
}
