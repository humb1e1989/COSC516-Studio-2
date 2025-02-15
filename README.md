# 🎳 Bowling With Physics

> A bowling game made with **Unity**. This is the submission for _**COSC516 Studio 2**_

## 📸 Game Preview

<video src="https://github.com/user-attachments/assets/03f84478-4215-471e-89bc-63c14c7f7ab1"></video>
_Screenshot of the game in action_

---

## 🎯 Main Features
- 🏀 **Realistic Physics** – Ball rolling, pin collisions, and gutter interaction
- 🎭 **Invisible Walls & Physics Layers** – Ensures proper gameplay mechanics
- 🏗 **Cinemachine Camera** – Follows the ball during play. It allows smooth third-person aiming and tracking
- 🎯 **Aiming Indicator** – Visual cue for ball launching direction
- 🎳 **Scoring System** – Automatic tracking of knocked-down pins
- 🔄 **Game Reset Functionality** – Allows replaying rounds without restarting but **NOT** reset the scores.
- 🌟 **Custom Models & Materials** – Enhanced visual realism
---

## 📌 Key Features Corresponding to Marking Criteria
### ✅ **Base Game Mechanics**
- **Ball Rolling & Pin Collision** – Implemented using `Rigidbody` physics to ensure realistic interactions.
- **Prefab System** – Created reusable `Ball`, `Pins & Pin Collection`, and `Gutter` prefabs for efficient game object management.
- **Gutter Mechanics** – Implemented `OnTriggerEnter` to detect when `Ball` enters the `Gutter`and after entering, the ball will go along the `Gutter` til reach the end

### ✅ **Player & Camera Controls**
- **Cinemachine Camera** – Integrated `Cinemachine` for smooth tracking and third-person aiming.
- **Player Movement** – `A/D` keys allow smooth left and right movement.
- **Ball Aiming & Shooting** – Implemented `LaunchIndicator` to visually guide the player before throwing the ball.

### ✅ **Game Management & Scoring**
- **Pin Fall Detection** – Implemented `OnTriggerEnter` in `FallTrigger.cs` to track knocked-down pins.
- **Score System** – Score automatically updates in UI when pins fall.
- **Game Reset Functionality** – Pressing `R` resets `Ball` and `Pins` and keep persist score.

### ✅ **Polish & User Experience Enhancements**
- **Custom 3D Models** – Imported `CC0` licensed models for `Ball`, `Pins`, and `LaunchIndicator`.
- **Physics Materials** – Adjusted friction and bounciness for more realistic ball and pin movement.
- **User Interface** – Improved player feedback with dynamic UI updates.
- **Camera Tracking** – Ensured the camera follows the player smoothly.

---

## 🛠 Installation & Setup
### **1️⃣ Download & Open the Project**
1. **Clone the repository**
   ```bash
   git clone https://github.com/humb1e1989/COSC516-Studio-2.git
   cd COSC516-Studio-2
   ```
2. **Open in Unity**
   - Open **Unity Hub**
   - Click `Open` and select the project folder
   - Ensure you are using **Unity 2021.3 LTS** or later

### **2️⃣ Run the Game**
1. Open the `SampleScene` from the `Scenes` folder.
2. Click **`Play`** in the Unity Editor.
3. Adjust player controls and enjoy the game!
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
│   ├── 📂 Materials  # Textures & Materials
│   ├── 📂 Models  # Imported 3D Models
│   ├── 📂 Prefabs  # Game Objects Prefabs
│   ├── 📂 Scenes  # Unity Scenes
│   ├── 📂 Scripts  # C# Scripts
│   ├── 📂 TextMesh Pro  # UI Font System
├── 📂 Logs  # Debugging & Error Logs
├── 📂 Packages  # Unity Package Manager Dependencies
├── 📂 ProjectSettings  # Unity Project Configuration
├── 📂 Temp  # Temporary Build Files (Auto-generated)
├── 📂 UserSettings  # Unity User Preferences
```


## 🙌 Credits
- **_LostboiSurviveA1one_ made this** 
- **Assets from:** `poly.pizza`, `Kenney.nl`, `Quaternius`, and `CC0 Licensed Resources`
```
