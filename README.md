# Message Decoding Program

This C# program reads an encoded message from a text file, decodes it, and returns the decoded version as a string. The encoding involves associating words with numbers and arranging them in a pyramid-like structure.

## Table of Contents

- [Description](#description)
- [Usage](#usage)
- [File Structure](#file-structure)
- [How It Works](#how-it-works)
- [Dependencies](#dependencies)
- [Contributing](#contributing)
- [License](#license)

## Description

The program takes input from a text file where each line consists of a number and a word. The numbers are arranged in a pyramid-like structure. The program decodes the message by constructing the sequence of words corresponding to the right side of the pyramid.

## Usage

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/your-username/Message-Decoding.git
    ```

2. **Build and Run:**

    Open the project in Visual Studio or your preferred C# development environment. Build and run the program.

3. **Provide Input File:**

    Replace the `messageFile` variable in the `Main` method with the path to your input text file.

4. **View Decoded Message:**

    Run the program, and the decoded message will be printed to the console.

## File Structure

- `Program.cs`: Contains the main C# program.
- `example.txt`: Example input file for testing.

## How It Works

The program reads the input file, extracts numbers and words, and builds a dictionary. It then constructs the decoded message based on the right side of the pyramid, following a specific pattern.

## Dependencies

No external dependencies are required. The program uses standard C# libraries.

## Contributing

If you'd like to contribute to the project, please follow these steps:

1. Fork the repository.
2. Create a new branch.
3. Make your changes.
4. Create a pull request.

## License

This project is not licensed and free for use/replication.
