using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using Autofac;
using Autofac.Features.Metadata;
using DesignPatters.Filters;
using DesignPatters.Models;
using DesignPatters.Models.Animals;
using DesignPatters.Models.Cars;
using DesignPatters.Models.Commands;
using DesignPatters.Models.Composite;
using DesignPatters.Models.Drinks;
using DesignPatters.Models.Facade;
using DesignPatters.Models.Flyweight;
using DesignPatters.Models.Html;
using DesignPatters.Models.Interpreter;
using DesignPatters.Models.Iterator;
using DesignPatters.Models.Journals;
using DesignPatters.Models.Mediator;
using DesignPatters.Models.Mediator.Chat;
using DesignPatters.Models.Mediator.MediatR;
using DesignPatters.Models.Memento;
using DesignPatters.Models.MethodChain;
using DesignPatters.Models.NeuralNetworks;
using DesignPatters.Models.NullObjectPattern;
using DesignPatters.Models.ObserverPattern;
using DesignPatters.Models.ObserverPattern.Declarative;
using DesignPatters.Models.Persons;
using DesignPatters.Models.Persons.Employees;
using DesignPatters.Models.Persons.Relations;
using DesignPatters.Models.Points;
using DesignPatters.Models.Printers;
using DesignPatters.Models.Products;
using DesignPatters.Models.Proxy;
using DesignPatters.Models.Reporting;
using DesignPatters.Models.Shapes;
using DesignPatters.Models.Singleton;
using DesignPatters.Models.StatePattern;
using DesignPatters.Models.Strategy;
using DesignPatters.Models.Themes;
using DesignPatters.Models.Vectors;
using DesignPatters.Specifications;
using DesignPatters.Specifications.ProductSpecifications;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoreLinq;
using Stateless;
using Action = DesignPatters.Models.StatePattern.Action;

namespace DesignPatters;

class Program
{
    public static void Main(string[] args)
    {
        // Single Responsibility Principle
        // CreateAndOpenJournalFile();

        // Open Closed Principle
        // CreateAndFilterProducts();
        
        // Liskov Substitution Principle
        // ShapesAreaCalculation();
        
        // Interface Segregation Principle
        // OldFashionedPrinter();
        
        // Dependency Inversion Principle
        // CreateRelationshipsForResearch();

        // Builder Pattern
        // GenerateHtmlOutput();
        // var personJobBuilder = new EmployeeBuilder();
        // personJobBuilder.SetFirstName("Juan Miguel");
        // CreateAndDisplayPersonAndEmployee();

        // Stepwise Builder
        // StepwiseBuilder();

        // Functional Builder
        // FunctionalBuilder();
        
        // Faceted Builder
        // CreatePersonWithFacetedBuilder();

        // Builder Pattern Exercise
        // BuilderPatternExercise();

        // Factory Pattern
        // FactoryPattern();
        
        // Asynchronous Factory Method
        // var foo = await Foo.CreateAsync();

        // Class Factory Pattern
        // ClassFactoryPattern();
        
        // Object tracking with Factory Method
        // GenerateThemesWithFactory();

        // Bulk Replacement with Factory Class
        // BulkReplacementWithFactoryClass();

        // Abstract Factory Pattern
        // AbstractFactoryPattern();

        // Prototype Pattern - The problem
        // PrototypePatternTheProblem();
        
        // Prototype Pattern - Copy constructor
        // CopyConstructor();
        
        // Prototype Pattern - Clone method
        // DeepCopyMethod();
        
        // Prototype Pattern - Inheritance - Copy constructor
        // DeepCopyAndInheritanceWithCopyConstructor();

        // Prototype Pattern - Inheritance - Clone method
        // DeepCopyWithInterface();
        
        // Prototype Pattern - Serialization
        // DeepCopyWithJsonSerialization();
        // DeepCopyWithXmlSerialization();
        
        // Prototype Pattern - Exercise
        // CreateAndDisplayLines();

        // Singleton Pattern
        // SingletonPattern();

        // Singleton Pattern - Mono state
        // SingletonMonoState();
        
        // Singleton per Thread
        // ExecutePerThreadSingletonTasks();
        
        // Ambient Context
        // BuildWallsWithContexts();
        
        // Singleton tester - Exercise
        // SingletonTester();

        // Adapter Pattern
        // AdapterCaching();

        // Generic Value Adapter
        // GenericValueAdapter();

        // Adapter In Dependency Injection
        // await AdapterInDependencyInjection();

        // Adapter Exercise
        // CreateSquareAdapter();

        // Bridge Pattern
        // BridgePattern();

        // Composite Pattern
        // CompositePattern();
        // RenderCircleGroup();

        // Composite Pattern - Neural Networks
        // EstablishNeuronConnections();

        // Composite Pattern - Exercise
        // CompositePatternExercise();

        // Decorator Pattern
        // DecoratorPattern();
        // AdapterAndDecoratorPattern();
        // DecoratorWithMultipleInheritance();
        // HandleMultipleInheritance();
        // DynamicDecoratorComposition();
        // StaticDecoratorComposition();

        // Decorator In Dependency Injection
        // DecoratorInDependencyInjection();
        
        // Facade Exercise
        // FacadeExercise();

        // Flyweight Pattern
        // FlyweightPattern();
        
        // Flyweight Pattern - Exercise
        // FlyweightPatternExercise();
        
        // Flyweight Pattern - Factory
        // FlyweightWithFactory();

        // Proxy Pattern - Protection
        // ProtectionProxy();
        // PropertyProxy();

        // Value Proxy
        // ValueProxy();
        // CompositeProxy();

        // Composite Proxy - Array backed properties
        // CompositeProxyWithArrayBackedProperties();
        // DynamicProxyForLogging();
        // ProxyViewModel();
        
        // Protection Proxy Pattern - Exercise
        // ProtectionProxyExercise();
        // BitFragging();
        
        // Chain of Responsibility - Method Chain
        // ChainOfResponsibility();
        // BrokerChain();

        // Chain of Responsibility - Exercise
        // ChainOfResponsibilityExercise();

        // Command Pattern
        // CommandPattern();
        // CompositeBankAccountCommands();
        // ExecuteMoneyTransfer();
        
        // Command Pattern - Exercise
        // CommandPatterExercise();

        // Interpreter Pattern
        // InterpreterPattern();
        
        // Interpreter Pattern - Exercise
        // InterpreterPatternExercise();
        // InterpreterPatternExerciseV2();

        
        // Iterator Pattern
        // IteratorObjectBinaryTree();
        // IteratorMethod();
        // IteratorAndGetEnumerator();
        
        // Array backed-properties
        // ArrayBackedProperties();
        
        // Iterator Pattern - Exercise
        // BuildAndDisplayBinaryTreePreOrder();
        // IteratorExercise();

        // Mediator Pattern
        // MediatorPattern();
        // MediatorEventBroker();
        // MediatR
        // await MediatRSample(args);
        // await MediatRSampleAutoFac();
        // MediatorExercise();
        
        // Memento Pattern
        // MementoPatterPart1();
        // MementoImproved();
        // Memento Pattern - Exercise
        // MementoExercise();

        // Null Object Pattern
        // NullObjectPattern();
        // DynamicNullObjectPattern();
        // DynamicNullObjectPatternWithProxy();
        
        // Null Object Pattern - Exercise
        // NullObjectPatternExercise();
        
        // Observer Pattern
        // ObserverPatternEvents();

        // WeakEventPattern();
        // FireGC();

        // IObserver / IObservable Pattern
        // ObserverPattern();

        // NotifyPropertyChanged Pattern
        // NotifyPropertyChanged();

        // bidirectional binding
        // BidirectionalBinding();
        // PropertyDependencies();
        
        // Declarative Event Subscriptions with interfaces
        // DeclarativeEventSubscription();

        // Observer Pattern - Exercise
        // ObserverPatternExercise();
        
        // State Pattern
        // StatePatternClasicImpl();
        // HandMadeStateMachine();

        // Switch-Based state Machine
        // SwitchBasedStateMachine();
        
        // Switch Expression
        // SwitchExpressionForStateMachine();

        // Stateless machine
        // ConfigureHealthStateMachine();
        
        // State Pattern - Exercise
        // StatePatternExercise();

        // Strategy Pattern
        // DynamicStrategyPattern();
        StaticStrategyPattern();

        Console.WriteLine("End");
        // Console.ReadLine();
    }

