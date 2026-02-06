# Collaborative Whiteboard

![Status](https://img.shields.io/badge/status-Active-success.svg)
![License](https://img.shields.io/badge/license-MIT-blue.svg)

A real-time collaborative whiteboard application. This project allows multiple users to connect to a shared session and draw on a canvas simultaneously, demonstrating core concepts of computer networks and socket programming.

## 📝 Table of Contents

- [About](#about)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## 🧐 About

The Collaborative Whiteboard is designed to facilitate remote brainstorming and visual communication. By leveraging web sockets (or similar network protocols), the application ensures that strokes made by one user are instantly broadcast to all other connected users, maintaining a synchronized state across all clients.

## ✨ Features

- **Real-time Synchronization:** Low-latency updates across all connected clients.
- **Multi-User Support:** Handles multiple connections simultaneously.
- **Drawing Tools:** Basic pen tool with adjustable colors and sizes.
- **Clean Interface:** Minimalist design focused on the drawing area.

## 🚀 Technologies Used

*Note: This project is built for a Computer Networks Lab.*

- **Frontend:** HTML5 Canvas, CSS3, JavaScript
- **Backend:** Node.js / Python / Java (Check source code for specifics)
- **Networking:** WebSockets / Socket.io

## 🏁 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

Ensure you have the following installed:

- [Git](https://git-scm.com/)
- The runtime environment matching the backend (e.g., [Node.js](https://nodejs.org/) or Python).

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/Collaborative-White-Board.git
   ```

2. **Navigate to the project directory**

   ```bash
   cd Collaborative-White-Board
   ```

3. **Install Dependencies**

   *If using Node.js:*
   ```bash
   npm install
   ```
   *If using Python:*
   ```bash
   pip install -r requirements.txt
   ```

4. **Run the Application**

   *If using Node.js:*
   ```bash
   npm start
   ```
   *If using Python:*
   ```bash
   python server.py
   ```

## 🎈 Usage

1. Start the server using the commands above.
2. Open your web browser and navigate to `http://localhost:3000` (or the port specified in the console).
3. Open the same URL in a second tab or a different device on the same network.
4. Draw on one canvas and watch it appear on the other instantly.

## 🤝 Contributing

Contributions are welcome! Please fork the repository and create a pull request for any feature additions or bug fixes.

## 📜 License

This project is open-source and available under the MIT License.