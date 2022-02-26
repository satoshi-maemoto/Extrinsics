using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class NewBehaviourScript : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraB;
    public TMP_Text text;
    public TMP_Text textUI;

    void Update()
    {
        var T = this.cameraB.transform.position - this.cameraA.transform.position;
        var R = Quaternion.FromToRotation(this.cameraA.transform.forward, this.cameraB.transform.forward);
        this.text.text = 
        $"A->B\n" +
        $"R:({R.x:f2},{R.y:f2},{R.z:f2})\n" +
        $"T:({T.x:f2},{T.y:f2},{T.z:f2})"
        ;
        this.textUI.text = this.text.text;
    }
}
