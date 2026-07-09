using Serilog;

namespace _4_Log;


// Log => Env hamisinda proseslerin gedisati haqqinda Proqramist ucun lazimi olan melumatlardir

// Audit Finding

// Loglama etmek ucun meshur olan kitabxanalar

// Serilog => Yeni texnologiya + Elastic Kibana 
// NLog ( WebForm, Aspx )



public class Program
{
    static void Main(string[] args)
    {

        // using var log = new LoggerConfiguration().CreateLogger();
        // 
        // log.Information("Hello, Serilog!");
        // log.Debug("Kamran Karimzada");
        // log.Error("Xayyam Qasimov");



        //using var log = new LoggerConfiguration()
        //     .WriteTo.Console()
        //     .WriteTo.File("log.txt")          
        //     .CreateLogger();


        //log.Information("Hello, Serilog!");
        //log.Debug("Kamran Karimzada");
        //log.Error("Xayyam Qasimov");

        //Console.WriteLine("Success log");


        // -----------------------------------------

        var log = new LoggerConfiguration()
            .Enrich.WithEnvironmentName()
            .Enrich.WithThreadId()
            .WriteTo.Console(outputTemplate:
                "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}] " +
                "[{Level:u3}] " +
                "[Env:{EnvironmentName}] " +
                "[Thread:{ThreadId}] " +
                "[{SourceContext}] " +
                "{Message:lj}{NewLine}{Exception}")
            .WriteTo.File(
                "logs/log-.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 30,
                shared: true,
                outputTemplate:
                "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}] " +
                "[{Level:u3}] " +
                "[Env:{EnvironmentName}] " +
                "[Thread:{ThreadId}] " +
                "{Message:lj}{NewLine}{Exception}")
            .CreateLogger();


        log.Information("Application Started");


        log.Information("Application continuee");


        log.Error("Error occured");


        log.Information("Application successfully ended");

        var newTask = Task.Run(() =>
         {
             log.Information("New thread created");


         });


        newTask.Wait();

    }
}
