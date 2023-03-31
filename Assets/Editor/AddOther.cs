using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;



[CustomEditor(typeof(AddOther))]
public class AddOther : Editor
{
    public static int number = 0;

    [MenuItem("Golf/Add teleport")]
    static void TeleportEdit()
    {
        number++;
        GameObject def = new GameObject("Teleport"+number);
        GameObject telstart = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        telstart.name = "TeleportStart";
        GameObject telend = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        telend .name = "TeleportEnd";
        telstart.transform.parent = def.transform;
        telend.transform.parent = def.transform;

        Teleport teleportScr = telstart.AddComponent<Teleport>(); // Attach script to GameObject



        def.transform.localScale = new Vector3(1, 1, 1);
        telstart.transform.localScale = new Vector3(1.55f, -0.04f, 1.22f);
        telend.transform.localScale = new Vector3(1.55f, -0.04f, 1.22f);

        telstart.transform.localPosition = new Vector3(-2.93f, 0.26f, 0);
        telend.transform.localPosition = new Vector3(2.93f, 0.26f, 0);



        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Black.mat");

        telstart.GetComponent<Renderer>().material = material;
        telend.GetComponent<Renderer>().material = material;



        teleportScr.TeleportEnd = telend.transform;

    }

    [MenuItem("Golf/Add hole")]
    static void HoleEdit()
    {
        number++;
        GameObject def = new GameObject("Hole" + number);
        GameObject holepre = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        holepre.name = "HolePrekrivac";
        GameObject hole = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        hole.name = "Hole";
        holepre.transform.parent = def.transform;
        hole.transform.parent = def.transform;

        Dropper teleportScr = hole.AddComponent<Dropper>(); // Attach script to GameObject



        def.transform.localScale = new Vector3(1, 1, 1);
        holepre.transform.localScale = new Vector3(2.2f, 1f, 2.2f);
        hole.transform.localScale = new Vector3(1.2f, 0.9725482f, 1.2f);

        holepre.transform.localPosition = new Vector3(0f, -0.043f, 0);
        //hole.transform.localPosition = new Vector3(2.93f, 0.26f, 0);



        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Black.mat");

        Material material1 = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Outerhole.mat");

        holepre.GetComponent<Renderer>().material = material1;
        hole.GetComponent<Renderer>().material = material;



        teleportScr.hole = hole.transform;

    }

    [MenuItem("Golf/Add Ball")]
    static void PlayerEditor()
    {

        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.tag = "Player";
        ball.name = "Ball";

        ball.transform.localPosition = new Vector3(0, 0.8f, 0);
        ball.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        Material material = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/ball.mat");

        ball.GetComponent<Renderer>().material = material;
    }
}