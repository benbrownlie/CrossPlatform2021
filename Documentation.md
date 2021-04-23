## Documentation
Here I will describe all the purpose of the scrips and their various functions.

### EnemyAttackBehavior

#### *Variables*
* private float _damage: Used to set how much damage an enemy will deal out.
* private EnemyMovementBehavior _movement: Reference to the enemy's movement script.

#### *Functions*
* private void Awake(): sets _movement to the get component call with EnemyMovementBehavior passed in.
* private void OnCollisionEnter(Collision collision): Holds the logic for what will occur when an Enemy collides with an object.

###  EnemyMovementBehavior

#### *Variables*
* public GameObject target: A reference to the enemy's target.
* public float speed: Variable used to set the enemy's speed.
* private NavMeshAgent _agent: Reference to the navmesh agent.
* public Rigidbody rigidbody: A reference to the enemy's rigidbody.
* public float StartCos: variable used to represent the enemy's starting cosine.

#### *Functions*
* void Start(): Used to call GetComponent for both _agent and the rigidbody.
* void Update(): Sets the agent to lookat its target and then sets it destination to the target causing them to follow them around.

### EnemySpawnBehavior

#### *Variables*
* public float TimeBetweenSpawns: Used to set the time it takes between when an enemy will spawn into the scene after the last.
* public bool StopSpawning: Used to tell the game if the enemy should continue to spawn or not.
* public GameObject EnemyTarget: Reference to the enemy's target.

#### *Functions*
* void Start(): Used to spawn in enemies into the scene by calling SpawnEnemies.
* public IEnumerator SpawnEnemies(): Instantiates enemies, calls spawnedEnemy's GetComponent and repeats after the TimeBetweenSpawns time has passed.

### GameManagerBehavior

#### *Variables*
* private static bool _gameOver: Bool to set if the game is over or not.
* public HealthBehavior _playerHealth: Reference to the player's health.
* public GameObject _gameOverScreen: Reference to the gameover overlay.

#### *Functions*
* public static bool GameOver: returns _gameOver.
* public void RestartGame(): Restarts the game to the beginning of the scene.
* public void EndGame(): Closes the application.
* void Update(): Sets game over to be the player's health less than or equal to 0. Sets gameoverscreen to be active.

### HealthBarBehavior

#### *Variables*
* private HealthBehavior _health: Reference to the user's health.
* private Gradient _healthGradient: Health gradient used for the healthbar.
* private Image _fill: The filled in color.
* private Slider _slider: The Healthbar itself.

#### *Functions*
* void Start(): Calls slider's GetComponent, sets its maximum value to be the user's health, sets the fill's color to be the gradient.
* void Update(): Updates as the game goes along, sets the slider's value to be the player's health, sets the fill color to be health gradient.

### HealthBehavior

#### *Variables*
* private float _health: Used to set the user's health.

#### *Functions*
* public float Health: returns the variable _health.
* public void TakeDamage(float damage): subtracts damage from the user's health. If the user's health is less than 0, sets it to 0.
* void Update(): If the health is 0, destroy the object.

### PlayerMovementBehavior

#### *Variables*
* public float speed: Used to set the player's speed.
* private Vector3 _mousePos: Stores the player's mouse position.
* private Ray _mouseRay: Represents the ray to the mouse.
* public CharacterController characterController: Reference to the player's CharacterController.

#### *Functions*
* Update(): Checks if the player is pressing Mouse1.  Using rays moves the player in the direction of the mouseclick using its speed scaled by the direction.