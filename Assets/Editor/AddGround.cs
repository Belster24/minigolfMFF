using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(AddGround))]
public class AddGround : Editor
{   
    public static int number = 0;

    [MenuItem("Golf/Create ground/Classic path")]
    static void ClassicEdit()
    {
        number++;
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.name = "Ground" + number;
        GameObject wall1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall1.tag = "Obstruct";
        GameObject Wall2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Wall2.tag = "Obstruct";
        wall1.transform.parent = ground.transform;
        Wall2.transform.parent = ground.transform;
        

        ground.transform.localScale = new Vector3(10, 0.5f, 10);
        wall1.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);
        Wall2.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);

        wall1.transform.localPosition = new Vector3(-0.462f, 1.14f, 0);
        Wall2.transform.localPosition = new Vector3(0.46f, 1.14f, 0);



        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Wall.mat");
        Material material1 = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/MenuGround.mat");



        wall1.GetComponent<Renderer>().material = material;
        Wall2.GetComponent<Renderer>().material = material;

        ground.GetComponent<Renderer>().material = material1;


    }

    [MenuItem("Golf/Create ground/Start")]
    static void StartingEdit()
    {
        number++;
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.name = "Start" + number;
        GameObject wall1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall1.tag = "Obstruct";
        GameObject Wall2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Wall2.tag = "Obstruct";
        GameObject Wall3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Wall3.tag = "Obstruct";

        wall1.transform.parent = ground.transform;
        Wall2.transform.parent = ground.transform;
        Wall3.transform.parent = ground.transform;


        ground.transform.localScale = new Vector3(10, 0.5f, 10);
        wall1.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);
        Wall2.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);
        Wall3.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);

        wall1.transform.localPosition = new Vector3(-0.462f, 1.14f, 0);
        Wall2.transform.localPosition = new Vector3(0.46f, 1.14f, 0);
        Wall3.transform.localPosition = new Vector3(-0.004f, 1.14f, -0.461f);

        Wall3.transform.Rotate(0, 90, 0);

        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Wall.mat");
        Material material1 = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/MenuGround.mat");



        wall1.GetComponent<Renderer>().material = material;
        Wall2.GetComponent<Renderer>().material = material;
        Wall3.GetComponent<Renderer>().material = material;

        ground.GetComponent<Renderer>().material = material1;




    }

    [MenuItem("Golf/Create ground/Up")]
    static void UpThereEdit()
    {
        number++;
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.name = "GroundUp" + number;
        GameObject wall1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall1.tag = "Obstruct";
        GameObject Wall2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Wall2.tag = "Obstruct";
   

        wall1.transform.parent = ground.transform;
        Wall2.transform.parent = ground.transform;
        


        ground.transform.localScale = new Vector3(10, 0.5f, 10);
        wall1.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);
        Wall2.transform.localScale = new Vector3(0.074f, 2.14f, 0.999f);
        

        wall1.transform.localPosition = new Vector3(-0.462f, 1.14f, 0);
        Wall2.transform.localPosition = new Vector3(0.46f, 1.14f, 0);
        

        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Wall.mat");
        Material material1 = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/MenuGround.mat");

        ground.transform.Rotate(-16.569f, 0, 0);

        wall1.GetComponent<Renderer>().material = material;
        Wall2.GetComponent<Renderer>().material = material;
       

        ground.GetComponent<Renderer>().material = material1;




    }
}

