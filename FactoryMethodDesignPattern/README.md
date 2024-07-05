<h1>Factory Design Pattern</h1>
<p>In C#, a factory method is a design pattern that provides a way to create objects without specifying the exact class of the object that will be created. 
It involves creating a method that returns instances of a specific type, often based on some parameters or configuration.</p>

<h4>When to Use a Factory Method</h4>
<ul>
  <li>
    <h6>When the exact type of the object isn't known until runtime:</h6> 
    If you need to decide which class to instantiate based on some runtime information, a factory method can handle this decision-making process.
  </li>
  <li>
    <h6>To encapsulate object creation:</h6> 
    If the process of creating an object is complex or involves several steps, a factory method can encapsulate this complexity and provide a simple interface for object creation.
  </li>
  <li>
    <h6>To manage and control object creation: </h6> 
    If you need to control how and when objects are created, such as enforcing singleton patterns or managing resources, a factory method provides a centralized place for these controls
  </li>
  <li>
    <h6>To promote loose coupling: </h6> 
    By relying on interfaces or abstract classes, a factory method allows you to write code that is more flexible and less dependent on specific implementations.
  </li>
</ul>
