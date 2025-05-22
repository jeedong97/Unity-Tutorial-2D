using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log($"�̸� : {obj.name}"); // ���ӿ�����Ʈ�� �̸�
        Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");
    }

}