using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNoRepeat : MonoBehaviour {
	
	private List<string> alpha = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H"};//sampel list
	private List<string> randomList = new List<string>();//move the alpa list to this list

	public string x;
	public Text text;

	void Start () {
		RandomTest ();
	}

	void Update () {
		
	}
	public void RandomTest(){

		int countList = alpha.Count;
		for (int i = 0; i < countList; i++) {
			int rand = Random.Range(0,alpha.Count-1);
			randomList.Add(alpha[rand]);//add the randomList with the alpha random index
			alpha.RemoveAt(rand);//remove the current alpha to prevent repeats index
			x = x +" - "+randomList[i];
			text.text = x;//make new Text in hierarchy to check the list
		}
	}
}
