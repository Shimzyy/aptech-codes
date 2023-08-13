import java.rmi.*;
import java.rmi.registry.*;


public class RMIServer{
	
	public static void main(String args[]){
		
		
		try{
			
			Adder stub=new AdderRemote();
			LocateRegistry.createRegistry(5000);
			Naming.rebind("rmi://localhost:5000/kamal", stub);
			System.err.println("server ready");
			System.err.println("server up");
			System.err.println("call RMI method");	
		}
		
		
		catch(Exception e)
		{
			System.out.println(e);
		}		
	}
	
	
	
}