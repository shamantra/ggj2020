using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;

    void Start()
    {
        Layout level = JsonUtility.FromJson<Layout>(jsonFile.text);
        print(level);
        //foreach (Employee employee in employeesInJson.employees)
        //{
        //    Debug.Log("Found employee: " + employee.firstName + " " + employee.lastName);
        //}
    }
}