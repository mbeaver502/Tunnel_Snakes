# Brief Overview

This is the CS 455: Software Engineering term project completed at the University of North Alabama in Spring 2014. The team consisted of [Michael Beaver](https://www.github.com/mbeaver502), [Travis Hunt](https://www.github.com/thunt1), [Andrew Hamilton](https://github.com/aahamilt), Andrew "Drew" Aaron, Chad Farley, and [Clay Boren](https://github.com/clayboren). This software implements a Windows GUI IDE and (partial) emulator of the ASSIST/I assembly language for the IBM/360. More information can be found in the [Documents](https://github.com/mbeaver502/Tunnel_Snakes/tree/master/Documents/) folder and specifically in the [project descriptions](https://github.com/mbeaver502/Tunnel_Snakes/tree/master/Documents/Project%20Description). The project was completed in C# using Microsoft Visual Studio 2010/2012.

NB: This is a fork of the [original master](https://github.com/thunt1/Tunnel_Snakes).

# My Primary Contributions

If you're interested, I contributed primarily to the following files. Most of my work consisted of implementing the memory representation, the machine simulation/emulation, and the actual operations processing. As this project is now well over two years old, I cannot remember exact details or rationale for decisions, unless otherwise noted within comments. This is by no means an exhaustive list:

1. [Library.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Library.cs)
  This class represents all available instructions available to the ASSIST/UNA assembly language. Interaction with this class should be done through the public method SimulateInstruction, which will then call the necessary methods to perform the intended operations as specified in the object code.
2. [Processing.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Processing.cs)
  This is a static class to take care of managing the backend processing. This includes Assembling and Simulating the source code.
3. [Simulator.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Simulator.cs)
  This class emulates the IBM/360 that the ASSIST/I language was used upon. This class contains the methods to initialize the memory and the registers with their starting contents and also contains the driver that calls the library class to process the next instruction contained in the object code.
4. [AssistByte.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/MemoryClasses/AssistByte.cs)
  This class represents the a byte that can be "locked" (i.e., declared constant).
5. [Memory.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/MemoryClasses/Memory.cs)
  This class represents the ASSIST/UNA's simulator's memory. The memory contents are represented as an array of byte objects.
6. [PSW.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/MemoryClasses/PSW.cs)
  This class represents a portion of the ASSIST/UNA's simulator's Program Status Word (PSW). This class represents the location counter (instruction address) as an array of LOC_SIZE bytes and the condition code as COND_CODE_SIZE integers (0 or 1).
7. [Register.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/MemoryClasses/Register.cs)
  This class represents one of the ASSIST/UNA's simulator's registers. The register contents are represented as an array of byte objects.
8. [ExceptionCodes.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Exceptions/ExceptionCodes.cs)
  This class contains all the ASSIST/I codes for runtime exceptions.
9. [ErrorDetection.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Exceptions/ErrorDetection.cs)
  This class contains all the exceptions that can be thrown while performing the instructions contained in Library.
10. [EndProcessingException.cs](../master/Assist-UNA/04282014-Code/Assist-UNA/Processing/Exceptions/EndProcessingException.cs)
  This class contains an empty basic exception throw to trigger shutdown upon a fatal exception within the Simulator. This class should be used via the ErrorDetection class.




