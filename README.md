# 🐝 Bee Shooting Game 🎯

A fun and simple 2D shooting game built with Unity where the player shoots down flying bees for points. Buzz, aim, and shoot to win!

---

## 🎮 Game Description

In the **Bee Shooting Game**, the player controls a shooter at the bottom of the screen and must shoot down as many flying bees as possible. Each bee hit increases the score. The game ends if 3 bees cross the player.

---

## 🛠️ Features

- 🐝 Randomly spawned bees
- 🎯 Shooting mechanics
- 🔫 Player-controlled shooter
- 💥 Score counter
- ❌ Game over condition when 3 bees pass the player
- 🎵 Sound effects (optional)

---

## 📦 Project Structure

This section explains the structure and role of each file and folder in the `BeeShootingGame` Unity project.

---

### 🗂️ BeeShootingGame/

The root directory of your Unity project.

---

### 📁 Assets/

This is the main folder where all Unity assets are stored including scripts, scenes, sprites, prefabs, etc.

---

### 📁 Scripts/

Contains all the C# scripts that power the gameplay.

#### 📄 MakeEnemy.cs
- Responsible for spawning (instantiating) bees at random intervals and positions.
- Uses `Instantiate()` to create enemies in the game scene.

#### 📄 Bullet.cs
- Handles the behavior of the bullet (player's projectile).
- Controls movement and detects collisions with bees.

#### 📄 PlayerController.cs
- Manages the player's input and movement.
- Listens for shooting commands (like pressing spacebar) and spawns bullets.

#### 📄 Enemy.cs
- Controls bee behavior, such as falling movement.
- May include collision detection with the player or bottom boundary.

#### 📄 GameManager.cs
- Manages overall game state.
- Tracks how many bees have crossed the player.
- Triggers **Game Over** when 3 bees escape.

---

### 📁 Prefabs/

- Stores reusable GameObjects like:
  - Bee prefab
  - Bullet prefab
  - Player shooter prefab
- Prefabs help in instantiating multiple objects during gameplay.

---

### 📁 Scenes/

#### 📄 MainScene.unity
- The main Unity scene where the game takes place.
- Contains the game environment, objects, and references to scripts.

---

### 📁 Sprites/

- Contains all visual assets such as:
  - Bee images
  - Shooter graphics
  - Backgrounds or UI elements

---

### 📁 Audio/

- Holds audio files like:
  - Shooting sounds
  - Bee buzzing effects
  - Game over music or background soundtrack

---

This structured organization helps in keeping the Unity project clean, modular, and easy to maintain.

---

## ▶️ How to Play

- **Move**: Use `A` / `D` or `←` / `→` to move the shooter left or right.
- **Shoot**: Press `Spacebar` to fire bullets.
- 🎯 Destroy the bees before they reach you!
- ❗ If **3 bees** cross the shooter, the game ends.

---

Open the project in Unity (Unity 2021.3 LTS or later).

Load the scene:

Go to Assets/Scenes/MainScene.unity

Press the Play button in Unity Editor.

---

## 📝 License

This project is open source and available under the **MIT License**.

---