    private static void StaticStrategyPattern()
    {
        var tp1 = new TextProcessor<MarkdownListStrategy>();
        tp1.AppendList(["foo", "bar", "baz"]);
        Console.WriteLine(tp1);
        
        var tp2 = new TextProcessor<HtmlListStrategy>();
        tp2.AppendList(["foo", "bar", "baz"]);
        Console.WriteLine(tp2);
    }

    private static void DynamicStrategyPattern()
    {
        var tp = new TextProcessor();
        tp.SetOutputFormat(OutputFormat.Markdown);
        tp.AppendList(["foo", "bar", "baz"]);
        Console.WriteLine(tp);

        tp.Clear();
        
        tp.SetOutputFormat(OutputFormat.Html);
        tp.AppendList(["foo", "bar", "baz"]);
        Console.WriteLine(tp);
    }

    private static void StatePatternExercise()
    {
        var cl = new CombinationLock([1, 2, 3, 4, 5]);
        cl.EnterDigit(1);
        cl.EnterDigit(2);
        cl.EnterDigit(3);
        cl.EnterDigit(4);
        cl.EnterDigit(6);
        
    }

    private static void ConfigureHealthStateMachine()
    {
        var stateMachine = new StateMachine<Health, HealthActivity>(Health.NonReproductive);

        stateMachine.Configure(Health.NonReproductive)
            .Permit(HealthActivity.ReachPuberty, Health.Reproductive);

        stateMachine.Configure(Health.Reproductive)
            .Permit(HealthActivity.Hysterectomy, Health.NonReproductive)
            .PermitIf(HealthActivity.HaveUnprotectedSex, Health.Pregnant,
                () => HealthDemo.ParentsNotWatching());

        stateMachine.Configure(Health.Pregnant)
            .Permit(HealthActivity.GiveBirth, Health.Reproductive)
            .Permit(HealthActivity.HaveAbortion, Health.Reproductive);
    }

    private static void SwitchExpressionForStateMachine()
    {
        var chest = Chest.Locked;
        Console.WriteLine($"The chest is {chest}");
        Console.WriteLine();

        chest = ChestDemo.Manipulate(chest, Action.Open, true);
        Console.WriteLine($"The chest is {chest}");
        
        chest = ChestDemo.Manipulate(chest, Action.Close, false);
        Console.WriteLine($"The chest is {chest}");
        
        chest = ChestDemo.Manipulate2(chest, Action.Close, false);
        Console.WriteLine($"The chest is {chest}");
    }

    private static void SwitchBasedStateMachine()
    {
        var code = "1234";
        var state = LockState.Locked;
        var entry = new StringBuilder();

        while (true)
        {
            switch (state)
            {
                case LockState.Locked:
                    entry.Append(Console.ReadKey().KeyChar);

                    if (entry.ToString() == code)
                    {
                        state = LockState.Unlocked;
                        break;
                    }

                    if (!code.StartsWith(entry.ToString()))
                    {
                        state = LockState.Failed;
                    }
                    
                    break;
                case LockState.Failed:
                    Console.CursorLeft = 0;
                    Console.WriteLine("FAILED");
                    entry.Clear();
                    state = LockState.Locked;
                    break;
                case LockState.Unlocked:
                    Console.CursorLeft = 0;
                    Console.WriteLine("UNLOCKED");
                    return;
            }
        }
    }

    private static void HandMadeStateMachine()
    {
        PhoneStateMachine.Run();
    }

    private static void StatePatternClasicImpl()
    {
        var ls = new DSwitch();
        ls.On();
        ls.Off();
        ls.Off();
    }

    private static void ObserverPatternExercise()
    {
        var game = new RatGame();
        var rat1 = new Rat(game);
        var rat2 = new Rat(game);
        
        rat2.Dispose();
    }

