using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject Obj; // ť�� ���� ������Ʈ�� �������� �ʹ� 

    public string changeName;
    void Start()
    {
        Obj= GameObject.Find("Main Camera");    
    }
}
