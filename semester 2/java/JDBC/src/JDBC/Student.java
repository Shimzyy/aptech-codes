package JDBC;
import java.util.Scanner;

public class Student {
	Scanner getInput = new Scanner(System.in);
	
	String id;
	String name;
	String age;
	String state;
	
	
	void getData()
	{
		System.out.println("Enter Student I.D: ");
		id=getInput.next();
		System.out.println("Enter Student Name: ");
		name=getInput.next();
		System.out.println("Enter Student age: ");
		age=getInput.next();
		System.out.println("Enter Student state: ");
		state=getInput.next();
		
		DBConnect dbc = new DBConnect();
		
	}
	
}

