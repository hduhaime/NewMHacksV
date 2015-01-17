using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class changecolor : MonoBehaviour {

	public GameObject myo = null;

	private Pose _lastPose = Pose.Unknown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();

		if (thalmicMyo.pose != _lastPose) {

						_lastPose = thalmicMyo.pose;
						if (thalmicMyo.pose == Pose.Fist) {
								thalmicMyo.Vibrate (VibrationType.Medium);
								// Change material when wave in, wave out or double tap poses are made.
						} 
				}
		print (thalmicMyo.accelerometer);
		print ("hello");

	}
}
