# Collaborative White Board

A Windows Forms application built with C# that provides a digital whiteboard for drawing, sketching, and collaborative work.

## Features

- **Drawing Tools**: Free-hand drawing with mouse
- **Color Selection**: Multiple color options (Black, Red, Blue, Green, Yellow)
- **Brush Thickness**: Three thickness options (Thin, Medium, Thick)
- **Save & Load**: Save your drawings as images (PNG, JPEG, BMP) and load them back
- **Clear Board**: Clear the entire canvas with confirmation
- **Responsive UI**: Resizable window that adapts to your screen

## Requirements

- Windows Operating System
- .NET 6.0 SDK or later
- Visual Studio 2019/2022 Community (or any edition) or Visual Studio Code with C# extension

## Getting Started

### Option 1: Using Visual Studio

1. Clone or download this repository
2. Open `CollaborativeWhiteBoard.sln` in Visual Studio
3. Build the solution (Build > Build Solution or press F6)
4. Run the application (Debug > Start Debugging or press F5)

### Option 2: Using .NET CLI

1. Clone or download this repository
2. Open a command prompt or terminal in the project directory
3. Run the following commands:

```bash
cd CollaborativeWhiteBoard
dotnet restore
dotnet build
dotnet run
```

## How to Use

1. **Drawing**: Click and drag on the white canvas to draw
2. **Change Color**: Click any of the color buttons in the Colors section
3. **Change Thickness**: Select Thin, Medium, or Thick from the Thickness section
4. **Save Drawing**: Click "Save Drawing" to save your work as an image file
5. **Load Drawing**: Click "Load Drawing" to open an existing image
6. **Clear Board**: Click "Clear Board" to start fresh (you'll be asked to confirm)

## Project Structure

```
CollaborativeWhiteBoard/
├── CollaborativeWhiteBoard.sln     # Visual Studio solution file
├── CollaborativeWhiteBoard/
│   ├── CollaborativeWhiteBoard.csproj  # Project file
│   ├── Program.cs                      # Application entry point
│   ├── MainForm.cs                     # Main form logic
│   └── MainForm.Designer.cs            # Form designer code
└── README.md                           # This file
```

## Technologies Used

- **Language**: C#
- **Framework**: .NET 6.0
- **UI Framework**: Windows Forms
- **IDE**: Visual Studio Community

## Future Enhancements

Potential features for future versions:
- Network collaboration (multiple users drawing on the same board)
- Shape tools (rectangles, circles, lines)
- Text tool
- Eraser tool
- Undo/Redo functionality
- More color options and color picker
- Background patterns or images
- Export to PDF

## Contributing

Feel free to fork this repository and submit pull requests with improvements or bug fixes.

## License

This project is open source and available for educational purposes.

## Author

Mustaqeem

## Screenshots

(Screenshots will be added after the application is built and running)