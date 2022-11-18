using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpinnerMode : ScriptableObject
{
	[SerializeField]
	private int intValue;

	public int intValue2
	{
		get { return intValue; }
		set { intValue = value; }
	}

}
