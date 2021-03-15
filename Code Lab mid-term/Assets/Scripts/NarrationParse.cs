using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class NarrationParse : MonoBehaviour
{
    // Start is called before the first frame update
    //make a directory and file for the string to be in
    public string FILE_NARRATION;
    private const string DIR = "/Text/";
    private string FILE_PATH;
    private string readText;
    public Text text; //for the text on the canvas
    private string[] lines; // to parse the text
    void Start()
    {
        //read the flie and separate it by every line and put it into the list
        FILE_PATH = Application.dataPath + DIR + FILE_NARRATION;
        readText = File.ReadAllText(FILE_PATH);
        lines = readText.Split('\n');
    }

    // Update is called once per frame
    void Update()
    {
        //update the text to read the line that matches the level you are on
        text.text = lines[GameManager.instance.GetComponent<ASCIILevelLoader>().currentLevel];
    }
}
