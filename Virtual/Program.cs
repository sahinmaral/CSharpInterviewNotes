internal class Program{
	private static void Main(string[] args){
		 MSSQLDatabaseService service = new MSSQLDatabaseService("99");
		 service.connectToDb();
		 Console.WriteLine(service.Port);
		
		 OracleDatabaseService service2 = new OracleDatabaseService("98");
		 service2.connectToDb();
		 Console.WriteLine(service2.Port);
	}
}

 public class MSSQLDatabaseService : DatabaseService{
	 public MSSQLDatabaseService(string port):base(port){
		
	} 
	 
	 public override void connectToDb(){
		 Console.WriteLine("Connected to mssql");
	 }
	
	 public override string getConnectionPort(){
			return Port;
	}
 }

public class OracleDatabaseService : DatabaseService{
	
	public OracleDatabaseService(string port):base(port){
		
	} 
	
	public override string getConnectionPort(){
			return Port;
	}
	
}

public abstract class DatabaseService{
	
	public string Port {get;}
	
	public DatabaseService(string port){
		Port = port;
	}
	
	public virtual void connectToDb(){
		Console.WriteLine("Connected to db");
	}
	
	public abstract string getConnectionPort();
}

