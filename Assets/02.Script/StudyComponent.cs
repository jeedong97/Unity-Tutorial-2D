using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject Obj; // 큐브 게임 오브젝트를 가져오고 싶다 

    public string changeName;
    void Start()
    {
        Obj= GameObject.Find("Main Camera");    
    }
}
