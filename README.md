# 🎳 Bowling (with Physics)

> A physics-based bowling game developed in **Unity**, implementing realistic physics interactions, user-friendly controls, and immersive gameplay.

## 📸 Game Preview
![Game Screenshot](https://your-image-link.com)  
_Screenshot of the game in action_

---

## 🎯 Features
- 🏀 **Realistic Physics** – Ball rolling, pin collisions, and gutter interaction
- 🎳 **Scoring System** – Automatic tracking of knocked-down pins
- 🚀 **Polished Gameplay** – Smooth controls, enhanced UI, and immersive effects
- 🔊 **Sound Effects** – Feedback when ball hits pins
- 📷 **Dynamic Camera** – Follows the ball during play
- 🌟 **Custom Models & Materials** – Enhanced visual realism
- 🏗 **Cinemachine Camera** – Allows smooth third-person aiming and tracking
- 🎯 **Aiming Indicator** – Visual cue for ball launching direction
- 🎭 **Invisible Walls & Physics Layers** – Ensures proper gameplay mechanics
- 🔄 **Game Reset Functionality** – Allows replaying rounds without restarting

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

---

## 🔧 Technologies Used
- 🎮 **Unity (2021.3 LTS)**
- 🎲 **C# (Game Logic & Physics)**
- 🏗 **Rigidbody & Colliders** for physics interactions
- 🎥 **Cinemachine** for dynamic camera control
- 🎨 **Custom 3D Models & Materials**
- 🔊 **AudioSource** for sound effects
- 🖥 **Unity UI & TextMeshPro** for scorekeeping

---

## 📌 Implemented Features as per Assignment
### ✅ **Base Game Setup**
- **Ball Rolling & Pin Collision** – Implemented using `Rigidbody`
- **Prefab System** – Used for managing multiple objects efficiently
- **Trigger Colliders (Gutter)** – Detects when `Ball` enters `Gutter`

### ✅ **Player & Camera Controls**
- **Cinemachine Camera** – Smooth tracking and aiming
- **Player Movement** – `A/D` to move left and right
- **Ball Aiming & Shooting** – Uses `LaunchIndicator`

### ✅ **Game Management**
- **Pin Fall Detection** – Implemented using `OnTriggerEnter` in `FallTrigger.cs`
- **Score Tracking** – Auto-updates score UI
- **Reset Functionality** – Allows replay without restarting Unity

### ✅ **Polish & Visual Enhancements**
- **Imported Custom 3D Models** – Pins, Ball, Arrow from `poly.pizza`
- **Applied Physics Materials** – Optimized ball rolling and pin behavior
- **Enhanced UI & Sound Effects** – Improved player feedback

---

## 📌 Future Improvements
- ✅ **Multiplayer Mode** – Compete against friends!
- ✅ **Leaderboard System** – Track top scores
- ✅ **VR Support** – Immersive bowling experience

---

## 🤝 Contribution Guidelines
1. **Fork the repository**
2. **Create a feature branch** (`git checkout -b feature-name`)
3. **Commit your changes** (`git commit -m "Added new feature"`)
4. **Push to GitHub** (`git push origin feature-name`)
5. **Submit a Pull Request**

---

## 📜 License
This project is **MIT Licensed**. Feel free to use and modify!

---

## 🙌 Credits
- **Developed by:** Your Name
- **Assets from:** `poly.pizza`, `Kenney.nl`, `Quaternius`, and `CC0 Licensed Resources`
