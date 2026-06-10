# Prototype-Pattern

## What is the Prototype Design Pattern?
- Creational Design Pattern
- Creating exact copies of an already existing object
  - Shallow copy
  - Deep copy

## When to use?
- When you want to create exact copies of an object, independant from it's class
- Especially when you want to create a lot of copies

<u>**Copy process without prototype pattern:**</u>
- Create new Object
- Go through all Object fields and set the same values as the object you want to copy
  - => Do the same shit for every single copy you want to create

<u>**Copy process with prototype pattern:**</u>
- Implement prototype Interface, which only contains a clone() function
- Let the classes which objetcs you need to copy implement that interface
- Overwrite the clone() function so it returns a copy of the exact object
  - => Now you only need to call the clone function for every copy you want to create
  - => Copies can still get modified as needed

## Shallow copy vs. Deep copy
- Shallow Copy:
  - Primitive Datatypes will be copied as own value
  - Copy and original share the same references
  - Referencetypes (Objects, Lists etc.) will not be copied, only the references will be adopted . 
    - => If a value in the copy is changed, then it is also changed in the original.
    
  - Main characteristics:
    - Faster than deep copy
    - Needs less storage capacity
    - Shared references

- Deep Copy:
  - Copy is fully independetnt from original
  - For referencetypes new references will be created for the copy

  - Main characteristics:
    - More independency
    - Needs more storage capacity
    - More complex

## Pros / Cons
| Pros | Cons |
|---------------|---------------|
| Clone objects without coupeling to theire classes |  Can be complexe to implement for complexe object structures| 
|No repeated initialization code | Possibly high implementation effort for deep copy |
|Produce complex objects easily | Hidden depencencies |
|Improves performance | | 
|Avoids expensive creation | |

## Structure
![](/img/structure-prototypePattern.png)


## Sources
- https://refactoring.guru/design-patterns/prototype
- https://www.youtube.com/watch?v=hS5C7igeZrk 