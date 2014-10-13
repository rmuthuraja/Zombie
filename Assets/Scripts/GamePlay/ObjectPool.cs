﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour {

	public static ObjectPool Instance;
	public GameObject pooledObject;
	public int pooledAmount = 0;
	public bool willGrow = false;

	List<GameObject> pooledObjects;

	void Awake() {

		Instance = this;
	}

	// Use this for initialization
	void Start () {
	
		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) {

			GameObject obj = (GameObject)Instantiate(pooledObject);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
	}

	public GameObject GetPooledObject() {

		for(int i = 0; i < pooledObjects.Count; i++) {

			if(!pooledObjects[i].activeInHierarchy) {

				return pooledObjects[i];
			}
		}

		if (willGrow) {
				
			GameObject obj = (GameObject)Instantiate(pooledObject);
			pooledObjects.Add(obj);
			return obj;
		}

		return null;
	}
}