    private static void DeclarativeEventSubscription()
    {
        var cb = new ContainerBuilder();
        var assembly = Assembly.GetExecutingAssembly();

        cb.RegisterAssemblyTypes(assembly)
            .AsClosedTypesOf(typeof(ISend<>))
            .SingleInstance();

        cb.RegisterAssemblyTypes(assembly)
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IHandle<>)
            )).OnActivated(act =>
            {
                // IHandle<Foo>
                // ISend<Foo>.Sender += act.Instance.Handle;

                var instanceType = act.Instance.GetType();
                var interfaces = instanceType.GetInterfaces();

                foreach (var i in interfaces)
                {
                    if (i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IHandle<>))
                    {
                        // IHandle<Foo>
                        var genericType = i.GetGenericArguments()[0];
                        
                        // ISend<Foo> construct;
                        var senderType = typeof(ISend<>).MakeGenericType(genericType);
                        
                        // every single ISend<Foo> in container
                        // IEnumerable<IFoo> -> every instance of IFoo
                        var allSenderTypes = typeof(IEnumerable<>).MakeGenericType(senderType);
                        
                        // IEnumerable<ISend<Foo>>
                        var allServices = act.Context.Resolve(allSenderTypes);
                        foreach (var service in (IEnumerable) allServices)
                        {
                            var eventInfo = service.GetType().GetEvent("Sender");
                            var handleMethod = instanceType.GetMethod("Handle");
                            var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, null, handleMethod);
                            eventInfo.AddEventHandler(service, handler);
                        }
                    }
                }
            })
            .SingleInstance()
            .AsSelf();
        
        using var container = cb.Build();

        var button = container.Resolve<DButton>();
        var logging = container.Resolve<Logging>();

        button.Fire(1);
        button.Fire(2);
    }

    private static void PropertyDependencies()
    {
        var person = new Developer();
        person.PropertyChanged += (sender, args) =>
        {
            Console.WriteLine($"{args.PropertyName} changed.");
        };
        
        person.Age = 16;
        person.Citizen = true;
    }

    private static void BidirectionalBinding()
    {
        var product = new OProduct("Book");
        var window = new OWindow("Book");
        
        // product.PropertyChanged += (sender, args) =>
        // {
        //     if (args.PropertyName == nameof(product.Name))
        //     {
        //         window.ProductName = product.Name;
        //     }
        // };
        //
        // window.PropertyChanged += (sender, eventArgs) =>
        // {
        //     if (eventArgs.PropertyName == nameof(window.ProductName))
        //     {
        //         product.Name = window.ProductName;
        //     }
        // };
        
        using var binding = new BidirectionalBinding(product, window, () => product.Name, () => window.ProductName);
        
        product.Name = "Smart Book";
        window.ProductName = "Really Smart Book";

        Console.WriteLine(product);
        Console.WriteLine(window);
    }

    private static void NotifyPropertyChanged()
    {
        var market = new Market();
        
        market.PropertyChanged += (sender, args) =>
        {
            Console.WriteLine($"Market property changed: {args.PropertyName}");

            if (args.PropertyName == nameof(market.Volatility))
            {
                Console.WriteLine("Volatility changed, updating prices");
            }
        };
        
        market.Volatility = 100;
        
        // Binding List
        market.Prices.ListChanged += (sender, args) =>
        {
            if (args.ListChangedType == ListChangedType.ItemAdded)
            {
                var list = (BindingList<float>) sender!;
                var price = list[args.NewIndex];
                Console.WriteLine($"Binding List got a price of: {price}");
            }
        };
        
        market.AddPrice(50);
    }

    private static void ObserverPattern()
    {
        var personObserver = new PersonObserver();
        var person = new EPerson();
        var subscription = person.Subscribe(personObserver);

        person.OfType<FallsIllEvent>().Subscribe(observer =>
        {
            Console.WriteLine($"This person has fallen ill: {observer.Address}");
        });
        
        person.FallIll();
    }

    private static void WeakEventPattern()
    {
        WeakReference windowRef;
        {
            var button = new OButton();
            var window = new Window(button);

            windowRef = new WeakReference(window);

            button.Fire();

            Console.WriteLine("Setting window to null");
            window = null;
        }
        
        FireGC();
        
        Console.WriteLine($"Is the window alive af GC? {windowRef.IsAlive}");
    }

    private static void FireGC()
    {
        Console.WriteLine("Starting GC");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        Console.WriteLine("GC is done!");
    }

    private static void ObserverPatternEvents()
    {
        var person = new OPerson();
        person.FallsIll += CallDoctor;
        
        person.CatchCold();
        
        person.FallsIll -= CallDoctor;
    }

    private static void CallDoctor(object? sender, FallsIllEventArgs args)
    {
        Console.WriteLine($"A doctor has been called to {args.Address}");
    }

    private static void NullObjectPatternExercise()
    {
        var log = new NullLogEx();
        var a = new AccountEx(log);
        a.SomeOperation();
        a.SomeOperation();
    }

    private static void DynamicNullObjectPatternWithProxy()
    {
        var log = NullProxy<ILog>.Create();
        var ba = new SimpleBankAccount(log);
        ba.Deposit(100);
    }

    private static void DynamicNullObjectPattern()
    {
        var log = Null<ILog>.Instance;
        var ba = new SimpleBankAccount(log);
        ba.Deposit(100);
    }

    private static void NullObjectPattern()
    {
        var log = new ConsoleLog();
        // var ba = new SimpleBankAccount(null);
        // ba.Deposit(100);

        var cb = new ContainerBuilder();

        // cb.Register(ctx => new SimpleBankAccount(null));
        
        cb.RegisterType<SimpleBankAccount>();
        
        cb.Register(ctx => ILog.Null).As<ILog>();
        // cb.RegisterType<NullLog>().As<ILog>();
        // cb.RegisterType<ConsoleLog>().As<ILog>();
        // cb.RegisterInstance(log).As<ILog>();
        
        using var container = cb.Build();
        var ba = container.Resolve<SimpleBankAccount>();
        ba.Deposit(100);
    }

    private static void MementoExercise()
    {
        var tokenMachine = new TokenMachine();

        var token1 = new TokenEx(1);
        var token2 = new TokenEx(2);
        var token3 = new TokenEx(3);
        
        var m1 = tokenMachine.AddToken(token1);
        var m2 = tokenMachine.AddToken(token2);
        var m3 = tokenMachine.AddToken(token3);
        var m4 = tokenMachine.AddToken(4);
        var m5 = tokenMachine.AddToken(5);

        tokenMachine.Revert(m2);
    }

    private static void MementoImproved()
    {
        var ba = new LocalBankAccount(100);
        ba.Deposit(50);
        ba.Deposit(25);
        Console.WriteLine(ba);

        ba.Undo();
        Console.WriteLine($"Undo 1: {ba}");
        ba.Undo();
        Console.WriteLine($"Undo 2: {ba}");
        ba.Redo();
        Console.WriteLine($"Redo: {ba}");
    }

    private static void MementoPatterPart1()
    {
        var ba = new LocalBankAccount(100);
        var m1 = ba.Deposit(50); // 150
        var m2 = ba.Deposit(25); // 175
        Console.WriteLine(ba);
        
        ba.Restore(m1);
        Console.WriteLine(ba);
        
        ba.Restore(m2);
        Console.WriteLine(ba);
    }

    private static void MediatorExercise()
    {
        var mediator = new SampleMediator();
        var participant1 = new Participant(mediator);
        var participant2 = new Participant(mediator);
        
        participant1.Say(2);
        participant1.Say(2);
        participant2.Say(4);
    }

    private static async Task MediatRSampleAutoFac()
    {
        var builder = new ContainerBuilder();

        var configuration = MediatRConfigurationBuilder
            .Create(GetMediatorKey(), typeof(Program).Assembly)
            .WithAllOpenGenericHandlerTypesRegistered()
            .Build();

        // this will add all your Request- and Notificationhandler
        // that are located in the same project as your program-class
        builder.RegisterMediatR(configuration);
        
        var container = builder.Build();
        
        var mediator = container.Resolve<IMediator>();
        
        var response = await mediator.Send(new PingCommand());
        Console.WriteLine($"We got a response at {response.Timestamp}");
    }

    private static async Task MediatRSample(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        
        builder.Services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
            cfg.LicenseKey = GetMediatorKey();
        });
        
        builder.Logging.AddFilter("LuckyPennySoftware.MediatR.License", LogLevel.None);

        var app = builder.Build();
        
        var mediator = app.Services.GetRequiredService<IMediator>();

        var response = await mediator.Send(new PingCommand());
        Console.WriteLine($"We got a response at {response.Timestamp}");
    }

    private static string GetMediatorKey()
    {
        return string.Empty;
    }

    private static void MediatorEventBroker()
    {
        var cb = new ContainerBuilder();
        cb.RegisterType<EventBroker>().SingleInstance();
        cb.RegisterType<FootballCouch>();
        cb.Register((c, p) =>
        {
            return new FootballPlayer(c.Resolve<EventBroker>(), p.Named<string>("name"));
        });
        
        using var c = cb.Build();
        var coach = c.Resolve<FootballCouch>();
        var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
        var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));

        player1.Score();
        player1.Score();
        player1.Score(); // Ignored by the coach
        
        player1.AssaultReferee();
        player2.Score();
    }

    private static void MediatorPattern()
    {
        var chatRoom = new ChatRoom();
        var john = new ChatPerson("John");
        var jane = new ChatPerson("Jane");
        
        chatRoom.Join(john);
        chatRoom.Join(jane);
        
        john.Say("Hi");
        jane.Say("oh, hey John");
        
        var simon = new ChatPerson("Simon");
        chatRoom.Join(simon);
        simon.Say("Hi everyone");
        
        jane.PrivateMessage("Simon", "Glad you could join us!");
    }

    private static void IteratorExercise()
    {
        var eight = new Node<int>(8);
        var nine = new Node<int>(9);
        var four = new Node<int>(4, eight, nine);
        var ten = new Node<int>(10);
        var eleven = new Node<int>(11);
        var five = new Node<int>(5, ten, eleven);
        var two = new Node<int>(2, four, five);
        
        var twelve = new Node<int>(12);
        var thirteen = new Node<int>(13);
        var six = new Node<int>(6, twelve, thirteen);
        var fourteen = new Node<int>(14);
        var fifteen = new Node<int>(15);
        var seven = new Node<int>(7, fourteen, fifteen);
        var three = new Node<int>(3, six, seven);
        
        var root = new Node<int>(1, two, three);

        foreach (var i in root.PreOrder)
        {
            Console.WriteLine(i);
        }
    }

    private static void BuildAndDisplayBinaryTreePreOrder()
    {
        var eight = new Node<int>(8);
        var nine = new Node<int>(9);
        var four = new Node<int>(4, eight, nine);
        var ten = new Node<int>(10);
        var eleven = new Node<int>(11);
        var five = new Node<int>(5, ten, eleven);
        var two = new Node<int>(2, four, five);
        
        var twelve = new Node<int>(12);
        var thirteen = new Node<int>(13);
        var six = new Node<int>(6, twelve, thirteen);
        var fourteen = new Node<int>(14);
        var fifteen = new Node<int>(15);
        var seven = new Node<int>(7, fourteen, fifteen);
        var three = new Node<int>(3, six, seven);
        
        var root = new Node<int>(1, two, three);
        var tree = new BinaryTree<int>(root);

        foreach (var node in tree.InPreOrder)
        {
            Console.WriteLine(node.Value);
        }
    }

    private static void ArrayBackedProperties()
    {
        var creature = new GameCreature()
        {
            Strength = 5,
            Agility = 6,
            Intelligence = 10,
        };

        Console.WriteLine(string.Join(",", creature));
    }

    private static void IteratorAndGetEnumerator()
    {
        var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
        var tree = new BinaryTree<int>(root);

        foreach (var node in tree)
        {
            Console.WriteLine(node);
        }
    }

    private static void IteratorMethod()
    {
        //     1
        //    /  \
        //   2    3
        var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
        var tree = new BinaryTree<int>(root);
        Console.WriteLine(string.Join(",", tree.InOrder.Select(x => x.Value)));
    }

    private static void IteratorObjectBinaryTree()
    {
        //     1
        //    /  \
        //   2    3
        
        // In-order: 2,1,3
        // Pre-order: 1,2,3
        // Post-order: 2,3,1

        var root = new Node<int>(1, 
            new Node<int>(2),
            new Node<int>(3));
        
        var it = new InOrderIterator<int>(root);
        while (it.MoveNext())
        {
            Console.Write(it.Current);
            Console.Write(',');
        }
    }

    private static void InterpreterPatternExercise()
    {
        var ep = new ExpressionProcessor();
        ep.Variables.Add('x', 3);
        const string expression = "10-2-x";
        var result = ep.Calculate(expression);
        
        Console.WriteLine($"{expression} = {result}");
    }
    
    
    private static void InterpreterPatternExerciseV2()
    {
        var ep = new ExpressionProcessorV2();
        ep.Variables.Add('x', 3);
        const string expression = "10-2-x";
        var result = ep.Calculate(expression);
        
        Console.WriteLine($"{expression} = {result}");
    }

    private static void InterpreterPattern()
    {
        // https://www.antlr.org/
        // ANTLR (ANother Tool for Language Recognition) is a powerful parser generator for reading, processing, executing, or translating structured text or binary files.
        // It's widely used to build languages, tools, and frameworks. From a grammar, ANTLR generates a parser that can build and walk parse trees.
        
        var input = "(13+4)-(12+1)";
        var tokens = Lexer.Lex(input);

        Console.WriteLine(string.Join("\t", tokens));
        
        var parsed = Parser.Parse(tokens);

        Console.WriteLine($"{input} = {parsed.Value}");
    }


    private static void CommandPatterExercise()
    {
        var account = new Account() { Balance = 100 };
        account.Process(new Command()
        {
            TheAction = Command.Action.Deposit,
            Amount = 100
        });

        Console.WriteLine(account);
    }

    private static void ExecuteMoneyTransfer()
    {
        var from = new BankAccount("Juan");
        from.Deposit(100);
        var to = new BankAccount("Miguel");
        
        var mtc = new MoneyTransferCommand(from, to, 75);
        mtc.Execute();

        Console.WriteLine(from);
        Console.WriteLine(to);
        
        mtc.Undo();
        
        Console.WriteLine(from);
        Console.WriteLine(to);
    }

    private static void CompositeBankAccountCommands()
    {
        var ba = new BankAccount("Juan");
        var deposit = new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100);
        var withdraw = new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 5000);

        var composite = new CompositeBankAccountCommand([deposit, withdraw]);
        composite.Execute();

        Console.WriteLine(ba);
        
        composite.Undo();
        Console.WriteLine(ba);
    }

    private static void CommandPattern()
    {
        var ba = new BankAccount("Juan");
        var commands = new List<BankAccountCommand>
        {
            new(ba, BankAccountCommand.Action.Deposit, 100),
            new(ba, BankAccountCommand.Action.Withdraw, 1000),
        };
        
        commands.ForEach(c => c.Execute());

        Console.WriteLine(ba);

        foreach (var command in Enumerable.Reverse(commands))
        {
            command.Undo();
        }

        Console.WriteLine(ba);
        
    }

    private static void ChainOfResponsibilityExercise()
    {
        var game = new SimpleGame();
        var goblin = new Goblin(game);
        game.Creatures.Add(goblin);
        Console.WriteLine(goblin);

        var goblinKing = new GoblinKing(game);
        game.Creatures.Add(goblinKing);
        Console.WriteLine(goblinKing);
        Console.WriteLine(goblin);
        
        var goblin2 = new Goblin(game);
        game.Creatures.Add(goblin2);
        Console.WriteLine(goblin2);
        
        game.Creatures.Remove(goblinKing);
        Console.WriteLine(goblin);
    }

    private static void BrokerChain()
    {
        var game = new Game();
        var goblin = new SmallCreature(game, "Strong Goblin", 3, 3);

        Console.WriteLine(goblin);
        
        using (new TripleAttackModifier(game, goblin))
        {
            Console.WriteLine(goblin);

            using (new IncrementDefenseModifier(game, goblin, 7))
            {
                Console.WriteLine(goblin);
            }
        }

        Console.WriteLine(goblin);
    }

    private static void ChainOfResponsibility()
    {
        var goblin = new BigCreature("Goblin", 2, 2);
        Console.WriteLine(goblin);

        var root = new CreatureModifier();
        Console.WriteLine("Let's double the goblin's attack");
        root.Add(new DoubleAttackModifier());

        Console.WriteLine("Let's increase the goblin's defense");
        root.Add(new IncreaseDefenseModifier(5));

        Console.WriteLine("Let's not allow new bonuses");
        root.Add(new NoBonusesModifier());
        
        root.Add(new DoubleAttackModifier()); // This will be ignored
        
        root.Handle(goblin);
        Console.WriteLine(goblin);
    }

    private static void BitFragging()
    {
        // BitVector32 bitVector32 = new BitVector32(10);
        // BitArray bitArray = new BitArray(5);
        // var bytes = BitConverter.GetBytes(0b11UL);
        
        var numbers = new[] { 1, 3, 5, 7 };
        var numberOfOps = numbers.Length - 1;
        var limit = 1UL << 2 * numberOfOps;
        
        for (var result = 0; result <= 10; result++)
        {
            for (ulong key = 0UL; key  < limit ; key++)
            {
                var tbs = new TwoBitSet(key);
                var ops = Enumerable.Range(0, numberOfOps)
                    .Select(i => tbs[i])
                    .Cast<Operation>()
                    .ToArray();
                
                var problem = new Problem(numbers, ops);
                if (problem.Eval() == result)
                {
                    var p = new Problem(numbers, ops);
                    Console.WriteLine($"{p} = {result}");
                    break;
                }
            }
        }
    }

    private static void ProtectionProxyExercise()
    {
        var person = new NormalPerson{ Age = 16 };
        var responsiblePerson = new ResponsiblePerson(person);
        responsiblePerson.DrinkAndDrive();
    }

    private static void ProxyViewModel()
    {
        var person = new DeveloperPerson("Juan", "Paulino");
        var viewModel = new DeveloperPersonViewModel(person);

        viewModel.PropertyChanged += (sender, args) =>
        {
            Console.WriteLine("Event");
        };
            
        viewModel.FirstName = "Oscar";
        viewModel.LastName = "Polanco";
        
        Console.WriteLine(person);
    }

    private static void DynamicProxyForLogging()
    {
        // var ba = Log<BankAccount>.As<IBankAccount>();
        // ba.Deposit(100);
        // ba.Withdraw(50);
        // Console.WriteLine(ba);

        var ba = BankAccountProxy.Create();
        ba.Deposit(100);
        ba.Withdraw(50);
        Console.WriteLine(ba);
    }

    private static void CompositeProxyWithArrayBackedProperties()
    {
        var ms = new MasonrySettings();
        ms.All = true;
        Console.WriteLine($"Walls: {ms.Walls} Pillars: {ms.Pillars} Floors: {ms.Floors}");
    }

    private static void CompositeProxy()
    {
        // AoS - Array of Structures
        var monsters = new Monster[100];
        foreach (var monster in monsters)
        {
            monster.X++;
        }
        
        // AOS/SOA duality
        var monsters2 = new Monsters(100); // SoA - Structure of Arrays
        foreach (var monster in monsters2)
        {
            monster.X++;
        }
    }

    private static void ValueProxy()
    {
        Console.WriteLine(10f * 5.Percent());

        var percentage = 2.Percent() + 3.Percent();
        Console.WriteLine(percentage); //5%
    }

    private static void PropertyProxy()
    {
        var sportCarProperty = new Property<SportCar>();
        SportCar car = sportCarProperty;
        Property<SportCar> sportCarPropertyImplicitConversion = car;

        var c = new Creature();
        c.Agility = 10;
        c.Agility = 10;
    }

    private static void ProtectionProxy()
    {
        var driver = new Driver() { Age = 15 };
        var car = new SportCarProxy(driver);
        car.Drive();
    }

    private static void FlyweightWithFactory()
    {
        var threeFactory = new ThreeTypeFactory();
        var forest = new Forest();
        var type = threeFactory.GetType("Roble", "Verde", "Madera");
        
        forest.Add(new Three(type, 0, 0));
        forest.Add(new Three(type, 1, 1));

        Console.WriteLine(forest);
    }

    private static void FlyweightPatternExercise()
    {
        var sentence = new Sentence("hello world");
        sentence[1].Capitalize = true;
        Console.WriteLine(sentence); // writes "hello WORLD"
    }

    private static void FlyweightPattern()
    {
        var ft = new FormattedText("This is a brave new world.");
        ft.Capitalize(10, 15);
        Console.WriteLine(ft);
        
        var bft = new BetterFormattedText("This is a brave new world.");
        bft.GetRange(10, 15).Capitalize = true;
        Console.WriteLine(bft);
    }

    private static void FacadeExercise()
    {
        var magicSquareGenerator = new MagicSquareGenerator();
        var magicSquare = magicSquareGenerator.Generate(3);

        Console.WriteLine("Success");
    }

    private static void DecoratorInDependencyInjection()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<ReportingService>().Named<IReportingService>("reporting");
        
        builder.RegisterDecorator<IReportingService>((context, service) =>
        {
            return new ReportingServiceWithLogging(service);
        }, "reporting");
        
        using var container = builder.Build();
        var reportingServiceDecorator = container.Resolve<IReportingService>();
        reportingServiceDecorator.Report();
        
        var baseReporting = container.ResolveNamed<IReportingService>("reporting");
        baseReporting.Report();
    }

    private static void StaticDecoratorComposition()
    {
        var box = new TransparentStructure<ColoredStructure<Box>>(0.6f);
        Console.WriteLine(box.AsString());
    }

    private static void DynamicDecoratorComposition()
    {
        var box = new Box(1.23f);
        Console.WriteLine(box.AsString());

        var colored1 = new ColoredStructure(box, "Green");
        Console.WriteLine(colored1.AsString());
        
        var transparent1 = new TransparentStructure(colored1, 0.5f);
        Console.WriteLine(transparent1.AsString());
        
        var colored2 = new ColoredStructure(transparent1, "Red");
        Console.WriteLine(colored2.AsString());
        
        var transparent2 = new TransparentStructure(colored2, 0.7f);
        Console.WriteLine(transparent2.AsString());
        
        var transparent3 = new TransparentStructure(transparent2, 0.7f);
        Console.WriteLine(transparent3.AsString());
    }

    private static void HandleMultipleInheritance()
    {
        var drake = new Drake()
        {
            Age = 5
        };

        // Without Extension Methods
        if (drake is IAvian d)
        {
            d.Fly();
        }

        if (drake is IReptile r)
        {
            r.Crawl();
        }
        
        // With Extension Methods
        drake.Crawl();
        drake.Fly();
    }

    private static void DecoratorWithMultipleInheritance()
    {
        var dragon = new Dragon();
        dragon.Weight = 30;
        dragon.Fly();
        dragon.Crawl();
    }

    private static void DecoratorPattern()
    {
        var codeGenerator = new MyStringBuilder();
        codeGenerator.AppendLine("class Foo")
            .AppendLine("{")
            .AppendLine("}");

        Console.WriteLine(codeGenerator);
    }

    private static void AdapterAndDecoratorPattern()
    {
        MyStringBuilder myCodeGen = "Hello";
        myCodeGen += " World";
        Console.WriteLine(myCodeGen);
    }

    private static void CompositePatternExercise()
    {
        var singleValue = new SingleValue() { Value = 6 };
        var manyValues = new ManyValues();
        manyValues.Add(5);
        manyValues.Add(4);

        var values = new List<IValueContainer>();
        values.Add(singleValue);
        values.Add(manyValues);

        var result = values.Sum();
        Console.WriteLine(result);
    }

    private static void EstablishNeuronConnections()
    {
        var neuron1 = new Neuron();
        var neuron2 = new Neuron();
        
        neuron1.ConnectTo(neuron2);

        var layer1 = new NeuronLayer();
        var layer2 = new NeuronLayer();
        
        neuron1.ConnectTo(layer1);
        layer1.ConnectTo(layer2);
    }

    private static void RenderCircleGroup()
    {
        var rasterRenderer = new RasterRenderer();
        var circle = new Circle(rasterRenderer, 30);
        var group = new FigureGroup();
        group.Add(circle);
        
        group.Draw();
    }

    private static void CompositePattern()
    {
        var drawing = new GraphicalObject() { Name = "My Drawing" };
        drawing.Children.Add(new SquareObject() { Color = "Red" });
        drawing.Children.Add(new CircleObject() { Color = "Yellow" });

        var group = new GraphicalObject();
        group.Children.Add(new CircleObject() { Color = "Blue" });
        group.Children.Add(new CircleObject() { Color = "Blue" });
        
        drawing.Children.Add(group);

        Console.WriteLine(drawing);
    }

    private static void BridgePattern()
    {
        // Using containerBuilder for dependency injection
        var cb = new ContainerBuilder();
        cb.RegisterType<VectorRenderer>()
            .As<IRenderer>()
            .SingleInstance();

        cb.Register((c, p) =>
        {
            var renderer = c.Resolve<IRenderer>();
            return new Circle(renderer, p.Positional<float>(0));
        });
        
        using var container = cb.Build();
        
        var circle = container.Resolve<Circle>(new PositionalParameter(0, 5f));
        

        // This is the old way (Manually)
        // IRenderer rasterRenderer = new RasterRenderer();
        // IRenderer vectorRenderer = new VectorRenderer();
        // var circle = new Circle(vectorRenderer, 5);
        
        circle.Draw();
        circle.Resize(2);
        circle.Draw();
    }

    private static void CreateSquareAdapter()
    {
        var square = new Square
        {
            Side = 5
        };

        var adapter = new SquareToRectangleAdapter(square);
    }

    private static async Task AdapterInDependencyInjection()
    {
        var b = new ContainerBuilder();
        b.RegisterType<SaveCommand>().As<ICommand>().WithMetadata("Name", "Save");
        b.RegisterType<OpenCommand>().As<ICommand>().WithMetadata("Name", "Open");

        // b.RegisterType<Button>();
        // b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
        b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
        {
            var name = (string) cmd.Metadata["Name"];
            return new Button(cmd.Value, name);
        });
        
        b.RegisterType<Editor>();

        await using var c = b.Build();
        var editor = c.Resolve<Editor>();
        editor.ClickAll();
        foreach (var button in editor.Buttons)
        {
            button.PrintMe();
        }
    }

    private static void GenericValueAdapter()
    {
        var v = new Vector2i(1, 2);
        v[0] = 0;
        v[1] = 1;

        var vv = new Vector2i(3, 4);

        var result = v + vv;
        
        
        var u = Vector3f.Create(3.5f, 2.2f, 1f);
    }

    private static void AdapterCaching()
    {
        Draw();
        Draw();
    }

    private static readonly List<VectorObject> VectorObjects = new()
    {
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6),
    };
    
    private static void Draw()
    {
        foreach (var vectorObject in VectorObjects)
        {
            foreach (var line in vectorObject)
            {
                var adapter = new LineToPointAdapter(line);
                adapter.ForEach(DrawPoint);
            }
        }
        Console.WriteLine("");
    }
    
    public static void DrawPoint(Point point)
    {
        Console.Write(".");
    }

    private static void SingletonTester()
    {
        var cb = () => SingletonDatabase.Instance;
        var result = IsSingleton(cb);
        Console.WriteLine(result);
    }
    
    public static bool IsSingleton(Func<object> func)
    {
        var result1 = func();
        var result2 = func();
        
        return result1 == result2;
    }

    private static void BuildWallsWithContexts()
    {
        var building = new Building();
        
        using (var ctx1 = new BuildingContext(3000)) // gnd 3000
        {
            building.Walls.Add(new Wall(Point.Origin, Point.Factory.CreateNewCartesianPoint(5000, 0)));
            building.Walls.Add(new Wall(Point.Origin, Point.Factory.CreateNewCartesianPoint(0, 4000)));

            using (var ctx2 = new BuildingContext(3500)) // 1st 3500
            {
                building.Walls.Add(new Wall(Point.Origin, Point.Factory.CreateNewCartesianPoint(6000, 0)));
                building.Walls.Add(new Wall(Point.Origin, Point.Factory.CreateNewCartesianPoint(0, 4000)));
            }
            
            // gnd 3000
            building.Walls.Add(new Wall(Point.Origin, Point.Factory.CreateNewCartesianPoint(5000, 4000)));
        }

        Console.WriteLine(building);
    }

    private static void ExecutePerThreadSingletonTasks()
    {
        var t1 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"t1: " + PerThreadSingleton.Instance.Id);
        });
        
        var t2 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"t2: " + PerThreadSingleton.Instance.Id);
            Console.WriteLine($"t2: " + PerThreadSingleton.Instance.Id);
        });
        
        Task.WaitAll(t1, t2);
    }

    private static void SingletonMonoState()
    {
        var ceo = new Ceo("Juan", 37);
        var ceo2 = new Ceo("Luis", 35);

        Console.WriteLine(ceo);
        Console.WriteLine(ceo2);
    }

    private static void SingletonPattern()
    {
        var db = SingletonDatabase.Instance;
        var city = "New York";
        var population = db.GetPopulation(city);
        Console.WriteLine($"The population of {city} is {population}");
    }

    private static void CreateAndDisplayLines()
    {
        var line = new Line
        {
            Start = Point.Origin,
            End = Point.Factory.CreateNewCartesianPoint(10, 10)
        };

        var line2 = line.DeepCopy();
        line2.Start = Point.Factory.CreateNewCartesianPoint(100, 100);
        line2.End = Point.Factory.CreateNewCartesianPoint(200, 200);

        Console.WriteLine(line);
        Console.WriteLine(line2);
    }

    private static void DeepCopyWithXmlSerialization()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.CloneWithXml();
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }
    
    private static void DeepCopyWithJsonSerialization()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.CloneWithSerialization();
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }
    
    private static void DeepCopyWithInterface()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.DeepClone();
        var person2 = employee1.DeepClone<Person>();
        person2.FirstName = "Antonia";
        person2.MiddleName = "";
        person2.LastName = "Carpio";
        person2.Street = "Street";
        person2.City = "City";
        person2.State = "State";
        person2.ZipCode = "ZipCode";
        person2.Latitude = 1;
        person2.Longitude = 2;
        person2.Nicknames[0] = "antonia";
        person2.Nicknames[1] = "carpio";
        person2.ContactInfo.Email = "antonia@gmail.com";
        person2.ContactInfo.Facebook = "antonia";
        
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
        Console.WriteLine(person2);
    }

    private static void DeepCopyAndInheritanceWithCopyConstructor()
    {
        var employee1 = new Employee()
        {
            FirstName = "Juan",
            MiddleName = "Miguel",
            LastName = "Paulino Carpio",
            Position = "Software Engineer",
            Company = "Company",
            Salary = 1000000,
            Responsibilities = ["Develop", "Test"],
            Nicknames = ["juanmiguel431", "carpio"],
            Street = "Amparo Decena",
            City = "Villa Carmen",
            State = "Santo Domingo Este",
            ZipCode = "10473",
            Latitude = 123,
            Longitude = 456,
            ContactInfo = new ()
            {
                Email = "juanmiguel431@gmail.com",
                Phone = "8298205436",
                Facebook = "juanmiguel431"
            }
        };
        
        var employee2 = employee1.DeepCopy();
        employee2.FirstName = "Oscar";
        employee2.MiddleName = "Ivan";
        employee2.LastName = "Polanco";
        employee2.Street = "Doña Emma Balaguer";
        employee2.City = "Villa Carmen";
        employee2.State = "Santo Domingo Este";
        employee2.ZipCode = "10473";
        employee2.Latitude = 963;
        employee2.Longitude = 852;
        employee2.Company = "Altice";
        employee2.Salary = 45000;
        employee2.Position = "Seller";
        employee2.Responsibilities[0] = "Sell";
        employee2.Responsibilities[1] = "Bey";
        employee2.Nicknames[0] = "ivanpolanco";
        employee2.Nicknames[1] = "polanco";
        employee2.ContactInfo.Email = "ivanpolanco@gmail.com";
        employee2.ContactInfo.Facebook = "ivanpolanco";
        

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }

    private static void DeepCopyMethod()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        var person2 = person1.DeepCopy();
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        person2.ContactInfo.Facebook = "luimiguel424";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void CopyConstructor()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        var person2 = new Person(person1);
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        person2.ContactInfo.Facebook = "luimiguel424";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void PrototypePatternTheProblem()
    {
        var person1 = new Person("Juan Miguel", "Paulino Carpio", new ContactInfo("juanmiguel431@gmail.com", "8298205436", "juanmiguel431"));
        
        var person2 = person1.Clone() as Person;
        person2.FirstName = "Luigi";
        person2.ContactInfo.Email = "luimiguel424@gmail.com";
        person2.ContactInfo.Phone = "809256619";
        
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    private static void AbstractFactoryPattern()
    {
        var hotDrinkMachine = new HotDrinkMachine();
        var hotDrink = hotDrinkMachine.MakeDrink(DrinkType.Coffee, 100);
        hotDrink.Consume();
    }

    private static void BulkReplacementWithFactoryClass()
    {
        var factory2 = new ReplaceableThemeFactory();
        var magicTheme = factory2.CreateTheme(true);
        Console.WriteLine(magicTheme.Value.BrgColor);
        factory2.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value.BrgColor);
    }

    private static void GenerateThemesWithFactory()
    {
        var factory = new TrackingThemeFactory();
        var theme1 = factory.CreateTheme(false);
        var theme2 = factory.CreateTheme(true);

        Console.WriteLine(factory.Info);
    }

    private static void ClassFactoryPattern()
    {
        var point = Point.Factory.CreateNewPolarPoint(1.0, Math.PI / 2);

        Console.WriteLine(point);
    }
    
    private static void FactoryPattern()
    {
        var point = Point.Factory.CreateNewPolarPoint(1.0, Math.PI / 2);

        Console.WriteLine(point);
    }

    private static void BuilderPatternExercise()
    {
        var codeBuilder = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");

        Console.WriteLine(codeBuilder);
    }

    private static void CreatePersonWithFacetedBuilder()
    {
        Person person = Person.PersonFacetedBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Location
                .SetLatitude(1.5f)
                .SetLongitude(-15.2f)
            .Address
                .SetStreet("1822 Seward Ave.")
                .SetCity("Bronx")
                .SetState("New York")
                .SetZipCode("10473");
        
        Console.WriteLine(person);
    }

    private static void FunctionalBuilder()
    {
        var person = Person.FunctionalBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Build();
        
        Console.WriteLine(person);

        var employee = Employee.FunctionalBuilder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .SetCompany("Company")
            .SetPosition("Developer")
            .Build();

        Console.WriteLine(employee);
    }

    private static void StepwiseBuilder()
    {
        var car = Car.Builder()
            .OfType(CarType.Sedan)
            .WheelSize(15)
            .Build();

        Console.WriteLine(car);
    }

    private static void CreateAndDisplayPersonAndEmployee()
    {
        var person = Person.Builder()
            .SetFirstName("Juan")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .Build();

        Console.WriteLine(person);
        
        var employee = Employee.Builder()
            .SetFirstName("Juan")
            .SetPosition("Software Engineer")
            .SetMiddleName("Miguel")
            .SetLastName("Paulino Carpio")
            .SetCompany("Company")
            .Build();

        Console.WriteLine(employee);
    }

    private static void GenerateHtmlOutput()
    {
        var hello = "Hello";
        var sb = new StringBuilder();
        sb.Append("<b>");
        sb.Append(hello);
        sb.Append("</b>");
        Console.WriteLine(sb);

        var words = new [] {"Hello", "World"};
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.AppendFormat("<li>{0}</li>", word);
        }
        sb.Append("</ul>");
        Console.WriteLine(sb);

        var root = new HtmlBuilder("html");
        var body = root.AddChild("body");
        body.AddChild("h1", "Hello World");
        body.AddChild("p", "This is a paragraph");
        var li = body.AddChild("ul");
        li.AddChild("li", "Hello");
        li.AddChild("li", "World");
        Console.WriteLine(root);
    }

    private static void CreateRelationshipsForResearch()
    {
        var parent = new Person() { FirstName = "John" };
        var child1 = new Person() { FirstName = "Chris" };
        var child2 = new Person() { FirstName = "Mary" };
        
        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);
        
        var research = new Research(relationships);
        research.PrintAllChildrenOf("John");
    }

    private static void OldFashionedPrinter()
    {
        var oldFashionedPrinter = new OldFashionedPrinter();
        oldFashionedPrinter.Print(); // It can only print
    }

    private static void ShapesAreaCalculation()
    {
        var rec = new Rectangle()
        {
            Height = 3,
            Width = 6,
        };
        Console.WriteLine($"{rec} has area {rec.GetArea()}");

        Shape sq = new Square()
        {
            Side = 5
        };
        
        Console.WriteLine($"{sq} has area {sq.GetArea()}");
    }

    private static void CreateAndFilterProducts()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        var products = new[] { apple, tree, house };

        var filter = new ProductFilter();
        Console.WriteLine("Green products (old):");
        foreach (var product in filter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($" - {product.Name} is Green");
        }


        var betterFilter = new BetterFilter();
        var greenProducts = betterFilter.Filter(products, new ColorSpecification(Color.Green));
        Console.WriteLine("Green products (new):");
        foreach (var product in greenProducts)
        {
            Console.WriteLine($" - {product.Name} is Green");
        }

        Console.WriteLine("Large Blue products:");
        foreach (var product in betterFilter.Filter(
                     products,
                     new AndSpecification<Product>(
                         new SizeSpecification(Size.Large),
                         new ColorSpecification(Color.Blue)
                     )))
        {
            Console.WriteLine($" - {product.Name} is Large and Blue");
        }
    }

    private static void CreateAndOpenJournalFile()
    {
        var journal = new Journal();
        journal.AddEntry("I cried today.");
        journal.AddEntry("I ate a banana.");

        var persistence = new Persistence();

        var tempPath = Path.GetTempPath();
        var fileName = tempPath + "journal.txt";
        persistence.SaveToFile(journal, fileName, true);

        var psi = new ProcessStartInfo
        {
            FileName = fileName,
            UseShellExecute = true
        };

        Process.Start(psi);
    }
}