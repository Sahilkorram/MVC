namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string constring=@"server=192.168.10.150;port=3306;user=dac22;password=welcome;database=dac22";
    public static List<Employee> getalllist()
    {
        List<Employee>list=new List<Employee>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=constring;
        string query="select * from Employee";
        conn.Open();
        try{
            MySqlCommand command=new MySqlCommand(query,conn);
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read()){
                int eid=int.Parse(reader[0].ToString());
                string ename=reader[1].ToString();
                string edate=reader[2].ToString();
                string edescription=reader[3].ToString();
                int ehours=int.Parse(reader[4].ToString());
                string estatus=reader[5].ToString();
                Employee e=new Employee{
                    eid=eid,
                    ename=ename,
                    edate=edate,
                    edescription=edescription,
                    ehours=ehours,
                    estatus=estatus

                };
                list.Add(e);
            }   
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }
    finally{
        conn.Close();
    }
    return list;
}

    public static bool updateEmp(int eid,string ename,string edate,string edescription,int ehours,string estatus)
    {
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString= constring;
        con.Open();
        string query = "Update Employees set ename=@ename,edate=@edate,edescription=@edescription,ehours=@ehours,estatus=@estatus where eid=@eid";
        
        try{
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("@ename",ename);
            cmd.Parameters.AddWithValue("@edate",edate);
            cmd.Parameters.AddWithValue("@edescription",edescription);
            cmd.Parameters.AddWithValue("@ehours",ehours);
            cmd.Parameters.AddWithValue("@estatus",estatus);
            cmd.Parameters.AddWithValue("@eid",eid);
            int n=cmd.ExecuteNonQuery();
            if(n>0){
                return true;
            }
        }
        catch(Exception e){
                Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return false;
    }
    }

