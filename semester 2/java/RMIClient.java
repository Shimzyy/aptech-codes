import java.rmi.*;
import java.util.Scanner;

public class RMIClient{

public static void main(String args[]){
	
	try{
		
		Scanner input = new Scanner(System.in);
		Adder stub = (Adder)Naming.lookup("rmi://localhost:5000/kamal");
		
		
		System.out.println("Enter numer 1: ");
		int fn = input.nextInt();
		
		System.out.println("Enter numer 2: ");
		int sn = input.nextInt();
		
		
		System.out.println(stub.add(fn,sn));	
	}

catch (Exception e){}
}


}