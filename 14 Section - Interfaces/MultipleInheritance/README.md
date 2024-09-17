# Multiple Inheritance

    - Example of a multiple Inheritance;

<p align="center">
  <img src="./screenshots/example1.png" width="350" title="Console">
</p>

### Multiple inheritance and the diamond problem

##### Diamond problem

    - Multiple inheritance can generate the diamond problem: an ambiguity caused by the existence of the same method in more than one superclass;
    - Multiple inheritance is not allowed in most languages;

<p align="center">
  <img src="./screenshots/diamondproblem.png" width="350" title="Console">
</p>

#### However, a class (or struct) can implement more than one interface

    - ATTENTION:
      This is NOT multiple inheritance, as there is NO REUSE in the relationship between ComboDevice and the Scanner and Printer interfaces;
      ComboDevide does not inherit, but implements the interfaces (fulfills the contract);

<p align="center">
  <img src="./screenshots/interfaces.png" width="350" title="Console">
</p>
