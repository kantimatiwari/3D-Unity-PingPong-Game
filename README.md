1. Setting Up the Project
I started by setting up the game environment in Unity. I chose the Universal Render Pipeline (URP) because it improves visual quality with optimized lighting, shadows, and post-processing effects while maintaining good performance. This is especially useful for making the game visually appealing and efficient to run on multiple devices.

2. Designing the Game World
The game world includes a futuristic arena, two rackets, and a ball. I imported pre-made 3D models for these elements and arranged them in the scene. I adjusted the camera to provide a top-down view, which gives players a clear perspective of the game.

3. Implementing Core Gameplay
Player Controls: I scripted the movement of the player rackets using C#. Players can move the rackets up and down to hit the ball.
Ball Movement: The ball uses a Kinematic Rigidbody, allowing me to control its movement directly while still detecting collisions with rackets and walls. I added randomness to the ball's direction for more challenging gameplay.
AI Opponent: I created an AI-controlled racket that tracks the ball's position along the z-axis, giving players the option to compete against the computer.

4. Adding Features
Scoring System: I added goal detection areas on both sides of the arena. A Goal Controller script detects when a goal is scored, updates the score, resets the ball's position, and starts a new countdown.
Visual Effects with Particle Systems: I used Unity's Particle System to create visual effects like smoke trails on rackets and sparks during ball collisions. This adds a stylish, cyberpunk vibe to the game.
Audio Integration: Using Unity's AudioSource, I added background music and sound effects for hits and goals, making the gameplay more immersive.

5. Key Technologies Explained
Unity: A popular game engine that provides tools for creating 2D/3D games.
Universal Render Pipeline (URP): A feature in Unity for enhancing visuals with optimized rendering.
Kinematic Rigidbody: A physics object in Unity that can be manually controlled but still interacts with other objects.
Particle System: A Unity feature for creating dynamic visual effects like smoke, sparks, or explosions.
AudioSource: A Unity component for adding sound and music to the game.
Que: How did these technologies help in the game development process?

Ans: These technologies simplified the development process by providing pre-built tools and functionalities. For example:

URP gave the game a polished, professional look without compromising performance.
Particle Systems made it easy to create engaging visuals, and AudioSource brought the game to life with sound.
Using Kinematic Rigidbody allowed me to precisely control the ball's movement while maintaining realistic interactions.
