# Design Pattern

### Creational patterns

**Creational patterns** patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

- `Factory Method`: provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

  - Complexity: 1
  - Popularity: 3

- `Abstract Factory`: lets you produce families of related objects without specifying their concrete classes.

  - Complexity: 2
  - Popularity: 3

- `Builder`: lets you construct complex objects step by step. The pattern

  - Complexity:
  - Popularity:allows you to produce different types and representations of an object using the same construction code.
  - Complexity: 2
  - Popularity: 3

- `Prototype`: lets you copy existing objects without making your code dependent on their classes.

  - Complexity: 1
  - Popularity: 2

- `Singleton`: lets you ensure that a class has only one instance, while providing a global access point to this instance.

  - Complexity: 1
  - Popularity: 2

### Structural patterns

**Structural patterns** explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.

- `Adapter`: allows objects with incompatible interfaces to collaborate.

  - Complexity: 1
  - Popularity: 3

- `Bridge`: lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

  - Complexity: 3
  - Popularity: 1

- `Composite`: lets you compose objects into tree structures and then work with these structures as if they were individual objects.

  - Complexity: 2
  - Popularity: 2

- `Decorator`: lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

  - Complexity: 2
  - Popularity: 2

- `Facade`: provides a simplified interface to a library, a framework, or any other complex set of classes.

  - Complexity: 1
  - Popularity: 2

- `Flyweight`: lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

  - Complexity: 3
  - Popularity: 1

- `Proxy`: lets you provide a substitute or placeholder for another object.

  - Complexity:
  - Popularity:A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.
  - Complexity: 2
  - Popularity: 1

### Behavioral patterns

**Behavioral patterns** are concerned with algorithms and the assignment of responsibilities between objects

- `Chain of Responsibility`: lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process
  the request or to pass it to the next handler in the chain.

  - Complexity: 2
  - Popularity: 2

- `Command`: turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests
  as a method arguments, delay or queue a request’s execution, and support undoable operations.

  - Complexity: 2
  - Popularity: 3

- `Iterator`: lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

  - Complexity:
  - Popularity:

- `Mediator`: lets you reduce chaotic dependencies between objects. The
  pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

  - Complexity: 2
  - Popularity: 2

- `Mememto`: lets you save and restore the previous state of an object without revealing the details of its implementation.

  - Complexity: 3
  - Popularity: 1

- `Observer`: lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

  - Complexity: 1
  - Popularity: 2

- `State`: lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

  - Complexity: 1
  - Popularity: 2

- `Strategy`: lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

  - Complexity: 1
  - Popularity: 3

- `Template Method`: defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.

  - Complexity: 1
  - Popularity: 2

- `Visitor`: lets you separate algorithms from the objects on which they operate.

  - Complexity: 3
  - Popularity: 1
