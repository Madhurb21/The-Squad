using System.Collections;
using System.Collections.Generic;
using UnityEngine
    using UnityEngiine.UI;

public class Scorescript : MonoBehaviour
{
    public static int scorezombie1 = 0;
    
    Text score;
   
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> (); 
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scorezombie1;
    }
}
