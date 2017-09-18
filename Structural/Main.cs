using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Structural
{
    /*
    Attach additional responsibilities to an object dynamically. Decorators 
    provide a flexible alternative to subclassing for extending functionality.
        
    This structural code demonstrates the Decorator pattern which dynamically 
    adds extra functionality to an existing object.

    OUTPUT:
    ConcreteComponent.Operation()
    ConcreteDecoratorA.Operation()
    ConcreteDecoratorB.Operation()
    */

    /// <summary>
    /// Main startup class for Structural 
    /// Decorator Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainStructural()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
