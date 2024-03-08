/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases
        Console.WriteLine("Test 1");

        var cs = new CustomerService(-1);
        Console.WriteLine(cs);

        // Expected Result:
        if(cs._maxSize < 1)
        {
            Console.WriteLine("An Error occured");
        }
        else 
        {
            Console.WriteLine("Passed\n");
        }

        Console.WriteLine("=================");
        // Should have a maximum size of 10

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        for(int i = 0; i < cs._maxSize+2;i++)
        {
            Console.WriteLine($"Customer {i+1}");
            cs.AddNewCustomer();
            Console.WriteLine(cs._queue[cs._queue.Count-1]);
        }
        if(cs._queue.Count != cs._maxSize)
        {
            Console.WriteLine("Too many customers are in queue.");
        }
        else 
        {
            Console.WriteLine("Passed Test 2\n");
        }
        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 3");
        Console.WriteLine($"Before Service: {cs}");
        for(int i = 0; i < cs._maxSize+1;i++)
        {
            Console.WriteLine($"Customer {i+1}");
            cs.ServeCustomer();
        }
        Console.WriteLine($"After Service: {cs}");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if(_queue.Count == 0){
            Console.WriteLine("No Customers currently left in queue that need service.");
            return;
        }
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}