# Overview
** Inteface Segmentation ** is one of the SOLID principles in Oject Oriented Programming. We try to split the interface into multiple segments, so that we do not create big intefaces that tries to do everything.  The smaller interfaces are specific about what they do. They serve the particular functionalities given by them. In this way we can prevent classes to  to implement methods that are not relevant to them. We thus promote Single Responsibility principle in SOLID. We can add more flexibility and more loose coupling.

** Benefits **
- We can mix and match interfaces
- Codes are easy to maintain
- increased flexibility
- increased readabiliy
- easier to test

# Design
In this project, there are SmartLight, SimpleLight and Fan. SmartLight has extra functions to change color of light. All these share the ISwitchable interface.

# Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
