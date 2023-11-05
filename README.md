# GeoJest - A Robust Geometry Library

GeoJest is a .NET geometry library designed to handle geometric shapes and provide essential geometric operations. It adheres to modern .NET coding standards and best practices, ensuring a smooth integration into your projects.

## Features

- Calculate the area of a circle given its radius.
- Calculate the area of a triangle given the lengths of its sides.
- Determine if a triangle is right-angled based on the lengths of its sides.
- Extensible design allowing for the easy addition of more geometric shapes in the future.
- Well-documented code following standard C# XML documentation conventions.
- Comprehensive suite of unit tests ensuring accuracy and performance.
- Packaged as a Nuget package for easy distribution and usage.

## Setup

### Building from Source

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio or any .NET-supporting IDE.
3. Build the solution to get the `GeoJest.dll` library file.

### Creating a NuGet Package

1. Ensure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.
2. Navigate to the project directory in your terminal.
3. Run the following command to create a NuGet package:

```bash
dotnet pack --configuration Release
```

## Usage

Here's how you can use GeoJest in your C# project:

```csharp
using GeoJest.Factories;
using GeoJest.Models;

// Create a Circle
var circleFactory = new CircleFactory();
var circle = circleFactory.Create(10);  // radius = 10
var circleArea = circle.GetArea();

// Create a Triangle
var triangleFactory = new TriangleFactory();
var triangle = triangleFactory.Create(3, 4, 5);  // sides = 3, 4, 5
var triangleArea = triangle.GetArea();

// Check if the triangle is right-angled
var isRightAngled = ((IRightAngleCheckable)triangle).HasRightAngle();
