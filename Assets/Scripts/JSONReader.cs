using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;
    Layout level;

    private void Awake()
    {
        GameLevel _level = new GameLevel();
        level = JsonUtility.FromJson<Layout>(jsonFile.text);
        GameLevel.getGameLevel().setLevel(level);
    }

    void Start()
    {
        
        print(level);
        //foreach (Employee employee in employeesInJson.employees)
        //{
        //    Debug.Log("Found employee: " + employee.firstName + " " + employee.lastName);
        //}
    }
}