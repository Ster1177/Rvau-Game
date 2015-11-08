#pragma strict

var waypoint : Transform[];
private var speed : float = 0.05;
//var hud : HUD;
private var currentWaypoint : int = 0;
var loop : boolean = true;
var player : Transform;
//var dead : boolean;
private var character : CharacterController;
private var lastPos : Vector3;
 
 function Start ()
 {
 	//Debug.Log("1");
 	// Search for all waypoints in the game
 	var waypointObjs = GameObject.FindGameObjectsWithTag("Waypoint");
 	 var transforms = new Array();
 	 for(var obj : GameObject in waypointObjs)
    {
		//Debug.Log("Once!");
        transforms.Push(obj.transform);
    }
    waypoint = transforms.ToBuiltin(Transform);
 	randomizeArray(waypoint);
 	
 	//GetComponent.<Animation>().wrapMode = WrapMode.Loop;
    character = GetComponent(CharacterController);
    
//    hud = GameObject.Find("Target").GetComponent(HUD);
 //   dead = false;
    lastPos = transform.position;
    //InvokeRepeating("RandomRun", 3f, 2f);
 }
 
 function Update () 
 {
    // speed = hud.zombieSpeed;
	 		// calculate the actual horizontal velocity: 
	 		//var vel = speed / Time.deltaTime;  
	 		 
	     if(currentWaypoint < waypoint.length)
	     {
	         var target : Vector3 = waypoint[currentWaypoint].position;
	         target.y = transform.position.y; // keep waypoint at character's height
	         var moveDirection : Vector3 = target - transform.position;
	         if(moveDirection.magnitude < 0.001)
	         {
	         	 Debug.Log("Muito Perto");
	             transform.position = target; // force character to waypoint position
	             currentWaypoint++;
	         }
	         else
	         {
	             Debug.Log("Speed: " + speed.ToString("F4"));
	             transform.LookAt(target);
	             character.Move(moveDirection.normalized * speed * Time.deltaTime);
	         }
	     }
	     else
	     {
	         if(loop)
	         {
	             currentWaypoint=0;
	         }
	     }
     }
 
 function RandomRun() 
 {
 	 if(Random.Range(0,5) == 0){
 	 	currentWaypoint++;
 	 }
 	 if(Random.Range(0,2) == 0){
 	 	speed += Random.Range(-5,5);
 	 	if(speed < 0)
    		speed = 0; 
 	 }
 }
 
 
 function nextWP(){
	currentWaypoint++;
}

private function randomizeArray(arr : Transform[]){
    for (var i = 0; i < arr.Length; i++){
        swap(arr, i, Random.Range(i,arr.length));
    }
}
private function swap(arr : Transform[], id1 : int, id2 : int){
    var temp = arr[id1];
    arr[id1] = arr[id2];
    arr[id2] = temp;
}