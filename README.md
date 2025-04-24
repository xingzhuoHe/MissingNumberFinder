# Missing Number Finder

This is a simple console application written in C# to find the missing number in a sequence of numbers. The application reads a list of numbers from the console, calculates the missing number, and displays the result.

## Project Structure

- **IMissingNumberFinder**: Interface for finding the missing number.
- **IConsoleIO**: Interface for input and output operations.
- **MissingNumberFinder**: Implementation of the missing number finder.
- **ConsoleIO**: Implementation of for input and output operations.
- **MissingNumberApplication**: Main application class that orchestrates the process.
- **Program**: Entry point of the application.

## How to Run

1. **Clone the repository**:
   ```bash
   git clone <repository-url>
   ```

2. **Navigate to the project directory**:
   ```bash
   cd MissNumberFinder
   ```

3. **Build the project**:
   Use your preferred C# build tool, for example:
   ```bash
   dotnet build
   ```

4. **Run the application**:
   ```bash
   dotnet run
   ```

5. **Input the numbers**:
   When prompted, enter a list of numbers in the format `[9, 6, 4, 2, 3, 5, 7, 0, 1]`.

## Example

```
Please enter the number list (format like: [9, 6, 4, 2, 3, 5, 7, 0, 1]):
[9, 6, 4, 2, 3, 5, 7, 0, 1]
The missing number is: 8
```