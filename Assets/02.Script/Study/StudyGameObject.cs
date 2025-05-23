using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    void Awake()
    {
        CreateAmongus();
    }

   public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, this.transform);
        obj.name = "AmongUs";
    }
}
