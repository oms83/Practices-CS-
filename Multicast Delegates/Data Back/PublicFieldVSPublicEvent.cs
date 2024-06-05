using System;


namespace Multicast_Delegates.Data_Back
{
    /*
     * Public Field:
     * Defining the Public Field:
     * using System;
    */

    public class publicFieldDelegate
    {
        public delegate void DataBackEventHandler(int number);

        public class ExampleWithField
        {
            public DataBackEventHandler DataBack;
        }

        class Program
        {
            static void Mainn()
            {
                ExampleWithField example = new ExampleWithField();

                // Subscribe to the field
                example.DataBack += HandlerMethod;

                // Invoke the handler
                example.DataBack?.Invoke(42);

                // Assign the field to null (direct manipulation possible)
                example.DataBack = null;

                // The handler will not be invoked because the field was set to null
                example.DataBack?.Invoke(84);
            }

            static void HandlerMethod(int number)
            {
                Console.WriteLine($"Number: {number}");
            }
        }

    }
    /*
     * 
     * Direct Access: We can set the DataBack field to null or any other value.
     * Lack of Protection: The field value can be completely replaced, which may result in losing all subscribed handlers.
     * 
     **/


    /*
     * 
     * Public Event:
     * Defining the Public Event:
     *
     */

    public class evetDelegate
    {
        public delegate void DataBackEventHandler(int number);

        public class ExampleWithEvent
        {
            public event DataBackEventHandler DataBack;
        }

        class Program
        {
            static void Mainn()
            {
                ExampleWithEvent example = new ExampleWithEvent();

                // Subscribe to the event
                example.DataBack += HandlerMethod;

                // Invoke the handler
                //example.DataBack?.Invoke(42);

                // Attempt to set the event to null (not allowed)
                // example.DataBack = null; // This line will cause a compilation error

                // Unsubscribe from the event
                example.DataBack -= HandlerMethod;

                // The handler will not be invoked because the subscription was removed
                //example.DataBack?.Invoke(84);
            }

            static void HandlerMethod(int number)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
    /*
     * 
     * Notes:
     * Subscribe and Unsubscribe Only: External objects can only subscribe or unsubscribe using += and -=.
     * Higher Protection: The event cannot be set to null or replaced with a new value, preventing unintended manipulation.
     *
     */

    /*
     * 
     * Difference in Manipulation:
     * Manipulation of the Public Field:
     * In the case of a public field, external objects can set the field to null, 
     * leading to the loss of all associated handlers:
     *
     *		example.DataBack = null; // Allowed
     *		
     *		
     * Manipulation of the Public Event: 
     * In the case of a public event, the event cannot be set to null, and subscriptions are 
     * controlled only via += and -=:
     *		
     *		example.DataBack += HandlerMethod; // Allowed
     *		example.DataBack -= HandlerMethod; // Allowed
     *		
     *	Summary:
     *	Public Field: Can be directly manipulated, which might cause issues if set to null or replaced.
     *	Public Event: Provides higher protection and restricts direct access, preventing unintended manipulation 
     *	and maintaining application stability.
     */


}
