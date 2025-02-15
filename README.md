# 🎳 Bowling With Physics

> A physics-based bowling game developed in **Unity**, implementing realistic physics interactions, user-friendly controls, and immersive gameplay.

## 📸 Game Preview
![Game Screenshot](https://your-image-link.com)  
_Screenshot of the game in action_

---

## 🎯 Features
- 🏀 **Realistic Physics** – Ball rolling, pin collisions, and gutter interaction
- 🎳 **Scoring System** – Automatic tracking of knocked-down pins
- 🌟 **Custom Models & Materials** – Enhanced visual realism
- 🏗 **Cinemachine Camera** – Follows the ball during play. It allows smooth third-person aiming and tracking.
- 🎯 **Aiming Indicator** – Visual cue for ball launching direction
- 🎭 **Invisible Walls & Physics Layers** – Ensures proper gameplay mechanics
- 🔄 **Game Reset Functionality** – Allows replaying rounds without restarting and reseting the score
---

## 📌 Key Features Corresponding to Marking Criteria
### ✅ **Base Game Mechanics**
- **Ball Rolling & Pin Collision** – Implemented using `Rigidbody` physics to ensure realistic interactions.
- **Prefab System** – Created reusable `Ball`, `Pins & Pin Collection`, and `Gutter` prefabs for efficient game object management.
- **Gutter Mechanics** – Implemented `OnTriggerEnter` to detect when `Ball` enters the `Gutter`, ensuring correct game rules.

### ✅ **Player & Camera Controls**
- **Cinemachine Camera** – Integrated `Cinemachine` for smooth tracking and third-person aiming.
- **Player Movement** – `A/D` keys allow smooth left and right movement.
- **Ball Aiming & Shooting** – Implemented `LaunchIndicator` to visually guide the player before throwing the ball.

### ✅ **Game Management & Scoring**
- **Pin Fall Detection** – Implemented `OnTriggerEnter` in `FallTrigger.cs` to track knocked-down pins.
- **Score System** – Score automatically updates in UI when pins fall.
- **Game Reset Functionality** – Pressing `R` resets `Ball`, `Pins`, and `Score`, allowing seamless replay.

### ✅ **Polish & User Experience Enhancements**
- **Custom 3D Models** – Imported `CC0` licensed models for `Ball`, `Pins`, and `LaunchIndicator`.
- **Physics Materials** – Adjusted friction and bounciness for more realistic ball and pin movement.
- **UI & Sound Effects** – Improved player feedback with dynamic UI updates and collision sound effects.
- **Camera Tracking** – Ensured the camera follows the ball smoothly, enhancing immersion.

---

## 🛠 Installation & Setup
### **1️⃣ Clone the Repository**
```bash
git clone https://github.com/your-repo/bowling-with-physics.git
cd bowling-with-physics
```

### **2️⃣ Open in Unity**
1. Open **Unity Hub**
2. Click `Open` and select the project folder
3. Ensure you are using **Unity 2021.3 LTS** or later

### **3️⃣ Run the Game**
- Click **`Play`** in the Unity Editor

---

## 🎮 Controls
| Key | Action |
|------|---------|
| `A/D` | Move Player Left/Right |
| `Mouse` | Adjust Camera |
| `Space` | Throw Ball |
| `R` | Reset Game |

---

## 🏗 Project Structure
```
📂 BowlingWithPhysics
├── 📂 Assets
│   ├── 📂 Scripts  # C# Scripts
│   ├── 📂 Prefabs  # Game Objects Prefabs
│   ├── 📂 Materials  # Textures & Materials
│   ├── 📂 Audio  # Sound Effects
│   ├── 📂 UI  # UI Elements
├── 📂 Scenes  # Unity Scenes
├── 📄 README.md  # Documentation
```


## 🔧 Technologies Used
- 🎮 **Unity (2021.3 LTS)**
- 🎲 **C# (Game Logic & Physics)**
- 🏗 **Rigidbody & Colliders** for physics interactions
- 🎥 **Cinemachine** for dynamic camera control
- 🎨 **Custom 3D Models & Materials**
- 🔊 **AudioSource** for sound effects
- 🖥 **Unity UI & TextMeshPro** for scorekeeping


---

## 📜 License
This project is **MIT Licensed**. Feel free to use and modify!

---

## 🙌 Credits
- **_LostboiSurviveA1one_ made this** 
- **Assets from:** `poly.pizza`, `Kenney.nl`, `Quaternius`, and `CC0 Licensed Resources`
