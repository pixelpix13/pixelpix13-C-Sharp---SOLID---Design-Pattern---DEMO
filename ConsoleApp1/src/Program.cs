using ConsoleApp1.Coupling;
using ConsoleApp1.SOLID.D.BetterExample;
using ConsoleApp1.SOLID.S.BetterExample;
using ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample;
using ConsoleApp1.src.DesignPatterns.Creational.Singleton.GoodExample;
using ConsoleApp1.src.OopPrinciples.Coupling;
using ConsoleApp1.src.SOLID.D.BetterExample;
using System;

//BadBankAccount badBankAccount = new BadBankAccount();
//badBankAccount.balance = -100;
//Console.WriteLine(badBankAccount.balance); // -100

/* ENCAPSULATION */
//BankAccount bankAccount = new BankAccount(100);
// BankAccount bankAccount = new BankAccount(-100); // throws exception
//bankAccount.Withdraw(150);// throws exception
//bankAccount.Withdraw(-50); // throws exception
// bankAccount.Deposit(-50); // throws exception
//Console.WriteLine(bankAccount.GetBalance());
// here we are using encapsulation to hide the implementation details of the BankAccount class.

/* ABSTRACTION */
//EmailService emailService = new EmailService();
//emailService.sendEmail();
//emailService.connect(); // ERROR: connect() is private
//emailService.authenticate(); // ERROR: authenticate() is private
//emailService.disconnect(); // ERROR: disconnect() is private
// here we are using abstraction to hide the implementation details of the EmailService class.


/* INHERITANCE */
//Car car = new Car();
//car.Brand = "Toyota";
//car.Model = "Corolla";
//car.Year = 2020;
//car.NumberOfDoors = 4;
//car.Start(); //written in the Vehicle class
//car.Stop(); //writen in Vehicle class

//Bike bike = new Bike();
//bike.Brand = "Yamaha";
//bike.Model = "YZF-R3";
//bike.Year = 2021;
//bike.Start(); //written in the Vehicle class
//bike.Stop(); //written in the Vehicle class


/* POLYMORPHISM */
//Car car = new Car();

//List<Vehicle> vehicles = new List<Vehicle>();

//vehicles.Add(new Car
//{
//    Brand = "Toyota",
//    Model = "Corolla",
//    Year = 2020,
//    NumberOfDoors = 4
//});
//vehicles.Add(new Motorcycle
//{
//    Brand = "Harley Davidson",
//    Model = "Street 750",
//    Year = 2019,
//});
//vehicles.Add(new Vehicle
//{
//    Brand = "Generic",
//    Model = "Generic",
//    Year = 2000,
//});

//foreach (var vehicle in vehicles)
//{
//    vehicle.Start();
//    vehicle.Stop();
//}
//here we are using the same method name (Start and Stop) but the implementation is different for each class. This is polymorphism.


/* Coupling */
//var email = new EmailSender();
//var order = new Order(email);
//var sms = new SmsSender();
//var order2 = new Order(sms);

//order.PlaceOrder();
//order2.PlaceOrder();
//here we were able to use the same Order class without changing the implementation of the class.
//here we are calling the SendNotification method from the EmailSender class using the Order class.
//This is an example of coupling. The Order class is dependent on the EmailSender class to send notifications.
//This is a good example of coupling because we are using interfaces to decouple the classes.
//We can easily change the implementation of the INotificationService interface without changing the Order class.
//This is a good practice in software development.


/* Composition */
//this means that we are using objects to create new instances of the the classes we want to use rather than inheriting them.
//look in the car class for the implementation of the composition.

/* Single Responsibility Principle */
//UserService userService = new UserService();
//User user = new User();
//user.Username = "John Doe";
//user.Email = "john@gmail.com";
//userService.RegisterUser(user);
//here we are using the single responsibility principle to separate the user registration logic from the user class by creating the UserService class.

/* Open/Closed Principle */
//Shape shape = new Circle { Radius = 5};
//Shape shape1 = new Rectangle { Length = 4, Width = 6 };
//Console.WriteLine(shape.CalculateArea()); // Calls Circle's CalculateArea method
//Console.WriteLine(shape1.CalculateArea()); // Calls Rectangle's CalculateArea method
//here we are using the open/closed principle to allow the Shape class to be open for extension but closed for modification.

