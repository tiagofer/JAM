using UnityEngine;
using System.Collections;

public class Region : MonoBehaviour {

	private bool _isFull;
	public bool IsFull{
		set{
			_isFull = value;
		}
		get{
			return _isFull; 
		}
	}
	
	private int _lossRate;
	public int LossRate{
		set{
			_lossRate = value;
		}
		get{
			return _lossRate;
		}
	}
	
	private int _waterLevel;
	public int WaterLevel{
		set{
			_waterLevel = value;
		}
		get{
			return _waterLevel;
		}
	}
	
	public void updateWaterLevel(int increment){
		WaterLevel += increment; 
	}
	
	public void printLevel(string text){
		Debug.Log (text + WaterLevel);
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}