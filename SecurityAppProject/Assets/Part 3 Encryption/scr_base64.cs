using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_base64 : MonoBehaviour {
	public InputField mainInputField;
	public Text Stringy1;
	public Text Stringy2;
	public string stringingy;
	// Converts string to 64
	public static string Base64Encode(string plainText) {
		var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
		return System.Convert.ToBase64String(plainTextBytes);
	}

	// Converts 64 to string 
	public static string Base64Decode(string base64EncodedData) {
		
		if( (base64EncodedData.Length % 4 !=0) || (base64EncodedData.Length ==0))
			return "Invalid";

		else {
				
			var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
			return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Update string
		stringingy = mainInputField.text;

		// Encode string 
		Stringy1.text = "Encoded: " + Base64Encode(stringingy);

		// check if non zero
		if (stringingy.Length ==0)
			Stringy2.text = "Decoded: " + "Invalid";
		else if((stringingy !="" )||(stringingy != null)|| (stringingy.Length % 4==0))
			Stringy2.text = "Decoded: " + Base64Decode(stringingy);
		else 
			Stringy2.text = "Decoded: " + "Invalid";
	}
}
