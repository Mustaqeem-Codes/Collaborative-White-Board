# Installation Guide

## Prerequisites

Before you can run the Collaborative White Board application, ensure you have the following installed:

### Required Software

1. **Operating System**: Windows 10 or Windows 11
2. **Development Environment**: Choose one of the following:
   - **Visual Studio 2022 Community** (Recommended)
     - Download from: https://visualstudio.microsoft.com/vs/community/
     - During installation, select the ".NET desktop development" workload
   - **Visual Studio Code** with C# extension
     - Download VS Code from: https://code.visualstudio.com/
     - Install the C# extension from the marketplace
3. **.NET SDK**: .NET 8.0 SDK or later
   - Download from: https://dotnet.microsoft.com/download

## Installation Steps

### Method 1: Using Visual Studio (Recommended for Beginners)

1. **Download/Clone the Repository**
   ```bash
   git clone https://github.com/Mustaqeem-Codes/Collaborative-White-Board.git
   ```
   Or download as ZIP and extract it.

2. **Open the Solution**
   - Navigate to the project folder
   - Double-click on `CollaborativeWhiteBoard.sln`
   - Visual Studio will open the solution

3. **Restore Dependencies**
   - Visual Studio will automatically restore NuGet packages
   - If not, right-click on the solution in Solution Explorer and select "Restore NuGet Packages"

4. **Build the Project**
   - Press `Ctrl + Shift + B` or go to Build > Build Solution
   - Wait for the build to complete (you should see "Build succeeded" in the output)

5. **Run the Application**
   - Press `F5` or click the green "Start" button
   - The application window should open

### Method 2: Using .NET CLI

1. **Download/Clone the Repository**
   ```bash
   git clone https://github.com/Mustaqeem-Codes/Collaborative-White-Board.git
   cd Collaborative-White-Board
   ```

2. **Restore Dependencies**
   ```bash
   cd CollaborativeWhiteBoard
   dotnet restore
   ```

3. **Build the Project**
   ```bash
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

### Method 3: Using Visual Studio Code

1. **Open the Project**
   - Open VS Code
   - File > Open Folder > Select the CollaborativeWhiteBoard folder

2. **Open Terminal**
   - Terminal > New Terminal (or press `` Ctrl + ` ``)

3. **Restore and Build**
   ```bash
   cd CollaborativeWhiteBoard
   dotnet restore
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

## Troubleshooting

### Common Issues

**Issue: "The target framework 'net8.0-windows' was not found"**
- **Solution**: Install the .NET 8.0 SDK from https://dotnet.microsoft.com/download

**Issue: Build errors related to Windows Forms**
- **Solution**: Ensure you're building on a Windows machine. Windows Forms applications require Windows OS.

**Issue: Application doesn't start**
- **Solution**: Check the build output for errors. Make sure all dependencies are restored correctly.

**Issue: Visual Studio can't find the project**
- **Solution**: Make sure you're opening the `.sln` file, not the `.csproj` file.

## System Requirements

- **OS**: Windows 10 or later
- **Processor**: 1 GHz or faster
- **RAM**: Minimum 2 GB (4 GB recommended)
- **Disk Space**: 500 MB free space
- **Display**: 1024x768 minimum resolution

## Next Steps

After installation, check out the [User Guide](USER_GUIDE.md) to learn how to use all the features of the Collaborative White Board.