/*Liskov Substitution Principle */
//Shape shape = new Rectangle { Height = 4, Width = 6 };
//Shape shape1 = new Square { SideLength = 5 };

//Console.WriteLine(shape.Area); // Calls Rectangle's CalculateArea method
//Console.WriteLine(shape1.Area); // Calls Square's CalculateArea method
//here we are using the liskov substitution principle to allow the Shape class to be substituted with any of its subclasses without changing the behavior of the program.
//for example, we can use the Rectangle class or the Square class in place of the Shape class without changing the behavior of the program.

/* Interface Segregation Principle */
//Sphere sphere = new Sphere { Radius = 5 };
//Circle circle = new Circle { Radius = 5 };
//Console.WriteLine(sphere.Area());
//Console.WriteLine(sphere.Volume());
//Console.WriteLine(circle.Area());
//here we used two different interfaces to impletement the same functionality becasue sphere is a 3D shape and circle is a 2D shape.
//thus if we were to create a class that implements the IShape interface, we would have to implement the Volume method which is not applicable for 2D shapes.
//this is an example of the interface segregation principle. We are using two different interfaces to implement the same functionality.


/* Dependency Inversion Principle */
//Engine carEngine = new Engine();
//var car = new Car(carEngine);
//car.StartCar();
//ElectricEngine electricCarEngine = new ElectricEngine();
//var electricCar = new Car(electricCarEngine);
//electricCar.StartCar();
//here we are using the dependency inversion principle to allow the Car class to depend on abstractions (the IEngine interface) rather than concrete implementations (the Engine class).
//this allows us to easily change the implementation of the IEngine interface without changing the Car class.
//also we can easily add new implementations of the IEngine interface without changing the Car class.
//moreover, we can use the ElectricEngine class in place of the Engine class without changing the behavior of the program.


/* Stragegy Pattern */
//var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
//videoStorage.Store("video.mov - overlay black and white");
//videoStorage.SetCompressor(new CompressorMP4());
//videoStorage.SetOverlay(new OverlayBlur()); 
//videoStorage.Store("video.mp4 - overlay blur");
//here we adhere to SOLID principles and used Stragery patter to implement the video storage functionality.
//what we did here is that we created a class that implements the ICompressor interface and another class that implements the IOverlay interface.
//then we used these classes to create a new instance of the VideoStorage class.
//we break the functionality into smaller classes.
//e.g. we created a separate classes for each type of compressor since they might contain different algorithms.
//we then also did the same thing with the overlay classes.
//all the overlay and compressor classes implement the ICompressor and IOverlay interfaces respectively.
//thus this code adheres to the Single Responsibility Principle because each class has a single responsibility like compressing and applying overlays and storing all of these is a part of video storage process.
//moreover, this also follows the Open/Closed Principle because we can easily add new implementations of the ICompressor and IOverlay interfaces without changing the VideoStorage class.
//additionaly, this also follows the Liskov Substitution Principle because we can easily substitute the ICompressor and IOverlay interfaces with any of their subclasses without changing the behavior of the program.
//this also follows the Interface Segregation Principle because Icompress only has compress and IOverlay only has apply methods.
//no additonal methods are added to the interfaces. No class is forced to implement methods that it does not use.
//thus Strategy Pattern lets you define a family of interchangeable algorithms (strategies) and allows the client to choose one at runtime, without modifying the core logic.

/* Singleton Pattern */
//var settings = AppSetting.GetInstance();
//settings.Set("app_name", "DemoSingleTon");
//settings.Set("app_version", "1.0.0");
//settings.Set("app_author", "Purav");
//Console.WriteLine(settings.Get("app_name"));

//Test.Run();
//what we did here is that we created a singleton class that can only be instantiated once i.e. we call the getinsatance method to get the instance of the class.
//we kept the AppSetting class private so that it cannot be instantiated from outside the class and thus cannot creaate multiple instances of the class.
//this is an example of the singleton pattern.

