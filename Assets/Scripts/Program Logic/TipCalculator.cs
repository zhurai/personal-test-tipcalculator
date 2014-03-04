using UnityEngine;
using System.Collections;

public class TipCalculator : MonoBehaviour {
	public float bill;
	public float tippct;
	public float tip;
	public float total;
	
	public GameObject objbill;
	public GameObject objtippct;
	public GameObject objtip;
	public GameObject objtotal;


	public void Update()
	{
		// Get the required Labels
		UILabel labelbill = objbill.GetComponent<UILabel>();
		UILabel labeltippct = objtippct.GetComponent<UILabel>();
		UILabel labeltip = objtip.GetComponent<UILabel>();
		UILabel labeltotal = objtotal.GetComponent<UILabel>();

		// calculation
		bill = float.Parse (labelbill.text);
		tippct = float.Parse (labeltippct.text);
		tip = tippct * bill;
		total = tip + bill;

		// update totals
		labeltip.text = tip.ToString("C");
		labeltotal.text = total.ToString("C");

	}
}
