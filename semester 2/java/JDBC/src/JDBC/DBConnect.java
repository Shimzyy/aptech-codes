package JDBC;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
public class DBConnect {
	
	
	void connectAndInsert(String id, String name, String age, String state) 
	{
		try 
		{
			 Class.forName("com.mysql.jdbc.Driver");
	          Connection conn =DriverManager.getConnection("jdbc:mysql://localhost:3306/studentDB", "root", "");
	          String query="insert into studentable(id,name,age,state)values(?,?,?,?)";
	          
	          PreparedStatement preparetstmt= conn.prepareStatement(query);
	          preparetstmt.setString(1,id);
	          preparetstmt.setString(2,name);
	          preparetstmt.setString(3,age);
	          preparetstmt.setString(4,state);     
	          int i=preparetstmt.executeUpdate();
	          if(i>=1)
	          {
	              System.out.println("data is inserted successfully");
	          }
	          else{
	              System.out.println("data not inserted");
	          }
		}
		
		catch (Exception e) 
		{
			
			System.out.println(e);
		}
		
	}

}
